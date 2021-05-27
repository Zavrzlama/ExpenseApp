CREATE TABLE useraccounts
  (
     id          INTEGER NOT NULL,
     email       VARCHAR(200) NOT NULL,
     accountname VARCHAR(200) NOT NULL,
     password    VARCHAR(2000) NOT NULL,
     salt        VARCHAR(100) NOT NULL,
	 active	BOOLEAN CHECK (1 OR 0),
     datecreated DATE NOT NULL,
     dateupdated DATE NOT NULL,
  );