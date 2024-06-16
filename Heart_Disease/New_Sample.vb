Imports System.Data.OleDb

Public Class New_Sample
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HeartDisease.accdb")
    Dim cmd As OleDbCommand, cmd1 As OleDbCommand, cmd2 As OleDbCommand
    Dim dr As OleDbDataReader, dr1 As OleDbDataReader
    Dim result As String

    Sub Text_Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
    End Sub

    Private Sub New_Sample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        New_Pid()
        Label18.Text = "Result"
    End Sub

    Sub New_Pid()
        Dim c As Integer = 0
        conn.Open()
        cmd = New OleDbCommand("select IIF(IsNull(Pid),'1',Pid) from heart_tb", conn)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            c = Convert.ToInt32(dr(0).ToString())
        End While
        dr.Close()
        conn.Close()
        c = c + 1
        TextBox1.Text = c.ToString
        TextBox2.Text = Date.Now.Date
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Text_Clear()
        Label18.Text = "Result:"
        Label18.BackColor = Color.Transparent
        New_Pid()
    End Sub

    Private Sub Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter  Patient ID", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please Enter Sample Date", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("Please Enter Patient Name", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MsgBox("Please Enter Age", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox5.Text = "" Then
            MsgBox("Please Enter Weight", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox6.Text = "" Then
            MsgBox("Please Enter Chest Pain", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox7.Text = "" Then
            MsgBox("Please Enter Resting Bp", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox8.Text = "" Then
            MsgBox("Please Enter Cholesterol", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox9.Text = "" Then
            MsgBox("Please Enter Fasting Bp", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox10.Text = "" Then
            MsgBox("Please Enter Resting ECG", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox11.Text = "" Then
            MsgBox("Please Enter MAX HR", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox12.Text = "" Then
            MsgBox("Please Enter Exercise Angina", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox13.Text = "" Then
            MsgBox("Please Enter Old Peak", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox14.Text = "" Then
            MsgBox("Please Enter ST Slope", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If

        

        conn.Open()
        cmd = New OleDbCommand("insert into heart_tb values(@Pid, @sdate,@pname,@age,@gender,@weight,@Chest,@Resting_Bp,@Cholesterol,@Fasting_Bp,@Resting_ECG,@MAX_HR,@Exercise_Angina,@Old_Peak,@ST_Slope)", conn)
        cmd.Parameters.Add(New OleDbParameter("@Pid", TextBox1.Text))
        cmd.Parameters.Add(New OleDbParameter("@sdate", TextBox2.Text))
        cmd.Parameters.Add(New OleDbParameter("@pname", TextBox3.Text))
        cmd.Parameters.Add(New OleDbParameter("@age", TextBox4.Text))
        cmd.Parameters.Add(New OleDbParameter("@gender", ComboBox1.Text))
        cmd.Parameters.Add(New OleDbParameter("@weight", TextBox5.Text))
        cmd.Parameters.Add(New OleDbParameter("@Chest", TextBox6.Text))
        cmd.Parameters.Add(New OleDbParameter("@Resting_Bp", TextBox7.Text))
        cmd.Parameters.Add(New OleDbParameter("@Cholesterol", TextBox8.Text))
        cmd.Parameters.Add(New OleDbParameter("@Fasting_Bp", TextBox9.Text))
        cmd.Parameters.Add(New OleDbParameter("@Resting_ECG", TextBox10.Text))
        cmd.Parameters.Add(New OleDbParameter("@MAX_HR", TextBox11.Text))
        cmd.Parameters.Add(New OleDbParameter("@Exercise_Angina", TextBox12.Text))
        cmd.Parameters.Add(New OleDbParameter("@Old_Peak", TextBox13.Text))
        cmd.Parameters.Add(New OleDbParameter("@ST_Slope", TextBox14.Text))

        If (cmd.ExecuteNonQuery() > 0) Then
            pid = TextBox1.Text
            MsgBox("Record Stored Successfully", MsgBoxStyle.Information, "Message")

            Dim flag As Integer
            If (Convert.ToInt32(TextBox7.Text) >= 80 And Convert.ToInt32(TextBox7.Text) <= 120) Then
                flag = 0
            Else
                flag = 1
            End If
            If (Convert.ToInt32(TextBox8.Text) <= 200) Then
                flag = 0
            Else
                flag = 1
            End If
            If (Convert.ToInt32(TextBox11.Text) >= 60 And Convert.ToInt32(TextBox11.Text) <= 100) Then
                flag = 0
            Else
                flag = 1
            End If
            If (TextBox14.Text.Equals("Normal")) Then
                flag = 0
            Else
                flag = 1
            End If

            If (flag = 0) Then
                Label18.Text = "Result: 0"
                Label18.BackColor = Color.Green
            Else
                Label18.Text = "Result: 1"
                Label18.BackColor = Color.Red
            End If

            Text_Clear()
            conn.Close()
        Else
            MsgBox("Sry! Error.. Try Again", MsgBoxStyle.Critical, "Message")
            conn.Close()
        End If
    End Sub

End Class