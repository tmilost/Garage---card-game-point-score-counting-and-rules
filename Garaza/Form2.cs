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
    public partial class Form2 : Form 
    {
        public Form2()
        {
            InitializeComponent();
            //Label name change
            label1.Text = Player.Name1;
            label2.Text = Player.Name2;
            label3.Text = Player.Name3;
            label4.Text = Player.Name4;
            label5.Text = Player.Name5;

            //label visibility depends of number of player
            switch (Player.NumberOfPlayer)
            {
                case 5:
                    label5.Visible = true;
                    textBox5.Visible = true;
                    richTextBox5.Visible = true;
                    richTextBox10.Visible = true;
                    goto case 4;
                   
                case 4:
                    label4.Visible = true;
                    textBox4.Visible = true;
                    richTextBox4.Visible = true;
                    richTextBox9.Visible = true;
                    goto case 3;
                    
                    
                case 3:
                    label3.Visible = true;
                    textBox3.Visible = true;
                    richTextBox3.Visible = true;
                    richTextBox8.Visible = true;
                    goto case 2;
                    

                case 2:
                    label2.Visible = true;
                    textBox2.Visible = true;
                    richTextBox2.Visible = true;
                    richTextBox7.Visible = true;
                    goto case 1;
                    

                case 1:
                    label1.Visible = true;
                    textBox1.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox6.Visible = true; 
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        int i = 1;
        KanastaCaculatePoints k = new KanastaCaculatePoints();
        KanastaCaculatePoints k1 = new KanastaCaculatePoints();
        KanastaCaculatePoints k2 = new KanastaCaculatePoints();
        KanastaCaculatePoints k3 = new KanastaCaculatePoints();
        KanastaCaculatePoints k5 = new KanastaCaculatePoints();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //prvi igrac
                k.BrojBodova = Convert.ToInt32(textBox1.Text);

                richTextBox1.Focus();
                richTextBox1.AppendText(i + " Runda: " + k.AllNumberOfPoints() + "\n");

                k.ukupanBrojBodova();
                richTextBox6.Text = "Ukupan rezultat: \n" + k.ukupanBrojBodova() + "\n Za otvaranje:" + k.zaOtvaranje() + "\n";
                k.PredhodniRezultat = k.Rezultat;
                //drugi igrac
                if (!(label2.Text == "" && Player.Name2 == ""))
                {
                    k1.BrojBodova = Convert.ToInt32(textBox2.Text);

                    richTextBox2.Focus();
                    richTextBox2.AppendText(i + " Runda: " + k1.AllNumberOfPoints() + "\n");

                    k1.ukupanBrojBodova();
                    richTextBox7.Text = "Ukupan rezultat: \n" + k1.ukupanBrojBodova() + "\n Za otvaranje:" + k1.zaOtvaranje() + "\n";
                    k1.PredhodniRezultat = k1.Rezultat;
                }
                //treci igrac
                if (!(label3.Text == "" && Player.Name3 == ""))
                {
                    k2.BrojBodova = Convert.ToInt32(textBox3.Text);

                    richTextBox3.Focus();
                    richTextBox3.AppendText(i + " Runda: " + k2.AllNumberOfPoints() + "\n");

                    k2.ukupanBrojBodova();
                    richTextBox8.Text = "Ukupan rezultat: \n" + k2.ukupanBrojBodova() +"\n Za otvaranje:" + k2.zaOtvaranje() + "\n";
                    k2.PredhodniRezultat = k2.Rezultat;
                }
                //cetvrti igrac
                if (!(label4.Text == "" && Player.Name4 == ""))
                {
                    k3.BrojBodova = Convert.ToInt32(textBox4.Text);

                    richTextBox4.Focus();
                    richTextBox4.AppendText(i + " Runda: " + k3.AllNumberOfPoints() + "\n" );

                    k3.ukupanBrojBodova();
                    richTextBox9.Text = "Ukupan rezultat: \n" + k3.ukupanBrojBodova() + "\n Za otvaranje:" + k3.zaOtvaranje() + "\n";
                    k3.PredhodniRezultat = k3.Rezultat;
                }
                //peti igrac
                if (!(label5.Text == "" && Player.Name5 == ""))
                {
                    k5.BrojBodova = Convert.ToInt32(textBox5.Text);

                    richTextBox5.Focus();
                    richTextBox5.AppendText(i + " Runda: " + k5.AllNumberOfPoints());


                    k5.ukupanBrojBodova();
                    richTextBox10.Text = "Ukupan rezultat: \n" + k5.ukupanBrojBodova() + "\n Za otvaranje:" + k5.zaOtvaranje() + "\n";
                    k5.PredhodniRezultat = k5.Rezultat;
                }
            }


            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            catch (Exception ef)
            {
                MessageBox.Show(ef.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "       ⤾(o_o)⤿", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 a = new Form1();
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "       ⤾(o_o)⤿", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form2 a = new Form2();
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rules_Kanasta c = new Rules_Kanasta();
            c.ShowDialog();

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void changeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
