using CT.AdminUI.Models.BaseTableDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace CT.AdminUI.ViewComponents
{
    [ViewComponent(Name = "BaseTable")]
    public class BaseTableComponent : ViewComponent
    {

        public IViewComponentResult Invoke(
            string formActionStr,
            string searchBarStr,
            string editBtnStr,
            string editBtnController,
            string editBtnAction,
            string deleteBtnStr,
            string deleteBtnModalID,
            List<string> tableheads,
            List<object> tabledatas,
            bool haspreviouspage,
            bool hasnextpage,
            int pageIndex
            )
        {
            BaseTableDTO dto = new BaseTableDTO()
            {
                FormActionStr = formActionStr,
                SearchbarStr = searchBarStr,
                EditBtnStr = editBtnStr,
                EditBtnController = editBtnController,
                EditBtnAction = editBtnAction,
                DeleteBtnStr = deleteBtnStr,
                DeleteBtnModalID = deleteBtnModalID,
                TableHeads = tableheads,
                TableDatas = tabledatas,
                HasNextPage = hasnextpage,
                HasPreviousPage = haspreviouspage,
                PageIndex = pageIndex               
            };
            return View("Default",dto);
        }
    }
}
