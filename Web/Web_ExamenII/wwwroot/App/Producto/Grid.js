"use strict";
var ProductoGrid;
(function (ProductoGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.ProductoEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "El producto ha sido eliminado", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    ProductoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(ProductoGrid || (ProductoGrid = {}));
//# sourceMappingURL=Grid.js.map