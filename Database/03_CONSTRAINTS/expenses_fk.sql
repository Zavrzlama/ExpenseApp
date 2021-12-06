DO $$
BEGIN
	IF NOT db_constraint_exists('expenses_fk1') THEN
		ALTER TABLE expenses ADD CONSTRAINT expenses_fk1 FOREIGN KEY (expense_type_id) REFERENCES expense_types(id);
	END IF;
END; $$
