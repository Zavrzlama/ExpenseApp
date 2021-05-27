CREATE TABLE expensetypes
  (
     id              INTEGER NOT NULL,
     description     VARCHAR(1000) NOT NULL,
     expensetype     VARCHAR(10),
     expectedexpense NUMERIC(13, 2),
     expensenotify   NUMERIC(13, 2),
     datecreated     DATE NOT NULL,
     dateupdated     DATE NOT NULL
  );