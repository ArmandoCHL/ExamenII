CREATE TABLE [dbo].[Orden]
(
	IdOrden INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Orden PRIMARY KEY CLUSTERED(IdOrden),
	IdProducto int NOT NULL
	  CONSTRAINT FK_Orden_Producto FOREIGN KEY(IdProducto) REFERENCES dbo.Producto(IdProducto),
	CantidadProducto int NOT NULL,
	Estado varchar(25) NULL
)
