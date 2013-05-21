DELIMITER $$

DROP PROCEDURE IF EXISTS `myinsert` $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `myinsert`()
begin
declare i int default 1;
while (i < 100) do
insert into mydate(startdate, enddate) values(adddate(curdate(), interval i day), adddate(curdate(), interval (45 + i) day));
set i = i + 1;
end while;
select * from mydate;

end $$

DELIMITER ;