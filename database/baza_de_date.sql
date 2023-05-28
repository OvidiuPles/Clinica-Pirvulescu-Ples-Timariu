
create database Clinica_II
use Clinica_II

create table Pacienti(
 Nume varchar(20) not null,
 Prenume varchar(20) not null,
 CNP varchar(13) not null,
 Telefon varchar(10)not null,
 Email varchar(40) not null,
 Sex varchar(10) not null
 Primary key (CNP)
 );

 create table Doctori(
  Nume varchar(20) not null,
 Prenume varchar(20) not null,
 CNP varchar(13) not null,
 Telefon varchar(10) not null,
 Email varchar(40) not null,
 Specializare varchar(40),
 Sex varchar(10) not null,
 Descriere varchar (200)
 Primary key (CNP)
 );

 create table Users (
CNPp varchar(13)  ,
CNPd varchar(13),
username varchar(30) not null,
parola varchar (20) not null,

primary key (username),
foreign key (CNPp) references Pacienti(CNP),
foreign key (CNPd) references Doctori(CNP),
 );

 create table LogedUser (
username varchar(30),
primary key(username),
 );
--trebuie initializat
insert into LogedUser (username) values ('null')

create table Programari(
 username varchar(30) not null,
 simptome varchar(1000),
 medic varchar(30),
 data varchar(20),
 ora varchar(20),
 id int IDENTITY(1,1) primary key,
 foreign key (username) references Users(username),
 );

create table PacientiMedic (
username varchar(30) not null,
numeMedic varchar (30) not null,
id int IDENTITY(1,1) primary key,

foreign key (username) references Users(username),
 );

 create table Afectiuni(
 username varchar(30) not null,
 medic varchar(30),
 afectiune varchar(100),
 reteta varchar(1000),
 id int IDENTITY(1,1) primary key,
 foreign key (username) references Users(username),
 );


 select * from Pacienti
 select * from Users
 select * from Doctori
 select * from LogedUser
 select * from Programari
 select * from PacientiMedic
 select * from Afectiuni


delete from Afectiuni
delete from PacientiMedic
delete from Programari
delete from Users
delete from Pacienti
delete from Doctori
delete from LogedUser
insert into LogedUser (username) values ('null')


----initializare medici
insert into Doctori (Nume, Prenume, CNP, Telefon, Email, Specializare, Sex)
values ('Marius', 'Florin', '5010409444983', '0756787443', 'mariusflorin23@yahoo.com','Cardiologie', 'Masculin')
insert into Users (CNPp, CNPd, username, parola) 
values (NULL, '5010409444983', 'marius', 'doctor')

insert into Doctori (Nume, Prenume, CNP, Telefon, Email,Specializare, Sex)
values ('Pop', 'Gheorghe', '5891097779835', '0740787443', 'popgheorghe@yahoo.com','Dermatologie','Masculin')
insert into Users (CNPd, username, parola) 
values ('5891097779835', 'gheorghe', 'doctor')

insert into Doctori (Nume, Prenume, CNP, Telefon, Email,Specializare, Sex)
values ('Andreescu', 'Monica', '6991197799026', '0740888472', 'monicadoctorita@yahoo.com','Stomatologie', 'Feminin')
insert into Users (CNPd, username, parola) 
values ('6991197799026', 'monica', 'doctor')

insert into Doctori (Nume, Prenume, CNP, Telefon, Email,Specializare, Sex)
values ('Raed', 'Arafat', '5441102190022', '0760888212', 'raedNBN@yahoo.com','Endocrinologie', 'Masculin')
insert into Users (CNPd, username, parola) 
values ('5441102190022', 'arafat', 'doctor')

----initializare pacienti
insert into Pacienti (Nume, Prenume, CNP, Telefon, Email, Sex)
values ('Popescu', 'Ada', '5010411344289', '0751560862', 'ada_cont1@yahoo.com', 'Feminin')
insert into Users (CNPp, username, parola) 
values ('5010411344289', 'ada1', 'adaada')

insert into Pacienti (Nume, Prenume, CNP, Telefon, Email, Sex)
values ('Popescu', 'Ada', '5010413333359', '0751589812', 'ada_cont2@yahoo.com', 'Feminin')
insert into Users (CNPp, username, parola) 
values ('5010413333359', 'ada2', 'adaada')

insert into Pacienti (Nume, Prenume, CNP, Telefon, Email, Sex)
values ('Mujdar', 'Alex', '5010413339999', '0751456812', 'mujdar_alex@yahoo.com', 'Masculin')
insert into Users (CNPp, username, parola) 
values ('5010413339999', 'alex', 'alexalex')

----initializare pacienti pentru arafat
insert into PacientiMedic (username, numeMedic)
values ('ada1', 'Raed Arafat')

insert into PacientiMedic (username, numeMedic)
values ('ada2', 'Raed Arafat')

insert into PacientiMedic (username, numeMedic)
values ('alex', 'Raed Arafat')

insert into PacientiMedic (username, numeMedic)
values ('ada1', 'Marius Florin')

----initializare afectiuni ada1
insert into Afectiuni (username, medic, afectiune, reteta)
values ('ada1', 'Raed Arafat', 'Tinitus', 'paracetamol 3x5')

insert into Afectiuni (username, medic, afectiune, reteta)
values ('ada1', 'Marius Florin', 'Obezitate', 'dieta ketogenica')

insert into Afectiuni (username, medic, afectiune, reteta)
values ('ada1', 'Raed Arafat', 'Tuse acuta', 'nu mai fuma atat de mult!!!xd')

----initializare programari ada1 la arafat (aprobate de arafat)
insert into Programari (username, simptome, medic, data, ora)
values ('ada1','Ma doare capul de nu mai pot!!!', 'Raed Arafat', '5/17/2023', '08:30')

insert into Programari (username, simptome, medic, data, ora)
values ('ada1','Vreau o operatie la piele!!!', 'Raed Arafat', '7/20/2023', '10:30')
