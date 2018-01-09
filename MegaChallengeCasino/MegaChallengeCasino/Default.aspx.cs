using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayReels();                             
                ViewState.Add("MoneyPot", 100.0);
                displayMoneyPot();                
            }
        }

        protected void betBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            runGamble();                        
        }

        private void runGamble()
        {
            double moneyPot = (double)ViewState["MoneyPot"];
            if (moneyPot > 0)
            {//on pull lever produces 3 random images
                displayReels();

                //calculate winnings
                displayWinnings();

                //calculate money pot            
                displayMoneyPot();
            }
            else displayNoMoney();
            
        }

       

        Random random = new Random();

        //this works
        private string spinReel()
        {
            string[] images = new string[] { "Strawberry.png", "Bar.png", "Lemon.png",
                                             "Bell.png", "Clover.png", "Cherry.png",
                                             "Diamond.png", "Orange.png", "Seven.png",
                                             "HorseShoe.png", "Plum.png", "Watermelon.png" };
            return images[random.Next(11)];
        }


        //this works
        private double getBet()
        {
            double bet = 0.0;

            if ((double.TryParse(betBox.Text, out bet))
                && (betBox.Text.Trim().Length > 0))
                bet = double.Parse(betBox.Text);

            return bet;

        }

        //this works - be careful with how you order if else statements
        //cherries - one is 2x two is 3x three is 4x
        private double getCherries()
        {
            double bet = getBet();
            double cherries = 0.0;

            if (Image1.ImageUrl == "Cherry.png"
                                            && Image2.ImageUrl == "Cherry.png"
                                            && Image3.ImageUrl == "Cherry.png")
            { cherries = bet * 4.0; }

            else if ((Image1.ImageUrl == "Cherry.png" && Image2.ImageUrl == "Cherry.png")
                    || (Image1.ImageUrl == "Cherry.png" && Image3.ImageUrl == "Cherry.png")
                    || (Image2.ImageUrl == "Cherry.png" && Image3.ImageUrl == "Cherry.png"))
            { cherries = bet * 3.0; }            

            else if (Image1.ImageUrl == "Cherry.png"
                            || Image2.ImageUrl == "Cherry.png"
                            || Image3.ImageUrl == "Cherry.png")
            { cherries = bet * 2.0; }
            
            else { cherries = 0.0; }

            return cherries;
        }

        //this works
        //7s - 3 is 100x bet
        private double getJackpot()
        {
            double bet = getBet();
            double jackpot = 0.0;

            if (Image1.ImageUrl == "Seven.png"
                && Image2.ImageUrl == "Seven.png"
                && Image3.ImageUrl == "Seven.png")
            { jackpot = bet * 100.0; }

            else { jackpot = 0.0; }

            return jackpot;
        }

        //this works
        //bar - 1 is win nothing
        private double getBar()
        {
            double bet = getBet();
            double bar = 0.0;

            if (Image1.ImageUrl == "Bar.png"
                || Image2.ImageUrl == "Bar.png"
                || Image3.ImageUrl == "Bar.png")
            { bar = 0.0; }
            else
            { bar = 1.0; }

            return bar;
        }

        private double calculateWinnings()
        {
            double cherries = getCherries();
            double bar = getBar();
            double jackpot = getJackpot();

            double winnings = (cherries + jackpot) * bar;

            return winnings;

        }

        //this works
       private void getMoneyPot()
        {
            double moneyPot = (double)ViewState["MoneyPot"];            
                                
            double bet = getBet();
            double winnings = calculateWinnings();

            
                moneyPot -= bet;
                moneyPot += winnings;
                ViewState["MoneyPot"] = moneyPot;
            
            
            //add double string moneypot here
            //make it add new index for every entry
            //subtract bet
            //add winnings
            //add to view state            
            
        }

        private void displayReels()
        {
            Image1.ImageUrl = spinReel();
            Image2.ImageUrl = spinReel();
            Image3.ImageUrl = spinReel();
        }

        private void displayWinnings()
        {
            double winnings = calculateWinnings();
            double bet = getBet();

            if (winnings > 0)
            { resultsLabel.Text = String.Format("You bet {0:C} and won {1:C}", bet, winnings); }
            else { resultsLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", bet); }
        }

        private void displayMoneyPot()
        {
            getMoneyPot();

            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["MoneyPot"]);
        }

        private void displayNoMoney()
        {
            resultsLabel.Text = String.Format("Sorry, you are out of money. Refresh to play again.");
        }

    }
}