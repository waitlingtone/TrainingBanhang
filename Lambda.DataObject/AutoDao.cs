using Lambda.BusinessObject;
using Lambda.CoreService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lambda.DataObject
{
    public class AutoDao
    {


        static string GetConnectionString(string ConnectionStringName)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
            catch
            { return ""; }
        }
        static SqlConnection GetConnection(string ConnectionStringName)
        {
            return new SqlConnection(GetConnectionString(ConnectionStringName));
        }

        #region Execute Query
        static SqlDataReader ExecuteReader(string spName, List<SqlParameter> param, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = spName;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            //if (cmd.CommandText.IndexOf(' ') >= 0) // cho phép xử lý câu sql, thay vì StoredProcedure
            //{
            //    cmd.CommandType = CommandType.Text;
            //}
            if (param != null && param.Count > 0)
                cmd.Parameters.AddRange(param.ToArray());
            return cmd.ExecuteReader();
        }
        static List<AutoObject> DataReaderToAutoObject(SqlDataReader reader)
        {
            List<AutoObject> lst = new List<AutoObject>();
            while (reader.Read())
            {
                List<AutoItem> items = new List<AutoItem>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    AutoItem p = new AutoItem();
                    p.CSharpType = reader.GetFieldType(i).FullName;
                    p.Name = reader.GetName(i);   //p.SqlType = Lambda.Framework.BMIConvert.GetSqlTypeFromStringType(reader.GetDataTypeName(i));
                    //p.SqlType = reader.GetDataTypeName(i);
                    var value = reader.GetValue(i);
                    p.Value = value;
                    if (p.Value == DBNull.Value)
                        p.Value = null;
                    items.Add(p);
                }
                AutoObject d = new AutoObject();
                d.Items = items;
                lst.Add(d);
            }
            reader.Close();
            return lst;
        }
        static List<AutoObject> ExecuteQuery(string ConnectionStringName, string spName, List<AutoItem> param = null)
        {
            using (SqlConnection con = GetConnection(ConnectionStringName))
            {
                List<AutoObject> lst = new List<AutoObject>();
                con.Open();
                List<SqlParameter> Sqlparam = param.ToSqlParameter();
                var reader = ExecuteReader(spName, Sqlparam, con);
                lst = DataReaderToAutoObject(reader);
                reader.Close();//Mới thêm 23/10/2014
                con.Close();
                return lst;
            }
        }
        
        public static List<AutoObject> ExecuteQuery(Request request)
        {
            return ExecuteQuery(request.AppCSName, request.DataItem, request.Caching, request.MinuteToCache);
        }
        public static List<AutoObject> ExecuteQuery(string ConnectionStringName, AutoObject item, bool Caching = false, long MinuteToCache = 60)
        {
            List<AutoObject> data;

            string key = AutoMemCached.MakeKey(ConnectionStringName, item);
            if (Caching == true)
            {
                data = AutoMemCached.Get(key);
                if (data != null && data.Count > 0)
                    return data;
            }
            //Get data from database 
            data = ExecuteQuery(ConnectionStringName, item.SpName, item.Items);
            AutoMemCached.Add(key, data, DateTimeOffset.Now.AddMinutes(MinuteToCache));
            return data;
        }
        #endregion

        #region Execute StringTableXML
        public static string ExecuteQueryToTableXML(Request request)
        {
            return ExecuteQueryToTableXML(request.AppCSName, request.DataItem);
        }
        public static string ExecuteQueryToTableXML(string ConnectionStringName, AutoObject item)
        {
            using (SqlConnection con = GetConnection(ConnectionStringName))
            {
                con.Open();
                List<SqlParameter> Sqlparam = item.Items.ToSqlParameter();
                var reader = ExecuteReader(item.SpName, Sqlparam, con);
                var table = new DataTable(item.SpName);
                table.Load(reader);
                reader.Close();
                con.Close();
                using (StringWriter sw = new StringWriter())
                {
                    table.WriteXml(sw, XmlWriteMode.WriteSchema);
                    return sw.ToString();
                }
            }
        }
        #endregion

        #region Execute Non Query
        public static int ExeNonQuery(Request request)
        {
            return ExeNonQuery(request.AppCSName, request.DataItems);
        }
        public static int ExeNonQuery(string ConnectionStringName, List<AutoObject> data)
        {
            int rowAff = 0;
            using (SqlConnection con = GetConnection(ConnectionStringName))
            {
                SqlTransaction myTrans = null;
                try
                {
                    con.Open();
                    myTrans = con.BeginTransaction();
                    SqlCommand cmd = new SqlCommand();
                    for (int i = 0; i < data.Count; i++)
                    {
                        #region Exe 1 SQL
                        cmd.CommandText = data[i].SpName;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = myTrans;
                        //Get Param
                        List<SqlParameter> lstParam = new List<SqlParameter>();
                        if (data[i].Items != null && data[i].Items.Count > 0)
                        {
                            lstParam = data[i].Items.ToSqlParameter();
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(lstParam.ToArray());
                        }
                        int x = cmd.ExecuteNonQuery();
                        rowAff += x;
                        if (x > 0)
                        {
                            SqlParameter Item = FindVersion(lstParam);
                            AutoItem aItem = FindVersion(data[i]);
                            if (aItem != null && Item != null)
                                aItem.Value = Item.Value;
                        }
                        #endregion
                    }
                    myTrans.Commit();
                    for (int i = data.Count - 1; i >= 0; i--)
                    {
                        //if (data[i].SpName.ToLower().Contains("delete"))
                        //    data.RemoveAt(i);
                        if (data[i].State == RowState.Delete)
                            data.RemoveAt(i);
                    }
                }
                catch (Exception ex)
                {
                    myTrans.Rollback();
                    rowAff = 0;
                    con.Close();
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return rowAff;
        }
        private static AutoItem FindVersion(AutoObject dataItem)
        {
            if (dataItem == null)
                return null;
            for (int i = 0; i < dataItem.Items.Count; i++)
            {
                if (dataItem.Items[i].SqlType == SqlDbType.Timestamp)
                    return dataItem.Items[i];
            }
            return null;
        }
        private static SqlParameter FindVersion(List<SqlParameter> lstParam)
        {
            if (lstParam == null)
                return null;
            for (int i = 0; i < lstParam.Count; i++)
                if (lstParam[i].SqlDbType == SqlDbType.Timestamp)
                {
                    return lstParam[i];
                }
            return null;
        }
        #endregion

        #region Execute Function
        public static object ExeFunction(string ConnectionStringName, string function, params object[] param)
        {
            using (var con = GetConnection(ConnectionStringName))
            {
                try
                {
                    con.Open();
                    string strParam = "";
                    for (int i = 0; param!=null && i < param.Length; i++)
                    {
                        strParam += string.Format("'{0}',", param[i]);
                    }
                    if(!string.IsNullOrEmpty(strParam))
                        strParam = strParam.Trim().TrimEnd(',').Trim();
                    string sql = string.Format("SELECT {0} ({1})", function, strParam);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    object result = cmd.ExecuteScalar();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        #endregion
    }
    public static class Extension
    {
        public static SqlParameter ToSqlParameter(this AutoItem param)
        {
            if (param == null)
                return null;
            SqlParameter sqlPara = new SqlParameter();
            sqlPara.ParameterName = param.Name;
            sqlPara.Value = param.Value;
            if (sqlPara.Value == null)
                sqlPara.Value = DBNull.Value;
            if (param.SqlType == SqlDbType.Timestamp)
            {
                sqlPara.Direction = ParameterDirection.InputOutput;
            }
            sqlPara.SqlDbType = param.SqlType;
            return sqlPara;
        }
        public static List<SqlParameter> ToSqlParameter(this List<AutoItem> param)
        {
            if (param == null)
                return null;
            List<SqlParameter> lst = new List<SqlParameter>();
            for (int i = 0; i < param.Count; i++)
            {
                var sqlp = param[i].ToSqlParameter();
                if (sqlp != null)
                    lst.Add(sqlp);
            }
            return lst;
        }
    }
}
