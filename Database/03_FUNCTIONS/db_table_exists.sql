CREATE OR replace FUNCTION db_table_exists(p_schema varchar(10),
                                           p_table varchar(100)) returns BOOLEAN
AS
  $$
  DECLARE
    v_exists BOOLEAN;
  BEGIN
    SELECT EXISTS
           (
                  SELECT
                  FROM   information_schema.TABLES
                  WHERE  table_schema = p_schema
                  AND    table_name = p_table)
    INTO   v_exists;
    
    RETURN v_exists;
  END;
  $$ LANGUAGE plpgsql