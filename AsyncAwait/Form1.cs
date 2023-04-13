using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Task<int> SleepAsync(int MS)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(MS);
                return MS / 1000;
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int seconds = await SleepAsync(5000);
            this.Text = "Method returned after " + seconds + " seconds";
        }
    }
}
