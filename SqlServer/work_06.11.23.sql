--exists - not exists => mevcut mu?
--Herhangi bir kaydın varlığını kontrol eder?

select company_name from suppliers s
where exists ( select product_name from produts p
			  where p.supplier_id = s.supplier_id
			  and unit_price < 20);

select company_name from suppliers s
where not  exists ( select product_name from produts p
			  where p.supplier_id = s.supplier_id
			  and unit_price < 20)
			 
--iki tarih arasında sipariş almış alan çalışanlar.			
select * from employees e
where exists (select * from orders o
			 where e.employee_id = o.employee_id
			 and o.order_date between '3/5/1998' and '4/5/1998')
			 
--all : mantıksal operator  , and
--tüm alt sorgudaki değerleri koşulu sağlıyorsa eğer bizim true =>verilere ulaşabiliyoruz

select * from products
where product_id = ALL(select distinct product_id from order_details
					  where quantity = 10)
--any :				
--tüm alt sorgudaki değerlerinden herhangi biri koşulu sağlıyorsa eğer bizim true =>verilere ulaşabiliyoruz
	
select * from products
where product_id = ANY(select product_id from order_details
					  where quantity > 99)




