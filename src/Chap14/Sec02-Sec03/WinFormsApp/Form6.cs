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

// コード14.7
public partial class Form6 : Form {
    public Form6() {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        var elapsed = await Task.Run(() => DoLongTimeWork());
        toolStripStatusLabel1.Text = $"{elapsed}ミリ秒";
    }

    // 戻り値のある同期メソッド
    private long DoLongTimeWork() {
        var sw = Stopwatch.StartNew();
        // 時間のかかる処理
        System.Threading.Thread.Sleep(5000);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}

