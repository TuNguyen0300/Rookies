1. select * from employees where last_name = 'Zlotkey'
select * from employees where department_id in (select department_id from employees where last_name = 'Zlotkey') 
and last_name != 'Zlotkey'

select * from employees e1
inner join employees e2 on e1.department_id =  e2.department_id
where e2.last_name='Zlotkey' and e1.last_name<>'Zlotkey'

select e1.last_name, e1.hire_date from employees e1
inner join employees e2 on e1.department_id =  e2.department_id
where e2.last_name='Zlotkey' and e1.last_name<>'Zlotkey'

2.
select AVG(salary) from employees
select employee_id, last_name, salary from employees where salary>(select AVG(salary) from employees) order by salary DESC
3.
select distinct e1.employee_id, e1.last_name from employees e1
inner join employees e2 on e1.department_id =  e2.department_id
where e2.last_name like '%u%'
4.
select e1.last_name, e1.department_id, e1.job_id from employees e1 
join departments d1 on e1.department_id= d1.department_id
join locations l1 on d1.location_id = l1.location_id
where l1.city='Seattle'
5.
select last_name, salary from employees
where manager_id in (select employee_id from employees where last_name = 'King') 

select e1.last_name, e1.salary from employees e1
join employees e2 on e2.employee_id= e1.manager_id
where e2.last_name = 'King' 
6.
Select e1.department_id, e1.last_name, e1.job_id from employees e1
join departments d1 on e1.department_id = d1.department_id
where d1.department_name = 'Executive'

--select * from employees e1
--inner join departments d1 on e1.department_id = d1.department_id
--where d1.department_name='Finance' and d1.location_id = 1700

--join: gop them cac colum
--union: gop them cacs rows ko lien quan / union: gop ban ghi trung lap, union all: gop ban ghi ko trung lap
7.
select employee_id, last_name, salary from employees where salary > (select AVG(salary) from employees)
union
select e1.employee_id, e1.last_name, e1.salary from employees e1
inner join employees e2 on e1.department_id =  e2.department_id
where e2.last_name like '%u%' and e2.last_name not like '%u%u%'

select employee_id, last_name, salary from employees where salary > (select AVG(salary) from employees)
union
select employee_id, last_name, salary from employees
where department_id in ( select department_id from employees where last_name like '%u%' and last_name not like '%u%u%')
8. 
select CAST(MAX(salary) as numeric(10,0)) AS 'Maximum', CAST(MIN(salary) as numeric(10,0)) AS 'Minimum', CAST(SUM(salary) as numeric(10,0)) AS 'Sum', CAST(AVG(salary) as numeric(10,0)) AS 'Average' from employees

9.
select UPPER(left(last_name,1)) + LOWER(right(last_name, len(last_name)-1)), len(last_name) from employees
where last_name like 'J%' OR last_name like 'A%' or last_name like 'M%' order by last_name

select UPPER(left(last_name,1)) + LOWER(substring(last_name,2, len(last_name))), len(last_name) from employees
where last_name like 'J%' OR last_name like 'A%' or last_name like 'M%' order by last_name

select UPPER(left(last_name,1)) + LOWER(substring(last_name,2, len(last_name))), len(last_name) from employees
where UPPER(SUBSTRING(last_name,1,1)) in ('J','A','M') order by last_name

10.
select employee_id, last_name, CAST(salary as numeric(10,0)) as 'salary', CAST(salary*1.155 as numeric(10,0)) AS 'New Salary' from employees

11.
--c1
select e.last_name, e.department_id, d.department_name from employees e
join departments d on e.department_id = d.department_id 
--c2
select last_name, department_id, null as departmaent_name from employees 
union
select null ,department_id, department_name from departments

12.
select e.employee_id, e.last_name from employees e
join employees d on d.manager_id = e.employee_id 
where e.hire_date > d.hire_date
union
select e.employee_id, e.last_name from employees e
join departments d on e.department_id =  d.department_id
join locations l on l.location_id = d.location_id
where l.city = 'Toronto'

