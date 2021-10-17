using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.Entities;
using PhoneBook.Business.Services;
using PhoneBook.Core.Repository;
using PhoneBook.Business.Enums;
using PhoneBook.Business.Constants;

namespace PhoneBook.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsername.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text))
            {

                IUserService userService = new UserService(new UserRepository());

                var user = new User()
                {
                    Username = txtBoxUsername.Text,
                    Password = txtBoxPassword.Text
                };
                var result = userService.Login(user);

                switch (result)
                {
                    case 1:
                        //Hide the 'current' form
                        this.Hide();
                        //show another form 
                        PhoneBookForm form = new PhoneBookForm();
                        form.ShowDialog();
                        //Close the form
                        this.Close();
                        break;
                    case (int)ResultCodeEnums.ModelStateNoValid:
                        MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show(GlobalConstants.InvalidAttempt, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

            }
            else
            {
                MessageBox.Show(GlobalConstants.Required, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
