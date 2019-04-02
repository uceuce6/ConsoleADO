using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    interface ITransaction
    {
        List<TB_T_TransactionItem> Get();
        TB_T_TransactionItem Get(int Id);
        bool Insert(TB_T_TransactionItem transaction); 
        bool Update(int Id, TB_T_TransactionItem transaction);
        bool Delete(int Id);

    }
}
