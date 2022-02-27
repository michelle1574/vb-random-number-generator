Public Class Form1

    Dim NumericText2 As Boolean
    Dim NumericText1 As Boolean
    Dim MaxNum As String = 9999999995



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With TextBox1
            If IsNumeric(.Text) Then
                NumericText1 = True
            Else
                NumericText1 = False
            End If
        End With
        With TextBox2
            If IsNumeric(.Text) Then
                NumericText2 = True
            Else
                NumericText2 = False
            End If
        End With
        If NumericText2 = True And NumericText1 = True Then
            If TextBox1.Text > MaxNum Then
                Dim results As DialogResult
                results = MsgBox("The number is too high to generate. Are you sure to generate the number?", vbYesNo + vbExclamation, "Warning!")
                If results = vbYes Then
                    Randomize()
                    Dim value2 As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
                    If value2 >= TextBox1.Text Then
                        MsgBox("Sorry, the generated number is greater than entered number. Please try again.", vbOKOnly + vbCritical, "Error")
                    ElseIf value2 <= TextBox2.Text Then
                        MsgBox("Sorry, the generated number is less than entered number. Please try again.", vbOKOnly + vbCritical, "Error")
                    Else
                        Label4.Text = "Random Number: " & value2
                    End If
                Else
                    Exit Sub
                End If
            End If
            Randomize()
            Dim value As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
            If value >= TextBox1.Text Then
                MsgBox("Sorry, the generated number is greater than entered number. Please try again.", vbOKOnly + vbCritical, "Error")
            ElseIf value <= TextBox2.Text Then
                MsgBox("Sorry, the generated number is less than entered number. Please try again.", vbOKOnly + vbCritical, "Error")
            Else
                Label4.Text = "Random Number: " & value
            End If

        Else
            MsgBox("The value is not a number. Enter value that is an number. For example: Min Number should be 8 and Max number should be 20", vbOKOnly + vbCritical, "Error")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            Randomize()
            Dim value3 As Integer = CInt(Int((1000000 * Rnd()) + 1))
            Dim value4 As Integer = 0
            TextBox1.Text = value3
            TextBox2.Text = value4
            Dim value5 As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
            Label4.Text = "Random Number: " & value5
        ElseIf RadioButton2.Checked = True Then
            Randomize()
            Dim value3 As Integer = CInt(Int((100 * Rnd()) + 1))
            Dim value4 As Integer = 0
            TextBox1.Text = value3
            TextBox2.Text = value4
            Dim value5 As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
            Label4.Text = "Random Number: " & value5
        ElseIf RadioButton3.Checked = True Then
            Randomize()
            Dim value3 As Integer = CInt(Int((10000 * Rnd()) + 1))
            Dim value4 As Integer = 0
            TextBox1.Text = value3
            TextBox2.Text = value4
            Dim value5 As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
            Label4.Text = "Random Number: " & value5
        ElseIf RadioButton4.Checked = True Then
            Randomize()
            Dim value3 As Integer = CInt(Int((900000000 * Rnd()) + 5))
            Dim value4 As Integer = CInt(Int((5 * Rnd()) + 0))
            TextBox1.Text = value3
            TextBox2.Text = value4
            Dim value5 As Integer = CInt(Int((TextBox1.Text * Rnd()) + TextBox2.Text))
            Label4.Text = "Random Number: " & value5
        Else
            MsgBox("Please choose an option first.", vbOKOnly + vbCritical, "Error")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Random Number Generator 1.2, Created by: Michelle1574", vbOKOnly + vbInformation, "About Random Number Generator")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
