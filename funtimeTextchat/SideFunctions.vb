Imports System.IO

Module SideFunctions
    Friend Function errorControl(ex As String)
        MsgBox(ex, Title:="Error Information")
    End Function

    Friend Function checkDir(startpath)
        checkDo(startpath, "downloads")
        checkDo(startpath, "InternetRooms")
        checkDo(startpath, "LocalRooms")
        checkDo(startpath, "rooms")
        checkDo(startpath, "tempFiles")
        If Directory.Exists(startpath + "/testingItems") Then
        Else
            Directory.CreateDirectory(startpath + "/testingItems")
            Dim sw As StreamWriter = New StreamWriter(startpath.ToString + "/testingItems/verify.txt")
            sw.Write("testing")
            sw.Close()
        End If
    End Function

    Friend Function checkDo(startpath, dir)
        If (Directory.Exists(startpath + "/" + dir)) Then
            'Exists
        Else
            Directory.CreateDirectory(startpath + "/" + dir)
        End If
    End Function
End Module
