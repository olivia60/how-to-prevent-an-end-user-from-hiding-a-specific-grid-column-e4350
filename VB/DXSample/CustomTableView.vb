Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Grid

Namespace DXSample
	Public Class CustomTableView
		Inherits TableView
		Public Sub New()
			MyBase.New()

		End Sub
		Protected Overrides Function CreateEmptyDropTarget() As DevExpress.Xpf.Core.IDropTarget
			Return New CustomRemoveColumnDropTarget()
		End Function
	End Class
End Namespace
