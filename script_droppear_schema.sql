USE [GD1C2018];
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'spDropSchema')
    BEGIN
        DROP  PROCEDURE  spDropSchema
    END
GO

CREATE PROCEDURE spDropSchema
AS

DECLARE @Sql NVARCHAR(MAX) = '';
DECLARE @Schema CHAR(4) = 'FAGD';

--MatarConstraints
SELECT @Sql = @Sql + 'ALTER TABLE '+ QUOTENAME(@Schema) + '.' + QUOTENAME(t.name) + ' DROP CONSTRAINT ' + QUOTENAME(f.name)  + ';' + CHAR(13)
FROM sys.tables t 
    JOIN sys.foreign_keys f on f.parent_object_id = t.object_id 
    JOIN sys.schemas s on t.schema_id = s.schema_id
WHERE s.name = @Schema
ORDER BY t.name;

--DropearLasTablas
SELECT @Sql = @Sql + 'DROP TABLE '+ QUOTENAME(@Schema) +'.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema AND TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME

--EliminarLosProcedimientos
SELECT @Sql = @Sql + 'DROP PROCEDURE '+ QUOTENAME(@Schema) +'.' + QUOTENAME(ROUTINE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_SCHEMA = @Schema AND ROUTINE_TYPE = 'PROCEDURE'
ORDER BY ROUTINE_NAME

--EliminarLasFunciones
SELECT @Sql = @Sql + 'DROP FUNCTION '+ QUOTENAME(@Schema) +'.' + QUOTENAME(ROUTINE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_SCHEMA = @Schema AND ROUTINE_TYPE = 'FUNCTION'
ORDER BY ROUTINE_NAME


SELECT @Sql = @Sql + 'DROP SCHEMA '+ QUOTENAME(@Schema) + ';' + CHAR(13)

EXECUTE sp_executesql @Sql
GO


EXECUTE spDropSchema
GO