using System;
using System.Linq;
using System.Windows.Forms;
using PhoneBook.Business_.Constants;
using PhoneBook.Business_.Enums;
using PhoneBook.Business_.Services;
using PhoneBook.Core_.Repository;
using PhoneBook.Entities_;

namespace PhoneBook.UI.CROSS
{
    public partial class PhoneBookForm : Form
    {
        private readonly IContactService _contactService;
        public PhoneBookForm()
        {
            _contactService = new ContactService(new ContactRepository());
            InitializeComponent();
        }
        private void PhoneBookForm_Load(object sender, EventArgs e)
        {
            AddToListBox();
        }


        private void btn_Create_Click(object sender, EventArgs e)
        {
            var contact = new Contact()
            {

                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                Email = textBoxEmail.Text,
                Website = textBoxWebsite.Text,
                Address = textBoxAddress.Text,
                Description = textBoxDescription.Text,
                Number1 = textBoxNumber1.Text,
                Number2 = textBoxNumber2.Text,
                Number3 = textBoxNumber3.Text
            };

            var contacts = _contactService.Add(contact);

            switch (contacts)
            {
                case 1:
                    AddToListBox();
                    break;
                case (int)ResultCodeEnums.ModelStateNoValid:
                    MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            var selectedItem = (Contact)listBox.SelectedItem;
            textBoxName.Text = selectedItem.Name;
            textBoxSurname.Text = selectedItem.Surname;
            textBoxEmail.Text = selectedItem.Email;
            textBoxWebsite.Text = selectedItem.Website;
            textBoxAddress.Text = selectedItem.Address;
            textBoxDescription.Text = selectedItem.Description;
            textBoxNumber1.Text = selectedItem.Number1;
            textBoxNumber2.Text = selectedItem.Number2;
            textBoxNumber3.Text = selectedItem.Number3;
        }

        
        

        #region helper Methods
        private void AddToListBox()
        {
            listBoxContact.DataSource = null;

            var contacts = _contactService.GetAll();

            if (contacts.Any())
            {
                listBoxContact.DataSource = contacts;
            }
        }

        #endregion

        

        
        private void btnImportJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;

            int result = _contactService.ImportJson(path);

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            {
                var selectedItem = (Contact)listBoxContact.SelectedItem;

                if (selectedItem == null)
                {
                    MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var entity = new Contact()
                {
                    Id = selectedItem.Id,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    Website = textBoxWebsite.Text,
                    Address = textBoxAddress.Text,
                    Description = textBoxDescription.Text,
                    Number1 = textBoxNumber1.Text,
                    Number2 = textBoxNumber2.Text,
                    Number3 = textBoxNumber3.Text
                };

                var result = _contactService.Update(entity);

                switch (result)
                {
                    case 1:
                        AddToListBox();
                        MessageBox.Show(GlobalConstants.UpdateSuccess, GlobalConstants.UpdateSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case (int)ResultCodeEnums.ModelStateNoValid:
                        MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }

        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            var selectedItem = (Contact)listBoxContact.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var result = _contactService.Delete(selectedItem.Id);

            switch (result)
            {
                case 1:
                    AddToListBox();
                    MessageBox.Show(GlobalConstants.DeleteSuccess, GlobalConstants.DeleteSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)ResultCodeEnums.ModelStateNoValid:
                    MessageBox.Show(GlobalConstants.ModelStateNotValid, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnExportJson_Click_1(object sender, EventArgs e)
        {
            var result = _contactService.ExportJSON();

            switch (result)
            {
                case 1:
                    MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnExportXML_Click_1(object sender, EventArgs e)
        {
            var result = _contactService.ExportXML();

            switch (result)
            {
                case 1:
                    MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnExportCSV_Click_1(object sender, EventArgs e)
        {
            var result = _contactService.ExportCSV();

            switch (result)
            {
                case 1:
                    MessageBox.Show(GlobalConstants.Success, GlobalConstants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    MessageBox.Show(GlobalConstants.Fail, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        
    }
}
