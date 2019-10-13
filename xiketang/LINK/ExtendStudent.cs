using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINK
{
    static class ExtendStudent
    {
        /// <summary>
        /// 为密封类扩展方法
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static string Extend(this Student student)
        {

            return "欢迎您" + student.StudentName;
        }


        /// <summary>
        /// 为密封类扩展方法
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static void Extend(this Student student,int csharp,int db)
        {
            Console.WriteLine("姓名：{0}，年龄：{1}，C#:{2}分，数据库:{3}分", student.StudentName, student.Age, csharp, db);
        }

    }
}
