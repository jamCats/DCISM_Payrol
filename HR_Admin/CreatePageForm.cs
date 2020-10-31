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
    public partial class CreatePageForm : Form
    {
        public CreatePageForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNamefield_TextChanged(object sender, EventArgs e)
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

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salaryfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            String query1 = "INSERT INTO employee(fname,MI,lname,sex,birthdate,email,contact,religion,marital_status,nationality" +
                            "current_address,permanent_address,emergency_contact,date_of_employment) VALUES('"+fName+ ",''" + lName + ",''" + MI + ",''" + sex + ",'" +
                            "'" + birthdate + ",''" + email + ",''" + contact + ",''" + religion + ",''" + marital + ",''" + nationality + ",''" + currentAddress + ",''"
                            + permanentAdd + ",''" + fName + ",'" +"'" + emergencyCont + ",''" + dateofEmployment + ")";
            String query2 = "INSERT INTO companyPosition(company_position,salary) VALUES('"+position+ ",'" + salary+ ")";
            dbc.CreateUser(query1, query2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
