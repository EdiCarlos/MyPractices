mysql> use mydb
Database changed
mysql> create table temp1
    -> ( id int auto_increment primary key, username varchar(30) unique, userpass varchar(30) not null useremail varchar(30) not null);
ERROR 1064 (42000): You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near 'useremail varchar(30) not null)' at line 2
mysql> create table temp1
    -> ( id int auto_increment primary key, username varchar(30) unique, userpass varchar(30) not null, useremail varchar(30) not null);
Query OK, 0 rows affected (0.06 sec)

mysql> exit
