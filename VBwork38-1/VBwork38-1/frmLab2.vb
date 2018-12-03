Public Class frmLab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Vistra, Frista, sumsales, com1, com2, total As Long
        Vistra = txtVistra.Text
        Frista = txtFrista.Text

        com1 = Vistra * 0.05
        com2 = Frista * 0.1
        lblcom1.Text = com1
        lblcom2.Text = com2

        sumsales = Val(txtVistra.Text) + Val(txtFrista.Text)
        total = Val(lblcom1.Text) + Val(lblcom2.Text)
        lbl3.Text = sumsales
        lbl4.Text = total

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
