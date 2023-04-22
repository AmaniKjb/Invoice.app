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
        If TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
        Else
            Dim num1 As Decimal = TextBox9.Text
            Dim num2 As Decimal = TextBox10.Text
            Dim num3 As Decimal = TextBox11.Text
            Dim num4 As Decimal = TextBox12.Text
            Dim ans As Decimal = num1 * num2 * num3 * num4
            TextBox13.Text = (FormatNumber(ans))
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Me.Invalidate()
        If TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
        Else
            Dim num1 As Decimal = TextBox9.Text
            Dim num2 As Decimal = TextBox10.Text
            Dim num3 As Decimal = TextBox11.Text
            Dim num4 As Decimal = TextBox12.Text
            Dim ans As Decimal = num1 * num2 * num3 * num4
            TextBox13.Text = (FormatNumber(ans))
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Me.Invalidate()
        If TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
        Else
            Dim num1 As Decimal = TextBox9.Text
            Dim num2 As Decimal = TextBox10.Text
            Dim num3 As Decimal = TextBox11.Text
            Dim num4 As Decimal = TextBox12.Text
            Dim ans As Decimal = num1 * num2 * num3 * num4
            TextBox13.Text = (FormatNumber(ans))
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Me.Invalidate()
        If TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
        Else
            Dim num1 As Decimal = TextBox9.Text
            Dim num2 As Decimal = TextBox10.Text
            Dim num3 As Decimal = TextBox11.Text
            Dim num4 As Decimal = TextBox12.Text
            Dim ans As Decimal = num1 * num2 * num3 * num4
            TextBox13.Text = (FormatNumber(ans))
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Me.Invalidate()
        If TextBox13.Text = "" Or TextBox14.Text = "" Then
        Else
            Dim num5 As Decimal = TextBox13.Text
            Dim num6 As Decimal = TextBox14.Text
            Dim ans As Decimal = num5 * num6
            TextBox15.Text = (FormatNumber(ans))
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Me.Invalidate()
        If TextBox13.Text = "" Or TextBox14.Text = "" Then
        Else
            Dim num5 As Decimal = TextBox13.Text
            Dim num6 As Decimal = TextBox14.Text
            Dim ans As Decimal = num5 * num6
            TextBox15.Text = (FormatNumber(ans))
        End If
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

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        e.Handled = True
    End Sub
    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ad55 As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(Ad55).Cells("Column1").Value = TextBox6.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column2").Value = TextBox7.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column3").Value = TextBox8.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column4").Value = TextBox9.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column5").Value = TextBox10.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column6").Value = TextBox11.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column7").Value = TextBox12.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column8").Value = TextBox13.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column9").Value = TextBox14.Text
        DataGridView1.Rows.Item(Ad55).Cells("Column10").Value = TextBox15.Text
        DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
        Dim totalll As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            totalll += row.Cells("Column10").Value
        Next
        TextBox20.Text = totalll.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        Dim totalll As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            totalll += row.Cells("Column10").Value
        Next
        TextBox20.Text = totalll.ToString("0.00")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = Date.Today.ToString("dd-MMMM-yyyy")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Customer_Form.Show()
    End Sub
End Class
