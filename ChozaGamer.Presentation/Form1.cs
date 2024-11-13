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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await service.GetProducts(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
