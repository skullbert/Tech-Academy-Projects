using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }


        protected void heightBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void lengthBox_TextChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        protected void nextDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            performChanged();
        }

        private void performChanged()
        {
            if (!valuesExist()) return;

            int volume = 0;
            if (!tryGetVolume(out volume)) return;

            double postageMultiplier = getPostageMultiplier();

            double cost = volume * postageMultiplier;

            resultLabel.Text = String.Format("Your package will cost {0:C} to ship.",cost);
        }

        private double getPostageMultiplier()
        {
            if (groundRadio.Checked) return .15;
            else if (airRadio.Checked) return .25;
            else if (nextDayRadio.Checked) return .45;
            else return 0;

        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private bool valuesExist()
        {
            if (!airRadio.Checked
                && !groundRadio.Checked
                && !nextDayRadio.Checked)
                return false;

            if (widthBox.Text.Trim().Length == 0
                || heightBox.Text.Trim().Length == 0)
                return false;

            else
                return true;
        }

        //define variables for length, width, height - int try parse?
        //method to determine volume of package
        //multiplier method when radiobutton checked
        //maybe in same method? maybe new method for check to see if width and height given
        //in properties post back on event click
    }
}