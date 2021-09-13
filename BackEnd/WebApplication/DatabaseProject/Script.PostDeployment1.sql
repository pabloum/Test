/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

BEGIN
  IF NOT EXISTS (SELECT Id FROM [dbo].[User] WHERE Id = 1)
  BEGIN
    insert into [dbo].[User] values (1, 'Pablo', 'Uribe', 'puribe')
  END
END


BEGIN
  IF NOT EXISTS (SELECT Id FROM [dbo].[User] WHERE Id = 2)
  BEGIN
    INSERT INTO [dbo].[User] VALUES (2, 'James', 'Rodriguez', 'jrodriguez')
  END
END

BEGIN
  IF NOT EXISTS (SELECT Id FROM [dbo].[User] WHERE Id = 3)
  BEGIN
    INSERT INTO [dbo].[User] VALUES (3, 'Vero', 'Sharapova', 'vsharapova')
  END
END

BEGIN
  IF NOT EXISTS (SELECT Id FROM [dbo].[User] WHERE Id = 4)
  BEGIN
    INSERT INTO [dbo].[User] VALUES (4, 'Cristiano', 'Ronaldo', 'serresiete')
  END
END

BEGIN
  IF NOT EXISTS (SELECT Id FROM [dbo].[User] WHERE Id = 5)
  BEGIN
    INSERT INTO [dbo].[User] VALUES (5, 'Lionel', 'Messi', 'Liomessi')
  END
END