using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               string[] spyArray = new string [0];
                ViewState.Add("Asset", spyArray);
                int[] elecArray = new int[0];
                ViewState.Add("Elections", elecArray);
                int[] subArray = new int[0];
                ViewState.Add("Subterfuge", subArray);
            }
            
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string[] spyArray = (string[])ViewState["Asset"];

            Array.Resize(ref spyArray, spyArray.Length + 1);

            int[] elecArray = (int[])ViewState["Elections"];

            Array.Resize(ref elecArray, elecArray.Length + 1);

            int[] subArray = (int[])ViewState["Subterfuge"];

            Array.Resize(ref subArray, subArray.Length + 1);


            int newIndex = spyArray.GetUpperBound(0);

            spyArray[newIndex] = nameBox.Text;

            ViewState["Asset"] = spyArray;

            elecArray[newIndex] = int.Parse(electionsBox.Text);

            ViewState["Elections"] = elecArray;

            subArray[newIndex] = int.Parse(subterfugeBox.Text);

            ViewState["Subterfuge"] = subArray;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br/>(Last Asset You Added: {2}",elecArray.Sum(),subArray.Average(),spyArray[newIndex]);

            nameBox.Text = "";
            electionsBox.Text = "";
            subterfugeBox.Text = "";

        }
    }
}