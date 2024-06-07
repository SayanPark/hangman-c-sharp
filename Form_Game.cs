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
    public partial class Form_Game : Form
    { public string theName;
        public bool win;
        public int countWrong = 0;
        public Button[] buttons = new Button[20];
        IHangmanDB db = new HangmanDB();
        public Form_Game()
        {
            InitializeComponent();
        }

        private void Form_Game_Load(object sender, EventArgs e)
        {
            comboChar.Items.Add('a');
            comboChar.Items.Add('b');
            comboChar.Items.Add('c');
            comboChar.Items.Add('d');
            comboChar.Items.Add('e');
            comboChar.Items.Add('f');
            comboChar.Items.Add('g');
            comboChar.Items.Add('h');
            comboChar.Items.Add('i');
            comboChar.Items.Add('j');
            comboChar.Items.Add('k');
            comboChar.Items.Add('l');
            comboChar.Items.Add('m');
            comboChar.Items.Add('n');
            comboChar.Items.Add('o');
            comboChar.Items.Add('p');
            comboChar.Items.Add('q');
            comboChar.Items.Add('r');
            comboChar.Items.Add('s');
            comboChar.Items.Add('t');
            comboChar.Items.Add('u');
            comboChar.Items.Add('v');
            comboChar.Items.Add('w');
            comboChar.Items.Add('x');
            comboChar.Items.Add('y');
            comboChar.Items.Add('z');




            int xcount = db.CountOfData();
            Random rnd = new Random();
           
            int n = rnd.Next(0, xcount);

           
            DataTable dt = new DataTable();
            dt = db.SelectAll();
            theName = dt.Rows[n][0].ToString();

           
            int i;
            
            for (i = 0; i < theName.Length; i++)
            {
                var b = new Button();
              //  b.Text = theName[i].ToString();
               

                b.Height = 50;
                b.Width = 50;
                b.Top = 70;
                b.Left = 5 + 100 * i;

                b.Name = (i + 1).ToString();        
                
                b.Click += new EventHandler(b_click);
                buttons[i] = b;
                this.Controls.Add(buttons[i]);
            }



        }

        private void b_click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (buttons[1].Text == "")
            //    MessageBox.Show("e");
            char ch =(char) comboChar.SelectedItem;
            bool Ok = false;
            for (int i = 0; i < theName.Length; i++)
                if (ch == theName[i])
                {
                    buttons[i].Text = ch.ToString();
                    Ok = true;
                }
            if (!Ok)
            { lblWrong.Text += ch + " ";
                countWrong++;
            }
            if (countWrong == theName.Length)
            {
                MessageBox.Show("شما باختید!!!");
                Application.Exit();
            }
            win = true;
            for (int i = 0; i < theName.Length; i++)
                if (buttons[i].Text == "")
                    win = false;
            if(win)
            {
                MessageBox.Show("شما برنده شدید!!!");
                Application.Exit();
            }
        }
    }
}
