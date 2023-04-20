Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        With TextBox1
            Dim p As New Pen(If(TextBox1.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox2
            Dim p As New Pen(If(TextBox2.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox3
            Dim p As New Pen(If(TextBox3.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox4
            Dim p As New Pen(If(TextBox4.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox5
            Dim p As New Pen(If(TextBox5.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox6
            Dim p As New Pen(If(TextBox6.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox7
            Dim p As New Pen(If(TextBox7.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox8
            Dim p As New Pen(If(TextBox8.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox9
            Dim p As New Pen(If(TextBox9.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox10
            Dim p As New Pen(If(TextBox10.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox11
            Dim p As New Pen(If(TextBox11.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox12
            Dim p As New Pen(If(TextBox12.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox13
            Dim p As New Pen(If(TextBox13.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox14
            Dim p As New Pen(If(TextBox14.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox15
            Dim p As New Pen(If(TextBox15.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox16
            Dim p As New Pen(If(TextBox16.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox17
            Dim p As New Pen(If(TextBox17.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox18
            Dim p As New Pen(If(TextBox18.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox19
            Dim p As New Pen(If(TextBox19.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
        With TextBox20
            Dim p As New Pen(If(TextBox20.Text <> "", Color.Yellow, Color.Red), 2)
            e.Graphics.DrawRectangle(p, .Left - 1, .Top - 1, .Width + 2, .Height + 2)
            p.Dispose()
        End With
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        Me.Invalidate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ad55 As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(Ad55).Cells("Column1").Value = TextBox1.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column2").Value = TextBox2.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column3").Value = TextBox3.Text
        DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
        Dim totalll As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            totalll += row.Cells("Column3").Value
        Next
        TextBox4.Text = totalll.ToString("0.00")
    End Sub
End Class
