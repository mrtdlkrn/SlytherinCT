using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CT.AdminUI.ViewComponents
{
    [ViewComponent(Name = "DeleteModal")] //Solution
    public class DeleteModalComponent : ViewComponent
    {
        DeleteModalDTO dto;

        public IViewComponentResult Invoke(string title, string body, string id)
        {
            dto = new DeleteModalDTO() { ModalID = id, ModalTitle = title, ModalBody = body };
            return View("Default", dto);
        }
    }
}