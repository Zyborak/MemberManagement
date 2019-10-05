USE MemberManagement
GO 

CREATE TABLE [dbo].[Member](  
    [MemberID] [int] IDENTITY(1,1) NOT NULL,  
    [MemberTitle] [nchar](250) NULL,  
    [MemberImage] [nvarchar](max) NULL, 
	[MemberFirstName] [nchar](100) NULL,  
	[MemberLastName] [nchar](100) NULL, 
    [IsActive] [bit] NULL,  
    [CreatedDateTime] [datetime] NULL, 
    [UpdatedDateTime] [datetime] NULL,  
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED   
(  
    [MemberID] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]  