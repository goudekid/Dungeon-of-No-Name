using ConsoleRedirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_of_No_Name
{
    public partial class MainForm : Form
    {

        TextWriter _writer = null;

        Loc[,] map = new Loc[10,10];

        Player player;

        public MainForm()
        {
            InitializeComponent();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            String[] invText = { "You inspect your belongings.", "You open your backpack.",
                "You check your pack.", "You take inventory of your inventory.", "You look in your bags.",
                "You assay your attaché." };

            Random rand = new Random();

            int i = rand.Next(0, invText.Length);

            Console.WriteLine(invText[i]);

            // TODO: Actual inventory stuff goes here

        }

        private void abilityButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What ability will you use?");

            // TODO: ability menu stuff
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            String[] restText = { "You take a siesta.", "You rest for a bit.",
                "You doze for a mite.", "You have a nap.", "You acquire some \"Z's\".",
                "You take \"Forty Winks.\"" };

            Random rand = new Random();

            int i = rand.Next(0, restText.Length);

            Console.WriteLine(restText[i]);

            // TODO: Actual resting goes here


        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (player.CurrLocation.HasAttackableTarget == true)
            {
                doCombat(player);

            } else
            {
                Console.WriteLine("There's nothing here to attack!");
            }
        }

        private void upMovementButton_Click(object sender, EventArgs e)
        {
            if (player.CurrLocation.HasNorthExit == true)
            {
                Console.WriteLine("You head north.");

                player.Facing = 'n';

                // if we've not been to the location we're trying to go to yet, generate it and place it in the grid
                // if that location already exists, just go there instead
                if (map[player.CurrLocation.xCoord, player.CurrLocation.yCoord + 1] == null)
                {
                    map[player.CurrLocation.xCoord, player.CurrLocation.yCoord + 1] = Loc.GenerateRandomLocation(3, player.CurrLocation.xCoord, player.CurrLocation.yCoord + 1);
                    player.CurrLocation = map[player.CurrLocation.xCoord, player.CurrLocation.yCoord + 1];
                } else
                {
                    player.CurrLocation = map[player.CurrLocation.xCoord, player.CurrLocation.yCoord + 1];
                }

                update();

            } else
            {
                Console.WriteLine("There's a wall there!");
            }
        }

        private void leftMovementButton_Click(object sender, EventArgs e)
        {
            if (player.CurrLocation.HasWestExit == true)
            {
                Console.WriteLine("You head west.");

                player.Facing = 'w';

                // if we've not been to the location we're trying to go to yet, generate it and place it in the grid
                // if that location already exists, just go there instead
                if (map[player.CurrLocation.xCoord - 1, player.CurrLocation.yCoord] == null)
                {
                    map[player.CurrLocation.xCoord - 1, player.CurrLocation.yCoord] = Loc.GenerateRandomLocation(3, player.CurrLocation.xCoord - 1, player.CurrLocation.yCoord);
                    player.CurrLocation = map[player.CurrLocation.xCoord - 1, player.CurrLocation.yCoord];
                }
                else
                {
                    player.CurrLocation = map[player.CurrLocation.xCoord - 1, player.CurrLocation.yCoord];
                }

                update();
            }
            else
            {
                Console.WriteLine("There's a wall there!");
            }
        }

        private void downMovementButton_Click(object sender, EventArgs e)
        {
            if (player.CurrLocation.HasSouthExit == true)
            {
                Console.WriteLine("You head south.");

                player.Facing = 's';

                // if we've not been to the location we're trying to go to yet, generate it and place it in the grid
                // if that location already exists, just go there instead
                if (map[player.CurrLocation.xCoord, player.CurrLocation.yCoord - 1] == null)
                {
                    map[player.CurrLocation.xCoord, player.CurrLocation.yCoord - 1] = Loc.GenerateRandomLocation(1, player.CurrLocation.xCoord, player.CurrLocation.yCoord - 1);
                    player.CurrLocation = map[player.CurrLocation.xCoord, player.CurrLocation.yCoord - 1];
                }
                else
                {
                    player.CurrLocation = map[player.CurrLocation.xCoord, player.CurrLocation.yCoord - 1];
                }

                update();
            }
            else
            {
                Console.WriteLine("There's a wall there!");
            }
        }

        private void rightMovementButton_Click(object sender, EventArgs e)
        {
            if (player.CurrLocation.HasEastExit == true)
            {
                Console.WriteLine("You head east.");

                player.Facing = 'e';

                // if we've not been to the location we're trying to go to yet, generate it and place it in the grid
                // if that location already exists, just go there instead
                if (map[player.CurrLocation.xCoord + 1, player.CurrLocation.yCoord] == null)
                {
                    map[player.CurrLocation.xCoord + 1, player.CurrLocation.yCoord] = Loc.GenerateRandomLocation(4, player.CurrLocation.xCoord + 1, player.CurrLocation.yCoord);
                    player.CurrLocation = map[player.CurrLocation.xCoord + 1, player.CurrLocation.yCoord];
                }
                else
                {
                    player.CurrLocation = map[player.CurrLocation.xCoord + 1, player.CurrLocation.yCoord];
                }

                update();
            }
            else
            {
                Console.WriteLine("There's a wall there!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _writer = new TextBoxStreamWriter(logTextBox);
            Console.SetOut(_writer);

            map[3,3] = Loc.GenerateRandomLocation();

            map[3, 3].xCoord = 3;
            map[3, 3].yCoord = 3;

            player = new Player(100, 100, 20, map[3, 3]);

            player.Facing = 'n';



            // this goes at the bottom
            update();
        }

        private void update()
        {
            // updating the viewbox with exits and monsters etc

            if (player.CurrLocation.HasAttackableTarget == true)
            {
                viewTextBox.Text = (player.CurrLocation.ExitsAsString() + "There is a " + player.CurrLocation.Monster.Name + " here."
                + System.Environment.NewLine + player.CurrLocation.xCoord + "," + player.CurrLocation.yCoord);
            } else

                viewTextBox.Text = (player.CurrLocation.ExitsAsString()
                    + System.Environment.NewLine + player.CurrLocation.xCoord + "," + player.CurrLocation.yCoord);

            // player status
            healthLabel.Text = player.CurrHealth.ToString() + " / " + player.MaxHealth.ToString();
            exhaustionLabel.Text = player.CurrExhaustion.ToString() + " / " + player.MaxExhaustion.ToString();

            changeView();

        }

        private void changeView()
        {
            bool n, s, e, w;
            n = player.CurrLocation.HasNorthExit;
            s = player.CurrLocation.HasSouthExit;
            e = player.CurrLocation.HasEastExit;
            w = player.CurrLocation.HasWestExit;

            if (player.CurrLocation.NumExits == 1)
                viewPort.Image = Properties.Resources.deadend;
            else if (player.CurrLocation.NumExits == 2)
            {
                if (n && !e && !w)
                    viewPort.Image = Properties.Resources.north;
                else if (!n && e && !w)
                    viewPort.Image = Properties.Resources.east;
                else if (!n && !e && w)
                    viewPort.Image = Properties.Resources.west;
                else if (n && e && !w)
                    viewPort.Image = Properties.Resources.northandeast;
                else if (n && !e && w)
                    viewPort.Image = Properties.Resources.northandwest;
                else if (!n && e && w)
                    viewPort.Image = Properties.Resources.westandeast;
            }
            else if (player.CurrLocation.NumExits == 3)
            {
                if (n && e && !w)
                    viewPort.Image = Properties.Resources.northandeast;
                else if (n && !e && w)
                    viewPort.Image = Properties.Resources.northandwest;
                else if (!n && e && w)
                    viewPort.Image = Properties.Resources.westandeast;
            }
            else if (player.CurrLocation.NumExits == 4)
                viewPort.Image = Properties.Resources.all;
        }

        private void doCombat(Player p)
        {
            Console.WriteLine("You attack the " + p.CurrLocation.Monster.Name + "!");

            Console.WriteLine("You deal " + p.Attack + " damage.");

            p.CurrLocation.Monster.Health -= p.Attack;

            if (p.CurrLocation.Monster.Health <= 0)
            {
                Console.WriteLine("The " + p.CurrLocation.Monster.Name + " dies.");
                p.CurrLocation.HasAttackableTarget = false;
            }
            else
            {

                Console.WriteLine("The " + p.CurrLocation.Monster.Name + " attacks you and deals " + p.CurrLocation.Monster.AttackStrength + " damage.");

                p.CurrHealth -= p.CurrLocation.Monster.AttackStrength;

            }

            update();
        }

    }
}
