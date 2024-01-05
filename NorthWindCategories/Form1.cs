
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
}
