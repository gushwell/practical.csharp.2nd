namespace WinFormsApp;

partial class Form3 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        button1 = new Button();
        statusStrip1 = new StatusStrip();
        toolStripProgressBar1 = new ToolStripProgressBar();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(41, 27);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
        statusStrip1.Location = new Point(0, 134);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(358, 22);
        statusStrip1.TabIndex = 3;
        statusStrip1.Text = "statusStrip1";
        // 
        // toolStripProgressBar1
        // 
        toolStripProgressBar1.Name = "toolStripProgressBar1";
        toolStripProgressBar1.Size = new Size(100, 16);
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(32, 17);
        toolStripStatusLabel1.Text = "label";
        // 
        // Form3
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(358, 156);
        Controls.Add(statusStrip1);
        Controls.Add(button1);
        Name = "Form3";
        Text = "Form3";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripStatusLabel toolStripStatusLabel1;
}