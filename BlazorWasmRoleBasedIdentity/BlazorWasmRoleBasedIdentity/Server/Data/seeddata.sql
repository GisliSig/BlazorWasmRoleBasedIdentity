INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8ed99460-75ea-43d0-a296-57b00f83631e', N'Admin', N'ADMIN', N'awefkjwekfl')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b915d5dd-2e34-4d36-b12a-09a87de6e0c0', N'User', N'USER', N'34234wdfgsadf')
GO
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] ON 

GO
INSERT [dbo].[AspNetRoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue]) VALUES (4, N'8ed99460-75ea-43d0-a296-57b00f83631e', N'permission', N'edit')
GO
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a58473a4-c4c2-48f1-91da-bad9905eef84', N'user@superduperagency.com', N'USER@SUPERDUPERAGENCY.COM', N'user@superduperagency.com', N'USER@SUPERDUPERAGENCY.COM', 1, N'AQAAAAEAACcQAAAAEIVqMpxaa/rNk1zLwuw49THJRuTn+wcScin6kMlcg5eeeWyrE3yvn+5CnDmfFMyl6Q==', N'DID5MEXHJOPFP2L35FZRABBX7GILRDCM', N'a0e380c1-6811-4b19-80da-6b0615699eb5', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cedb032c-92fa-4e4d-9816-269e836a77ac', N'admin@superduperagency.com', N'ADMIN@SUPERDUPERAGENCY.COM', N'admin@superduperagency.com', N'ADMIN@SUPERDUPERAGENCY.COM', 1, N'AQAAAAEAACcQAAAAEM74MxNAi/5orrTxP6Jdv3M+Qr+0iHktG9DAoD8xee+JqwpUeyJqXoObbrDvkQJBnA==', N'RHZQ2RCVX7H2A2P3OKNSHBGRPEAUX3VL', N'22c3c22c-a092-4706-9018-6c4e6b9999ee', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cedb032c-92fa-4e4d-9816-269e836a77ac', N'8ed99460-75ea-43d0-a296-57b00f83631e')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a58473a4-c4c2-48f1-91da-bad9905eef84', N'b915d5dd-2e34-4d36-b12a-09a87de6e0c0')
GO
