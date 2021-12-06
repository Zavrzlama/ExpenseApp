CREATE TABLE IF NOT EXISTS expenses(
	id NUMERIC DEFAULT nextval('expenses_seq') NOT NULL,
	description VARCHAR(4000) NOT NULL,
	amount NUMERIC(13,2) NOT NULL,
	expense_date DATE,
	expense_type_id NUMERIC NOT NULL,
	PRIMARY KEY (id)
)