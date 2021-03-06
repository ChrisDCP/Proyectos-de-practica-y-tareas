USE [master]
GO
/****** Object:  Database [SistemaVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE DATABASE [SistemaVenta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaVenta', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SistemaVenta.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaVenta_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SistemaVenta_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaVenta] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaVenta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaVenta] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaVenta] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaVenta] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaVenta] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaVenta] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaVenta] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaVenta] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaVenta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaVenta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaVenta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaVenta] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaVenta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaVenta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaVenta] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaVenta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaVenta] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaVenta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaVenta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaVenta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaVenta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaVenta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaVenta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaVenta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaVenta] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaVenta] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaVenta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaVenta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaVenta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaVenta] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SistemaVenta]
GO
/****** Object:  StoredProcedure [dbo].[Guardar_Categorias]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Guardar_Categorias]
	-- Add the parameters for the stored procedure here
	@Descripcion  varchar(50),
	@Nombre varchar(50)
	
	as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Categoria ([Descripcion],Nombre)
	values (@Descripcion,@Nombre)
END



GO
/****** Object:  StoredProcedure [dbo].[Guardarcompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Guardarcompra]
	-- Add the parameters for the stored procedure here
	
	@ID_Proveedor int,
	@Fecha datetime,
	@Total money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Compra ( ID_Proveedor ,Fecha ,Total)
	values  (@ID_Proveedor ,@Fecha ,@Total)

END



GO
/****** Object:  StoredProcedure [dbo].[Llenar_categoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Llenar_categoria] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Categoria
END



GO
/****** Object:  StoredProcedure [dbo].[llenarpro]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[llenarpro]
	-- Add the parameters for the stored procedure here
	@ID_Producto varchar (25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID_Producto,Nombre,Precio,Existencia,ID_Categoria,UnidaddeMedida
	from Producto
	where ID_Producto=@ID_Producto
END



GO
/****** Object:  StoredProcedure [dbo].[LlenarProductCmpr]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LlenarProductCmpr]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Producto
END



GO
/****** Object:  StoredProcedure [dbo].[LlenarProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LlenarProveedor]
-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from Proveedor 
END



GO
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModificarProducto]
	-- Add the parameters for the stored procedure here
	@ID_Producto varchar(25),
	@Nombre varchar (30),
	@Precio money,
	@ID_Categoria int,
	@existencia float,
	@UnidaddeMedida varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


    -- Insert statements for procedure here
	update Producto
	set Nombre=@Nombre,Precio=@Precio,ID_Categoria=@ID_Categoria,existencia=@existencia,UnidaddeMedida=@UnidaddeMedida
	where ID_Producto=@ID_Producto
END



GO
/****** Object:  StoredProcedure [dbo].[ProductoEsp]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ProductoEsp]
	-- Add the parameters for the stored procedure here
	@ID_Producto VARCHAR(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID_Producto,Nombre,Existencia,ID_Categoria,UnidaddeMedida
	from Producto
	where ID_Producto=@ID_Producto

END



GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarAbono]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarAbono]
@CantidadAbono money,
@FechaAbono datetime,
@ID_Credito int
AS
BEGIN

		INSERT INTO Abono(CantidadAbono,Fecha_abono,ID_Credito)VALUES(@CantidadAbono,@FechaAbono,@ID_Credito);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarCategoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarCategoria]
@Nombre char(50)
AS
BEGIN
		INSERT INTO Categoria(Nombre)VALUES(@Nombre);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarCompra]
@ID_proveedor int,
@Fecha datetime,
@Total money
AS
BEGIN
		INSERT INTO Compra(ID_Proveedor,Fecha,Total)VALUES(@ID_proveedor,@Fecha,@Total);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarCredito]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarCredito]
@Monto money,
@Fecha datetime,
@ID_Cliente int,
@ID_venta int
AS
BEGIN
		INSERT INTO Credito(Monto,Fecha_Credito,ID_Cliente,ID_Venta)VALUES(@Monto,@Fecha,@ID_Cliente,@ID_venta);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarDetalleCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarDetalleCompra]
@Precio money,
@Cantidad float,
@subtotal money,
@ID_Compra int,
@ID_Producto int
AS
BEGIN
		INSERT INTO DetalleCompra(Cantidad,Precio,subtotal,ID_Compra,ID_Producto)VALUES(@Cantidad,@Precio,@subtotal,@ID_Compra,@ID_Producto);

		UPDATE inventario SET cantidad = (cantidad+@Cantidad), precio_compra=@Precio WHERE id_producto = @ID_Producto;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarDetalleVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarDetalleVenta]
@Cantidad float,
@PrecioUnitario money,
@ID_venta int,
@ID_producto int,
@subtotal money
AS
BEGIN
		INSERT INTO [Detalle Venta](Cantidad,PrecioUnitario,ID_Venta,ID_Producto,subtotal)VALUES(@Cantidad,@PrecioUnitario,@ID_venta,@ID_producto,@subtotal);

		UPDATE inventario SET cantidad=cantidad-@Cantidad WHERE id_producto=@ID_producto;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarInventario]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarInventario]
@cantidad float,
@precio_compra money,
@porc_venta float
AS
BEGIN

		INSERT INTO inventario(cantidad,precio_compra,porc_venta)VALUES(@cantidad,@precio_compra,@porc_venta);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarProducto]
@Nombre char(30),
@ID_Categoria int,
@id_unidadMedida int
AS
BEGIN
		INSERT INTO Producto(Nombre,ID_Categoria,id_unidadMedida)VALUES(@Nombre,@ID_Categoria,@id_unidadMedida);

		declare @cod int;

		SELECT @cod = ID_Producto FROM Producto ORDER BY ID_Producto ASC;

		INSERT INTO inventario(id_producto,cantidad,precio_compra,porc_venta)VALUES(@cod,0,0.0,0.0);

END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarUnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarUnidadMedida]
@nombre char(20)
AS
BEGIN
		INSERT INTO UnidadMedida(nombre)VALUES(@nombre);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_AgregarVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarVenta]
@Credito bit,
@ID_Cliente int,
@FechaVenta datetime,
@Total money
AS
BEGIN
		INSERT INTO Venta(Credito,ID_Cliente,FechaVenta,Total)VALUES(@Credito,@ID_Cliente,@FechaVenta,@Total);

		declare @id_venta int;

		SELECT @id_venta=ID_Venta FROM Venta ORDER BY ID_Venta ASC;

		IF @Credito=1
		BEGIN
			INSERT INTO Credito(Monto,Fecha_Credito,ID_Cliente,ID_Venta)VALUES(@Total,@FechaVenta,@ID_Cliente,@id_venta);
		END
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_EditarCategoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarCategoria]
@ID_Categoria int,
@Nombre char(50)
AS
BEGIN
		UPDATE Categoria SET Nombre=@Nombre WHERE ID_Categoria = @ID_Categoria;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_EditarCliente]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_EditarCliente]
	-- Add the parameters for the stored procedure here

	 @ID_Cliente int,
	 @Cedula char (16),
	 @Primer_Nombre char (20),
	 @Segundo_Nombre char (20),
	 @Primer_Apellido char (20),
	@Segundo_Apellido char (20),
	@Telefono char (9),
	@Direccion text
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	update Cliente
	set Cedula=@Cedula,Primer_Nombre=@Primer_Nombre,Segundo_Nombre=@Segundo_Nombre,Primer_Apellido=@Primer_Apellido,Segundo_Apellido=@Segundo_Apellido,Telefono=@Telefono,Direccion=@Direccion
	where ID_Cliente=@ID_Cliente
END



GO
/****** Object:  StoredProcedure [dbo].[SP_EditarInventario]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarInventario]
@id_producto int,
@precio_compra money,
@porc_venta float
AS
BEGIN
		UPDATE inventario SET porc_venta=@porc_venta, @precio_compra=@precio_compra
		WHERE id_producto=@id_producto;		
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_editarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_editarProducto]
@ID_producto int,
@Nombre char(30),
@ID_Categoria int,
@id_unidadMedida int
AS
BEGIN
		UPDATE Producto SET Nombre=@Nombre,ID_Categoria=@ID_Categoria,id_unidadMedida=@id_unidadMedida WHERE ID_Producto=@ID_producto;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_editarProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_editarProveedor]
	-- Add the parameters for the stored procedure here
	@ID_Proveedor int,
	@Num_Ruc char (18),
	@Primer_Nombre char (20),
	@Segundo_Nombre char (20),
	@Primer_Apellido char (20),
	@Segundo_Apellido char (20),
	@Telefono  char (9),
	@Direccion text,
	@Correo_Electronico varchar (50),
	@Nombre_Compañia char(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
 update Proveedor
 set 
		Num_Ruc=@Num_Ruc,
		Primer_Nombre=@Primer_Nombre,
		Segundo_Nombre=@Segundo_Nombre,
		Primer_Apellido=@Primer_Apellido,
		Segundo_Apellido=@Segundo_Apellido,
		Telefono =@Telefono,
		Direccion =	@Direccion,
		Correo_Electronico=	@Correo_Electronico,
		Nombre_Compañia=@Nombre_Compañia
	where ID_Proveedor=@ID_Proveedor

		
END



GO
/****** Object:  StoredProcedure [dbo].[SP_EditarUnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarUnidadMedida]
@id_unidadMedida int,
@nombre char(20)
AS
BEGIN
	UPDATE UnidadMedida SET nombre=@nombre WHERE id_unidadMedida=@id_unidadMedida;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarCategoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarCategoria]
@ID_Categoria int
AS
BEGIN
		DELETE FROM Categoria WHERE ID_Categoria = @ID_Categoria;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_eliminarClientes]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_eliminarClientes]
@id_Cliente int
AS
BEGIN
		DELETE FROM Cliente WHERE ID_Cliente = @id_Cliente;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_eliminarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_eliminarProducto]
@ID_producto int
AS
BEGIN
		DELETE FROM Producto WHERE ID_Producto=@ID_producto;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_eliminarProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_eliminarProveedor]
@ID_Proveedor int
AS
BEGIN
		DELETE FROM Proveedor WHERE ID_Proveedor=@ID_Proveedor;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarUnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarUnidadMedida]
@id_unidadMedida int
AS
BEGIN
	DELETE FROM UnidadMedida WHERE id_unidadMedida=@id_unidadMedida;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarCliente]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GuardarCliente]
	-- Add the parameters for the stored procedure here
	@Cedula char (16),
	@Primer_Nombre char (20),
	@Segundo_Nombre char (20),
	@Primer_Apellido char (20),
	@Segundo_Apellido char (20),
	@Telefono char (9),
	@Direccion text
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Cliente (Cedula,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Telefono,Direccion)
	values (@Cedula,@Primer_Nombre,@Segundo_Nombre,	@Primer_Apellido,@Segundo_Apellido,@Telefono,@Direccion)
END



GO
/****** Object:  StoredProcedure [dbo].[SP_Guardardetalle_compra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Guardardetalle_compra]
	-- Add the parameters for the stored procedure here
	@ID_DetalleCompra int,
	@Precio money,
	@Cantidad float,
	@ID_Compra int,
	@ID_Producto varchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Detalle_Compra (ID_DetalleCompra,Precio ,Cantidad ,ID_Compra,ID_Producto)
	values (@ID_DetalleCompra ,@Precio,@Cantidad ,@ID_Compra,@ID_Producto)
END



GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GuardarProveedor]
	-- Add the parameters for the stored procedure here
	@Num_Ruc varchar(18),
	@Primer_Nombre char (20),
	@Segundo_Nombre char (20),
	@Primer_Apellido char (20),
	@Segundo_Apellido char (20),
	@Telefono char (9),
	@Direccion text,
	@Nombre_Compañia char (50),
	@Correo_Electronico varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Proveedor (Num_Ruc,Nombre_Compañia,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Telefono,Correo_Electronico,Direccion)
	values (@Num_Ruc,@Nombre_Compañia,@Primer_Nombre,@Segundo_Nombre,@Primer_Apellido, @Segundo_Apellido,@Telefono,@Correo_Electronico,@Direccion)
END



GO
/****** Object:  StoredProcedure [dbo].[SP_IDCategoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDCategoria]
AS
BEGIN
		SELECT ID_Categoria FROM Categoria ORDER BY ID_Categoria ASC;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_IDCliente]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDCliente]

AS
BEGIN
		SELECT ID_Cliente FROM Cliente ORDER BY id_Cliente ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_IDCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDCompra]
AS
BEGIN
		SELECT ID_compra FROM Compra
		ORDER BY ID_Compra ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_IDProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDProducto]

AS
BEGIN
		SELECT Producto.ID_Producto 
		FROM Producto
        ORDER BY Producto.ID_Producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_IDProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDProveedor]
AS
BEGIN
		SELECT ID_Proveedor FROM Proveedor ORDER BY ID_Proveedor ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_IDUnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDUnidadMedida]
AS
BEGIN
		SELECT id_unidadMedida FROM UnidadMedida  ORDER BY id_unidadMedida ASC;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_IDVentas]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IDVentas]
AS
BEGIN
		SELECT ID_Venta
		FROM Venta
		ORDER BY ID_venta ASC;
END;		
GO
/****** Object:  StoredProcedure [dbo].[SP_InformeInventario]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InformeInventario]
AS
BEGIN
		SELECT Producto.Nombre AS Producto,Categoria.Nombre AS Categoria,
		CASE Producto.id_unidadMedida 
		WHEN 0 THEN ''
		ELSE
			(SELECT UnidadMedida.nombre FROM UnidadMedida WHERE UnidadMedida.id_unidadMedida = Producto.id_unidadMedida)
		END
		AS Medida
		,cantidad
		FROM inventario
		INNER JOIN producto ON producto.ID_Producto = inventario.id_producto
		INNER JOIN Categoria ON Categoria.ID_Categoria = producto.ID_Categoria;
		
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarAbonoVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarAbonoVenta]
@ID_Credito int
AS
BEGIN
		SELECT ID_Abono,CantidadAbono,Fecha_abono
		FROM Abono
		INNER JOIN Credito ON Credito.ID_Credito = Abono.ID_Credito
		WHERE Abono.ID_Credito=@ID_Credito;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarCategoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarCategoria]
@nombre char(50)
AS
BEGIN
		SELECT * FROM Categoria WHERE RTRIM(Nombre) LIKE CONCAT(RTRIM(@nombre),'%') ORDER BY ID_Categoria ASC;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_ListarClientes]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarClientes]
@texto char(40),
@tipo int
AS
BEGIN
		IF (@tipo = 1)
		BEGIN
			SELECT ID_cliente AS Codigo, Cedula AS Cedula, RTRIM(Primer_Nombre) as PriNom, RTRIM(Segundo_Nombre) AS SegNom, RTRIM(Primer_Apellido) AS PriApell, RTRIM(Segundo_Apellido) AS SegApell,Telefono,Direccion
			FROM Cliente
			WHERE CONCAT(RTRIM(Primer_Nombre), ' ',RTRIM(Segundo_Nombre)) LIKE CONCAT(RTRIM(@texto),'%')
			ORDER BY ID_cliente ASC;
		END
		ELSE IF (@tipo = 2)
			BEGIN
				SELECT ID_cliente AS Codigo, Cedula AS Cedula, CONCAT(RTRIM(Primer_Nombre), ' ',RTRIM(Segundo_Nombre)) AS Nombres, CONCAT(RTRIM(Primer_Apellido), ' ',RTRIM(Segundo_Apellido)) AS Apellidos,Telefono,Direccion
				FROM Cliente
				WHERE CONCAT(RTRIM(Primer_Apellido), ' ',RTRIM(Segundo_Apellido)) LIKE CONCAT(RTRIM(@texto),'%')
				ORDER BY ID_cliente ASC;
			END

END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarComboClientes]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarComboClientes]
AS
BEGIN
		SELECT id_Cliente,CONCAT(RTRIM(Primer_Nombre),' ',RTRIM(Segundo_Nombre),' ',RTRIM(Primer_Apellido),' ',RTRIM(Segundo_Apellido)) as Cli
		FROM Cliente
		ORDER BY ID_Cliente ASC;
END;		
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarComboProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarComboProducto]
AS
BEGIN
		SELECT ID_Producto, Nombre FROM Producto 
		ORDER BY ID_Producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarComboProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarComboProveedor]
AS
BEGIN
		SELECT ID_Proveedor,RTRIM(Nombre_Compañia) as Compania FROM Proveedor
		ORDER BY ID_Proveedor ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarCompra]
@ID_compra int
AS
BEGIN
		SELECT Proveedor.Nombre_Compañia AS Proveedor,Fecha,Total
		FROM Compra
		INNER JOIN Proveedor ON Proveedor.ID_Proveedor = Compra.ID_Proveedor
		WHERE ID_Compra = @ID_compra;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarDetalleCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarDetalleCompra]
@ID_compra int
AS
BEGIN
		SELECT Producto.ID_Producto AS Codigo, Producto.Nombre AS Producto, Cantidad,Precio,subtotal AS SubTotal
		FROM DetalleCompra
		INNER JOIN Producto ON Producto.ID_Producto = DetalleCompra.ID_Producto
		WHERE ID_Compra = @ID_compra;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarDetalleVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarDetalleVenta]
@ID_Venta int
AS
BEGIN
		SELECT Producto.ID_Producto AS Codigo, Producto.Nombre AS Producto, Cantidad,PrecioUnitario,subtotal AS SubTotal
		FROM [Detalle Venta]
		INNER JOIN Producto ON Producto.ID_Producto = [Detalle Venta].ID_Producto
		WHERE ID_Venta=@ID_Venta;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarProducto]
@Nombre char(20)
AS
BEGIN
		SELECT Producto.ID_Producto AS Codigo,Producto.Nombre AS Producto,Categoria.Nombre AS Categoria,
		CASE Producto.id_unidadMedida 
		WHEN 0 THEN ''
		ELSE
			(SELECT UnidadMedida.nombre FROM UnidadMedida WHERE UnidadMedida.id_unidadMedida = Producto.id_unidadMedida)
		END
		AS Medida
		FROM Producto
		INNER JOIN Categoria ON Categoria.ID_Categoria=Producto.ID_Categoria
		WHERE RTRIM(Producto.Nombre) LIKE CONCAT(RTRIM(@Nombre),'%') ORDER BY Producto.ID_Producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarProductoInventario]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarProductoInventario]
@producto char(30)
AS
BEGIN
		SELECT inventario.id_producto as Codigo,Producto.Nombre AS Producto,cantidad as Cantidad,precio_compra,porc_venta
		FROM inventario
		INNER JOIN producto ON producto.ID_Producto = inventario.id_producto
		WHERE RTRIM(Producto.Nombre) LIKE CONCAT(RTRIM(@producto),'%')
		ORDER BY inventario.id_producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarProveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarProveedor]
@Nombre_Compania char(50)
AS
BEGIN
		SELECT * FROM Proveedor
		WHERE RTRIM(Nombre_Compañia) LIKE CONCAT(RTRIM(@Nombre_Compania),'%') ORDER BY ID_Proveedor ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarUnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarUnidadMedida]
@nombre char(20)
AS
BEGIN
		SELECT * FROM UnidadMedida WHERE RTRIM(nombre) LIKE CONCAT(RTRIM(@nombre),'%') ORDER BY id_unidadMedida ASC;
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_ListarVenta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarVenta]
@ID_Venta int
AS
BEGIN
		SELECT ID_Venta,CONCAT(RTRIM(Primer_Nombre),' ',RTRIM(Segundo_Nombre),' ',RTRIM(Primer_Apellido),' ',RTRIM(Segundo_Apellido)) as Cli,Credito,FechaVenta,Total
		FROM Venta 
		INNER JOIN Cliente ON Cliente.ID_Cliente = Venta.ID_Cliente
		WHERE ID_Venta=@ID_Venta;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarVentaCredito]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarVentaCredito]
AS
BEGIN
		SELECT ID_Credito,ID_venta FROM Credito ORDER BY ID_venta;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_llenar_categoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_llenar_categoria]
	-- Add the parameters for the stored procedure here
	@ID_Categoria int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	select Nombre,Descripcion
	FROM Categoria
	where ID_Categoria=@ID_Categoria
END



GO
/****** Object:  StoredProcedure [dbo].[SP_Llenar_Proveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_Llenar_Proveedor]
	-- Add the parameters for the stored procedure here
	@ID_Proveedor int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Num_Ruc,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Telefono,Direccion,Correo_Electronico,Nombre_Compañia
	FROM Proveedor
	where  ID_Proveedor=@ID_Proveedor


END



GO
/****** Object:  StoredProcedure [dbo].[SP_LlenarCliente]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_LlenarCliente] 
	-- Add the parameters for the stored procedure here
	@ID_Cliente int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Cedula,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Telefono,Direccion
	from Cliente
	where ID_Cliente=@ID_Cliente
	end



GO
/****** Object:  StoredProcedure [dbo].[SP_LlenarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LlenarProducto]
	-- Add the parameters for the stored procedure here
	@ID_Producto varchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Nombre,Precio,ID_Categoria,existencia,UnidaddeMedida
	from Producto
	where ID_Producto=@ID_Producto
END



GO
/****** Object:  StoredProcedure [dbo].[SP_Modificar_Categoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURe [dbo].[SP_Modificar_Categoria]
	-- Add the parameters for the stored procedure here
	
	@ID_Categoria int,
	@Nombre varchar(50),
	@Descripcion varchar(50)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Categoria
	set Nombre=@Nombre,
	Descripcion=@Descripcion
	
	where ID_Categoria=@ID_Categoria
	
	
END



GO
/****** Object:  StoredProcedure [dbo].[SP_MostrarExistenciaPrecio]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarExistenciaPrecio]
@id_producto int
AS
BEGIN
		SELECT cantidad as Cantidad,precio_Compra,porc_venta
		FROM inventario
		INNER JOIN producto ON producto.ID_Producto = inventario.id_producto
		WHERE producto.ID_Producto=@id_producto
		ORDER BY inventario.id_producto ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_MostrarUnidadProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MostrarUnidadProducto]
@id_producto int
AS
BEGIN
		SELECT UnidadMedida.nombre AS Unidad FROM Producto
		INNER JOIN UnidadMedida ON UnidadMedida.id_unidadMedida = Producto.id_unidadMedida
		WHERE ID_Producto = @id_producto;
END;
GO
/****** Object:  StoredProcedure [dbo].[spGuardarProducto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[spGuardarProducto]
	-- Add the parameters for the stored procedure here
	@ID_Producto varchar(25),
	@Nombre varchar(30),
	@Precio money,
	@ID_Categoria int,
	@existencia float,
	@UnidaddeMedida varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


    -- Insert statements for procedure here
	insert into Producto(ID_Producto,Nombre,Precio,ID_Categoria,existencia,UnidaddeMedida)
	values(@ID_Producto,@Nombre,@Precio,@ID_Categoria,@existencia,@UnidaddeMedida)
END



GO
/****** Object:  Table [dbo].[Abono]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abono](
	[ID_Abono] [int] IDENTITY(1,1) NOT NULL,
	[CantidadAbono] [money] NOT NULL,
	[Fecha_abono] [datetime2](7) NOT NULL,
	[ID_Credito] [int] NOT NULL,
 CONSTRAINT [PK6] PRIMARY KEY CLUSTERED 
(
	[ID_Abono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](50) NOT NULL,
 CONSTRAINT [PK3] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](16) NOT NULL,
	[Primer_Nombre] [char](20) NOT NULL,
	[Segundo_Nombre] [char](20) NULL,
	[Primer_Apellido] [char](20) NOT NULL,
	[Segundo_Apellido] [char](20) NULL,
	[Telefono] [char](9) NULL,
	[Direccion] [text] NOT NULL,
 CONSTRAINT [PK1] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[ID_Compra] [int] IDENTITY(1,1) NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK9] PRIMARY KEY CLUSTERED 
(
	[ID_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Credito]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credito](
	[ID_Credito] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [money] NOT NULL,
	[Fecha_Credito] [datetime2](7) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Venta] [int] NOT NULL,
 CONSTRAINT [PK13] PRIMARY KEY CLUSTERED 
(
	[ID_Credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalle Venta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle Venta](
	[ID_DetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [float] NOT NULL,
	[PrecioUnitario] [money] NOT NULL,
	[ID_Venta] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[subtotal] [money] NOT NULL,
 CONSTRAINT [PK10] PRIMARY KEY CLUSTERED 
(
	[ID_DetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[ID_DetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [float] NOT NULL,
	[Precio] [money] NOT NULL,
	[subtotal] [money] NULL,
	[ID_Compra] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
 CONSTRAINT [PK12] PRIMARY KEY CLUSTERED 
(
	[ID_DetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inventario]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[id_producto] [int] NOT NULL,
	[cantidad] [float] NOT NULL,
	[precio_compra] [money] NOT NULL,
	[porc_venta] [float] NOT NULL,
 CONSTRAINT [PK_inventario] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](30) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[id_unidadMedida] [int] NOT NULL,
 CONSTRAINT [PK7] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Num_Ruc] [char](18) NOT NULL,
	[Nombre_Compañia] [char](50) NOT NULL,
	[Primer_Nombre] [char](20) NOT NULL,
	[Segundo_Nombre] [char](20) NULL,
	[Primer_Apellido] [char](20) NOT NULL,
	[Segundo_Apellido] [char](20) NULL,
	[Telefono] [char](9) NOT NULL,
	[Correo_Electronico] [varchar](50) NOT NULL,
	[Direccion] [text] NOT NULL,
 CONSTRAINT [PK2] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[id_unidadMedida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [char](20) NULL,
 CONSTRAINT [PK_UnidadMedida] PRIMARY KEY CLUSTERED 
(
	[id_unidadMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 2/7/2016 4:51:53 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Credito] [bit] NULL,
	[ID_Cliente] [int] NOT NULL,
	[FechaVenta] [datetime2](7) NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK4] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Abono] ON 

INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (1, 100.0000, CAST(0x07D0C9329F66923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (2, 50.0000, CAST(0x0750DED0EE66923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (3, 10.0000, CAST(0x070060DE0967923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (4, 30.0000, CAST(0x071093581F67923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (5, 60.0000, CAST(0x07D036224267923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (6, 10.0000, CAST(0x07106A835467923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (7, 50.0000, CAST(0x0700FC846767923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (9, 350.0000, CAST(0x077075EBED68923B0B AS DateTime2), 1)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (10, 500.0000, CAST(0x07604FBAB580923B0B AS DateTime2), 3)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (11, 7898.5000, CAST(0x07604FBAB580923B0B AS DateTime2), 3)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (12, 97.5000, CAST(0x07604FBAB580923B0B AS DateTime2), 2)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (13, 500.0000, CAST(0x07604FBAB580923B0B AS DateTime2), 2)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (14, 200.0000, CAST(0x07604FBAB580923B0B AS DateTime2), 2)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (15, 285.5000, CAST(0x0720BEC6AA82923B0B AS DateTime2), 4)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (16, 1675.3500, CAST(0x0720BEC6AA82923B0B AS DateTime2), 4)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (17, 2324.6499, CAST(0x0720BEC6AA82923B0B AS DateTime2), 4)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (18, 21.5000, CAST(0x07700F26158B923B0B AS DateTime2), 5)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (19, 375.0000, CAST(0x07700F26158B923B0B AS DateTime2), 5)
INSERT [dbo].[Abono] ([ID_Abono], [CantidadAbono], [Fecha_abono], [ID_Credito]) VALUES (20, 325.0000, CAST(0x07700F26158B923B0B AS DateTime2), 5)
SET IDENTITY_INSERT [dbo].[Abono] OFF
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (1, N'Productos Lacteos                                 ')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (3, N'Granos Basicos                                    ')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (4, N'Cocinas                                           ')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (5, N'Higiene                                           ')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (6, N'Libreria                                          ')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre]) VALUES (7, N'Limpieza                                          ')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID_Cliente], [Cedula], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Segundo_Apellido], [Telefono], [Direccion]) VALUES (2, N'121-120595-0004D', N'Tatiana             ', N'Maria               ', N'Obando              ', N'Gonzalez            ', N'8725-1585', N'Hospital 3 al sur 2 oeste')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([ID_Compra], [ID_Proveedor], [Fecha], [Total]) VALUES (4, 2, CAST(0x0770595F9668913B0B AS DateTime2), 4400.0000)
INSERT [dbo].[Compra] ([ID_Compra], [ID_Proveedor], [Fecha], [Total]) VALUES (5, 2, CAST(0x07F05B01CB69923B0B AS DateTime2), 27450.0000)
INSERT [dbo].[Compra] ([ID_Compra], [ID_Proveedor], [Fecha], [Total]) VALUES (6, 2, CAST(0x07300D8E6C81923B0B AS DateTime2), 8220.0000)
INSERT [dbo].[Compra] ([ID_Compra], [ID_Proveedor], [Fecha], [Total]) VALUES (7, 2, CAST(0x079045CE0682923B0B AS DateTime2), 18450.0000)
SET IDENTITY_INSERT [dbo].[Compra] OFF
SET IDENTITY_INSERT [dbo].[Credito] ON 

INSERT [dbo].[Credito] ([ID_Credito], [Monto], [Fecha_Credito], [ID_Cliente], [ID_Venta]) VALUES (1, 660.0000, CAST(0x07D0FC8CAC4E923B0B AS DateTime2), 2, 3)
INSERT [dbo].[Credito] ([ID_Credito], [Monto], [Fecha_Credito], [ID_Cliente], [ID_Venta]) VALUES (2, 797.5000, CAST(0x071026251C6A923B0B AS DateTime2), 2, 4)
INSERT [dbo].[Credito] ([ID_Credito], [Monto], [Fecha_Credito], [ID_Cliente], [ID_Venta]) VALUES (3, 8398.5000, CAST(0x07301ED32B80923B0B AS DateTime2), 2, 7)
INSERT [dbo].[Credito] ([ID_Credito], [Monto], [Fecha_Credito], [ID_Cliente], [ID_Venta]) VALUES (4, 4285.5000, CAST(0x07B0B9432A82923B0B AS DateTime2), 2, 8)
INSERT [dbo].[Credito] ([ID_Credito], [Monto], [Fecha_Credito], [ID_Cliente], [ID_Venta]) VALUES (5, 721.5000, CAST(0x07F0300DD88A923B0B AS DateTime2), 2, 9)
SET IDENTITY_INSERT [dbo].[Credito] OFF
SET IDENTITY_INSERT [dbo].[Detalle Venta] ON 

INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (1, 15, 13.2000, 1, 2, 198.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (2, 35, 13.2000, 2, 2, 462.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (3, 50, 13.2000, 3, 2, 660.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (4, 5, 13.2000, 4, 2, 66.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (5, 8, 26.0000, 4, 3, 208.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (6, 1, 19.5000, 4, 5, 19.5000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (7, 12, 42.0000, 4, 6, 504.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (8, 42, 26.0000, 5, 3, 1092.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (9, 29, 19.5000, 5, 5, 565.5000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (10, 88, 42.0000, 5, 6, 3696.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (11, 45, 13.2000, 6, 2, 594.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (12, 50, 19.5000, 6, 5, 975.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (13, 35, 26.0000, 6, 3, 910.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (14, 43, 19.5000, 7, 5, 838.5000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (15, 180, 42.0000, 7, 6, 7560.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (16, 30, 24.3000, 8, 8, 729.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (17, 50, 42.0000, 8, 6, 2100.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (18, 7, 19.5000, 8, 5, 136.5000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (19, 100, 13.2000, 8, 2, 1320.0000)
INSERT [dbo].[Detalle Venta] ([ID_DetalleVenta], [Cantidad], [PrecioUnitario], [ID_Venta], [ID_Producto], [subtotal]) VALUES (20, 37, 19.5000, 9, 5, 721.5000)
SET IDENTITY_INSERT [dbo].[Detalle Venta] OFF
SET IDENTITY_INSERT [dbo].[DetalleCompra] ON 

INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (1, 400, 11.0000, 4400.0000, 4, 2)
INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (2, 230, 15.0000, 3450.0000, 5, 5)
INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (3, 450, 20.0000, 9000.0000, 5, 3)
INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (4, 500, 30.0000, 15000.0000, 5, 6)
INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (5, 685, 12.0000, 8220.0000, 6, 7)
INSERT [dbo].[DetalleCompra] ([ID_DetalleCompra], [Cantidad], [Precio], [subtotal], [ID_Compra], [ID_Producto]) VALUES (6, 1025, 18.0000, 18450.0000, 7, 8)
SET IDENTITY_INSERT [dbo].[DetalleCompra] OFF
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (2, 800, 11.0000, 20)
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (3, 365, 20.0000, 30)
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (5, 63, 15.0000, 30)
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (6, 170, 30.0000, 40)
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (7, 685, 12.0000, 50)
INSERT [dbo].[inventario] ([id_producto], [cantidad], [precio_compra], [porc_venta]) VALUES (8, 995, 18.0000, 35)
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (2, N'Azucar                        ', 3, 1)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (3, N'Leche                         ', 1, 2)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (5, N'Cepillo Diente                ', 1, 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (6, N'Platos                        ', 4, 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (7, N'Curachas                      ', 4, 0)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [ID_Categoria], [id_unidadMedida]) VALUES (8, N'Frijoles                      ', 3, 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([ID_Proveedor], [Num_Ruc], [Nombre_Compañia], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Segundo_Apellido], [Telefono], [Correo_Electronico], [Direccion]) VALUES (2, N'121-588118-0008D  ', N'Ferromax                                          ', N'Otoniel             ', N'Alfonso             ', N'Ortiz               ', N'Serrano             ', N'8481-8181', N'otoniel@hotmail.com', N'regina 3 al sur')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
SET IDENTITY_INSERT [dbo].[UnidadMedida] ON 

INSERT [dbo].[UnidadMedida] ([id_unidadMedida], [nombre]) VALUES (1, N'Libras              ')
INSERT [dbo].[UnidadMedida] ([id_unidadMedida], [nombre]) VALUES (2, N'Litros              ')
SET IDENTITY_INSERT [dbo].[UnidadMedida] OFF
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (1, 0, 2, CAST(0x07B0450D3487913B0B AS DateTime2), 198.0000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (2, 0, 2, CAST(0x07D0FC8CAC4E923B0B AS DateTime2), 462.0000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (3, 1, 2, CAST(0x07D0FC8CAC4E923B0B AS DateTime2), 660.0000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (4, 1, 2, CAST(0x071026251C6A923B0B AS DateTime2), 797.5000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (5, 0, 2, CAST(0x07A051A6B07A923B0B AS DateTime2), 5353.5000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (6, 0, 2, CAST(0x07301ED32B80923B0B AS DateTime2), 2479.0000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (7, 1, 2, CAST(0x07301ED32B80923B0B AS DateTime2), 8398.5000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (8, 1, 2, CAST(0x07B0B9432A82923B0B AS DateTime2), 4285.5000)
INSERT [dbo].[Venta] ([ID_Venta], [Credito], [ID_Cliente], [FechaVenta], [Total]) VALUES (9, 1, 2, CAST(0x07F0300DD88A923B0B AS DateTime2), 721.5000)
SET IDENTITY_INSERT [dbo].[Venta] OFF
/****** Object:  Index [Ref1332]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref1332] ON [dbo].[Abono]
(
	[ID_Credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref225]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref225] ON [dbo].[Compra]
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref129]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref129] ON [dbo].[Credito]
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref421]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref421] ON [dbo].[Detalle Venta]
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref727]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref727] ON [dbo].[Detalle Venta]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref726]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref726] ON [dbo].[DetalleCompra]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref924]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref924] ON [dbo].[DetalleCompra]
(
	[ID_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref331]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref331] ON [dbo].[Producto]
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Ref123]    Script Date: 2/7/2016 4:51:53 p. m. ******/
CREATE NONCLUSTERED INDEX [Ref123] ON [dbo].[Venta]
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Abono]  WITH CHECK ADD  CONSTRAINT [RefCredito32] FOREIGN KEY([ID_Credito])
REFERENCES [dbo].[Credito] ([ID_Credito])
GO
ALTER TABLE [dbo].[Abono] CHECK CONSTRAINT [RefCredito32]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [RefProveedor25] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [RefProveedor25]
GO
ALTER TABLE [dbo].[Credito]  WITH CHECK ADD  CONSTRAINT [FK_Credito_Venta] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Venta] ([ID_Venta])
GO
ALTER TABLE [dbo].[Credito] CHECK CONSTRAINT [FK_Credito_Venta]
GO
ALTER TABLE [dbo].[Credito]  WITH CHECK ADD  CONSTRAINT [RefCliente29] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Credito] CHECK CONSTRAINT [RefCliente29]
GO
ALTER TABLE [dbo].[Detalle Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle Venta_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle Venta] CHECK CONSTRAINT [FK_Detalle Venta_Producto]
GO
ALTER TABLE [dbo].[Detalle Venta]  WITH CHECK ADD  CONSTRAINT [RefVenta21] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Venta] ([ID_Venta])
GO
ALTER TABLE [dbo].[Detalle Venta] CHECK CONSTRAINT [RefVenta21]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Producto]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [RefCompra24] FOREIGN KEY([ID_Compra])
REFERENCES [dbo].[Compra] ([ID_Compra])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [RefCompra24]
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [FK_inventario_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [FK_inventario_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [RefCliente23] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [RefCliente23]
GO
USE [master]
GO
ALTER DATABASE [SistemaVenta] SET  READ_WRITE 
GO
