CREATE TRIGGER client_roles_audit 
BEFORE INSERT OR UPDATE ON client_roles
FOR EACH ROW EXECUTE PROCEDURE f_client_roles_audit();
