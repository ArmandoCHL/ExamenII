CREATE PROCEDURE [dbo].[DetalleProducto]

	@IdProducto int = NULL

AS BEGIN
	SET NOCOUNT ON


	SELECT
	
		P.IdProducto,
		P.NombreProducto,
		P.PrecioProducto

	FROM dbo.Producto P

	WHERE (@IdProducto IS NULL OR IdProducto = @IdProducto)

END