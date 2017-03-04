﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Framework
{
    public static class Extension
    {
        /// <summary>
        /// public class Car
        /// {
        ///  public string Make{ get; set; }
        ///  public string Model{ get; set; }
        ///  public int Year{ get; set; }
        ///  public string Color{ get; set; }
        /// }
        /// 
        /// var nissanCars = from c in dataTable.AsEnumerable<Car>()
        /// where c.Make == "Nissan"
        /// select c;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IEnumerable<T> AsEnumerable<T>(this DataTable table) where T : new()
        {
            //check for table availability
            if (table == null)
                throw new NullReferenceException("DataTable");

            //grab property length
            int propertiesLength = typeof(T).GetProperties().Length;

            //if no properties stop
            if (propertiesLength == 0)
                throw new NullReferenceException("Properties");

            //create list to hold object T values
            var objList = new List<T>();

            //iterate thru rows of the datatable
            foreach (DataRow row in table.Rows)
            {
                //create a new instance of our object T
                var obj = new T();

                //grab properties of object T
                PropertyInfo[] objProperties = obj.GetType().GetProperties();

                //iterate thru and populate property values
                for (int i = 0; i < propertiesLength; i++)
                {
                    //grab current property
                    PropertyInfo property = objProperties[i];

                    //check datatable to see if datacolumn exists
                    if (table.Columns.Contains(property.Name))
                    {
                        //get row cell value
                        object objValue = row[property.Name];

                        //check for nullable property type and handle
                        var propertyType = property.PropertyType;
                        if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            propertyType = propertyType.GetGenericArguments()[0];

                        //set property value
                        objProperties[i].SetValue(obj, Convert.ChangeType(objValue, propertyType, System.Globalization.CultureInfo.CurrentCulture), null);
                    }
                }

                //add to obj list
                objList.Add(obj);
            }

            return objList;
        }
    }
}
