﻿CREATE TABLE [dbo].[OrderDetails] (
    [OrderDatailId]           INT             IDENTITY (1, 1) NOT NULL,
    [OrderBatchId] INT             NOT NULL,
    [OrderType]    NVARCHAR (50)   NULL,
    [InventoryId]  INT             NOT NULL,
    [DeliveryWay]  NVARCHAR (10)   NULL,
    [ExpressNo]    NVARCHAR (50)   NULL,
    [Price]        DECIMAL (15, 2) NULL,
    [Status]       NVARCHAR (50)   NULL,
    [Operator]     INT             NOT NULL,
	[CreateTime] Datetime not null,
	[UpdateTime] datetime null,
    [Remark]       NVARCHAR (200)  NULL
);

