Imports Inventory.BusinessLogic

Public Class FormBarang

    Private state As EnumStateRecord

    Private Sub FormBarangLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'load data dari database
        LoadData()
        'even jika mengklik row yang ada di datagrid maka akan menjalankan fungsi datagridviewrowstatechanged
        AddHandler DataGridView1.RowStateChanged, AddressOf DataGridViewRowStateChanged
        'ke fungsi inputstate
        SetInputState()
    End Sub

    Friend Sub LoadData()
        'deklarasi kelas barang core
        Dim cbarang As New BarangCore()
        'set data grid view untuk tidak memunculkan kolom yang di generate otomatis
        DataGridView1.AutoGenerateColumns = False
        'data grid view di set data sesuai dengan yang ada di database, bentuk data berbentuk array/list barang
        DataGridView1.DataSource = cbarang.GetBarang()
    End Sub

    Private Sub DataGridViewRowStateChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowStateChangedEventArgs)
        If e.StateChanged <> DataGridViewElementStates.Selected Then
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            Return
        End If
        TextBoxKodeBarang.Text = DataGridView1.SelectedRows(0).Cells("Kode_Barang").Value
        TextBoxNamaBarang.Text = DataGridView1.SelectedRows(0).Cells("Nama_Barang").Value
        NumericTextBoxHargaSatuan.Text = DataGridView1.SelectedRows(0).Cells("Harga_Barang").Value
        NumericTextBoxJumlahStock.Text = DataGridView1.SelectedRows(0).Cells("Stock_Barang").Value
        SetEditState()
    End Sub

    Private Sub SetEditState()
        State = EnumStateRecord.Edit
        TextBoxKodeBarang.ReadOnly = True
        TextBoxKodeBarang.Select()
        ButtonInput.Enabled = True
        ButtonDelete.Enabled = True
        ButtonSave.Enabled = True
    End Sub

    Private Sub SetInputState()
        State = EnumStateRecord.Input
        TextBoxKodeBarang.ReadOnly = False
        TextBoxKodeBarang.Select()
        ButtonInput.Enabled = False
        ButtonDelete.Enabled = False
        ButtonSave.Enabled = True
        For Each ctl In FlowLayoutPanelInputContent.Controls
            CType(ctl, TextBox).Text = String.Empty
        Next
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    
    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInput.Click
        SetInputState()
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            Dim core = New BarangCore
            core.DeleteBarang(TextBoxKodeBarang.Text)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSaveClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Select Case State
            Case EnumStateRecord.Input
                InsertBarang()
            Case EnumStateRecord.Edit
                UpdateBarang()
        End Select
    End Sub

    Private Sub UpdateBarang()

        Try
            Dim core = New BarangCore
            Dim barangModel = New Barang()
            barangModel.Harga_Barang = NumericTextBoxHargaSatuan.Text
            barangModel.Kode_Barang = TextBoxKodeBarang.Text
            barangModel.Nama_Barang = TextBoxNamaBarang.Text
            barangModel.Stock_Barang = NumericTextBoxJumlahStock.Text
            core.UpdateBarang(barangModel)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertBarang()
        Try
            Dim core = New BarangCore
            Dim barangModel = New Barang()
            barangModel.Harga_Barang = NumericTextBoxHargaSatuan.Text
            barangModel.Kode_Barang = TextBoxKodeBarang.Text
            barangModel.Nama_Barang = TextBoxNamaBarang.Text
            barangModel.Stock_Barang = NumericTextBoxJumlahStock.Text
            core.InsertBarang(barangModel)
            LoadData()
            SetInputState()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class