Namespace CustomControls
    Public Class NumericTextBox
        Inherits TextBox

        Protected Overrides Sub OnKeyPress(ByVal e As Windows.Forms.KeyPressEventArgs)
            MyBase.OnKeyPress(e)
            If "X1234567890".IndexOf(e.KeyChar.ToString()) > 0 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub


    End Class
End Namespace