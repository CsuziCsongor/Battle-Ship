using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Battle_Ship
{
    public partial class Form1 : Form
    {
        List<Button> playerPositionButtons;
        List<Button> enemyPositionButtons;

        Random rand = new Random();

        int totalShips = 3;
        int round = 15;
        int playerScore;
        int enemyScore;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {

        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {

        }

        private void PlayerPositionButtonEvent(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            playerPositionButtons = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPositionButtons = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4};

            EnemyLocationListBox.Items.Clear();

            EnemyLocationListBox.Text = null;

            txtHelp.Text = "1. Kattintson három különböző helyre a kezdéshez!";

            for(int i = 0; i < enemyPositionButtons.Count; i++)
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                enemyPositionButtons[i].BackColor = Color.White;
                enemyPositionButtons[i].BackgroundImage = null;
                EnemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);

            }

            for(int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                playerPositionButtons[i].BackColor = Color.White;
                playerPositionButtons[i].BackgroundImage = null;

            }

            playerScore = 0;
            enemyScore = 0;
            round = 15;
            totalShips = 3;

            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            btnAttack.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();


        }

        private void enemyLocationPicker()
        {
            for(int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPositionButtons.Count);

                if(enemyPositionButtons[index].Enabled == true && (string)enemyPositionButtons[index].Tag == null)
                {
                    enemyPositionButtons[index].Tag = "ellenséges hajó";

                    Debug.WriteLine("Ellenség poziciója: " + enemyPositionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(enemyPositionButtons.Count);
                }
            }

        }
    }
}
