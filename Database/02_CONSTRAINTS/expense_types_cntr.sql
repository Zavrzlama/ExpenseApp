ALTER TABLE expensetypes 
  ADD CONSTRAINT pk_expensetypes PRIMARY KEY(id);

ALTER TABLE expense_types
  ADD CONSTRAINT ck_expense_type CHECK(expensetype IN ('INCOME', 'OUTCOME')); 