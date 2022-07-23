Public Class Form1
    Dim a(,) As Integer = {{0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}}
    Dim sudoku(,) As Integer = {{0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}}
    Dim sudokuan(,) As Integer = {{0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}}

    Dim box As Integer = 0
    Dim Time As Integer = 0
    Dim stage As Integer
    Dim level As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = True
        If (sudoku(0, 0) = 0) Then  'for Textbox1
            TextBox1.Text = sudoku(0, 0)
            TextBox1.ReadOnly = False
        ElseIf (sudoku(0, 0) <> 0) Then
            TextBox1.Text = sudoku(0, 0)
            TextBox1.ReadOnly = True

        End If

        If (sudoku(0, 1) = 0) Then 'for Textbox2
            TextBox2.Text = sudoku(0, 1)
            TextBox2.ReadOnly = False
        ElseIf (sudoku(0, 1) <> 0) Then
            TextBox2.Text = sudoku(0, 1)
            TextBox2.ReadOnly = True
        End If

        If (sudoku(0, 2) = 0) Then 'for Textbox3
            TextBox3.Text = sudoku(0, 2)
            TextBox3.ReadOnly = False
        ElseIf (sudoku(0, 2) <> 0) Then
            TextBox3.Text = sudoku(0, 2)
            TextBox3.ReadOnly = True
        End If

        If (sudoku(0, 3) = 0) Then 'for Textbox4
            TextBox4.Text = sudoku(0, 3)
            TextBox4.ReadOnly = False
        ElseIf (sudoku(0, 3) <> 0) Then
            TextBox4.Text = sudoku(0, 3)
            TextBox4.ReadOnly = True
        End If

        If (sudoku(0, 4) = 0) Then 'for Textbox5
            TextBox5.Text = sudoku(0, 4)
            TextBox5.ReadOnly = False
        ElseIf (sudoku(0, 4) <> 0) Then
            TextBox5.Text = sudoku(0, 4)
            TextBox5.ReadOnly = True
        End If

        If (sudoku(0, 5) = 0) Then 'for Textbox6
            TextBox6.Text = sudoku(0, 5)
            TextBox6.ReadOnly = False
        ElseIf (sudoku(0, 5) <> 0) Then
            TextBox6.Text = sudoku(0, 5)
            TextBox6.ReadOnly = True
        End If

        If (sudoku(1, 0) = 0) Then 'for Textbox7
            TextBox7.Text = sudoku(1, 0)
            TextBox7.ReadOnly = False
        ElseIf (sudoku(1, 0) <> 0) Then
            TextBox7.Text = sudoku(1, 0)
            TextBox7.ReadOnly = True
        End If

        If (sudoku(1, 1) = 0) Then 'for Textbox8
            TextBox8.Text = sudoku(1, 1)
            TextBox8.ReadOnly = False
        ElseIf (sudoku(1, 1) <> 0) Then
            TextBox8.Text = sudoku(1, 1)
            TextBox8.ReadOnly = True
        End If

        If (sudoku(1, 2) = 0) Then 'for Textbox9
            TextBox9.Text = sudoku(1, 2)
            TextBox9.ReadOnly = False
        ElseIf (sudoku(1, 2) <> 0) Then
            TextBox9.Text = sudoku(1, 2)
            TextBox9.ReadOnly = True
        End If

        If (sudoku(1, 3) = 0) Then 'for Textbox10
            TextBox10.Text = sudoku(1, 3)
            TextBox10.ReadOnly = False
        ElseIf (sudoku(1, 3) <> 0) Then
            TextBox10.Text = sudoku(1, 3)
            TextBox10.ReadOnly = True
        End If

        If (sudoku(1, 4) = 0) Then 'for Textbox11
            TextBox11.Text = sudoku(1, 4)
            TextBox11.ReadOnly = False
        ElseIf (sudoku(1, 4) <> 0) Then
            TextBox11.Text = sudoku(1, 4)
            TextBox11.ReadOnly = True
        End If

        If (sudoku(1, 5) = 0) Then 'for Textbox12
            TextBox12.Text = sudoku(1, 5)
            TextBox12.ReadOnly = False
        ElseIf (sudoku(1, 5) <> 0) Then
            TextBox12.Text = sudoku(1, 5)
            TextBox12.ReadOnly = True
        End If

        If (sudoku(2, 0) = 0) Then 'for Textbox13
            TextBox13.Text = sudoku(2, 0)
            TextBox13.ReadOnly = False
        ElseIf (sudoku(2, 0) <> 0) Then
            TextBox13.Text = sudoku(2, 0)
            TextBox13.ReadOnly = True
        End If

        If (sudoku(2, 1) = 0) Then 'for Textbox14
            TextBox14.Text = sudoku(2, 1)
            TextBox14.ReadOnly = False
        ElseIf (sudoku(2, 1) <> 0) Then
            TextBox14.Text = sudoku(2, 1)
            TextBox14.ReadOnly = True
        End If

        If (sudoku(2, 2) = 0) Then 'for Textbox15
            TextBox15.Text = sudoku(2, 2)
            TextBox15.ReadOnly = False
        ElseIf (sudoku(2, 2) <> 0) Then
            TextBox15.Text = sudoku(2, 2)
            TextBox15.ReadOnly = True
        End If

        If (sudoku(2, 3) = 0) Then 'for Textbox16
            TextBox16.Text = sudoku(2, 3)
            TextBox16.ReadOnly = False
        ElseIf (sudoku(2, 3) <> 0) Then
            TextBox16.Text = sudoku(2, 3)
            TextBox16.ReadOnly = True
        End If

        If (sudoku(2, 4) = 0) Then 'for Textbox17
            TextBox17.Text = sudoku(2, 4)
            TextBox17.ReadOnly = False
        ElseIf (sudoku(2, 4) <> 0) Then
            TextBox17.Text = sudoku(2, 4)
            TextBox17.ReadOnly = True
        End If

        If (sudoku(2, 5) = 0) Then 'for Textbox18
            TextBox18.Text = sudoku(2, 5)
            TextBox18.ReadOnly = False
        ElseIf (sudoku(2, 5) <> 0) Then
            TextBox18.Text = sudoku(2, 5)
            TextBox18.ReadOnly = True
        End If

        If (sudoku(3, 0) = 0) Then 'for Textbox19
            TextBox19.Text = sudoku(3, 0)
            TextBox19.ReadOnly = False
        ElseIf (sudoku(3, 0) <> 0) Then
            TextBox19.Text = sudoku(3, 0)
            TextBox19.ReadOnly = True
        End If

        If (sudoku(3, 1) = 0) Then 'for Textbox20
            TextBox20.Text = sudoku(3, 1)
            TextBox20.ReadOnly = False
        ElseIf (sudoku(3, 1) <> 0) Then
            TextBox20.Text = sudoku(3, 1)
            TextBox20.ReadOnly = True
        End If

        If (sudoku(3, 2) = 0) Then 'for Textbox21
            TextBox21.Text = sudoku(3, 2)
            TextBox21.ReadOnly = False
        ElseIf (sudoku(3, 2) <> 0) Then
            TextBox21.Text = sudoku(3, 2)
            TextBox21.ReadOnly = True
        End If

        If (sudoku(3, 3) = 0) Then 'for Textbox22
            TextBox22.Text = sudoku(3, 3)
            TextBox22.ReadOnly = False
        ElseIf (sudoku(3, 3) <> 0) Then
            TextBox22.Text = sudoku(3, 3)
            TextBox22.ReadOnly = True
        End If

        If (sudoku(3, 4) = 0) Then 'for Textbox23
            TextBox23.Text = sudoku(3, 4)
            TextBox23.ReadOnly = False
        ElseIf (sudoku(3, 4) <> 0) Then
            TextBox23.Text = sudoku(3, 4)
            TextBox23.ReadOnly = True
        End If

        If (sudoku(3, 5) = 0) Then 'for Textbox24
            TextBox24.Text = sudoku(3, 5)
            TextBox24.ReadOnly = False
        ElseIf (sudoku(3, 5) <> 0) Then
            TextBox24.Text = sudoku(3, 5)
            TextBox24.ReadOnly = True
        End If

        If (sudoku(4, 0) = 0) Then 'for Textbox25
            TextBox25.Text = sudoku(4, 0)
            TextBox25.ReadOnly = False
        ElseIf (sudoku(4, 0) <> 0) Then
            TextBox25.Text = sudoku(4, 0)
            TextBox25.ReadOnly = True
        End If

        If (sudoku(4, 1) = 0) Then 'for Textbox26
            TextBox26.Text = sudoku(4, 1)
            TextBox26.ReadOnly = False
        ElseIf (sudoku(4, 1) <> 0) Then
            TextBox26.Text = sudoku(4, 1)
            TextBox26.ReadOnly = True
        End If

        If (sudoku(4, 2) = 0) Then 'for Textbox27
            TextBox27.Text = sudoku(4, 2)
            TextBox27.ReadOnly = False
        ElseIf (sudoku(4, 2) <> 0) Then
            TextBox27.Text = sudoku(4, 2)
            TextBox27.ReadOnly = True
        End If

        If (sudoku(4, 3) = 0) Then 'for Textbox28
            TextBox28.Text = sudoku(4, 3)
            TextBox28.ReadOnly = False
        ElseIf (sudoku(4, 3) <> 0) Then
            TextBox28.Text = sudoku(4, 3)
            TextBox28.ReadOnly = True
        End If

        If (sudoku(4, 4) = 0) Then 'for Textbox29
            TextBox29.Text = sudoku(4, 4)
            TextBox29.ReadOnly = False
        ElseIf (sudoku(4, 4) <> 0) Then
            TextBox29.Text = sudoku(4, 4)
            TextBox29.ReadOnly = True
        End If

        If (sudoku(4, 5) = 0) Then 'for Textbox30
            TextBox30.Text = sudoku(4, 5)
            TextBox30.ReadOnly = False
        ElseIf (sudoku(4, 5) <> 0) Then
            TextBox30.Text = sudoku(4, 5)
            TextBox30.ReadOnly = True
        End If

        If (sudoku(5, 0) = 0) Then 'for Textbox31
            TextBox31.Text = sudoku(5, 0)
            TextBox31.ReadOnly = False
        ElseIf (sudoku(5, 0) <> 0) Then
            TextBox31.Text = sudoku(5, 0)
            TextBox31.ReadOnly = True
        End If

        If (sudoku(5, 1) = 0) Then 'for Textbox32
            TextBox32.Text = sudoku(5, 1)
            TextBox32.ReadOnly = False
        ElseIf (sudoku(5, 1) <> 0) Then
            TextBox32.Text = sudoku(5, 1)
            TextBox32.ReadOnly = True
        End If

        If (sudoku(5, 2) = 0) Then 'for Textbox33
            TextBox33.Text = sudoku(5, 2)
            TextBox33.ReadOnly = False
        ElseIf (sudoku(5, 2) <> 0) Then
            TextBox33.Text = sudoku(5, 2)
            TextBox33.ReadOnly = True
        End If

        If (sudoku(5, 3) = 0) Then 'for Textbox34
            TextBox34.Text = sudoku(5, 3)
            TextBox34.ReadOnly = False
        ElseIf (sudoku(5, 3) <> 0) Then
            TextBox34.Text = sudoku(5, 3)
            TextBox34.ReadOnly = True
        End If

        If (sudoku(5, 4) = 0) Then 'for Textbox35
            TextBox35.Text = sudoku(5, 4)
            TextBox35.ReadOnly = False
        ElseIf (sudoku(5, 4) <> 0) Then
            TextBox35.Text = sudoku(5, 4)
            TextBox35.ReadOnly = True
        End If

        If (sudoku(5, 5) = 0) Then 'for Textbox36
            TextBox36.Text = sudoku(5, 5)
            TextBox36.ReadOnly = False
        ElseIf (sudoku(5, 5) <> 0) Then
            TextBox36.Text = sudoku(5, 5)
            TextBox36.ReadOnly = True
        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Label1.Text = ""
        If (TextBox1.Text = "") Then
            sudoku(0, 0) = 0
        End If
        If (TextBox1.Text = "0") Then
            TextBox1.Text = ""
        End If
        If (TextBox1.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox25.BackColor = Color.White
            TextBox31.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox1.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox1.Text)) Then
                    If (TextBox1.Text > 6 Or TextBox1.Text < 0) Then
                        TextBox1.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox1.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox1.Text) Then
                    sudoku(0, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox1.Text = sudoku(0, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox1.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox1.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox1.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox1.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox1.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox1.Text
                    sudoku(0, 0) = TextBox1.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox1.ReadOnly = False
                    box = 1
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Label1.Text = ""
        If (TextBox2.Text = "") Then
            sudoku(0, 1) = 0
        End If
        If (TextBox2.Text = "0") Then
            TextBox2.Text = ""
        End If
        If (TextBox2.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            Dim a As Integer
            Dim counter = 3
            Dim change = 0

            If (TextBox2.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox2.Text)) Then
                    If (TextBox2.Text > 6 Or TextBox2.Text < 0) Then
                        TextBox2.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox2.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox2.Text) Then
                    sudoku(0, 1) = 0
                End If
                Label1.Text = ""

                For i = 0 To 5
                    If (TextBox2.Text = sudoku(0, i)) Then
                        counter = 1
                        Label1.Text = "Found in Row"
                        TextBox2.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If

                    End If
                    If (TextBox2.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox2.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox2.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox2.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox2.Text
                    sudoku(0, 1) = TextBox2.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then

                    TextBox2.ReadOnly = False
                    box = 2
                    Timer1.Start()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label1.Text = ""
        If (TextBox3.Text = "") Then
            sudoku(0, 2) = 0
        End If
        If (TextBox3.Text = "0") Then
            TextBox3.Text = ""
        End If
        If (TextBox3.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            Dim a As Integer
            Dim counter = 3
            Dim change = 0

            If (TextBox3.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox3.Text)) Then
                    If (TextBox3.Text > 6 Or TextBox3.Text < 0) Then
                        TextBox3.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox3.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox3.Text) Then
                    sudoku(0, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5
                    If (TextBox3.Text = sudoku(0, i)) Then
                        counter = 1
                        Label1.Text = "Found in Row"
                        TextBox3.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If

                    End If
                    If (TextBox3.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox3.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox3.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox3.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox3.Text
                    sudoku(0, 2) = TextBox3.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox3.ReadOnly = False
                    box = 3
                    Timer1.Start()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label1.Text = ""
        If (TextBox4.Text = "") Then
            sudoku(0, 3) = 0
        End If
        If (TextBox4.Text = "0") Then
            TextBox4.Text = ""
        End If
        If (TextBox4.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            Dim a As Integer
            Dim counter = 3
            Dim change = 0

            If (TextBox4.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox4.Text)) Then
                    If (TextBox4.Text > 6 Or TextBox4.Text < 0) Then
                        TextBox4.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox4.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox4.Text) Then
                    sudoku(0, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5
                    If (TextBox4.Text = sudoku(0, i)) Then
                        counter = 1
                        Label1.Text = "Found in Row"
                        TextBox4.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If
                    End If
                    If (TextBox4.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox4.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox4.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox4.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox4.Text
                    sudoku(0, 3) = TextBox4.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox4.ReadOnly = False
                    box = 4
                    Timer1.Start()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Label1.Text = ""
        If (TextBox5.Text = "") Then
            sudoku(0, 4) = 0
        End If
        If (TextBox5.Text = "0") Then
            TextBox5.Text = ""
        End If
        If (TextBox5.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            Dim a As Integer
            Dim counter As Integer = 3
            Dim change = 0


            If (TextBox5.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox5.Text)) Then
                    If (TextBox5.Text > 6 Or TextBox5.Text < 0) Then
                        TextBox5.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox5.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox5.Text) Then
                    sudoku(0, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5
                    If (TextBox5.Text = sudoku(0, i)) Then
                        counter = 1
                        Label1.Text = "Found in Row"
                        TextBox5.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If
                    End If
                    If (TextBox5.Text = sudoku(i, 4)) Then
                        counter = 1
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox5.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox5.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox5.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i

                End If
                If (counter <> 1) Then
                    a = TextBox5.Text
                    sudoku(0, 4) = TextBox5.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox5.ReadOnly = False
                    box = 5
                    Timer1.Start()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Label1.Text = ""
        If (TextBox6.Text = "") Then
            sudoku(0, 5) = 0
        End If
        If (TextBox6.Text = "0") Then
            TextBox6.Text = ""
        End If
        If (TextBox6.ReadOnly = False) Then
Line1:
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox24.BackColor = Color.White
            TextBox30.BackColor = Color.White
            TextBox36.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            Dim a As Integer
            Dim counter As Integer = 3
            Dim change = 0


            If (TextBox6.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox6.Text)) Then
                    If (TextBox6.Text > 6 Or TextBox6.Text < 0) Then
                        TextBox6.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox6.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox6.Text) Then
                    sudoku(0, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5
                    If (TextBox6.Text = sudoku(0, i)) Then
                        counter = 1
                        Label1.Text = "Found in Row"
                        TextBox6.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox6.BackColor = Color.Red
                        End If
                    End If
                    If (TextBox6.Text = sudoku(i, 5)) Then
                        counter = 1
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox6.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox6.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox6.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i

                End If
                If (counter <> 1) Then
                    a = TextBox6.Text
                    sudoku(0, 5) = TextBox6.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox6.ReadOnly = False
                    box = 6
                    Timer1.Start()
                End If
            End If
        End If
    End Sub



    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Label1.Text = ""
        If (TextBox7.Text = "") Then
            sudoku(1, 0) = 0
        End If
        If (TextBox7.Text = "0") Then
            TextBox7.Text = ""
        End If
        If (TextBox7.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox25.BackColor = Color.White
            TextBox31.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox7.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox7.Text)) Then
                    If (TextBox7.Text > 6 Or TextBox7.Text < 0) Then
                        TextBox7.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox7.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox7.Text) Then
                    sudoku(1, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox7.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox7.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox7.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox7.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox7.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox7.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox7.Text
                    sudoku(1, 0) = TextBox7.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox7.ReadOnly = False
                    box = 7
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Label1.Text = ""
        If (TextBox8.Text = "") Then
            sudoku(1, 1) = 0
        End If
        If (TextBox8.Text = "0") Then
            TextBox8.Text = ""
        End If
        If (TextBox8.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox32.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox3.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox8.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox8.Text)) Then
                    If (TextBox8.Text > 6 Or TextBox8.Text < 0) Then
                        TextBox8.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox8.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox8.Text) Then
                    sudoku(1, 1) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox8.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox8.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox8.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox8.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox8.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox8.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox8.Text
                    sudoku(1, 1) = TextBox8.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox8.ReadOnly = False
                    box = 8
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Label1.Text = ""
        If (TextBox9.Text = "") Then
            sudoku(1, 2) = 0
        End If
        If (TextBox9.Text = "0") Then
            TextBox9.Text = ""
        End If
        If (TextBox9.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox3.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox33.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox1.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox9.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox9.Text)) Then
                    If (TextBox9.Text > 6 Or TextBox9.Text < 0) Then
                        TextBox9.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox9.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox9.Text) Then
                    sudoku(1, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox9.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox9.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox9.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox9.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 0 To 2
                            If (TextBox9.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox9.BackColor = Color.Red
                                If (i = 0 And j = 0) Then
                                    TextBox1.BackColor = Color.Red
                                ElseIf (i = 0 And j = 1) Then
                                    TextBox2.BackColor = Color.Red
                                ElseIf (i = 0 And j = 2) Then
                                    TextBox3.BackColor = Color.Red
                                ElseIf (i = 1 And j = 0) Then
                                    TextBox7.BackColor = Color.Red
                                ElseIf (i = 1 And j = 1) Then
                                    TextBox8.BackColor = Color.Red
                                ElseIf (i = 1 And j = 2) Then
                                    TextBox9.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox9.Text
                    sudoku(1, 2) = TextBox9.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox9.ReadOnly = False
                    box = 9
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Label1.Text = ""
        If (TextBox10.Text = "") Then
            sudoku(1, 3) = 0
        End If
        If (TextBox10.Text = "0") Then
            TextBox10.Text = ""
        End If
        If (TextBox10.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox4.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox34.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox10.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox10.Text)) Then
                    If (TextBox10.Text > 6 Or TextBox10.Text < 0) Then
                        TextBox10.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox10.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox10.Text) Then
                    sudoku(1, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox10.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox10.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox10.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox10.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox10.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox10.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox10.Text
                    sudoku(1, 3) = TextBox10.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox10.ReadOnly = False
                    box = 10
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Label1.Text = ""
        If (TextBox11.Text = "") Then
            sudoku(1, 4) = 0
        End If
        If (TextBox11.Text = "0") Then
            TextBox11.Text = ""
        End If
        If (TextBox11.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox35.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox11.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox11.Text)) Then
                    If (TextBox11.Text > 6 Or TextBox11.Text < 0) Then
                        TextBox11.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox11.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox11.Text) Then
                    sudoku(1, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox11.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox11.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox11.Text = sudoku(i, 4)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox11.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox11.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox11.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox11.Text
                    sudoku(1, 4) = TextBox11.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox11.ReadOnly = False
                    box = 11
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Label1.Text = ""
        If (TextBox12.Text = "") Then
            sudoku(1, 5) = 0
        End If
        If (TextBox12.Text = "0") Then
            TextBox12.Text = ""
        End If
        If (TextBox12.ReadOnly = False) Then
Line1:
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White

            TextBox6.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox24.BackColor = Color.White
            TextBox30.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox6.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox12.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox12.Text)) Then
                    If (TextBox12.Text > 6 Or TextBox12.Text < 0) Then
                        TextBox12.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox12.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox12.Text) Then
                    sudoku(1, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox12.Text = sudoku(1, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox12.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox12.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox12.Text = sudoku(i, 5)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox12.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 0 To 1
                        For j = 3 To 5
                            If (TextBox12.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox12.BackColor = Color.Red
                                If (i = 0 And j = 3) Then
                                    TextBox4.BackColor = Color.Red
                                ElseIf (i = 0 And j = 4) Then
                                    TextBox5.BackColor = Color.Red
                                ElseIf (i = 0 And j = 5) Then
                                    TextBox6.BackColor = Color.Red
                                ElseIf (i = 1 And j = 3) Then
                                    TextBox10.BackColor = Color.Red
                                ElseIf (i = 1 And j = 4) Then
                                    TextBox11.BackColor = Color.Red
                                ElseIf (i = 1 And j = 5) Then
                                    TextBox12.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox12.Text
                    sudoku(1, 5) = TextBox12.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox12.ReadOnly = False
                    box = 12
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Label1.Text = ""
        If (TextBox13.Text = "") Then
            sudoku(2, 0) = 0
        End If
        If (TextBox13.Text = "0") Then
            TextBox13.Text = ""
        End If
        If (TextBox13.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox25.BackColor = Color.White
            TextBox31.BackColor = Color.White

            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox13.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox13.Text)) Then
                    If (TextBox13.Text > 6 Or TextBox13.Text < 0) Then
                        TextBox13.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox13.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox13.Text) Then
                    sudoku(2, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox13.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox13.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox13.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox13.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox13.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox13.BackColor = Color.Red
                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox13.Text
                    sudoku(2, 0) = TextBox13.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox13.ReadOnly = False
                    box = 13
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Label1.Text = ""
        If (TextBox14.Text = "") Then
            sudoku(2, 1) = 0
        End If
        If (TextBox14.Text = "0") Then
            TextBox14.Text = ""
        End If
        If (TextBox14.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox32.BackColor = Color.White

            TextBox19.BackColor = Color.White
            TextBox21.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox14.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox14.Text)) Then
                    If (TextBox14.Text > 6 Or TextBox14.Text < 0) Then
                        TextBox14.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox14.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox14.Text) Then
                    sudoku(2, 1) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox14.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox14.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox14.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox14.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox14.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox14.BackColor = Color.Red
                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox14.Text
                    sudoku(2, 1) = TextBox14.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox14.ReadOnly = False
                    box = 14
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Label1.Text = ""
        If (TextBox15.Text = "") Then
            sudoku(2, 2) = 0
        End If
        If (TextBox15.Text = "0") Then
            TextBox15.Text = ""
        End If
        If (TextBox15.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox3.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox33.BackColor = Color.White

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox15.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox15.Text)) Then
                    If (TextBox15.Text > 6 Or TextBox15.Text < 0) Then
                        TextBox15.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox15.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox15.Text) Then
                    sudoku(2, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox15.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox15.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox15.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox15.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox15.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox15.BackColor = Color.Red
                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox15.Text
                    sudoku(2, 2) = TextBox15.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox15.ReadOnly = False
                    box = 15
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        Label1.Text = ""
        If (TextBox16.Text = "") Then
            sudoku(2, 3) = 0
        End If
        If (TextBox16.Text = "0") Then
            TextBox16.Text = ""
        End If
        If (TextBox16.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox4.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox34.BackColor = Color.White

            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox16.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox16.Text)) Then
                    If (TextBox16.Text > 6 Or TextBox16.Text < 0) Then
                        TextBox16.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox16.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox16.Text) Then
                    sudoku(2, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox16.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox16.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox16.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox16.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox16.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox16.BackColor = Color.Red
                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox16.Text
                    sudoku(2, 3) = TextBox16.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox16.ReadOnly = False
                    box = 16
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        Label1.Text = ""
        If (TextBox17.Text = "") Then
            sudoku(2, 4) = 0
        End If
        If (TextBox17.Text = "0") Then
            TextBox17.Text = ""
        End If
        If (TextBox17.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox35.BackColor = Color.White

            TextBox22.BackColor = Color.White
            TextBox24.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox17.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox17.Text)) Then
                    If (TextBox17.Text > 6 Or TextBox17.Text < 0) Then
                        TextBox17.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox17.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox17.Text) Then
                    sudoku(2, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox17.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox17.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox17.Text = sudoku(i, 4)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox17.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox17.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox17.BackColor = Color.Red
                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox17.Text
                    sudoku(2, 4) = TextBox17.Text
                    Label1.Text = "GOOD"
                    submit()

                ElseIf (counter = 1) Then
                    TextBox17.ReadOnly = False
                    box = 17
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        Label1.Text = ""
        If (TextBox18.Text = "") Then
            sudoku(2, 5) = 0
        End If
        If (TextBox18.Text = "0") Then
            TextBox18.Text = ""
        End If
        If (TextBox18.ReadOnly = False) Then
Line1:
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White

            TextBox6.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox24.BackColor = Color.White
            TextBox30.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox18.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox18.Text)) Then
                    If (TextBox18.Text > 6 Or TextBox18.Text < 0) Then
                        TextBox18.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox18.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox18.Text) Then
                    sudoku(2, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox18.Text = sudoku(2, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox18.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox18.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox18.Text = sudoku(i, 5)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox18.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox18.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox18.BackColor = Color.Red
                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox18.Text
                    sudoku(2, 5) = TextBox18.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox18.ReadOnly = False
                    box = 18
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        Label1.Text = ""
        If (TextBox19.Text = "") Then
            sudoku(3, 0) = 0
        End If
        If (TextBox19.Text = "0") Then
            TextBox19.Text = ""
        End If
        If (TextBox19.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox25.BackColor = Color.White
            TextBox31.BackColor = Color.White

            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox19.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox19.Text)) Then
                    If (TextBox19.Text > 6 Or TextBox19.Text < 0) Then
                        TextBox19.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox19.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox19.Text) Then
                    sudoku(3, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox19.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox19.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox19.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox19.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox19.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox19.BackColor = Color.Red
                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox19.Text
                    sudoku(3, 0) = TextBox19.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox19.ReadOnly = False
                    box = 19
                    Timer1.Start()

                End If
            End If

        End If
    End Sub




    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        Label1.Text = ""
        If (TextBox20.Text = "") Then
            sudoku(3, 1) = 0
        End If
        If (TextBox20.Text = "0") Then
            TextBox20.Text = ""

        End If
        If (TextBox20.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox32.BackColor = Color.White

            TextBox13.BackColor = Color.White
            TextBox15.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox20.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox20.Text)) Then
                    If (TextBox20.Text > 6 Or TextBox20.Text < 0) Then
                        TextBox20.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox20.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox20.Text) Then
                    sudoku(3, 1) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox20.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox20.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox20.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox20.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox20.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"


                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox20.Text
                    sudoku(3, 1) = TextBox20.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox20.ReadOnly = False
                    box = 20
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        Label1.Text = ""
        If (TextBox21.Text = "") Then
            sudoku(3, 2) = 0
        End If
        If (TextBox21.Text = "0") Then
            TextBox21.Text = ""

        End If
        If (TextBox21.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox3.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox33.BackColor = Color.White

            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox21.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox21.Text)) Then
                    If (TextBox21.Text > 6 Or TextBox21.Text < 0) Then
                        TextBox21.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox21.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox21.Text) Then
                    sudoku(3, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox21.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox21.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox21.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox21.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 0 To 2
                            If (TextBox21.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"


                                If (i = 2 And j = 0) Then
                                    TextBox13.BackColor = Color.Red
                                ElseIf (i = 2 And j = 1) Then
                                    TextBox14.BackColor = Color.Red
                                ElseIf (i = 2 And j = 2) Then
                                    TextBox15.BackColor = Color.Red
                                ElseIf (i = 3 And j = 0) Then
                                    TextBox19.BackColor = Color.Red
                                ElseIf (i = 3 And j = 1) Then
                                    TextBox20.BackColor = Color.Red
                                ElseIf (i = 3 And j = 2) Then
                                    TextBox21.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox21.Text
                    sudoku(3, 2) = TextBox21.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox21.ReadOnly = False
                    box = 21
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
        Label1.Text = ""
        If (TextBox22.Text = "") Then
            sudoku(3, 3) = 0
        End If
        If (TextBox22.Text = "0") Then
            TextBox22.Text = ""

        End If
        If (TextBox22.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox4.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox34.BackColor = Color.White

            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox22.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox22.Text)) Then
                    If (TextBox22.Text > 6 Or TextBox22.Text < 0) Then
                        TextBox22.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox22.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox22.Text) Then
                    sudoku(3, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox22.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox22.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox22.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox22.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox22.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox22.BackColor = Color.Red
                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox22.Text
                    sudoku(3, 3) = TextBox22.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox22.ReadOnly = False
                    box = 22
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

        Label1.Text = ""
        If (TextBox23.Text = "") Then
            sudoku(3, 4) = 0
        End If
        If (TextBox23.Text = "0") Then
            TextBox23.Text = ""

        End If
        If (TextBox23.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox35.BackColor = Color.White

            TextBox16.BackColor = Color.White
            TextBox18.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox23.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox23.Text)) Then
                    If (TextBox23.Text > 6 Or TextBox23.Text < 0) Then
                        TextBox23.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox23.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox23.Text) Then
                    sudoku(3, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox23.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox23.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox23.Text = sudoku(i, 4)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox23.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox23.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"

                                TextBox23.BackColor = Color.Red
                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox23.Text
                    sudoku(3, 4) = TextBox23.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox23.ReadOnly = False
                    box = 23
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        Label1.Text = ""
        If (TextBox24.Text = "") Then
            sudoku(3, 5) = 0
        End If
        If (TextBox24.Text = "0") Then
            TextBox24.Text = ""

        End If
        If (TextBox24.ReadOnly = False) Then
Line1:

            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            TextBox6.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox30.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox16.BackColor = Color.White
            TextBox17.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox24.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox24.Text)) Then
                    If (TextBox24.Text > 6 Or TextBox24.Text < 0) Then
                        TextBox24.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox24.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox24.Text) Then
                    sudoku(3, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox24.Text = sudoku(3, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox24.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox24.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox24.Text = sudoku(i, 5)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox24.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 2 To 3
                        For j = 3 To 5
                            If (TextBox24.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox24.BackColor = Color.Red

                                If (i = 2 And j = 3) Then
                                    TextBox16.BackColor = Color.Red
                                ElseIf (i = 2 And j = 4) Then
                                    TextBox17.BackColor = Color.Red
                                ElseIf (i = 2 And j = 5) Then
                                    TextBox18.BackColor = Color.Red
                                ElseIf (i = 3 And j = 3) Then
                                    TextBox22.BackColor = Color.Red
                                ElseIf (i = 3 And j = 4) Then
                                    TextBox23.BackColor = Color.Red
                                ElseIf (i = 3 And j = 5) Then
                                    TextBox24.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox24.Text
                    sudoku(3, 5) = TextBox24.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox24.ReadOnly = False
                    box = 24
                    Timer1.Start()

                End If
            End If

        End If
    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged
        Label1.Text = ""
        If (TextBox25.Text = "") Then
            sudoku(4, 0) = 0
        End If
        If (TextBox25.Text = "0") Then
            TextBox25.Text = ""

        End If
        If (TextBox25.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox31.BackColor = Color.White

            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox25.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox25.Text)) Then
                    If (TextBox25.Text > 6 Or TextBox25.Text < 0) Then
                        TextBox26.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox25.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox25.Text) Then
                    sudoku(4, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox25.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox25.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox25.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox25.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox25.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox25.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox25.Text
                    sudoku(4, 0) = TextBox25.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox25.ReadOnly = False
                    box = 25
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        Label1.Text = ""
        If (TextBox26.Text = "") Then
            sudoku(4, 1) = 0
        End If
        If (TextBox26.Text = "0") Then
            TextBox26.Text = ""

        End If
        If (TextBox26.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox32.BackColor = Color.White

            TextBox31.BackColor = Color.White
            TextBox33.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox26.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox26.Text)) Then
                    If (TextBox26.Text > 6 Or TextBox26.Text < 0) Then
                        TextBox26.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox26.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox26.Text) Then
                    sudoku(4, 1) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox26.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox26.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox26.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox26.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox26.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox26.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox26.Text
                    sudoku(4, 1) = TextBox26.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox26.ReadOnly = False
                    box = 26
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        Label1.Text = ""
        If (TextBox27.Text = "") Then
            sudoku(4, 2) = 0
        End If
        If (TextBox27.Text = "0") Then
            TextBox27.Text = ""

        End If
        If (TextBox27.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox3.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox33.BackColor = Color.White

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox27.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox27.Text)) Then
                    If (TextBox27.Text > 6 Or TextBox27.Text < 0) Then
                        TextBox27.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox27.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox27.Text) Then
                    sudoku(4, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox27.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox27.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox27.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox27.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox27.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox27.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox27.Text
                    sudoku(4, 2) = TextBox27.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox27.ReadOnly = False
                    box = 27
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged
        Label1.Text = ""
        If (TextBox28.Text = "") Then
            sudoku(4, 3) = 0
        End If
        If (TextBox28.Text = "0") Then
            TextBox28.Text = ""

        End If
        If (TextBox28.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox4.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox34.BackColor = Color.White

            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox28.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox28.Text)) Then
                    If (TextBox28.Text > 6 Or TextBox28.Text < 0) Then
                        TextBox28.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox28.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox28.Text) Then
                    sudoku(4, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox28.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox28.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox28.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox28.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox28.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox28.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox28.Text
                    sudoku(4, 3) = TextBox28.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox28.ReadOnly = False
                    box = 28
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged
        Label1.Text = ""
        If (TextBox29.Text = "") Then
            sudoku(4, 4) = 0
        End If
        If (TextBox29.Text = "0") Then
            TextBox29.Text = ""

        End If
        If (TextBox29.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox35.BackColor = Color.White

            TextBox34.BackColor = Color.White
            TextBox36.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox29.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox29.Text)) Then
                    If (TextBox29.Text > 6 Or TextBox29.Text < 0) Then
                        TextBox29.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox29.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox29.Text) Then
                    sudoku(4, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox29.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox29.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox29.Text = sudoku(i, 4)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox29.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox29.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox29.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox29.Text
                    sudoku(4, 4) = TextBox29.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox29.ReadOnly = False
                    box = 29
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        Label1.Text = ""
        If (TextBox30.Text = "") Then
            sudoku(4, 5) = 0
        End If
        If (TextBox30.Text = "0") Then
            TextBox30.Text = ""

        End If
        If (TextBox30.ReadOnly = False) Then
Line1:

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White
            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox6.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox24.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox30.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox30.Text)) Then
                    If (TextBox30.Text > 6 Or TextBox30.Text < 0) Then
                        TextBox30.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox30.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox30.Text) Then
                    sudoku(4, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox30.Text = sudoku(4, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox30.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox30.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox30.Text = sudoku(i, 5)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox30.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox30.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox30.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox30.Text
                    sudoku(4, 5) = TextBox30.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox30.ReadOnly = False
                    box = 30
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox31_TextChanged(sender As Object, e As EventArgs) Handles TextBox31.TextChanged
        Label1.Text = ""
        If (TextBox31.Text = "") Then
            sudoku(5, 0) = 0
        End If
        If (TextBox31.Text = "0") Then
            TextBox31.Text = ""

        End If
        If (TextBox31.ReadOnly = False) Then
Line1:

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox1.BackColor = Color.White
            TextBox7.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox25.BackColor = Color.White

            TextBox26.BackColor = Color.White
            TextBox27.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox31.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox31.Text)) Then
                    If (TextBox31.Text > 6 Or TextBox31.Text < 0) Then
                        TextBox31.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox31.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox31.Text) Then
                    sudoku(5, 0) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox31.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox31.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox31.Text = sudoku(i, 0)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox31.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox1.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox7.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox13.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox19.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox25.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox31.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox31.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox31.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox31.Text
                    sudoku(5, 0) = TextBox31.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox31.ReadOnly = False
                    box = 31
                    Timer1.Start()

                End If
            End If

        End If
    End Sub




    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged
        Label1.Text = ""
        If (TextBox32.Text = "") Then
            sudoku(5, 1) = 0
        End If
        If (TextBox32.Text = "0") Then
            TextBox32.Text = ""

        End If
        If (TextBox32.ReadOnly = False) Then
Line1:

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox2.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox20.BackColor = Color.White
            TextBox26.BackColor = Color.White

            TextBox25.BackColor = Color.White
            TextBox27.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox32.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox32.Text)) Then
                    If (TextBox32.Text > 6 Or TextBox32.Text < 0) Then
                        TextBox32.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox32.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox32.Text) Then
                    sudoku(5, 1) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox32.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox32.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox32.Text = sudoku(i, 1)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox32.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox2.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox8.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox14.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox20.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox26.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox32.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox32.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox32.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox32.Text
                    sudoku(5, 1) = TextBox32.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox32.ReadOnly = False
                    box = 32
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged
        Label1.Text = ""
        If (TextBox33.Text = "") Then
            sudoku(5, 2) = 0
        End If
        If (TextBox33.Text = "0") Then
            TextBox33.Text = ""

        End If
        If (TextBox33.ReadOnly = False) Then
Line1:

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox3.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox15.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox27.BackColor = Color.White

            TextBox25.BackColor = Color.White
            TextBox26.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox33.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox33.Text)) Then
                    If (TextBox33.Text > 6 Or TextBox33.Text < 0) Then
                        TextBox33.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox33.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox33.Text) Then
                    sudoku(5, 2) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox33.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox33.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox33.Text = sudoku(i, 2)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox33.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox3.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox9.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox15.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox21.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox27.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox33.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 0 To 2
                            If (TextBox33.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox33.BackColor = Color.Red

                                If (i = 4 And j = 0) Then
                                    TextBox25.BackColor = Color.Red
                                ElseIf (i = 4 And j = 1) Then
                                    TextBox26.BackColor = Color.Red
                                ElseIf (i = 4 And j = 2) Then
                                    TextBox27.BackColor = Color.Red
                                ElseIf (i = 5 And j = 0) Then
                                    TextBox31.BackColor = Color.Red
                                ElseIf (i = 5 And j = 1) Then
                                    TextBox32.BackColor = Color.Red
                                ElseIf (i = 5 And j = 2) Then
                                    TextBox33.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox33.Text
                    sudoku(5, 2) = TextBox33.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox33.ReadOnly = False
                    box = 33
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs) Handles TextBox34.TextChanged
        Label1.Text = ""
        If (TextBox34.Text = "") Then
            sudoku(5, 3) = 0
        End If
        If (TextBox34.Text = "0") Then
            TextBox34.Text = ""

        End If
        If (TextBox34.ReadOnly = False) Then
Line1:

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox4.BackColor = Color.White
            TextBox10.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox28.BackColor = Color.White

            TextBox29.BackColor = Color.White
            TextBox30.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox34.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox34.Text)) Then
                    If (TextBox34.Text > 6 Or TextBox34.Text < 0) Then
                        TextBox34.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox34.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox34.Text) Then
                    sudoku(5, 3) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox34.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox34.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox34.Text = sudoku(i, 3)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox34.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox4.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox10.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox16.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox22.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox28.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox34.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox34.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox34.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox34.Text
                    sudoku(5, 3) = TextBox34.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox34.ReadOnly = False
                    box = 34
                    Timer1.Start()

                End If
            End If

        End If
    End Sub


    Private Sub TextBox35_TextChanged(sender As Object, e As EventArgs) Handles TextBox35.TextChanged
        Label1.Text = ""
        If (TextBox35.Text = "") Then
            sudoku(5, 4) = 0
        End If
        If (TextBox35.Text = "0") Then
            TextBox35.Text = ""

        End If
        If (TextBox35.ReadOnly = False) Then
Line1:

            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox5.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox17.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox29.BackColor = Color.White

            TextBox28.BackColor = Color.White
            TextBox30.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox35.Text <> "") Then
                Time = 0
                If (IsNumeric(TextBox35.Text)) Then
                    If (TextBox35.Text > 6 Or TextBox35.Text < 0) Then
                        TextBox35.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox35.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox35.Text) Then
                    sudoku(5, 4) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox35.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox35.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox35.Text = sudoku(i, 4)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox35.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox5.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox11.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox17.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox23.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox29.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox35.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox35.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox35.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox35.Text
                    sudoku(5, 4) = TextBox35.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox35.ReadOnly = False
                    box = 35
                    Timer1.Start()

                End If
            End If

        End If
    End Sub



    Private Sub TextBox36_TextChanged(sender As Object, e As EventArgs) Handles TextBox36.TextChanged
        Label1.Text = ""
        If (TextBox35.Text = "") Then
            sudoku(5, 5) = 0
        End If
        If (TextBox36.Text = "0") Then
            TextBox36.Text = ""

        End If
        If (TextBox36.ReadOnly = False) Then
Line1:
            Time = 0
            TextBox31.BackColor = Color.White
            TextBox32.BackColor = Color.White
            TextBox33.BackColor = Color.White
            TextBox34.BackColor = Color.White
            TextBox35.BackColor = Color.White
            TextBox36.BackColor = Color.White

            TextBox6.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox24.BackColor = Color.White
            TextBox30.BackColor = Color.White

            TextBox28.BackColor = Color.White
            TextBox29.BackColor = Color.White


            Dim counter = 3
            Dim change = 0
            Dim a As Integer

            If (TextBox36.Text <> "") Then

                If (IsNumeric(TextBox36.Text)) Then
                    If (TextBox36.Text > 6 Or TextBox36.Text < 0) Then
                        TextBox36.Text = ""
                        Label1.Text = "Enter Proper number Between 1 To 6"
                        GoTo Line1
                    End If
                Else
                    TextBox36.Text = ""
                    Label1.Text = "Enter Only number Between 1 To 6"
                    GoTo Line1
                End If
                If (a <> TextBox36.Text) Then
                    sudoku(5, 5) = 0
                End If
                Label1.Text = ""
                For i = 0 To 5

                    If (TextBox36.Text = sudoku(5, i)) Then
                        counter = 1

                        Label1.Text = "Found in Row"
                        TextBox36.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox31.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox32.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox33.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox34.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox35.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                    End If

                    If (TextBox36.Text = sudoku(i, 5)) Then
                        Label1.Text = Label1.Text & " & Found in Column"
                        TextBox36.BackColor = Color.Red
                        If (i = 0) Then
                            TextBox6.BackColor = Color.Red
                        ElseIf (i = 1) Then
                            TextBox12.BackColor = Color.Red
                        ElseIf (i = 2) Then
                            TextBox18.BackColor = Color.Red
                        ElseIf (i = 3) Then
                            TextBox24.BackColor = Color.Red
                        ElseIf (i = 4) Then
                            TextBox30.BackColor = Color.Red
                        ElseIf (i = 5) Then
                            TextBox36.BackColor = Color.Red
                        End If
                        counter = 1

                    End If
                Next
                If (counter = 3 Or counter = 1) Then
                    For i = 4 To 5
                        For j = 3 To 5
                            If (TextBox36.Text = sudoku(i, j)) Then
                                counter = 1
                                Label1.Text = Label1.Text & " & Found in Grid"
                                TextBox36.BackColor = Color.Red

                                If (i = 4 And j = 3) Then
                                    TextBox28.BackColor = Color.Red
                                ElseIf (i = 4 And j = 4) Then
                                    TextBox29.BackColor = Color.Red
                                ElseIf (i = 4 And j = 5) Then
                                    TextBox30.BackColor = Color.Red
                                ElseIf (i = 5 And j = 3) Then
                                    TextBox34.BackColor = Color.Red
                                ElseIf (i = 5 And j = 4) Then
                                    TextBox35.BackColor = Color.Red
                                ElseIf (i = 5 And j = 5) Then
                                    TextBox36.BackColor = Color.Red
                                End If
                            End If
                        Next j
                    Next i
                End If
                If (counter <> 1) Then
                    a = TextBox36.Text
                    sudoku(5, 5) = TextBox36.Text
                    Label1.Text = "GOOD"
                    submit()
                ElseIf (counter = 1) Then
                    TextBox36.ReadOnly = False
                    box = 36
                    Timer1.Start()

                End If
            End If

        End If
    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (box = 1) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox1.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 2) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox2.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 3) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox3.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 4) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox4.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 5) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox5.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 6) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox6.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 7) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox7.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 8) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox8.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 9) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox9.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 10) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox10.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 11) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox11.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 12) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox12.Text = ""
                Time = 0
            End If
        ElseIf (box = 13) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox13.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 14) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox14.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 15) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox15.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 16) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox16.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 17) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox17.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 18) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox18.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 19) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox19.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 20) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox20.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 21) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox21.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 22) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox22.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 23) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox23.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 24) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox24.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 25) Then
            Time = Time + 1
            If (Time = 70) Then
                Timer1.Stop()
                box = 0
                TextBox25.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 26) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox26.Text = ""
                Time = 0
            End If
        ElseIf (box = 27) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox27.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 28) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox28.Text = ""
                Time = 0
            End If
        ElseIf (box = 29) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox26.Text = ""
                Time = 0
            End If
        ElseIf (box = 30) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox30.Text = ""
                Time = 0
            End If
        ElseIf (box = 31) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox31.Text = ""
                Time = 0
            End If
        ElseIf (box = 32) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox32.Text = ""
                Time = 0
            End If
        ElseIf (box = 33) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox33.Text = ""
                Time = 0
            End If
        ElseIf (box = 34) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                Label1.Text = ""
                TextBox34.Text = ""
                Time = 0
            End If
        ElseIf (box = 35) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox35.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        ElseIf (box = 36) Then
            Time = Time + 1
            If (Time = 40) Then
                Timer1.Stop()
                box = 0
                TextBox36.Text = ""
                Label1.Text = ""
                Time = 0
            End If
        End If

        If (box = 100) Then
            Button8.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label11.Visible = False
            GroupBox1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            PictureBox1.Visible = False
            Label1.Text = ""
            Label2.Text = ""
            PictureBox2.Location = New Point(373, 150)
            PictureBox2.Size = New Point(1000, 1000)

            PictureBox2.Image = My.Resources.thanks
            PictureBox2.Visible = True

            Time = Time + 1
            If (Time = 25) Then
                Me.Close()
            End If

        End If

        If (box = 200) Then
            Time = Time + 1
            If (Time = 50) Then
                Timer1.Stop()
                Time = 0
                Label3.Visible = True
                PictureBox1.Image = My.Resources.logo
                PictureBox2.Location = New Point(373, 323)
                Label4.Visible = True
                Label5.Visible = True
                Label11.Visible = True
                Button5.Visible = True
                Time = 0
            End If

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        stage = 1
        Button2.Visible = True
        level = 1
        Label2.Text = "Easy"
        Button5.Visible = False


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        stage = 2
        Button2.Visible = True
        level = 1
        Label2.Text = "Medium"
        Button5.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        stage = 3
        Button2.Visible = True
        Button5.Visible = False
        level = 1
        Label2.Text = "Difficult"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        Label1.Text = ""
        Label1.Visible = True
        Button6.Visible = True
        Button8.Visible = True
        Button7.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        PictureBox2.Visible = False
        GroupBox1.Visible = True
        Button2.Text = "Restart"
        Button3.Visible = True
        If (stage = 1) Then
            If (level = 1) Then
                Label2.Text = "Easy Level :  " & level
                Dim a1(,) As Integer = {{0, 2, 0, 0, 1, 0}, {5, 6, 1, 0, 0, 0}, {0, 0, 2, 4, 0, 6}, {3, 0, 0, 0, 5, 1}, {2, 1, 4, 5, 6, 3}, {0, 0, 5, 0, 2, 0}}
                Dim sudoku1(,) As Integer = {{0, 2, 0, 0, 1, 0}, {5, 6, 1, 0, 0, 0}, {0, 0, 2, 4, 0, 6}, {3, 0, 0, 0, 5, 1}, {2, 1, 4, 5, 6, 3}, {0, 0, 5, 0, 2, 0}}
                Dim sudokuan1(,) As Integer = {{4, 2, 3, 6, 1, 5}, {5, 6, 1, 3, 4, 2}, {1, 5, 2, 4, 3, 6}, {3, 4, 6, 2, 5, 1}, {2, 1, 4, 5, 6, 3}, {6, 3, 5, 1, 2, 4}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 2) Then
                Label2.Text = "Easy  Level :  " & level
                Dim a1(,) As Integer = {{3, 0, 0, 0, 5, 0}, {0, 0, 2, 3, 0, 0}, {0, 2, 0, 0, 4, 0}, {0, 4, 0, 5, 0, 0}, {2, 0, 1, 0, 0, 0}, {0, 0, 0, 0, 0, 3}}
                Dim sudoku1(,) As Integer = {{3, 0, 0, 0, 5, 0}, {0, 0, 2, 3, 0, 0}, {0, 2, 0, 0, 4, 0}, {0, 4, 0, 5, 0, 0}, {2, 0, 1, 0, 0, 0}, {0, 0, 0, 0, 0, 3}}
                Dim sudokuan1(,) As Integer = {{3, 1, 4, 2, 5, 6}, {6, 5, 2, 3, 1, 4}, {5, 2, 3, 6, 4, 1}, {1, 4, 6, 5, 3, 2}, {2, 3, 1, 4, 6, 5}, {4, 6, 5, 1, 2, 3}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 3) Then
                Label2.Text = "Easy Level :  " & level
                Dim a1(,) As Integer = {{0, 0, 2, 6, 0, 0}, {4, 1, 0, 0, 3, 5}, {0, 5, 0, 0, 0, 6}, {0, 6, 1, 0, 2, 4}, {6, 0, 0, 1, 0, 0}, {0, 2, 5, 0, 0, 3}}
                Dim sudoku1(,) As Integer = {{0, 0, 2, 6, 0, 0}, {4, 1, 0, 0, 3, 5}, {0, 5, 0, 0, 0, 6}, {0, 6, 1, 0, 2, 4}, {6, 0, 0, 1, 0, 0}, {0, 2, 5, 0, 0, 3}}
                Dim sudokuan1(,) As Integer = {{5, 3, 2, 6, 4, 1}, {4, 1, 6, 2, 3, 5}, {2, 5, 4, 3, 1, 6}, {3, 6, 1, 5, 2, 4}, {6, 4, 3, 1, 5, 2}, {1, 2, 5, 4, 6, 3}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 4) Then
                Label2.Text = "Easy Level :  " & level
                Dim a1(,) As Integer = {{6, 0, 0, 0, 0, 2}, {0, 0, 5, 0, 1, 3}, {0, 0, 1, 0, 3, 0}, {0, 0, 2, 0, 6, 0}, {0, 0, 4, 0, 2, 6}, {3, 0, 0, 0, 0, 4}}
                Dim sudoku1(,) As Integer = {{6, 0, 0, 0, 0, 2}, {0, 0, 5, 0, 1, 3}, {0, 0, 1, 0, 3, 0}, {0, 0, 2, 0, 6, 0}, {0, 0, 4, 0, 2, 6}, {3, 0, 0, 0, 0, 4}}
                Dim sudokuan1(,) As Integer = {{6, 1, 3, 2, 4, 2}, {2, 4, 5, 6, 1, 3}, {4, 6, 1, 2, 3, 5}, {5, 3, 2, 4, 6, 1}, {1, 5, 4, 3, 2, 6}, {3, 2, 6, 1, 5, 4}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 5) Then
                Label2.Text = "Easy Level :  " & level
                Dim a1(,) As Integer = {{0, 4, 0, 0, 0, 0}, {3, 0, 0, 5, 0, 0}, {0, 0, 1, 0, 0, 2}, {0, 6, 0, 0, 0, 3}, {0, 0, 0, 0, 0, 0}, {0, 0, 2, 4, 0, 1}}
                Dim sudoku1(,) As Integer = {{0, 4, 0, 0, 0, 0}, {3, 0, 0, 5, 0, 0}, {0, 0, 1, 0, 0, 2}, {0, 6, 0, 0, 0, 3}, {0, 0, 0, 0, 0, 0}, {0, 0, 2, 4, 0, 1}}
                Dim sudokuan1(,) As Integer = {{1, 4, 5, 3, 2, 6}, {3, 2, 6, 5, 1, 4}, {5, 3, 1, 6, 4, 2}, {2, 6, 4, 1, 5, 3}, {4, 1, 3, 2, 6, 5}, {6, 5, 2, 4, 3, 1}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            Else
                level = 1
                Button2_Click(sender, e)
            End If
        ElseIf (stage = 2) Then
            If (level = 1) Then
                Label2.Text = "Medium Level :  " & level
                Dim a1(,) As Integer = {{2, 0, 0, 0, 0, 0}, {0, 3, 0, 2, 0, 0}, {6, 0, 5, 4, 0, 0}, {0, 0, 4, 0, 0, 2}, {0, 0, 0, 0, 2, 5}, {0, 5, 0, 6, 4, 0}}
                Dim sudoku1(,) As Integer = {{2, 0, 0, 0, 0, 0}, {0, 3, 0, 2, 0, 0}, {6, 0, 5, 4, 0, 0}, {0, 0, 4, 0, 0, 2}, {0, 0, 0, 0, 2, 5}, {0, 5, 0, 6, 4, 0}}
                Dim sudokuan1(,) As Integer = {{2, 4, 1, 3, 5, 6}, {5, 3, 6, 2, 1, 4}, {6, 2, 5, 4, 3, 1}, {3, 1, 4, 5, 6, 2}, {4, 6, 3, 1, 2, 5}, {1, 5, 2, 6, 4, 3}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 2) Then
                Label2.Text = "Medium Level :  " & level
                Dim a1(,) As Integer = {{0, 6, 0, 0, 0, 1}, {2, 0, 5, 0, 0, 0}, {0, 5, 0, 1, 0, 0}, {0, 0, 4, 6, 0, 0}, {0, 0, 0, 0, 0, 2}, {6, 0, 0, 0, 1, 0}}
                Dim sudoku1(,) As Integer = {{0, 6, 0, 0, 0, 1}, {2, 0, 5, 0, 0, 0}, {0, 5, 0, 1, 0, 0}, {0, 0, 4, 6, 0, 0}, {0, 0, 0, 0, 0, 2}, {6, 0, 0, 0, 1, 0}}
                Dim sudokuan1(,) As Integer = {{4, 6, 3, 2, 5, 1}, {2, 1, 5, 3, 4, 6}, {3, 5, 6, 1, 2, 4}, {1, 2, 4, 6, 3, 5}, {5, 3, 1, 4, 6, 2}, {6, 4, 2, 5, 1, 3}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 3) Then
                Label2.Text = "Mediun Level :  " & level
                Dim a1(,) As Integer = {{2, 0, 0, 0, 0, 4}, {0, 1, 5, 6, 2, 0}, {0, 2, 0, 0, 1, 0}, {0, 5, 0, 0, 3, 0}, {0, 6, 3, 2, 4, 0}, {5, 0, 0, 0, 0, 1}}
                Dim sudoku1(,) As Integer = {{2, 0, 0, 0, 0, 4}, {0, 1, 5, 6, 2, 0}, {0, 2, 0, 0, 1, 0}, {0, 5, 0, 0, 3, 0}, {0, 6, 3, 2, 4, 0}, {5, 0, 0, 0, 0, 1}}
                Dim sudokuan1(,) As Integer = {{2, 3, 6, 1, 5, 4}, {4, 1, 5, 6, 2, 3}, {3, 2, 4, 5, 1, 6}, {6, 5, 1, 4, 3, 2}, {1, 6, 3, 2, 4, 5}, {5, 4, 2, 3, 6, 1}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            Else
                level = 1
                Button2_Click(sender, e)
            End If
        ElseIf (stage = 3) Then
            If (level = 1) Then
                Label2.Text = "Difficult Level :  " & level
                Dim a1(,) As Integer = {{0, 4, 1, 0, 5, 0}, {0, 0, 0, 0, 0, 0}, {4, 0, 0, 1, 0, 3}, {3, 0, 0, 5, 0, 2}, {0, 0, 0, 0, 0, 0}, {0, 6, 3, 0, 1, 0}}
                Dim sudoku1(,) As Integer = {{0, 4, 1, 3, 5, 6}, {6, 3, 5, 4, 2, 1}, {4, 5, 2, 1, 6, 3}, {3, 1, 6, 5, 4, 2}, {1, 2, 4, 6, 3, 5}, {5, 6, 3, 2, 1, 4}}
                Dim sudokuan1(,) As Integer = {{2, 4, 1, 3, 5, 6}, {6, 3, 5, 4, 2, 1}, {4, 5, 2, 1, 6, 3}, {3, 1, 6, 5, 4, 2}, {1, 2, 4, 6, 3, 5}, {5, 6, 3, 2, 1, 4}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 2) Then
                Label2.Text = "Difficult Level :  " & level
                Dim a1(,) As Integer = {{0, 1, 5, 6, 0, 2}, {0, 0, 0, 0, 3, 0}, {0, 2, 0, 0, 0, 0}, {6, 0, 4, 0, 0, 0}, {0, 0, 1, 2, 0, 0}, {0, 0, 0, 0, 0, 6}}
                Dim sudoku1(,) As Integer = {{0, 1, 5, 6, 0, 2}, {0, 0, 0, 0, 3, 0}, {0, 2, 0, 0, 0, 0}, {6, 0, 4, 0, 0, 0}, {0, 0, 1, 2, 0, 0}, {0, 0, 0, 0, 0, 6}}
                Dim sudokuan1(,) As Integer = {{3, 1, 5, 6, 4, 2}, {2, 4, 6, 1, 3, 5}, {1, 2, 3, 5, 6, 4}, {6, 5, 4, 3, 2, 1}, {4, 6, 1, 2, 5, 3}, {5, 3, 2, 4, 1, 6}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            ElseIf (level = 3) Then

                Label2.Text = "Difficult Level :  " & level
                Dim a1(,) As Integer = {{0, 0, 0, 0, 0, 0}, {0, 0, 2, 0, 1, 0}, {0, 0, 0, 0, 0, 0}, {0, 2, 0, 5, 0, 4}, {0, 3, 0, 0, 0, 5}, {0, 5, 6, 0, 0, 3}}
                Dim sudoku1(,) As Integer = {{0, 0, 0, 0, 0, 0}, {0, 0, 2, 0, 1, 0}, {0, 0, 0, 0, 0, 0}, {0, 2, 0, 5, 0, 4}, {0, 3, 0, 0, 0, 5}, {0, 5, 6, 0, 0, 3}}
                Dim sudokuan1(,) As Integer = {{6, 1, 3, 4, 5, 2}, {5, 4, 2, 3, 1, 6}, {4, 6, 5, 2, 3, 1}, {3, 2, 1, 5, 6, 4}, {1, 3, 4, 6, 2, 5}, {2, 5, 6, 1, 4, 3}}
                For i = 0 To 5
                    For j = 0 To 5
                        a(i, j) = a1(i, j)
                        sudoku(i, j) = sudoku1(i, j)
                        sudokuan(i, j) = sudokuan1(i, j)
                    Next j
                Next i
            Else
                level = 1
                Button2_Click(sender, e)
            End If



        Else
            Button1.Text = "Start"
            MessageBox.Show("First select level of game")
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True

        End If

        Button1_Click(sender, e)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button8.Visible = False
        Label1.Visible = False
        Dim done As Integer = 0
        For i = 0 To 5
            For j = 0 To 5
                If (sudoku(i, j) = "0") Then
                    Label1.Text = "Comple all then click on submit"
                    done = 1
                End If

            Next
        Next

        If (done = 0) Then

            GroupBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox2.Image = My.Resources.complete
            PictureBox2.Location = New Point(440, 250)
            PictureBox2.Size = New Point(491, 243)


            Button6.Visible = True
            Button2.Visible = False
            Button4.Visible = True
            level = level + 1
            Button7.Visible = True

        End If
        Button3.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = ""
        Label2.Text = ""
        Button6.Visible = False
        Button2_Click(sender, e)
        Button4.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox2.Image = My.Resources.First
        PictureBox2.Location = New Point(400, 150)
        box = 200
        Timer1.Start()




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PictureBox2.Visible = False
        stage = 0
        level = 0
        GroupBox1.Visible = False
        Button5_Click(sender, e)
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Label2.Text = " "
        Label1.Text = " "
        Button2.Visible = False
        Button4.Visible = False
        Button6.Visible = False
        Button3.Visible = False
        Button2.Text = "Start Game"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        box = 100
        Timer1.Start()
    End Sub

    Sub submit()

        If (box <> 500) Then
            Dim done As Integer = 0
            For i = 0 To 5
                For j = 0 To 5
                    If (sudoku(i, j) = "0") Then
                        done = 1
                    End If

                Next
            Next

            If (done = 0) Then
                Label1.Text = ""
                Button8.Visible = False
                GroupBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox2.Image = My.Resources.complete
                PictureBox2.Location = New Point(440, 250)
                PictureBox2.Size = New Point(491, 243)


                Button6.Visible = True
                Button2.Visible = False
                Button4.Visible = True
                level = level + 1
                Button7.Visible = True
                Button3.Visible = False

            Else
                Button8.Visible = True
            End If


        End If

    End Sub
    Private Sub GroupBox1_Paint(sender As Object, e As PaintEventArgs) Handles GroupBox1.Paint
        e.Graphics.DrawLine(Pens.Black, 78, 10, 78, 370)
        e.Graphics.DrawLine(Pens.Black, 147, 10, 147, 370)
        e.Graphics.DrawLine(Pens.Black, 300, 10, 300, 370)
        e.Graphics.DrawLine(Pens.Black, 370, 10, 370, 370)

        e.Graphics.DrawLine(Pens.Black, 2, 65, 500, 65)
        e.Graphics.DrawLine(Pens.Black, 2, 192, 500, 192)
        e.Graphics.DrawLine(Pens.Black, 2, 312, 500, 312)


        'e.Graphics.DrawLine(Pens.Black, 205, 15, 205, 358)


        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen
        myPen = New Pen(Brushes.Black, 5)
        e.Graphics.DrawLine(myPen, 4, 10, 4, 370)
        e.Graphics.DrawLine(myPen, 222, 10, 222, 370)
        e.Graphics.DrawLine(myPen, 440, 10, 440, 370)
        e.Graphics.DrawLine(myPen, 2, 7, 500, 7)
        e.Graphics.DrawLine(myPen, 2, 130, 500, 130)
        e.Graphics.DrawLine(myPen, 2, 253, 500, 253)
        e.Graphics.DrawLine(myPen, 2, 370, 500, 370)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        box = 500

        Button3.Visible = False
        TextBox1.Text = sudokuan(0, 0)
        TextBox2.Text = sudokuan(0, 1)
        TextBox3.Text = sudokuan(0, 2)
        TextBox4.Text = sudokuan(0, 3)
        TextBox5.Text = sudokuan(0, 4)
        TextBox6.Text = sudokuan(0, 5)

        TextBox7.Text = sudokuan(1, 0)
        TextBox8.Text = sudokuan(1, 1)
        TextBox9.Text = sudokuan(1, 2)
        TextBox10.Text = sudokuan(1, 3)
        TextBox11.Text = sudokuan(1, 4)
        TextBox12.Text = sudokuan(1, 5)

        TextBox13.Text = sudokuan(2, 0)
        TextBox14.Text = sudokuan(2, 1)
        TextBox15.Text = sudokuan(2, 2)
        TextBox16.Text = sudokuan(2, 3)
        TextBox17.Text = sudokuan(2, 4)
        TextBox18.Text = sudokuan(2, 5)


        TextBox19.Text = sudokuan(3, 0)
        TextBox20.Text = sudokuan(3, 1)
        TextBox21.Text = sudokuan(3, 2)
        TextBox22.Text = sudokuan(3, 3)
        TextBox23.Text = sudokuan(3, 4)
        TextBox24.Text = sudokuan(3, 5)

        TextBox25.Text = sudokuan(4, 0)
        TextBox26.Text = sudokuan(4, 1)
        TextBox27.Text = sudokuan(4, 2)
        TextBox28.Text = sudokuan(4, 3)
        TextBox29.Text = sudokuan(4, 4)
        TextBox30.Text = sudokuan(4, 5)

        TextBox31.Text = sudokuan(5, 0)
        TextBox32.Text = sudokuan(5, 1)
        TextBox33.Text = sudokuan(5, 2)
        TextBox34.Text = sudokuan(5, 3)
        TextBox35.Text = sudokuan(5, 4)
        TextBox36.Text = sudokuan(5, 5)


        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox13.ReadOnly = True
        TextBox14.ReadOnly = True
        TextBox15.ReadOnly = True
        TextBox16.ReadOnly = True
        TextBox17.ReadOnly = True
        TextBox18.ReadOnly = True
        TextBox19.ReadOnly = True
        TextBox20.ReadOnly = True
        TextBox21.ReadOnly = True
        TextBox22.ReadOnly = True
        TextBox23.ReadOnly = True
        TextBox24.ReadOnly = True
        TextBox25.ReadOnly = True
        TextBox26.ReadOnly = True
        TextBox27.ReadOnly = True
        TextBox28.ReadOnly = True
        TextBox29.ReadOnly = True
        TextBox31.ReadOnly = True
        TextBox32.ReadOnly = True
        TextBox33.ReadOnly = True
        TextBox34.ReadOnly = True
        TextBox35.ReadOnly = True
        TextBox36.ReadOnly = True





        level = level + 1
        Button8.Visible = False
        MessageBox.Show("Now you Check Solution for this Problem now problem will change.")
        Button2.Text = "Start"
        Label2.Text = ""
        Label1.Text = ""
    End Sub
End Class