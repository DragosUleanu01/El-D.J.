using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string nume)
        {
            InitializeComponent();
            using (var database = new PROIECTEntities())
            {
                var melodii = database.melodies.Where(x => x.Nume_Artist1 == nume).ToList();
                foreach (var x in melodii)
                {
                    Lista2.Items.Add(x.Link);
                 
                }
            }

        }

        
        private void Lista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.Start(Lista2.GetItemText(Lista2.SelectedItem)); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Dispose();
            form1.ShowDialog();
        }
    }
}
