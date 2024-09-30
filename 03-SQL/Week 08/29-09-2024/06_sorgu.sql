-- SELECT GETDATE()
-- SELECT YEAR(GETDATE())
-- select MONTH(GETDATE())
-- SELECT DAY(GETDATE())

--sadece 1960tan sonra doğan çalışanlar

-- select *
-- from Employees e
-- where e.BirthDate>='1960-1-1' 

-- select *
-- from Employees e
-- where YEAR(e.BirthDate)>=1960 


-- select*
-- from Employees e 
-- where Month(GETDATE())=MONTH((e.BirthDate))

--Her ayın sekizi ve sonrasında işe başlayanların listesi
select*
From Employees e 
where DAY(e.HireDate)>=8
