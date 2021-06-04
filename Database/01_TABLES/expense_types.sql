DO $$
BEGIN
	IF NOT db_table_exists('public', 'expense_types') then
		CREATE TABLE expense_types (
			id INTEGER NOT NULL
			,description VARCHAR(1000) NOT NULL
			,expense_type VARCHAR(10)
			,expected_expense NUMERIC(13, 2)
			,expense_notify NUMERIC(13, 2)
			,datecreated DATE NOT NULL
			,dateupdated DATE NOT NULL
			);
	END IF;
END; $$