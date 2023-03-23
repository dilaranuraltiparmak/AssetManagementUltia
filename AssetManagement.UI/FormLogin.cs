using AssetManagement.DAL;
using AssetManagement.DTO;
using AssetManagement.DTO.DTO;
using AssetManagement.Provider;
using SolutionSepet.Extentions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetManagement.UI
{
    public partial class FormLogin : Form
    {
        Login login = new Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            Login();

        }



        public void Login()
        {

            LoginDAL loginDal = new LoginDAL();
            loginDal.Select(login);
            login.UserName = txtUserName.Text;
            login.Password = txtPassword.Text;
            SqlDataReader rdr = loginDal.myDatabase.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Başarılı giriş");

                FormMain frmmain = new FormMain();
                frmmain.Show();
                this.Hide();
            }
            else
            {
                Temizle();
                MessageBox.Show("Hatalı kullanıcı bilgisi girdiniz");
        
            }
        }
        private void Temizle()
        {
            txtPassword.Text = txtUserName.Text = string.Empty;
        }





        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}

