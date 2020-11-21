using Algorand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAlgorandApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            var displayAddress = account.Address.ToString();
            var accountmnemonic = account.ToMnemonic();
            label2.Text = displayAddress;
            textBox1.Text = displayAddress;
            textBox2.Text = accountmnemonic;
        }
    }
}
