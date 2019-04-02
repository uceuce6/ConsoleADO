using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISupplier iSupplier = new SupplierController(); 
            TB_M_Suppliers supplier = new TB_M_Suppliers();

            IItem iItem = new ItemController();
            TB_M_Items item = new TB_M_Items();

            ISell iSell = new SellController();
            TB_M_Sell sell = new TB_M_Sell();
            int Id = 0;

            Console.WriteLine("------Menu----------");
            Console.WriteLine("====================");
            Console.WriteLine("1. Menu Supplier");
            Console.WriteLine("2. Menu Item");
            Console.WriteLine("3. Menu Sell");
            Console.WriteLine("4. Menu Transaction");
            Console.WriteLine("--------------------");
            Console.WriteLine("Tentukan Pilihanmu: ");
            int numberMenu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("====================");
            Console.WriteLine("Action");
            Console.WriteLine("====================");
            Console.WriteLine("1. View All data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("--------------------");
            Console.WriteLine("Tentukan Pilihanmu: ");

            int number = Convert.ToInt32(Console.ReadLine());
            if (numberMenu == 1)
            {
                switch (number)
                {
                    case 1:
                        iSupplier.Get();
                        break;
                    case 2:
                        iSupplier.Insert(supplier);
                        break;
                    case 3:
                        iSupplier.Update(Id, supplier);
                        break;
                    case 4:
                        iSupplier.Delete(Id);
                        break;
                }
            }
            else if (numberMenu == 2)
            {
                switch (number)
                {
                    case 1:
                        iItem.Get();
                        break;
                    case 2:
                        iItem.Insert(item);
                        break;
                    case 3:
                        iItem.Update(Id, item);
                        break;
                    case 4:
                        iItem.DeleteItem(Id);
                        break;
                }
            }
            else if (numberMenu == 3)
            {
                switch (number)
                {
                    case 1:
                        iSell.Get();
                        break;
                    case 2:
                        iSell.Insert(sell);
                        break;
                    case 3:
                        iSell.Update(Id, sell);
                        break;
                    case 4:
                        iSell.Delete(Id);
                        break;
                }
            }
            else
            {
                Console.Write("Data No Found");

            }
                Console.Read();

            //}
            //else if (numberMenu == 2)
            //{
             
            //    iItem.Insert(item);
              
            //}
            //else if (numberMenu == 3)
            //{
               
            //    iItem.Update(item);
          
            //}
            //else if (numberMenu == 4)
            //{
              
            //    iItem.DeleteItem();
            
            //}

            //// supplier
          
            //if (number == 1)
            //{
            //    iSupplier.Get();

            //    //iSupplier = new SupplierController();
            //    //iSupplier.Get();
            //}
            //else if (number == 2)
            //{
            //    iSupplier.Insert(supplier);
  
            //    //iSupplier = new SupplierController();
            //    //iSupplier.Insert(supplier);
            //}
            //else if (number == 3)
            //{
            //    iSupplier.Update(supplier);
       
            //    //iSupplier = new SupplierController();
            //    //iSupplier.Update(supplier);
            //}
            //else if (number == 4)
            //{
            //    iSupplier.Delete(supplier);
   
            //    //iSupplier = new SupplierController();
            //    //iSupplier.Delete(supplier);
            //}
            


        }
    }
}
