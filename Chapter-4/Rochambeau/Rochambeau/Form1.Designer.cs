namespace Rochambeau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRock = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblScissors = new System.Windows.Forms.Label();
            this.lblRockPaperScissors = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRock
            // 
            this.lblRock.AutoSize = true;
            this.lblRock.Location = new System.Drawing.Point(22, 206);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(33, 13);
            this.lblRock.TabIndex = 0;
            this.lblRock.Text = "Rock";
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Location = new System.Drawing.Point(119, 206);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(35, 13);
            this.lblPaper.TabIndex = 1;
            this.lblPaper.Text = "Paper";
            // 
            // lblScissors
            // 
            this.lblScissors.AutoSize = true;
            this.lblScissors.Location = new System.Drawing.Point(221, 207);
            this.lblScissors.Name = "lblScissors";
            this.lblScissors.Size = new System.Drawing.Size(46, 13);
            this.lblScissors.TabIndex = 2;
            this.lblScissors.Text = "Scissors";
            this.lblScissors.Click += new System.EventHandler(this.lblScissors_Click);
            // 
            // lblRockPaperScissors
            // 
            this.lblRockPaperScissors.AutoSize = true;
            this.lblRockPaperScissors.Location = new System.Drawing.Point(61, 109);
            this.lblRockPaperScissors.Name = "lblRockPaperScissors";
            this.lblRockPaperScissors.Size = new System.Drawing.Size(148, 13);
            this.lblRockPaperScissors.TabIndex = 3;
            this.lblRockPaperScissors.Text = "Let\'s play rock paper scissors!";
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.Control;
            this.btnRock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(12, 222);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(56, 46);
            this.btnRock.TabIndex = 4;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaper.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPaper.Image = ((System.Drawing.Image)(resources.GetObject("btnPaper.Image")));
            this.btnPaper.Location = new System.Drawing.Point(111, 222);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(56, 46);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.SystemColors.Control;
            this.btnScissors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScissors.Image = ((System.Drawing.Image)(resources.GetObject("btnScissors.Image")));
            this.btnScissors.Location = new System.Drawing.Point(216, 222);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(56, 46);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(12, 291);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(182, 83);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWins.Location = new System.Drawing.Point(200, 303);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(48, 15);
            this.lblWins.TabIndex = 8;
            this.lblWins.Text = "Wins : 0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLosses.Location = new System.Drawing.Point(200, 345);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(57, 15);
            this.lblLosses.TabIndex = 9;
            this.lblLosses.Text = "Losses : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblRockPaperScissors);
            this.Controls.Add(this.lblScissors);
            this.Controls.Add(this.lblPaper);
            this.Controls.Add(this.lblRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblScissors;
        private System.Windows.Forms.Label lblRockPaperScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
    }
}

