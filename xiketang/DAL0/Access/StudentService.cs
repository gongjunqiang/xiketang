using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;//访问access数据库
using IDAL0;
using Models0;

namespace DAL0.Access
{
    public class StudentService : IStudentService
    {
        public int AddStudent(Students student)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(Students student)
        {
            throw new NotImplementedException();
        }

        public Students GetStudentById(string studentId)
        {
            throw new NotImplementedException();
        }

        public List<Students> GetStudents()
        {
            throw new NotImplementedException();
        }

        public List<Students> GetStudentsByClass(string className)
        {
            throw new NotImplementedException();
        }

        public bool IsIdNoExisted(string idNo, string studentId)
        {
            throw new NotImplementedException();
        }

        public bool IsIdNoExisted(string studentIdNo)
        {
            throw new NotImplementedException();
        }

        public int ModifyStudent(Students student)
        {
            throw new NotImplementedException();
        }
    }
}
