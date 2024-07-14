namespace WinFormsApp;

public partial class MainForm : Form {

    public MainForm() {
        InitializeComponent();
    }

    // コード14.0 
    private void button1_Click(object sender, EventArgs e) {
        label1.Text = "";
        Cursor = Cursors.WaitCursor;
        DoLongTimeWork();    
        label1.Text = "終了";
        Cursor = Cursors.Arrow;

    }

    private void DoLongTimeWork() {
        System.Threading.Thread.Sleep(5000);
    }

    // コード14.1
    private void button2_Click(object sender, EventArgs e) {
        var fm = new Form1();
        fm.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e) {
        var fm = new Form2();
        fm.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e) {
        var fm = new Form3();
        fm.ShowDialog();

    }

    private void button5_Click(object sender, EventArgs e) {
        var fm = new Form4();
        fm.ShowDialog();

    }

    private void button6_Click(object sender, EventArgs e) {
        var fm = new Form5();
        fm.ShowDialog();

    }

    private void button7_Click(object sender, EventArgs e) {
        var fm = new Form6();
        fm.ShowDialog();

    }

    private void button8_Click(object sender, EventArgs e) {
        var fm = new Form7();
        fm.ShowDialog();

    }

    private void button9_Click(object sender, EventArgs e) {

        var fm = new Form8();
        fm.ShowDialog();
    }
}
