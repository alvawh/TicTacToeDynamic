namespace TicTacToeDynamic
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
            player2 = new Label();
            label1 = new Label();
            playerscore1 = new Label();
            playerscore2 = new Label();
            panel1 = new Panel();
            displayTurn = new Label();
            turn = new Label();
            playAgain = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.BackColor = SystemColors.AppWorkspace;
            player2.Location = new Point(121, 21);
            player2.Name = "player2";
            player2.Size = new Size(64, 20);
            player2.TabIndex = 0;
            player2.Text = "Player O";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Player X";
            // 
            // playerscore1
            // 
            playerscore1.AutoSize = true;
            playerscore1.BackColor = SystemColors.ControlLightLight;
            playerscore1.Location = new Point(46, 41);
            playerscore1.Name = "playerscore1";
            playerscore1.Size = new Size(17, 20);
            playerscore1.TabIndex = 1;
            playerscore1.Text = "0";
            // 
            // playerscore2
            // 
            playerscore2.AutoSize = true;
            playerscore2.BackColor = SystemColors.ControlLightLight;
            playerscore2.Location = new Point(144, 41);
            playerscore2.Name = "playerscore2";
            playerscore2.Size = new Size(17, 20);
            playerscore2.TabIndex = 2;
            playerscore2.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(playAgain);
            panel1.Controls.Add(displayTurn);
            panel1.Controls.Add(turn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(playerscore2);
            panel1.Controls.Add(playerscore1);
            panel1.Controls.Add(player2);
            panel1.Location = new Point(420, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 360);
            panel1.TabIndex = 3;
            // 
            // displayTurn
            // 
            displayTurn.AutoSize = true;
            displayTurn.Location = new Point(121, 95);
            displayTurn.Name = "displayTurn";
            displayTurn.Size = new Size(18, 20);
            displayTurn.TabIndex = 4;
            displayTurn.Text = "X";
            // 
            // turn
            // 
            turn.AutoSize = true;
            turn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            turn.Location = new Point(60, 88);
            turn.Name = "turn";
            turn.Size = new Size(55, 28);
            turn.TabIndex = 3;
            turn.Text = "Turn:";
            // 
            // playAgain
            // 
            playAgain.Location = new Point(60, 289);
            playAgain.Name = "playAgain";
            playAgain.Size = new Size(94, 29);
            playAgain.TabIndex = 5;
            playAgain.Text = "Play Again";
            playAgain.UseVisualStyleBackColor = true;
            playAgain.Click += playAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label player2;
        private Label label1;
        private Panel panel1;
        private Label displayTurn;
        private Label turn;
        private Button playAgain;
    }
}