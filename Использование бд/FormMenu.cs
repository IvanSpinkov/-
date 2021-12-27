using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Использование_бд
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void btnZakaz_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(tbxSum2.Text);
            double sumzakaz = 0;

            tbxZakaz2.Text = "Ваш заказ: ";
            tbxZakaz2.Text += "===============\r\n";

            if (rbt11.Checked)
            {
                sumzakaz += 100;
                tbxZakaz2.Text += rbt11.Text + "\r\n";
            }
            if (rbt12.Checked)
            {
                sumzakaz += 70;
                tbxZakaz2.Text += rbt12.Text + "\r\n";
            }
            if (rbt13.Checked)
            {
                sumzakaz += 80;
                tbxZakaz2.Text += rbt13.Text + "\r\n";
            }
            if (rbt21.Checked)
            {
                sumzakaz += 90;
                tbxZakaz2.Text += rbt21.Text + "\r\n";
            }
            if (rbt22.Checked)
            {
                sumzakaz += 110;
                tbxZakaz2.Text += rbt22.Text + "\r\n";
            }
            if (rbt23.Checked)
            {
                sumzakaz += 240;
                tbxZakaz2.Text += rbt23.Text + "\r\n";
            }
            if (chb31.Checked)
            {
                sumzakaz += 25;
                tbxZakaz2.Text += chb31.Text + "\r\n";
            }
            if (chb32.Checked)
            {
                sumzakaz += 35;
                tbxZakaz2.Text += chb32.Text + "\r\n";
            }
            if (chb33.Checked)
            {
                sumzakaz += 30;
                tbxZakaz2.Text += chb33.Text + "\r\n";
            }

            if (sum - sumzakaz >= 0)
            {
                tbxZakaz2.Text += "===============\r\n";
                tbxZakaz2.Text += "Сумма заказа: " + sumzakaz + "р.\r\n";
                tbxZakaz2.Text += "Сдача: " + (sum - sumzakaz) + "р.";
            }
            else
            {
                tbxZakaz2.Clear();
                MessageBox.Show("Не хватает денег для оплаты заказа!", "Внимание!",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxSum2.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Очистить заказ?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rez == DialogResult.Yes)
            {
                tbxSum2.Clear();
                tbxZakaz2.Clear();
                rbt11.Checked = false;
                rbt12.Checked = false;
                rbt13.Checked = false;
                rbt21.Checked = false;
                rbt22.Checked = false;
                rbt23.Checked = false;
                chb31.Checked = false;
                chb32.Checked = false;
                chb33.Checked = false;

                tbxSum2.Focus();
            }
        }

        private void tbxSum2_TextChanged(object sender, EventArgs e)
        {
            btnZakaz.Enabled = tbxSum2.Text != "";
        }

        private void tbxSum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
            if (e.KeyChar == (Char)Keys.Back) e.Handled = false;
            if (e.KeyChar == ',' && tbxSum2.Text.IndexOf(',') == -1 &&
               tbxSum2.SelectionStart > 0) e.Handled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

