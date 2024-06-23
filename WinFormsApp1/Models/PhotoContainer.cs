using WinFormsApp1.Classes;

namespace WinFormsApp1.Models;

public class PhotoContainer
{
    public int Id { get; set; }
    public Image Image => Photo.BytesToImage();
    public Image Picture { get; set; }
    public byte[] Photo { get; set; }
    public string Description { get; set; }
    public override string ToString() => Description;
}