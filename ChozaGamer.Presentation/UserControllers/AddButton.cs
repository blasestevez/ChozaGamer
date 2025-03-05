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
    public partial class AddButton : UserControl
    {
        public event EventHandler OpenAddFormButtonClick;
        public AddButton()
        {
            InitializeComponent();
        }

        private void OpenAddFormButton_Click(object sender, EventArgs e)
        {
            OpenAddFormButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
