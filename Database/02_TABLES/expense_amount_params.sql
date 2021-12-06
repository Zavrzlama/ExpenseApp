CREATE TABLE IF NOT EXISTS expense_amount_params(
	id NUMERIC NOT NULL DEFAULT nextval('expense_amount_parameters_seq') NOT NULL,
	code VARCHAR(10) NOT NULL,
	param_name VARCHAR(50) NOT NULL,
	description VARCHAR(1000) NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY(id),
	UNIQUE(code)
);