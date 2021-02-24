using COPRA.COPRA6.Controls;
using COPRA.COPRA6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static COPRA.COPRA6.FachberatungCore.core.ConfigService;

namespace COPRA.COPRA6.FachberatungCore.core
{
    public class MissingName
    {
        public ConfigService config = new ConfigService();

        public IEnumerable<string> GetVentilationDetails(string ventilationVarId, string caseId)
        {
            yield return null;
        }

        public void SetValueFromConfigList(Button button)
        {
            string name = button.Name;
            ConfigList configs = config.GetConfigList("CO_WeißDerTeufelWas").Where(list => list.Name.Equals(name)).FirstOrDefault();
            Variable variable = Variable.Get("CO_Variable");
            ITransaction transaction = button.GetTransaction();
            Data.Object parent = transaction.GetRegistredObject(variable.Parent);
            Value value = (Value)transaction.GetLastValue(variable, parent);
            Value new_y;

            if (value == null)
            {
                new_y = new Value(transaction, variable, parent);
            }
            else
            {
                new_y = transaction.Modify(value);
            }

            new_y.val = configs.Text;
            transaction.Commit();
        }
    }
}
