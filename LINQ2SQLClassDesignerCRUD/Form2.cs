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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Supplier newSupplier = new Supplier();
            try
            {
                if (string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    MessageBox.Show("Unesite ime kompanije!");
                    txtCompanyName.Focus();
                    return;
                }
                else
                {
                    newSupplier.companyname = txtCompanyName.Text;
                }

                if (string.IsNullOrEmpty(txtContactName.Text))
                {
                    MessageBox.Show("Unesite ime kontakta!");
                    txtContactName.Focus();
                    return;
                }
                else
                {
                    newSupplier.contactname = txtContactName.Text;
                }

                if (string.IsNullOrEmpty(txtContactTitle.Text))
                {
                    MessageBox.Show("Unesite zvanje kontakta!");
                    txtContactTitle.Focus();
                    return;
                }
                else
                {
                    newSupplier.contacttitle = txtContactTitle.Text;
                }

                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Unesite adresu!");
                    txtAddress.Focus();
                    return;
                }
                else
                {
                    newSupplier.address = txtAddress.Text;
                }

                if (string.IsNullOrEmpty(txtCity.Text))
                {
                    MessageBox.Show("Unesite grad!");
                    txtCity.Focus();
                    return;
                }
                else
                {
                    newSupplier.city = txtCity.Text;
                }

                newSupplier.region = txtRegion.Text;
                newSupplier.postalcode = txtPostalCode.Text;

                if (string.IsNullOrEmpty(txtCountry.Text))
                {
                    MessageBox.Show("Unesite drzavu!");
                    txtCountry.Focus();
                    return;
                }
                else
                {
                    newSupplier.country = txtCountry.Text;
                }

                if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Unesite drzavu!");
                    txtPhone.Focus();
                    return;
                }
                else
                {
                    newSupplier.phone = txtPhone.Text;
                }

                newSupplier.fax = txtFax.Text;

                Form1.dbContext.Suppliers.InsertOnSubmit(newSupplier);

                Form1.dbContext.SubmitChanges();

                MessageBox.Show("Dodato!");               
                                
                this.Close();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
