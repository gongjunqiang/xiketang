using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang
{
    public class Dog:Animal
    {

        //public Dog(string name, string color, string kind)
        //    :base(name, color, kind)
        //{
        //}



        public Dog(string name, string color, string kind)
            : base(name, color, kind)
        {

            this.Name = name;
            this.Color = color;
            this.Kind = kind;
        }

        public Dog()
        {
        }
        //public string Name { get; set; }
        //public string Color { get; set; }
        //public string Kind { get; set; }

        //public string Favorite { get; set; }
        ////自我介绍
        //public void Introduce()
        //{
        //    string info = string.Format("我是{0}，我的名字{1}，身穿{2}得颜色，我爱吃{3}", Kind, Name, Color, Favorite);

        //    Console.WriteLine(info);
        //}

        //赛跑
        public void Race()
        {
            base.Introduce();
            base.protectedTest();
            Console.WriteLine("开始赛跑！");
        }

        //public void Having()
        //{
        //    Console.WriteLine("开始吃肉！");
        //}

        public override void Having()
        {
            Console.WriteLine("开始吃肉！");
        }
    }
}
