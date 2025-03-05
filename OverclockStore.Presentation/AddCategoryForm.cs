using OverclockStore.Business.Services;
using OverclockStore.DataAccess.Models.Domain;
using OverclockStore.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverclockStore.Presentation
{
    public partial class AddCategoryForm : Form
    {
        private readonly CategoryService categoryService;
        CategoryDTO category = new CategoryDTO();
        public AddCategoryForm(CategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
        }

        private void NameBar_ContentChanged(object sender, EventArgs e)
        {

        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBar.Content))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            try
            {
                category.name = NameBar.Content;

                var categoryResponse = await categoryService.UploadCategory(category);
                if (categoryResponse)
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
