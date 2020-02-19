Public Class Form1

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval

            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim index As Byte = 0

        While index < 1
            '0'

            TextBox1.BackColor = Color.Blue
            TextBox2.BackColor = Color.Blue
            TextBox3.BackColor = Color.Blue
            TextBox4.BackColor = Color.Blue
            TextBox5.BackColor = Color.Blue
            TextBox6.BackColor = Color.Blue
            TextBox7.BackColor = Color.White
            TextBox8.BackColor = Color.White
            TextBox9.BackColor = Color.White
            TextBox10.BackColor = Color.Blue
            TextBox11.BackColor = Color.Blue
            TextBox12.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox15.BackColor = Color.Blue
            TextBox16.BackColor = Color.Blue
            TextBox17.BackColor = Color.White
            TextBox18.BackColor = Color.White
            TextBox19.BackColor = Color.White
            TextBox20.BackColor = Color.Blue
            TextBox21.BackColor = Color.Blue
            TextBox22.BackColor = Color.Blue
            TextBox23.BackColor = Color.Blue
            TextBox24.BackColor = Color.Blue
            TextBox25.BackColor = Color.Blue

            '1'
            wait(1000)
            TextBox1.BackColor = Color.White
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox6.BackColor = Color.White
            TextBox11.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            '2'
            wait(1000)
            TextBox1.BackColor = Color.Blue
            TextBox2.BackColor = Color.Blue
            TextBox3.BackColor = Color.Blue
            TextBox4.BackColor = Color.Blue
            TextBox6.BackColor = Color.White
            TextBox11.BackColor = Color.Blue
            TextBox12.BackColor = Color.Blue
            TextBox13.BackColor = Color.Blue
            TextBox14.BackColor = Color.Blue
            TextBox16.BackColor = Color.Blue
            TextBox20.BackColor = Color.White
            TextBox21.BackColor = Color.Blue
            TextBox22.BackColor = Color.Blue
            TextBox23.BackColor = Color.Blue
            TextBox24.BackColor = Color.Blue
            TextBox25.BackColor = Color.Blue

            '3'
            wait(1000)

            TextBox16.BackColor = Color.White
            TextBox20.BackColor = Color.Blue

            '4'
            wait(1000)
            TextBox2.BackColor = Color.White
            TextBox3.BackColor = Color.White
            TextBox4.BackColor = Color.White
            TextBox6.BackColor = Color.Blue
            TextBox11.BackColor = Color.Blue
            TextBox12.BackColor = Color.Blue
            TextBox13.BackColor = Color.Blue
            TextBox14.BackColor = Color.Blue
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            '5'
            wait(1000)
            TextBox2.BackColor = Color.Blue
            TextBox3.BackColor = Color.Blue
            TextBox4.BackColor = Color.Blue
            TextBox10.BackColor = Color.White
            TextBox21.BackColor = Color.Blue
            TextBox22.BackColor = Color.Blue
            TextBox23.BackColor = Color.Blue
            TextBox24.BackColor = Color.Blue

            '6'
            wait(1000)
            TextBox16.BackColor = Color.Blue

            '7'
            wait(1000)
            TextBox6.BackColor = Color.White
            TextBox10.BackColor = Color.Blue
            TextBox11.BackColor = Color.White
            TextBox12.BackColor = Color.White
            TextBox13.BackColor = Color.White
            TextBox14.BackColor = Color.White
            TextBox16.BackColor = Color.White
            TextBox21.BackColor = Color.White
            TextBox22.BackColor = Color.White
            TextBox23.BackColor = Color.White
            TextBox24.BackColor = Color.White

            '8'
            wait(1000)
            TextBox6.BackColor = Color.Blue
            TextBox11.BackColor = Color.Blue
            TextBox12.BackColor = Color.Blue
            TextBox13.BackColor = Color.Blue
            TextBox14.BackColor = Color.Blue
            TextBox16.BackColor = Color.Blue
            TextBox21.BackColor = Color.Blue
            TextBox22.BackColor = Color.Blue
            TextBox23.BackColor = Color.Blue
            TextBox24.BackColor = Color.Blue

            '9'
            wait(1000)
            TextBox16.BackColor = Color.White


            wait(1000)
        End While
    End Sub
End Class
