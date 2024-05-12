namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPUtimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(214, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 30);
            label2.TabIndex = 1;
            label2.Text = "Computer wins: ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(31, 88);
            button1.Name = "button1";
            button1.Size = new Size(115, 115);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerButton;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(152, 88);
            button2.Name = "button2";
            button2.Size = new Size(115, 115);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerButton;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(273, 88);
            button3.Name = "button3";
            button3.Size = new Size(115, 115);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Location = new Point(31, 209);
            button4.Name = "button4";
            button4.Size = new Size(115, 115);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerButton;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Location = new Point(152, 209);
            button5.Name = "button5";
            button5.Size = new Size(115, 115);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerButton;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Location = new Point(273, 209);
            button6.Name = "button6";
            button6.Size = new Size(115, 115);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerButton;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDark;
            button7.Location = new Point(31, 330);
            button7.Name = "button7";
            button7.Size = new Size(115, 115);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerButton;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.Location = new Point(152, 330);
            button8.Name = "button8";
            button8.Size = new Size(115, 115);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerButton;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDark;
            button9.Location = new Point(273, 330);
            button9.Name = "button9";
            button9.Size = new Size(115, 115);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerButton;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlDark;
            button10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.Location = new Point(152, 451);
            button10.Name = "button10";
            button10.Size = new Size(115, 43);
            button10.TabIndex = 11;
            button10.Text = "RESTART";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RestartGame;
            // 
            // CPUtimer
            // 
            CPUtimer.Interval = 1000;
            CPUtimer.Tick += CPUmove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(416, 514);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUtimer;
    }
}
