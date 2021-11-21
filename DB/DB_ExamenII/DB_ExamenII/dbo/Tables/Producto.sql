CREATE TABLE [dbo].[Producto]
(
	[IdProducto] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Producto PRIMARY KEY CLUSTERED(IdProducto),
	NombreProducto VARCHAR(50) NOT NULL,
	PrecioProducto DECIMAL(18,2) NOT NULL
)
