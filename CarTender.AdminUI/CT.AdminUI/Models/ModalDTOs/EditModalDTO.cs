using System.Collections.Generic;

namespace CT.AdminUI.Models.ModalDTOs
{
    public class EditModalDTO
    {
        public EditModalDTO(
            string modalId,
            string modalTitle,
            List<string> labelStrs
            )
        {
            ModalID = modalId;
            ModalTitle = modalTitle;
            LabelStrs = labelStrs;
        }
        public string ModalID { get; set; }
        public string ModalTitle { get; set; }
        public List<string> LabelStrs { get; set; }
    }
}
