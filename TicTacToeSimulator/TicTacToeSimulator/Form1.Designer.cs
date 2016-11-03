namespace TicTacToeSimulator
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.Label();
            this.A7 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.A5 = new System.Windows.Forms.Label();
            this.A8 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.A6 = new System.Windows.Forms.Label();
            this.A9 = new System.Windows.Forms.Label();
            this.turnIdentiferLabel = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.multiPlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.watchGameButton = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(123, 348);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 19);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // A1
            // 
            this.A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(5, 16);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(57, 61);
            this.A1.TabIndex = 2;
            this.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A1.Click += new System.EventHandler(this.square_click);
            // 
            // A4
            // 
            this.A4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A4.Location = new System.Drawing.Point(70, 16);
            this.A4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(57, 61);
            this.A4.TabIndex = 3;
            this.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A4.Click += new System.EventHandler(this.square_click);
            // 
            // A7
            // 
            this.A7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A7.Location = new System.Drawing.Point(134, 16);
            this.A7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(57, 61);
            this.A7.TabIndex = 4;
            this.A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A7.Click += new System.EventHandler(this.square_click);
            // 
            // A2
            // 
            this.A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A2.Location = new System.Drawing.Point(5, 85);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(57, 61);
            this.A2.TabIndex = 5;
            this.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A2.Click += new System.EventHandler(this.square_click);
            // 
            // A5
            // 
            this.A5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A5.Location = new System.Drawing.Point(70, 85);
            this.A5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(57, 61);
            this.A5.TabIndex = 6;
            this.A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A5.Click += new System.EventHandler(this.square_click);
            // 
            // A8
            // 
            this.A8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A8.Location = new System.Drawing.Point(134, 85);
            this.A8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(57, 61);
            this.A8.TabIndex = 7;
            this.A8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A8.Click += new System.EventHandler(this.square_click);
            // 
            // A3
            // 
            this.A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A3.Location = new System.Drawing.Point(5, 154);
            this.A3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(57, 61);
            this.A3.TabIndex = 8;
            this.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A3.Click += new System.EventHandler(this.square_click);
            // 
            // A6
            // 
            this.A6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A6.Location = new System.Drawing.Point(70, 154);
            this.A6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(57, 61);
            this.A6.TabIndex = 9;
            this.A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A6.Click += new System.EventHandler(this.square_click);
            // 
            // A9
            // 
            this.A9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.A9.Location = new System.Drawing.Point(134, 154);
            this.A9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(57, 61);
            this.A9.TabIndex = 10;
            this.A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.A9.Click += new System.EventHandler(this.square_click);
            // 
            // turnIdentiferLabel
            // 
            this.turnIdentiferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnIdentiferLabel.Location = new System.Drawing.Point(40, 27);
            this.turnIdentiferLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnIdentiferLabel.Name = "turnIdentiferLabel";
            this.turnIdentiferLabel.Size = new System.Drawing.Size(138, 17);
            this.turnIdentiferLabel.TabIndex = 11;
            this.turnIdentiferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_win_count
            // 
            this.x_win_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.x_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_win_count.Location = new System.Drawing.Point(131, 298);
            this.x_win_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(27, 22);
            this.x_win_count.TabIndex = 12;
            this.x_win_count.Text = "0";
            this.x_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_win_count
            // 
            this.o_win_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.o_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_win_count.Location = new System.Drawing.Point(162, 298);
            this.o_win_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(27, 22);
            this.o_win_count.TabIndex = 14;
            this.o_win_count.Text = "0";
            this.o_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "O";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(123, 325);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(69, 19);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear Score";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // multiPlayerButton
            // 
            this.multiPlayerButton.Location = new System.Drawing.Point(27, 327);
            this.multiPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.multiPlayerButton.Name = "multiPlayerButton";
            this.multiPlayerButton.Size = new System.Drawing.Size(75, 37);
            this.multiPlayerButton.TabIndex = 20;
            this.multiPlayerButton.Text = "New Game";
            this.multiPlayerButton.UseVisualStyleBackColor = true;
            this.multiPlayerButton.Click += new System.EventHandler(this.startNewGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "TIC TAC TOE";
            // 
            // watchGameButton
            // 
            this.watchGameButton.Location = new System.Drawing.Point(27, 289);
            this.watchGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.watchGameButton.Name = "watchGameButton";
            this.watchGameButton.Size = new System.Drawing.Size(75, 37);
            this.watchGameButton.TabIndex = 22;
            this.watchGameButton.Text = "Watch Game";
            this.watchGameButton.UseVisualStyleBackColor = true;
            this.watchGameButton.Click += new System.EventHandler(this.populateGameboard);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.A1);
            this.gb.Controls.Add(this.A4);
            this.gb.Controls.Add(this.A7);
            this.gb.Controls.Add(this.A2);
            this.gb.Controls.Add(this.A5);
            this.gb.Controls.Add(this.A8);
            this.gb.Controls.Add(this.A3);
            this.gb.Controls.Add(this.A9);
            this.gb.Controls.Add(this.A6);
            this.gb.Location = new System.Drawing.Point(12, 51);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 221);
            this.gb.TabIndex = 23;
            this.gb.TabStop = false;
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(63, 38);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(100, 13);
            this.InstructionsLabel.TabIndex = 24;
            this.InstructionsLabel.Text = "X Always Goes First";
            this.InstructionsLabel.Visible = false;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 395);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.watchGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiPlayerButton);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.turnIdentiferLabel);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label A4;
        private System.Windows.Forms.Label A7;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label A5;
        private System.Windows.Forms.Label A8;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label A6;
        private System.Windows.Forms.Label A9;
        private System.Windows.Forms.Label turnIdentiferLabel;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button multiPlayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button watchGameButton;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label InstructionsLabel;
    }
}

