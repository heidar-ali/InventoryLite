Imports Inventory.BusinessLogic

Public Class FormPenerimaanBarang

    Private currentId As String
    Private currentIndex As Int32

    Public Sub Input()
        InitInput()
        AddHandler ButtonSave.Click, AddressOf SavePenerimaanBarang
        Show()
    End Sub

    Private Sub InitInput()
        Text = "Input Penerimaan Barang"
        DateTimePenerimaan.Value = DateTime.Now
        LoadComboBarang()
        LoadComboSupplier()
        AddHandler DataGridView1.UserAddedRow, AddressOf DataGridViewUserAddedRow
        AddHandler DataGridView1.UserDeletingRow, AddressOf DataGridViewUserDeletingRow
        AddHandler DataGridView1.RowsAdded, AddressOf DataGridViewRowsAdded
    End Sub

    Private Sub LoadComboSupplier()
        Dim core = New SupplierCore()
        ComboBoxKodeSupplier.DisplayMember = "SupplierKodeName"
        ComboBoxKodeSupplier.ValueMember = "Kode_Supplier"
        ComboBoxKodeSupplier.DataSource = core.GetSupplierForCombo()
    End Sub

    Private Sub LoadComboBarang()
        Dim core = New BarangCore()
        Dim kodeBarangCombo = CType(DataGridView1.Columns("Kode_Barang"), DataGridViewComboBoxColumn)
        kodeBarangCombo.DisplayMember = "BarangKodeName"
        kodeBarangCombo.ValueMember = "Kode_Barang"
        kodeBarangCombo.DataSource = core.GetBarangForCombo()
    End Sub

    Private Sub SavePenerimaanBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim core = New PenerimaanBarangCore
        Dim vListPenerimaanBarang = New List(Of PenerimaanBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim penerimaanBarang = New PenerimaanBarangModel
                penerimaanBarang.Tanggal = DateTimePenerimaan.Value.Date
                penerimaanBarang.NoInvoice = TextBoxNoTerima.Text
                penerimaanBarang.KodeSupplier = ComboBoxKodeSupplier.SelectedValue
                penerimaanBarang.KodeBarang = row.Cells("Kode_Barang").Value
                penerimaanBarang.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                vListPenerimaanBarang.Add(penerimaanBarang)
            End If
        Next
        
        core.InsertPenerimaanBarang(vListPenerimaanBarang)
        InitInput()
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Public Sub Edit(ByVal id As String)
        AddHandler ButtonSave.Click, AddressOf UpdatePenerimaanBarang
        Show()
        currentId = id
        Text = String.Format("Edit Penerimaan Barang No {0}", id)
        LoadComboBarang()
        LoadComboSupplier()
        Dim penerimaanBarangCore = New PenerimaanBarangCore
        Dim penerimaanBarang = penerimaanBarangCore.GetPenerimaanBarangHarian(id)
        TextBoxNoTerima.Text = penerimaanBarang.No_Invoice
        ComboBoxKodeSupplier.SelectedValue = penerimaanBarang.Supplier.Kode_Supplier
        DateTimePenerimaan.Value = penerimaanBarang.Tanggal
        DataGridView1.AllowUserToAddRows = True
        Dim a = New PenerimaanBarangCore
        Dim bs = a.GetPenerimaanBarang(currentId)

        For Each item In bs
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
        AddHandler ButtonSave.Click, AddressOf DeletePenerimaanBarang
        Show()
        currentId = id
        Text = String.Format("Delete Penerimaan Barang No {0}", id)
        LoadComboBarang()
        LoadComboSupplier()
        Dim penerimaanBarangCore = New PenerimaanBarangCore
        Dim penerimaanBarang = penerimaanBarangCore.GetPenerimaanBarangHarian(id)
        TextBoxNoTerima.Text = penerimaanBarang.No_Invoice
        ComboBoxKodeSupplier.SelectedValue = penerimaanBarang.Supplier.Kode_Supplier
        DateTimePenerimaan.Value = penerimaanBarang.Tanggal
        DataGridView1.AutoGenerateColumns = False
        Dim a = New PenerimaanBarangCore
        DataGridView1.DataSource = a.GetPenerimaanBarang(currentId)
    End Sub

    Private Sub DeletePenerimaanBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim core = New PenerimaanBarangCore
        Dim vListPenerimaanBarang = New List(Of PenerimaanBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim penerimaanBarang = New PenerimaanBarangModel
                penerimaanBarang.Tanggal = DateTimePenerimaan.Value.Date
                penerimaanBarang.NoInvoice = TextBoxNoTerima.Text
                penerimaanBarang.KodeSupplier = ComboBoxKodeSupplier.SelectedValue
                penerimaanBarang.KodeBarang = row.Cells("Kode_Barang").Value
                penerimaanBarang.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                penerimaanBarang.Crud = Convert.ToInt32(row.Cells("Crud").Value)
                penerimaanBarang.Id = Convert.ToInt32(row.Cells("Id").Value)
                vListPenerimaanBarang.Add(penerimaanBarang)
            End If
        Next
        core.DeletePenerimaanBarang(vListPenerimaanBarang)
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Private Sub UpdatePenerimaanBarang(ByVal sender As Object, ByVal e As EventArgs)
        Dim core = New PenerimaanBarangCore
        Dim vListPenerimaanBarang = New List(Of PenerimaanBarangModel)
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim penerimaanBarang = New PenerimaanBarangModel
                penerimaanBarang.Tanggal = DateTimePenerimaan.Value.Date
                penerimaanBarang.NoInvoice = TextBoxNoTerima.Text
                penerimaanBarang.KodeSupplier = ComboBoxKodeSupplier.SelectedValue
                penerimaanBarang.KodeBarang = row.Cells("Kode_Barang").Value
                penerimaanBarang.Jumlah = Convert.ToInt32(row.Cells("Jumlah").Value)
                penerimaanBarang.Crud = Convert.ToInt32(row.Cells("Crud").Value)
                penerimaanBarang.Id = Convert.ToInt32(row.Cells("Id").Value)
                vListPenerimaanBarang.Add(penerimaanBarang)
            End If
        Next
        core.UpdatePenerimaanBarang(vListPenerimaanBarang)
        MainForm.LoadDataBarang()
        Close()
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private listPenerimaanBarang As ListPenerimaanBarang

    Public Property ListForm() As ListPenerimaanBarang
        Get
            Return listPenerimaanBarang
        End Get
        Set(ByVal value As ListPenerimaanBarang)
            listPenerimaanBarang = value
        End Set
    End Property

    Private Sub DataGridViewUserAddedRow(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowEventArgs)
        e.Row.Cells("Crud").Value = 1
    End Sub

    Private Sub DataGridViewUserDeletingRow(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowCancelEventArgs)
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

    Private Sub DataGridViewRowsAdded(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowsAddedEventArgs)
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        If DataGridView1.CurrentRow.Cells("Crud").Value Is Nothing Then
            DataGridView1.CurrentRow.Cells("Crud").Value = 1
        End If
    End Sub

    Private Sub DataGridView1EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Dim a = DataGridView1.CurrentCell

        If a.ColumnIndex = 3 Then
            AddHandler e.Control.KeyPress, AddressOf OnCellJumlahEdit
        End If
        If a.ColumnIndex = 2 Then
            AddHandler CType(e.Control, ComboBox).SelectedValueChanged, AddressOf GridComboBoxSelectedvalue
        End If
    End Sub

    Private Sub GridComboBoxSelectedvalue(ByVal sender As System.Object, ByVal e As EventArgs)
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

    Private Sub DataGridViewCellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim row = DataGridView1.CurrentRow
        If Not row.IsNewRow Then
            If row.Cells("Crud").Value = 0 Then
                row.Cells("Crud").Value = 2
            End If
        End If
    End Sub

End Class