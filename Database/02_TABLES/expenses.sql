CREATE TABLE IF NOT EXISTS expenses(
	id NUMERIC DEFAULT nextval('expenses_seq') NOT NULL,
	description VARCHAR(4000) NOT NULL,
	amount NUMERIC(13,2) NOT NULL,
	expense_date DATE NOT NULL,
	expense_type_id NUMERIC NOT NULL,
	city_id NUMERIC,
	store_id NUMERIC,
	currency_id NUMERIC NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY (id)
)