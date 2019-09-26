using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICal;
using System.Reflection;

namespace _5._1Refection
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //动态加载程序集，创建对象
            ICalculator cal = (ICalculator)Assembly.LoadFrom("CalDLL.dll").CreateInstance("CalDLL.Calculator");

            var result=cal.Add(Convert.ToInt32(this.txt1.Text), Convert.ToInt32(this.txt2.Text));

            this.lbl2.Text = result.ToString();

        }
    }
}
