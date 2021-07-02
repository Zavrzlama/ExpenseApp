DO $$
BEGIN
	IF NOT db_table_exists('public', 'client_roles') then
		CREATE TABLE client_roles (
			id NUMERIC NOT NULL DEFAULT nextval('client_roles_seq')
			,role_name VARCHAR(100) NOT NULL
			,description VARCHAR(4000)
			,date_created DATE NOT NULL
			,date_updated DATE NOT NULL
			);
	END IF;
END;$$

ALTER TABLE client_roles ADD CONSTRAINT PK_client_roles PRIMARY KEY(id)