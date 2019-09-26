using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang
{
    public abstract class Animal
    {
        public Animal(string name,string color,string kind)
        {
            this.Name = name;
            this.Color = color;
            this.Kind = kind;
        }

        public Animal()
        {
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Kind { get; set; }

        public string Favorite { get; set; }
        //自我介绍
        public void Introduce()
        {
            string info = string.Format("我是{0}，我的名字{1}，身穿{2}得颜色，我爱吃{3}", Kind, Name, Color, Favorite);

            Console.WriteLine(info);
        }

        private void privatetest()
        {
            Console.WriteLine("private");
        }

        protected void protectedTest()
        {
            Console.WriteLine("private");
        }

        //定义抽象方法
        //public abstract void Having();

        public virtual void Having()
        {
            Console.WriteLine("我要吃饭");
        }


        public void Test()
        {
            Console.WriteLine("父类");
        }

    }
}
