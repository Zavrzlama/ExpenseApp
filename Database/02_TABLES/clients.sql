CREATE TABLE IF NOT EXISTS clients (
	id NUMERIC NOT NULL DEFAULT nextval('clients_seq') NOT NULL,
	code VARCHAR(10),
	client_name VARCHAR(100) NOT NULL,
	description VARCHAR(4000),
	client_role_id NUMERIC NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY (id),
	UNIQUE(code)
);