create or replace procedure ImportData_Insert(p_period varchar, p_data json)
language sql
as $$
insert into importdata(dataperiod,data) values (p_period,p_data);
$$;