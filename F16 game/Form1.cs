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
                
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }
        private void RestartGame() 
        {


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
