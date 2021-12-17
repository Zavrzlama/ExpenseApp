CREATE TABLE IF NOT EXISTS currencies(
	id NUMERIC DEFAULT nextval('currencies_seq') NOT NULL,
	code VARCHAR(10) NOT NULL,
	currency_name VARCHAR(50) NOT NULL,
	PRIMARY KEY(id)
)