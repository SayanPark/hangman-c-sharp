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
    public partial class FormShow : Form
    { IHangmanDB db = new HangmanDB();
        public FormShow()
        {
            InitializeComponent();
        }

        private void FormShow_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SelectAll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
                if (MessageBox.Show($"مطمئن هستید ؟ {name} آیا از حذف", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string xname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    db.Delete(xname);
                   dataGridView1.DataSource = db.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید");
            }
        }
    }
}
