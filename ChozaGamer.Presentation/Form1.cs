using ChozaGamer.Business.Services;

namespace ChozaGamer.Presentation
{
    public partial class Form1 : Form
    {
        private readonly ProductService service;

        public Form1(ProductService service)
        {
            InitializeComponent();
            this.service = service;
            ConfigureDataGridView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.Columns.Clear();

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "ProductImage";
            imgColumn.HeaderText = "Preview";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            dataGridView1.Columns.Add(imgColumn);
            dataGridView1.Columns.Add("ProductName", "Name");
            dataGridView1.Columns.Add("CategoryName", "Category");
            dataGridView1.Columns.Add("BrandName", "Brand");
            dataGridView1.Columns.Add("SubCategoryName", "Subcategory");
            dataGridView1.Columns.Add("SpecialPrice", "Special Price");
            dataGridView1.Columns.Add("DefaultPrice", "Price");
            dataGridView1.Columns.Add("Stock", "Stock");
            dataGridView1.Columns.Add("ProductCode", "P/N");
            dataGridView1.Columns.Add("Sale", "On Sale");
            dataGridView1.Columns.Add("Warranty", "Warranty (Months)");
            dataGridView1.Columns.Add("IVA", "IVA (%)");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var products = await service.GetProducts(textBox1.Text);

            dataGridView1.Rows.Clear();

            foreach (var product in products)
            {
                Image productImage = null;
                if (product.productImages.Any() && product.productImages[0] != null && product.productImages[0].Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(product.productImages[0]))
                        {
                            productImage = Image.FromStream(ms);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"An error has occured while loading the image: {product.name}: {ex.Message}");
                        productImage = null;
                    }
                }

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells["ProductImage"].Value = productImage;
                row.Cells["ProductName"].Value = product.name;
                row.Cells["CategoryName"].Value = product.categoryName;
                row.Cells["BrandName"].Value = product.brandName;
                row.Cells["SubCategoryName"].Value = product.subCategoryName;
                row.Cells["SpecialPrice"].Value = product.specialPrice;
                row.Cells["DefaultPrice"].Value = product.defaultPrice;
                row.Cells["Stock"].Value = product.stock;
                row.Cells["ProductCode"].Value = product.productCode;
                row.Cells["Sale"].Value = product.sale;
                row.Cells["Warranty"].Value = product.warranty;
                row.Cells["IVA"].Value = product.iva;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
