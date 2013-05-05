Imports Inventory.BusinessLogic

Public Class ListPenerimaanBarang

    Dim currentid As String
    Public Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        Dim core = New PenerimaanBarangCore
        DataGridView1.DataSource = core.GetPenerimaanBarang()

    End Sub

    Private Sub OnDataGridViewRowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs)

        If e.StateChanged <> DataGridViewElementStates.Selected Then
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            Return
        End If
        currentid = DataGridView1.SelectedRows(0).Cells("No_Terima").Value
    End Sub

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        Dim formPenerimaanBarang As New FormPenerimaanBarang
        formPenerimaanBarang.MdiParent = MainForm
        formPenerimaanBarang.ListForm = Me
        formPenerimaanBarang.Input()
    End Sub

    Private Sub ButtonEditClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonEdit.Click
        If String.IsNullOrEmpty(currentid) Then
            Return
        End If
        Dim formPenerimaanBarang As New FormPenerimaanBarang
        formPenerimaanBarang.MdiParent = MainForm
        formPenerimaanBarang.ListForm = Me
        formPenerimaanBarang.Edit(currentid)
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If String.IsNullOrEmpty(currentid) Then
            Return
        End If
        'Dim formPenerimaanBarang As New FormPenerimaanBarang
        'formPenerimaanBarang.MdiParent = MainForm
        'formPenerimaanBarang.ListForm = Me
        'formPenerimaanBarang.Delete(currentid)
        Dim msg = MessageBox.Show(Me, String.Format("Hapus data No Terima {0} ?", currentid), "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            Dim core = New PenerimaanBarangCore
            core.DeletePenerimaanBarang(currentid)
            MainForm.LoadDataBarang()
        End If

    End Sub

    Private Sub ListPenerimaanBarangLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        AddHandler DataGridView1.RowStateChanged, AddressOf OnDataGridViewRowStateChanged
    End Sub

    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class