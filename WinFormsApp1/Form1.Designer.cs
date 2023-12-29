namespace WinFormsApp1;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        ImagesComboBox = new ComboBox();
        pictureBox1 = new PictureBox();
        InvalidReadButton = new Button();
        ValidReadButton = new Button();
        CurrentDetailsButton = new Button();
        DapperSetImageButton = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // ImagesComboBox
        // 
        ImagesComboBox.AccessibleDescription = "Combox with names of images from database";
        ImagesComboBox.AccessibleName = "ImageList";
        ImagesComboBox.AccessibleRole = AccessibleRole.List;
        ImagesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        ImagesComboBox.FormattingEnabled = true;
        ImagesComboBox.Location = new Point(29, 12);
        ImagesComboBox.Name = "ImagesComboBox";
        ImagesComboBox.Size = new Size(208, 28);
        ImagesComboBox.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.AccessibleDescription = "Image container to display image selected by ComboBox above";
        pictureBox1.AccessibleName = "ImageContainer";
        pictureBox1.AccessibleRole = AccessibleRole.Graphic;
        pictureBox1.Location = new Point(29, 63);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(125, 62);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // InvalidReadButton
        // 
        InvalidReadButton.AccessibleDescription = "Try reading an image with an invalid primary key";
        InvalidReadButton.AccessibleName = "InvalidImageButton";
        InvalidReadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        InvalidReadButton.Location = new Point(519, 11);
        InvalidReadButton.Name = "InvalidReadButton";
        InvalidReadButton.Size = new Size(208, 29);
        InvalidReadButton.TabIndex = 2;
        InvalidReadButton.Text = "Invalid read";
        InvalidReadButton.UseVisualStyleBackColor = true;
        InvalidReadButton.Click += InvalidReadButton_Click;
        // 
        // ValidReadButton
        // 
        ValidReadButton.AccessibleDescription = "Read an existing record by primary key";
        ValidReadButton.AccessibleName = "ValidImageButton";
        ValidReadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        ValidReadButton.Location = new Point(519, 46);
        ValidReadButton.Name = "ValidReadButton";
        ValidReadButton.Size = new Size(208, 29);
        ValidReadButton.TabIndex = 3;
        ValidReadButton.Text = "Valid read";
        ValidReadButton.UseVisualStyleBackColor = true;
        ValidReadButton.Click += ValidReadButton_Click;
        // 
        // CurrentDetailsButton
        // 
        CurrentDetailsButton.AccessibleDescription = "Try reading an image with an invalid primary key";
        CurrentDetailsButton.AccessibleName = "InvalidImageButton";
        CurrentDetailsButton.Location = new Point(270, 12);
        CurrentDetailsButton.Name = "CurrentDetailsButton";
        CurrentDetailsButton.Size = new Size(208, 29);
        CurrentDetailsButton.TabIndex = 4;
        CurrentDetailsButton.Text = "Current details";
        CurrentDetailsButton.UseVisualStyleBackColor = true;
        CurrentDetailsButton.Click += CurrentDetailsButton_Click;
        // 
        // DapperSetImageButton
        // 
        DapperSetImageButton.Location = new Point(519, 81);
        DapperSetImageButton.Name = "DapperSetImageButton";
        DapperSetImageButton.Size = new Size(208, 29);
        DapperSetImageButton.TabIndex = 5;
        DapperSetImageButton.Text = "Dapper set image";
        DapperSetImageButton.UseVisualStyleBackColor = true;
        DapperSetImageButton.Click += DapperSetImageButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(739, 558);
        Controls.Add(DapperSetImageButton);
        Controls.Add(CurrentDetailsButton);
        Controls.Add(ValidReadButton);
        Controls.Add(InvalidReadButton);
        Controls.Add(pictureBox1);
        Controls.Add(ImagesComboBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SQL-Server working with images";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox ImagesComboBox;
    private PictureBox pictureBox1;
    private Button InvalidReadButton;
    private Button ValidReadButton;
    private Button CurrentDetailsButton;
    private Button DapperSetImageButton;
}
