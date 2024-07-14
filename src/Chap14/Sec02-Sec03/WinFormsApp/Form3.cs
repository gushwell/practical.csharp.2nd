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

// コード14.3
public partial class Form3 : Form {

    private BackgroundWorker _worker = new BackgroundWorker();

    public Form3() {
        InitializeComponent();
        _worker.DoWork += _worker_DoWork;
        _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
        _worker.ProgressChanged += _worker_ProgressChanged;
        _worker.WorkerReportsProgress = true;
    }

    // 本来の処理を行う
    private void _worker_DoWork(object? sender, DoWorkEventArgs e) {
        var collection = Enumerable.Range(1, 200).ToArray();
        int count = 0;
        foreach (var n in collection) {
            // nに対する処理をする
            DoWork(n);
            // 何パーセントまで処理をしたか求める
            var per = count * 100 / collection.Length;
            // プログレスバーを更新するために、処理状況を通知する
            _worker.ReportProgress(Math.Min(per, toolStripProgressBar1.Maximum), null);
            count++;
        }
    }

    // プログレスバーの更新
    private void _worker_ProgressChanged(object? sender, ProgressChangedEventArgs e) {
        toolStripProgressBar1.Value = e.ProgressPercentage;
    }

    // 処理が完了したときに呼び出される
    private void _worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e) {
        toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
        toolStripStatusLabel1.Text = "完了";
    }

    private void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        // 処理を開始する
        _worker.RunWorkerAsync();
    }

    private void DoWork(int n) {
        System.Threading.Thread.Sleep(50);
    }
}
