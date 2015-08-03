using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as2edit
{
    public partial class CodeDialog : Form
    {
        Action<string> saveFunction;

        public CodeDialog(Action<string> saveFunction, string defaultText = "")
        {
            InitializeComponent();

            this.saveFunction = saveFunction;
            codeText.Text = defaultText;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFunction(codeText.Text);
            Close();
        }
    }
}
