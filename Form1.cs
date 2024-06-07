using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Form_Game frm = new Form_Game();
            frm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormShow frm = new FormShow();
            frm.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd();
            frm.ShowDialog();
        }
    }
}
