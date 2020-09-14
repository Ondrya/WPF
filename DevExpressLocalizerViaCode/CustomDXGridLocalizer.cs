using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Localizer
{
    public class CustomDXGridLocalizer : GridControlLocalizer
    {
        protected override void PopulateStringTable()
        {
            base.PopulateStringTable();

            #region CONTEXT MENU
            AddString(GridControlStringId.MenuColumnSortAscending, "По возрастанию");
            AddString(GridControlStringId.MenuColumnSortDescending, "По убыванию");
            AddString(GridControlStringId.MenuColumnClearSorting, "Отменить сортировку");
            AddString(GridControlStringId.MenuColumnGroup, "Группировать по этому столбцу");
            AddString(GridControlStringId.MenuColumnHideGroupPanel, "Скрыть панель группировки");
            AddString(GridControlStringId.MenuColumnShowColumnChooser, "Показать меню выбора столбцов");
            AddString(GridControlStringId.MenuColumnBestFit, "Автоподбор ширины столбца");
            AddString(GridControlStringId.MenuColumnBestFitColumns, "Автоподбор ширины ВСЕХ столбца");
            AddString(GridControlStringId.MenuColumnFilterEditor, "Расширенный фильтр");
            AddString(GridControlStringId.MenuColumnShowSearchPanel, "Показать панель поиска");
            #endregion

            #region FILTER EDITOR
            AddString(GridControlStringId.FilterEditorTitle, "Расширенный фильтр");
            #endregion
        }
    }
}
