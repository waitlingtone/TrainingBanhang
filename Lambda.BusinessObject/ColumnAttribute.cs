using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    /// <summary>
    /// Attribute for decorating fields,
    /// so they can be matched to DB columns
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ColumnAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the System.Data.DbType
        /// that will be used for the object for Parameters
        /// </summary>
        public DbType DbType{get;set;}
        /// <summary>
        /// Gets or sets the System.Data.SqlDbType
        /// that will be used for the object for Parameters 
        /// </summary>
        public SqlDbType SqlType { get; set; }
        /// <summary>
        /// Gets or sets the Name of the object
        /// </summary>
        public String Name{get;set;}

        
    }
}
