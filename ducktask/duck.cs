using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducktask
{
    public class duck : myduck , superduck
    {
        public int a;
       public void display()
        {
            Console.WriteLine("enter 1 for finding your duck");
            Console.WriteLine("enter 2 for finding your toy duck");
              a =Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                

                
            }
        }
    }
}
