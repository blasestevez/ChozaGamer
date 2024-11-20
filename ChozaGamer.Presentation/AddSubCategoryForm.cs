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

namespace ChozaGamer.Presentation
{
    public partial class AddSubCategoryForm : Form
    {
        private readonly SubCategoryService subCategoryService;
        private readonly CategoryService categoryService;
        private List<CategoryDTO> categories = new List<CategoryDTO>();
        private SubCategoryDTO subcategory = new SubCategoryDTO();

        public AddSubCategoryForm(SubCategoryService subCategoryService, CategoryService categoryService)
        {
            InitializeComponent();
            this.subCategoryService = subCategoryService;
            this.categoryService = categoryService;
            FillComboBox();
        }

        private async void FillComboBox()
        {
            await GetCategories();
            var nonNullCategories = categories.Where(x => x.name != null).Select(x => x.name).ToArray();
            comboBox1.Items.AddRange(nonNullCategories);

        }

        private async Task GetCategories()
        {
            categories = await categoryService.GetCategories();
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBar.Content))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            try
            {
                subcategory.idCategory = categories.Where(x => x.name == comboBox1.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
                subcategory.name = NameBar.Content;

                var subCategoryResponse = await subCategoryService.UploadSubCategory(subcategory);
                if (subCategoryResponse)
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
