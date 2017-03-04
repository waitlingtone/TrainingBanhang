using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

/*
 * 03-05-2012 - veg - Added GetProperty().
 * 04-05-2012 - veg - Disabled slow code.
 *                  - Added constructorArgs to the public methods to allow paremetrized constructors.
 *                  - Added Documentation.
 *                  - Renamed methods
 *                  - Made most methods private.
 *                  - Altered signatures of method to use Generics 
 *                  - Swapped HashTables for types Dictionaries.
 *                  - Removed unneccesary typecast.
 *                  
 * TODO - Add BindingFlags support other than BindingFlags.Default.
 * TODO - Look into params keyword.
 */

namespace Lambda.DynamicLoad
{
    /// <summary>
    /// A class that allows you to 
    /// 1) call to methods and 
    /// 2) get/set properties 
    /// on a dynamically loaded assembly.
    /// </summary>
    public class DynaInvoke
    {
        public static T CreateInstance<T>(string ClassName, string assemblyFile = null, params Object[] args)
        {
            Type type = DynaInvoke.GetType(ClassName, assemblyFile);
            var obj = (T)Activator.CreateInstance(type, args);
            return obj;
        }

        public static Type GetType(string ClassName, string assemblyFile = null)
        {
            if (!string.IsNullOrEmpty(ClassName))
                ClassName = ClassName.Trim();
            if (!string.IsNullOrEmpty(assemblyFile))
                assemblyFile = assemblyFile.Trim();

            if (string.IsNullOrEmpty(ClassName))
                return null;

            if (!string.IsNullOrEmpty(assemblyFile))
            {
                foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (a.Location == Path.GetFullPath(assemblyFile))
                    {
                        foreach (Type type in a.GetTypes())
                        {
                            if (type.FullName == ClassName || type.Name == ClassName)
                            {
                                return type;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    foreach (Type type in a.GetTypes())
                    {
                        if (type.FullName == ClassName || type.Name == ClassName)
                        {
                            return type;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(assemblyFile))
            {
                try
                {
                    if (File.Exists(assemblyFile))
                    {
                        var assembly = Assembly.LoadFrom(assemblyFile);
                        foreach (Type type in assembly.GetTypes())
                        {
                            if (type.FullName == ClassName || type.Name == ClassName)
                            {
                                return type;
                            }
                        }
                    }
                }
                catch { }
            }
            return null;
        }

        public static T CallMethod<T>(string assemblyFile, string ClassName, string MethodName, bool isStatic = true, Object[] methodArgs = null, Object[] constructorArgs = null)
        {
            var type = GetType(ClassName, assemblyFile);
            if (type == null)
                throw new Exception(string.Format("Không tồn tại class {0}, hoặc dll {1}", ClassName, assemblyFile));
            if (type.IsClass == true)
            {
                object classInstance = null;
                if (isStatic == false)
                {
                    if (constructorArgs == null)
                        classInstance = Activator.CreateInstance(type);
                    else
                        classInstance = Activator.CreateInstance(type, constructorArgs);
                }
                // Dynamically Invoke the method
                object Result = type.InvokeMember(MethodName,
                    BindingFlags.Default | BindingFlags.InvokeMethod,
                        null,
                        classInstance,
                        methodArgs);
                if (classInstance is IDisposable)
                {
                    var dis = classInstance as IDisposable;
                    dis.Dispose();
                }
                GC.Collect(2);

                return (T)Result;
            }
            throw (new System.Exception("could not invoke method"));
        }
        public static void CallMethod(string assemblyFile, string ClassName, string MethodName, bool isStatic = true, Object[] methodArgs = null, Object[] constructorArgs = null)
        {
            CallMethod<Object>(assemblyFile, ClassName, MethodName, isStatic, methodArgs, constructorArgs);
        }

        public static T CallMethod<T>(Object classInstance, Type type, string MethodName, Object[] methodArgs = null)
        {
            if (type == null && classInstance != null)
            {
                type = classInstance.GetType();
            }
            object Result = type.InvokeMember(MethodName,
                   BindingFlags.Default | BindingFlags.InvokeMethod,
                       null,
                       classInstance,
                       methodArgs);
            return (T)Result;
        }
        public static void CallMethod(Object classInstance, Type type, string MethodName, Object[] methodArgs = null)
        {
            CallMethod<Object>(classInstance, type, MethodName, methodArgs);
        }

        public static T SetProperty<T>(Object classInstance, string PropName, T arg)
        {
            // Dynamically Invoke the method
            PropertyInfo pi = classInstance.GetType().GetProperty(PropName);
            pi.SetValue(classInstance, (T)arg, new Object[] { });

            return (T)(pi.GetValue(classInstance, new Object[] { }));
        }
        public static T GetProperty<T>(Object classInstance, string PropName)
        {
            // Dynamically Get a Property Value
            PropertyInfo pi = classInstance.GetType().GetProperty(PropName);

            return (T)(pi.GetValue(classInstance, new Object[] { }));
        }

        /// <summary>
        /// This way of invoking a function is slower when making multiple calls
        /// because the assembly is being instantiated each time.
        /// But this code is clearer as to what is going on
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblyFile"></param>
        /// <param name="ClassName"></param>
        /// <param name="MethodName"></param>
        /// <param name="constructorArgs"></param>
        /// <param name="methodArgs"></param>
        /// <returns></returns>
        public static T CallMethodSlow<T>(string assemblyFile, string ClassName, string MethodName, bool isStatic = true, Object[] constructorArgs = null, Object[] methodArgs = null)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyFile);

            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass == true)
                {
                    if (type.FullName.EndsWith("." + ClassName))
                    {
                        object classInstance = null;
                        if (isStatic == false)
                        {
                            if (constructorArgs == null)
                                classInstance = Activator.CreateInstance(type);
                            else
                                classInstance = Activator.CreateInstance(type, constructorArgs);
                        }
                        // Dynamically Invoke the method
                        object Result = type.InvokeMember(MethodName,
                            BindingFlags.Default | BindingFlags.InvokeMethod,
                                null,
                                classInstance,
                                methodArgs);
                        return (T)Result;
                    }
                }
            }

            throw (new System.Exception("could not invoke method"));
        }

        /*
                /// <summary>
                /// Now do it the efficient way by holding references to the assembly 
                /// and the class this is an inner class which holds the class instance info
                /// </summary>
                internal class DynaClassInfo
                {
                    public Type type;
                    public Object classInstance;

                    public DynaClassInfo()
                    {
                    }

                    public DynaClassInfo(Type t, Object c)
                    {
                        type = t;
                        classInstance = c;
                    }
                }

                private static Dictionary<String, Assembly> AssemblyReferences = new Dictionary<String, Assembly>();
                private static Dictionary<String, DynaClassInfo> ClassReferences = new Dictionary<String, DynaClassInfo>();

                internal static DynaClassInfo GetClassReference(string assemblyFile, string ClassName, Object[] constructorArgs = null)
                {
                    if (PreLoadAssembly(assemblyFile, ClassName, constructorArgs))
                    {
                        return (ClassReferences[assemblyFile]);
                    }
                    return null;
                }

                /// <summary>
                /// Preload an Assembly
                /// </summary>
                /// <param name="assemblyFile">The Filename of the Assembly</param>
                /// <param name="ClassName">The Classname to instantiate</param>
                /// <param name="constructorArgs">Constructor Parameters (or null)</param>
                /// <returns>true if succeeeded</returns>
                public static Boolean PreLoadAssembly(string assemblyFile, string ClassName, Object[] constructorArgs = null)
                {
                    if (ClassReferences.ContainsKey(assemblyFile) == false)
                    {
                        Assembly assembly;
                        if (AssemblyReferences.ContainsKey(assemblyFile) == false)
                        {
                            AssemblyReferences.Add(assemblyFile,
                                  assembly = Assembly.LoadFrom(assemblyFile));
                        }
                        else
                            assembly = AssemblyReferences[assemblyFile];

                        // Walk through each type in the assembly
                        foreach (Type type in assembly.GetTypes())
                        {
                            if (type.IsClass == true)
                            {
                                // Doing it this way means that you don't have
                                // to specify the full namespace and class (just the class)

                                if (type.FullName.EndsWith("." + ClassName))
                                {
                                    try
                                    {
                                        DynaClassInfo ci = new DynaClassInfo(type,
                                                           Activator.CreateInstance(type, constructorArgs));
                                        ClassReferences.Add(assemblyFile, ci);
                                    }
                                    catch (Exception e)
                                    {
                                        Debug.WriteLine(e.Message);
                                    }
                                }
                            }
                        }
                    }

                    return ClassReferences.ContainsKey(assemblyFile);
                }

                private static T CallMethod<T>(DynaClassInfo classInfo,
                                     string MethodName, Object[] methodArgs)
                {
                    // Dynamically Invoke the method
                    Object Result = classInfo.type.InvokeMember(MethodName,
                      BindingFlags.Default | BindingFlags.InvokeMethod,
                           null,
                           classInfo.classInstance,
                           methodArgs);
                    return (T)Result;
                }

                private static T SetProperty<T>(DynaClassInfo ci, string PropName, T arg)
                {
                    // Dynamically Invoke the method
                    PropertyInfo pi = ci.type.GetProperty(PropName);
                    pi.SetValue(ci.classInstance, (T)arg, new Object[] { });

                    return (T)(pi.GetValue(ci.classInstance, new Object[] { }));
                }

                private static T GetProperty<T>(DynaClassInfo classInfo, string PropName)
                {
                    // Dynamically Get a Property Value
                    PropertyInfo pi = classInfo.type.GetProperty(PropName);

                    return (T)(pi.GetValue(classInfo.classInstance, new Object[] { }));
                }

                // --- these is the method that you invoke ------------

                /// <summary>
                /// Call a Generic tgyped Method on an (cached) Assembly.
                /// </summary>
                /// <typeparam name="T">The return Type</typeparam>
                /// <param name="assemblyFile">The Filename of the Assembly</param>
                /// <param name="ClassName">The Classname to instantiate</param>
                /// <param name="MethodName">The Method name to invoke</param>
                /// <param name="methodArgs">Method Parameters</param>
                /// <param name="constructorArgs">Constructor Parameters (or null)</param>
                /// <returns>The method result if any</returns>
                public static T CallMethod<T>(String assemblyFile, String ClassName, String MethodName, Object[] methodArgs, Object[] constructorArgs = null)
                {
                    DynaClassInfo ci = GetClassReference(assemblyFile, ClassName, constructorArgs);

                    return CallMethod<T>(ci, MethodName, methodArgs);
                }

                /// <summary>
                /// Call a Method on an (cached) Assembly.
                /// </summary>
                /// <param name="assemblyFile">The Filename of the Assembly</param>
                /// <param name="ClassName">The Classname to instantiate</param>
                /// <param name="MethodName">The Method name to invoke</param>
                /// <param name="methodArgs">Method Parameters</param>
                /// <param name="constructorArgs">Constructor Parameters (or null)</param>
                public static void CallMethod(String assemblyFile, String ClassName, String MethodName, Object[] methodArgs, Object[] constructorArgs = null)
                {
                    DynaClassInfo ci = GetClassReference(assemblyFile, ClassName, constructorArgs);

                    CallMethod<Object>(ci, MethodName, methodArgs);
                }

                /// <summary>
                /// Set a Property value on an (cached) Assembly.
                /// </summary>
                /// <typeparam name="T">The Property Type</typeparam>
                /// <param name="assemblyFile">The Filename of the Assembly</param>
                /// <param name="ClassName">The Classname to instantiate</param>
                /// <param name="PropName">The Property to set</param>
                /// <param name="pArg">Property Value</param>
                /// <param name="constructorArgs">Constructor Parameters (or null)</param>
                /// <returns>The (new) Property Value</returns>
                public static T SetProperty<T>(String assemblyFile, String ClassName, String PropName, T pArg, Object[] constructorArgs = null)
                {
                    DynaClassInfo classInfo = GetClassReference(assemblyFile, ClassName, constructorArgs);

                    return SetProperty<T>(classInfo, PropName, pArg);
                }

                /// <summary>
                /// Return a Property value of an (cached) Assembly.
                /// </summary>
                /// <typeparam name="T">The Property Type</typeparam>
                /// <param name="assemblyFile">The Filename of the Assembly</param>
                /// <param name="ClassName">The Classname to instantiate</param>
                /// <param name="PropName">The Property to set</param>
                /// <param name="constructorArgs">Constructor Parameters (or null)</param>
                /// <returns>The Property Value</returns>
                public static T GetProperty<T>(String assemblyFile, String ClassName, String PropName, Object[] constructorArgs = null)
                {
                    DynaClassInfo ci = GetClassReference(assemblyFile, ClassName, constructorArgs);

                    return GetProperty<T>(ci, PropName);
                }
         * */
    }
}

////Arguments for Class Constructor. If you want to use default class constructor w/o any arguments just leave the array empty like this Object[] classConstructorArgs = {};
//Object[] classConstructorArgs = {@"OneArgForClassConstructor"};

//Object[] methodArgs = {1, "2", 3.0};

//Object Result = DynaInvoke.InvokeMethodSlow("c:\FullPathToDll.DLL", 
//                                            "ClassName",
//                                            "MethodName",
//                                            classConstructorArgs,
//                                            methodArgs);


//Just a suggestion but:
// in the signature of your InvokeMethodSlow method, declare the 'args' parameter as 'params' so that users can either pass an already created object array or variable length parameters to the function that will in turn be passed to the dynamic method.

// public static Object InvokeMethodSlow(string assemblyFile, string ClassName, string MethodName, params Object[] args)


//string FullTypeName = assemblyFile + "." + ClassName
// Type type=TheAssembly.GetType(FullTypeName);

// creates the type object directly without having to walk the types in the assembly 


