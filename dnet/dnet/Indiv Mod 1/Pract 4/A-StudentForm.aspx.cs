using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentRegistration
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            if (chkTerms.Checked)
            {
                lblOutput.Text = "Student Name : " + txtName.Text +
                    "<br/>Gender : " + gender +
                    "<br/>Course : " + ddlCourse.SelectedValue +
                    "<br/>Date : " + calDate.SelectedDate.ToShortDateString();
            }
            else
            {
                lblOutput.Text = "Please accept Terms & Conditions";
            }
        }
    }
}