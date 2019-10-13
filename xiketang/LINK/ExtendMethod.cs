using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINK
{
    /// <summary>
    /// 定义扩展方法
    /// </summary>
    static class ExtendMethod
    {
        public static int GetAvg(this int sum)
        {
            return sum / 5;
        }

        public static string Name(this string name)
        {
            return string.Format("{0}好，您的平均成绩为：",name);
        }
    }


}
