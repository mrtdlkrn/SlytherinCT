namespace CT.AdminUI.Models.ButtonDTOs.EditandDeleteDTO
{
    public class EditAndDeleteDTO
    {
        public EditAndDeleteDTO(string ModalID)
        {
            this.ModalID = ModalID;
        }
        public string ModalID { get; set; }
    }
}
