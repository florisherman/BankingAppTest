using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppTest
{
   public interface IWorkFlow
    {
        void AddTransaction();
        Customer ShowCustomer();
        void UpdateBalance(decimal amt);

    }
}
