using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IOrdenService
    {
        Task<DBEntity> Create(OrdenEntity entity);
        Task<DBEntity> Delete(OrdenEntity entity);
        Task<IEnumerable<OrdenEntity>> Get();
        Task<OrdenEntity> GetById(OrdenEntity entity);
        Task<DBEntity> Update(OrdenEntity entity);

        Task<IEnumerable<OrdenEntity>> GetLista();
    }

    public class OrdenService : IOrdenService
    {
        private readonly IDataAccess sql;

        public OrdenService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<OrdenEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<OrdenEntity, ProductoEntity>("dbo.DetalleOrden", "IdOrden,IdProducto");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<OrdenEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<OrdenEntity>("dbo.ListarOrdenes");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<OrdenEntity> GetById(OrdenEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<OrdenEntity>("dbo.DetalleOrden", new
                { entity.IdOrden });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InsertarOrden", new
                {
                    entity.IdOrden,
                    entity.Producto,
                    entity.CantidadProducto,
                    entity.Estado


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.EditarOrden", new
                {
                    entity.IdOrden,
                    entity.Producto,
                    entity.CantidadProducto,
                    entity.Estado

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(OrdenEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.EliminarOrden", new
                {
                    entity.IdOrden,



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        


        #endregion



    }
}