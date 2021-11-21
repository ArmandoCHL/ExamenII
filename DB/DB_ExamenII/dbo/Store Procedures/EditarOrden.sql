CREATE PROCEDURE [dbo].[EditarOrden]
	
	@IdOrden int,	
	@IdProducto int,
	@CantidadProducto int,
	@Estado VARCHAR(25)
	
AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.Orden SET
	
	IdProducto = @IdOrden,
	CantidadProducto = @CantidadProducto,
	Estado = @Estado
	
	WHERE
		IdOrden= @IdOrden

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

  BEGIN CATCH

   SELECT 
         ERROR_NUMBER() AS CodeError,
		 ERROR_MESSAGE() AS MsgError
   
   ROLLBACK TRANSACTION TRASA

   END CATCH

 END