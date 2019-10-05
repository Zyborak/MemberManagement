USE MemberManagement
GO

CREATE OR ALTER PROCEDURE [dbo].[SP_Member_List]      
AS  
BEGIN  
      
    SET NOCOUNT ON;  
    SELECT 
			[MemberID]
		   ,[MemberTitle]
           ,[MemberImage]
           ,[MemberFirstName]
           ,[MemberLastName]
           ,[IsActive]
           ,[CreatedDateTime]
           ,[UpdatedDateTime] 
	FROM [Member]   
    END  