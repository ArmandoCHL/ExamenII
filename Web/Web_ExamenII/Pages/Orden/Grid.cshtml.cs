using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace Web_ExamenII.Pages.Orden
{
    public class GridModel : PageModel
    {
        private readonly IOrdenService OrdenService;

        public GridModel(IOrdenService OrdenService)
        {
            this.OrdenService = OrdenService;
        }


        public IEnumerable<OrdenEntity> GridList { get; set; } = new List<OrdenEntity>();

        public string Mensaje { get; set; } = "";
        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await OrdenService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {

            try
            {
                var result = await OrdenService.Delete(new() { IdOrden = id });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }

                TempData["Msg"] = "La Orden ha sido eliminada";

                return Redirect("Grid");


            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
