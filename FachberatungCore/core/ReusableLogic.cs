using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPRA.COPRA6.FachberatungCore.core
{
    public class ReusableLogic
    {
        public System.Collections.Generic.IEnumerable<object> GetAllUser(Controls.IControl control, Data.ITransaction transaction)
        {
            yield return transaction != null;
        }

        public int GetTiss10(List<int> values)
        {
            return (int)(Math.PI * new Random().Next());
        }
    }
}
