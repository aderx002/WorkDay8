Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text
        Dim n As Integer = st.Length
        Dim start As Integer
        Dim result As String = ""

        For start = (n - 1) To 0 Step -1
            result &= st.Chars(start)
        Next

        txtOutput.Text = result
    End Sub
End Class
