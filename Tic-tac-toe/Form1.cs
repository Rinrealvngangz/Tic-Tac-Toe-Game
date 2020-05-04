using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string play;
        private void gofirst_Click_1(object sender, EventArgs e)
        {
            checkPlayer();
            btn.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        public void checkPlayer()
        {
            Random random = new Random();
            int num = random.Next(2);
            bool[] mangKT = { true, false };
            bool p = mangKT[num];
            if (p == true)
            {
                MessageBox.Show("Player1 Go First");
            }
            else
                MessageBox.Show("Player2 Go First");

            if (p == true)
            {
                play = "X";
            }
            else
                play = "O";
        }
        public void checkGo()
        {
            if (play == "X")
            {
                play = "O";

                p1.ForeColor = Color.Blue;
                if (p1.ForeColor == Color.Blue)
                {
                    p2.ForeColor = Color.Black;
                };
            }
            else {
                play = "X";
                p2.ForeColor = Color.Red;
                if (p2.ForeColor == Color.Red)
                {
                    p1.ForeColor = Color.Black;
                };
            }
           
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            btn.Text = play;
            checkGo();
            btn.Enabled = false;
            checkWin();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = play;
            checkGo();
            btn1.Enabled = false;
            checkWin();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
              
            btn5.Text = play;
            checkGo();
            btn5.Enabled = false;
            checkWin();
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
                
            btn4.Text = play;
            checkGo();
            btn4.Enabled = false;
            checkWin();
           
      
        }

        private void btn2_Click(object sender, EventArgs e)
        {
                  
            btn2.Text = play;
            checkGo();
            btn2.Enabled = false;
            checkWin();
         
  
        }

        private void btn6_Click(object sender, EventArgs e)
        {
          
           
            btn6.Text = play;
            checkGo();
            btn6.Enabled = false;
            checkWin();
      
        }

        private void btn7_Click(object sender, EventArgs e)
        {    
            btn7.Text = play;
            checkGo();
            btn7.Enabled = false;
            checkWin();
         
        }

        private void btn8_Click(object sender, EventArgs e)
        {
               
           btn8.Text = play;
            checkGo();
            btn8.Enabled = false;
            checkWin();
        
        }

        private void btn9_Click(object sender, EventArgs e)
        {                 
            btn9.Text = play;
            checkGo();
            btn9.Enabled = false;
            checkWin();
          
        }
        public void check_Who_Win()
        {
            if (play == "X")
            {
                play = "O";
                MessageBox.Show("Player 2 Win");
            }
            else if (play == "O")
            {
                play = "X";
                MessageBox.Show("Player 1 Win");
            }
            

        }
        public void playAgain()
        {
            btn.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            p2.ForeColor = Color.Black;
            p1.ForeColor = Color.Black;

        }
        public void checkWin()
        {
                    
             
            if ((btn.Text == "X") && (btn5.Text == "X") && (btn1.Text == "X") || (btn.Text == "O") && (btn5.Text == "O") && (btn1.Text == "O"))

                check_Who_Win();


            else if ((btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X") || (btn7.Text == "O") && (btn4.Text == "O") && (btn1.Text == "O"))
                check_Who_Win();

            else if ((btn5.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X") || (btn5.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O"))

                check_Who_Win();

            else if ((btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X") || (btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O"))

                check_Who_Win();

            else if ((btn1.Text == "X") && (btn2.Text == "X") && (btn9.Text == "X") || (btn1.Text == "O") && (btn2.Text == "O") && (btn9.Text == "O"))

                check_Who_Win();

            else if ((btn2.Text == "X") && (btn5.Text == "X") && (btn7.Text == "X") || (btn2.Text == "O") && (btn5.Text == "O") && (btn7.Text == "O"))

                check_Who_Win();

            else if ((btn4.Text == "X") && (btn2.Text == "X") && (btn6.Text == "X") || (btn4.Text == "O") && (btn2.Text == "O") && (btn6.Text == "O"))

                check_Who_Win();

            else if ((btn.Text == "X") && (btn2.Text == "X") && (btn8.Text == "X") || (btn.Text == "O") && (btn2.Text == "O") && (btn8.Text == "O"))

                check_Who_Win();
            else if ((btn.Enabled == false) && (btn1.Enabled == false) && (btn2.Enabled == false) && (btn4.Enabled == false) && (btn5.Enabled == false) && (btn6.Enabled == false) && (btn7.Enabled == false) && (btn8.Enabled == false) && (btn9.Enabled == false))
            {
                MessageBox.Show("Hoa!!!");
            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            playAgain();
          
        }
    }

     
    }

