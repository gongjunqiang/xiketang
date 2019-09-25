using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang
{
    public class Cat: Animal
    {
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
        public Cat(string name, string color, string kind)
            :base(name,color,kind)
        {
        }

        public Cat()
        {
        }
        //跳舞
        public void Dancing()
        {
            Console.WriteLine("开始跳舞！");
        }

        //public void Having()
        //{
        //    Console.WriteLine("开始吃鱼！");
        //}

        public override void Having()
        {
            Console.WriteLine("开始吃鱼！");
        }

    }
}
