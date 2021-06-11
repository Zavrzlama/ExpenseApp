DO $$
BEGIN
	IF NOT db_sequence_exists('public','user_accounts_seq') THEN
		CREATE SEQUENCE user_accounts_seq
		START 1
		INCREMENT 1;
	END IF;
END; $$