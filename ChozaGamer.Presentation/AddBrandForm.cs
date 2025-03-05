using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChozaGamer.Presentation.UserControllers
{
    public partial class AddBrandForm : Form
    {
        private readonly BrandService brandService;
        private readonly BrandDTO brand = new BrandDTO();

        public AddBrandForm(BrandService brandService)
        {
            InitializeComponent();
            this.brandService = brandService;
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBar.Content))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please enter a warranty.");
                return;
            }
            try
            {
                brand.name = NameBar.Content;
                brand.warranty = Convert.ToInt32(numericUpDown1.Value);

                var brandResponse = await brandService.UploadBrand(brand); 
                if (brandResponse)
                {
                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error updating product.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
