using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public interface ISell
    {
        List<TB_M_Sell> Get();
        TB_M_Sell Get(int Id);
        bool Insert(TB_M_Sell sell);
        bool Update(int Id, TB_M_Sell sell);
        bool Delete(int Id);
    }
}
