using Lambda.BusinessObject;
using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.DataObject
{
    public class AutoExecute
    {
        public static List<AutoObject> ExecuteGetData(Request request)
        {
            if (request.DataItem != null && !string.IsNullOrEmpty(request.DataItem.KeyService))
            {
                return ExecuteGetDataFromAssembly(request);
            }
            return AutoDao.ExecuteQuery(request);
        }
        public static List<AutoObject> ExecuteGetDataFromAssembly(Request request)
        {
            try
            {
                var serviceItem = GetServiceItem(request);
                return Lambda.DynamicLoad.DynaInvoke.CallMethod<List<AutoObject>>(serviceItem.AssemblyFile, serviceItem.ClassName, serviceItem.MethodName, serviceItem.IsStatic, new object[] { request });
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw ex.InnerException;
                throw ex;
            }
        }

        public static int ExecuteSetData(Request request)
        {
            if (request.DataItem != null && !string.IsNullOrEmpty(request.DataItem.KeyService))
            {
                return ExecuteSetDataFromAssembly(request);
            }
            return AutoDao.ExeNonQuery(request);
        }
        public static int ExecuteSetDataFromAssembly(Request request)
        {
            try
            {
                var serviceItem = GetServiceItem(request);
                return Lambda.DynamicLoad.DynaInvoke.CallMethod<int>(serviceItem.AssemblyFile, serviceItem.ClassName, serviceItem.MethodName, serviceItem.IsStatic, new object[] { request });
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw ex.InnerException;
                throw ex;
            }
        }

        private static ServiceItem GetServiceItem(Request request)
        {
            var Items = new List<AutoItem>();
            Items.Add(new AutoItem
            {
                Name = "KeyService",
                Value = request.DataItem.KeyService,
                SqlType = System.Data.SqlDbType.NVarChar
            });
            var serviceItems = ServiceModel.Get<ServiceItem>(new AutoObject { SpName = "sys_ServiceItemSelect_WithKey", Items = Items }, request.AppCSName);
            if (serviceItems == null || serviceItems.Count != 1)
                throw new Exception("Lệnh không hợp lệ");
            var serviceItem = serviceItems[0];
            return serviceItem;
        }
    }
}
