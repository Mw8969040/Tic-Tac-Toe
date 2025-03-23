using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter1 = 0;
        int counter2 = 0;

        TimeSpan result;

        Random random = new Random();
       
        void checkbutton(Button button)
        {
            if (button.Tag.ToString() == "x" || button.Tag.ToString() == "o")
            {
                MessageBox.Show("Error: Button already clicked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Player_Case.Text == "Player 1" && button.Tag.ToString() == "questionmark")
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                button.Image = Resources.X;
                Player_Case.Text = "Player 2";
                button.Tag = "x";
                counter1 = 2;
                timer1.Enabled = true;
            }

            else if (Player_Case.Text == "Player 2" && button.Tag.ToString() == "questionmark")
            {

                button.Image = Resources.O;
                Player_Case.Text = "Player 1";
                button.Tag = "o";
                result = new TimeSpan(0, 0, 10);
                timer2.Enabled = true;
            }

            CheckWinner();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            counter1--;
           if (counter1 == 0) 
           {
                timer1.Enabled = false;
                PerformComputerMove();
           }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            result = result.Subtract(TimeSpan.FromSeconds(1));

            label4.Text = "Timer: " + result.ToString();
            if (result.TotalSeconds == 0)
            {
                timer2.Enabled = false;
                PerformComputerMove();
            }

        }
        void PerformComputerMove()
        {
          
            if (Player_Case.Text == "Player 2" ||Player_Case.Text == "Player 1" )
            {
                Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
                Button chosenButton = null;

                do
                {
                    chosenButton = buttons[random.Next(buttons.Length)];
                }
                while (chosenButton.Tag.ToString() == "x" || chosenButton.Tag.ToString() == "o");

                checkbutton(chosenButton);
            }
        }

        void FinalResult(Button FirstButton , Button SecondButton , Button ThirdButton)
        {
            timer2.Enabled = false;
            FirstButton.BackColor = SecondButton.BackColor = ThirdButton.BackColor = Color.Lime;
            WinnerName.Text = FirstButton.Tag.ToString()=="x" ? "Player 1" : "Player 2";
            Player_Case.Text = "Game Over";
            SystemSounds.Exclamation.Play();

            MessageBox.Show($"Congratulations, {WinnerName.Text} won the game!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void CheckWinner()
        {
            if ((button1.Tag.ToString() == "x" && button2.Tag.ToString() == "x" && button3.Tag.ToString() == "x") ||
                (button1.Tag.ToString() == "o" && button2.Tag.ToString() == "o" && button3.Tag.ToString() == "o"))
            {
                FinalResult(button1,button2,button3);
                return;
            }

            if ((button4.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button6.Tag.ToString() == "x") ||
                (button4.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button6.Tag.ToString() == "o"))
            {
                FinalResult(button4, button5, button6);
                return;
            }

            if ((button7.Tag.ToString() == "x" && button8.Tag.ToString() == "x" && button9.Tag.ToString() == "x") ||
                (button7.Tag.ToString() == "o" && button8.Tag.ToString() == "o" && button9.Tag.ToString() == "o"))
            {
                FinalResult(button7, button8, button9);
                return;
            }

            if ((button1.Tag.ToString() == "x" && button4.Tag.ToString() == "x" && button7.Tag.ToString() == "x") ||
                (button1.Tag.ToString() == "o" && button4.Tag.ToString() == "o" && button7.Tag.ToString() == "o"))
            {
                FinalResult(button1, button4, button7);
                return;
            }

            if ((button2.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button8.Tag.ToString() == "x") ||
                (button2.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button8.Tag.ToString() == "o"))
            {
                FinalResult(button2, button5, button8);
                return;
            }

            if ((button3.Tag.ToString() == "x" && button6.Tag.ToString() == "x" && button9.Tag.ToString() == "x") ||
                (button3.Tag.ToString() == "o" && button6.Tag.ToString() == "o" && button9.Tag.ToString() == "o"))
            {
                FinalResult(button3, button6, button9);
                return;
            }

            if ((button1.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button9.Tag.ToString() == "x") ||
                (button1.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button9.Tag.ToString() == "o"))
            {
                FinalResult(button1, button5, button9);
                return;
            }

            if ((button3.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button7.Tag.ToString() == "x") ||
                (button3.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button7.Tag.ToString() == "o"))
            {
                FinalResult(button3, button5, button7);
                return;
            }

            if (button1.Tag.ToString() != "questionmark" &&
                button2.Tag.ToString() != "questionmark" &&
                button3.Tag.ToString() != "questionmark" &&
                button4.Tag.ToString() != "questionmark" &&
                button5.Tag.ToString() != "questionmark" &&
                button6.Tag.ToString() != "questionmark" &&
                button7.Tag.ToString() != "questionmark" &&
                button8.Tag.ToString() != "questionmark" &&
                button9.Tag.ToString() != "questionmark")
            {
                WinnerName.Text = "Draw";
                Player_Case.Text = "Game Over";
                button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.Red;
                SystemSounds.Exclamation.Play();

                MessageBox.Show("There is not winner ! ", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(Black);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 630, 200, 250, 200);  
            e.Graphics.DrawLine(pen, 630, 320, 250, 320); 
            e.Graphics.DrawLine(pen, 370, 100, 370, 420);
            e.Graphics.DrawLine(pen, 500, 100, 500, 420);
        }
        private void button_Click(object sender, EventArgs e)
        {
            checkbutton((Button)sender);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Tag = button2.Tag = button3.Tag = button4.Tag = button5.Tag = button6.Tag = button7.Tag = button8.Tag = button9.Tag = "questionmark";

            button1.Image = button2.Image = button3.Image = button4.Image = button5.Image = button6.Image = button7.Image = button8.Image = button9.Image = Resources.questionmark;

            button1.BackColor = button2.BackColor = button3.BackColor =button4.BackColor =button5.BackColor=button6.BackColor=button7.BackColor=button8.BackColor=button9.BackColor= Color.Black;

            Player_Case.Text = "Player 1";

            WinnerName.Text = "n Progress";

            result = new TimeSpan(0, 0, 10);
            timer2.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            result = new TimeSpan(0,0,10);
            timer2.Enabled = true;
        }

    }
}
