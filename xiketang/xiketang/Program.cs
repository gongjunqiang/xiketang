using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //使用对象初始化器创建对象
        //    Cat cat = new Cat("","","")
        //    {
        //        Name = "球球",
        //        Color = "白",
        //        Kind = "猫",
        //        Favorite ="小鱼" 
        //    };
        //    Dog dog = new Dog("","","")
        //    {
        //        Name = "狗狗",
        //        Color = "黑",
        //        Kind = "狗",
        //        Favorite = "肉"
        //    };

        //    Console.WriteLine("自我介绍");
        //    cat.Introduce();
        //    dog.Introduce();
        //    Console.WriteLine("--------------------------------");
        //    Console.WriteLine("开始表演");
        //    cat.Dancing();
        //    dog.Race();
        //    Console.Read();
        //}


        static void Main(string[] args)
        {
            //使用对象初始化器创建对象
            Cat cat = new Cat()
            {
                Name = "球球",
                Color = "白",
                Kind = "猫",
                Favorite = "小鱼"
            };
            Dog dog = new Dog()
            {
                Name = "狗狗",
                Color = "黑",
                Kind = "狗",
                Favorite = "肉"
            };
            //将子类添加到父类集合
            List<Animal> list =new List<Animal>();
            list.Add(cat);
            list.Add(dog);

            List<object> list1 = new List<object>();
            list1.Add(cat);
            list1.Add(dog);


            foreach (var animal in list)
            {
               animal.Having();
            }


            //foreach (var animal in list)
            //{
            //    //Cat cat1 = (Cat) animal;
            //    //cat1.Having();
            //    if (animal is Cat)
            //        ((Cat)animal).Having();
            //    else
            //    {
            //        ((Dog)animal).Having();
            //    }
            //}

            Console.Read();
        }
    }
}
