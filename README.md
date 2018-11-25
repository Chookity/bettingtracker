# BettingTracker

Lep pozdrav,

najprej: 

File -> open -> Project -> najdeš kje imas in odpres bettracker.sln

tools -> connect to database
server name : (localdb)\mssqllocaldb
database: master

gres do server explorer, zberes eno bazo in dajes create table:

CREATE TABLE [dbo].[Drzava] (
    [ID_drzava] INT        NOT NULL,
    [Ime]       NCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_drzava] ASC)
);

CREATE TABLE [dbo].[Ekipa] (
    [ID_ekipa] INT            IDENTITY (1, 1) NOT NULL,
    [Ime]      NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Ekipa] PRIMARY KEY CLUSTERED ([ID_ekipa] ASC)
);

CREATE TABLE [dbo].[Sport] (
    [ID_sport] INT   NOT NULL,
    [Naziv]    NTEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_sport] ASC)
);

CREATE TABLE [dbo].[Uporabnik] (
    [ID_uporabnik] INT            IDENTITY (1, 1) NOT NULL,
    [Ime]          NVARCHAR (MAX) NOT NULL,
    [Priimek]      NVARCHAR (MAX) NOT NULL,
    [Email]        NVARCHAR (MAX) NOT NULL,
    [Drzava]       NVARCHAR (MAX) NOT NULL,
    [Geslo]        NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Uporabnik] PRIMARY KEY CLUSTERED ([ID_uporabnik] ASC)
);

CREATE TABLE [dbo].[Stava] (
    [ID_stava]       INT  IDENTITY (1, 1) NOT NULL,
    [ID_ekipa_doma]  INT  NOT NULL,
    [ID_ekipa_goste] INT  NOT NULL,
    [Kvota]          REAL NOT NULL,
    [Kolicina]       REAL NOT NULL,
    [Izid]           INT  NULL,
    [Izbera]         INT  NOT NULL,
    [ID_sport]       INT  NOT NULL,
    [ID_uporabnik]   INT  NOT NULL,
    CONSTRAINT [PK_Stava] PRIMARY KEY CLUSTERED ([ID_stava] ASC),
    FOREIGN KEY ([ID_sport]) REFERENCES [dbo].[Sport] ([ID_sport]),
    FOREIGN KEY ([ID_ekipa_doma]) REFERENCES [dbo].[Ekipa] ([ID_ekipa]),
    FOREIGN KEY ([ID_ekipa_goste]) REFERENCES [dbo].[Ekipa] ([ID_ekipa]),
    FOREIGN KEY ([ID_uporabnik]) REFERENCES [dbo].[Uporabnik] ([ID_uporabnik])
);

ko vse to vneses, vnesi nekaj podatkov za drzavo in sport

show table data in ročno vneses.

če ti normaln runup ne dela, potem probi zamenjats iz iis na bettracker.

če ti baza ne dela potem pojdi v appsettings.json in spremeni database string connection settings









