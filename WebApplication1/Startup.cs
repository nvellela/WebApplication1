﻿using Owin;

namespace IdentitySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}



//CREATE TABLE[dbo].[Users](
//	[Id]
//[int]
//Identity NOT NULL,
//	[Email]
//[nvarchar](256) NULL,
//	[EmailConfirmed]
//[bit]
//NOT NULL,
//    [PasswordHash] [nvarchar](max) NULL,
//	[SecurityStamp]
//[nvarchar](max) NULL,
//	[PhoneNumber]
//[nvarchar](max) NULL,
//	[PhoneNumberConfirmed]
//[bit]
//NOT NULL,
//    [TwoFactorEnabled] [bit]
//NOT NULL,
//    [LockoutEndDateUtc] [datetime]
//NULL,
//	[LockoutEnabled]
//[bit]
//NOT NULL,
//    [AccessFailedCount] [int]
//NOT NULL,
//    [UserName] [nvarchar](256) NOT NULL,
//CONSTRAINT[PK_dbo.Users] PRIMARY KEY CLUSTERED
//(
//[Id] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]

//GO
