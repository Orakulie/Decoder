Public Class Decoder
    Dim InText As String
    Dim OutText As String
    Dim Letters(52) As String
    Dim TextArray() As Char
    Dim Seed() As Char
    Dim SeedINT(8) As Integer
    Dim Z As Integer = 0
    Public Sub Main1()

        Letters(0) = "a"
        Letters(1) = "b"
        Letters(2) = "c"
        Letters(3) = "d"
        Letters(4) = "e"
        Letters(5) = "f"
        Letters(6) = "g"
        Letters(7) = "h"
        Letters(8) = "i"
        Letters(9) = "j"
        Letters(10) = "k"
        Letters(11) = "l"
        Letters(12) = "m"
        Letters(13) = "n"
        Letters(14) = "o"
        Letters(15) = "p"
        Letters(16) = "q"
        Letters(17) = "r"
        Letters(18) = "s"
        Letters(19) = "t"
        Letters(20) = "u"
        Letters(21) = "v"
        Letters(22) = "w"
        Letters(23) = "x"
        Letters(24) = "y"
        Letters(25) = "z"
        Letters(26) = " "
        Letters(27) = "("
        Letters(28) = ")"
        Letters(29) = "["
        Letters(30) = "]"
        Letters(31) = "{"
        Letters(32) = "}"
        Letters(33) = "?"
        Letters(34) = "!"
        Letters(35) = "="
        Letters(36) = "'"
        Letters(37) = ","
        Letters(38) = "."
        Letters(39) = "-"
        Letters(40) = "/"
        Letters(41) = "\"
        Letters(42) = ":"

        Letters(43) = "0"
        Letters(44) = "1"
        Letters(45) = "2"
        Letters(46) = "3"
        Letters(47) = "4"
        Letters(48) = "5"
        Letters(49) = "6"
        Letters(50) = "7"
        Letters(51) = "8"
        Letters(52) = "9"




        SeedChange()
    End Sub










    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Main1()
        InText = InputBox.Text.ToLower
        Z = 0
        TextArray = InText.ToCharArray
        Dim y As Integer = 0
        Dim b As Integer = 0

        For Each cha As Char In TextArray
            Dim i As Integer = 0

            For Each letter As String In Letters
                If letter = cha Then



                    If i + SeedINT(Z) <= Letters.Length - 1 Then
                            TextArray(y) = Letters(i + SeedINT(Z))
                        End If
                        If i + SeedINT(Z) > Letters.Length - 1 Then
                            Dim temp As Integer = (i + SeedINT(Z) - (Letters.Length))

                            TextArray(y) = Letters(0 + temp)
                        End If
                        If Z = 8 Then
                            Z = 0
                        End If
                        If Z <= 7 Then
                            Z += 1
                        End If

                    End If


                    i += 1
            Next
            y += 1

        Next
        OutputBox.Text = TextArray



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main1()
        InText = InputBox.Text
        InText.ToLower()
        TextArray = InText.ToCharArray
        Z = 0
        Dim y As Integer = 0

        For Each cha As Char In TextArray
            Dim i As Integer = 0

            For Each letter As String In Letters
                If letter = cha Then

                    If i - SeedINT(Z) >= 0 Then
                        TextArray(y) = Letters(i - SeedINT(Z))
                    End If
                    If i - SeedINT(Z) < 0 Then
                        Dim temp As Integer = (i - SeedINT(Z) + 1)
                        TextArray(y) = Letters((Letters.Length - 1) + temp)
                    End If
                    If Z = 8 Then
                        Z = 0
                    End If
                    If Z <= 7 Then
                        Z += 1
                    End If

                End If

                i += 1


            Next
            y += 1
        Next
        OutputBox.Text = TextArray
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(OutputBox.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SeedBox.Text = "123456789"
        SeedChange()
    End Sub
    Sub SeedChange()
        Array.Clear(SeedINT, 0, SeedINT.Length)


        Seed = SeedBox.Text.ToCharArray
        Dim i As Integer = 0
        For Each x As Char In Seed


            SeedINT(i) = Asc(x) - 48

            i += 1
        Next
        Z = 0
    End Sub

    Private Sub SeedBox_TextChanged(sender As Object, e As EventArgs) Handles SeedBox.TextChanged
        SeedChange()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        InputBox.Text = My.Computer.Clipboard.GetText
    End Sub

End Class
