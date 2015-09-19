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

        public enum SongName
        {
            None = -1,
            Title = 0,
            WorldMap = 1,
            Town = 2,
            Garrison = 3,
            Boss = 4,
            Item = 5,
            Dungeon1 = 6,
            Dungeon2 = 7,
            Dungeon3 = 8,
            Dungeon4 = 9,
            Dungeon5 = 10,
            Dungeon6 = 11,
            Dungeon7 = 12,
            Dungeon8 = 13,
            Dungeon9a = 14,
            Dungeon9b = 15,
            FinalBoss = 16,
            Credits = 17,
            Silent = 18,
        }

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

        private void stockButton_Click(object sender, EventArgs e)
        {
            StockEntityEditor sE = new StockEntityEditor();
            sE.Show();
        }

        private void specialButton_Click(object sender, EventArgs e)
        {
            SpecialEditor sE = new SpecialEditor();
            sE.Show();
        }
    }
}
