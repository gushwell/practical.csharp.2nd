using System.Threading;

namespace WinFormsApp;

// Code 14.1 
// ここでは、途中でフォームを閉じても例外が発生しないようにしている
// 書籍のコードとは若干異なる。
public partial class Form1 : Form {

    public Form1() {
        InitializeComponent();
    }

    private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        _cancellationTokenSource.Cancel();
    }

    // コード14.1
    private void button1_Click(object sender, EventArgs e) {
        label1.Text = "";
        var th = new Thread(DoSomething);
        th.Start();   
    }

    private void DoSomething() {
        DoLongTimeWork();
        CancellationToken token = _cancellationTokenSource.Token;

        if (token.IsCancellationRequested) {
            return;
        }

        label1.Invoke((Action)delegate () {
            label1.Text = "終了";
        });
    }

    private void DoLongTimeWork() {
        System.Threading.Thread.Sleep(5000);
    }


}
