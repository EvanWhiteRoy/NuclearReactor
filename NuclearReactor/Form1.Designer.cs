namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactorLabel1 = new System.Windows.Forms.Label();
            this.reactorLabel2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2Statelabel = new System.Windows.Forms.Label();
            this.reactor5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.Nuclear3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(792, 56);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactorLabel1
            // 
            this.reactorLabel1.AutoSize = true;
            this.reactorLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel1.Location = new System.Drawing.Point(135, 144);
            this.reactorLabel1.Name = "reactorLabel1";
            this.reactorLabel1.Size = new System.Drawing.Size(146, 36);
            this.reactorLabel1.TabIndex = 1;
            this.reactorLabel1.Text = "Reactor 1";
            this.reactorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactorLabel2
            // 
            this.reactorLabel2.AutoSize = true;
            this.reactorLabel2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorLabel2.Location = new System.Drawing.Point(473, 144);
            this.reactorLabel2.Name = "reactorLabel2";
            this.reactorLabel2.Size = new System.Drawing.Size(146, 36);
            this.reactorLabel2.TabIndex = 2;
            this.reactorLabel2.Text = "Reactor 2";
            this.reactorLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reactorLabel2.Click += new System.EventHandler(this.reactorLabel2_Click);
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.reactor1StateLabel.Location = new System.Drawing.Point(76, 209);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(268, 112);
            this.reactor1StateLabel.TabIndex = 4;
            // 
            // reactor2Statelabel
            // 
            this.reactor2Statelabel.AutoSize = true;
            this.reactor2Statelabel.BackColor = System.Drawing.Color.Chartreuse;
            this.reactor2Statelabel.Location = new System.Drawing.Point(657, 284);
            this.reactor2Statelabel.Name = "reactor2Statelabel";
            this.reactor2Statelabel.Size = new System.Drawing.Size(0, 13);
            this.reactor2Statelabel.TabIndex = 5;
            // 
            // reactor5
            // 
            this.reactor5.BackColor = System.Drawing.Color.Chartreuse;
            this.reactor5.Location = new System.Drawing.Point(428, 209);
            this.reactor5.Name = "reactor5";
            this.reactor5.Size = new System.Drawing.Size(265, 112);
            this.reactor5.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gold;
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(274, 351);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(230, 50);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Nuclear3
            // 
            this.Nuclear3.BackColor = System.Drawing.Color.LightYellow;
            this.Nuclear3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuclear3.Location = new System.Drawing.Point(291, 439);
            this.Nuclear3.Name = "Nuclear3";
            this.Nuclear3.Size = new System.Drawing.Size(200, 28);
            this.Nuclear3.TabIndex = 8;
            this.Nuclear3.Text = "Reactor Stable";
            this.Nuclear3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(810, 513);
            this.Controls.Add(this.Nuclear3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactor5);
            this.Controls.Add(this.reactor2Statelabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactorLabel2);
            this.Controls.Add(this.reactorLabel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "WhiteBoyRoyNuclear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactorLabel1;
        private System.Windows.Forms.Label reactorLabel2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2Statelabel;
        private System.Windows.Forms.Label reactor5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label Nuclear3;
    }
}

