Public Class Dashboard_Form

    Private Sub New_Input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles New_Input.Click
        New_Sample.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Login_Form.Show()
        Me.Hide()
    End Sub

End Class