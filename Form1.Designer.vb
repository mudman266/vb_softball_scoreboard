<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblScore7 = New System.Windows.Forms.Label()
        Me.lblScore6 = New System.Windows.Forms.Label()
        Me.lblScore5 = New System.Windows.Forms.Label()
        Me.lblScore4 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.lblTotalScoreHeader = New System.Windows.Forms.Label()
        Me.lblInning7 = New System.Windows.Forms.Label()
        Me.lblInning5 = New System.Windows.Forms.Label()
        Me.lblInning6 = New System.Windows.Forms.Label()
        Me.lblInning4 = New System.Windows.Forms.Label()
        Me.lblInning3 = New System.Windows.Forms.Label()
        Me.lblInning2 = New System.Windows.Forms.Label()
        Me.lblInning1 = New System.Windows.Forms.Label()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.lstScoreList = New System.Windows.Forms.ListBox()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(0, 26)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(802, 426)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(229, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Softball Scoreboard"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.lblScore7)
        Me.Panel1.Controls.Add(Me.lblScore6)
        Me.Panel1.Controls.Add(Me.lblScore5)
        Me.Panel1.Controls.Add(Me.lblScore4)
        Me.Panel1.Controls.Add(Me.lblScore3)
        Me.Panel1.Controls.Add(Me.lblScore2)
        Me.Panel1.Controls.Add(Me.lblScore1)
        Me.Panel1.Controls.Add(Me.lblTotalScore)
        Me.Panel1.Controls.Add(Me.lblTotalScoreHeader)
        Me.Panel1.Controls.Add(Me.lblInning7)
        Me.Panel1.Controls.Add(Me.lblInning5)
        Me.Panel1.Controls.Add(Me.lblInning6)
        Me.Panel1.Controls.Add(Me.lblInning4)
        Me.Panel1.Controls.Add(Me.lblInning3)
        Me.Panel1.Controls.Add(Me.lblInning2)
        Me.Panel1.Controls.Add(Me.lblInning1)
        Me.Panel1.Location = New System.Drawing.Point(136, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 209)
        Me.Panel1.TabIndex = 3
        '
        'lblScore7
        '
        Me.lblScore7.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore7.Location = New System.Drawing.Point(431, 47)
        Me.lblScore7.Name = "lblScore7"
        Me.lblScore7.Size = New System.Drawing.Size(62, 38)
        Me.lblScore7.TabIndex = 110
        Me.lblScore7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore6
        '
        Me.lblScore6.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore6.Location = New System.Drawing.Point(365, 47)
        Me.lblScore6.Name = "lblScore6"
        Me.lblScore6.Size = New System.Drawing.Size(62, 38)
        Me.lblScore6.TabIndex = 109
        Me.lblScore6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore5
        '
        Me.lblScore5.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore5.Location = New System.Drawing.Point(299, 47)
        Me.lblScore5.Name = "lblScore5"
        Me.lblScore5.Size = New System.Drawing.Size(62, 38)
        Me.lblScore5.TabIndex = 108
        Me.lblScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore4
        '
        Me.lblScore4.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore4.Location = New System.Drawing.Point(233, 47)
        Me.lblScore4.Name = "lblScore4"
        Me.lblScore4.Size = New System.Drawing.Size(62, 38)
        Me.lblScore4.TabIndex = 107
        Me.lblScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore3
        '
        Me.lblScore3.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore3.Location = New System.Drawing.Point(167, 47)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(62, 38)
        Me.lblScore3.TabIndex = 106
        Me.lblScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore2
        '
        Me.lblScore2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(101, 47)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(62, 38)
        Me.lblScore2.TabIndex = 105
        Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore1
        '
        Me.lblScore1.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(35, 47)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(62, 38)
        Me.lblScore1.TabIndex = 104
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalScore
        '
        Me.lblTotalScore.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.Location = New System.Drawing.Point(3, 140)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(522, 43)
        Me.lblTotalScore.TabIndex = 103
        Me.lblTotalScore.Text = "0"
        Me.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalScoreHeader
        '
        Me.lblTotalScoreHeader.AutoSize = True
        Me.lblTotalScoreHeader.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScoreHeader.Location = New System.Drawing.Point(231, 98)
        Me.lblTotalScoreHeader.Name = "lblTotalScoreHeader"
        Me.lblTotalScoreHeader.Size = New System.Drawing.Size(67, 24)
        Me.lblTotalScoreHeader.TabIndex = 102
        Me.lblTotalScoreHeader.Text = "Total"
        '
        'lblInning7
        '
        Me.lblInning7.AutoSize = True
        Me.lblInning7.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning7.Location = New System.Drawing.Point(450, 12)
        Me.lblInning7.Name = "lblInning7"
        Me.lblInning7.Size = New System.Drawing.Size(24, 24)
        Me.lblInning7.TabIndex = 101
        Me.lblInning7.Text = "7"
        '
        'lblInning5
        '
        Me.lblInning5.AutoSize = True
        Me.lblInning5.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning5.Location = New System.Drawing.Point(318, 12)
        Me.lblInning5.Name = "lblInning5"
        Me.lblInning5.Size = New System.Drawing.Size(24, 24)
        Me.lblInning5.TabIndex = 5
        Me.lblInning5.Text = "5"
        '
        'lblInning6
        '
        Me.lblInning6.AutoSize = True
        Me.lblInning6.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning6.Location = New System.Drawing.Point(384, 12)
        Me.lblInning6.Name = "lblInning6"
        Me.lblInning6.Size = New System.Drawing.Size(24, 24)
        Me.lblInning6.TabIndex = 100
        Me.lblInning6.Text = "6"
        '
        'lblInning4
        '
        Me.lblInning4.AutoSize = True
        Me.lblInning4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning4.Location = New System.Drawing.Point(252, 12)
        Me.lblInning4.Name = "lblInning4"
        Me.lblInning4.Size = New System.Drawing.Size(24, 24)
        Me.lblInning4.TabIndex = 3
        Me.lblInning4.Text = "4"
        '
        'lblInning3
        '
        Me.lblInning3.AutoSize = True
        Me.lblInning3.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning3.Location = New System.Drawing.Point(186, 12)
        Me.lblInning3.Name = "lblInning3"
        Me.lblInning3.Size = New System.Drawing.Size(24, 24)
        Me.lblInning3.TabIndex = 2
        Me.lblInning3.Text = "3"
        '
        'lblInning2
        '
        Me.lblInning2.AutoSize = True
        Me.lblInning2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning2.Location = New System.Drawing.Point(120, 12)
        Me.lblInning2.Name = "lblInning2"
        Me.lblInning2.Size = New System.Drawing.Size(24, 24)
        Me.lblInning2.TabIndex = 1
        Me.lblInning2.Text = "2"
        '
        'lblInning1
        '
        Me.lblInning1.AutoSize = True
        Me.lblInning1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInning1.Location = New System.Drawing.Point(54, 12)
        Me.lblInning1.Name = "lblInning1"
        Me.lblInning1.Size = New System.Drawing.Size(24, 24)
        Me.lblInning1.TabIndex = 0
        Me.lblInning1.Text = "1"
        '
        'btnEnterScore
        '
        Me.btnEnterScore.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterScore.Location = New System.Drawing.Point(296, 338)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(208, 51)
        Me.btnEnterScore.TabIndex = 4
        Me.btnEnterScore.Text = "Enter Score"
        Me.btnEnterScore.UseVisualStyleBackColor = True
        '
        'lstScoreList
        '
        Me.lstScoreList.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lstScoreList.FormattingEnabled = True
        Me.lstScoreList.Location = New System.Drawing.Point(670, 98)
        Me.lstScoreList.Name = "lstScoreList"
        Me.lstScoreList.Size = New System.Drawing.Size(120, 212)
        Me.lstScoreList.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstScoreList)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Softball Scoreboard"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblScore7 As Label
    Friend WithEvents lblScore6 As Label
    Friend WithEvents lblScore5 As Label
    Friend WithEvents lblScore4 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents lblTotalScoreHeader As Label
    Friend WithEvents lblInning7 As Label
    Friend WithEvents lblInning5 As Label
    Friend WithEvents lblInning6 As Label
    Friend WithEvents lblInning4 As Label
    Friend WithEvents lblInning3 As Label
    Friend WithEvents lblInning2 As Label
    Friend WithEvents lblInning1 As Label
    Friend WithEvents btnEnterScore As Button
    Friend WithEvents lstScoreList As ListBox
End Class
