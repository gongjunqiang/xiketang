using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiveDesignModelAndFactory;

namespace FiveDesignModelAndFactory
{
    public partial class FrmPrint : Form
    {
        public FrmPrint()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            #region 直接通过接口创建对象
            //通过接口创建对象，调用不同的打印报表：此方法调用的报表是写死的，无法很好的可扩展性
            //IReport report = new ExcelReport();
            //report.StartPrint();
            #endregion


            #region 通过工厂创建对象
            var report = Factory.ChooseReportType();
            report.StartPrint();
            #endregion


        }
    }
}
