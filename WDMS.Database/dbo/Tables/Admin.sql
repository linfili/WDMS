﻿CREATE TABLE [dbo].[Admin] (
    [AdminId]     INT           IDENTITY (1, 1) NOT NULL,
    [AdminRoldId] INT           NOT NULL,
    [AdminName]   NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NULL
);

