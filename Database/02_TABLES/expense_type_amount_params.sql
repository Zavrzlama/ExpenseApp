CREATE TABLE IF NOT EXISTS expense_type_amount_params(
	expense_type_id NUMERIC NOT NULL,
	expense_amount_params_id NUMERIC NOT NULL,
	user_created NUMERIC NOT NULL,
	date_created DATE NOT NULL,
	user_updated NUMERIC NOT NULL,
	date_updated DATE NOT NULL,
	PRIMARY KEY(expense_type_id, expense_amount_params_id, user_created)
)