select json_array_elements(data)->'ExpenseDate' ExpenseDate, 
	   json_array_elements(data)->'Amount' Amount,
	   json_array_elements(data)->'Account' Account from importdata where dataperiod <> 'February 2021'