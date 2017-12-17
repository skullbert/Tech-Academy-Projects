using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class CalculatorForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addValues_Click(object sender, EventArgs e)
        {
           int i = int.Parse(firstValue.Text);
            int j = int.Parse(secondValue.Text);
            
            resultLabel.Text = (i + j).ToString();

        }

        protected void subtractValues_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValue.Text);
            int j = int.Parse(secondValue.Text);

            resultLabel.Text = (i - j).ToString();
        }

        protected void multiplyValues_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstValue.Text);
            int j = int.Parse(secondValue.Text);

            resultLabel.Text = (i * j).ToString();
        }

        protected void divideValues_Click(object sender, EventArgs e)
        {
            decimal i = decimal.Parse(firstValue.Text);
            decimal j = decimal.Parse(secondValue.Text);

            resultLabel.Text = (i / j).ToString();                        
        }
    }
}