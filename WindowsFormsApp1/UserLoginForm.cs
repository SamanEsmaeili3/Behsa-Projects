using Models;
using Service;
using System;
using Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserLoginForm : Form
    {
        UserService _userService = new UserService();
        //PhoneBookRespository _phoneBookRepository = new PhoneBookRespository(); 
        Models.User user = new Models.User();

        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var users = _userService.GetUsers();
            var user = users.FirstOrDefault(x => x.userName == txtbox_username.Text);
            if (user != null && users.Contains(user))
            {
                //TODO: Open this user Phone book
                
                if (user.password.Equals(txtbox_passworde.Text))
                {
                    PhoneBookRespository _phoneBookRepository = new PhoneBookRespository(user);
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
              
            }
            //TODO: show message box and say error
            else
            {
                MessageBox.Show("No user found! try sign up");
            }


        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            var users = _userService.GetUsers();
            var user = new User();
            if(!string.IsNullOrEmpty(txtbox_username.Text) && !string.IsNullOrEmpty(txtbox_passworde.Text)){
                //add user
                user.userName = txtbox_username.Text;
                user.password = txtbox_passworde.Text;
                user.phoneBookFilePath = "";
                _userService.SaveUser(user);
                PhoneBookRespository _phoneBookRepository = new PhoneBookRespository(user);
                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill both of username and password!");
            }
        }


    }
}
