﻿Public Class frm_orderlist_a174088
    Private Sub frm_orderlist_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_order.DataSource = run_sql_4_query("SELECT * FROM TBL_ORDER_A174088")
        Me.BackgroundImage = Image.FromFile("wallpaper/b1.jpg")
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub frm_orderlist_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class