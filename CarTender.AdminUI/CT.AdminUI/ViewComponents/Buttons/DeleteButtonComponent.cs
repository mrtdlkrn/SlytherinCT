using CT.AdminUI.Models.ButtonDTOs.EditandDeleteDTO;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CT.AdminUI.ViewComponents.Buttons
{
    [ViewComponent(Name = "DeleteButton")]
    public class DeleteButtonComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string modalID)
        {
            EditAndDeleteDTO editAndDeleteDTO = new EditAndDeleteDTO(modalID);
            return View("Default", editAndDeleteDTO);
        }
    }
}
