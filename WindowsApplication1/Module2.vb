Imports System.Data.SqlClient
Module Module2


    Dim cn As New SqlConnection("data source =DESKTOP-GVQOKQT\SQLEXPRESS ; initial catalog = GestionCabinetMedicale ; integrated security = true ")
    Dim drP As SqlDataReader
    Dim cmd As SqlCommand
    Dim t As DataTable
End Module
