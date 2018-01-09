using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  //1. Reverse your name
             string name = "Sarah Hulbert";           

             //trebluH haraS

             for (int i = name.Length - 1; i >= 0; i--)
             {
                resultLabel.Text += name[i];
             }
             */
             

            /*//2.Reverse this string
            string names = "Luke,Leia,Han,Chewbacca";
            string[] chars  = names.Split(',');
            string result = "";

            for (int i = chars.Length-1; i >=0; i--)
            {
                result += chars[i] + ",";
            }

            result = result.Remove(result.Length - 1, 1);

            resultLabel.Text =  result;*/

            //3. Create ASCII art
            /*
             *****luke*****
             *****leia*****
             *****han******
             **chewbacca***
             */

          
            string names = "Luke,Leia,Han,Chewbacca";
            string[] chars = names.Split(',');
            string result = "";

            for (int i = 0; i < chars.Length; i++)
            {
                int padLeft = (14 - chars[i].Length) / 2;
                string temp = chars[i].PadLeft(chars[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }

            resultLabel.Text = result;


            // 4. Solve this puzzle:

          /* string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            int index = puzzle.IndexOf("NOW");

            resultLabel.Text = puzzle.ToLower().Replace('z', 't').Replace("remove-me", "").Replace("now","Now");*/
            
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
    }
}