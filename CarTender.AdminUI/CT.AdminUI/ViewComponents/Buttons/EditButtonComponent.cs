using CT.AdminUI.Models.ButtonDTOs.EditandDeleteDTO;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.ViewComponents.Buttons
{
    [ViewComponent(Name = "EditButton")]
    public class EditButtonComponent : ViewComponent
    {

        public IViewComponentResult Invoke(string modalID)
        {
            EditAndDeleteDTO editAndDeleteDTO = new EditAndDeleteDTO(modalID);
            return View("Default", editAndDeleteDTO);
        }
    }
}
