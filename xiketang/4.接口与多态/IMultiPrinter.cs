using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.接口与多态
{
    interface IMultiPrinter
    {
        //打印
        void Print(string content);
        //复印
        void Copy(string content);
        //传真
        bool Fax(string content);
    }
}
