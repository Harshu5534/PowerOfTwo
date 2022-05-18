using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worshop
{
    public class PowerOfTwo
    {
        public void PowerTable()
        {
            int i = 0;
            Console.WriteLine("Enter The Number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                Console.WriteLine("2" +" "+"^"+" "+i+"="+Math.Pow(2,i));
            }
        }
    }
}
