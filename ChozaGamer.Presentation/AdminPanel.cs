using ChozaGamer.Business.Services;
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
    public partial class AdminPanel : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;

        public AdminPanel(ProductService productService, UserService userService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminPanelComboBox_TabIndexChanged(object sender, EventArgs e)
        {
            if (AdminPanelComboBox.SelectedIndex == 0) // product
            {

            }
        }

        private void AdminPanelSelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.Title = "Select an image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        AdminPanelProductPicture.Content = new Bitmap(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private async void AdminPanelAddButton_Click(object sender, EventArgs e)
        {
            ProductDTO productDTO = new ProductDTO
            {
                name = AdminPanelProductNameBar.Content,
                defaultPrice = Convert.ToDecimal(PriceNUD.Value),
                productImage = ConvertImageToByte(AdminPanelProductPicture.Content)
            };

            await productService.UploadProduct(productDTO);
        }

        private byte[] ConvertImageToByte(Image image)
        {
            if (image == null)
            {
                return null;
            }

            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, image.RawFormat);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting image to byte array: {ex.Message}");
                return null;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm existingLoginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

            if (existingLoginForm != null && !existingLoginForm.IsDisposed)
            {
                existingLoginForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm(productService, userService);
                loginForm.Show();
            }
            this.Hide();
        }
    }
}
