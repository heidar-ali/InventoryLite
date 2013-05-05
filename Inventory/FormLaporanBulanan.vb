﻿Imports Inventory.BusinessLogic
Imports Microsoft.Reporting.WinForms

Public Class FormLaporanBulanan
    Private tanggal As DateTime
    Private Sub FormLaporanBulanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New LaporanCore
        Dim laporanPenerimaanBarangModels As List(Of LaporanHarianModel)
        laporanPenerimaanBarangModels = a.GetLaporanBulan(tanggal)

        Dim source As New ReportDataSource
        source.Name = "Inventory_BusinessLogic_LaporanHarianModel"
        source.Value = laporanPenerimaanBarangModels
        ReportViewer1.LocalReport.DataSources.Add(source)

        ReportViewer1.RefreshReport()
    End Sub

    Public Sub ViewLaporanHarian(ByVal tanggalLaporan As DateTime)
        tanggal = tanggalLaporan
        Show()
    End Sub
End Class