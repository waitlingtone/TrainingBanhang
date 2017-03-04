using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    public class BusinessAction
    {
        public static AutoObject ToAutoObject<T>(T item) where T : Bus
        {
            return item.DataToAutoObject();
        }
        public static List<AutoObject> ToAutoObject<T>(List<T> items) where T : Bus
        {
            List<AutoObject> listAuto = new List<AutoObject>();
            for (int i = 0; i < items.Count; i++)
            {
                listAuto.Add(items[i].DataToAutoObject());
            }
            return listAuto;
        }
        public static T ToBusinessObject<T>(AutoObject item) where T : Bus
        {
            T x = (T)Activator.CreateInstance(typeof(T), item);
            x.MakeUnchange();
            return x;
        }
        public static List<T> ToBusinessObject<T>(List<AutoObject> items) where T : Bus
        {
            List<T> listBus = new List<T>();
            for (int i = 0; i < items.Count; i++)
            {
                T x = (T)Activator.CreateInstance(typeof(T), items[i]);
                x.MakeUnchange();
                listBus.Add(x);
            }
            return listBus;
        }

        public static List<T> GetBusinessObjectWithState<T>(List<T> listBus, RowState state) where T : Bus
        {
            var result = new List<T>();
            for (int i = 0; i < listBus.Count; i++)
                if ((listBus[i].State & state) == listBus[i].State)
                    result.Add(listBus[i]);
            return result;
        }
        public static List<AutoObject> GetAutoObjectWithSetState<T>(params List<T>[] arraylistBus) where T : Bus
        {
            var result = new List<AutoObject>();
            for (int i = 0; i < arraylistBus.Length; i++)
            {
                var tmp = BusinessAction.GetBusinessObjectWithState(arraylistBus[i], RowState.Insert | RowState.Update | RowState.Delete);
                result.AddRange(BusinessAction.ToAutoObject(tmp));
            }
            return result;
        }
    }
}
