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
    public partial class FormAdd : Form
    {
        IHangmanDB db = new HangmanDB();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            bool isSuccess;
            isSuccess = db.Insert(txtName.Text);
            if (isSuccess == true)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
