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
    public class StudentClassManager
    {
        //通过抽象工厂创建数据访问对象

        private IClassService classService = DataAccess.CreateClassService();


        public List<StudentClass> GetAllClass()
        {
            return classService.GetAllClass();
        }
    }
}
