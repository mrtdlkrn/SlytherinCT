using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.ViewComponents.Modals
{
    [ViewComponent(Name = "AddModal")]
    public class AddModalComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string modalID, string modalTitle, object dto)
        {
            BaseModalDTO baseModalDTO = new BaseModalDTO(modalID, modalTitle, dto);
            return View("Default", baseModalDTO);
        }
    }
}
