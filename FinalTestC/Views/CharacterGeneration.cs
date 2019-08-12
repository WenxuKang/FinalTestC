using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalTestC.Views
{
    public partial class CharacterGeneration : FinalTestC.Views.MasterForm
    {
        public object MainTabControl { get; private set; }

        public CharacterGeneration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
