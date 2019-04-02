using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using butcham1.Models;

namespace butcham1
{
    class TransactionItemController : ITransaction
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Sell sell = new TB_M_Sell();
        TB_M_Items item = new TB_M_Items();
        TB_T_TransactionItem transaction = new TB_T_TransactionItem();

        public List<TB_T_TransactionItem> Get()
        {
            throw new NotImplementedException();
        }

        public TB_T_TransactionItem Get(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_T_TransactionItem transaction)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id, TB_T_TransactionItem transaction)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
