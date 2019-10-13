using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 匿名类与var
            var obj = new { age = 20, name = "小张", id = 10001 };
            Console.WriteLine("姓名：{0}，年龄：{1}，学号：{2}", obj.name, obj.age, obj.id);
            var b = "adadad";
            //var arry = { 1, 2, 3 };
            //var arry1 = new int[] { 1, 2, 3 };

            //var a = null;
            #endregion

            #region 扩展方法
            Console.WriteLine("-----------扩展方法---------------");
            ExtendMethodTest();
            ExtendSrudentTest();
            #endregion

            #region 委托
            Console.WriteLine("-------------委托-------------");
            //3将委托与方法关联：即创建委托对象关联方法
            CalculatorDelegate objAdd = new CalculatorDelegate(Add);
            //4通过委托调用方法
            int result = objAdd(3, 6);
            Console.WriteLine(result);
            //断开委托所关联的方法
            objAdd -= Add;
            //关联减法
            objAdd += Sub;
            Console.WriteLine(objAdd(20, 10));
            #endregion

            #region 匿名方法与Lambal表达式
            Console.WriteLine("-------匿名方法-------");
            CalculatorDelegate add = delegate (int c, int d)
            {
                return c + d;
            };
            Console.WriteLine(add(20,30));
            Console.WriteLine("---Lambal表达式---");
            CalculatorDelegate add1 = (int c, int d)=>{ return c + d; };
            Console.WriteLine(add1(20, 30));
            CalculatorDelegate add2 = ( c,  d) => { return c + d; };
            Console.WriteLine(add2(5,5));
            MathDelegate math = a => a * a;
            Console.WriteLine(math(10));
            #endregion


            Console.ReadLine();
        }



        static void ExtendMethodTest()
        {
            var name = "龚同学";
            name.Any();
            var a = 300;
            Console.WriteLine(name.Name() + a.GetAvg());

        }

        static void ExtendSrudentTest()
        {
            Student student = new Student { Age = 20, StudentName = "龚老师", StudentId = 10000000 };
            Console.WriteLine(student.Extend());
            student.Extend(99,85);
            
        }

        //2.根据委托定义方法
        public static int Add(int c, int b)
        {
            return c + b;
        }


        public static int Sub(int c, int b)
        {
            return c - b;
        }

    }

    //1.声明委托(定义一个函数的原型：返回值+参数类型个数)

    public delegate int CalculatorDelegate(int a, int b);

    public delegate int MathDelegate(int a);
}
