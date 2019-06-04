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
    public partial class Form1 : Form
    {
        public static SuppliersDataContext dbContext = new SuppliersDataContext();        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridSuppliers.ReadOnly = true;
            gridSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridSuppliers.MultiSelect = false;
            gridSuppliers.AllowUserToAddRows = false;

            RefreshData();
        }

        public void RefreshData()
        {
            dbContext = null;
            dbContext = new SuppliersDataContext();

            try
            {                
                gridSuppliers.DataSource = dbContext.Suppliers;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void gridSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSuppliers.SelectedRows.Count > 0)
            {
                txtUpdateId.Text = gridSuppliers.SelectedRows[0].Cells[0].Value.ToString();
                txtUpdateCompanyName.Text = gridSuppliers.SelectedRows[0].Cells[1].Value.ToString();
                txtUpdateContactName.Text = gridSuppliers.SelectedRows[0].Cells[2].Value.ToString();
                txtUpdateContactTitle.Text = gridSuppliers.SelectedRows[0].Cells[3].Value.ToString();
                txtUpdateAddress.Text = gridSuppliers.SelectedRows[0].Cells[4].Value.ToString();
                txtUpdateCity.Text = gridSuppliers.SelectedRows[0].Cells[5].Value.ToString();
                if (gridSuppliers.SelectedRows[0].Cells[6].Value == null)
                {
                    txtUpdateRegion.Text = null;
                }
                else
                {
                    txtUpdateRegion.Text = gridSuppliers.SelectedRows[0].Cells[6].Value.ToString();
                }

                if (gridSuppliers.SelectedRows[0].Cells[7].Value == null)
                {
                    txtUpdatePostalCode.Text = null;
                }
                else
                {
                    txtUpdatePostalCode.Text = gridSuppliers.SelectedRows[0].Cells[7].Value.ToString();
                }
                     
                txtUpdateCountry.Text = gridSuppliers.SelectedRows[0].Cells[8].Value.ToString();
                txtUpdatePhone.Text = gridSuppliers.SelectedRows[0].Cells[9].Value.ToString();

                if(gridSuppliers.SelectedRows[0].Cells[10].Value == null)
                {
                    txtUpdateFax.Text = null;
                }
                else
                {
                    txtUpdateFax.Text = gridSuppliers.SelectedRows[0].Cells[10].Value.ToString();
                }      
                
                txtDeleteSupplierId.Text = gridSuppliers.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = Convert.ToInt32(txtUpdateId.Text);
                Supplier supplierToUpdate = dbContext.Suppliers.SingleOrDefault(s => s.supplierid == supplierId);

                if (string.IsNullOrEmpty(txtUpdateCompanyName.Text))
                {
                    MessageBox.Show("Unesite ime kompanije!");
                    txtUpdateCompanyName.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.companyname = txtUpdateCompanyName.Text;
                }

                if (string.IsNullOrEmpty(txtUpdateContactName.Text))
                {
                    MessageBox.Show("Unesite ime kontakta!");
                    txtUpdateContactName.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.contactname = txtUpdateContactName.Text;
                }

                if (string.IsNullOrEmpty(txtUpdateContactTitle.Text))
                {
                    MessageBox.Show("Unesite zvanje kontakta!");
                    txtUpdateContactTitle.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.contacttitle = txtUpdateContactTitle.Text;
                }

                if (string.IsNullOrEmpty(txtUpdateAddress.Text))
                {
                    MessageBox.Show("Unesite adresu!");
                    txtUpdateAddress.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.address = txtUpdateAddress.Text;
                }

                if (string.IsNullOrEmpty(txtUpdateCity.Text))
                {
                    MessageBox.Show("Unesite grad!");
                    txtUpdateCity.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.city = txtUpdateCity.Text;
                }
                
                supplierToUpdate.region = txtUpdateRegion.Text;
                supplierToUpdate.postalcode = txtUpdatePostalCode.Text;

                if (string.IsNullOrEmpty(txtUpdateCountry.Text))
                {
                    MessageBox.Show("Unesite drzavu!");
                    txtUpdateCountry.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.country = txtUpdateCountry.Text;
                }

                if (string.IsNullOrEmpty(txtUpdatePhone.Text))
                {
                    MessageBox.Show("Unesite drzavu!");
                    txtUpdatePhone.Focus();
                    return;
                }
                else
                {
                    supplierToUpdate.phone = txtUpdatePhone.Text;
                }
                
                supplierToUpdate.fax = txtUpdateFax.Text;

                dbContext.SubmitChanges();

                MessageBox.Show("Izmenjeno!");

                RefreshData();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(txtDeleteSupplierId.Text);
            Supplier supplierToDelete = dbContext.Suppliers.SingleOrDefault(s => s.supplierid == supplierId);

            dbContext.Suppliers.DeleteOnSubmit(supplierToDelete);
            dbContext.SubmitChanges();

            MessageBox.Show("Obrisano!");

            RefreshData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
