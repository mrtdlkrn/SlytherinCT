namespace CT.AdminUI.Models.ButtonDTOs.AddDTO
{
    public class AddDTO
    {
        public AddDTO(string ButtonName, string ModalID, string LinkHref, string ControllerName, string ActionName, bool IsHref)
        {
            this.LinkHref = LinkHref;
            this.ButtonName = ButtonName;
            this.ModalID = ModalID;
            this.ControllerName = ControllerName;
            this.ActionName = ActionName;
            this.IsHref = IsHref;
        }

        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string LinkHref { get; set; }
        public bool IsHref { get; set; }
        public string ButtonName { get; set; }
        public string ModalID { get; set; }
    }
}
