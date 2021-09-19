using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace MathProf
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
           
           
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            Matematik mat = new Matematik();
            mat.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simülasyon sml = new Simülasyon();
            sml.Show();
            this.Hide();
        }
    }
    
}
