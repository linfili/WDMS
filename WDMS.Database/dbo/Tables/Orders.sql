﻿CREATE TABLE [dbo].[Orders] (
    [OrderBatchId] INT           IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT           NOT NULL,
    [Status]       NVARCHAR (50) NULL,
    [Operator]     INT           NOT NULL,
    [Assistant]    INT           NULL,
    [CreateTime]   DATETIME      CONSTRAINT [DF_Orders_CreateTime] DEFAULT (getdate()) NOT NULL,
    [UpdateTime]   DATETIME      NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderBatchId] ASC),
    CONSTRAINT [FK_Orders_Assistant] FOREIGN KEY ([Assistant]) REFERENCES [dbo].[Admin] ([AdminId]),
    CONSTRAINT [FK_Orders_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]),
    CONSTRAINT [FK_Orders_Operator] FOREIGN KEY ([Operator]) REFERENCES [dbo].[Admin] ([AdminId])
);







