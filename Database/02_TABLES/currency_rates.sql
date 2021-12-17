CREATE TABLE IF NOT EXISTS currency_rates(
	id NUMERIC DEFAULT nextval('currency_rates_seq') NOT NULL,
	date_od_rate VARCHAR(10) NOT NULL,
	currency_rate NUMERIC(13,5),
	currency_id VARCHAR(50) NOT NULL,
	PRIMARY KEY(id)
)