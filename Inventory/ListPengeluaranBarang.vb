Imports Inventory.BusinessLogic

Public Class ListPengeluaranBarang

    Dim currentid As String

    Private Sub ListPengeluaranBarangLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        AddHandler DataGridView1.RowStateChanged, AddressOf OnDataGridViewRowStateChanged
    End Sub

    Private Sub OnDataGridViewRowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs)
        If e.StateChanged <> DataGridViewElementStates.Selected Then
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            Return
        End If
        currentid = DataGridView1.SelectedRows(0).Cells("No_Dokumen").Value
    End Sub

    Public Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        Dim core = New PengeluaranBarangCore
        DataGridView1.DataSource = core.GetPengeluaranBarangs()
    End Sub

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        Dim formPengeluaranBarang As New FormPengeluaranBarang
        formPengeluaranBarang.MdiParent = MainForm
        formPengeluaranBarang.Input()
    End Sub

    Private Sub ButtonEditClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonEdit.Click
        If currentid = "" Then
            Return
        End If
        Dim formPengeluaranBarang As New FormPengeluaranBarang
        formPengeluaranBarang.MdiParent = MainForm
        formPengeluaranBarang.Edit(currentid)
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDelete.Click
        If currentid = "" Then
            Return
        End If
        Dim msg = MessageBox.Show(Me, "Hapus data No Invoice " & currentid & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            Dim core = New PengeluaranBarangCore
            core.DeletePengeluaranBarang(currentid)
            'ButtonRefreshClick(sender, e)
            MainForm.LoadDataBarang()
        End If
    End Sub

    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class