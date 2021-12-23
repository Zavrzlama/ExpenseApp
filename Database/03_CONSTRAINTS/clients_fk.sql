DO $$
BEGIN
	IF NOT db_constraint_exists('client_fk1') THEN
		ALTER TABLE clients ADD CONSTRAINT client_fk1 FOREIGN KEY (client_role_id) REFERENCES client_roles(id);
	END IF;
END; $$;