using System.Diagnostics.CodeAnalysis;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        CheckBox myCheckBox = new CheckBox();
        //myCheckBox.Checked = true;
        //this.Controls.Add(myCheckBox);

        bool isPlayerTurn = true;
        bool isPlayingWithCPU = true;

        public enum Player
        {
            X, O
        }

        Player CurrentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int computerWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();

            //Добавление возможности играть с компьютером или другом

            RadioButton cpuRB = new RadioButton();
            cpuRB.Text = "Do you want to play with CPU?";
            cpuRB.Checked = true;
            cpuRB.CheckedChanged += CpuRadioButton_CheckedChanged;

            RadioButton playWithFriend = new RadioButton();
            playWithFriend.Text = "Play with friend";
            playWithFriend.CheckedChanged += new EventHandler(PlayerRadioButton_CheckedChanged);
        }
        private void CpuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isPlayingWithCPU = true;
        }
        private void PlayerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isPlayingWithCPU = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PlayerButton(object sender, EventArgs e)
        {
            if (!isPlayerTurn) return; // Если не очередь игрока, возвращаемся

            var button = (Button)sender;
            CurrentPlayer = Player.X;
            button.Text = CurrentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            CPUtimer.Start();

            if(isPlayingWithCPU)
            {
                CPUtimer.Start();
            }
            else
            {

            }
            isPlayerTurn = false; // Переключаем флаг, чтобы остановить игрока
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (isPlayingWithCPU && buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                CurrentPlayer = Player.O;
                buttons[index].Text = CurrentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                CheckGame();
                CPUtimer.Stop();
                isPlayerTurn = true; // Включаем режим игрока снова
            }
        }


        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                 || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                 || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                 || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                 || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                 || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                 || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                 || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                CPUtimer.Stop();
                MessageBox.Show("Player Wins!", "Game Over");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                CPUtimer.Stop();
                MessageBox.Show("Computer Wins!", "Game Over");
                computerWinCount++;
                label2.Text = "Computer Wins: " + computerWinCount;
                RestartGame();
            }
        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4,
                button5, button6, button7, button8, button9};

            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = " ";
                button.BackColor = DefaultBackColor;

            }
        }

        private void Xbutton_Click(object sender, EventArgs e)
        {

        }
        private void Obutton_Click(object sender, EventArgs e)
        {

        }

        private void CPU_Click(object sender, EventArgs e)
        {         
        }

        private void Friend_Click(object sender, EventArgs e)
        {
        }
    }
}
