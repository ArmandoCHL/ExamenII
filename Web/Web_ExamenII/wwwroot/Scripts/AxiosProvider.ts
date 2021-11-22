
namespace App.AxiosProvider   {

    export const OrdenEliminar = (id) => axios.delete<DBEntity>("Orden/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const OrdenGuardar = (entity) => axios.post<DBEntity>("Orden/Edit", entity).then(({ data }) => data);

    export const ProductoEliminar = (id) => axios.delete<DBEntity>("Producto/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ProductoGuardar = (entity) => axios.post<DBEntity>("Producto/Edit", entity).then(({ data }) => data);

}




