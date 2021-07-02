DO $$
BEGIN
	IF NOT db_table_exists('public', 'clients') THEN
		CREATE TABLE clients (
			id NUMERIC NOT NULL DEFAULT nextval('clients_seq')
			,client_name VARCHAR(100) NOT NULL
			,client_role_id NUMERIC NOT NULL
			,description VARCHAR(4000)
			,date_created DATE NOT NULL
			,date_updated DATE NOT NULL
			);
	END IF;
END; $$

ALTER TABLE clients ADD CONSTRAINT PK_clients PRIMARY KEY(id)