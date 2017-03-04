using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    [Flags]
    public enum RowState { Insert = 1, Update = 2, Delete = 4, UnChange = 8 }
    public abstract class Bus : INotifyPropertyChanged, INotifyPropertyChanging
    {
        RowState _State = RowState.Insert;
        public RowState State
        {
            get { return _State; }
            private set 
            {
                _State = value;
                OnPropertyChanged("State");
            }
        }

        bool flag = false;
        public void MakeUnchange()
        {
            flag = true;
            State = RowState.UnChange;
            flag = false;
        }
        public void MakeInsert()
        {
            flag = true;
            State = RowState.Insert;
            flag = false;
        }
        public void MakeUpdate()
        {
            flag = true;
            State = RowState.Update;
            flag = false;
        }
        public void MakeDelete()
        {
            flag = true;
            State = RowState.Delete;
            flag = false;
        }

        AutoItem GetValueFromAutoObject(AutoObject value, string Name)
        {
            if (value.Items == null)
                return null;
            Name = Name.ToLower();
            for (int i = 0; i < value.Items.Count; i++)
                if (value.Items[i].Name.ToLower() == Name)
                    return value.Items[i];
            return null;
        }
        
        public virtual void DataFromAutoObject(AutoObject value)
        {
            var obj = this;
            PropertyInfo[] ObjProperties = obj.GetType().GetProperties();
            for (int i = 0; i < ObjProperties.Length; i++)
            {
                PropertyInfo property = ObjProperties[i];
                AutoItem item = GetValueFromAutoObject(value, property.Name);
                if (item != null)
                {
                    //check for nullable property type and handle
                    var propertyType = property.PropertyType;
                    if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        propertyType = propertyType.GetGenericArguments()[0];

                    //set property value
                    var objValue = item.Value;

                    if (objValue == null)
                    {
                        ObjProperties[i].SetValue(obj, null);
                    }
                    else
                    {
                        ObjProperties[i].SetValue(obj, Convert.ChangeType(objValue, propertyType, System.Globalization.CultureInfo.CurrentCulture), null);
                    }
                }
            }

        }
        public virtual AutoObject DataToAutoObject()
        {
            var obj = this;
            var Items = new List<AutoItem>();

            //Items.Add(new AutoItem { Name = "Ngaysinh", Value = Ngaysinh, SqlType = SqlDbType.DateTime });
            //Items.Add(new AutoItem { Name = "Gioitinh", Value = Gioitinh, SqlType = SqlDbType.Bit });
            //Items.Add(new AutoItem { Name = "SinhvienId", Value = SinhvienId, SqlType = SqlDbType.BigInt });
            //Items.Add(new AutoItem { Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp });
            //Items.Add(new AutoItem { Name = "Hoten", Value = Hoten, SqlType = SqlDbType.NVarChar });
            PropertyInfo[] ObjProperties = obj.GetType().GetProperties();
            foreach (var p in ObjProperties)
            {
                var attributes = p.GetCustomAttributes(false);
                foreach (Attribute attribute in attributes)
                {
                    ColumnAttribute ca = attribute as ColumnAttribute;
                    if (ca != null)
                    {
                        Items.Add(new AutoItem { Name = ca.Name, Value = p.GetValue(obj,null), SqlType = ca.SqlType });
                    }
                }
            }
            return DataToAutoObject(Items.ToArray());
        }
        public virtual AutoObject DataToAutoObject(params AutoItem[] items)
        {
            AutoObject item = new AutoObject { SpName = GetSpName(),Items = new List<AutoItem>()};
            item.TypeName = this.GetType().FullName;
            item.State = this.State;

            item.Items.AddRange(items);
            return item;
        }
        public virtual string GetSpName()
        {
            var obj = this;
            var type = obj.GetType();

            var attributes = type.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes)
            {
                TableAttribute ta = attribute as TableAttribute;
                if (ta != null)
                {
                    if (State == RowState.Insert)
                        return ta.spInsert;
                    if (State == RowState.Update)
                        return ta.spUpdate;
                    if (State == RowState.Delete)
                        return ta.spDelete;
                    return ta.spSelect;
                }
            }
            return null;
        }
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            OnPropertyChanging(propertyName);
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
            return false;
        }
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (_State == RowState.UnChange && flag == false)
                _State = RowState.Update;
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangingEventHandler PropertyChanging;
        protected void OnPropertyChanging(string propertyName)
        {
            var handler = PropertyChanging;
            if (handler != null)
            {
                handler(this, new PropertyChangingEventArgs(propertyName));
            }
        }
        #endregion
    }
}