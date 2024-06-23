using System.ComponentModel;
using WinFormsApp1.Classes;
using WinFormsApp1.Models;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private BindingList<PhotoContainer> PhotoContainers;
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private async void Form1_Shown(object sender, EventArgs e)
    {
        string[] include = ["**/*.png"];
        SuspendLayout();
        try
        {
            // start fresh each time this app runs
            await PhotoOperations.TruncateTableAsync();

            var fileList = await FileOperations.GetImagesAsync("Images");

            // insert records into table using Dapper
            foreach (var name in fileList)
            {
                await PhotoOperations.InsertImageDapper(await File.ReadAllBytesAsync(name),
                    Path.GetFileNameWithoutExtension(name));
            }

            PhotoContainers = new BindingList<PhotoContainer>(await PhotoOperations.ReadDapper1());
            ImagesComboBox.DataSource = PhotoContainers;
            ImagesComboBox.SelectedIndexChanged += ImagesComboBoxOnSelectedIndexChanged;
        }
        finally
        {
            ResumeLayout();
        }

        ShowCurrentImage();

    }

    private void ImagesComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
    {
        ShowCurrentImage();
    }

    private void ShowCurrentImage()
    {
        //CurrentImageBox.Image = ((PhotoContainer)ImagesComboBox.SelectedItem).Photo.BytesToImage();
        CurrentImageBox.Image = PhotoContainers[ImagesComboBox.SelectedIndex].Image;
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
        //MessageBox.Show($"ID {current.Id} Description {current.Description}");
        CurrentImageBox.Image = current.Picture;
    }

    private void DapperSetImageButton_Click(object sender, EventArgs e)
    {
        var (success, container) = PhotoOperations.ReadImageDapper(3);
        if (success)
        {
            CurrentImageBox.Image = container.Picture;
        }
        else
        {
            MessageBox.Show("Nope");
        }
        
    }
}
