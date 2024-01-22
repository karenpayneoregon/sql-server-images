namespace NorthWindCategoriesJson;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        coreBindingNavigator1 = new CoreBindingNavigator();
        pictureBox1 = new PictureBox();
        coreBindingNavigator1.BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // coreBindingNavigator1
        // 
        coreBindingNavigator1.ImageScalingSize = new Size(20, 20);
        coreBindingNavigator1.Location = new Point(0, 0);
        coreBindingNavigator1.Name = "coreBindingNavigator1";
        coreBindingNavigator1.Size = new Size(279, 27);
        coreBindingNavigator1.TabIndex = 0;
        coreBindingNavigator1.Text = "coreBindingNavigator1";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Location = new Point(0, 27);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Padding = new Padding(10, 10, 0, 0);
        pictureBox1.Size = new Size(279, 200);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(279, 227);
        Controls.Add(pictureBox1);
        Controls.Add(coreBindingNavigator1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        coreBindingNavigator1.EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CoreBindingNavigator coreBindingNavigator1;
    private PictureBox pictureBox1;
}
