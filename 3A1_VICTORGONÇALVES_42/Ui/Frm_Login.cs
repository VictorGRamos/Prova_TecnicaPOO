using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3A1_VICTORGONÇALVES_42.Code.BLL;
using _3A1_VICTORGONÇALVES_42.Code.DTO;
using System.Windows.Forms;

namespace _3A1_VICTORGONÇALVES_42.Ui
{
    public partial class Frm_Login : Form
    {

        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
       
            loginDTO.Email = txt_email.Text;
            loginDTO.Senha = txt_senha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true) 
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

        }
    }
}
