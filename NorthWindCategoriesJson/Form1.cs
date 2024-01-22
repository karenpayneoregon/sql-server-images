using System.ComponentModel;
using System.Text.Json;
using NorthWindCategoriesJson.Classes;
using NorthWindCategoriesJson.Models;

namespace NorthWindCategoriesJson;

public partial class Form1 : Form
{
    private BindingSource _bindingSource = new BindingSource();
    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {

        //DapperOperations operations = new DapperOperations();
        //operations.UpdateImage();

        List<Categories> list = JsonSerializer.Deserialize<List<Categories>>(JsonStatements.CategoriesData);

        foreach (var cat in list)
        {
            cat.Picture = cat.Photo.ByteToImage();
        }

        _bindingSource.DataSource = list;
        
        coreBindingNavigator1.BindingSource = _bindingSource;
        pictureBox1.DataBindings.Add("Image", _bindingSource, nameof(Categories.Picture));

    }

}