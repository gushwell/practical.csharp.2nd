using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp;

// コード14.6
public partial class Form5 : Form {
    public Form5() {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        await Task.Run(() => DoLongTimeWork());
        toolStripStatusLabel1.Text = "終了";
   
    }
    private void DoLongTimeWork() {
        System.Threading.Thread.Sleep(5000);
    }

}
