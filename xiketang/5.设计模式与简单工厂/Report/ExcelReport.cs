using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveDesignModelAndFactory
{
    class ExcelReport : IReport
    {
        public void StartPrint()
        {
            MessageBox.Show("正在调用Excel报表程序");
        }
    }
}
