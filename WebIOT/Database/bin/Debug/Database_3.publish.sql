﻿/*
Deployment script for DBIOT

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DBIOT"
:setvar DefaultFilePrefix "DBIOT"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[SP_MenuData_Save]...';


GO
SET ANSI_NULLS, QUOTED_IDENTIFIER OFF;


GO
CREATE PROCEDURE [dbo].[SP_MenuData_Save]  
 @idMenu bigint,  
 @NamaMenu nvarchar(max),  
 @Action nvarchar(max),  
 @Controller nvarchar(max),  
 @Platform nvarchar(max),  
 @Img nvarchar(max),  
 @Status bigint  
AS  
  
declare @Title nvarchar(max)  
declare @Message nvarchar(max)  
declare @MStatus nvarchar(max)  
  
declare @Id bigint  
set @Id = 0  
if(@idMenu = 0)  
begin  
 if not exists(select*from [dbo].[DataMenu] where NamaMenu = @NamaMenu)  
 begin  
  insert into DataMenu  
  (  
   NamaMenu,  
   Action,  
   Controller,  
   Platform,  
   Img,  
   Status  
  )  
  values   
  (  
   @NamaMenu,  
   @Action,  
   @Controller,  
   @Platform,  
   @Img,  
   @Status  
  )  
  set @Id = (select idMenu from DataMenu where idMenu = SCOPE_IDENTITY())  
  set @Title = 'Success'  
  set @Message = 'Penambahan Menu '+ @NamaMenu + ' berhasil dibuat'  
  set @MStatus = 'success'  
 end  
 else  
 begin  
  set @Title = 'Sorry'  
  set @Message = 'Modul '+ @NamaMenu + ' already exists'  
  set @MStatus = 'error'  
 end  
end  
else  
begin  
 declare @namamenu_sebelum nvarchar(max)  
 set @namamenu_sebelum = (select NamaMenu from DataMenu where idMenu=@idMenu)  
 if(@namamenu_sebelum = @NamaMenu)  
 begin  
  update DataMenu  
  set   
   NamaMenu=@NamaMenu,  
   Action=@Action,  
   Controller=@Controller,  
   Platform=@Platform,  
   Img=@Img,  
   Status=@Status  
  where   
  idmenu=@idMenu  
  
  set @Id = @idMenu  
  set @Title = 'Success'  
  set @Message = 'Menu '+ @NamaMenu + ' berhasil diupdate'  
  set @MStatus = 'success'  
  
 end  
 else  
 begin  
  declare @idmodule_sama bigint  
  if((select count(*) from DataMenu where NamaMenu= @NamaMenu) > 0)  
  begin  
   set @Id = @idMenu  
   set @Title = 'Sorry'  
   set @Message = 'Modul '+ @NamaMenu + ' already exists, silahkan cari nama lain'  
   set @MStatus = 'error'  
  end  
  else  
  begin  
   update DataMenu  
   set   
    NamaMenu=@NamaMenu,  
    Action=@Action,  
    Controller=@Controller,  
    Platform=@Platform,  
    Img=@Img,  
    Status=@Status  
   where   
   idMenu=@idMenu  
  
   set @Id = @idMenu  
   set @Title = 'Success'  
   set @Message = 'Menu '+ @NamaMenu + ' berhasil diupdate'  
   set @MStatus = 'success'  
  end  
 end  
  
end  
  
  
select @Title Title, @Message Message, @MStatus Status, @Id Id
GO
SET ANSI_NULLS, QUOTED_IDENTIFIER ON;


GO
PRINT N'Update complete.';


GO