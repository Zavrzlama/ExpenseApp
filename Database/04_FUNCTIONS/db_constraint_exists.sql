CREATE OR REPLACE FUNCTION db_constraint_exists(p_constraint_name varchar(100)) returns BOOLEAN
AS
  $$
  DECLARE
    v_exists BOOLEAN;
  BEGIN
    SELECT EXISTS(SELECT
                  FROM   information_schema.REFERENTIAL_CONSTRAINTS
			   	  WHERE  constraint_name = p_constraint_name)
    INTO   v_exists;
    
    RETURN v_exists;
  END;
  $$ LANGUAGE plpgsql