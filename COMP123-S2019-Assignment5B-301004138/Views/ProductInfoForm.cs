using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301004138.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is event handler for CancelButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel? Your order will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            Program.product.productID = short.Parse(ProductIDDataLabel.Text);
            Program.product.cost = decimal.Parse(CostDataLabel.Text);
            Program.product.manufacturer = ManufacturerDataLabel.Text;
            Program.product.model = ModelDataLabel.Text;
            Program.product.condition = ConditionDataLabel.Text;
            Program.product.platform = PlatformDataLabel.Text;
            Program.product.OS = OSDataLabel.Text;
            Program.product.RAM_size = MemoryDataLabel.Text;
            Program.product.screensize = LCDSizeDataLabel.Text;
            Program.product.HDD_size = HDDDataLabel.Text;
            Program.product.CPU_brand = CPUBrandDataLabel.Text;
            Program.product.CPU_number = CPUNumberDataLabel.Text;
            Program.product.GPU_Type = GPUTypeDataLabel.Text;
            Program.product.CPU_type = CPUTypeDataLabel.Text;
            Program.product.CPU_speed = CPUSpeedDataLabel.Text;
            Program.product.webcam = WebCamDataLabel.Text;
        }
    }
}
