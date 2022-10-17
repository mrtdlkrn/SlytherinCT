using CT.AdminUI.Models.ButtonDTOs.AddDTO;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.ViewComponents.Buttons
{
    [ViewComponent(Name = "AddButton")]
    public class AddButtonComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string ButtonName, string ModalID, string LinkHref, string ControllerName, string ActionName, bool IsHref)
        {
            AddDTO addDTO = new AddDTO(ButtonName, ModalID, LinkHref, ControllerName, ActionName, IsHref);
            return View("Default", addDTO);
        }
    }
}
