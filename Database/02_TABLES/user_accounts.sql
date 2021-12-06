CREATE TABLE IF NOT EXISTS user_accounts (
	id NUMERIC NOT NULL DEFAULT nextval('user_accounts_seq') NOT NULL,
	email VARCHAR(200) NOT NULL,
	account_name VARCHAR(200) NOT NULL,
	password VARCHAR(2000) NOT NULL,
	salt VARCHAR(100) NOT NULL,
	active BOOLEAN,
	datecreated DATE NOT NULL,
	dateupdated DATE NOT NULL,
	PRIMARY KEY(id),
	UNIQUE(email),
	UNIQUE(account_name)
);