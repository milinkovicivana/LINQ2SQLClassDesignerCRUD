using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ2SQLClassDesignerCRUD
{
    public partial class Form3 : Form
    {
        SuppliersDataContext dbContext = new SuppliersDataContext();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCity.Text))
                {
                    MessageBox.Show("Unesite grad!");
                    txtCity.Focus();
                    return;
                }
                else
                {
                    var suppliers = from Supplier in dbContext.Suppliers
                                    where Supplier.city == txtCity.Text
                                    select Supplier;

                    gridCityFilter.DataSource = suppliers;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
