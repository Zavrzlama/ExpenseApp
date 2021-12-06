CREATE TABLE IF NOT EXISTS password_reset (
	email VARCHAR(200) NOT NULL,
	reset_token VARCHAR(1000) NOT NULL,
	expiration_date DATE NOT NULL,
	PRIMARY KEY (email, expiration_date)
);