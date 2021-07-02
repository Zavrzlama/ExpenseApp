CREATE OR REPLACE FUNCTION f_expense_types_audit ()
RETURNS TRIGGER AS $$

BEGIN
	IF (TG_OP = 'INSERT') THEN 
		new.date_created = now();
		new.date_updated = now();

	ELSIF(TG_OP = 'UPDATE') THEN 
		new.date_updated = now();
		
	END IF;
	
	RETURN new;
END;$$

LANGUAGE plpgsql;
