using CT.AdminUI.Models.BaseTableDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CT.AdminUI.ViewComponents
{
    [ViewComponent(Name = "BaseTable")]
    public class BaseTableComponent : ViewComponent
    {

        public IViewComponentResult Invoke(
            string tableID,
            bool editIsModal,
            string editBtnController,
            string editBtnAction,
            string editBtnModalID,
            string deleteBtnModalID,
            List<string> tableheads,
            List<object> tabledatas
            )
        {           
            return View("Default", new BaseTableDTO()
            {
                TableID  = tableID,
                EditBtnModalID = editBtnModalID,
                EditIsModal = editIsModal,
                EditBtnController = editBtnController,
                EditBtnAction = editBtnAction,
                DeleteBtnModalID = deleteBtnModalID,
                TableHeads = tableheads,
                TableDatas = tabledatas,
            });
        }
    }
}
