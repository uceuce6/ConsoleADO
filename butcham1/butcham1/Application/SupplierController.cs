using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public class SupplierController : ISupplier
    {
        public static MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Suppliers tb_M_Suppliers = new TB_M_Suppliers();

        // method untuk menampilkan supplier
        public List<TB_M_Suppliers> Get()
        {
            // throw new NotImplementedException();
            var get = myContext.TB_M_Suppliers.Where(x => x.isDelete == false).ToList(); // ToList berfungsi untuk menampilkan 
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t Data Supplier");
            Console.WriteLine("------------------------------");
            foreach (var list in get)
            {
                Console.Write("Id               :");
                Console.WriteLine(list.Id);
                Console.Write("Name Supplier    :");
                Console.WriteLine(list.Name);
                Console.Write("");
            }
            return get;
        }

        public bool Insert(TB_M_Suppliers supplier)
        {
            // throw new NotImplementedException();
            Console.Write("Insert Your Name :");
            String Name = Console.ReadLine(); // bedanya String "s" kecil dan "S" besar "s" kecil punya bahasa c#
            supplier.Name = Name;
            myContext.TB_M_Suppliers.Add(supplier);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.Write("Insert Successfully");
            }
            else
            {
                Console.Write("Insert Failed");
            }
            return status;
        }

        public bool Update(int Id, TB_M_Suppliers supplier)
        {
            // throw new NotImplementedException();
            Console.Write("Insert Your Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            if (get != null)
            {
                Console.Write("Insert Your ID  :");
                String Name = Console.ReadLine();
                get.Name = Name;
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    Console.Write("Update Successfully");
                }
                else
                {
                    Console.Write("Update Failed");
                }

            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;

        }
        public bool Delete(int Id)
        {
            // throw new NotImplementedException();
            Console.Write("Insert Your Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Id);
            if (get != null)
            {
                myContext.Entry(get).State = System.Data.Entity.EntityState.Deleted;
                var result = myContext.SaveChanges();
                if (result > 0)
                {
                    status = true;
                    Console.Write("Delete Successfully");
                }
                else
                {
                    Console.Write("Delete Failed");
                }

            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;

        }

        public TB_M_Suppliers Get(int id)
        {
            Console.Write("Insert your Id :");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }
    }
}