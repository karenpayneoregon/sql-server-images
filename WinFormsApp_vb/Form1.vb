Imports System.IO

Public Class Form1
    Private _bindingSourceImages As New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim data As DataTable = PhotoOperations.ReadAllImages()
        _bindingSourceImages.DataSource = data
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = _bindingSourceImages
        PictureBox1.DataBindings.Add("Image", _bindingSourceImages, "Photo", True)
    End Sub
    Private Sub AddImageButton_Click(sender As Object, e As EventArgs) Handles AddImageButton.Click
        Dim imageData = File.ReadAllBytes("DeleteCode.png")
        Dim result = PhotoOperations.InsertImage(imageData, "Humor")
        If result = 1 Then
            Dim dt = DirectCast(_bindingSourceImages.DataSource, DataTable)
            dt.Rows.Add(Nothing, imageData, "Humor")
        End If
    End Sub
End Class
