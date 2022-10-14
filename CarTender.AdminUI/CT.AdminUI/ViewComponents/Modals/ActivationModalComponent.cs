﻿using CT.AdminUI.Models.ModalDTOs;
using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.ViewComponents
{
    [ViewComponent(Name = "ActivationModal")]

    public class ActivationModalComponent : ViewComponent
    {
        ModalDTO dto;

        public IViewComponentResult Invoke(string title, string body, string id)
        {
            dto = new ModalDTO() { ModalID = id, ModalTitle = title, ModalBody = body };
            return View("Default", dto);
        }
    }
}
