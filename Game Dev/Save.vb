Public Class Save

    Public Sub SaveProgress()
        '' Data Folder...
        Dim datafolder As String = Application.StartupPath.ToString & "\SaveData\"
        If Not My.Computer.FileSystem.DirectoryExists(datafolder) Then
            My.Computer.FileSystem.CreateDirectory(datafolder)
        End If

        ''Score File Saving...
        Dim scorefile As String = "score.dat"
        If System.IO.File.Exists(datafolder & scorefile) Then
            System.IO.File.Delete(datafolder & scorefile)
        End If
        Dim scorewriter As System.IO.StreamWriter

        scorewriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & scorefile, True)
        scorewriter.Write(Form1.ScoreTotal.Text)
        scorewriter.Close()

        ''AutoFeedOne File Saving...
        Dim autofeedonefile As String = "autofeedone.dat"
        If System.IO.File.Exists(datafolder & autofeedonefile) Then
            System.IO.File.Delete(datafolder & autofeedonefile)
        End If
        Dim autofeedonewriter As System.IO.StreamWriter

        autofeedonewriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & autofeedonefile, True)
        autofeedonewriter.Write(Form1.autofeedone.ToString)
        autofeedonewriter.Close()

        ''AutoFeedTwo File Saving...
        Dim autofeedtwofile As String = "autofeedtwo.dat"
        If System.IO.File.Exists(datafolder & autofeedtwofile) Then
            System.IO.File.Delete(datafolder & autofeedtwofile)
        End If
        Dim autofeedtwowriter As System.IO.StreamWriter

        autofeedtwowriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & autofeedtwofile, True)
        autofeedtwowriter.Write(Form1.autofeedtwo.ToString)
        autofeedtwowriter.Close()

        ''Current Animal File Saving...
        Dim currentanimalfile As String = "currentanimal.dat"
        If System.IO.File.Exists(datafolder & currentanimalfile) Then
            System.IO.File.Delete(datafolder & currentanimalfile)
        End If
        Dim currentanimalwriter As System.IO.StreamWriter

        currentanimalwriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & currentanimalfile, True)
        currentanimalwriter.Write(Form1.currentanimal.ToString)
        currentanimalwriter.Close()

        ''Pig File Saving...
        Dim pigfile As String = "pig.dat"
        If System.IO.File.Exists(datafolder & pigfile) Then
            System.IO.File.Delete(datafolder & pigfile)
        End If
        Dim pigwriter As System.IO.StreamWriter

        pigwriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & pigfile, True)
        pigwriter.Write(Form1.pig.ToString)
        pigwriter.Close()

        ''Frog File Saving...
        Dim frogfile As String = "frog.dat"
        If System.IO.File.Exists(datafolder & frogfile) Then
            System.IO.File.Delete(datafolder & frogfile)
        End If
        Dim frogwriter As System.IO.StreamWriter

        frogwriter = My.Computer.FileSystem.OpenTextFileWriter(datafolder & frogfile, True)
        frogwriter.Write(Form1.frog.ToString)
        frogwriter.Close()
    End Sub
End Class