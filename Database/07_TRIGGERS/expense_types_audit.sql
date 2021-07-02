CREATE TRIGGER expense_types_audit 
BEFORE INSERT OR UPDATE ON expense_types
FOR EACH ROW EXECUTE PROCEDURE f_expense_types_audit();