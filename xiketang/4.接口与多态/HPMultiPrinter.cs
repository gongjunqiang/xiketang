using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.接口与多态
{
    class HPMultiPrinter : IMultiPrinter
    {
        /// <summary>
        /// 复印
        /// </summary>
        /// <param name="content"></param>
        public void Copy(string content)
        {
            Console.WriteLine("欢迎使用HP打印机");
            Console.WriteLine("HP正在复印：" + content);
        }

        /// <summary>
        /// 传真
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public bool Fax(string content)
        {
            Console.WriteLine("欢迎使用HP打印机");
            Console.WriteLine("HP正在传真：" + content);
            return true;
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="content"></param>
        public void Print(string content)
        {
            Console.WriteLine("欢迎使用HP打印机");
            Console.WriteLine("HP正在打印："+content);

        }
    }
}
