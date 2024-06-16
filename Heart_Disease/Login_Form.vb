Public Class Login_Form

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter Login ID", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please Enter Password", MsgBoxStyle.Exclamation, "MESSAGE")
            Exit Sub
        End If

        If (TextBox1.Text) = "admin" And (TextBox2.Text) = "000" Then
            MsgBox("WELCOME TO HEART DISEASE PREDICTION SYSTEM", MsgBoxStyle.Information, "MESSAGE")
            Dashboard_Form.Show()
            Me.Hide()
        Else
            If (TextBox1.Text) <> "admin" Then
                MsgBox("Invalid Login ID", MsgBoxStyle.Critical, "MESSAGE")
                TextBox1.Text = ""
            End If
            If TextBox2.Text <> "000" Then
                MsgBox("Invalid Password", MsgBoxStyle.Critical, "MESSAGE")
                TextBox2.Text = ""
            End If
        End If
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class
