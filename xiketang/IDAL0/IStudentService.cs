using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models0;

namespace IDAL0
{
    public interface IStudentService
    {
        int AddStudent(Students student);
        int DeleteStudent(Students student);
        List<Students> GetStudents();
        List<Students> GetStudentsByClass(string className);
        Students GetStudentById(string studentId);
        bool IsIdNoExisted(string idNo, string studentId);
        bool IsIdNoExisted(string studentIdNo);
        int ModifyStudent(Students student);
    }
}
