<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        IdColumn = New DataGridViewTextBoxColumn()
        DescriptionColumn = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        AddImageButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {IdColumn, DescriptionColumn})
        DataGridView1.Location = New Point(23, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(341, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' IdColumn
        ' 
        IdColumn.DataPropertyName = "Id"
        IdColumn.HeaderText = "Id"
        IdColumn.MinimumWidth = 6
        IdColumn.Name = "IdColumn"
        IdColumn.Width = 125
        ' 
        ' DescriptionColumn
        ' 
        DescriptionColumn.DataPropertyName = "Description"
        DescriptionColumn.HeaderText = "Description"
        DescriptionColumn.MinimumWidth = 6
        DescriptionColumn.Name = "DescriptionColumn"
        DescriptionColumn.Width = 125
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(370, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' AddImageButton
        ' 
        AddImageButton.Location = New Point(23, 241)
        AddImageButton.Name = "AddImageButton"
        AddImageButton.Size = New Size(94, 29)
        AddImageButton.TabIndex = 2
        AddImageButton.Text = "Add Image"
        AddImageButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 323)
        Controls.Add(AddImageButton)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Code sample"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IdColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddImageButton As Button
End Class
