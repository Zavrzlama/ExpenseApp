CREATE TABLE IF NOT EXISTS store(
	id NUMERIC DEFAULT nextval('store_seq') NOT NULL,
	code VARCHAR(100) NOT NULL,
	store_name VARCHAR(500) NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY(id)
);