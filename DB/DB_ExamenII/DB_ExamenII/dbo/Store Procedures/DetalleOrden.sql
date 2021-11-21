CREATE PROCEDURE [dbo].[DetalleOrden]
	
	@IdOrden int = NULL

AS BEGIN
	SET NOCOUNT ON


	SELECT
	
		O.IdOrden,
		O.IdProducto,
		O.CantidadProducto,
		o.Estado

	FROM dbo.Orden O

	WHERE (@IdOrden IS NULL OR IdOrden = @IdOrden)

END