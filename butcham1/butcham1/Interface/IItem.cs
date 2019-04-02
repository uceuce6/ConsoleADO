using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public interface IItem
    {
        List<TB_M_Items> Get();
        TB_M_Items Get(int id);
        bool Insert(TB_M_Items item);
        bool Update(int Id, TB_M_Items item);
        bool DeleteItem(int Id);
    }
}
