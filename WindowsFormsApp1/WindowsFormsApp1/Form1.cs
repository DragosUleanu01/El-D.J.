using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Afisare_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            using (var db = new PROIECTEntities())
            {
            
                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    var melodii = db.melodies.ToList();

                    foreach (var x in melodii)
                    {
                        Lista.Items.Add(x.Nume_Melodie);
                    }
                }
                else if (!checkBox1.Checked && checkBox2.Checked)
                {
                    var artisti = db.melodies.GroupBy(a => new
                    {
                        name1 = a.Nume_Artist1
                       
                    }).Select(g => g.FirstOrDefault()).ToList();

                    foreach (var x in artisti)
                    {
                        Lista.Items.Add(x.Nume_Artist1);
                    }
                }

                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var melodie_selectata = new melodie();
            var nume = Lista.GetItemText(Lista.SelectedItem);
            using (var db = new PROIECTEntities())

            {
                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    melodie_selectata = db.melodies.Where(x => x.Nume_Melodie == nume).FirstOrDefault();
                    label1.Text = melodie_selectata.Gen;
                    label2.Text = melodie_selectata.Nume_Artist2;
                    label3.Text = melodie_selectata.Nume_Artist1;
                    label4.Text = melodie_selectata.Nume_Melodie;
                    linkLabel1.Text = melodie_selectata.Link;
                }
                else if (!checkBox1.Checked && checkBox2.Checked)
                {
                 
                    Form2 form2 = new Form2(nume);

                    Hide();
                    form2.ShowDialog();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
