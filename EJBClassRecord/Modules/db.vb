﻿Module db

    Public Function myconn() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\kccgrades.mdb")
    End Function

End Module
