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

namespace OverclockStore.Presentation.UserControllers
{
    public partial class EditableSubCategoryCard : UserControl
    {
        private readonly SubCategoryDTO subCategory;

        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public EditableSubCategoryCard(SubCategoryDTO subCategory)
        {
            InitializeComponent();
            this.subCategory = subCategory;

            subCategoryName = subCategory.name;
        }

        public string subCategoryName
        {
            set { SubCategoryName.Text = value; }
        }


        private void EditSubCategoryButton_Click_1(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
