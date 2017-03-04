using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAccounting.Form
{
    public class MyGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Tìm kiếm";
            if (id == GridStringId.FindControlClearButton)
                return "Xóa";
            return base.GetLocalizedString(id);
        }
    }
}
