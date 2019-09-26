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

        //public override void Having()
        //{
        //    Console.WriteLine("开始吃鱼！");
        //}

        public override bool Equals(object obj)
        {
            Cat objCat = obj as Cat;

            if (objCat.Name == this.Name &&
                objCat.Kind == this.Kind &&
                objCat.Color == this.Color &&
                objCat.Favorite == this.Favorite
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override string ToString()
        {
            return string.Format("种类：{0}，颜色：{1}", this.Kind, this.Color);
        }

        //public  void Test()
        //{
        //    Console.WriteLine("子类");
        //}


    }
}
