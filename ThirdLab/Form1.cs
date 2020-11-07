using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace ThirdLab
{
    public partial class Form1 : Form
    {
        private string path = "XMLFile1.xml";
        private string path_ = "XSLFile1.xsl";

        public Form1()
        {
            InitializeComponent();
            BuildBox(namebox, sexbox, breedbox, agebox, vacbox);
            namebox.Enabled = false;
            sexbox.Enabled = false;
            breedbox.Enabled = false;
            agebox.Enabled = false;
            vacbox.Enabled = false;
            radioLINQ.Checked = true;
        }

        public void BuildBox(ComboBox namebox,  ComboBox sexbox, ComboBox breedbox, ComboBox agebox, ComboBox vacbox )
        {
            IStrategy p = new LinqToXML();
            List<Cats> res = p.AnalyzeFile(new Cats(), path);
            List<string> name = new List<string>();
            List<string> sex = new List<string>();
            List<string> age = new List<string>();
            List<string> breed = new List<string>();
            List<string> vac = new List<string>();
            foreach(Cats x in res)
            {
                if(!name.Contains(x.name))
                {
                    name.Add(x.name);
                }
                if (!sex.Contains(x.sex))
                {
                    sex.Add(x.sex);
                }
                if (!breed.Contains(x.breed))
                {
                    breed.Add(x.breed);
                }
                if (!age.Contains(x.age))
                {
                    age.Add(x.age);
                }
                if (!vac.Contains(x.vac))
                {
                    vac.Add(x.vac);
                }
            }
            name = name.OrderBy(x => x).ToList();
            sex = sex.OrderBy(x => x).ToList();
            breed = breed.OrderBy(x => x).ToList();
            age = age.OrderBy(x => x).ToList();
            vac = vac.OrderBy(x => x).ToList();

            namebox.Items.AddRange(name.ToArray());
            sexbox.Items.AddRange(sex.ToArray());
            breedbox.Items.AddRange(breed.ToArray());
            agebox.Items.AddRange(age.ToArray());
            vacbox.Items.AddRange(vac.ToArray());
        }

        private Cats OurSearch()
        {
            string[] info = new string[6];
            if(checkBoxname.Checked)
            {
                info[0] = Convert.ToString(namebox.Text);
            }
            if (checkBoxsex.Checked)
            {
                info[1] = Convert.ToString(sexbox.Text);
            }
            if (checkBoxbreed.Checked)
            {
                info[2] = Convert.ToString(breedbox.Text);
            }
            if (checkBoxage.Checked)
            {
                info[3] = Convert.ToString(agebox.Text);
            }
            if (checkBoxvac.Checked)
            {
                info[4] = Convert.ToString(vacbox.Text);
            }
            Cats idealSearch = new Cats(info);
            return idealSearch;
        }

        private void Parsing4XML()
        {
            Cats myTemp = OurSearch();
            List<Cats> res;

            if(radioSAX.Checked)
            {
                IStrategy parser = new SAX();
                res = parser.AnalyzeFile(myTemp, path);
                Output(res);
            }
            else if (radioDOM.Checked)
            {
                IStrategy parser = new DOM();
                res = parser.AnalyzeFile(myTemp, path);
                Output(res);
            }
            else if (radioLINQ.Checked)
            {
                IStrategy parser = new LinqToXML();
                res = parser.AnalyzeFile(myTemp, path);
                Output(res);
            }
        }

        private void Output(List<Cats> res)
        {
            richTextBox1.Clear();
            foreach(Cats x in res)
            {
                richTextBox1.AppendText("Cat`s name: " + x.name + "\n");
                richTextBox1.AppendText("Sex: " + x.sex + "\n");
                richTextBox1.AppendText("Breed: " + x.breed + "\n");
                richTextBox1.AppendText("Age: " + x.age + "\n");
                richTextBox1.AppendText("Vaccinations: " + x.vac + "\n");
                richTextBox1.AppendText("❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️ \n");
            }
        }

        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(path_);
            string input = path;
            string result = @"HTML.html";
            xsl.Transform(input, result);
            MessageBox.Show("Done!");
        }

        private void Clear()
        {
            richTextBox1.Clear();
            radioDOM.Checked = false;
            radioSAX.Checked = false;
            radioLINQ.Checked = false;
            namebox.Text = null;
            sexbox.Text = null;
            breedbox.Text = null;
            agebox.Text = null;
            vacbox.Text = null;
            checkBoxname.Checked = false;
            checkBoxsex.Checked = false;
            checkBoxbreed.Checked = false;
            checkBoxage.Checked = false;
            checkBoxvac.Checked = false;
        }

        private void Help()
        {
            MessageBox.Show("The second lab from Nataliia Zakharchuk - \n student of K-24 group \n Try to find your cat","Help", MessageBoxButtons.OK);
        }

        private void OpenHTML()
        {
            button2.Enabled = true;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void namebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parsing4XML();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntoHTML();
            OpenHTML();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            errorMessage += "Are you sure you want to exit?";
            DialogResult res = MessageBox.Show(errorMessage, "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                Application.Exit();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void checkBoxbreed_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxbreed.Checked)
            {
                breedbox.Enabled = true;
            }
            else
            {
                breedbox.Enabled = false;
            }
        }

        private void checkBoxname_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxname.Checked)
            {
                namebox.Enabled = true;
            }
            else
            {
                namebox.Enabled = false;
            }
        }

        private void checkBoxsex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxsex.Checked)
            {
                sexbox.Enabled = true;
            }
            else
            {
                sexbox.Enabled = false;
            }
        }

        private void checkBoxage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxage.Checked)
            {
                agebox.Enabled = true;
            }
            else
            {
                agebox.Enabled = false;
            }
        }

        private void checkBoxvac_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxvac.Checked)
            {
                vacbox.Enabled = true;
            }
            else
            {
                vacbox.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openHTML = System.Diagnostics.Process.Start("HTML.html");
        }
    }
}
