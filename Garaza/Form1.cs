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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Player.Name1;
            textBox2.Text= Player.Name2;
            textBox3.Text= Player.Name3;
            textBox4.Text= Player.Name4;
            textBox5.Text= Player.Name5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Player.Name1 = textBox1.Text;
            Player.Name2 = textBox2.Text;
            Player.Name3 = textBox3.Text;
            Player.Name4 = textBox4.Text;
            Player.Name5 = textBox5.Text;


            //for class
            Player.NumberOfPlayer = Convert.ToInt32(numericUpDown1.Value);

            //MessageBox.Show(p.Name1+p.Name2+p.Name3+p.Name4+p.Name5, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //Check if name is empty
            if ((textBox1.Text == "" && textBox1.Visible == true))
            {
                MessageBox.Show("Unesite ime za Player 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((textBox2.Text == "" && textBox2.Visible == true))
            {
                MessageBox.Show("Unesite ime za Player 2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((textBox3.Text == "" && textBox3.Visible == true))
            {
                MessageBox.Show("Unesite ime za Player 3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((textBox4.Text == "" && textBox4.Visible == true))
            {
                MessageBox.Show("Unesite ime za Player 4", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((textBox5.Text == "" && textBox5.Visible == true))
            {
                MessageBox.Show("Unesite ime za Player 5", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Form Open
                if (numericUpDown1.Value >= 1)
                {
                    if (comboBox1.Text == "KANASTA")
                    {
                        Form2 a = new Form2();
                        this.Hide();
                        a.ShowDialog();
                        this.Close();
                    }
                    if (comboBox1.Text == "LORA")
                    {
                        LORA l = new LORA();
                        this.Hide();
                        l.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select number of players", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Panel visible
            if(!(numericUpDown1.Value==0))
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

            //Textbox visible
            
            switch (numericUpDown1.Value)
            {
                case 0:
                    
                    break;
                case 1:
                    label3a1.Visible = true;
                    textBox1.Visible = true;

                    label4a2.Visible = false;
                    textBox2.Visible = false;
                    break;
                case 2:
                    label4a2.Visible = true;
                    textBox2.Visible = true;

                    label5a3.Visible = false;
                    textBox3.Visible = false;
                    break;
                case 3:
                    label5a3.Visible = true;
                    textBox3.Visible = true;

                    label6a4.Visible = false;
                    textBox4.Visible = false;
                    break;
                case 4:
                    label6a4.Visible = true;
                    textBox4.Visible = true;

                    label7a5.Visible = false;
                    textBox5.Visible = false;
                    break;
                case 5:
                    label7a5.Visible = true;
                    textBox5.Visible = true;
                    break;
                default:
                    MessageBox.Show("Wrong number","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;

                    
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
