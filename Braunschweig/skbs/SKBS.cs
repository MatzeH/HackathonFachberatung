using COPRA.COPRA6.FachberatungCore.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braunschweig.test
{
    public class SKBS
    {
        private static MissingName logic = new MissingName();

        public static System.Collections.Generic.IEnumerable<object> CO_Anaesthesie_AWR_Protokoll_postop__ScriptEvent1(COPRA.COPRA6.Controls.IControl control, COPRA.COPRA6.Data.ITransaction transaction)
        {
            return logic.GetVentilationDetails("133742", "fallId");
        }
    }
}
