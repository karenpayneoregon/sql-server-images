using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace NorthWindCategoriesJson.Classes;

/// <summary>
/// All versions of NorthWind do not have category for Wine, id 9,
/// this code updates the wine category Picture to include an image for wine.
///
/// For this to work, see notes in Categories model.
/// </summary>
internal class DapperOperations
{
    private readonly IDbConnection _cn 
        = new SqlConnection(
            """
            Data Source=.\sqlexpress;Initial Catalog=NorthWind2024;
            Integrated Security=True;Encrypt=False
            """);

    public void UpdateImage()
    {
        var imageBytes = File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NorthImage", "Wine.png"));
        var statement =
            """
            UPDATE dbo.Categories 
            SET Picture = @ByteArray  
            WHERE CategoryID = 9
            """;
        var parameters = new { ByteArray = imageBytes };
        _cn.Execute(statement, parameters);
    }
}
