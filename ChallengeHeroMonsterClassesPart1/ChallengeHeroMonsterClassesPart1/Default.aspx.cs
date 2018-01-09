using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character Hero = new Character();
            Hero.Name = "Dave the Barbarian";
            Hero.Health = 150;
            Hero.DamageMaximum = 20;
            Hero.AttackBonus = true;

            Character Monster = new Character();
            Monster.Name = "Sabertooth Tiger";
            Monster.Health = 150;
            Monster.DamageMaximum = 21;
            Monster.AttackBonus = false;

            int damage = Hero.Attack();
            Monster.Defend(damage);

            damage = Monster.Attack();
            Hero.Defend(damage);

            displayStats(Hero);
            displayStats(Monster);

                
        }

        private void displayStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - Max Damage: {2} - " +
                                           "Attack Bonus: {3}</p>", character.Name, character.Health,
                                           character.DamageMaximum,character.AttackBonus);
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }


        public int Attack()
        {
            Random attackPoints = new Random();
            
            int damage = attackPoints.Next(this.DamageMaximum);
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}