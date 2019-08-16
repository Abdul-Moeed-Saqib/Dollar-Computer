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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.LoadSavedButton = new System.Windows.Forms.Button();
            this.ExitOrderButton = new System.Windows.Forms.Button();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DollarComputerLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 17);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(285, 24);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Order Your Computer Today!";
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.BackColor = System.Drawing.Color.DarkOrange;
            this.StartOrderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.StartOrderButton.ForeColor = System.Drawing.Color.White;
            this.StartOrderButton.Location = new System.Drawing.Point(64, 233);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(172, 34);
            this.StartOrderButton.TabIndex = 2;
            this.StartOrderButton.Text = "Start a New Order";
            this.StartOrderButton.UseVisualStyleBackColor = false;
            this.StartOrderButton.Click += new System.EventHandler(this.StartOrderButton_Click);
            this.StartOrderButton.MouseLeave += new System.EventHandler(this.StartOrderButton_MouseLeave);
            this.StartOrderButton.MouseHover += new System.EventHandler(this.StartOrderButton_MouseHover);
            // 
            // LoadSavedButton
            // 
            this.LoadSavedButton.BackColor = System.Drawing.Color.DarkOrange;
            this.LoadSavedButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LoadSavedButton.ForeColor = System.Drawing.Color.White;
            this.LoadSavedButton.Location = new System.Drawing.Point(64, 276);
            this.LoadSavedButton.Name = "LoadSavedButton";
            this.LoadSavedButton.Size = new System.Drawing.Size(172, 34);
            this.LoadSavedButton.TabIndex = 2;
            this.LoadSavedButton.TabStop = false;
            this.LoadSavedButton.Text = "Open a Saved Order";
            this.LoadSavedButton.UseVisualStyleBackColor = false;
            this.LoadSavedButton.Click += new System.EventHandler(this.LoadSavedButton_Click);
            this.LoadSavedButton.MouseLeave += new System.EventHandler(this.LoadSavedButton_MouseLeave);
            this.LoadSavedButton.MouseHover += new System.EventHandler(this.LoadSavedButton_MouseHover);
            // 
            // ExitOrderButton
            // 
            this.ExitOrderButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ExitOrderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ExitOrderButton.ForeColor = System.Drawing.Color.White;
            this.ExitOrderButton.Location = new System.Drawing.Point(64, 317);
            this.ExitOrderButton.Name = "ExitOrderButton";
            this.ExitOrderButton.Size = new System.Drawing.Size(172, 34);
            this.ExitOrderButton.TabIndex = 2;
            this.ExitOrderButton.TabStop = false;
            this.ExitOrderButton.Text = "Exit";
            this.ExitOrderButton.UseVisualStyleBackColor = false;
            this.ExitOrderButton.Click += new System.EventHandler(this.ExitOrderButton_Click);
            this.ExitOrderButton.MouseLeave += new System.EventHandler(this.ExitOrderButton_MouseLeave);
            this.ExitOrderButton.MouseHover += new System.EventHandler(this.ExitOrderButton_MouseHover);
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // DollarComputerLogoPictureBox
            // 
            this.DollarComputerLogoPictureBox.Image = global::COMP123_S2019_Assignment5B_301004138.Properties.Resources.DollarComputerLogoReal;
            this.DollarComputerLogoPictureBox.Location = new System.Drawing.Point(33, 44);
            this.DollarComputerLogoPictureBox.Name = "DollarComputerLogoPictureBox";
            this.DollarComputerLogoPictureBox.Size = new System.Drawing.Size(241, 183);
            this.DollarComputerLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollarComputerLogoPictureBox.TabIndex = 0;
            this.DollarComputerLogoPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.ControlBox = false;
            this.Controls.Add(this.ExitOrderButton);
            this.Controls.Add(this.LoadSavedButton);
            this.Controls.Add(this.StartOrderButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.DollarComputerLogoPictureBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DollarComputerLogoPictureBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button LoadSavedButton;
        private System.Windows.Forms.Button ExitOrderButton;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
    }
}