Public Class Form1

    Dim cookiex, cookiey As Integer
    Dim totallocation As System.Drawing.Point
    Dim cookieinsec As Double = 0

    Dim autofeedone As Boolean = False

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim storeloc As System.Drawing.Point
        storeloc.X = 12
        storeloc.Y = 12
        Store.Location = storeloc
        Dim title As String = Game_Dev.My.Application.Info.ProductName.ToString
        Me.Text = title
        Timer1.Start()
        AutoFeed1.Start()

        ''here comes the savedata load process




        '' Load the savedata in the Game
        If PictureBox2.BackgroundImage.ToString = Game_Dev.My.Resources.Cookie1.ToString Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        cookiex = PictureBox2.Location.X

        ''neccessary
        cookiey = Control.MousePosition.Y - PictureBox2.Location.Y
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            totallocation.X = cookiex

            totallocation.Y = Control.MousePosition.Y - Me.Top
            PictureBox2.Location = totallocation
        End If

        ''Check for the Cookie to reach 50px difference
        If PictureBox2.Location.Y <= 397 - 50 Then
            PictureBox2.Enabled = False
            Dim locationdef As System.Drawing.Point
            locationdef.Y = 397
            locationdef.X = 175
            PictureBox2.Location = locationdef
            Dim score As Integer = ScoreTotal.Text + 1
            ScoreTotal.Text = score
            cookieinsec += 1
            PictureBox2.Enabled = True

            ''make the animal bigger...
            If Not PictureBox1.Size.Width >= 150 Then
                PictureBox1.Size = New Size(PictureBox1.Size.Width + 2, PictureBox1.Size.Height + 2)
                Dim locationpoint As System.Drawing.Point
                locationpoint.X = PictureBox1.Location.X - 1
                locationpoint.Y = PictureBox1.Location.Y - 1
                PictureBox1.Location = locationpoint
            Else
                PictureBox4.Visible = True
                Dim locationpoint As System.Drawing.Point
                locationpoint.X = PictureBox1.Location.X + 25
                locationpoint.Y = PictureBox1.Location.Y + 25
                PictureBox1.Location = locationpoint
                PictureBox1.Size = New Size(PictureBox1.Size.Width - 50, PictureBox1.Size.Height - 50)
            End If
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        Dim locationdef As System.Drawing.Point
        locationdef.Y = 397
        locationdef.X = 175
        PictureBox2.Location = locationdef
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
        PictureBox4.Visible = False
        Dim score As Integer = ScoreTotal.Text + 10
        ScoreTotal.Text = score
        BonusLabel.Text = "Poop Bonus : + 10"
        BonusLabel.Visible = True
        BonusLabelTimer.Start()
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
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score As Double = ScoreTotal.Text
        If score >= 49 Then
            Dim scorenew As Double = score - 50
            ScoreTotal.Text = scorenew
            Button1.Enabled = False
            autofeedone = True
        Else
            MsgBox("Sorry, you don't have enought points yet.")
        End If
    End Sub

    Public Sub save()
        Dim scorefile As String = Application.StartupPath.ToString & "\SaveData\score.dat"
    End Sub
End Class
