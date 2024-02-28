using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO 3.3 Set the text value of the finalGrade label to "Submit your grade percentage to see your final grade!". Watch out for post backs
            if (!IsPostBack)
            {
                finalGrade.Text = "Submit your grade percentage to see your final grade!";
            }
        }
        protected void Calculate(object sender, EventArgs e)
        {
            double grade = int.Parse(percentageGrade.Text);
            if (grade < 60)
            {
                grade = 5.00;
            }
            else if (grade >= 60 && grade <= 64.50)
            {
                grade = 3.00;
            }
            else if (grade >= 64.51 && grade <= 69)
            {
                grade = 2.75;
            }
            else if (grade >= 69.01 && grade <= 73.50)
            {
                grade = 2.50;
            }
            else if (grade >= 73.51 && grade <= 78)
            {
                grade = 2.25;
            }
            else if (grade >= 78.01 && grade <= 82.50)
            {
                grade = 2.00;
            }
            else if (grade >= 82.51 && grade <= 87)
            {
                grade = 1.75;
            }
            else if (grade >= 87.01 && grade <= 91.50)
            {
                grade = 1.50;
            }
            else if (grade >= 91.51 && grade <= 96)
            {
                grade = 1.25;
            }
            else if (grade >= 96)
            {
                grade = 1.00;
            }
            finalGrade.Text = grade.ToString();

            if (grade == 1.00)
            {
                string script = "alert('Congratulations!');";
                ClientScript.RegisterStartupScript(this.GetType(), "CongratsScript", script, true);
            }
        }
    }
}