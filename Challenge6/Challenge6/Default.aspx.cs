using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge6
{
    public partial class Default : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            double budget = GetBudget();
            bool vacation = HadEnoughVacation();
            bool assignment = NotNegativeAssignment();

            if(vacation == false) { 
            resultLabel.Text = "You must allow at least 14 days between assignments.";
            startCalendar.SelectedDate = prevCalendar.SelectedDate.AddDays(14);
            }

            else if (assignment == false)
            {
                resultLabel.Text = "Assignment must be at least one day long.";
                endCalendar.SelectedDate = startCalendar.SelectedDate.AddDays(1);
            }

            else if(vacation == true && assignment == true) { 
            resultLabel.Text = String.Format("Success. You have assigned spy {0}" +
                                                 " to project {1}.<br/> Total Budget: {2:C}",
                                                 TextBox1.Text,TextBox2.Text,budget);
            }
        }

        private double GetBudget()
        {
            TimeSpan assignmentDays = new TimeSpan();

            assignmentDays = (endCalendar.SelectedDate.Date - startCalendar.SelectedDate.Date);

            double budget = assignmentDays.TotalDays * 500;

            if (assignmentDays.TotalDays > 21)
            {
                budget += 1000;
            }
            else
            {
                budget += 0;
            }

            return budget;
        }

        private bool HadEnoughVacation()
        {
            TimeSpan elapsedDays = new TimeSpan();

            elapsedDays = (startCalendar.SelectedDate.Date - prevCalendar.SelectedDate.Date);

            if (elapsedDays.TotalDays < 14)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool NotNegativeAssignment()
        {
            TimeSpan elapsedDays = new TimeSpan();

            elapsedDays = (endCalendar.SelectedDate.Date - startCalendar.SelectedDate.Date);

            if (elapsedDays.TotalDays <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}