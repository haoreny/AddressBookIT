Public Class PhoneEntry
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Check for text'
        'Check number is 10 digits'
        'Check number is present in database'
        'If number is present show entry'
        'If not present ask to add to databse or exit'
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchNumberBtn.Click
        Struserinput = TxtFriend.Text

        If Struserinput = LstPeople.SelectedItem Then

            MessageBox.Show(strPhonenumber(LstPeople.SelectedIndex))
        Else
            ' if number is not listed send error message
            MessageBox.Show("That entry is not in the list.")
        End If
    End Sub
End Class