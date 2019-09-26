using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.继承与多态
{
    public class A
    {
        public virtual void Test()
        {
            Console.WriteLine("I am A，我是基类");
        }
    }

    public class B : A
    {
        public new void Test()
        {
            Console.WriteLine("I am B, 标识符是new");
        }
    }

    public class C : A
    {
        public override void Test()
        {
            Console.WriteLine("I am C, 标识符是override");
        }
    }

    public class TestNew
    {
        public void Go()
        {
            A a = new A();
            Console.WriteLine("A - New A, call Test is: ");
            a.Test();

            A ab = new B();
            Console.WriteLine("A - New B, call Test is: ");
            ab.Test();


            B b = new B();
            Console.WriteLine("B - New B, call Test is: ");
            b.Test();

            A ac = new C();
            Console.WriteLine("A - New C, call Test is: ");
            ac.Test();

            C c = new C();
            Console.WriteLine("C - New C, call Test is: ");
            c.Test();
        }
    }
}
