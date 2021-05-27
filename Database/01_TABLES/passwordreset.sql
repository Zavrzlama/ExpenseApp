CREATE TABLE passwordreset
  (
     email          VARCHAR(200) NOT NULL,
     resettoken     VARCHAR(1000) NOT NULL,
     expirationdate DATE NOT NULL
  );

ALTER TABLE passwordreset
  ADD CONSTRAINT uq_email UNIQUE (email);