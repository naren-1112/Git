create database School
use School
create table Student(Id int, Name varchar(100),Address varchar(100),Email varchar(75),Class varchar(5)
create table Class(Id int,Name varchar(5))
create table Subject(Id int,Name varchar(50))


create index Student_Index on Student(Id,Name,Address,Email,Class)
create index Class_Index on Class(Id,Name)
create index Subject_Index on Subject(Id,Name)


insert into Student values(1,'Naren','Villupuram','sk.narencric@gmail.com','12')
insert into Student values(2,'Kalpana','Chennai','kalpana@yahoo.com','11')
insert into Student values(3,'Shaggy','Tirunelveli','shaggy@hotmail.com','8')

insert into Class values(1,'12')
insert into Class values(2,'11')
insert into Class values(3,'8')

insert into Subject values(01,'Biology')
insert into Subject values(02,'Maths')
insert into Subject values(03,'English')

Select*from Student
Select*from Class
Select*from�Subject
