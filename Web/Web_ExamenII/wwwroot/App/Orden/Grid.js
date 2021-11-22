"use strict";
var OrdenGrid;
(function (OrdenGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar la Orden Seleccionada?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.OrdenEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "La Orden ha sido eliminada", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    OrdenGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(OrdenGrid || (OrdenGrid = {}));
//# sourceMappingURL=Grid.js.map