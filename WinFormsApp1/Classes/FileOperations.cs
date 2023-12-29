namespace WinFormsApp1.Classes;
internal class FileOperations
{
    /// <summary>
    /// Get images from the Image folder under the application folder
    /// </summary>
    /// <returns>
    /// List of files with their path
    /// </returns>
    public static List<string> GetImages() 
        => Directory.GetFiles(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images"))
            .ToList();


    public static async Task<List<string>> GetImagesAsync(string path)
        => await Task.Run(()
            => Task.FromResult(Directory.EnumerateFiles(path).ToList()));
}
