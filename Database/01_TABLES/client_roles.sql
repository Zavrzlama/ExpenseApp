DO $$
BEGIN
	IF db_table_exists('public', 'client_roles') then
		CREATE TABLE client_roles (
			id NUMERIC NOT NULL
			,role_name VARCHAR(100) NOT NULL
			,description VARCHAR(4000)
			);
	END IF;

END;$$
