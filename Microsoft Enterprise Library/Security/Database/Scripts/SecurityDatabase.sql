IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Security')
	DROP DATABASE [Security]
GO

CREATE DATABASE [Security]
   COLLATE SQL_Latin1_General_CP1_CI_AS
GO

exec sp_dboption N'Security', N'autoclose', N'false'
GO

exec sp_dboption N'Security', N'bulkcopy', N'false'
GO

exec sp_dboption N'Security', N'trunc. log', N'false'
GO

exec sp_dboption N'Security', N'torn page detection', N'true'
GO

exec sp_dboption N'Security', N'read only', N'false'
GO

exec sp_dboption N'Security', N'dbo use', N'false'
GO

exec sp_dboption N'Security', N'single', N'false'
GO

exec sp_dboption N'Security', N'autoshrink', N'false'
GO

exec sp_dboption N'Security', N'ANSI null default', N'false'
GO

exec sp_dboption N'Security', N'recursive triggers', N'false'
GO

exec sp_dboption N'Security', N'ANSI nulls', N'false'
GO

exec sp_dboption N'Security', N'concat null yields null', N'false'
GO

exec sp_dboption N'Security', N'cursor close on commit', N'false'
GO

exec sp_dboption N'Security', N'default to local cursor', N'false'
GO

exec sp_dboption N'Security', N'quoted identifier', N'false'
GO

exec sp_dboption N'Security', N'ANSI warnings', N'false'
GO

exec sp_dboption N'Security', N'auto create statistics', N'true'
GO

exec sp_dboption N'Security', N'auto update statistics', N'true'
GO

use [Security]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_UserRoles_Role]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[UserRoles] DROP CONSTRAINT FK_UserRoles_Role
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Profiles_Users]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Profiles] DROP CONSTRAINT FK_Profiles_Users
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_UserRoles_Users]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[UserRoles] DROP CONSTRAINT FK_UserRoles_Users
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AddProfile]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[AddProfile]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AddUserToRoleByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[AddUserToRoleByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DeleteProfile]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DeleteProfile]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DeleteRoleByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DeleteRoleByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DeleteUserByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[DeleteUserByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetProfile]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetProfile]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetRolesByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetRolesByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetUserInRoleByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetUserInRoleByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RemoveUserFromRoleByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[RemoveUserFromRoleByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChangePasswordById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ChangePasswordById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ChangePasswordByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ChangePasswordByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetAllRoles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetAllRoles]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetAllUsers]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetAllUsers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetPassword]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetPassword]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetRoleIdByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetRoleIdByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetUserIdByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetUserIdByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InsertRole]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[InsertRole]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InsertUser]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[InsertUser]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateRoleById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[UpdateRoleById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateUserById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[UpdateUserById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GetProfileColumnSize]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[GetProfileColumnSize]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Profiles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Profiles]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserRoles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserRoles]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Roles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Roles]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Users]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Users]
GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Roles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[Roles] (
	[RoleID] [int] IDENTITY (1, 1) NOT NULL ,
	[RoleName] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
) ON [PRIMARY]
END

GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Users]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[Users] (
	[UserID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [nvarchar] (256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Password] [varbinary] (64) NOT NULL 
) ON [PRIMARY]
END

GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Profiles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[Profiles] (
	[ProfileID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserID] [int] NOT NULL ,
	[Profile] [binary] (4096) NULL 
) ON [PRIMARY]
END

GO

if not exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserRoles]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
 BEGIN
CREATE TABLE [dbo].[UserRoles] (
	[UserID] [int] NOT NULL ,
	[RoleID] [int] NOT NULL 
) ON [PRIMARY]
END

GO

ALTER TABLE [dbo].[Roles] WITH NOCHECK ADD 
	CONSTRAINT [PK_Role] PRIMARY KEY  CLUSTERED 
	(
		[RoleID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Users] WITH NOCHECK ADD 
	CONSTRAINT [PK_Users] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Profiles] WITH NOCHECK ADD 
	CONSTRAINT [PK_Profile] PRIMARY KEY  CLUSTERED 
	(
		[ProfileID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[UserRoles] WITH NOCHECK ADD 
	CONSTRAINT [PK_UserRoles] PRIMARY KEY  CLUSTERED 
	(
		[UserID],
		[RoleID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Roles] WITH NOCHECK ADD 
	CONSTRAINT [IX_Role] UNIQUE  NONCLUSTERED 
	(
		[RoleName]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Users] WITH NOCHECK ADD 
	CONSTRAINT [IX_Users_Name] UNIQUE  NONCLUSTERED 
	(
		[UserName]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Profiles] ADD 
	CONSTRAINT [FK_Profiles_Users] FOREIGN KEY 
	(
		[UserID]
	) REFERENCES [dbo].[Users] (
		[UserID]
	)
GO

ALTER TABLE [dbo].[UserRoles] ADD 
	CONSTRAINT [FK_UserRoles_Role] FOREIGN KEY 
	(
		[RoleID]
	) REFERENCES [dbo].[Roles] (
		[RoleID]
	),
	CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY 
	(
		[UserID]
	) REFERENCES [dbo].[Users] (
		[UserID]
	)
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetProfileColumnSize
	@profileSize int OUT
AS

SELECT @profileSize = CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.Columns 
WHERE 
	TABLE_NAME = 'Profiles' AND
	COLUMN_NAME = 'Profile'




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.ChangePasswordById
	@userId	int,
	@password	varbinary(64)
AS

	UPDATE Users
	SET Password = @password
	WHERE UserID = @userId

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.ChangePasswordByName
	@name nvarchar(256),
	@password varbinary(64)
AS

	select @password = IsNull(@password, 0xFFFF)

	UPDATE Users
	SET Password = @password
	WHERE UserName = @name

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetAllRoles
AS

	SET NOCOUNT ON
	
	SELECT RoleName
	FROM Roles





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetAllUsers
AS

	SET NOCOUNT ON
	
	SELECT UserName
	FROM Users




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetPassword
	@name nvarchar(256)
AS
	SET NOCOUNT ON

	SELECT	
		Password
	FROM Users
	WHERE UserName = @name

	SET NOCOUNT OFF

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetRoleIdByName
	@name	nvarchar(256),
	@roleID int OUT
AS

	SELECT @roleID = RoleID 
	FROM Roles 
	WHERE RoleName = @name

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetUserIdByName
	@name nvarchar(256),
	@userId int OUT
AS

	SELECT @userId = UserID
	FROM Users
	WHERE UserName = @name

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.InsertRole
	@name	nvarchar(256)
AS

	INSERT INTO Roles
		(RoleName)
	VALUES
		(@name)

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.InsertUser
	@name nvarchar(256),
	@password varbinary(64),
	@userExists tinyint out
AS

IF EXISTS (SELECT UserName FROM users WHERE UserName = @name)
BEGIN
	SELECT @userExists = 1
	RETURN
END

SELECT @userExists = 0

SELECT @password = IsNull(@password, 0x691B0FBEED8F399F7E12576B090B217E4AD88A09)

INSERT INTO Users
	(UserName, Password)
VALUES
	(@name, @password)

RETURN 



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.UpdateRoleById
	@roleID int,
	@roleName nvarchar(256)
AS

	UPDATE Roles
	SET RoleName = @roleName
	WHERE RoleID = @roleID

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.UpdateUserById
	@userId int,
	@name nvarchar(256)
AS

	UPDATE Users
	SET UserName = @name
	WHERE UserID = @userId

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.AddProfile
	@userName nvarchar(256),
	@profile binary(4096)
AS

	DECLARE @userId int 

	EXEC GetUserIdByName @userName, @userId OUT

	INSERT Profiles 
		(userId, [profile])
	VALUES
		(@userId, @profile)




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.AddUserToRoleByName
	@name nvarchar(256),
	@roleName nvarchar(256)
AS
DECLARE @userId int, @roleID int

EXEC GetUserIdByName @name, @userId OUT
EXEC GetRoleIdByName @roleName, @roleID OUT

INSERT INTO UserRoles
	(UserID, RoleID)
VALUES
	(@userId, @roleID)
	



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.DeleteProfile
	@userName nvarchar(256)
AS

	DECLARE @userId int 

	EXEC GetUserIdByName @userName, @userId OUT

	DELETE Profiles 
	WHERE UserId = @userId





GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.DeleteRoleByName
	@name nvarchar(256)
AS

	DECLARE @roleID int, @firstOpError tinyint

	EXEC GetRoleIdByName @name, @roleID OUT

	IF (@roleID IS NULL) RAISERROR('No Role with that name', 16, 99)

	BEGIN
		BEGIN TRANSACTION
		 
		DELETE FROM UserRoles 
		WHERE RoleID = @roleID
		select @firstOpError = @@ERROR
		
		DELETE FROM Roles 
		WHERE RoleID = @roleID

		IF (@@ERROR = 0) AND (@firstOpError = 0)
			COMMIT
		ELSE
			ROLLBACK
	END
	
RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.DeleteUserByName
	@name nvarchar(256)
AS

	DECLARE @userId int, @errorFound tinyint
	Select @errorFound = 0
	
	BEGIN TRANSACTION

	EXEC GetUserIdByName @name, @userId OUT
	IF @@ERROR > 0 SET @errorFound = 1
		
	DELETE UserRoles
	WHERE UserID = @userId
	IF @@ERROR > 0 SET @errorFound = 1
	
	DELETE Profiles
	WHERE UserID = @userId
	IF @@ERROR > 0 SET @errorFound = 1
		
	DELETE FROM Users 
	WHERE UserID = @userId

	IF (@@ERROR > 0) OR (@errorFound > 0)
		ROLLBACK
	ELSE
		COMMIT
	
RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetProfile
	@userName nvarchar(256),
	@profile binary(4096) OUT
AS

	DECLARE @userId int 

	EXEC GetUserIdByName @userName, @userId OUT

	SELECT 
		@profile = [Profile]
	FROM Profiles 
	WHERE UserId = @userId




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetRolesByName
	@name nvarchar(256)
AS

	DECLARE @userId int

	EXEC GetUserIdByName @name, @userId OUT

	SELECT 
		Roles.RoleID, 
		Roles.RoleName
	FROM Users
		JOIN UserRoles
		ON Users.UserID = UserRoles.UserID
		JOIN Roles
		ON UserRoles.RoleID = Roles.RoleID
	WHERE Users.UserID = @userId

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.GetUserInRoleByName
	@roleName nvarchar(256)
AS

	DECLARE @roleID int

	EXEC GetRoleIdByName @roleName, @roleID OUT

	SELECT Users.UserID, Users.UserName
	FROM Roles 
		JOIN UserRoles
			ON Roles.RoleID = UserRoles.RoleID
		JOIN Users
			ON UserRoles.UserID = Users.UserID
	WHERE Roles.RoleID = @roleID

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.RemoveUserFromRoleByName
	@username nvarchar(256),
	@roleName nvarchar(256)
AS

	DECLARE @userId int
	DECLARE @roleID int

	EXEC GetUserIdByName @username, @userId OUT
	if ( @userId IS NULL ) RAISERROR(@username, 16, 99)
	
	EXEC GetRoleIdByName @roleName, @roleID OUT
	if (@roleID IS NULL) RAISERROR(@roleName, 16, 98);

	DELETE FROM UserRoles
	WHERE UserID = @userId
	AND RoleID = @roleID

RETURN



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

