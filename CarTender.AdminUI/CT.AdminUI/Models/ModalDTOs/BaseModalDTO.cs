namespace CT.AdminUI.Models.ModalDTOs
{
    /// <summary>
    /// Using for Add and Edit modals.
    /// </summary>
    public class BaseModalDTO
    {
        public BaseModalDTO(string modalID, string modalTitle, object dto)
        {
            this.ModalID = modalID;
            this.ModalTitle = modalTitle;
            this.DTO = dto;
        }

        public string ModalID { get; set; }
        public string ModalTitle { get; set; }
        public object DTO { get; set; }
    }
}
