USE dblojinha
GO

CREATE PROCEDURE [dbo].[exclui_cliente]
    @codigo int
AS
    DELETE FROM CLIENTES WHERE codigo = @codigo

EXEC exclui_cliente 1 

SELECT * FROM CLIENTES;

