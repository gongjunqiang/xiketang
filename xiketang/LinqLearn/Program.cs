using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq1();
            //Console.WriteLine("______使用linq_______");
            //Linq2();
          
            Linq3();







            Console.ReadLine();
        }


        #region LinQ
        static void Linq1()
        {
            int[] nums = { 4, 5, 1, 3, 88, 66, 44, 55, 9, 7, 46, 15 };
            List<int> list = new List<int>();
            foreach (var item in nums)
            {
                if (item % 2 == 1)
                {
                    list.Add(item);
                }
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void Linq2()
        {
            int[] nums = { 4, 5, 1, 3, 88, 66, 44, 55, 9, 7, 46, 15 };
            var list = from a in nums
                        where a%2!=0
                        orderby a descending
                        select a;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Linq3()
        {
            int[] nums = { 4, 5, 1, 3, 88, 66, 44, 55, 9, 7, 46, 15 };
            var list = nums.Select(o => o * o);
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            var list1 = nums
                .Where(o => o % 2 != 1)
                .Select(c=>c)
                .OrderBy(b=>b);


            Console.WriteLine(list1);
            Console.WriteLine();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }


        #endregion

    }
}
