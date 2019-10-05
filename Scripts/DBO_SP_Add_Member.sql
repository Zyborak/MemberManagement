USE [MemberManagement]
GO

CREATE OR ALTER PROCEDURE [dbo].[SP_Add_Member]      
    @MemberTitle NVARCHAR(250) ,      
    @MemberImage NVARCHAR(Max) ,      
    @MemberFirstName NVARCHAR(100) ,   
	@MemberLastName NVARCHAR(100) ,  
    @IsActive BIT ,     
    @CreatedDateTime DATETIME , 
    @UpdatedDateTime DATETIME    
        
AS      
    BEGIN      
		DECLARE @MemberId as BIGINT    
        INSERT INTO [dbo].[Member]
           ([MemberTitle]
           ,[MemberImage]
           ,[MemberFirstName]
           ,[MemberLastName]
           ,[IsActive]
           ,[CreatedDateTime]
           ,[UpdatedDateTime])
        VALUES  ( @MemberTitle			
				  ,@MemberImage
                  ,@MemberFirstName    
                  ,@MemberLastName     
                  ,@IsActive       
                  ,@CreatedDateTime 
                  ,@UpdatedDateTime    
             );     
        SET @MemberId = SCOPE_IDENTITY();     
        SELECT  @MemberId AS JobId;      
    END; 

