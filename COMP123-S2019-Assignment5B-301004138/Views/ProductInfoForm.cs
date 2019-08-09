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
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            CostDataLabel.Text = Program.product.cost.ToString();
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
        }
    }
}
