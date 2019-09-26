using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;


namespace FiveDesignModelAndFactory
{
    public class Factory
    {
        ////【1】定义接口变量
        //static IReport report = null;

        ////【2】读取配置文件
        //private static string reportType = ConfigurationManager.AppSettings["ReportType"];

        ////【3】根据配置文件创建对象

        //public static IReport ChooseReportType()
        //{

        //    switch (reportType)
        //    {
        //        case "ExcelReport":
        //            report = new ExcelReport();
        //            break;
        //        case "WordReport":
        //            report = new WordReport();
        //            break;
        //        case "CrystalReport":
        //            report = new CrystalReport();
        //            break;
        //    }

        //    return report;
        //}

        #region 使用反射
        //【1】定义接口变量
        static IReport report = null;

        //【2】读取配置文件
        private static string reportType = ConfigurationManager.AppSettings["ReportType"];

        public static IReport ChooseReportType()
        {
            report = (IReport)Assembly.Load("FiveDesignModelAndFactory").CreateInstance("FiveDesignModelAndFactory."+ reportType);
            return report;
        }


        #endregion






    }
}
