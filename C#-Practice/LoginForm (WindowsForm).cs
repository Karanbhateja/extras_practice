using System;
using System.Windows.Forms;
namespace Registration_form{
    public partial class Form1 : Form{
        public Form1(){ InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e){
// Label, TextBox, Button, RadioButton, RichTextBox, CheckBox, ListBox, PictureBox
// Text, Autosize, Location = new Point(), this.Controls.Add(t1), 
            Label l = new Label();
            l.Text = "Login form";
            l.Location = new Point(310, 20);
            l.AutoSize = true;
            this.Controls.Add(l);

            Label l2 = new Label();
            l2.Text = "Name";
            l2.Location = new Point(210, 50);
            l2.AutoSize = true;
            this.Controls.Add(l2);

            TextBox t2 = new TextBox();
            t2.Location = new Point(350, 80);
            t2.AutoSize = true;
            this.Controls.Add(t2);

            RadioButton rb = new RadioButton();
            rb.Text = "male";
            rb.Location = new Point(210, 190);
            rb.AutoSize = true;
            rb.Name = "Radio1";
            this.Controls.Add(rb);

            RadioButton rb1 = new RadioButton();
            rb1.Text = "female";
            rb1.Location = new Point(210, 210);
            rb1.AutoSize = true;
            this.Controls.Add(rb1);
        }
        private void Radio1_ClickChanged(object sender, EventArgs e)
        {
            String msg = "male";
            box.Text = msg;
        }
    }
}
