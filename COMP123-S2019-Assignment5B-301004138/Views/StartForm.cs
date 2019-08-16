using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301004138.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for ExitOrderButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitOrderButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is event handler for StartOrderButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is event handler for LoadSavedButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedButton_Click(object sender, EventArgs e)
        {
            OpenFile();

            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method will open up your saved files
        /// </summary>
        private void OpenFile()
        {
            // Configure the file dialog

            ProductOpenFileDialog.FileName = "Hardware.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // Open the file dialog

            var resultFile = ProductOpenFileDialog.ShowDialog();
            if (resultFile != DialogResult.Cancel)
            {
                try
                {
                    // Open file stream to read

                    using (StreamReader input = new StreamReader(File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        Program.product.productID = short.Parse(input.ReadLine());
                        Program.product.cost = decimal.Parse(input.ReadLine());
                        Program.product.manufacturer = input.ReadLine();
                        Program.product.model = input.ReadLine();
                        Program.product.condition = input.ReadLine();
                        Program.product.platform = input.ReadLine();
                        Program.product.OS = input.ReadLine();
                        Program.product.RAM_size = input.ReadLine();
                        Program.product.screensize = input.ReadLine();
                        Program.product.HDD_size = input.ReadLine();
                        Program.product.CPU_brand = input.ReadLine();
                        Program.product.CPU_number = input.ReadLine();
                        Program.product.GPU_Type = input.ReadLine();
                        Program.product.CPU_type = input.ReadLine();
                        Program.product.CPU_speed = input.ReadLine();
                        Program.product.webcam = input.ReadLine();

                        // cleaning it up

                        input.Close();
                        input.Dispose();
                    }
                }
                catch (IOException error)
                {

                    MessageBox.Show($"ERROR: {error.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException errorFormat)
                {
                    MessageBox.Show($"ERROR: {errorFormat.Message} \n\nPlease select the correct file type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This is event handler for StartOrderButton MouseHover event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_MouseHover(object sender, EventArgs e)
        {
            StartOrderButton.ForeColor = Color.Purple;
        }

        /// <summary>
        /// This is event handler for StartOrderButton MouseLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartOrderButton_MouseLeave(object sender, EventArgs e)
        {
            StartOrderButton.ForeColor = Color.Transparent;
        }

        /// <summary>
        /// This is event handler for LoadSavedButton MouseHover event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedButton_MouseHover(object sender, EventArgs e)
        {
            LoadSavedButton.ForeColor = Color.Green;
        }

        /// <summary>
        /// This is event handler for LoadSavedButton MouseLeave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedButton_MouseLeave(object sender, EventArgs e)
        {
            LoadSavedButton.ForeColor = Color.Transparent;
        }

        /// <summary>
        /// This is event handler for ExitOrderButton MouseHover event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitOrderButton_MouseHover(object sender, EventArgs e)
        {
            ExitOrderButton.ForeColor = Color.Red;
        }

        /// <summary>
        /// This is event handler for ExitOrderButton MouseLeave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitOrderButton_MouseLeave(object sender, EventArgs e)
        {
            ExitOrderButton.ForeColor = Color.Transparent;
        }
    }
}
