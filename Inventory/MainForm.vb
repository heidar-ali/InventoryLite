Public Class MainForm

    Private Sub BarangToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim formBarang As New FormBarang
        formBarang.MdiParent = Me
        formBarang.Show()
    End Sub

    Private Sub SupplierToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim formSupplier As New FormSupplier
        formSupplier.MdiParent = Me
        formSupplier.Show()
    End Sub

    Private Sub CustomerToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim formCustomers As New FormCustomers
        formCustomers.MdiParent = Me
        formCustomers.Show()
    End Sub

    Private Sub PenerimaanBarangToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles PenerimaanBarangToolStripMenuItem.Click
        Dim listPenerimaanBarang As New ListPenerimaanBarang
        listPenerimaanBarang.MdiParent = Me
        listPenerimaanBarang.Show()
    End Sub

    Friend Sub LoadDataBarang()
        For Each cform In MdiChildren
            If cform.Name = "ListPenerimaanBarang" Then
                CType(cform, ListPenerimaanBarang).ButtonRefreshClick(Nothing, Nothing)
            End If
            If cform.Name = "FormBarang" Then
                CType(cform, FormBarang).LoadData()
            End If
            If cform.Name = "ListPengeluaranBarang" Then
                CType(cform, ListPengeluaranBarang).ButtonRefreshClick(Nothing, Nothing)
            End If
        Next
    End Sub

    Private Sub PengeluaranBarangToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles PengeluaranBarangToolStripMenuItem.Click
        Dim listPengeluaranBarang As New ListPengeluaranBarang
        listPengeluaranBarang.MdiParent = Me
        listPengeluaranBarang.Show()
    End Sub

    Dim dialogLapBulanan As FormDialogMonthReport
    Private Sub LaporanBulananItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim laporan As New FormLaporanBulanan
        laporan.Owner = dialogLapBulanan
        laporan.ViewLaporanHarian(dialogLapBulanan.DateTimePicker1.Value.Date)

    End Sub

    Private Sub ChartBulananItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim laporan As New FormChartBarang
        laporan.Owner = dialogLapBulanan
        laporan.ViewChartBarang(dialogLapBulanan.DateTimePicker1.Value.Date)

    End Sub

    Private Sub LaporanHarianItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim laporan As New FormLaporanHarian
        laporan.Owner = vLaporanHarian
        laporan.ViewLaporanHarian(vLaporanHarian.DateTimePicker1.Value.Date)
    End Sub

    Private Sub OnDialogReportClosed(ByVal sender As Object, ByVal e As EventArgs)
        dialogLapBulanan.Close()
    End Sub

    Private Sub OnDialogReportHarianClosed(ByVal sender As Object, ByVal e As EventArgs)
        vLaporanHarian.Close()
    End Sub

    Private vLaporanHarian As FormDialogTanggalReport
    Private vFormLogin As FormLogin

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.DoEvents()
        vFormLogin = New FormLogin
        AddHandler vFormLogin.FormClosing, AddressOf BeforeFormClosing
        AddHandler vFormLogin.Button2.Click, AddressOf DoLogin
        AddHandler vFormLogin.Button1.Click, AddressOf CancelLogin
        AddHandler vFormLogin.TextBox1.KeyDown, AddressOf OnKeyPressUserName
        AddHandler vFormLogin.TextBox2.KeyDown, AddressOf OnKeyPressPassword
        isExist = True
        vFormLogin.ShowDialog(Me)
    End Sub

    Private Sub OnKeyPressUserName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            vFormLogin.TextBox2.Select()
        End If
    End Sub

    Private Sub OnKeyPressPassword(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DoLogin(sender, Nothing)
        End If
    End Sub

    Private Sub BeforeFormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        e.Cancel = isExist
    End Sub

    Private Sub DoLogin(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If vFormLogin.TextBox1.Text.Equals("admin") And vFormLogin.TextBox2.Text.Equals("admin") Then
            isExist = False
            vFormLogin.Close()

        Else
            MessageBox.Show(vFormLogin, "Login Salah  mohon Periksakan Kembali Username dan Password yang anda masukan", "Login Failed")
        End If
    End Sub

    Dim isExist As Boolean

    Private Sub CancelLogin(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isExist = False
        vFormLogin.Close()
        Application.Exit()
    End Sub

    Private Sub LaporanHarianToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHarianToolStripMenuItem.Click
        vLaporanHarian = New FormDialogTanggalReport
        AddHandler vLaporanHarian.ButtonClose.Click, AddressOf OnDialogReportHarianClosed
        AddHandler vLaporanHarian.ButtonView.Click, AddressOf LaporanHarianItemClick
        vLaporanHarian.Show(Me)
    End Sub

    Private Sub LaporanBulananToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanBulananToolStripMenuItem.Click
        dialogLapBulanan = New FormDialogMonthReport
        dialogLapBulanan.Text = "Parameter Laporan Bulanan"
        AddHandler dialogLapBulanan.ButtonClose.Click, AddressOf OnDialogReportClosed
        AddHandler dialogLapBulanan.ButtonView.Click, AddressOf LaporanBulananItemClick
        dialogLapBulanan.Show(Me)
    End Sub

    Private Sub ChartBulananToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartBulananToolStripMenuItem.Click
        dialogLapBulanan = New FormDialogMonthReport
        dialogLapBulanan.Text = "Parameter Chart Bulanan"
        AddHandler dialogLapBulanan.ButtonClose.Click, AddressOf OnDialogReportClosed
        AddHandler dialogLapBulanan.ButtonView.Click, AddressOf ChartBulananItemClick
        dialogLapBulanan.Show(Me)
    End Sub

    Private Sub KeluarToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim ask = MessageBox.Show(Me, "Tutup aplikasi inventory ?", "Konfirmasi", MessageBoxButtons.YesNo)
        If ask = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
