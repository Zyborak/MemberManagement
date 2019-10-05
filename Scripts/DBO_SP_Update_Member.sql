USE [MemberManagement]
GO

CREATE OR ALTER PROCEDURE [dbo].[SP_Update_member]    
    @MemberId INT,  
    @MemberTitle NVARCHAR(250) ,      
    @MemberImage NVARCHAR(Max) ,      
    @MemberFirstName NVARCHAR(100) ,   
	@MemberLastName NVARCHAR(100) ,  
    @IsActive BIT ,      
    @UpdatedDateTime DATETIME   
          
AS        
    BEGIN        
     UPDATE m   
     SET    
            m.MemberTitle = @MemberTitle,    
            m.MemberImage = @MemberImage,    
            m.MemberFirstName = @MemberFirstName, 
			m.MemberLastName = @MemberLastName,
            m.IsActive = @IsActive,     
            m.UpdatedDateTime = @UpdatedDateTime  
  FROM [Member] m    
  WHERE MemberId = @MemberId   
    END;        