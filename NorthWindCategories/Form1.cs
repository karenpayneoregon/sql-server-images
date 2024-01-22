
using System.Text.Json;
using NorthWindCategories.Models;

namespace NorthWindCategories;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        var bytes = File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NorthImage", "Beverages..png"));
        using var context = new Context();
        var cat = context.Categories.FirstOrDefault(x => x.CategoryID == 1);
        cat.Photo = bytes;
        var result = context.SaveChanges();
    } // set breakpoint to validate

    private void SerializeButton_Click(object sender, EventArgs e)
    {
        var fileName = "Categories.json";
        using var context = new Context();
        var list = context.Categories.ToList();
        File.WriteAllText(fileName, JsonSerializer.Serialize(list,
            new JsonSerializerOptions { WriteIndented = true }));
    }
}
