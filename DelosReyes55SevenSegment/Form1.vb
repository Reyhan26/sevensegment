Public Class Form1
    Dim seg(25) As PictureBox
    Dim i = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seg(1) = PictureBox1
        seg(2) = PictureBox2
        seg(3) = PictureBox3
        seg(4) = PictureBox4
        seg(5) = PictureBox5
        seg(6) = PictureBox6
        seg(7) = PictureBox7
        seg(8) = PictureBox8
        seg(9) = PictureBox9
        seg(10) = PictureBox10
        seg(11) = PictureBox11
        seg(12) = PictureBox12
        seg(13) = PictureBox13
        seg(14) = PictureBox14
        seg(15) = PictureBox15
        seg(16) = PictureBox16
        seg(17) = PictureBox17
        seg(18) = PictureBox18
        seg(19) = PictureBox19
        seg(20) = PictureBox20
        seg(21) = PictureBox21
        seg(22) = PictureBox22
        seg(23) = PictureBox23
        seg(24) = PictureBox24
        seg(25) = PictureBox25
        Timer1.Start()
        TextBox1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextBox1.Text += 1
        If (TextBox1.Text = 11) Then
            TextBox1.Text = 0
        End If
        If (TextBox1.Text = 1) Then
            For i = 1 To 25
                seg(i).BackColor = Color.Maroon

            Next
            seg(2).BackColor = Color.White
            seg(3).BackColor = Color.White
            seg(4).BackColor = Color.White
            seg(6).BackColor = Color.White
            seg(10).BackColor = Color.White
            seg(11).BackColor = Color.White
            seg(15).BackColor = Color.White
            seg(16).BackColor = Color.White
            seg(20).BackColor = Color.White
            seg(22).BackColor = Color.White
            seg(23).BackColor = Color.White
            seg(24).BackColor = Color.White
        ElseIf TextBox1.Text = 2 Then
            For i = 1 To 25
                seg(i).BackColor = Color.Maroon
            Next
            seg(2).BackColor = Color.White
            seg(3).BackColor = Color.White
            seg(8).BackColor = Color.White
            seg(6).BackColor = Color.White
            seg(13).BackColor = Color.White
            seg(18).BackColor = Color.White
            seg(21).BackColor = Color.White
            seg(22).BackColor = Color.White
            seg(23).BackColor = Color.White
            seg(24).BackColor = Color.White
            seg(25).BackColor = Color.White
        ElseIf TextBox1.Text = 3 Then
            For i = 1 To 25
                seg(i).BackColor = Color.White
            Next
            seg(7).BackColor = Color.Maroon
            seg(8).BackColor = Color.Maroon
            seg(9).BackColor = Color.Maroon
            seg(6).BackColor = Color.Maroon
            seg(20).BackColor = Color.Maroon
            seg(17).BackColor = Color.Maroon
            seg(18).BackColor = Color.Maroon
            seg(19).BackColor = Color.Maroon

        ElseIf TextBox1.Text = 4 Then
            For i = 1 To 25
                seg(i).BackColor = Color.Maroon
            Next
            seg(2).BackColor = Color.White
            seg(3).BackColor = Color.White
            seg(4).BackColor = Color.White
            seg(6).BackColor = Color.White
            seg(10).BackColor = Color.White
            seg(13).BackColor = Color.White
            seg(14).BackColor = Color.White
            seg(16).BackColor = Color.White
            seg(20).BackColor = Color.White
            seg(22).BackColor = Color.White
            seg(23).BackColor = Color.White
            seg(24).BackColor = Color.White
        ElseIf TextBox1.Text = 5 Then
            For i = 1 To 25
                seg(i).BackColor = Color.Maroon
            Next
            seg(3).BackColor = Color.White
            seg(5).BackColor = Color.White
            seg(10).BackColor = Color.White
            seg(7).BackColor = Color.White
            seg(11).BackColor = Color.White
            seg(12).BackColor = Color.White
            seg(13).BackColor = Color.White
            seg(14).BackColor = Color.White
            seg(15).BackColor = Color.White
            seg(11).BackColor = Color.White
            seg(20).BackColor = Color.White
            seg(25).BackColor = Color.White
        ElseIf TextBox1.Text = 6 Then
            For i = 1 To 25
                seg(i).BackColor = Color.White
            Next
            seg(10).BackColor = Color.Maroon
            seg(7).BackColor = Color.Maroon
            seg(8).BackColor = Color.Maroon
            seg(9).BackColor = Color.Maroon
            seg(17).BackColor = Color.Maroon
            seg(18).BackColor = Color.Maroon
            seg(19).BackColor = Color.Maroon
            seg(16).BackColor = Color.Maroon
        ElseIf TextBox1.Text = 7 Then
            For i = 1 To 25
                seg(i).BackColor = Color.White
            Next
            seg(1).BackColor = Color.Maroon
            seg(10).BackColor = Color.Maroon
            seg(7).BackColor = Color.Maroon
            seg(8).BackColor = Color.Maroon
            seg(9).BackColor = Color.Maroon
            seg(17).BackColor = Color.Maroon
            seg(18).BackColor = Color.Maroon
            seg(19).BackColor = Color.Maroon
            seg(21).BackColor = Color.Maroon
            seg(25).BackColor = Color.Maroon
        ElseIf TextBox1.Text = 8 Then
            For i = 1 To 25
                seg(i).BackColor = Color.Maroon
            Next
            seg(1).BackColor = Color.White
            seg(2).BackColor = Color.White
            seg(3).BackColor = Color.White
            seg(4).BackColor = Color.White
            seg(5).BackColor = Color.White
            seg(10).BackColor = Color.White
            seg(14).BackColor = Color.White
            seg(18).BackColor = Color.White
            seg(22).BackColor = Color.White
        ElseIf TextBox1.Text = 9 Then
            For i = 1 To 25
                seg(i).BackColor = Color.White
            Next
            seg(1).BackColor = Color.Maroon
            seg(5).BackColor = Color.Maroon
            seg(7).BackColor = Color.Maroon
            seg(8).BackColor = Color.Maroon
            seg(9).BackColor = Color.Maroon
            seg(17).BackColor = Color.Maroon
            seg(18).BackColor = Color.Maroon
            seg(19).BackColor = Color.Maroon
            seg(21).BackColor = Color.Maroon
            seg(25).BackColor = Color.Maroon
        ElseIf TextBox1.Text = 10 Then
            For i = 1 To 25
                seg(i).BackColor = Color.White
            Next
            seg(7).BackColor = Color.Maroon
            seg(8).BackColor = Color.Maroon
            seg(9).BackColor = Color.Maroon
            seg(17).BackColor = Color.Maroon
            seg(18).BackColor = Color.Maroon
            seg(19).BackColor = Color.Maroon
            seg(16).BackColor = Color.Maroon
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = 0
        For i = 1 To 25
            seg(i).BackColor = Color.Maroon
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
