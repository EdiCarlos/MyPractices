create table userdetails
(
p_id int auto_increment,
id varchar(30),
valid enum('yes', 'no'),
pwd blob,
timeenter timestamp,
primary key(p_id)
);# MySQL returned an empty result set (i.e. zero rows).

insert into password (id, pwd) values('bob', des_encrypt('secret', 'somekey')), ('tom', des_encrypt('password', 'somekey'))

