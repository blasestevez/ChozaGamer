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
    public partial class EditableCategoryCard : UserControl
    {
        private readonly CategoryDTO category;

        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public EditableCategoryCard(CategoryDTO category)
        {
            InitializeComponent();
            this.category = category;

            categoryName = category.name;
        }

        public string categoryName
        {
            set { CategoryName.Text = value; }
        }

        private void EditCategoryButton_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
