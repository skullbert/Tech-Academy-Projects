using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDay = firstCalendar.SelectedDate;
            DateTime secondDay = secondCalendar.SelectedDate;

            if (firstDay > secondDay)
            {
                TimeSpan daySpan = firstDay.Subtract(secondDay);
                resultLabel.Text = daySpan.TotalDays.ToString();
            }
            else if (secondDay > firstDay)
            {
                TimeSpan daySpan = secondDay.Subtract(firstDay);
                resultLabel.Text = daySpan.TotalDays.ToString();
            }

            
        }
    }
}