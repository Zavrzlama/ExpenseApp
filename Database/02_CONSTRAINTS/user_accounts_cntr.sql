ALTER TABLE user_accounts ADD CONSTRAINT pk_user_accounts PRIMARY KEY (id);
ALTER TABLE user_accounts ADD CONSTRAINT uq_email (email);