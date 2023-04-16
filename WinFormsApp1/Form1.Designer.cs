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
            this.ImagesComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InvalidReadButton = new System.Windows.Forms.Button();
            this.ValidReadButton = new System.Windows.Forms.Button();
            this.CurrentDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagesComboBox
            // 
            this.ImagesComboBox.AccessibleDescription = "Combox with names of images from database";
            this.ImagesComboBox.AccessibleName = "ImageList";
            this.ImagesComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.ImagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImagesComboBox.FormattingEnabled = true;
            this.ImagesComboBox.Location = new System.Drawing.Point(29, 12);
            this.ImagesComboBox.Name = "ImagesComboBox";
            this.ImagesComboBox.Size = new System.Drawing.Size(208, 28);
            this.ImagesComboBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Image container to display image selected by ComboBox above";
            this.pictureBox1.AccessibleName = "ImageContainer";
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.pictureBox1.Location = new System.Drawing.Point(29, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InvalidReadButton
            // 
            this.InvalidReadButton.AccessibleDescription = "Try reading an image with an invalid primary key";
            this.InvalidReadButton.AccessibleName = "InvalidImageButton";
            this.InvalidReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvalidReadButton.Location = new System.Drawing.Point(519, 11);
            this.InvalidReadButton.Name = "InvalidReadButton";
            this.InvalidReadButton.Size = new System.Drawing.Size(208, 29);
            this.InvalidReadButton.TabIndex = 2;
            this.InvalidReadButton.Text = "Invalid read";
            this.InvalidReadButton.UseVisualStyleBackColor = true;
            this.InvalidReadButton.Click += new System.EventHandler(this.InvalidReadButton_Click);
            // 
            // ValidReadButton
            // 
            this.ValidReadButton.AccessibleDescription = "Read an existing record by primary key";
            this.ValidReadButton.AccessibleName = "ValidImageButton";
            this.ValidReadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidReadButton.Location = new System.Drawing.Point(519, 46);
            this.ValidReadButton.Name = "ValidReadButton";
            this.ValidReadButton.Size = new System.Drawing.Size(208, 29);
            this.ValidReadButton.TabIndex = 3;
            this.ValidReadButton.Text = "Valid read";
            this.ValidReadButton.UseVisualStyleBackColor = true;
            this.ValidReadButton.Click += new System.EventHandler(this.ValidReadButton_Click);
            // 
            // CurrentDetailsButton
            // 
            this.CurrentDetailsButton.AccessibleDescription = "Try reading an image with an invalid primary key";
            this.CurrentDetailsButton.AccessibleName = "InvalidImageButton";
            this.CurrentDetailsButton.Location = new System.Drawing.Point(270, 12);
            this.CurrentDetailsButton.Name = "CurrentDetailsButton";
            this.CurrentDetailsButton.Size = new System.Drawing.Size(208, 29);
            this.CurrentDetailsButton.TabIndex = 4;
            this.CurrentDetailsButton.Text = "Current details";
            this.CurrentDetailsButton.UseVisualStyleBackColor = true;
            this.CurrentDetailsButton.Click += new System.EventHandler(this.CurrentDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 558);
            this.Controls.Add(this.CurrentDetailsButton);
            this.Controls.Add(this.ValidReadButton);
            this.Controls.Add(this.InvalidReadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImagesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL-Server working with images";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ComboBox ImagesComboBox;
    private PictureBox pictureBox1;
    private Button InvalidReadButton;
    private Button ValidReadButton;
    private Button CurrentDetailsButton;
}
