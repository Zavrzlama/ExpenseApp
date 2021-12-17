CREATE TABLE IF NOT EXISTS cities(
	id NUMERIC DEFAULT nextval('cities_seq') NOT NULL,
	postal_code VARCHAR(100) NOT NULL,
	city_name VARCHAR(500) NOT NULL,
	state_id NUMERIC NOT NULL,
	PRIMARY KEY(id)
);