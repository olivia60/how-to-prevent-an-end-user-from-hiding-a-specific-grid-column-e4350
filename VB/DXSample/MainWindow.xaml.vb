﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid

Namespace DXSample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = DataHelper.GetData()
        End Sub
    End Class
End Namespace
