Imports Inventory.BusinessLogic

Public Class FormPengeluaranBarang

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private currentId As String
    Public Sub Input()
        InitInput()
        AddHandler ButtonSave.Click, AddressOf SavePengeluaranBarang
        Show()
    End Sub

    Private Sub SavePengeluaranBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim pengeluaranBarangCore = New PengeluaranBarangCore
        Dim pengeluaranBarangModels = New List(Of PengeluaranBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim pengeluaranBarangModel = New PengeluaranBarangModel
                pengeluaranBarangModel.Tanggal = DateTimePenerimaan.Value.Date
                pengeluaranBarangModel.NoDokumen = TextBoxNoTerima.Text
                pengeluaranBarangModel.KodeCustomer = ComboBoxKodeCustomer.SelectedValue
                pengeluaranBarangModel.KodeBarang = row.Cells("Kode_Barang").Value
                pengeluaranBarangModel.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                pengeluaranBarangModels.Add(pengeluaranBarangModel)
            End If
        Next

        pengeluaranBarangCore.InsertPengeluaranBarang(pengeluaranBarangModels)
        InitInput()
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Private Sub InitInput()
        Text = "Input Pengeluaran Barang"
        DateTimePenerimaan.Value = DateTime.Now
        TextBoxNoTerima.BackColor = Color.Khaki
        LoadComboBarang()
        LoadComboCustomer()
        AddHandler DataGridView1.UserAddedRow, AddressOf DataGridViewUserAddedRow
        AddHandler DataGridView1.UserDeletingRow, AddressOf DataGridViewUserDeletingRow
        AddHandler DataGridView1.RowsAdded, AddressOf DataGridViewRowsAdded
    End Sub

    Private Sub LoadComboCustomer()
        Dim core = New CustomerCore()
        ComboBoxKodeCustomer.DisplayMember = "CustomerKodeName"
        ComboBoxKodeCustomer.ValueMember = "Kode_Customer"
        ComboBoxKodeCustomer.DataSource = core.GetCustomerForCombo()
    End Sub

    Private Sub LoadComboBarang()
        Dim core = New BarangCore()
        Dim kodeBarangCombo = CType(DataGridView1.Columns("Kode_Barang"), DataGridViewComboBoxColumn)
        kodeBarangCombo.DisplayMember = "BarangKodeName"
        kodeBarangCombo.ValueMember = "Kode_Barang"
        kodeBarangCombo.DataSource = core.GetBarangForCombo()
    End Sub

    Public Sub Edit(ByVal id As String)
        AddHandler ButtonSave.Click, AddressOf UpdatePengeluaranBarang
        Show()
        currentId = id
        Text = String.Format("Edit Pengeluaran Barang No {0}", id)
        LoadComboBarang()
        LoadComboCustomer()
        Dim pengeluaranBarangCore = New PengeluaranBarangCore
        Dim tmodel = pengeluaranBarangCore.GetPengeluaranBarang(id)
        TextBoxNoTerima.Text = tmodel.No_Dokumen
        ComboBoxKodeCustomer.SelectedValue = tmodel.Customer.Kode_Customer
        DateTimePenerimaan.Value = tmodel.Tanggal
        DataGridView1.AllowUserToAddRows = True
        'Dim a = New PengeluaranBarangCore
        Dim jPengeluaranBarang = pengeluaranBarangCore.GetPengeluaranBarangs(currentId)

        For Each item In jPengeluaranBarang
            Dim rows = DataGridView1.Rows(DataGridView1.Rows.Add())
            rows.Cells("Crud").Value = item.Crud
            rows.Cells("Kode_Barang").Value = item.KodeBarang
            rows.Cells("Jumlah").Value = item.Jumlah
            rows.Cells("Id").Value = item.Id
            rows.Cells("Harga_Barang").Value = item.HargaBarang
        Next
        AddHandler DataGridView1.UserAddedRow, AddressOf DataGridViewUserAddedRow
        AddHandler DataGridView1.UserDeletingRow, AddressOf DataGridViewUserDeletingRow
        AddHandler DataGridView1.RowsAdded, AddressOf DataGridViewRowsAdded
        AddHandler DataGridView1.CellEndEdit, AddressOf DataGridViewCellEndEdit
    End Sub

    Public Sub Delete(ByVal id As String)
        ButtonSave.Text = "Delete"
        AddHandler ButtonSave.Click, AddressOf DeletePengeluaranBarang
        Show()
        currentId = id
        Text = String.Format("Delete Pengeluaran Barang No {0}", id)
        LoadComboBarang()
        LoadComboCustomer()
        Dim pengeluaranBarangCore = New PengeluaranBarangCore
        Dim tmodel = pengeluaranBarangCore.GetPengeluaranBarang(id)
        TextBoxNoTerima.Text = tmodel.No_Dokumen
        ComboBoxKodeCustomer.SelectedValue = tmodel.Customer.Kode_Customer
        DateTimePenerimaan.Value = tmodel.Tanggal
        DataGridView1.AutoGenerateColumns = False
        Dim a = New PengeluaranBarangCore
        DataGridView1.DataSource = a.GetPengeluaranBarangs(currentId)
       
    End Sub

    Private Sub DeletePengeluaranBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim core = New PengeluaranBarangCore
        Dim vListPengeluaraBarang = New List(Of PengeluaranBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim penerimaanBarang = New PengeluaranBarangModel
                penerimaanBarang.Tanggal = DateTimePenerimaan.Value.Date
                penerimaanBarang.NoDokumen = TextBoxNoTerima.Text
                penerimaanBarang.KodeCustomer = ComboBoxKodeCustomer.SelectedValue
                penerimaanBarang.KodeBarang = row.Cells("Kode_Barang").Value
                penerimaanBarang.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                penerimaanBarang.Crud = Convert.ToInt32(row.Cells("Crud").Value)
                penerimaanBarang.Id = Convert.ToInt32(row.Cells("Id").Value)
                vListPengeluaraBarang.Add(penerimaanBarang)
            End If
        Next
        core.DeletePengeluaranBarang(vListPengeluaraBarang)
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Private Sub UpdatePengeluaranBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim core = New PengeluaranBarangCore
        Dim vListPengeluaraBarang = New List(Of PengeluaranBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim penerimaanBarang = New PengeluaranBarangModel
                penerimaanBarang.Tanggal = DateTimePenerimaan.Value.Date
                penerimaanBarang.NoDokumen = TextBoxNoTerima.Text
                penerimaanBarang.KodeCustomer = ComboBoxKodeCustomer.SelectedValue
                penerimaanBarang.KodeBarang = row.Cells("Kode_Barang").Value
                penerimaanBarang.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                penerimaanBarang.Crud = Convert.ToInt32(row.Cells("Crud").Value)
                penerimaanBarang.Id = Convert.ToInt32(row.Cells("Id").Value)
                vListPengeluaraBarang.Add(penerimaanBarang)
            End If
        Next
        core.UpdatePengeluaranBarang(vListPengeluaraBarang)
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Private Sub DataGridViewUserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs)
        If e.Row.Cells("Crud").Value = 1 Then
            e.Cancel = False
        ElseIf e.Row.Cells("Crud").Value = 0 Or e.Row.Cells("Crud").Value = 2 Then
            e.Row.DefaultCellStyle.BackColor = Color.Red
            e.Row.DefaultCellStyle.ForeColor = Color.WhiteSmoke
            e.Row.Cells("Crud").Value = 3
            e.Cancel = True
        ElseIf e.Row.Cells("Crud").Value = 3 Then
            e.Row.DefaultCellStyle.BackColor = Color.White
            e.Row.DefaultCellStyle.ForeColor = Color.Black
            e.Row.Cells("Crud").Value = 2
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Dim a = DataGridView1.CurrentCell

        If a.ColumnIndex = 3 Then
            AddHandler e.Control.KeyPress, AddressOf OnCellJumlahEdit
        End If
        If a.ColumnIndex = 2 Then
            AddHandler CType(e.Control, ComboBox).SelectedValueChanged, AddressOf OnCellBarangSelectedValue
        End If
    End Sub

    Private Sub OnCellBarangSelectedValue(ByVal sender As Object, ByVal e As EventArgs)
        Dim i = DataGridView1.CurrentRow.Index
        Try
            Dim mbarang = BarangCore.GetBarang(CType(sender, ComboBox).SelectedValue)
            DataGridView1.Rows(i).Cells("Harga_Barang").Value = mbarang.Harga_Barang
        Catch ex As Exception
            DataGridView1.Rows(i).Cells("Harga_Barang").Value = 0
        End Try
    End Sub

    Private Sub OnCellJumlahEdit(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If "X1234567890".IndexOf(e.KeyChar.ToString()) > 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewUserAddedRow(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowEventArgs)
        e.Row.Cells("Crud").Value = 1
    End Sub

    Private Sub DataGridViewCellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs)
        Dim row = DataGridView1.CurrentRow
        If Not row.IsNewRow Then
            If row.Cells("Crud").Value = 0 Then
                row.Cells("Crud").Value = 2
            End If
        End If
    End Sub

    Private Sub DataGridViewRowsAdded(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowsAddedEventArgs)
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        If DataGridView1.CurrentRow.Cells("Crud").Value Is Nothing Then
            DataGridView1.CurrentRow.Cells("Crud").Value = 1
        End If
    End Sub
End Class