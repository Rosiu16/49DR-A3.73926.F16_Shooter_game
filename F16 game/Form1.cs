using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F16_game
{
    public partial class F16 : Form
    {
        bool goUp, goDown, shot, gameOver;

        int score = 0;
        int speed = 8;
        int UFOspeed = 10;

        Random rand = new Random();

        int playerSpeed = 7;
        int index = 0; 
        
        public F16()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;

            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;

            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (shot == false)
            {

                shot = true;
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
                
        private void RestartGame() 
        {
            goUP = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;

            txtScore.Text = "Score:  " + score;

            ChangeUFO();


        }

        private void GameOver()
        { 
        
        }
        private void RemoveBullet(PictureBox bullet)
        { 
        
        }
        private void MakeBullet()
        { 
        
        }

        private void ChangeUFO()
        {


        }
    }

}
