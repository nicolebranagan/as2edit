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
using System.Xml;
using System.Xml.Serialization;

namespace as2edit
{

    public partial class Main : Form
    {
        public static Worldfile currentFile = new Worldfile();

        public Main()
        {
            InitializeComponent();
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            MapEditor map = new MapEditor();
            map.Show();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML Worldfile|*.xml|All Files|*.*";
            saveFileDialog1.Title = "Save Worldfile";
            saveFileDialog1.ShowDialog();

            XmlWriterSettings ws = new XmlWriterSettings();
            ws.NewLineHandling = NewLineHandling.Entitize;

            if (saveFileDialog1.FileName != "")
            {
                XmlSerializer xS = new XmlSerializer(typeof(Worldfile));
                try
                {
                    StreamWriter sW = new StreamWriter(saveFileDialog1.FileName);
                    xS.Serialize(sW, currentFile);
                    sW.Close();
                    MessageBox.Show("Saved XML file successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error saving file.");
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Worldfile|*.xml|All Files|*.*";
            openFileDialog1.Title = "Open Worldfile";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                XmlSerializer xS = new XmlSerializer(typeof(Worldfile));
                FileStream fS = new FileStream(openFileDialog1.FileName, FileMode.Open);
                XmlTextReader xTR = new XmlTextReader(fS);
                Worldfile wF;
                wF = (Worldfile)xS.Deserialize(xTR);
                Main.currentFile = wF;
            }
        }

        private void advButton_Click(object sender, EventArgs e)
        {
            AdventureEditor adv = new AdventureEditor();
            adv.Show();
        }

        private void bestButton_Click(object sender, EventArgs e)
        {
            BestiaryEditor bE = new BestiaryEditor();
            bE.Show();
        }
    }
}
