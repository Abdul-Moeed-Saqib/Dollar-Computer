using COMP123_S2019_Assignment5B_301004138.Data;
using COMP123_S2019_Assignment5B_301004138.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5B_301004138
{
    public static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        public static Product product;

        /// <summary>
        /// Name: Abdul Moeed Saqib
        /// Student ID: 301004138
        /// Date last Modified: August 2nd, 2019
        /// Program description: Dollar Computers allows you to order different kinds of Computer like laptops or desktops.
        /// 
        /// RevisionHistory:
        /// 1: created splash screen and created forms like StartForm, SelectForm, ProductInfoForm, OrderForm and AboutForm
        /// 2: added NextButton and Cancelbutton
        /// 3: created DataGridView and Use the Entity Framework to connect to the Database named DollarComputers
        /// 4: created Entity data model
        /// 5: added SaveFileDialog to save file and OpenFileDialog to the ProductInfoForm to save the data that customer choosed. Also added OpenFileDialog to the StartForm
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());
            product = new Product();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
