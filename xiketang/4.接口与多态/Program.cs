using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.接口与多态
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //创建对象（通过接口创建）
        //    IMultiPrinter printer = new HPMultiPrinter();
        //    IMultiPrinter printer1 = new HCPrinter();


        //    printer.Print("学生学习表");
        //    printer.Copy("学生成绩表");
        //    printer.Fax("录取名单表");
        //    Console.WriteLine("----------------");

        //    printer1.Print("学生学习表");
        //    printer1.Copy("学生成绩表");
        //    printer1.Fax("录取名单表");

        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            //创建对象（通过接口创建）
            Test(new HPMultiPrinter());
            Console.WriteLine("---------------");
            Test(new HCPrinter());
            Console.ReadLine();
        }

        static void Test(IMultiPrinter printer)
        {
            printer.Print("学生学习表");
            printer.Copy("学生成绩表");
            printer.Fax("录取名单表");
        }


    }
}
