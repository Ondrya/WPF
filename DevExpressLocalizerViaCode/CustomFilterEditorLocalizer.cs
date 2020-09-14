using DevExpress.Xpf.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Localizer
{
    public class CustomFilterEditorLocalizer : EditorLocalizer
    {
        protected override void PopulateStringTable()
        {
            base.PopulateStringTable();

            AddString(EditorStringId.FilterGroupAnd, "И");
            AddString(EditorStringId.FilterGroupNotAnd, "И НЕ");
            AddString(EditorStringId.FilterGroupOr, "ИЛИ");
            AddString(EditorStringId.FilterGroupNotOr, "ИЛИ НЕ");
            AddString(EditorStringId.FilterGroupAddCondition, "Добавить условие");
            AddString(EditorStringId.FilterGroupAddGroup, "Добавить условие");
            AddString(EditorStringId.FilterGroupRemoveGroup, "Удалить условие");
            AddString(EditorStringId.FilterGroupClearAll, "Очистить все условия");


            AddString(EditorStringId.FilterClauseAnyOf, "Один из");
            AddString(EditorStringId.FilterClauseBeginsWith, "Начинается с");
            AddString(EditorStringId.FilterClauseBetween, "В интервале");
            AddString(EditorStringId.FilterClauseBetweenAnd, "И");
            AddString(EditorStringId.FilterClauseContains, "Содержит");
            AddString(EditorStringId.FilterClauseEndsWith, "Заканчивается на");
            AddString(EditorStringId.FilterClauseEquals, "Равно");
            AddString(EditorStringId.FilterClauseGreater, "Больше");
            AddString(EditorStringId.FilterClauseGreaterOrEqual, "Больше или равно");
            AddString(EditorStringId.FilterClauseIsNotNull, "Не NULL (значение задано)");
            AddString(EditorStringId.FilterClauseIsNull, "NULL (значение не задано)");
            AddString(EditorStringId.FilterClauseLess, "Меньше");
            AddString(EditorStringId.FilterClauseLessOrEqual, "Меньше или равно");
            AddString(EditorStringId.FilterClauseLike, "Совпадает с");
            AddString(EditorStringId.FilterClauseNoneOf, "Не в списке");
            AddString(EditorStringId.FilterClauseNotBetween, "Не в интервале");
            AddString(EditorStringId.FilterClauseDoesNotContain, "Не содержит");
            AddString(EditorStringId.FilterClauseDoesNotEqual, "Не равно");
            AddString(EditorStringId.FilterClauseNotLike, "Не совпадает с");
            AddString(EditorStringId.FilterClauseIsNullOrEmpty, "Значение пусто или не задано");
            AddString(EditorStringId.FilterClauseIsNotNullOrEmpty, "Значение задано и не пусто");
            AddString(EditorStringId.FilterClauseIsBeyondThisYear, "Текущий год");
            AddString(EditorStringId.FilterClauseIsLaterThisYear, "Позже в текущем году");
            AddString(EditorStringId.FilterClauseIsLaterThisMonth, "Позже в текущем месяце");
            AddString(EditorStringId.FilterClauseIsNextWeek, "На следующей неделе");
            AddString(EditorStringId.FilterClauseIsLaterThisWeek, "Позже на текущей недели");
            AddString(EditorStringId.FilterClauseIsTomorrow, "Завтра");
            AddString(EditorStringId.FilterClauseIsToday, "Сегодня");
            AddString(EditorStringId.FilterClauseIsYesterday, "Вчера");
            AddString(EditorStringId.FilterClauseIsEarlierThisWeek, "Ранее на текущей недели");
            AddString(EditorStringId.FilterClauseIsLastWeek, "Последняя неделя (IsLastWeek)");
            AddString(EditorStringId.FilterClauseIsEarlierThisMonth, "Ранее в текущем месяце");
            AddString(EditorStringId.FilterClauseIsEarlierThisYear, "Ранее в текущем году");
            AddString(EditorStringId.FilterClauseIsPriorThisYear, "В прошлом году");
            AddString(EditorStringId.FilterClauseLocalDateTimeThisYear, "Текущий год"); //TODO This Year
            AddString(EditorStringId.FilterClauseLocalDateTimeThisMonth, "Текущий месяц");
            AddString(EditorStringId.FilterClauseLocalDateTimeLastWeek, "На прошлой неделе");
            AddString(EditorStringId.FilterClauseLocalDateTimeThisWeek, "На этой неделе");
            AddString(EditorStringId.FilterClauseLocalDateTimeYesterday, "Вчера");
            AddString(EditorStringId.FilterClauseLocalDateTimeToday, "Сегодня");
            AddString(EditorStringId.FilterClauseLocalDateTimeNow, "Текущие Дата-Время");
            AddString(EditorStringId.FilterClauseLocalDateTimeTomorrow, "Завтра");
            AddString(EditorStringId.FilterClauseLocalDateTimeDayAfterTomorrow, "Послезавтра");
            AddString(EditorStringId.FilterClauseLocalDateTimeNextWeek, "На следующей неделе");
            AddString(EditorStringId.FilterClauseLocalDateTimeTwoWeeksAway, "2 недели до");
            AddString(EditorStringId.FilterClauseLocalDateTimeNextMonth, "В следующем месяце");
            AddString(EditorStringId.FilterClauseLocalDateTimeNextYear, "В следующем году");
        }
    }
}
