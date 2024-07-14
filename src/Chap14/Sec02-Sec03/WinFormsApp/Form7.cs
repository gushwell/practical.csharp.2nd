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

// コード14.8
public partial class Form7 : Form {
    public Form7() {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e) {
        toolStripStatusLabel1.Text = "";
        await DoLongTimeWorkAsync();
        toolStripStatusLabel1.Text = "終了";
    }

    // 非同期メソッド - DoSomethingAsyncは何も戻さない
    private async Task DoLongTimeWorkAsync() {
        await Task.Run(() => {
            System.Threading.Thread.Sleep(5000);    // 時間のかかる処理
        });
    }

    private async Task DoSomethingAsync(int milliseconds) {
        DoLongTimeWork();    // 時間のかかる処理
    }

    private void DoLongTimeWork() {
            System.Threading.Thread.Sleep(5000);    // 時間のかかる処理
    }

}

