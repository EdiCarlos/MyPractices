 CREATE TABLE AuthorBook(
       AuthID SMALLINT NOT NULL,
       BookID SMALLINT NOT NULL,
       PRIMARY KEY (AuthID, BookID),
       FOREIGN KEY (AuthID) REFERENCES Authors (AuthID),
       FOREIGN KEY (BookID) REFERENCES Books (BookID)
    )
    ENGINE=INNODB;
    
    INSERT INTO AuthorBook VALUES (1006, 14356),
                                   (1008, 15729),
                                   (1009, 12786),
                                   (1010, 17695),
                                   (1011, 15729),
                                   (1012, 19264),
                                   (1012, 19354),
                                   (1014, 16284);