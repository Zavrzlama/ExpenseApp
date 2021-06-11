DO $$
BEGIN
	IF NOT db_sequence_exists('public','expense_types_seq') THEN
		CREATE SEQUENCE expense_types_seq
		START 1
		INCREMENT 1;
	END IF;
END; $$