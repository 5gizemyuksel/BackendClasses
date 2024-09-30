-------------------------------------------------------------
------- 1-) Veri Tabanı Yaratma Adımı
-------------------------------------------------------------- go komutu önce yazdığım işlemi yap sonra alt komuta geç demek
USE master
GO

DROP DATABASE if exists LibraryManagement
go 

create database LibraryManagement 
GO

use LibraryManagement
go

-------------------------------------------------------------
------- 2) Tabloların YAratılması Adımı
--------------------------------------------------------------

Create table LibraryItems(
    Id int Primary key IDENTITY(1,1),
    Title NVARCHAR(100) not null,
    PublishedDate date not null,
    ItemType nvarchar(50) not null,

)
go

create table Books(
    ItemId int primary key,
    Author NVARCHAR(100) not null,
    foreign key(ItemId) REFERENCES LibraryItems(Id)

)
go

create table Magazines(
    ItemId int Primary key,
    IssueNumber nvarchar(50) not null,
    foreign key(ItemId) references LibraryItems(Id), 
)
go 

create table DVDs(
    ItemId int primary key,
    Director NVARCHAR(100) not null, 
    foreign key(ItemId) REFERENCES LibraryItems(Id),
)
go

create table members(
    Id int primary key IDENTITY(1,1),
    FullName NVARCHAR(100) not null,
    MembershipStatus NVARCHAR(50) not null,

)
go


create table ContactInfos(
    Id int primary key IDENTITY(1,1),
    MemberId int not null,
    ContactInfo NVARCHAR(255) not null,
    foreign key(MemberId) REFERENCES Members(Id),

)