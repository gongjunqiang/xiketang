using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models0;
using DALFactory;
using IDAL0;

namespace BLL0
{
    public class StudentManager
    {
        //方法一：直接通过new DAL;不使用接口，直接创建对象
        //private StudentService studentService = new StudentService();

        //方法二：通过接口直接创建对象；
        //private IStudentService studentService = new StudentService();

        

        //方法三：通过抽象工厂创建DAL,实现DAL动态替换
        private IStudentService studentService = DataAccess.CreateStudentService();



        public int AddStudent(Students student)
        {
            return studentService.AddStudent(student);
        }

        public int DeleteStudent(Students student)
        {
            return studentService.DeleteStudent(student);
        }

        public Students GetStudentById(string studentId)
        {
            return studentService.GetStudentById(studentId);
        }

        public List<Students> GetStudents()
        {
            return studentService.GetStudents();
        }

        public List<Students> GetStudentsByClass(string className)
        {
            return studentService.GetStudentsByClass(className);
        }

        public bool IsIdNoExisted(string idNo, string studentId)
        {
            return studentService.IsIdNoExisted(idNo, studentId);
        }

        public bool IsIdNoExisted(string studentIdNo)
        {
            return studentService.IsIdNoExisted(studentIdNo);
        }

        public int ModifyStudent(Students student)
        {
            return studentService.ModifyStudent(student);
        }


    }
}
