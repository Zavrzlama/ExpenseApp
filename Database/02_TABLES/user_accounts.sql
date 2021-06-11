DO $$
BEGIN
	IF NOT db_table_exists('public', 'user_accounts') THEN
		CREATE TABLE user_accounts (
			id NUMERIC NOT NULL DEFAULT nextval('user_accounts_seq')
			,email VARCHAR(200) NOT NULL
			,accountname VARCHAR(200) NOT NULL
			,password VARCHAR(2000) NOT NULL
			,salt VARCHAR(100) NOT NULL
			,active BOOLEAN
			,datecreated DATE NOT NULL
			,dateupdated DATE NOT NULL
			);
	END IF;
END $$