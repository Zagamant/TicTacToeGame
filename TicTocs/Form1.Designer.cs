namespace TicTocs
{
    partial class Form1
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
            this.B00 = new System.Windows.Forms.Button();
            this.B01 = new System.Windows.Forms.Button();
            this.B02 = new System.Windows.Forms.Button();
            this.B12 = new System.Windows.Forms.Button();
            this.B11 = new System.Windows.Forms.Button();
            this.B10 = new System.Windows.Forms.Button();
            this.B22 = new System.Windows.Forms.Button();
            this.B21 = new System.Windows.Forms.Button();
            this.B20 = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelXWins = new System.Windows.Forms.Label();
            this.labelYWins = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B00
            // 
            this.B00.Location = new System.Drawing.Point(52, 47);
            this.B00.Name = "B00";
            this.B00.Size = new System.Drawing.Size(82, 78);
            this.B00.TabIndex = 0;
            this.B00.UseVisualStyleBackColor = true;
            this.B00.Click += new System.EventHandler(this.buttonClick);
            // 
            // B01
            // 
            this.B01.Location = new System.Drawing.Point(175, 47);
            this.B01.Name = "B01";
            this.B01.Size = new System.Drawing.Size(82, 78);
            this.B01.TabIndex = 1;
            this.B01.UseVisualStyleBackColor = true;
            this.B01.Click += new System.EventHandler(this.buttonClick);
            // 
            // B02
            // 
            this.B02.Location = new System.Drawing.Point(295, 47);
            this.B02.Name = "B02";
            this.B02.Size = new System.Drawing.Size(82, 78);
            this.B02.TabIndex = 2;
            this.B02.UseVisualStyleBackColor = true;
            this.B02.Click += new System.EventHandler(this.buttonClick);
            // 
            // B12
            // 
            this.B12.Location = new System.Drawing.Point(295, 151);
            this.B12.Name = "B12";
            this.B12.Size = new System.Drawing.Size(82, 78);
            this.B12.TabIndex = 5;
            this.B12.UseVisualStyleBackColor = true;
            this.B12.Click += new System.EventHandler(this.buttonClick);
            // 
            // B11
            // 
            this.B11.Location = new System.Drawing.Point(175, 151);
            this.B11.Name = "B11";
            this.B11.Size = new System.Drawing.Size(82, 78);
            this.B11.TabIndex = 4;
            this.B11.UseVisualStyleBackColor = true;
            this.B11.Click += new System.EventHandler(this.buttonClick);
            // 
            // B10
            // 
            this.B10.Location = new System.Drawing.Point(52, 151);
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(82, 78);
            this.B10.TabIndex = 3;
            this.B10.UseVisualStyleBackColor = true;
            this.B10.Click += new System.EventHandler(this.buttonClick);
            // 
            // B22
            // 
            this.B22.Location = new System.Drawing.Point(295, 252);
            this.B22.Name = "B22";
            this.B22.Size = new System.Drawing.Size(82, 78);
            this.B22.TabIndex = 8;
            this.B22.UseVisualStyleBackColor = true;
            this.B22.Click += new System.EventHandler(this.buttonClick);
            // 
            // B21
            // 
            this.B21.Location = new System.Drawing.Point(175, 252);
            this.B21.Name = "B21";
            this.B21.Size = new System.Drawing.Size(82, 78);
            this.B21.TabIndex = 7;
            this.B21.UseVisualStyleBackColor = true;
            this.B21.Click += new System.EventHandler(this.buttonClick);
            // 
            // B20
            // 
            this.B20.Location = new System.Drawing.Point(52, 252);
            this.B20.Name = "B20";
            this.B20.Size = new System.Drawing.Size(82, 78);
            this.B20.TabIndex = 6;
            this.B20.UseVisualStyleBackColor = true;
            this.B20.Click += new System.EventHandler(this.buttonClick);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(201, 387);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 9;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(302, 387);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelXWins
            // 
            this.labelXWins.AutoSize = true;
            this.labelXWins.Location = new System.Drawing.Point(516, 80);
            this.labelXWins.Name = "labelXWins";
            this.labelXWins.Size = new System.Drawing.Size(35, 13);
            this.labelXWins.TabIndex = 11;
            this.labelXWins.Text = "label1";
            // 
            // labelYWins
            // 
            this.labelYWins.AutoSize = true;
            this.labelYWins.Location = new System.Drawing.Point(516, 184);
            this.labelYWins.Name = "labelYWins";
            this.labelYWins.Size = new System.Drawing.Size(35, 13);
            this.labelYWins.TabIndex = 12;
            this.labelYWins.Text = "label2";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Location = new System.Drawing.Point(516, 285);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(35, 13);
            this.labelDraw.TabIndex = 13;
            this.labelDraw.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.labelYWins);
            this.Controls.Add(this.labelXWins);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.B22);
            this.Controls.Add(this.B21);
            this.Controls.Add(this.B20);
            this.Controls.Add(this.B12);
            this.Controls.Add(this.B11);
            this.Controls.Add(this.B10);
            this.Controls.Add(this.B02);
            this.Controls.Add(this.B01);
            this.Controls.Add(this.B00);
            this.Name = "Form1";
            this.Text = "Tic-tac-toe game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B00;
        private System.Windows.Forms.Button B01;
        private System.Windows.Forms.Button B02;
        private System.Windows.Forms.Button B12;
        private System.Windows.Forms.Button B11;
        private System.Windows.Forms.Button B10;
        private System.Windows.Forms.Button B22;
        private System.Windows.Forms.Button B21;
        private System.Windows.Forms.Button B20;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelXWins;
        private System.Windows.Forms.Label labelYWins;
        private System.Windows.Forms.Label labelDraw;
    }
}

