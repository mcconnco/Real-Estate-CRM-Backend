using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.Utility
{
    public class Cast
    {
        public List<Dictionary<string, object>> DataTableToDictionary(DataTable dt)
        {
            var dictionaries = new List<Dictionary<string, object>>();
            foreach (DataRow row in dt.Rows)
            {
                Dictionary<string, object> dictionary = Enumerable.Range(0, dt.Columns.Count).ToDictionary(i => dt.Columns[i].ColumnName, i => row.ItemArray[i]);
                dictionaries.Add(dictionary);
            }
            return dictionaries;
        }
        public Dictionary<string, object> DataRowToDictionary(DataRow dr)
        {
            return dr.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => dr[c]);
        }
    }
}
