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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContacts = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFromName = New System.Windows.Forms.TextBox()
        Me.txtFromEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Tag = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.txtMandrill = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.prgProcessed = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(646, 570)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(74, 36)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(486, 33)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(46, 35)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(434, 20)
        Me.txtFile.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Step 1: Select file (Column A as email, Column B as first name and Column C as la" & _
    "st name)"
        '
        'lblContacts
        '
        Me.lblContacts.AutoSize = True
        Me.lblContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacts.Location = New System.Drawing.Point(43, 81)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(0, 13)
        Me.lblContacts.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Step 2: Email Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "From Name:"
        '
        'txtFromName
        '
        Me.txtFromName.Location = New System.Drawing.Point(117, 147)
        Me.txtFromName.Name = "txtFromName"
        Me.txtFromName.Size = New System.Drawing.Size(179, 20)
        Me.txtFromName.TabIndex = 7
        '
        'txtFromEmail
        '
        Me.txtFromEmail.Location = New System.Drawing.Point(403, 150)
        Me.txtFromEmail.Name = "txtFromEmail"
        Me.txtFromEmail.Size = New System.Drawing.Size(179, 20)
        Me.txtFromEmail.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From Email:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(117, 189)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(603, 20)
        Me.txtSubject.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Subject:"
        '
        'txtBody
        '
        Me.txtBody.AcceptsReturn = True
        Me.txtBody.Location = New System.Drawing.Point(117, 232)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(603, 261)
        Me.txtBody.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Body:"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(117, 570)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(179, 20)
        Me.txtTag.TabIndex = 15
        '
        'Tag
        '
        Me.Tag.AutoSize = True
        Me.Tag.Location = New System.Drawing.Point(47, 572)
        Me.Tag.Name = "Tag"
        Me.Tag.Size = New System.Drawing.Size(26, 13)
        Me.Tag.TabIndex = 14
        Me.Tag.Text = "Tag"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'btnBreak
        '
        Me.btnBreak.Location = New System.Drawing.Point(117, 499)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(114, 23)
        Me.btnBreak.TabIndex = 16
        Me.btnBreak.Text = "Insert Line Break"
        Me.btnBreak.UseVisualStyleBackColor = True
        '
        'txtMandrill
        '
        Me.txtMandrill.Location = New System.Drawing.Point(403, 570)
        Me.txtMandrill.Name = "txtMandrill"
        Me.txtMandrill.Size = New System.Drawing.Size(179, 20)
        Me.txtMandrill.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Mandrill API Key"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(237, 499)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(114, 23)
        Me.btnFirst.TabIndex = 19
        Me.btnFirst.Text = "Insert First Name"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(357, 499)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(114, 23)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = "Insert Last Name"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prgProcessed, Me.lblProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 655)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(745, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'prgProcessed
        '
        Me.prgProcessed.Name = "prgProcessed"
        Me.prgProcessed.Size = New System.Drawing.Size(550, 16)
        '
        'lblProgress
        '
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 677)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtMandrill)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBreak)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.Tag)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFromEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFromName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblContacts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnSend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EngageMore Blast!"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFromName As System.Windows.Forms.TextBox
    Friend WithEvents txtFromEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents Tag As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnBreak As System.Windows.Forms.Button
    Friend WithEvents txtMandrill As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents prgProcessed As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblProgress As System.Windows.Forms.ToolStripStatusLabel

End Class
