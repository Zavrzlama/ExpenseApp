DO $$
BEGIN
	IF NOT db_table_exists('public', 'expenses') then
		CREATE TABLE expenses (
			id NUMERIC NOT NULL DEFAULT nextval('expenses_seq')
			,description VARCHAR(2000) NOT NULL
			,expense_year NUMERIC NOT NULL
			,expense_date DATE
			,amount NUMERIC(13, 2) NOT NULL
			,expense_type_id NUMERIC NOT NULL
			,client_id NUMERIC NOT NULL
			,date_created DATE NOT NULL
			,date_updated DATE NOT NULL
			);
	END IF;
END;$$

ALTER TABLE expenses ADD CONSTRAINT PK_expenses PRIMARY KEY(id)