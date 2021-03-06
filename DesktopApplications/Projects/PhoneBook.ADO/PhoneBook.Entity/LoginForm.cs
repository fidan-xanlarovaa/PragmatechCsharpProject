using PhoneBook.Entities_;
using System;
using System.Windows.Forms;
using PhoneBook.Business_.Constants;
using PhoneBook.Business_.Enums;
using PhoneBook.Business_.Services;
using PhoneBook.Core_.Repository;

namespace PhoneBook.UI.CROSS
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
                UserService userService = new UserService(new UserRepository());

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


