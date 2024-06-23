using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.Data.SqlClient;
using WinFormsApp1.Models;

using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace WinFormsApp1.Classes;

internal class PhotoOperations
{
    public static int InsertImage(byte[] imageBytes, string description)
    {
        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(SqlStatements.InsertImage, cn);
        
        cmd.Parameters.Add("@ByteArray", SqlDbType.VarBinary).Value = imageBytes;
        cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;

        cn.Open();

        return cmd.ExecuteNonQuery();
    }

    public static async Task<int> InsertImageDapper(byte[] imageBytes, string description)
    {
        await using var cn = new SqlConnection(ConnectionString());
        return await cn.ExecuteAsync(SqlStatements.InsertImage, new { ByteArray = imageBytes, Description = description});
    }

    /// <summary>
    /// Return one record by primary key
    /// </summary>
    /// <param name="identifier">Existing primary key</param>
    public static (PhotoContainer, bool) ReadImage(int identifier)
    {
        PhotoContainer photoContainer = new() { Id = identifier };

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(SqlStatements.SelectImageByIdentifier, cn);

        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
        
        cn.Open();

        var reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            reader.Read();

            photoContainer.Description = reader.GetString(2);
            photoContainer.Picture = ((byte[])reader[1]).BytesToImage();

            return (photoContainer, true);
        }
        else
        {
            return (photoContainer, false);
        }
        
    }

    public static (bool success, PhotoContainer) ReadImageDapper(int identifier)
    {
        using var cn = new SqlConnection(ConnectionString());
        var container =  cn.QueryFirstOrDefault<PhotoContainer>(SqlStatements.SelectImageByIdentifier, new {id = identifier});
        if (container is not null)
        {
            container.Picture = container.Photo.BytesToImage();

            return (true, container);
        }

        return (false, null);
    }

    public static async Task<List<PhotoContainer>> ReadDapper()
    {
        await using var cn = new SqlConnection(ConnectionString());
        var list = await cn.QueryAsync<PhotoContainer>(SqlStatements.ReadAllImages);

        foreach (var container in list)
        {
            container.Picture = container.Photo.BytesToImage();
        }
        return list.AsList();
    }

    public static async Task<List<PhotoContainer>> ReadDapper1()
    {
        await using var cn = new SqlConnection(ConnectionString());
        return  (await cn.QueryAsync<PhotoContainer>(SqlStatements.ReadAllImages)).AsList();
    }



    /// <summary>
    /// Read all records from the Picture1 table into our container
    /// </summary>
    public static List<PhotoContainer> Read()
    {

        var list = new List<PhotoContainer>();

        using var cn = new SqlConnection(ConnectionString());
        using var cmd = new SqlCommand(SqlStatements.ReadAllImages, cn);

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
    public static async Task TruncateTableAsync()
    {
        var sql = "TRUNCATE TABLE dbo.Pictures1;";

        await using var cn = new SqlConnection(ConnectionString());
        await using var cmd = new SqlCommand(sql, cn);

        cn.Open();
        await cmd.ExecuteNonQueryAsync();
    }

}