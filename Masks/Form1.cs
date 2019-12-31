using FindInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masks
{
    public partial class Form1 : Form
    {
        Random random;
        List<Mask> masks;
        public Form1()
        {
            InitializeComponent();
            LoadComponent();
        }

        private void LoadComponent()
        {
            masks = FileEngine.OpenFile("mask.txt");
            random = new Random();
            GenerateMask();
        }
        private void GenerateMask()
        {
            if (masks.Count != 0)
            {
                int index = random.Next(masks.Count);
                try
                {
                    CharacterPicture.BackgroundImage = Image.FromFile(masks[index].path);
                }
                catch
                {
                    CharacterPicture.BackgroundImage = Properties.Resources.errorimage;
                }
                NameLabel.Text = masks[index].name.ToUpper();
                masks.Remove(masks[index]);
            }
            else
            {
                CharacterPicture.BackgroundImage = Properties.Resources.theend;
                NameLabel.Text = "Чуваки кончились";
            }
        }

        private void CharacterPicture_Click(object sender, EventArgs e)
        {
            GenerateMask();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            GenerateMask();
        }

        private void CharacterPicture_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                GenerateMask();
            }
        }

        private void NameLabel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                GenerateMask();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter|| e.KeyCode == Keys.Space)
            {
                GenerateMask();
            }
        }
    }
}
