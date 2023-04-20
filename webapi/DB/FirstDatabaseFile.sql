-- Solitare Database

use cwaller;

drop table if exists Card;
drop table if exists Suit;

create table Suit (
suitId int not null primary key auto_increment,
suitName varchar(200) not null);

create table Card (
cardId int not null primary key auto_increment,
value int not null,
suitId int not null,
foreign key (suitId) references Suit(suitId));

insert into Suit (suitname) values ("Clubs");
insert into Suit (suitname) values ("Hearts");
insert into Suit (suitname) values ("Spades");
insert into Suit (suitname) values ("Diamonds");

insert into Card (value, suitId) values (1, 1);
insert into Card (value, suitId) values (2, 1);
insert into Card (value, suitId) values (3, 1);
insert into Card (value, suitId) values (4, 1);
insert into Card (value, suitId) values (5, 1);
insert into Card (value, suitId) values (6, 1);
insert into Card (value, suitId) values (7, 1);
insert into Card (value, suitId) values (8, 1);
insert into Card (value, suitId) values (9, 1);
insert into Card (value, suitId) values (10, 1);
insert into Card (value, suitId) values (11, 1);
insert into Card (value, suitId) values (12, 1);
insert into Card (value, suitId) values (13, 1);
insert into Card (value, suitId) values (1, 2);
insert into Card (value, suitId) values (2, 2);
insert into Card (value, suitId) values (3, 2);
insert into Card (value, suitId) values (4, 2);
insert into Card (value, suitId) values (5, 2);
insert into Card (value, suitId) values (6, 2);
insert into Card (value, suitId) values (7, 2);
insert into Card (value, suitId) values (8, 2);
insert into Card (value, suitId) values (9, 2);
insert into Card (value, suitId) values (10, 2);
insert into Card (value, suitId) values (11, 2);
insert into Card (value, suitId) values (12, 2);
insert into Card (value, suitId) values (13, 2);
insert into Card (value, suitId) values (1, 3);
insert into Card (value, suitId) values (2, 3);
insert into Card (value, suitId) values (3, 3);
insert into Card (value, suitId) values (4, 3);
insert into Card (value, suitId) values (5, 3);
insert into Card (value, suitId) values (6, 3);
insert into Card (value, suitId) values (7, 3);
insert into Card (value, suitId) values (8, 3);
insert into Card (value, suitId) values (9, 3);
insert into Card (value, suitId) values (10, 3);
insert into Card (value, suitId) values (11, 3);
insert into Card (value, suitId) values (12, 3);
insert into Card (value, suitId) values (13, 3);
insert into Card (value, suitId) values (1, 4);
insert into Card (value, suitId) values (2, 4);
insert into Card (value, suitId) values (3, 4);
insert into Card (value, suitId) values (4, 4);
insert into Card (value, suitId) values (5, 4);
insert into Card (value, suitId) values (6, 4);
insert into Card (value, suitId) values (7, 4);
insert into Card (value, suitId) values (8, 4);
insert into Card (value, suitId) values (9, 4);
insert into Card (value, suitId) values (10, 4);
insert into Card (value, suitId) values (11, 4);
insert into Card (value, suitId) values (12, 4);
insert into Card (value, suitId) values (13, 4);

select * from Card;
select * from Suit;
