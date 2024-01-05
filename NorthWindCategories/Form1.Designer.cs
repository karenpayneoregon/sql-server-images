namespace NorthWindCategories;

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
        UpdateButton = new Button();
        SuspendLayout();
        // 
        // UpdateButton
        // 
        UpdateButton.Location = new Point(116, 86);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new Size(94, 29);
        UpdateButton.TabIndex = 0;
        UpdateButton.Text = "Update";
        UpdateButton.UseVisualStyleBackColor = true;
        UpdateButton.Click += UpdateButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(326, 200);
        Controls.Add(UpdateButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button UpdateButton;
}
