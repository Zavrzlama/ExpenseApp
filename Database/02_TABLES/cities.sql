CREATE TABLE IF NOT EXISTS cities(
	id NUMERIC DEFAULT nextval('cities_seq') NOT NULL,
	postal_code VARCHAR(100) NOT NULL,
	city_name VARCHAR(500) NOT NULL,
	state_id NUMERIC NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY(id)
);
