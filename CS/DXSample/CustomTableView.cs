using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Grid;

namespace DXSample
{
    public class CustomTableView : TableView
    {
        public CustomTableView(): base()
        {

        }
        protected override DevExpress.Xpf.Core.IDropTarget CreateEmptyDropTarget()
        {
            return new CustomRemoveColumnDropTarget();
        }
    }
}
