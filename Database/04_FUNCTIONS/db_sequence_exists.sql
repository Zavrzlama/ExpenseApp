CREATE OR REPLACE FUNCTION db_sequence_exists (p_schema IN VARCHAR(10), p_sequence IN VARCHAR(100)) 
RETURNS boolean 
AS $$
DECLARE 
	v_exists boolean;
BEGIN
	SELECT EXISTS (
			SELECT *
			FROM information_schema.sequences seq
			WHERE sequence_schema = p_schema
				AND sequence_name = p_sequence
			)
	INTO v_exists;

	RETURN v_exists;
END $$ 
LANGUAGE plpgsql