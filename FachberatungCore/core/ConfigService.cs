using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPRA.COPRA6.FachberatungCore.core
{
    public class ConfigService
    {

        public class ConfigList
        {
            public string Name { get; private set; }
            public string Text { get; private set; }
            public string Abbrev { get; private set; }
            public string Add1 { get; private set; }
            public string Add2 { get; private set; }
            public string Add3 { get; private set; }
            public string Add4 { get; private set; }
            public string Add5 { get; private set; }
            public string Sort { get; private set; }
            public string ID { get; private set; }

            public ConfigList(string name, string text, string abbrev, string add1, string add2, string add3, string add4, string add5, string sort, string id)
            {
                this.Name = name;
            }

        }
        //Gibt Konfigurationsliste zurück
        public List<ConfigList> GetConfigList(string lvListName)
        {
            /*
            result[0] = "Name";
            result[1] = "Text";
            result[2] = "Abbrev";
            result[3] = "Add1";
            result[4] = "Add2";
            result[5] = "Add3";
            result[6] = "Add4";
            result[7] = "Add5";
            result[8] = "Sort";
            result[9] = "ID";
            */

            System.Collections.Generic.List<string[]> result = null;

            System.Collections.Generic.List<String[]> listen;
            if (Base.Context.Parameters.ContainsKey("Konfig_Listen"))
            {
                listen = (System.Collections.Generic.List<String[]>)Base.Context.Parameters["Konfig_Listen"];
                result = listen.Where(res => res[0] == lvListName).ToList();
            }
            else
            {
                listen = new System.Collections.Generic.List<String[]>();
                Base.Context.Parameters["Konfig_Listen"] = listen;
                result = new System.Collections.Generic.List<String[]>();
            }

            if (result.Count == 0)
            {
                String sql = @"SELECT [Name]
                             ,[Sort]
                                  ,[Text]
                                  ,[Abbrev]
                                  ,[Add1]
                                  ,[Add2]
                                  ,[Add3]
                                  ,[Add4]
                                  ,[Add5]
                                  ,[ID]
                              FROM [dbo].[CO6_Config_Lists]

                            WHERE [Name] = '#listname#'
                                  AND [Deleted] = 0

                            ORDER BY [Name], [Sort]";

                sql = sql.Replace("#listname#", lvListName);

                var sqlResult = Base.Context.Connection.GetDataSet(sql).Tables[0].Rows;

                if (sqlResult != null && sqlResult.Count > 0)
                {
                    String[] tmpListe;

                    foreach (System.Data.DataRow row in sqlResult)
                    {
                        tmpListe = new String[10];

                        tmpListe[0] = row["Name"].ToString();
                        tmpListe[1] = row["Text"].ToString();
                        tmpListe[2] = row["Abbrev"].ToString();
                        tmpListe[3] = row["Add1"].ToString();
                        tmpListe[4] = row["Add2"].ToString();
                        tmpListe[5] = row["Add3"].ToString();
                        tmpListe[6] = row["Add4"].ToString();
                        tmpListe[7] = row["Add5"].ToString();
                        tmpListe[8] = row["Sort"].ToString();
                        tmpListe[9] = row["ID"].ToString();

                        listen.Add(tmpListe);
                        result.Add(tmpListe);
                    }
                }
            }

            return Convert(result);
        }

        private List<ConfigList> Convert(List<string[]> result)
        {
            return result.Select(x => new ConfigList(x[0], x[1], x[0], x[1], x[0], x[1], x[0], x[1], x[0], x[1])).ToList();
        }
    }
}
