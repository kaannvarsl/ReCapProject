CREATE TABLE Cars(
CarId int PRIMARY KEY IDENTITY(1,1), 
BrandId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Descriptions nvarchar(250),

)

CREATE TABLE Brands(
BrandId int PRIMARY KEY IDENTITY(1,1),
BrandName nvarchar(50),
)

CREATE TABLE Colors(
ColorId int PRIMARY KEY IDENTITY(1,1),
ColorName nvarchar(50),
)



INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) VALUES


(1,1,'2018',500,'SUV'),
(1,2,'2020',600,'4x4'),
(2,2,'2016',700,'2.el Arac'),
(2,1,'2015',300,'Klasik Arac'),
(3,3,'2021',450,'Spor Arac')

INSERT INTO Colors(ColorName) VALUES ('Gri'),('Siyah'),('Beyaz'),('Mavi');
INSERT INTO Brands(BrandName) VALUES ('Mercedes'),('Volvo'),('BMW'),('Honda');