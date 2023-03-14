Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Clear()
        txtValue.Focus()
        lblResults.Visible = False
        grpConversion.Focus()
        rbtnInToM.Checked = True
        rbtnMToIn.Checked = False

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decInput As Decimal = 0D
        Dim decConversion As Decimal
        Dim decResult As Decimal
        Dim strLabel1 As String
        Dim strLabel2 As String
        Dim decInToM As Decimal = 0.0254D
        Dim decMToIn As Decimal = 39.37D


        If IsNumeric(txtValue.Text) Then
            decInput = Convert.ToDecimal(txtValue.Text)
            If decInput > 0 Then
                If rbtnInToM.Checked Then
                    decConversion = decInToM
                    strLabel1 = " inches "
                    strLabel2 = " meters"

                ElseIf rbtnMToIn.Checked Then
                    decConversion = decMToIn
                    strLabel1 = " meters "
                    strLabel2 = " inches"
                End If

                decResult = (decInput * decConversion)
                lblResults.Text = decInput.ToString() + strLabel1 + " is " + decResult.ToString() + strLabel2
                lblResults.Visible = True
            Else
                MsgBox("Enter a positive Number for an accurate conversion")
            End If
        Else
            MsgBox("Enter a numeric value for an accurarte converion")
        End If
    End Sub
End Class
