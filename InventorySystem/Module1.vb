Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.SecurityException
Module Module1
    Public Function koneksi() As SqlConnection
        Dim supernothing As New SqlConnection
        supernothing = New SqlConnection("server=FAIZUL; database=DB_Inventory; trusted_Connection=true")
        supernothing.Open()
        Return (supernothing)
    End Function
End Module
