using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_id.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            //-----------------------------------------
            string fn;
            fn = "C:\\Data\\";
            string p, r;
            //---------first name--------------
            p = fn + this.txt_id.Text + "_fn.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_textBox.Text = r;
            }
            //----------last name--------------
            p = fn + this.txt_id.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_textBox.Text = r;
            }
            //----------Tell--------------
            p = fn + this.txt_id.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_textBox.Text = r;
            }
            //----------cell--------------
            p = fn + this.txt_id.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.celnum_textBox.Text = r;
            }
            //----------email--------------
            p = fn + this.txt_id.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_textBox.Text = r;
            }
            //----------address--------------
            p = fn + this.txt_id.Text + "_address.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.address_textBox.Text = r;
            }
            //----------comment--------------
            p = fn + this.txt_id.Text + "_comment.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comment_textBox.Text = r;
            }
            // -----------------------------------
            this.id_textBox.Text= this.txt_id.Text;
        }
    }
}
