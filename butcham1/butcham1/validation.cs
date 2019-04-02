using butcham1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcham1
{
    public class validation
    {
        public static MyContext myContext = new MyContext();

        public validation(MyContext _myContext)
        {
            myContext = _myContext;
        }

        public validation() { }

        public bool Save()
        {
            bool status;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.Write("Success");
            }
            else
            {
                status = false;
                Console.Write("Not Success");
            }
            return status;
        }
    }
        
}

