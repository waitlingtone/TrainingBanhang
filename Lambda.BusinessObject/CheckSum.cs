using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.BusinessObject
{
    public static class CheckSum
    {
        public static string MakeChecksum(List<AutoObject> lst, string accessToken)
        {
            if (lst == null)
                return null;
            StringBuilder checksum = new StringBuilder();
            checksum.Append(accessToken);
            for (int i = 0; i < lst.Count; i++)
            {
                checksum.Append(Lambda.Framework.AutoEncrypt.MakeChecksum(lst[i].SpName));
                for (int j = 0; j < lst[i].Items.Count; j++)
                {
                    var x = lst[i].Items[j];
                    checksum.Append(Lambda.Framework.AutoEncrypt.MakeChecksum(string.Format("{0}{1}{2}", x.SqlType, x.Value, x.Name)));
                }
            }
            string checksumcalc = Lambda.Framework.AutoEncrypt.MakeChecksum(checksum.ToString(), true);
            return checksumcalc;
        }
    }
}
