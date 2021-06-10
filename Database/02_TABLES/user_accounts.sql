DO $$
BEGIN
	IF db_table_exists('public', 'user_accounts') THEN
		CREATE TABLE user_accounts (
			id NUMBER NOT NULL
			,email VARCHAR(200) NOT NULL
			,accountname VARCHAR(200) NOT NULL
			,password VARCHAR(2000) NOT NULL
			,salt VARCHAR(100) NOT NULL
			,active BOOLEAN CHECK (1 OR 0)
			,datecreated DATE NOT NULL
			,dateupdated DATE NOT NULL
			);
	END IF;
END $$
