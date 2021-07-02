DO $$
BEGIN
	IF NOT db_table_exists('public', 'expense_types') THEN
		CREATE TABLE expense_types (
			id NUMERIC NOT NULL DEFAULT nextval('expense_types_seq')
			,description VARCHAR(1000) NOT NULL
			,expense_type VARCHAR(10)
			,expected_expense NUMERIC(13, 2)
			,expense_notify NUMERIC(13, 2)
			,date_created DATE NOT NULL
			,date_updated DATE NOT NULL
			);
	END IF;
END; $$