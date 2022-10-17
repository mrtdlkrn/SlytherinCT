using System.Collections.Generic;

namespace CT.AdminUI.Models.BaseTableDTOs
{
    public class BaseTableDTO
    {
        public string TableID { get; set; }
        public bool EditIsModal { get; set; }
        public string EditBtnController { get; set; }
        public string EditBtnModalID { get; set; }
        public string EditBtnAction { get; set; }
        public string DeleteBtnModalID { get; set; }
        public List<string> TableHeads { get; set; }
        public List<object> TableDatas { get; set; }
    }
}
