using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xiketang;

namespace _2.继承与多态
{
    class Program
    {
        static void Main(string[] args)
        {
            TestNew nNew = new TestNew();
            nNew.Go();

            int a = 10;
            Console.WriteLine(a.ToString());

            Console.WriteLine(a.Equals(10));
            Cat cat = new Cat()
            {
                Name = "球球",
                Color = "白",
                Kind = "猫",
                Favorite = "小鱼"
            };
            cat.Test();


            Animal animal1 =new Cat();
            animal1.Test();

            Console.WriteLine(cat.ToString());

            Cat cat2 = new Cat()
            {
                Name = "球球",
                Color = "白",
                Kind = "猫",
                Favorite = "小鱼"
            };
            Console.WriteLine(cat.Equals(cat2));

            Dog dog = new Dog()
            {
                Name = "狗狗",
                Color = "黑",
                Kind = "狗",
                Favorite = "肉"
            };

            Console.WriteLine(cat.Equals(dog));


            List<Animal> list =new List<Animal>();

            list.Add(cat);
            list.Add(dog);

            foreach (var animal in list)
            {
                animal.Having();
            }

            Console.WriteLine("-------------is------------------------");
            foreach (var animal in list)
            {
                if (animal is Cat)
                {
                    ((Cat)animal).Having();
                }
                else if (animal is Dog)
                {
                    ((Dog)animal).Having();
                }
            }

            Console.WriteLine("-----------------as--------------------");
            foreach (var animal in list)
            {
                if (animal is Cat)
                {
                    Cat cat1 = animal as Cat;
                    cat1.Having();
                }
                else if (animal is Dog)
                {
                    Dog dog1 = animal as Dog;
                    dog1.Having();
                }
            }

            Console.WriteLine("-------------------里氏替换原则");

            Test(cat);
            Test(dog);


            Console.ReadLine();
        }


        static void Test(Animal objAnimal)
        {
            objAnimal.Having();
        }

    }
}
