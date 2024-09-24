Imports System.Data.OleDb
Module Module1
    Public sqlco As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\manage_students\pharmacy\bin\Debug\db\db_manage_student.accdb")
    ' Public sqlco As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db\db_manage_student.accdb")
    Public ds As New DataSet
    Public cmdb As OleDbCommandBuilder
    Public ad As OleDbDataAdapter
    Public cmd As OleDbCommand

End Module
