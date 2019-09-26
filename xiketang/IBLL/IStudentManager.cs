using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace IBLL
{
    public interface IStudentManager
    {
        int AddStudent(Students student);

        int DeleteStudent(Students student);

        List<Students> QueryStudents();
    }
}
