using System.Collections.Generic;

namespace CT.AdminUI.Models.BaseTableDTOs
{
    public class BaseTableDTO
    {
        //public string ShowAllAction { get; set; }
        //public string NameSortParamAction { get; set; }
        //public string DateSortParamAction { get; set; }
        public string FormActionStr { get; set; }
        public string SearchbarStr { get; set; }
        public string EditBtnStr { get; set; }
        public string EditBtnController { get; set; }
        public string EditBtnAction { get; set; }
        public string DeleteBtnStr { get; set; }
        public string DeleteBtnModalID { get; set; }
        public List<string> TableHeads { get; set; }
        public List<object> TableDatas { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int PageIndex { get; set; }

        //public object CurrentFilter { get; set; }
        //public object NameSortParam { get; set; }
        //public object DateSortParam { get; set; }
        //public object CurrentSort { get; set; }
    }
}
