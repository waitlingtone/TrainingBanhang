//using Lambda.AutoService;
using Lambda.CoreService;
using Lambda.DynamicLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ClientModel
{
    public class FactoryLocal
    {
        static IDataService proxy;
        public static IDataService CreateProxy()
        {
            if (proxy == null)
            {
                //proxy = new Lambda.AutoService.DataService();
                var type = DynaInvoke.GetType("DataService", "Lambda.AutoService.dll");
                proxy = Activator.CreateInstance(type) as IDataService;
                ModelCore.MakeToken(proxy);
                ModelCore.Count++;
            }
            return proxy;
        }
    }
}
