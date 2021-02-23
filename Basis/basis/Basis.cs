using COPRA.COPRA6.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COPRA.COPRA6.FachberatungCore.core;

namespace Basis.test
{
    public class Basis
    {
        private static MissingName logic = new MissingName();

        public static void CO_Admin_Kopfzeile__ScriptEvent1(string event_name, object sender, System.EventArgs e)
        {
            logic.SetValueFromConfigList((Button)sender);
        }

        public static System.Collections.Generic.IEnumerable<object> CO_Anaesthesie_AWR_Protokoll_postop__ScriptEvent2(COPRA.COPRA6.Controls.IControl control, COPRA.COPRA6.Data.ITransaction transaction)
        {
            return logic.GetVentilationDetails("1046", "fallId");
        }
    }
}
