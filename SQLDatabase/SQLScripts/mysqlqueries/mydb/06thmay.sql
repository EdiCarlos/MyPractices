DELIMITER $$

DROP PROCEDURE IF EXISTS `ctemp` $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ctemp`()
begin
drop temporary table if exists secondtemp;
create temporary table secondtemp
(
id smallint auto_increment primary key,
dt date not null
);
set @i = 1;
while @i < 100 do
insert into secondtemp(dt) values(curdate());
set @i = @i + 1;
end while;
select * from secondtemp;
end $$

DELIMITER ;