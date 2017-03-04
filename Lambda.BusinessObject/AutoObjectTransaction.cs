using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    public class AutoObjectTransaction
    {
        List<AutoObject> listAuto = new List<AutoObject>();
        public AutoObjectTransaction Add<T>(List<T> listBus) where T : Bus
        {
            listBus = BusinessAction.GetBusinessObjectWithState(listBus, RowState.Insert | RowState.Update | RowState.Delete);
            for (int i = 0; i < listBus.Count; i++)
            {
                listAuto.Add(listBus[i].DataToAutoObject());
            }
            return this;
        }
        public AutoObjectTransaction Add<T>(T item) where T : Bus
        {
            var listBus = new List<T>();
            listBus.Add(item);
            return Add(listBus);
        }
        public AutoObjectTransaction Add(AutoObject item)
        {
            listAuto.Add(item);
            return this;
        }
        public AutoObjectTransaction Add(List<AutoObject> items)
        {
            listAuto.AddRange(items);
            return this;
        }
        public List<AutoObject> ListAuto
        {
            get
            {
                return listAuto;
            }
        }
        public void Clear()
        {
            listAuto.Clear();
        }
    }
}
