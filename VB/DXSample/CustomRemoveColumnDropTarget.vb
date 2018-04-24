Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Grid.Native
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid

Namespace DXSample
    Public Class CustomRemoveColumnDropTarget
        Inherits RemoveColumnDropTarget

        Public Overrides Sub Drop(ByVal source As UIElement, ByVal pt As Point)
            Dim view As TableView = TryCast(GetDataView(source), TableView)
            Dim column As GridColumn = TryCast((TryCast(source, GridColumnHeader)).DataContext, GridColumn)
            Dim flag As Boolean = Convert.ToBoolean(column.GetValue(AbsoluteVisible.IsEnableProperty))
            If flag Then
                DragDropScroller.StopScrolling(GetDataView(source))
                Return
            End If
            MyBase.Drop(source, pt)
        End Sub

    End Class
End Namespace
