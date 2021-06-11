DO $$
BEGIN
	IF NOT db_sequence_exists('public','clients_seq') THEN
		CREATE SEQUENCE clients_seq
		START 1
		INCREMENT 1;
	END IF;
END; $$