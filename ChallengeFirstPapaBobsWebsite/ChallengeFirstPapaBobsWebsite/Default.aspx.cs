using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void babySizeRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            double totalPrice = 0.00;

            if (babySizeRadio.Checked)
            {
                totalPrice = 10.00;
            }
            else if (mamaSizeRadio.Checked)
            {
                totalPrice = 13.00;
            }
            else if (papaSizeRadio.Checked)
            {
                totalPrice = 16.00;
            }

            if (thinCrustRadio.Checked)
            {
                totalPrice = totalPrice + 0.00;
            }
            else if (ddCrustRadio.Checked)
            {
                totalPrice = totalPrice + 2.00;
            }

            if (pepperoniCheck.Checked)
            {
                totalPrice = totalPrice + 1.50;
            }
            
            if (onionsCheck.Checked)
            {
               totalPrice = totalPrice + 0.75;
            }

            if (gPeppersCheck.Checked)
            {
                totalPrice = totalPrice + 0.50;
            }

            if (rPeppersCheck.Checked)
            {
                totalPrice = totalPrice + 0.75;
            }

            if (anchoviesCheck.Checked)
            {
                totalPrice = totalPrice + 2.00;
            }

            if ((pepperoniCheck.Checked 
                && gPeppersCheck.Checked 
                && anchoviesCheck.Checked)
                || (pepperoniCheck.Checked
                && rPeppersCheck.Checked
                && onionsCheck.Checked))
            {
                totalLabel.Text = "Total: $" + (totalPrice - 2.00);
            }
            else
            {
                totalLabel.Text = "Total: $" + totalPrice;
            }
            
        }
    }
}