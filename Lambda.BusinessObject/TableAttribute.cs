using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    /// <summary>
    /// Attribute for decorating classes, so they can be matched to DB tables.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class TableAttribute : Attribute
    {
        public string Schema { get; set; }
        public string Name { get; set; }
        public string spSelect { get; set; }
        public string spInsert { get; set; }
        public string spUpdate { get; set; }
        public string spDelete { get; set; }
    }
}
