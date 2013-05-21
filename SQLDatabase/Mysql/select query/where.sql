create table topic
(
topicid smallint not null auto_increment primary key,
name varchar(50) not null,
InStock smallint unsigned not null,
OnOrder smallint unsigned not null,
Reserved smallint unsigned not null,
Department enum('Classical', 'Populart') not null,
Category varchar(2) not null,
RowUpdate timestamp not null
)
go

INSERT INTO Topic (Name,          InStock, OnOrder, Reserved, Department,   Category) VALUES
                       ('Java',          10,      5,       3,        'Popular',    'Rock'),
                       ('JavaScript',    10,      5,       3,        'Classical',  'Opera'),
                       ('C Sharp',       17,      4,       1,        'Popular',    'Jazz'),
                       ('C',             9,       4,       2,        'Classical',  'Dance'),
                       ('C++',           24,      2,       5,        'Classical',  'General'),
                       ('Perl',          16,      6,       8,        'Classical',  'Vocal'),
                       ('Python',        2,       25,      6,        'Popular',    'Blues'),
                       ('Php',           32,      3,       10,       'Popular',    'Jazz'),
                       ('ASP.net',       12,      15,      13,       'Popular',    'Country'),
                       ('VB.net',        5,       20,      10,       'Popular',    'New Age'),
                       ('VC.net',        24,      11,      14,       'Popular',    'New Age'),
                       ('UML',           42,      17,      17,       'Classical',  'General'),
                       ('www.java2s.com',25,      44,      28,       'Classical',  'Dance'),
                       ('Oracle',        32,      15,      12,       'Classical',  'General'),
                       ('Pl/SQL',        20,      10,      5,        'Classical',  'Opera'),
                       ('Sql Server',    23,      12,      8,        'Classical',  'General');
