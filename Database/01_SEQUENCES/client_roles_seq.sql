DO $$
BEGIN
	IF NOT db_sequence_exists('public','client_roles_seq') THEN
		CREATE SEQUENCE client_roles_seq
		START 1
		INCREMENT 1;
	END IF;
END; $$