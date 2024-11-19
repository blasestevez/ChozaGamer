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
    public partial class EditableBrandCard : UserControl
    {
        private readonly BrandDTO brand;
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public EditableBrandCard(BrandDTO brand)
        {
            InitializeComponent();
            this.brand = brand;
            brandName = brand.name;
        }

        public string brandName
        {
            set { BrandName.Text = value; }
        }

        private void EditBrandButton_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BrandName_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
