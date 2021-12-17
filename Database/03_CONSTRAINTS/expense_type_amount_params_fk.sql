DO $$
BEGIN
	IF NOT db_constraint_exists('expense_type_amount_params_fk1') THEN
		ALTER TABLE expense_type_amount_params ADD CONSTRAINT expense_type_amount_params_fk1 FOREIGN KEY(expense_type_id) REFERENCES expense_types(id);
	END IF;
END; $$;

DO $$
BEGIN
	IF NOT db_constraint_exists('expense_type_amount_params_fk2') THEN
		ALTER TABLE expense_type_amount_params ADD CONSTRAINT expense_type_amount_params_fk2 FOREIGN KEY(expense_amount_params_id) REFERENCES expense_amount_params(id);
	END IF;
END; $$;