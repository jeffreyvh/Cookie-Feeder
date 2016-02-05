Public Class Form1

    ''Load The Required STUFF!!!
    Public cookiex, cookiey As Integer
    Public totallocation As System.Drawing.Point
    Public cookieinsec As Double = 0
    Public autofeedone As Boolean = False
    Public autofeedtwo As Boolean = False
    Public pig As Boolean = False
    Public frog As Boolean = False
    Public currentanimal As String = Nothing
    Public poopbonuscount As Integer = 0

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ''Execute The Save Progress
        Save.SaveProgress()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Execute The Load Progress
        LoadFile.LoadProgress()
    End Sub

    Public Sub grow()
        ''make the animal bigger...
        If Not PictureBox1.Size.Width >= 150 Then
            PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height + 2)
            Dim locationpoint As System.Drawing.Point
            locationpoint.X = PictureBox1.Location.X - 1
            locationpoint.Y = PictureBox1.Location.Y - 1
            PictureBox1.Location = locationpoint
        Else
            PictureBox4.Visible = True
            poopbonuscount += 1

            Dim locationpoint As System.Drawing.Point
            locationpoint.X = PictureBox1.Location.X + 25
            locationpoint.Y = PictureBox1.Location.Y + 25
            PictureBox1.Location = locationpoint
            PictureBox1.Size = New Size(PictureBox1.Size.Width - 50, PictureBox1.Size.Height - 50)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statuscookie.Text = cookieinsec
        cookieinsec = 0
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "Exit Store" Then
            Store.Visible = False
            TabControl1.SelectedTab = TabControl1.TabPages(0)
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Store.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        poopbonuscount -= 1
        If poopbonuscount = 0 Then
            PictureBox4.Visible = False
            Dim score As Integer = ScoreTotal.Text + 10
            ScoreTotal.Text = score
            BonusLabel.Text = "Poop Bonus : + 10"
            BonusLabel.Visible = True
            BonusLabelTimer.Start()
        Else
            Dim score As Integer = ScoreTotal.Text + 10
            ScoreTotal.Text = score
            BonusLabel.Text = "Poop Bonus : + 10"
            BonusLabel.Visible = True
            BonusLabelTimer.Start()
        End If
        
    End Sub

    Private Sub BonusLabelTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusLabelTimer.Tick
        BonusLabel.Visible = False
        BonusLabelTimer.Stop()
    End Sub

    Private Sub AutoFeed1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoFeed1.Tick
        If autofeedone = True Then
            Dim score As Integer = ScoreTotal.Text + 1
            ScoreTotal.Text = score
            cookieinsec += 1

            ''make the animal bigger...
            grow()
        End If
    End Sub

    Private Sub AutoFeedOneBuyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoFeedOneBuyButton.Click
        Dim score As Double = ScoreTotal.Text
        If score >= 50 Then
            Dim scorenew As Double = score - 50
            ScoreTotal.Text = scorenew
            AutoFeedOneBuyButton.Enabled = False
            autofeedone = True
        Else
            MsgBox("Sorry, you don't have enought points yet.")
        End If
    End Sub

    Private Sub AutoFeed2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoFeed2.Tick
        If autofeedtwo = True Then
            Dim score As Integer = ScoreTotal.Text + 2
            ScoreTotal.Text = score
            cookieinsec += 2

            ''make the animal bigger...
            grow()
        End If
    End Sub

    Private Sub AutoFeedTwoBuyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoFeedTwoBuyButton.Click
        Dim score As Double = ScoreTotal.Text
        If score >= 100 Then
            Dim scorenew As Double = score - 100
            ScoreTotal.Text = scorenew
            AutoFeedTwoBuyButton.Enabled = False
            autofeedtwo = True
        Else
            MsgBox("Sorry, you don't have enought points yet.")
        End If
    End Sub

    Private Sub PigBuyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PigBuyButton.Click
        Dim score As Double = ScoreTotal.Text
        If Not PigBuyButton.Text = "USE" Then

            'Buy the pig'
            If score >= 100 Then
                Dim scorenew As Double = score - 100
                ScoreTotal.Text = scorenew
                PigBuyButton.Enabled = False
                PigBuyButton.Text = "USE"
                pig = True
                currentanimal = "Pig"
            Else
                MsgBox("Sorry, you don't have enought points yet.")
            End If

        Else

            'Use the pig instead of all other animals which are bought'
            currentanimal = "Pig"
            PigBuyButton.Enabled = False

            FrogBuyButton.Enabled = True


        End If
    End Sub

    Private Sub FrogBuyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrogBuyButton.Click
        Dim score As Double = ScoreTotal.Text

        If Not FrogBuyButton.Text = "USE" Then

            'Buy the frog'
            If score >= 100 Then
                Dim scorenew As Double = score - 100
                ScoreTotal.Text = scorenew
                FrogBuyButton.Enabled = False
                FrogBuyButton.Text = "USE"
                frog = True
                currentanimal = "Frog"
            Else
                MsgBox("Sorry, you don't have enought points yet.")
            End If

        Else

            'Use the frog instead of all other animals which are bought'
            currentanimal = "Frog"
            FrogBuyButton.Enabled = False

            PigBuyButton.Enabled = True

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim score As Double = ScoreTotal.Text
        ScoreTotal.Text = score + 1
        cookieinsec += 1
        grow()
    End Sub

    Private Sub AnimalTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalTimer.Tick
        If currentanimal = "Pig" Then

            PictureBox1.Image = Feed_It.My.Resources.Animal3

            enableall()

            PigBuyButton.Text = "USE"

            PigBuyButton.Enabled = False



            ElseIf currentanimal = "Frog" Then

                PictureBox1.Image = Feed_It.My.Resources.Animal2

                enableall()

            FrogBuyButton.Text = "USE"

                FrogBuyButton.Enabled = False

            ElseIf currentanimal = Nothing Then

                PictureBox1.Image = My.Resources.Animal1

            End If
    End Sub

    Public Sub enableall()

        If pig = True Then

            PigBuyButton.Enabled = True

            PigBuyButton.Text = "USE"

        Else

            PigBuyButton.Enabled = True

            PigBuyButton.Text = "BUY : 100"

        End If

        If frog = True Then

            FrogBuyButton.Enabled = True

            FrogBuyButton.Text = "USE"

        Else

            FrogBuyButton.Enabled = True

            FrogBuyButton.Text = "BUY : 100"

        End If

    End Sub
End Class
