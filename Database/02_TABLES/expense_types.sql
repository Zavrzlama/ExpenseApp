CREATE TABLE IF NOT EXISTS expense_types (
	id NUMERIC NOT NULL DEFAULT nextval('expense_types_seq'),
	code VARCHAR(10),
	expense_type VARCHAR(10),
	description VARCHAR(1000) NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY(id),
	UNIQUE(code),
	CHECK(expense_type IN ('INCOME', 'OUTCOME'))
);
	