using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using IBLL;
using Models;


namespace MyProject
{
    public partial class AddStudent : Form
    {
        //创建业务接口对象
        private IStudentManager objStudentManager = new StudentManager();


        public AddStudent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //1.数据验证

            //2.封装对象

            //调用方法
            try
            {
                int result = objStudentManager.AddStudent(new Students());
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
