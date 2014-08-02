Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Net
Imports Microsoft.Office.Interop.Excel
Imports System.ComponentModel
Imports System.Threading
Imports Mandrill

Public Class frmMain

    Public lstContact As New List(Of Contact)
    Public Class Contact


        Private _Email As System.String
        Private _First As System.String
        Private _Last As System.String


        Public Property Email() As System.String
            Get
                Return _Email
            End Get
            Set(ByVal value As System.String)
                _Email = value
            End Set
        End Property

        Public Property First() As System.String
            Get
                Return _First
            End Get
            Set(ByVal value As System.String)
                _First = value
            End Set
        End Property

        Public Property Last() As System.String
            Get
                Return _Last
            End Get
            Set(ByVal value As System.String)
                _Last = value
            End Set
        End Property


    End Class
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click


        If String.IsNullOrEmpty(Me.txtFile.Text) Then
            MsgBox("Please select an excel file")
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.txtFromName.Text) Or String.IsNullOrEmpty(Me.txtFromEmail.Text) Or String.IsNullOrEmpty(Me.txtSubject.Text) Or String.IsNullOrEmpty(Me.txtBody.Text) Or String.IsNullOrEmpty(Me.txtTag.Text) Or String.IsNullOrEmpty(Me.txtMandrill.Text) Then
            MsgBox("Please complete all fields")
            Exit Sub
        End If

        'store user seetins
        My.Settings.MandrillAPI = Me.txtMandrill.Text
        My.Settings.FromEmail = Me.txtFromEmail.Text
        My.Settings.FromName = Me.txtFromName.Text

        'loop thriugh each contact
        Try
            For Each c As Contact In lstContact
                Dim api As New MandrillApi(Me.txtMandrill.Text)

                Dim email As New Mandrill.EmailMessage()
                email.auto_text = True
                email.from_email = Me.txtFromEmail.Text
                email.from_name = Me.txtFromName.Text
                'email.AddHeader("Reply-To", replyto)

                email.html = Me.txtBody.Text.Replace("{First}", c.First).Replace("{Last}", c.Last)
                email.important = False
                'Dim metadata As New Metadata()
                'metadata.website = "test.com"
                'message.metadata = metadata
                email.subject = Me.txtSubject.Text

                Dim lstTags As New List(Of String)
                lstTags.Add(Me.txtTag.Text)
                email.tags = lstTags
                email.track_clicks = True
                email.track_opens = True

                Dim lstSendTo As New List(Of EmailAddress)
                lstSendTo.Add(New EmailAddress(c.Email, c.First & " " & c.Last, "to"))
                email.to = lstSendTo

                Dim emailresults As New List(Of Mandrill.EmailResult)
                emailresults = api.SendMessage(email)

                'For Each t As EmailResult In emailresults

                '    If EmailResultStatus.Sent = EmailResultStatus.Sent Then
                '        MsgBox("Emails sent")
                '    Else
                '        MsgBox("Error sending")
                '    End If

                'Next
            Next
            MsgBox("Emails sent")
        Catch ex As Exception
            MsgBox("Error sending:" & ex.Message)
        End Try
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk


        Me.txtFile.Text = Me.OpenFileDialog1.FileName

        'build list
        lstContact.Clear()
        ' Create new Application.
        Dim excel As Application = New Application

        ' Open Excel spreadsheet.
        Dim w As Workbook = excel.Workbooks.Open(Me.txtFile.Text)

        ' Loop over all sheets.
        For i As Integer = 1 To w.Sheets.Count

            ' Get sheet.
            Dim sheet As Worksheet = w.Sheets(i)

            ' Get range.
            Dim r As Range = sheet.UsedRange

            ' Load all cells into 2d array.
            Dim array(,) As Object = r.Value(XlRangeValueDataType.xlRangeValueDefault)

            ' Scan the cells.
            If array IsNot Nothing Then
                Console.WriteLine("Length: {0}", array.Length)

                ' Get bounds of the array.
                Dim bound0 As Integer = array.GetUpperBound(0)
                Dim bound1 As Integer = array.GetUpperBound(1)

                ' Console.WriteLine("Dimension 0: {0}", bound0)
                'Console.WriteLine("Dimension 1: {0}", bound1)

                ' Loop over all elements.
                For j As Integer = 1 To bound0
                    For x As Integer = 1 To bound1
                        If j = 1 Then 'first row
                            If x = 1 Then 'first column
                                Dim s1 As String = array(j, x)
                                If s1 <> "Email" Then
                                    MsgBox("Column A must be named Email")
                                    Exit Sub
                                End If
                            End If
                            If x = 2 Then 'second column
                                Dim s1 As String = array(j, x)
                                If s1 <> "First Name" Then
                                    MsgBox("Column B must be named First Name")
                                    Exit Sub
                                End If
                            End If
                            If x = 3 Then 'thired column
                                Dim s1 As String = array(j, x)
                                If s1 <> "Last Name" Then
                                    MsgBox("Column C must be named Last Name")
                                    Exit Sub
                                End If
                            End If
                        Else 'data rows
                            Dim strEmail, strFirst, strLast As String
                            If x = 1 Then 'first column

                                Dim s1 As String = array(j, x)
                                strEmail = s1
                            End If
                            If x = 2 Then 'sceond column
                                Dim s1 As String = array(j, x)
                                strFirst = s1
                            End If
                            If x = 3 Then 'third column
                                Dim s1 As String = array(j, x)
                                strLast = s1

                                Dim c1 As New Contact
                                c1.Email = IIf(String.IsNullOrEmpty(strEmail) = False, strEmail, vbEmpty)
                                c1.First = IIf(String.IsNullOrEmpty(strFirst) = False, strFirst, vbEmpty)
                                c1.Last = IIf(String.IsNullOrEmpty(strLast) = False, strLast, vbEmpty)
                                lstcontact.Add(c1)
                            End If
                        End If

                        'Console.Write(s1)
                        ' Console.Write(" "c)

                    Next
                    Console.WriteLine()
                Next
            End If
        Next

        ' Close.
        w.Close()


        'update label
        Me.lblContacts.Text = lstcontact.Count & " contacts found"
    End Sub

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click

        txtBody.SelectedText = "<br>"
        Me.txtBody.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'load user settings
        If String.IsNullOrEmpty(My.Settings.MandrillAPI) = False Then Me.txtMandrill.Text = My.Settings.MandrillAPI
        If String.IsNullOrEmpty(My.Settings.FromEmail) = False Then Me.txtFromEmail.Text = My.Settings.FromEmail
        If String.IsNullOrEmpty(My.Settings.FromName) = False Then Me.txtFromName.Text = My.Settings.FromName
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        txtBody.SelectedText = "{First}"
        Me.txtBody.Focus()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        txtBody.SelectedText = "{Last}"
        Me.txtBody.Focus()
    End Sub
End Class
