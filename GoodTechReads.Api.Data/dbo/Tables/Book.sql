CREATE TABLE [dbo].[Book] (
    [BookId]          INT           NOT NULL,
    [Title]           VARCHAR (100) NOT NULL,
    [PublicationDate] DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([BookId] ASC)
);

