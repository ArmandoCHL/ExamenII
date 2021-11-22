namespace OrdenGrid {

    export function OnClickEliminar(id) {

        ComfirmAlert("Desea eliminar la Orden Seleccionada?", "Eliminar", "warning", "#3085d6", "d33")
            .then(result => {
                if (result.isConfirmed) {
                    Loading.fire("Borrando");
                    App.AxiosProvider.OrdenEliminar(id).then(data => {
                        Loading.close();

                        if (data.CodeError == 0) {
                            Toast.fire({ title: "La Orden ha sido eliminada", icon: "success" }).then(() => window.location.reload());
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" })
                        }
                    });
                }

            });

    }

    $("#GridView").DataTable();








}