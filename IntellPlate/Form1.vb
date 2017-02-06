Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Dim errorstext As String = ""
    Dim l1, l2, l3, n1, n2, n3, r1, r2, n As Integer
    Dim l1err, l2err, l3err, n1err, n2err, n3err, r1err, r2err As Integer

    Private Sub BDownload_Click(sender As Object, e As EventArgs) Handles BDownload.Click
        If ListBox1.Items.Count > 0 Then
            If MsgBox("Вы действительно хотите загрузить записи в список?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Download()
            End If
        Else
            Download()
        End If



    End Sub

    Private Sub NUD1l_ValueChanged(sender As Object, e As EventArgs) Handles NUD1l.ValueChanged
        l1 = NUD1l.Value

    End Sub

    Private Sub NUD1n_ValueChanged(sender As Object, e As EventArgs) Handles NUD1n.ValueChanged
        n1 = NUD1n.Value

    End Sub

    Private Sub NUD2n_ValueChanged(sender As Object, e As EventArgs) Handles NUD2n.ValueChanged
        n2 = NUD2n.Value

    End Sub

    Private Sub NUD3n_ValueChanged(sender As Object, e As EventArgs) Handles NUD3n.ValueChanged
        n3 = NUD3n.Value

    End Sub

    Private Sub NUD2l_ValueChanged(sender As Object, e As EventArgs) Handles NUD2l.ValueChanged
        l2 = NUD2l.Value

    End Sub

    Private Sub NUD3l_ValueChanged(sender As Object, e As EventArgs) Handles NUD3l.ValueChanged
        l3 = NUD3l.Value
    End Sub

    Private Sub NUD1r_ValueChanged(sender As Object, e As EventArgs) Handles NUD1r.ValueChanged
        r1 = NUD1r.Value

    End Sub

    Private Sub NUD2r_ValueChanged(sender As Object, e As EventArgs) Handles NUD2r.ValueChanged
        r2 = NUD2r.Value

    End Sub

    Private Sub NUDn_ValueChanged(sender As Object, e As EventArgs) Handles NUDn.ValueChanged
        n = NUDn.Value

    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Function Download()
        Try
            ListBox1.Items.Clear()
            Dim strCn As String = "Server=" & TBServer.Text & ";Database=lprex;User ID=" & TBUser.Text & ";Password=" & TBPass.Text
            Dim cn As New SqlConnection(strCn)
            Dim TimeZone As Date = TimeZone.ToUniversalTime
            Dim dateFrom As String = Format(DateTimePicker1.Value.AddHours(-10), "yyyy-MM-dd HH:mm:ss")
            Dim dateTo As String = Format(DateTimePicker2.Value.AddHours(-10), "yyyy-MM-dd HH:mm:ss")
            Dim cmdstring As String = "SELECT frame_id FROM lprex.dbo.Frames WHERE frame Is Not null And time > '" &
                dateFrom &
                "' and time < '" &
                dateTo &
                "'"                'формат: 2017-01-31 00:00:00'"
            Dim cmd As New SqlCommand(cmdstring, cn)
            Dim dr As SqlDataReader
            Dim sqlAdapter As New SqlDataAdapter
            Dim TABLE As New DataTable
            With sqlAdapter
                .SelectCommand = cmd
                .Fill(TABLE)
            End With
            cn.Open()
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dr.Close()

            For i = 0 To TABLE.Rows.Count - 1
                ListBox1.Items.Add(TABLE(i).Item(0).ToString)
            Next
            LabelCount.Text = "Всего загружено: " & ListBox1.Items.Count
            cn.Close()
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try

    End Function

    Private Sub BFlush_Click(sender As Object, e As EventArgs) Handles BFlush.Click
        If MsgBox("Действительно сбросить все собранные данные по ошибкам?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Flush()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "dd MMMM yyyy HH:mm:ss"
        DateTimePicker2.CustomFormat = "dd MMMM yyyy HH:mm:ss"
        DateTimePicker1.Value = Date.Now.Day & " " & Date.Now.Month & " " & Date.Now.Year & " 00:00:00"
        DateTimePicker2.Value = Date.Now.Day & " " & Date.Now.Month & " " & Date.Now.Year & " 23:59:59"

        Flush()
        'Download()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Dim strCn As String = "Server=" & TBServer.Text & ";Database=lprex;User ID=" & TBUser.Text & ";Password=" & TBPass.Text
            Dim cn As New SqlConnection(strCn)
            Dim cmd As New SqlCommand("SELECT frame_id, frame, time FROM lprex.dbo.Frames WHERE frame_id=" & "'" & ListBox1.SelectedItem.ToString & "'", cn)
            Dim dr As SqlDataReader
            Dim sqlAdapter As New SqlDataAdapter
            cn.Open()
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read Then
                Dim bytBLOBData(dr.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                dr.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                PictureBox1.Image = Image.FromStream(stmBLOBData)
            End If
            dr.Close()
            Dim TABLE As New DataTable
            With sqlAdapter
                .SelectCommand = cmd
                .Fill(TABLE)
            End With
            Dim time As Date = CDate(TABLE(0).Item(2))
            time = time.ToLocalTime 'добавляем ко времени часовой пояс
            TBTime.Text = time

            cn.Close()

            GetNumber(ListBox1.SelectedItem.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)

        End Try
    End Sub
    Function GetNumber(id As String)
        Try
            Dim strCn As String = "Server=" & TBServer.Text & ";Database=lprex;User ID=" & TBUser.Text & ";Password=" & TBPass.Text
            Dim cn As New SqlConnection(strCn)
            Dim cmd As New SqlCommand("select text from [lprex].[dbo].[Numbers] where number_id = (select number_id from [lprex].[dbo].[Plates] where pk = (select plates_id from [lprex].[dbo].[Plate_Numbers] where frame_id = '" & id & "'))", cn)
            Dim dr As SqlDataReader
            Dim sqlAdapter As New SqlDataAdapter
            Dim TABLE As New DataTable
            With sqlAdapter
                .SelectCommand = cmd
                .Fill(TABLE)
            End With
            cn.Open()
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dr.Close()

            TBNumber.Text = TABLE(0).Item(0)

            cn.Close()
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try
    End Function
    Private Sub BNext_Click(sender As Object, e As EventArgs) Handles BNext.Click
        Try
            If ListBox1.Items.Count = 0 Then
                MsgBox("Необходимо загрузить записи о распознанных номерах.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            n = n + 1
            NUDn.Value = n
            If cbletter1.Checked Then l1 = l1 + 1
            If cbletter2.Checked Then l2 = l2 + 1
            If cbletter3.Checked Then l3 = l3 + 1
            If cbnumber1.Checked Then n1 = n1 + 1
            If cbnumber2.Checked Then n2 = n2 + 1
            If cbnumber3.Checked Then n3 = n3 + 1
            If cbregion1.Checked Then r1 = r1 + 1
            If cbregion2.Checked Then r2 = r2 + 1
            NUD1l.Value = l1
            NUD2l.Value = l2
            NUD3l.Value = l3
            NUD1n.Value = n1
            NUD2n.Value = n2
            NUD3n.Value = n3
            NUD1r.Value = r1
            NUD2r.Value = r2

            calculation()
            cbletter1.Checked = False
            cbletter2.Checked = False
            cbletter3.Checked = False
            cbnumber1.Checked = False
            cbnumber2.Checked = False
            cbnumber3.Checked = False
            cbregion1.Checked = False
            cbregion2.Checked = False

            If ListBox1.SelectedIndex = ListBox1.Items.Count - 1 Then
                ListBox1.SelectedIndex = 0
            Else
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        End Try


    End Sub
    Function Flush()
        n = 0
        l1 = 0
        l2 = 0
        l3 = 0
        n1 = 0
        n2 = 0
        n3 = 0
        r1 = 0
        r2 = 0

        NUD1l.Value = l1
        NUD2l.Value = l2
        NUD3l.Value = l3
        NUD1n.Value = n1
        NUD2n.Value = n2
        NUD3n.Value = n3
        NUD1r.Value = r1
        NUD2r.Value = r2
        NUDn.Value = n

        PB1l.Value = 0
        PB1n.Value = 0
        PB1r.Value = 0
        PB2l.Value = 0
        PB2n.Value = 0
        PB2r.Value = 0
        PB3l.Value = 0
        PB3n.Value = 0
        Return 1

    End Function
    Function calculation()
        l1err = l1 / n * 100
        l2err = l2 / n * 100
        l3err = l3 / n * 100
        n1err = n1 / n * 100
        n2err = n2 / n * 100
        n3err = n3 / n * 100
        r1err = r1 / n * 100
        r2err = r2 / n * 100
        PB1l.Value = l1err
        PB1n.Value = n1err
        PB1r.Value = r1err
        PB2l.Value = l2err
        PB2n.Value = n2err
        PB2r.Value = r2err
        PB3l.Value = l3err
        PB3n.Value = n3err

        TextBox1.Text = "Процент ошибок из " & n & ": " & vbCrLf &
            "1-я буква: " & Math.Round(l1err, 2) & "%" & vbCrLf &
            "2-я буква: " & Math.Round(l2err, 2) & "%" & vbCrLf &
            "3-я буква: " & Math.Round(l3err, 2) & "%" & vbCrLf &
            "1-я цифра: " & Math.Round(n1err, 2) & "%" & vbCrLf &
            "2-я цифра: " & Math.Round(n2err, 2) & "%" & vbCrLf &
            "3-я цифра: " & Math.Round(n3err, 2) & "%" & vbCrLf &
            "1-я буква региона: " & Math.Round(r1err, 2) & "%" & vbCrLf &
            "2-я буква региона: " & Math.Round(r2err, 2) & "%"

        Chart()

        Return True


    End Function
    Function Chart()
        Chart1.Series.Clear()
        With Chart1.Series.Add("Мои данные")
            .Points.AddXY("1-я буква", l1err)
            .Points.AddXY("1-я цифра", n1err)
            .Points.AddXY("1-я региона", r1err)
            .Points.AddXY("2-я буква", l2err)
            .Points.AddXY("2-я цифра", n2err)
            .Points.AddXY("2-я региона", r2err)
            .Points.AddXY("3-я буква", l3err)
            .Points.AddXY("3-я цифра", n3err)
            .ChartType = DataVisualization.Charting.SeriesChartType.Pie
        End With
        Return True

    End Function
End Class
