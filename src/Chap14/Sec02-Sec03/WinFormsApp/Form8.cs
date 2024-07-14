using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp;

// コード14.9
public partial class Form8 : Form {
    public Form8() {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        var elapsed = await DoLongTimeWorkAsync(4000);
        toolStripStatusLabel1.Text = $"{elapsed}ミリ秒";
    }

    // 非同期メソッド - DoLongTimeWorkAsyncは、long型の値を戻す
    private async Task<long> DoLongTimeWorkAsync(int milliseconds) {
        var sw = Stopwatch.StartNew();
        await Task.Run(() => {
            System.Threading.Thread.Sleep(5000);    // 時間のかかる処理
        });
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}
