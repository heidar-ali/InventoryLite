Imports Inventory.BusinessLogic

Public Class FormSupplier

    Private state As EnumStateRecord

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        SetInputState()
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            Dim core = New SupplierCore
            core.DeleteSupplier(TextBoxKodeSupplier.Text)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Select Case state
            Case EnumStateRecord.Input
                InsertBarang()
            Case EnumStateRecord.Edit
                UpdateBarang()
        End Select
    End Sub

    Private Sub UpdateBarang()
        Try
            Dim core = New SupplierCore
            Dim supplier = New Supplier()
            supplier.Alamat = TextBoxAlamat.Text
            supplier.Email = TextBoxEmail.Text
            supplier.Kode_Supplier = TextBoxKodeSupplier.Text
            supplier.Nama_Supplier = TextBoxNamaSupplier.Text
            supplier.Telepon = TextBoxTelp.Text
            core.UpdateSupplier(supplier)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertBarang()
        Try
            Dim core = New SupplierCore
            Dim supplierModel = New Supplier()
            supplierModel.Alamat = TextBoxAlamat.Text
            supplierModel.Email = TextBoxEmail.Text
            supplierModel.Kode_Supplier = TextBoxKodeSupplier.Text
            supplierModel.Nama_Supplier = TextBoxNamaSupplier.Text
            supplierModel.Telepon = TextBoxTelp.Text
            core.InsertSupplier(supplierModel)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub FormSupplierLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        SetInputState()
    End Sub

    Private Sub SetInputState()
        State = EnumStateRecord.Input
        TextBoxKodeSupplier.ReadOnly = False
        TextBoxKodeSupplier.Select()
        ButtonInput.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
        For Each ctl In FlowLayoutPanelInputContent.Controls
            CType(ctl, TextBox).Text = String.Empty
        Next
    End Sub

    Private Sub LoadData()

        Dim supplierCore As New SupplierCore()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = supplierCore.GetSuppliers()
    End Sub

    Private Sub DataGridView1RowStateChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If e.StateChanged <> DataGridViewElementStates.Selected Then
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            Return
        End If
        TextBoxAlamat.Text = DataGridView1.SelectedRows(0).Cells("Alamat").Value
        TextBoxEmail.Text = DataGridView1.SelectedRows(0).Cells("Email").Value
        TextBoxKodeSupplier.Text = DataGridView1.SelectedRows(0).Cells("Kode_Supplier").Value
        TextBoxNamaSupplier.Text = DataGridView1.SelectedRows(0).Cells("Nama_Supplier").Value
        TextBoxTelp.Text = DataGridView1.SelectedRows(0).Cells("Telepon").Value
        SetEditState()
    End Sub

    Private Sub SetEditState()
        state = EnumStateRecord.Edit
        TextBoxKodeSupplier.ReadOnly = True
        TextBoxKodeSupplier.Select()
        ButtonInput.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub
End Class