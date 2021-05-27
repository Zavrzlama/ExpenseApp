ALTER TABLE expensetypes 
  ADD CONSTRAINT pk_expensetypes PRIMARY KEY(id);

ALTER TABLE expensetypes
  ADD CONSTRAINT ck_expensetype CHECK(expensetype IN ('INCOME', 'OUTCOME')); 