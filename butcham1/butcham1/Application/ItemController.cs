using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public class ItemController : IItem
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        TB_M_Suppliers supplier = new TB_M_Suppliers();
        TB_M_Items item = new TB_M_Items();

        // List Item
        public List<TB_M_Items> Get()
        {
            var get = myContext.TB_M_Items.Where(x => x.isDelete == false).ToList(); // ToList berfungsi untuk menampilkan 
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t Data Items");
            Console.WriteLine("------------------------------");
            foreach (var list in get)
            {
                Console.Write("Id           :");
                Console.WriteLine(list.Id);
                Console.Write("Name Item    :");
                Console.WriteLine(list.Name);
                Console.Write("Id_Supplier  :");
                Console.WriteLine(list.Suppliers_Id);
                Console.Write("Price        :");
                Console.WriteLine(list.Price);
                Console.Write("Stock        :");
                Console.WriteLine(list.Stock);
                Console.Write("");
            }
            return get;
        }

        // Get Item By Id

        public TB_M_Items Get (int Id)
        {
            Console.Write("Insert your Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }

        //Insert Data Item

        public bool Insert(TB_M_Items item)
        {
            Console.Write("Insert Item Name :");
            string Name = Console.ReadLine(); 
            Console.Write("Insert Id_Supplier :");
            int Suppliers_Id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Price :");
            decimal Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Stock :");
            int Stock = Convert.ToInt16(Console.ReadLine());

            item.Name = Name;
            item.Suppliers_Id = Suppliers_Id;
            item.Price = Price;
            item.Stock = Stock;

            myContext.TB_M_Items.Add(item);
            validation valid = new validation();
            return valid.Save();
            //if (result > 0)
            //{
            //    status = true;
            //    Console.Write("Insert Successfully");
            //}
            //else
            //{
            //    Console.Write("Insert Failed");
            //}
        }

        //Update Data Item

        public bool Update(int Id, TB_M_Items item)
        {
            Console.Write("Insert Your Id :");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            if (get != null)
            {
                Console.Write("Update Item Name :");
                string Name = Console.ReadLine();
                get.Name = Name;

                Console.Write("Update Id_Supplier :");
                int Suppliers_Id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Update Price :");
                decimal Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Update Stock :");
                int Stock = Convert.ToInt16(Console.ReadLine());

                get.Suppliers_Id = Suppliers_Id;
                get.Price = Price;
                get.Stock = Stock;

                myContext.Entry(get).State = EntityState.Modified;
                validation valid = new validation();
                return valid.Save();
                //    if (result > 0)
                //    {
                //        status = true;
                //        Console.Write("Update Successfully");
                //    }
                //    else
                //    {
                //        Console.Write("Update Failed");
                //    }

                //}
                //else
                //{
                //    Console.Write("No Data Found");
                //}
                //return status;
            }return status;
        }

            // delete item
            public bool DeleteItem(int Id)
            {
                Console.Write("Insert Id :");
                Id = Convert.ToInt16(Console.ReadLine());
                var get = myContext.TB_M_Items.Find(Id);
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

