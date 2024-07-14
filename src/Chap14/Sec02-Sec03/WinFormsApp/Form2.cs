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

// コード14.2
public partial class Form2 : Form {
    private BackgroundWorker _worker = new BackgroundWorker();

    public Form2() {
        InitializeComponent();
        _worker.DoWork += _worker_DoWork;
        _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
    }


    private void _worker_DoWork(object? sender, DoWorkEventArgs e) {
        DoLongTimeWork();    // 時間のかかる処理
    }

    private void _worker_RunWorkerCompleted(object? sender,
                                            RunWorkerCompletedEventArgs e) {
        label1.Text = "終了";
    }

    private void button1_Click(object sender, EventArgs e) {
        label1.Text = "";
        _worker.RunWorkerAsync();
    }

    private void DoLongTimeWork() {
        System.Threading.Thread.Sleep(5000);
    }

}
