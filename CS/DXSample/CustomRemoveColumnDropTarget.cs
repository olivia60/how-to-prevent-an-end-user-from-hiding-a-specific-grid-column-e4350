using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Grid.Native;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;

namespace DXSample
{
    public class CustomRemoveColumnDropTarget : RemoveColumnDropTarget
    {
        public override void Drop(UIElement source, Point pt)
        {
            TableView view = GetDataView(source) as TableView;
            GridColumn column = (source as GridColumnHeader).DataContext as GridColumn;
            bool flag = Convert.ToBoolean(column.GetValue(AbsoluteVisible.IsEnableProperty));
            if (flag)
            {
                DragDropScroller.StopScrolling(GetDataView(source));
                return;
            }
            base.Drop(source, pt);
        }
    
    }
}
