
use Okul
Create Table Bolumler(
    BolumID INT Primary key identity(1,1),
    BolumAdi NVARCHAR(50) not null 
    )

create table Dersler(
    DersID int primary key identity(1,1),
    DersAdi NVARCHAR(100) not null,
    Kredi tinyint not null, 
    BolumID int not null,
    foreign key (BolumID) references Bolumler(BolumID)
)

create table Ogrenciler(
    OgrendiID int primary key identity(1,1),
    Ad NVARCHAR(50) not null,
    Soyad NVARCHAR(50) not null,
    DogumTarihi DATE null,
    BolumID int not null,
    foreign key(BolumID) REFERENCES Bolumler(BolumID)
)

create table DersKayitlari(
    OgrenciID int ,
    DersID int,
    primary key(OgrenciID,DersID),
    foreign key(OgrenciID) references Ogrenciler(OgrenciID),
    foreign key(DersID) references Dersler(DersID)
)