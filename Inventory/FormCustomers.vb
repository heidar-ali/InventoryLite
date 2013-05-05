Imports Inventory.BusinessLogic

Public Class FormCustomers

    Private state As EnumStateRecord

    Private Sub FormCustomersLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
        SetInputState()
    End Sub

    Private Sub LoadData()
        Dim supplierCore As New CustomerCore()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = supplierCore.GetCustomers()
    End Sub

    Private Sub SetInputState()
        state = EnumStateRecord.Input
        TextBoxKodeCustomer.ReadOnly = False
        TextBoxKodeCustomer.Select()
        ButtonInput.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
        For Each ctl In FlowLayoutPanelInputContent.Controls
            CType(ctl, TextBox).Text = String.Empty
        Next
    End Sub

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        SetInputState()
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim core = New CustomerCore
            core.DeleteCustomer(TextBoxKodeCustomer.Text)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSaveClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSave.Click
        Select Case state
            Case EnumStateRecord.Input
                InsertBarang()
            Case EnumStateRecord.Edit
                UpdateBarang()
        End Select
    End Sub

    Private Sub UpdateBarang()
        Try
            Dim core = New CustomerCore
            Dim customer = New Customer()
            customer.Alamat = TextBoxAlamat.Text
            customer.Email = TextBoxEmail.Text
            customer.Kode_Customer = TextBoxKodeCustomer.Text
            customer.Nama_Customer = TextBoxNamaCustomer.Text
            customer.Telephone = TextBoxTelp.Text
            core.UpdateCustomer(customer)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertBarang()
        Try
            Dim core = New CustomerCore
            Dim customer = New Customer()
            customer.Alamat = TextBoxAlamat.Text
            customer.Email = TextBoxEmail.Text
            customer.Kode_Customer = TextBoxKodeCustomer.Text
            customer.Nama_Customer = TextBoxNamaCustomer.Text
            customer.Telephone = TextBoxTelp.Text
            core.InsertCustomer(customer)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
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
        TextBoxKodeCustomer.Text = DataGridView1.SelectedRows(0).Cells("Kode_Customer").Value
        TextBoxNamaCustomer.Text = DataGridView1.SelectedRows(0).Cells("Nama_Customer").Value
        TextBoxTelp.Text = DataGridView1.SelectedRows(0).Cells("Telephone").Value
        SetEditState()
    End Sub

    Private Sub SetEditState()
        state = EnumStateRecord.Edit
        TextBoxKodeCustomer.ReadOnly = True
        TextBoxKodeCustomer.Select()
        ButtonInput.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub
End Class