namespace COMP123_S2019_Assignment5B_301004138.Views
{
    partial class StartForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.LoadSavedButton = new System.Windows.Forms.Button();
            this.ExitOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_Assignment5B_301004138.Properties.Resources.dollarComputerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(51, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 17);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(285, 24);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Order Your Computer Today!";
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Font = new System.Drawing.Font("Arial", 12F);
            this.StartOrderButton.Location = new System.Drawing.Point(64, 233);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(172, 34);
            this.StartOrderButton.TabIndex = 2;
            this.StartOrderButton.Text = "Start a New Order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            // 
            // LoadSavedButton
            // 
            this.LoadSavedButton.Font = new System.Drawing.Font("Arial", 12F);
            this.LoadSavedButton.Location = new System.Drawing.Point(64, 276);
            this.LoadSavedButton.Name = "LoadSavedButton";
            this.LoadSavedButton.Size = new System.Drawing.Size(172, 34);
            this.LoadSavedButton.TabIndex = 2;
            this.LoadSavedButton.Text = "Open a Saved Order";
            this.LoadSavedButton.UseVisualStyleBackColor = true;
            // 
            // ExitOrderButton
            // 
            this.ExitOrderButton.Font = new System.Drawing.Font("Arial", 12F);
            this.ExitOrderButton.Location = new System.Drawing.Point(64, 317);
            this.ExitOrderButton.Name = "ExitOrderButton";
            this.ExitOrderButton.Size = new System.Drawing.Size(172, 34);
            this.ExitOrderButton.TabIndex = 2;
            this.ExitOrderButton.Text = "Exit";
            this.ExitOrderButton.UseVisualStyleBackColor = true;
            this.ExitOrderButton.Click += new System.EventHandler(this.ExitOrderButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.ControlBox = false;
            this.Controls.Add(this.ExitOrderButton);
            this.Controls.Add(this.LoadSavedButton);
            this.Controls.Add(this.StartOrderButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button LoadSavedButton;
        private System.Windows.Forms.Button ExitOrderButton;
    }
}