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

// コード14.4
public partial class Form4 : Form {
    public Form4() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        Task.Run(() => DoSomething());
    }

    private void DoSomething() {
        DoLongTimeWork();    // 時間のかかる処理
        statusStrip1.Invoke((Action)(() => {
            toolStripStatusLabel1.Text = "終了";
        }));
    }

    private void DoLongTimeWork() {
        System.Threading.Thread.Sleep(5000);
    }

    // コード14.5
    private void button2_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        var currentContext = TaskScheduler.FromCurrentSynchronizationContext();
        Task.Run(() => {
            DoSomething();
        })
        .ContinueWith(task => {
            toolStripStatusLabel1.Text = "終了";
        }, currentContext);
    }
}

