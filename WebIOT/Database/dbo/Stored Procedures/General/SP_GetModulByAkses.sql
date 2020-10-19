CREATE PROCEDURE [dbo].[SP_GetModulByAkses]
	@IdUser bigint
AS
	select * from DataModule where IdModul in
	(
		select
		distinct IdModule
		from Role_MenuTree where IdMenu in (
			select
			IdMenu
			from GroupData_MenuAkses where IdRole in (select RoleId from UserData where id = @IdUser)
		)
	) 
	and Status = 1