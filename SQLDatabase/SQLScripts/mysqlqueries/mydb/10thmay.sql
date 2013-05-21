DELIMITER $$

DROP PROCEDURE IF EXISTS `inserttemp1` $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserttemp1`(in fname varchar(20), in lname  varchar(20),in mname varchar(30))
begin
insert into temp1(fname, lname, mname) values(fname, lname, mname);
select * from temp1;
end $$

DELIMITER ;