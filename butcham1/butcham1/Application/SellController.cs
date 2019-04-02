using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using butcham1.Models;
using System.Data.Entity;

namespace butcham1
{                           
    public class SellController : ISell
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Sell sell = new TB_M_Sell();

        // menampilkan semua data
        public List<TB_M_Sell> Get()
        {
            var get = myContext.TB_M_Sell./*Where(x => x.isDelete == false).*/ToList(); 
            Console.WriteLine("------------------------------");
            Console.WriteLine(" Data Sell");
            Console.WriteLine("------------------------------");
            foreach (var list in get)
            {
                Console.Write("Id           :");
                Console.WriteLine(list.Id);
                Console.Write("Order Date   :");
                Console.WriteLine(list.OrderDate);
                Console.Write("");
            }
            return get;
        }

        // menampilkan data berdasarkan Id yang di masukkan
        public TB_M_Sell Get(int Id)
        {
            Console.Write("Insert Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Sell.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }

        public bool Insert(TB_M_Sell sell)
        {
            // throw new NotImplementedException();
            DateTime OrderDate = DateTime.Now;
            Console.Write("Insert Order Date :");
            OrderDate = Convert.ToDateTime(Console.ReadLine());

            sell.OrderDate = OrderDate;

            myContext.TB_M_Sell.Add(sell);
            validation valid = new validation();
            return valid.Save();

        }

        public bool Update(int Id, TB_M_Sell sell)
        {
            // throw new NotImplementedException();

            Console.Write("Insert Id Sell :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Sell.Find(Id);
            if (get != null)
            {
                Console.Write("Update OrderDate :");
                DateTime OrderDate = DateTime.Now;
                sell.OrderDate = OrderDate;            

                myContext.Entry(get).State = EntityState.Modified;
                validation valid = new validation();
                return valid.Save();
            }
            return status;

        }
        public bool Delete(int Id)
        {
            Console.Write("Insert Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Sell.Find(Id);
            if (get != null)
            {
                myContext.Entry(get).State = EntityState.Deleted;
                validation valid = new validation();
                return valid.Save();
            }
            return status;
        }
    }
}
