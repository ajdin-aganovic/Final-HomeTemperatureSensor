create database homeTemperatureSensor

use homeTemperatureSensor

create table sobe
(
	SobaID int primary key,
	NazivSobe varchar(20)
)

create table podaci
(
	RedniBrojID int primary key identity(1,1),
	TemperaturaCelzijusa float,
	TemperaturaFarenhajta float,
	SobaID int,
	Vrijeme datetime,
	StatusAlarma varchar(3)
)

insert sobe 
values (1,'Dnevni boravak'), 
(2,'Kuhinja'),
(3,'Trpezarija'),
(4,'Spavaæa soba'),
(5,'Djeèija soba')

select*
from sobe

select*
from podaci

ALTER TABLE podaci
ADD FOREIGN KEY (SobaID) REFERENCES sobe(SobaID) 





















































