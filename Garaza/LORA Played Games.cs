using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garaza
{
    public partial class LORA_Played_Games : Form
    {
        public LORA_Played_Games()
        {
            InitializeComponent();

            label1.Text = Player.Name1;
            label2.Text = Player.Name2;
            label3.Text = Player.Name3;
            label4.Text = Player.Name4;
            label5.Text = Player.Name5;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LORA_Played_Games_Load(object sender, EventArgs e)
        {

        }
    }
}
