using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Sockets;
using COPRA.COPRA6.FachberatungCore.core;

namespace COPRA.COPRA6.Fachberatung.UKSH.project
{
    public static class UKSH
    {
        private static ReusableLogic core = new ReusableLogic();

        public static System.Collections.Generic.IEnumerable<object> TissGetResult1(Controls.IControl control, Data.ITransaction transaction)
        {
            yield return core.GetTiss10(null);
        }

        public static System.Collections.Generic.IEnumerable<object> SendDataToUKSHSubsystem(Controls.IControl control, Data.ITransaction transaction)
        {
            int score = core.GetTiss10(null);
            Console.Out.WriteLine($"Some heavy magic is going on, but this is only for UKSH: {score}");

            #region Heavy Magic!
            
            #endregion

            yield return true;
        }
    }
}