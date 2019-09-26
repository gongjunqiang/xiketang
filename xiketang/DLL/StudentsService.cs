using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDLL;
using Models;

namespace DLL
{
    public class StudentsService : IStudentService
    {
        public int AddStudent(Students student)
        {
            return 1;
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
