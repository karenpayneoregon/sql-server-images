namespace WinFormsApp1.Models;

public class PhotoContainer
{
    public int Id { get; set; }
    public Image Picture { get; set; }
    public string Description { get; set; }
    public override string ToString() => Description;
}