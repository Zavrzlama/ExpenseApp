DO $$
BEGIN
	IF NOT db_table_exists('public', 'password_reset') THEN
		CREATE TABLE password_reset (
			email VARCHAR(200) NOT NULL
			,resettoken VARCHAR(1000) NOT NULL
			,expirationdate DATE NOT NULL
			);
	END IF;
END; $$
