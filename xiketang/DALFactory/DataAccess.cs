using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using IDAL0;
using System.Reflection;

namespace DALFactory
{
    /// <summary>
    /// 基于反射技术编写抽象工厂类
    /// </summary>
    public sealed class DataAccess
    {
        //【1】读取数据库类型
        private static string dbType = ConfigurationManager.AppSettings["dbType"].ToString();

        //【2】获取DAL所在程序及名称
        static  string dalAssemblyName = ConfigurationManager.AppSettings["dalAssemblyName"].ToString();

        //【3】组合需要创建对象的所在命名空间
        private static string path = dalAssemblyName + "." + dbType;

        /// <summary>
        /// 返回学员操作数据访问类对象
        /// </summary>
        /// <returns></returns>
        public static IStudentService CreateStudentService()
        {
            return (IStudentService) Assembly.Load(dalAssemblyName).CreateInstance(path + ".StudentService");
        }

        /// <summary>
        /// 返回学员班级操作数据访问类对象
        /// </summary>
        /// <returns></returns>
        public static IClassService CreateClassService()
        {
            return (IClassService)Assembly.Load(dalAssemblyName).CreateInstance(path + ".StudentClassService");
        }
    }
}
