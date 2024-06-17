	-- Insert List des roles utilisateur
	
	USE [doctoDb_Dev]

	SET NOCOUNT ON;

    SET IDENTITY_INSERT Roles ON 

	INSERT INTO [dbo].[Roles]([Id],[CreatedAt],[LastModifAt] ,[Libelle],[Description],[Code])
     VALUES
           (1,GETDATE(),GETDATE(),'Admin' ,'Adminstrateur'  ,'Admin'),
		   (2,GETDATE(),GETDATE(),'Patient' ,'Patient'  ,'Patient'),
		   (3,GETDATE(),GETDATE(),'Praticien' ,'Praticien'  ,'Praticien')

	SET IDENTITY_INSERT Roles OFF 