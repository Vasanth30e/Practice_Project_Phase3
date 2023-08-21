use school
create table Student
(ID int primary key,
Name varchar(50) not null,
Email varchar(50) not null,
Class varchar(50) not null)

insert into student values (1, 'Tom', 'tom@email.com', '7a');
insert into student values (2, 'Thomas', 'thomas@email.com', '7a');
insert into student values (3, 'Manuel', 'manuelm@email.com', '7a');

select * from student;
select StudentName from student;

update student set class = '8a';
update student set Name = 'Tom Clancy' where Name = 'Tom';

delete from student where name = 'Tom Clancy'
delete from student

select * from student where name like 'm%';
select * from student where email = 'thomas@email.com' and class='8a';
select * from student order by name;

declare @namevalue as varchar(100)
set @namevalue = 'Tom'
select * from student where name  = @namevalue
