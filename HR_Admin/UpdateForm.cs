using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Admin
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void contactfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            // VERIFIES IF INPUT IS A DIGIT
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void emrgcyContactfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            // VERIFIES IF INPUT IS A DIGIT
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void salaryfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            // VERIFIES IF INPUT IS A DIGIT
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Create_KeyPress(object sender, KeyPressEventArgs e)
        {
            String id = IDfield.Text;
            String fName = fNamefield.Text;
            String lName = lNamefield.Text;
            String MI = MIfield.Text;
            String sex = genderfield.Text;
            String birthdate = bdayfield.Text;
            String email = emailfield.Text;
            String contact = contactfield.Text;
            String religion = religionfield.Text;
            String marital = maritalfield.Text;
            String nationality = nationalityfield.Text;
            String currentAddress = currentAddfield.Text;
            String permanentAdd = perAddfield.Text;
            String emergencyCont = emrgcyContactfield.Text;
            String dateofEmployment = dateofEmploymentfield.Text;
            String position = positionfield.Text;
            String salary = salaryfield.Text;
            DBConnect dbc = new DBConnect();
            String query1 = "UPDATE employee SET(fname='"+fName+ ",'MI='" + MI + ",'lname='" + lName + ",'sex='" + sex + ",'birthdate='" + birthdate + ",'" +
                "           birthdate='" + birthdate + ",'email='" + email + ",'contact='" + contact + ",'religion='" + religion + ",'marital_status='" + marital + ",'nationality='" + nationality + ",'" +
                "           current_address='" + currentAddress + ",'permanent_adress='" + permanentAdd + ",'emergency_contact='" + emergencyCont + ",') WHERE id='"+id+"')";
            String query2 = "UPDATE companyposition SET(company_position='"+position+",'salary='"+salary+",') WHERE id='"+id+"')";
            dbc.UpdateUser(query1, query2);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
