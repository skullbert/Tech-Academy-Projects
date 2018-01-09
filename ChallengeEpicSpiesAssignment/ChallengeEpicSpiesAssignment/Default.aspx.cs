using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                prevCalendar.SelectedDate = DateTime.Now.Date;
                startCalendar.SelectedDate = DateTime.Now.AddDays(14).Date;
                projCalendar.SelectedDate = DateTime.Now.AddDays(21).Date;
            }
        }

        protected void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            DateTime prevAssignment = prevCalendar.SelectedDate;
            DateTime startAssignment = startCalendar.SelectedDate;
            DateTime projAssignment = projCalendar.SelectedDate;
            TimeSpan budgetDays = projAssignment.Subtract(startAssignment);
            var budgetTotal = budgetDays.TotalDays * 500;

            

            

            if (budgetDays.TotalDays > 21)
            {
                budgetTotal += 1000;
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total is: {2:C}.", nameBox.Text, assignmentBox.Text, budgetTotal);

            TimeSpan unionDays = startAssignment.Subtract(prevAssignment);

            if (unionDays.TotalDays < 14)
            {
                resultLabel.Text = "Error: you must allow at least fourteen days between assignments.";
            }

            DateTime earliestStart = prevCalendar.SelectedDate.AddDays(14);

            startCalendar.SelectedDate = earliestStart;
            startCalendar.VisibleDate = earliestStart;

        }
    }
}