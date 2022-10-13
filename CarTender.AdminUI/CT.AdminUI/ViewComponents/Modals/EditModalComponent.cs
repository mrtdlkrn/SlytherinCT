using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.AdminUI.ViewComponents.Modals
{
    [ViewComponent(Name = "EditModal")]
    public class EditModalComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string modalID,
            string modalTitle,
            List<string> labelStrs
            )
        {
            EditModalDTO dto = new EditModalDTO(modalID,modalTitle, labelStrs);
            return View("Default",dto);
        }
    }
}
