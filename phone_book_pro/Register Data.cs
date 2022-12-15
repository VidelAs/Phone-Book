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
    public partial class Register_Data : Form
    {
        public Register_Data()
        {
            InitializeComponent();
        }

        private void newdata_butt_Click(object sender, EventArgs e)
        {
            this.newdata_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            this.Info_gbox.Enabled = true;
            //---------Clear Textboxes-------------
            this.id_textBox.ResetText();
            this.fn_textBox.ResetText();
            this.ln_textBox.ResetText();
            this.tel_textBox.ResetText();
            this.email_textBox.ResetText();
            this.address_textBox.ResetText();
            this.comment_textBox.ResetText();
            this.celnum_textBox.ResetText();
            //------------------------------------
        }

        private void Save_butt_Click(object sender, EventArgs e)
        {
            if (this.id_textBox.Text == "")
            {
                MessageBox.Show("You must enter the ID");
            }
            this.newdata_butt.Enabled = true;
            this.Save_butt.Enabled = false;
            this.Info_gbox.Enabled = false;
            //--------------------------------
            string fn;
            fn = "C:\\Data\\";
            string p;
            //---------first name----------
            p = fn + this.id_textBox.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox.Text, Encoding.UTF8);
            //---------last name----------
            p = fn + this.id_textBox.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox.Text, Encoding.UTF8);
            //------------Telephone-------------
            p = fn + this.id_textBox.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_textBox.Text, Encoding.UTF8);
            //-----------cell------------
            p = fn + this.id_textBox.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.celnum_textBox.Text, Encoding.UTF8);
            //-----------email------------
            p = fn + this.id_textBox.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_textBox.Text, Encoding.UTF8);
            //-----------address------------
            p = fn + this.id_textBox.Text + "_address.txt";
            System.IO.File.WriteAllText(p, this.address_textBox.Text, Encoding.UTF8);
            //-----------comment------------
            p = fn + this.id_textBox.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.comment_textBox.Text, Encoding.UTF8);
            MessageBox.Show("Saved!!");
        }

        private void Register_Data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = false;
        }
    }
}
