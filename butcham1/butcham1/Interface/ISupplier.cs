using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public interface ISupplier
    {
        List<TB_M_Suppliers> Get(); // untuk menampilkan semua data supplier
        TB_M_Suppliers Get(int Id);
        bool Insert(TB_M_Suppliers supplier); // yang hijau type data yang putih parameter
        bool Update(int Id, TB_M_Suppliers supplier);
        bool Delete(int Id);

    }
}
