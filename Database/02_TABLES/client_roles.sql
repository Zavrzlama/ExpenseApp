CREATE TABLE IF NOT EXISTS client_roles (
	id NUMERIC NOT NULL DEFAULT nextval('client_roles_seq'),
	code VARCHAR(10) NOT NULL,
	role_name VARCHAR(100) NOT NULL,
	description VARCHAR(4000),
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	UNIQUE(code)
);