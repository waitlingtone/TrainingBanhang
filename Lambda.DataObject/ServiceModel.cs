using Lambda.BusinessObject;
using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.DataObject
{
    public class ServiceModel
    {
        public static List<T> Get<T>(AutoObject item, string AppCSName = null) where T : Bus
        {
            if (string.IsNullOrEmpty(AppCSName) == true)
            {
                AppCSName = ConfigService.Instance.AppCSName;
            }
            var result = AutoDao.ExecuteQuery(AppCSName, item);
            return BusinessAction.ToBusinessObject<T>(result);
        }
        public static List<T> Get<T>(Request request) where T: Bus
        {
            return Get<T>(request.DataItem, request.AppCSName);
        }

        public static int Set<T>(T item, string AppCSName = null) where T : Bus
        {
            return Set<T>(new List<T> { item });
        }
        public static int Set<T>(List<T> listBus, string AppCSName = null) where T : Bus
        {
            if (string.IsNullOrEmpty(AppCSName) == true)
            {
                AppCSName = ConfigService.Instance.AppCSName;
            }
            var listSet = BusinessAction.GetBusinessObjectWithState<T>(listBus, RowState.Insert | RowState.Update | RowState.Delete);
            var listSetAuto = BusinessAction.ToAutoObject(listSet);//var listSetAuto = CreateListAuto(listSet);

            var listDelete = BusinessAction.GetBusinessObjectWithState<T>(listSet, RowState.Delete);
            var listIU = BusinessAction.GetBusinessObjectWithState<T>(listSet, RowState.Insert | RowState.Update);
            //var response =  SetInvoke(listSetAuto);
            var RowsAffected = AutoDao.ExeNonQuery(AppCSName, listSetAuto);

            for (int i = 0; i < listDelete.Count; i++)
            {
                listBus.Remove(listDelete[i]);
            }

            for (int i = 0; i < listIU.Count; i++)
            {
                //listIU[i].DataFromAutoObject(response.DataItems[i]);
                listIU[i].DataFromAutoObject(listSetAuto[i]);
                listIU[i].MakeUnchange();
            }

            return RowsAffected;
        }
        public static int SetTransaction(AutoObjectTransaction item, string AppCSName = null)
        {
            if (string.IsNullOrEmpty(AppCSName) == true)
            {
                AppCSName = ConfigService.Instance.AppCSName;
            }
            var RowsAffected = AutoDao.ExeNonQuery(AppCSName, item.ListAuto);
            item.Clear();
            return RowsAffected;
        }
    }
}
