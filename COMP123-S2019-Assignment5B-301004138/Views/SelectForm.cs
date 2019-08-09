using COMP123_S2019_Assignment5B_301004138.Data;
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

namespace COMP123_S2019_Assignment5B_301004138.Views
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
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            //rows[rowIndex].Selected = false;

            string outputString = string.Empty;
            for (int i = 0; i < columnCount; i++)
            {
                outputString += cells[i].Value.ToString() + ", ";
            }

            SelectionTextBox.Text = outputString;

            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.CPU_number = cells[13].Value.ToString();
            Program.product.GPU_Type = cells[19].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.CPU_speed = cells[12].Value.ToString();
            Program.product.webcam = cells[30].Value.ToString();
        }
    }
}
