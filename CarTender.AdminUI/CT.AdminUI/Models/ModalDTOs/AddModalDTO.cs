using System.Collections.Generic;

namespace CT.AdminUI.Models.ModalDTOs
{
    public class AddModalDTO
    {
        public AddModalDTO(string ModalID,string modalTitle, List<string> Labelstrs, string SaveBtnStr)
        {
            this.ModalID = ModalID;
            ModalTitle = modalTitle;
            this.Labelstrs = Labelstrs;
            this.SaveBtnStr = SaveBtnStr;
        }

        public string ModalID { get; set; }
        public string ModalTitle { get; set; }
        public List<string> Labelstrs { get; set; }
        public string SaveBtnStr { get; set; }
    }
}
