using DollarComputer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputer.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for SelectForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // loading up the database

            using (var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
            ProductDataGridView.ClearSelection();
        }

        /// <summary>
        /// this is event handler for CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // gives a warning if the user wants to cancel the application

            var confirmResult = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        /// <summary>
        /// This is event handler for NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is event handler for ProductDataGridView Selection Changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // local scope aliases

            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var cells = rows[rowIndex].Cells;
            
            // Checking to see if the is not selected then the NextButton will be disable

            if (rows[rowIndex].Selected == false)
            {
                EmptySelectionTextBox.Visible = true;
                SelectionTextBox.Visible = false;
                NextButton.Enabled = false;
            }
            else
            {
                SelectionTextBox.Visible = true;
                EmptySelectionTextBox.Visible = false;
                NextButton.Enabled = true;
            }
            
            SelectedData(cells);

            // Assigning the data into the Program.product

            Program.product.productID = short.Parse(cells[(int)ProductField.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(cells[(int)ProductField.COST].Value.ToString());
            Program.product.manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            Program.product.model = cells[(int)ProductField.MODEL].Value.ToString();
            Program.product.condition = cells[(int)ProductField.CONDITION].Value.ToString();
            Program.product.platform = cells[(int)ProductField.PLATFORM].Value.ToString();
            Program.product.OS = cells[(int)ProductField.OPEARTING_SYSTEM].Value.ToString();
            Program.product.RAM_size = cells[(int)ProductField.RAM_SIZE].Value.ToString();
            Program.product.screensize = cells[(int)ProductField.SCREENSIZE].Value.ToString();
            Program.product.HDD_size = cells[(int)ProductField.HDD_SIZE].Value.ToString();
            Program.product.CPU_brand = cells[(int)ProductField.CPU_BRAND].Value.ToString();
            Program.product.CPU_number = cells[(int)ProductField.CPU_NUMBER].Value.ToString();
            Program.product.GPU_Type = cells[(int)ProductField.GPU_TYPE].Value.ToString();
            Program.product.CPU_type = cells[(int)ProductField.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = cells[(int)ProductField.CPU_SPEED].Value.ToString();
            Program.product.webcam = cells[(int)ProductField.WEBCAM].Value.ToString();
        }

        /// <summary>
        /// This method shows the selected data like manufacturer, model and the cost from ProductDataGridView
        /// </summary>
        /// <param name="cells"></param>
        private void SelectedData(DataGridViewCellCollection cells)
        {
            string outputString = string.Empty;
            string manufacturer = cells[(int)ProductField.MANUFACTURER].Value.ToString();
            string model = cells[(int)ProductField.MODEL].Value.ToString();
            decimal cost = (decimal)cells[(int)ProductField.COST].Value;
            
            outputString = string.Format($"{manufacturer} {model} Priced at: {cost:C}");
            
            SelectionTextBox.Text = outputString;
        }

        /// <summary>
        /// This is event handler for NextButton MouseHover event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.Purple;
        }

        /// <summary>
        /// This is event handler for CancelButton MouseHover event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_MouseHover(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.Red;
        }

        /// <summary>
        /// This is event handler for NextButton MouseLeave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_MouseLeave(object sender, EventArgs e)
        {
            NextButton.ForeColor = Color.FromArgb(34, 36, 49);
        }

        /// <summary>
        /// This is event handler for CancelButton MouseLeave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.FromArgb(34, 36, 49);
        }
    }
}
