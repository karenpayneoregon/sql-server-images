using System.Data;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
namespace WinFormsApp1.Classes;

internal class PhotoOperations
{
    public static int InsertImage(byte[] imageBytes, string description)
    {
        var sql = 
            """
                INSERT INTO [dbo].[Pictures1] 
                    (
                        [Photo], 
                        Description
                    ) 
                VALUES 
                (
                    @ByteArray, 
                    @Description
                )
            """;

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(sql, cn);
        
        cmd.Parameters.Add("@ByteArray", SqlDbType.VarBinary).Value = imageBytes;
        cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;

        cn.Open();

        return cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Return one record by primary key
    /// </summary>
    /// <param name="identifier">Existing primary key</param>
    public static (PhotoContainer, bool) ReadImage(int identifier)
    {
        PhotoContainer photoContainer = new() { Id = identifier };

        var sql = 
            """
                SELECT 
                    id, 
                    Photo,
                    Description
                FROM 
                    dbo.Pictures1 
                WHERE 
                    dbo.Pictures1.id = @id;
            """;

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(sql, cn);

        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
        
        cn.Open();

        var reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            reader.Read();

            photoContainer.Description = reader.GetString(2);
            var imageData = (byte[])reader[1];
            using (var ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);
                photoContainer.Picture = Image.FromStream(ms, true);
            }

            return (photoContainer, true);
        }
        else
        {
            return (photoContainer, false);
        }
        
    }

    /// <summary>
    /// Read all records from the Picture1 table into our container
    /// </summary>
    public static List<PhotoContainer> Read()
    {
        var sql = 
            """
                SELECT 
                    Id,
                    Photo,
                    [Description] 
                FROM 
                    dbo.Pictures1
            """;

        var list = new List<PhotoContainer>();

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(sql, cn);

        cn.Open();
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            PhotoContainer container = new ()
            {
                Id = reader.GetInt32(0),
                Description = reader.GetString(2)
            };

            var imageData = (byte[])reader[1];

            using (var ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);
                container.Picture = Image.FromStream(ms, true);
            }

            list.Add(container);
        }

        return list;
    }

    /// <summary>
    /// Provides a reset so that the table does not grow while learning
    /// </summary>
    public static void TruncateTable()
    {
        var sql = "TRUNCATE TABLE dbo.Pictures1;";

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(sql, cn);

        cn.Open();
        cmd.ExecuteNonQuery();
    }

}