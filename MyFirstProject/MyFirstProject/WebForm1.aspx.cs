﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            string age = ageBox.Text;
            string money = moneyBox.Text;

            string result = "At " + age + " years old, I would have expected you to have more than " + money + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}