Imports Inventory.BusinessLogic
Imports Microsoft.Reporting.WinForms

Public Class ReportChartContohForm

    Private Sub ReportChartContohForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New LaporanCore
        Dim laporanPenerimaanBarangModels As List(Of LaporanHarianModel)
        laporanPenerimaanBarangModels = a.GetLaporanHarian(New DateTime(2013, 2, 10)).OrderByDescending(Function(x) x.BarangMasuk).Take(15).ToList()
        Dim source As New ReportDataSource
        source.Name = "Inventory_BusinessLogic_LaporanHarianModel"
        source.Value = laporanPenerimaanBarangModels
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(source)
        ReportViewer1.RefreshReport()
    End Sub
End Class