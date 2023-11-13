--1-)Brazil'da ki bulunan müşterilerimin bilgileri
select company_name, contact_name, address, city, country from customers
where country = 'Brazil';

--2-)Brazil'da olmayan müşterilerimin bilgileri
select company_name, contact_name, address, city, country from customers
where country  <> 'Brazil';

--3-)Ülkesi Spain ya da France ya da Germany olan müşterilerim

select company_name, contact_name, address, city, country from customers
where  country =  'Spain' or country = 'France' or country = 'Germany';

select company_name, contact_name, address, city, country from customers
where country in('Spain', 'France', 'Germany');

--4-)Fax numarasını bilmediğim müşteriler
select * from customers
where fax is  null;

--5-)Londra'da ya da Paris'de bulunan müşterilerim?
select company_name, contact_name, address, city, country from customers
where city in('London', 'Paris');

--6-)Müşterilerimden en uzun isme müşteri
select company_name, LENGTH(company_name) from customers
order by LENGTH(company_name) desc limit 1;

--7-)Hem México D.F. ikamet eden hem de iletişim kişisi ünvanında 'owner' olan müşteri
select * from customers
where city = 'México D.F.' and contact_title = 'Owner';

--8-)C ile başlayan  ürünlerimin  isimleri ve fiyatları nedir?
select product_name, unit_price from products
where product_name like 'C%';

--9-)ADI 'A' ile başlayan çalışanların (Employees);Ad, Soyad, Doğum tarihi
select first_name, last_name, birth_date from employees
where first_name like 'A%'

--10-)Her müşterinin şipariş sayısı
--Geleneksel Yöntem
select o.customer_id, c.company_name, count(*) from orders o, customers c
where c.customer_id = o.customer_id
group by o.customer_id, c.company_name
order by 1

--Join
select o.customer_id, c.company_name, count(*) from orders o
join customers c on  c.customer_id = o.customer_id
group by o.customer_id, c.company_name
order by 1

--Sub Query
select customer_id, company_name, (select count(*) from orders where customer_id = c.customer_id)
from customers c order by 1










--union/all
select city, country from customers
union all
select city, country from suppliers
union all
select city, country from employees