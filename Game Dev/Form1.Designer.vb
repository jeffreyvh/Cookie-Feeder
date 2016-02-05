<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statuscookie = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BonusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ScoreTotal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Store = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.FrogBuyButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PigBuyButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AutoFeedTwoBuyButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AutoFeedOneBuyButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.Panel()
        Me.BonusLabelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AutoFeed1 = New System.Windows.Forms.Timer(Me.components)
        Me.AutoFeed2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AnimalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Store.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statuscookie, Me.BonusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 450)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(394, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel1.Text = "Cookie per second :"
        '
        'statuscookie
        '
        Me.statuscookie.Name = "statuscookie"
        Me.statuscookie.Size = New System.Drawing.Size(13, 17)
        Me.statuscookie.Text = "0"
        '
        'BonusLabel
        '
        Me.BonusLabel.Name = "BonusLabel"
        Me.BonusLabel.Size = New System.Drawing.Size(49, 17)
        Me.BonusLabel.Text = "Bonus..."
        Me.BonusLabel.Visible = False
        '
        'ScoreTotal
        '
        Me.ScoreTotal.AutoSize = True
        Me.ScoreTotal.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScoreTotal.Image = Global.Feed_It.My.Resources.Resources.Grass1
        Me.ScoreTotal.Location = New System.Drawing.Point(146, 18)
        Me.ScoreTotal.Name = "ScoreTotal"
        Me.ScoreTotal.Size = New System.Drawing.Size(43, 51)
        Me.ScoreTotal.TabIndex = 4
        Me.ScoreTotal.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Store
        '
        Me.Store.Controls.Add(Me.GroupBox1)
        Me.Store.Location = New System.Drawing.Point(397, 13)
        Me.Store.Name = "Store"
        Me.Store.Size = New System.Drawing.Size(370, 438)
        Me.Store.TabIndex = 6
        Me.Store.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STORE"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(358, 407)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.PictureBox5)
        Me.TabPage1.Controls.Add(Me.FrogBuyButton)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.PigBuyButton)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(350, 381)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Animals"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Feed_It.My.Resources.Resources.Animal2
        Me.PictureBox6.Location = New System.Drawing.Point(6, 49)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'FrogBuyButton
        '
        Me.FrogBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FrogBuyButton.Location = New System.Drawing.Point(261, 51)
        Me.FrogBuyButton.Name = "FrogBuyButton"
        Me.FrogBuyButton.Size = New System.Drawing.Size(75, 23)
        Me.FrogBuyButton.TabIndex = 11
        Me.FrogBuyButton.Text = "BUY : 100"
        Me.FrogBuyButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-76, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(566, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "=============================================================="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "FROG"
        '
        'PigBuyButton
        '
        Me.PigBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PigBuyButton.Location = New System.Drawing.Point(261, 11)
        Me.PigBuyButton.Name = "PigBuyButton"
        Me.PigBuyButton.Size = New System.Drawing.Size(75, 23)
        Me.PigBuyButton.TabIndex = 8
        Me.PigBuyButton.Text = "BUY : 100"
        Me.PigBuyButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-76, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(566, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "=============================================================="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "PIG"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(350, 381)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cookies"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AutoFeedTwoBuyButton)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.AutoFeedOneBuyButton)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(350, 381)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Engine"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AutoFeedTwoBuyButton
        '
        Me.AutoFeedTwoBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoFeedTwoBuyButton.Location = New System.Drawing.Point(261, 51)
        Me.AutoFeedTwoBuyButton.Name = "AutoFeedTwoBuyButton"
        Me.AutoFeedTwoBuyButton.Size = New System.Drawing.Size(75, 23)
        Me.AutoFeedTwoBuyButton.TabIndex = 5
        Me.AutoFeedTwoBuyButton.Text = "BUY : 100"
        Me.AutoFeedTwoBuyButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-76, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(566, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "=============================================================="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AUTO FEED : 2 sec"
        '
        'AutoFeedOneBuyButton
        '
        Me.AutoFeedOneBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutoFeedOneBuyButton.Location = New System.Drawing.Point(261, 11)
        Me.AutoFeedOneBuyButton.Name = "AutoFeedOneBuyButton"
        Me.AutoFeedOneBuyButton.Size = New System.Drawing.Size(75, 23)
        Me.AutoFeedOneBuyButton.TabIndex = 2
        Me.AutoFeedOneBuyButton.Text = "BUY : 50"
        Me.AutoFeedOneBuyButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-76, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(566, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "=============================================================="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTO FEED : 1 sec"
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(350, 381)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Exit Store"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Feed_It.My.Resources.Resources.Cookie1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(175, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 3
        '
        'BonusLabelTimer
        '
        Me.BonusLabelTimer.Interval = 2000
        '
        'AutoFeed1
        '
        Me.AutoFeed1.Interval = 1000
        '
        'AutoFeed2
        '
        Me.AutoFeed2.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Feed_It.My.Resources.Resources.Grass1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.Feed_It.My.Resources.Resources.Store_Button
        Me.PictureBox3.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Feed_It.My.Resources.Resources.Animal1
        Me.PictureBox1.Location = New System.Drawing.Point(151, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Feed_It.My.Resources.Resources.Grass1
        Me.PictureBox4.Image = Global.Feed_It.My.Resources.Resources.poop
        Me.PictureBox4.Location = New System.Drawing.Point(175, 201)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'AnimalTimer
        '
        Me.AnimalTimer.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Feed_It.My.Resources.Resources.Grass1
        Me.ClientSize = New System.Drawing.Size(394, 472)
        Me.Controls.Add(Me.Store)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ScoreTotal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Store.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statuscookie As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.Panel
    Friend WithEvents ScoreTotal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Store As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BonusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BonusLabelTimer As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents AutoFeedOneBuyButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents AutoFeed1 As System.Windows.Forms.Timer
    Friend WithEvents AutoFeed2 As System.Windows.Forms.Timer
    Friend WithEvents AutoFeedTwoBuyButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents FrogBuyButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PigBuyButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AnimalTimer As System.Windows.Forms.Timer

End Class
