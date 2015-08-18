using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as2edit
{
    public partial class CodeExplanation : Form
    {
        public CodeExplanation()
        {
            InitializeComponent();

            Stream myStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("as2edit.CodeExplanation.txt");
            StreamReader sR = new StreamReader(myStream);
            explanation.Text = sR.ReadToEnd();
            explanation.Select(0, 0);
        }
    }
}
