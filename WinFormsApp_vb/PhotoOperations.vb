Imports Microsoft.Data.SqlClient
Imports ConfigurationLibrary.Classes.ConfigurationHelper

Module PhotoOperations

    Public Function InsertImage(imageBytes() As Byte, description As String) As Integer
        Dim sql = "    
        INSERT INTO [dbo].[Pictures1]
        (
            [Photo],
            Description
        )
        VALUES
        (
            @ByteArray,
            @Description
        )"

        Using cn = New SqlConnection(ConnectionString())
            Using cmd = New SqlCommand(sql, cn)

                cmd.Parameters.Add("@ByteArray", SqlDbType.VarBinary).Value = imageBytes
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description

                cn.Open()

                Return cmd.ExecuteNonQuery()

            End Using
        End Using
    End Function
    Public Function ReadAllImages() As DataTable
        Dim sql = "SELECT Id,Photo,Description FROM dbo.Pictures1;"
        Dim dt As New DataTable
        Using cn = New SqlConnection(ConnectionString())
            Using cmd = New SqlCommand(Sql, cn)
                cn.Open()
                dt.Load(cmd.ExecuteReader())
                Return dt
            End Using
        End Using
    End Function

End Module
