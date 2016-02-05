Public Class LoadFile

    Public Sub LoadProgress()
        Dim storeloc As System.Drawing.Point
        storeloc.X = 12
        storeloc.Y = 12
        Form1.Store.Location = storeloc
        Dim title As String = Feed_It.My.Application.Info.ProductName.ToString
        Me.Text = title
        Form1.Timer1.Start()
        Form1.AutoFeed1.Start()
        Form1.AutoFeed2.Start()
        Form1.AnimalTimer.Start()

        '' Data Folder...
        Dim datafolder As String = Application.StartupPath.ToString & "\SaveData\"


        ''Check if the folder exist, if not. Don't load.
        If My.Computer.FileSystem.DirectoryExists(datafolder) Then


            ''Data Loading...
            Dim scorefile As String = "score.dat"
            If System.IO.File.Exists(datafolder & scorefile) Then
                Form1.ScoreTotal.Text = My.Computer.FileSystem.ReadAllText(datafolder & scorefile).ToString()
            End If

            Dim autofeedonefile As String = "autofeedone.dat"
            If System.IO.File.Exists(datafolder & autofeedonefile) Then
                If My.Computer.FileSystem.ReadAllText(datafolder & autofeedonefile) = "True" Then
                    Form1.autofeedone = True
                    Form1.AutoFeedOneBuyButton.Enabled = False
                End If
            End If

            Dim autofeedtwofile As String = "autofeedtwo.dat"
            If System.IO.File.Exists(datafolder & autofeedtwofile) Then
                If My.Computer.FileSystem.ReadAllText(datafolder & autofeedtwofile) = "True" Then
                    Form1.autofeedtwo = True
                    Form1.AutoFeedTwoBuyButton.Enabled = False
                End If
            End If

            Dim pigfile As String = "pig.dat"
            If System.IO.File.Exists(datafolder & pigfile) Then
                If My.Computer.FileSystem.ReadAllText(datafolder & pigfile) = "True" Then
                    Form1.pig = True
                End If
            End If

            Dim frogfile As String = "frog.dat"
            If System.IO.File.Exists(datafolder & frogfile) Then
                If My.Computer.FileSystem.ReadAllText(datafolder & frogfile) = "True" Then
                    Form1.frog = True
                End If
            End If

            Dim currentanimalfile As String = "currentanimal.dat"
            If System.IO.File.Exists(datafolder & currentanimalfile) Then
                If My.Computer.FileSystem.ReadAllText(datafolder & currentanimalfile) = "Pig" Then
                    Form1.currentanimal = "Pig"
                ElseIf My.Computer.FileSystem.ReadAllText(datafolder & currentanimalfile) = "Frog" Then
                    Form1.currentanimal = "Frog"
                Else
                    Form1.currentanimal = Nothing
                End If
            End If

        End If
    End Sub
End Class