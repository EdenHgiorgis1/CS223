using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
          
        {
            pro p = new pro
            {
                number = Convert.ToInt32(txt_num.Text),
                date = txt_date.Text,
                itemName = txt_name.Text,
                sku = txt_sku.Text, 
                quantity = Convert.ToInt32(txt_quantity.Text),
                price = Convert.ToInt32(txt_price.Text),
               

            };

            p.save();
            String name = txt_name.Text;
            MessageBox.Show($"       Item {name} is Stored Succesfully ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"        Closed ");
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
