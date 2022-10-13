using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CT.AdminUI.ViewComponents.Modals
{
    [ViewComponent(Name = "AddModal")]
    public class AddModalComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string ModalID,string modalTitle, List<string> Labelstrs, string SaveBtnStr)
        {
            AddModalDTO dto = new AddModalDTO(ModalID,modalTitle,Labelstrs,SaveBtnStr);
            return View("Default",dto);
        }
    }
}
