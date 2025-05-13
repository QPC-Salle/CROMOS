Imports Microsoft.VisualBasic
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Class1
    Public SQLConn As New SqlConnection With {
        .ConnectionString = "Server=localhost/127.0.0.1 ;
        Database=cromos ;
        User Id= root@localhsot;
        Password= ;"
    }
    Public SQLCmd As New SqlCommand

    Public Function HasConnection() As Boolean
        Try
            SQLConn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            SQLConn.Close()
        End Try
    End Function

End Class
