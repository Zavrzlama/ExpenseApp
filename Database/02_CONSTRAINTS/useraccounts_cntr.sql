ALTER TABLE useraccounts ADD CONSTRAINT pk_useraccounts PRIMARY KEY (id);
ALTER TABLE useraccounts ADD CONSTRAINT uq_email (email);