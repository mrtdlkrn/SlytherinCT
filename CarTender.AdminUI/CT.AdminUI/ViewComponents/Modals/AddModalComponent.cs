using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.ViewComponents.Modals
{
    [ViewComponent(Name = "AddModal")]
    public class AddModalComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string modalID, string modalTitle, object dto,string ActionName,string ControllerName)
        {
            BaseModalDTO baseModalDTO = new BaseModalDTO(modalID, modalTitle, dto ,ActionName,ControllerName);
            return View("Default", baseModalDTO);
        }
    }
}
