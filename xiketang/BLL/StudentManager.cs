using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using IBLL;
using IDLL;
using Models;

namespace BLL
{
    public class StudentManager : IStudentManager
    {
        private IStudentService objStudentService = new StudentsService();

        public int AddStudent(Students student)
        {
            return objStudentService.AddStudent(student);
        }

        public int DeleteStudent(Students student)
        {
            throw new NotImplementedException();
        }

        public List<Students> QueryStudents()
        {
            throw new NotImplementedException();
        }
    }
}
