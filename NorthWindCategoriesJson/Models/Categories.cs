namespace NorthWindCategoriesJson.Models;

public partial class Categories
{
    /// <summary>
    /// Primary key
    /// </summary>
    public int CategoryID { get; set; }

    /// <summary>
    /// Name of a category
    /// </summary>
    public string CategoryName { get; set; }

    /// <summary>
    /// Description of category
    /// </summary>
    public string Description { get; set; }


    public byte[] Photo { get; set; }
    public Bitmap Picture { get; set; }
    // Use the following for DapperOperations
    //public byte[] Picture { get; set; }
}