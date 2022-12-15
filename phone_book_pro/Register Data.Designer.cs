namespace phone_book_pro
{
    partial class Register_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Data));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newdata_butt = new System.Windows.Forms.ToolStripButton();
            this.Save_butt = new System.Windows.Forms.ToolStripButton();
            this.Info_gbox = new System.Windows.Forms.GroupBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fn_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ln_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.celnum_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.comment_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Info_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newdata_butt,
            this.Save_butt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(436, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newdata_butt
            // 
            this.newdata_butt.Image = ((System.Drawing.Image)(resources.GetObject("newdata_butt.Image")));
            this.newdata_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newdata_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newdata_butt.Name = "newdata_butt";
            this.newdata_butt.Size = new System.Drawing.Size(119, 36);
            this.newdata_butt.Text = "New Data";
            this.newdata_butt.Click += new System.EventHandler(this.newdata_butt_Click);
            // 
            // Save_butt
            // 
            this.Save_butt.Image = ((System.Drawing.Image)(resources.GetObject("Save_butt.Image")));
            this.Save_butt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_butt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_butt.Name = "Save_butt";
            this.Save_butt.Size = new System.Drawing.Size(149, 36);
            this.Save_butt.Text = "Save Changes";
            this.Save_butt.Click += new System.EventHandler(this.Save_butt_Click);
            // 
            // Info_gbox
            // 
            this.Info_gbox.Controls.Add(this.comment_textBox);
            this.Info_gbox.Controls.Add(this.label7);
            this.Info_gbox.Controls.Add(this.address_textBox);
            this.Info_gbox.Controls.Add(this.label6);
            this.Info_gbox.Controls.Add(this.fn_textBox);
            this.Info_gbox.Controls.Add(this.label5);
            this.Info_gbox.Controls.Add(this.ln_textBox);
            this.Info_gbox.Controls.Add(this.label4);
            this.Info_gbox.Controls.Add(this.email_textBox);
            this.Info_gbox.Controls.Add(this.label3);
            this.Info_gbox.Controls.Add(this.celnum_textBox);
            this.Info_gbox.Controls.Add(this.label2);
            this.Info_gbox.Controls.Add(this.tel_textBox);
            this.Info_gbox.Controls.Add(this.label1);
            this.Info_gbox.Controls.Add(this.id_textBox);
            this.Info_gbox.Controls.Add(this.lblID);
            this.Info_gbox.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_gbox.Location = new System.Drawing.Point(29, 74);
            this.Info_gbox.Name = "Info_gbox";
            this.Info_gbox.Size = new System.Drawing.Size(370, 377);
            this.Info_gbox.TabIndex = 1;
            this.Info_gbox.TabStop = false;
            this.Info_gbox.Text = "Information";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(104, 272);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(121, 24);
            this.address_textBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address:";
            // 
            // fn_textBox
            // 
            this.fn_textBox.Location = new System.Drawing.Point(104, 83);
            this.fn_textBox.Name = "fn_textBox";
            this.fn_textBox.Size = new System.Drawing.Size(121, 24);
            this.fn_textBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name:";
            // 
            // ln_textBox
            // 
            this.ln_textBox.Location = new System.Drawing.Point(104, 127);
            this.ln_textBox.Name = "ln_textBox";
            this.ln_textBox.Size = new System.Drawing.Size(121, 24);
            this.ln_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name:";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(61, 229);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(164, 24);
            this.email_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telephone:";
            // 
            // celnum_textBox
            // 
            this.celnum_textBox.Location = new System.Drawing.Point(104, 195);
            this.celnum_textBox.Name = "celnum_textBox";
            this.celnum_textBox.Size = new System.Drawing.Size(121, 24);
            this.celnum_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cell Number:";
            // 
            // tel_textBox
            // 
            this.tel_textBox.Location = new System.Drawing.Point(104, 164);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(121, 24);
            this.tel_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(61, 42);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(121, 24);
            this.id_textBox.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // comment_textBox
            // 
            this.comment_textBox.Location = new System.Drawing.Point(104, 314);
            this.comment_textBox.Multiline = true;
            this.comment_textBox.Name = "comment_textBox";
            this.comment_textBox.Size = new System.Drawing.Size(199, 57);
            this.comment_textBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Comment:";
            // 
            // Register_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 463);
            this.Controls.Add(this.Info_gbox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Register_Data";
            this.Text = "Register_Data";
            this.Load += new System.EventHandler(this.Register_Data_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Info_gbox.ResumeLayout(false);
            this.Info_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newdata_butt;
        private System.Windows.Forms.ToolStripButton Save_butt;
        private System.Windows.Forms.GroupBox Info_gbox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fn_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ln_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox celnum_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox comment_textBox;
        private System.Windows.Forms.Label label7;
    }
}