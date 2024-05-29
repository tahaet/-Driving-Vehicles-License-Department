using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using MySolution.Properties;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace MySolution.People
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        //particularly -1 as it is important for logic 
        private int _PersonID=-1;
        public int PersonID
        { 
            get { return _PersonID;} 
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;

        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            //very necessary for logic
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName.ToString();
            lblDateOfBirth.Text=_Person.DateOfBirth.ToString();
            lblNationalNo.Text=_Person.NationalNo.ToString();
            lblEmail.Text=_Person.Email.ToString(); 
            lblAddress.Text=_Person.Address.ToString();
            lblCountry.Text=_Person.CountryInfo.CountryName.ToString();
            lblGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblPhone.Text=_Person.Phone.ToString();
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            pbPersonImage.Image = _Person.Gendor == 0 ? Resources.Male_512 : Resources.Female_512;
            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation= ImagePath;
                
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LoadPersonInfo(int PersonID)
        {
            //Necessary
            _PersonID = PersonID;
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
