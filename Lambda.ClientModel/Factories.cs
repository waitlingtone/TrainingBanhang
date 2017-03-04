using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.ClientModel
{
    public class Factories
    {
        private static readonly object syncRoot = new Object();
        public static IDataService Proxy
        {
            get
            {
                lock (syncRoot)
                {
                    if (ConfigService.Instance.SelectModelType == ModelType.Local)
                        return FactoryLocal.CreateProxy();
                    return FactoryService.CreateProxy();
                }
            }
        }
    }
}
