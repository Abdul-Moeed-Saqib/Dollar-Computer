using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301004138.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event Handler for CancelButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel? \n\nYour order will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This is event handler for BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();

            OrderForm_Activated(sender, e);
        }

        /// <summary>
        /// This is event handler for FinishButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Thank you for your busniess.\nThe order will be processed in 7-10 business days.", "Thank you", MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        /// <summary>
        /// This is event handler for OrderForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            PriceDataLabel.Text = Program.product.cost.ToString();

            PriceDataLabel.Text = string.Format("{0:C2}", decimal.Parse(PriceDataLabel.Text));

            SalesTax();

            ManufacturerDataLabel.Text = Program.product.manufacturer.ToString();
            ModelDataLabel.Text = Program.product.model.ToString();
            ConditionDataLabel.Text = Program.product.condition.ToString();
            PlatformDataLabel.Text = Program.product.platform.ToString();
            OSDataLabel.Text = Program.product.OS.ToString();
            MemoryDataLabel.Text = Program.product.RAM_size.ToString();
            LCDSizeDataLabel.Text = Program.product.screensize.ToString();
            HDDDataLabel.Text = Program.product.HDD_size.ToString();
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;

            
            if (Program.product.platform.Equals("Laptop")) 
            {
                PlatformPictureBox.Image = new Bitmap("laptop.jpg");
                PlatformPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
            else
            {
                PlatformPictureBox.Image = new Bitmap("desktopPC.jpg");
                PlatformPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        /// <summary>
        /// This is method is calculates the product's sale tax
        /// </summary>
        private void SalesTax()
        {
            float tax = 0.13F;
            var saleTax = (float)Program.product.cost * tax;
            saleTax = (float)Math.Round(saleTax, 1);
            if (saleTax < 0.1F)
            {
                saleTax = 0.1F;
            }
            SalesTaxDataLabel.Text = saleTax.ToString("C2");

            CalculateTotal(saleTax);
        }

        /// <summary>
        /// This method calculates the tax and the price to get the total cost of the product
        /// </summary>
        /// <param name="saleTax"></param>
        private void CalculateTotal(float saleTax)
        {
            var total = (float)Program.product.cost + saleTax;
            TotalDataLabel.Text = total.ToString("C2");
        }

        /// <summary>
        /// This is event handler for OrderForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PriceDataLabel.Text = Program.product.cost.ToString();

            PriceDataLabel.Text = string.Format("{0:C2}", decimal.Parse(PriceDataLabel.Text));

            SalesTax();

            ManufacturerDataLabel.Text = Program.product.manufacturer.ToString();
            ModelDataLabel.Text = Program.product.model.ToString();
            ConditionDataLabel.Text = Program.product.condition.ToString();
            PlatformDataLabel.Text = Program.product.platform.ToString();
            OSDataLabel.Text = Program.product.OS.ToString();
            MemoryDataLabel.Text = Program.product.RAM_size.ToString();
            LCDSizeDataLabel.Text = Program.product.screensize.ToString();
            HDDDataLabel.Text = Program.product.HDD_size.ToString();
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;

            if (Program.product.platform.Equals("Laptop"))
            {
                PlatformPictureBox.Image = new Bitmap("laptop.jpg");
                PlatformPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PlatformPictureBox.Image = new Bitmap("desktopPC.jpg");
                PlatformPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// This is event handler for printToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order will be Printing Now!", "Printing...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }
    }
}
