CREATE TABLE [dbo].[GlyphParams] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Value]         NVARCHAR (32) NOT NULL,
    [Id_glyph_type] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id_glyph_type]) REFERENCES [dbo].[GlyphTypes] ([Id])
);

CREATE TABLE [dbo].[Glyphs] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Title]          NVARCHAR (1) NOT NULL,
    [Id_glyph_param] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id_glyph_param]) REFERENCES [dbo].[GlyphParams] ([Id])
);

CREATE TABLE [dbo].[GlyphTypes] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Type] NVARCHAR (10) NOT NULL,
    [Circle_Radio] NUMERIC(5, 2) NOT NULL DEFAULT 0, 
    [Circle_Ratio] NUMERIC(5, 2) NOT NULL DEFAULT 0, 
    [Width] NUMERIC(5, 2) NOT NULL DEFAULT 0, 
    [Heigth] NUMERIC(5, 2) NOT NULL DEFAULT 0, 
    [Lines] INT NOT NULL DEFAULT 0, 
    [Tokens] INT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
------------------------------------------------------------------------
INSERT INTO dbo.[GlyphTypes] (Type, Circle_Radio, Circle_Ratio, Width, Heigth, Lines, Tokens) VALUES ('6-dots', 6, 25, 30, 40, 10, 10); 
INSERT INTO dbo.[GlyphTypes] (Type, Circle_Radio, Circle_Ratio, Width, Heigth, Lines, Tokens) VALUES ('8-dots', 6, 25, 30, 40, 10, 10); 
------------------------------------------------------------------------
SELECT * FROM dbo.[GlyphTypes];
------------------------------------------------------------------------
INSERT INTO dbo.[GlyphParams] (Value, ID_Glyph_type) VALUES ('1;1|', 1);
INSERT INTO dbo.[GlyphParams] (Value, ID_Glyph_type) VALUES ('1;1|1;2|', 1);
INSERT INTO dbo.[GlyphParams] (Value, ID_Glyph_type) VALUES ('1;1|2;1|', 1);
------------------------------------------------------------------------
SELECT * FROM dbo.[GlyphParams];
------------------------------------------------------------------------
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('A', 2);
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('B', 3);
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('C', 4);
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('1', 2);
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('2', 3);
INSERT INTO dbo.[Glyphs] (Title, Id_glyph_param) VALUES ('3', 4);
------------------------------------------------------------------------
DELETE FROM dbo.[Glyphs];
SELECT * FROM dbo.[Glyphs];