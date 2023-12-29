using WinFormsApp1.Classes;
using WinFormsApp1.Models;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        // start fresh each time this app runs
        PhotoOperations.TruncateTable();

        var fileList = FileOperations.GetImages();

        // insert records into table using Dapper
        foreach (var name in fileList)
        {
            PhotoOperations.InsertImageDapper(File.ReadAllBytes(name),
                Path.GetFileNameWithoutExtension(name));
        }

        ImagesComboBox.DataSource = PhotoOperations.ReadDapper();
        ImagesComboBox.SelectedIndexChanged += ImagesComboBoxOnSelectedIndexChanged;

        ShowCurrentImage();

    }

    private void ImagesComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
    {
        ShowCurrentImage();
    }

    private void ShowCurrentImage()
    {
        pictureBox1.Image = ((PhotoContainer)ImagesComboBox.SelectedItem).Picture;
    }

    private void InvalidReadButton_Click(object sender, EventArgs e)
    {
        int id = 100;
        var (_, success) = PhotoOperations.ReadImage(id);
        if (!success)
        {
            MessageBox.Show($"No record with an id of {id} exists");
        }
    }

    private void ValidReadButton_Click(object sender, EventArgs e)
    {
        int id = 2;
        var (container, success) = PhotoOperations.ReadImage(id);
        if (success)
        {
            MessageBox.Show($"Description {container.Description}");
        }
    }

    private void CurrentDetailsButton_Click(object sender, EventArgs e)
    {
        var current = ((PhotoContainer)ImagesComboBox.SelectedItem);
        MessageBox.Show($"ID {current.Id} Description {current.Description}");
    }

    private void DapperSetImageButton_Click(object sender, EventArgs e)
    {
        var (success, container) = PhotoOperations.ReadImageDapper(3);
        if (success)
        {
            pictureBox1.Image = container.Picture;
        }
        else
        {
            MessageBox.Show("Nope");
        }
        
    }
}
