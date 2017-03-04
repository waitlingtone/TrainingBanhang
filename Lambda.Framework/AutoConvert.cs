using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lambda.Framework
{
    public static class AutoConvert
    {
        public static Type GetTypeFromSqlDbType(SqlDbType SqlType)
        {
            switch (SqlType)
            {
                case SqlDbType.Image:
                case SqlDbType.Timestamp:
                case SqlDbType.VarBinary:
                case SqlDbType.Binary:
                    return typeof(Byte[]);

                case SqlDbType.BigInt:
                    return typeof(System.Int64);

                case SqlDbType.Bit:
                    return typeof(System.Boolean);

                case SqlDbType.Char:
                case SqlDbType.NChar:
                case SqlDbType.NText:
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                case SqlDbType.VarChar:
                case SqlDbType.Xml:
                    return typeof(System.String);

                case SqlDbType.Date:
                case SqlDbType.DateTime:
                case SqlDbType.DateTime2:
                case SqlDbType.DateTimeOffset:
                    return typeof(System.DateTime);

                case SqlDbType.Decimal:
                case SqlDbType.Money:
                case SqlDbType.SmallMoney:
                    return typeof(System.Decimal);

                case SqlDbType.Real: return typeof(System.Single);

                case SqlDbType.UniqueIdentifier: return typeof(System.Guid);

                case SqlDbType.TinyInt: return typeof(System.Byte);
                default: return typeof(System.String);
            }
        }
        static Array ListSqlDbType = Enum.GetValues(typeof(SqlDbType));
        public static SqlDbType GetSqlDbTypeFromStringType(string type)
        {
            
            if (string.IsNullOrEmpty(type))
                return SqlDbType.NVarChar;
            type = type.Trim().ToLower();
            for (int i = 0; i < ListSqlDbType.Length; i++)
            {
                if (((SqlDbType)ListSqlDbType.GetValue(i)).ToString().ToLower() == type)
                    return (SqlDbType)ListSqlDbType.GetValue(i);
            }

            // Summary:
            //     System.Int64. A 64-bit signed integer.
            if (type == SqlDbType.BigInt.ToString().ToLower())// = 0,
                return SqlDbType.BigInt;
            //
            // Summary:
            //     System.Array of type System.Byte. A fixed-length stream of binary data ranging
            //     between 1 and 8,000 bytes.
            if (type == SqlDbType.Binary.ToString().ToLower())// = 1,
                return SqlDbType.Binary;
            //
            // Summary:
            //     System.Boolean. An unsigned numeric value that can be 0, 1, or null.
            if (type == SqlDbType.Bit.ToString().ToLower())// = 2,
                return SqlDbType.Bit;
            //
            // Summary:
            //     System.String. A fixed-length stream of non-Unicode characters ranging between
            //     1 and 8,000 characters.
            if (type == SqlDbType.Char.ToString().ToLower())// = 3,
                return SqlDbType.Char;
            //
            // Summary:
            //     System.DateTime. Date and time data ranging in value from January 1, 1753
            //     to December 31, 9999 to an accuracy of 3.33 milliseconds.
            if (type == SqlDbType.DateTime.ToString().ToLower())// = 4,
                return SqlDbType.DateTime;
            //
            // Summary:
            //     System.Decimal. A fixed precision and scale numeric value between -10 38
            //     -1 and 10 38 -1.
            if (type == SqlDbType.Decimal.ToString().ToLower())// = 5,
                return SqlDbType.Decimal;
            //
            // Summary:
            //     System.Double. A floating point number within the range of -1.79E +308 through
            //     1.79E +308.
            if (type == SqlDbType.Float.ToString().ToLower())// = 6,
                return SqlDbType.Float;
            //
            // Summary:
            //     System.Array of type System.Byte. A variable-length stream of binary data
            //     ranging from 0 to 2 31 -1 (or 2,147,483,647) bytes.
            if (type == SqlDbType.Image.ToString().ToLower())// = 7,
                return SqlDbType.Image;
            //
            // Summary:
            //     System.Int32. A 32-bit signed integer.
            if (type == SqlDbType.Int.ToString().ToLower())// = 8,
                return SqlDbType.Int;
            //
            // Summary:
            //     System.Decimal. A currency value ranging from -2 63 (or -9,223,372,036,854,775,808)
            //     to 2 63 -1 (or +9,223,372,036,854,775,807) with an accuracy to a ten-thousandth
            //     of a currency unit.
            if (type == SqlDbType.Money.ToString().ToLower())// = 9,
                return SqlDbType.Money;
            //
            // Summary:
            //     System.String. A fixed-length stream of Unicode characters ranging between
            //     1 and 4,000 characters.
            if (type == SqlDbType.NChar.ToString().ToLower())// = 10,
                return SqlDbType.NChar;
            //
            // Summary:
            //     System.String. A variable-length stream of Unicode data with a maximum length
            //     of 2 30 - 1 (or 1,073,741,823) characters.
            if (type == SqlDbType.NText.ToString().ToLower())// = 11,
                return SqlDbType.NText;
            //
            // Summary:
            //     System.String. A variable-length stream of Unicode characters ranging between
            //     1 and 4,000 characters. Implicit conversion fails if the string is greater
            //     than 4,000 characters. Explicitly set the object when working with strings
            //     longer than 4,000 characters. Use System.Data.SqlDbType.NVarChar when the
            //     database column is nvarchar(max).
            if (type == SqlDbType.NVarChar.ToString().ToLower())// = 12,
                return SqlDbType.NVarChar;
            //
            // Summary:
            //     System.Single. A floating point number within the range of -3.40E +38 through
            //     3.40E +38.
            if (type == SqlDbType.Real.ToString().ToLower())// = 13,
                return SqlDbType.Real;
            //
            // Summary:
            //     System.Guid. A globally unique identifier (or GUID).
            if (type == SqlDbType.UniqueIdentifier.ToString().ToLower())// = 14,
                return SqlDbType.UniqueIdentifier;
            //
            // Summary:
            //     System.DateTime. Date and time data ranging in value from January 1, 1900
            //     to June 6, 2079 to an accuracy of one minute.
            if (type == SqlDbType.SmallDateTime.ToString().ToLower())// = 15,
                return SqlDbType.SmallDateTime;
            //
            // Summary:
            //     System.Int16. A 16-bit signed integer.
            if (type == SqlDbType.SmallInt.ToString().ToLower())// = 16,
                return SqlDbType.SmallInt;
            //
            // Summary:
            //     System.Decimal. A currency value ranging from -214,748.3648 to +214,748.3647
            //     with an accuracy to a ten-thousandth of a currency unit.
            if (type == SqlDbType.SmallMoney.ToString().ToLower())// = 17,
                return SqlDbType.SmallMoney;
            //
            // Summary:
            //     System.String. A variable-length stream of non-Unicode data with a maximum
            //     length of 2 31 -1 (or 2,147,483,647) characters.
            if (type == SqlDbType.Text.ToString().ToLower())// = 18,
                return SqlDbType.Text;
            //
            // Summary:
            //     System.Array of type System.Byte. Automatically generated binary numbers,
            //     which are guaranteed to be unique within a database. timestamp is used typically
            //     as a mechanism for version-stamping table rows. The storage size is 8 bytes.
            if (type == SqlDbType.Timestamp.ToString().ToLower())// = 19,
                return SqlDbType.Timestamp;
            //
            // Summary:
            //     System.Byte. An 8-bit unsigned integer.
            if (type == SqlDbType.TinyInt.ToString().ToLower())// = 20,
                return SqlDbType.TinyInt;
            //
            // Summary:
            //     System.Array of type System.Byte. A variable-length stream of binary data
            //     ranging between 1 and 8,000 bytes. Implicit conversion fails if the byte
            //     array is greater than 8,000 bytes. Explicitly set the object when working
            //     with byte arrays larger than 8,000 bytes.
            if (type == SqlDbType.VarBinary.ToString().ToLower())// = 21,
                return SqlDbType.VarBinary;
            //
            // Summary:
            //     System.String. A variable-length stream of non-Unicode characters ranging
            //     between 1 and 8,000 characters. Use System.Data.SqlDbType.VarChar when the
            //     database column is varchar(max).
            if (type == SqlDbType.VarChar.ToString().ToLower())// = 22,
                return SqlDbType.VarChar;
            //
            // Summary:
            //     System.Object. A special data type that can contain numeric, string, binary,
            //     or date data as well as the SQL Server values Empty and Null, which is assumed
            //     if no other type is declared.
            if (type == SqlDbType.Variant.ToString().ToLower())// = 23,
                return SqlDbType.Variant;
            //
            // Summary:
            //     An XML value. Obtain the XML as a string using the System.Data.SqlClient.SqlDataReader.GetValue(System.Int32)
            //     method or System.Data.SqlTypes.SqlXml.Value property, or as an System.Xml.XmlReader
            //     by calling the System.Data.SqlTypes.SqlXml.CreateReader() method.
            if (type == SqlDbType.Xml.ToString().ToLower())// = 25,
                return SqlDbType.Xml;
            //
            // Summary:
            //     A SQL Server 2005 user-defined type (UDT).
            if (type == SqlDbType.Udt.ToString().ToLower())// = 29,
                return SqlDbType.Udt;
            //
            // Summary:
            //     A special data type for specifying structured data contained in table-valued
            //     parameters.
            if (type == SqlDbType.Structured.ToString().ToLower())// = 30,
                return SqlDbType.Structured;
            //
            // Summary:
            //     Date data ranging in value from January 1,1 AD through December 31, 9999
            //     AD.
            if (type == SqlDbType.Date.ToString().ToLower())// = 31,
                return SqlDbType.Date;
            //
            // Summary:
            //     Time data based on a 24-hour clock. Time value range is 00:00:00 through
            //     23:59:59.9999999 with an accuracy of 100 nanoseconds. Corresponds to a SQL
            //     Server time value.
            if (type == SqlDbType.Time.ToString().ToLower())// = 32,
                return SqlDbType.Time;
            //
            // Summary:
            //     Date and time data. Date value range is from January 1,1 AD through December
            //     31, 9999 AD. Time value range is 00:00:00 through 23:59:59.9999999 with an
            //     accuracy of 100 nanoseconds.
            if (type == SqlDbType.DateTime2.ToString().ToLower())// = 33,
                return SqlDbType.DateTime2;
            //
            // Summary:
            //     Date and time data with time zone awareness. Date value range is from January
            //     1,1 AD through December 31, 9999 AD. Time value range is 00:00:00 through
            //     23:59:59.9999999 with an accuracy of 100 nanoseconds. Time zone value range
            //     is -14:00 through +14:00.
            if (type == SqlDbType.DateTimeOffset.ToString().ToLower())// = 34,
                return SqlDbType.DateTimeOffset;
            return SqlDbType.NVarChar;
        }
        public static SqlDbType GetSqlTypeFromStringType(string type)
        {
            SqlDbType SqlType = new SqlDbType();
            if (type == null)
                return SqlDbType.NVarChar;
            switch (type.ToLower())
            {
                case "bigint": SqlType = SqlDbType.BigInt; break;
                case "bit": SqlType = SqlDbType.Bit; break;
                case "char": SqlType = SqlDbType.Char; break;
                case "datetime": SqlType = SqlDbType.DateTime; break;
                case "decimal": SqlType = SqlDbType.Decimal; break;
                case "float": SqlType = SqlDbType.Float; break;
                case "int": SqlType = SqlDbType.Int; break;
                case "money": SqlType = SqlDbType.Money; break;
                case "nchar": SqlType = SqlDbType.NChar; break;
                case "ntext": SqlType = SqlDbType.NText; break;
                case "nvarchar": SqlType = SqlDbType.NVarChar; break;
                case "real": SqlType = SqlDbType.Real; break;
                case "timestamp": SqlType = SqlDbType.Timestamp; break;
                case "varbinary": SqlType = SqlDbType.VarBinary; break;
                case "varchar": SqlType = SqlDbType.VarChar; break;
                case "xml": SqlType = SqlDbType.Xml; break;
                case "date": SqlType = SqlDbType.Date; break;
                case "time": SqlType = SqlDbType.Time; break;
                case "datetime2": SqlType = SqlDbType.DateTime2; break;
                case "datetimeoffset": SqlType = SqlDbType.DateTimeOffset; break;
                case "image": SqlType = SqlDbType.Image; break;
                case "binary": SqlType = SqlDbType.Binary; break;
                case "uniqueidentifier": SqlType = SqlDbType.UniqueIdentifier; break;
                case "TinyInt": SqlType = SqlDbType.TinyInt; break;
                default: SqlType = SqlDbType.NVarChar; break;
            }
            return SqlType;
        }

        public static byte[] GetBytesFromHexString(string value)
        {
            if(string.IsNullOrEmpty(value))
                return null;
            SoapHexBinary shb = SoapHexBinary.Parse(value);
            return shb.Value;
        }
        public static string GetHexStringFromBytes(byte[] val)
        {
            if (val == null)
                return null;
            SoapHexBinary shb = new SoapHexBinary(val);
            return shb.ToString();
        }

        public static Object ConvertFromString(String value, String CSharpType)
        {
            return ConvertFromString(value,Type.GetType(CSharpType));
        }
        /// <summary>
        /// DeSerialize Object(Type: CSharpType) from String (xml)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="CSharpType"></param>
        /// <returns></returns>
        public static Object ConvertFromString(String value, Type CSharpType)
        {
            MethodInfo gM = typeof(AutoConvert).GetMethod("Deserialize");
            MethodInfo sgM = gM.MakeGenericMethod(GetNullableType(CSharpType));
            Object obj = sgM.Invoke(null, new object[] { value });
            return obj;
        }
        public static string ConvertToString(Object value, String CSharpType)
        {
            return ConvertToString(value, Type.GetType(CSharpType));
        }
        /// <summary>
        /// Serialize Object(Type: CSharpType) to String(xml)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="CSharpType"></param>
        /// <returns></returns>
        public static string ConvertToString(Object value, Type CSharpType)
        {
            if (value == null || value == DBNull.Value)
            {
                CSharpType = GetNullableType(CSharpType);
                object v = null;
                return v.SerializeObject(CSharpType);
            }
            return value.SerializeObject(CSharpType);
        }
        public static Type GetNullableType(Type type)
        {
            if (type.IsArray || type.FullName.ToLower().Contains("string") || type.FullName.Contains("Nullable"))
                return type;
            return Type.GetType(string.Format("System.Nullable`1[[{0}]]",type.FullName));
        }
        public static string SerializeObject<T>(this T toSerialize, Type CSharpType)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(CSharpType);
            StringWriter textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }
        public static T Deserialize<T>(string xmlDataToDeSerialize)
        {
            XmlSerializer xmlDeSerializer = new XmlSerializer(GetNullableType(typeof(T)));
            StringReader stringReader = new StringReader(xmlDataToDeSerialize);
            return (T)xmlDeSerializer.Deserialize(stringReader);
        }
    }
}
