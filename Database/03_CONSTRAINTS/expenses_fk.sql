DO $$
BEGIN
	IF NOT db_constraint_exists('expenses_fk1') THEN
		ALTER TABLE expenses ADD CONSTRAINT expenses_fk1 FOREIGN KEY (expense_type_id) REFERENCES expense_types(id);
	END IF;
END; $$;


DO $$
BEGIN
	IF NOT db_constraint_exists('expenses_fk2') THEN
		ALTER TABLE expenses ADD CONSTRAINT expenses_fk2 FOREIGN KEY (city_id) REFERENCES cities(id);
	END IF;
END; $$;

DO $$
BEGIN
	IF NOT db_constraint_exists('expenses_fk3') THEN
		ALTER TABLE expenses ADD CONSTRAINT expenses_fk3 FOREIGN KEY (store_id) REFERENCES stores(id);
	END IF;
END; $$;