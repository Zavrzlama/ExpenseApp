DO $$
BEGIN
	IF NOT db_table_exists('public', 'clients') THEN
		CREATE TABLE clients (
			id NUMERIC NOT NULL
			,client_name VARCHAR(100) NOT NULL
			,client_role NUMERIC NOT NULL
			,description VARCHAR(4000)
			);
	END IF;
END; $$
