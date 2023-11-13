-- KODLAMA.IO
select * from customers where city = 'Berlin';

select * from Products where category_id = 1 or category_id = 3;
select * from Products where category_id = 1 and unit_price >= 10;

--order by : sıralama
select * from Products order by unit_price;

--önce category_id göre sıralar, sonra product_name göre sıralar
select * from Products order by category_id, product_name;

--category_id = 1 olan verileri unit_price göre sırala
select * from Products where category_id = 1 order by unit_price;

select category_id, count(*) as CountCategory from products where unit_price <20 
group by category_id having count(*) < 10;





-- ASEKRON SQL
select * from customers;

select count(*) from customers;

select country, count(customer_id) from customers
group by country
order by country;

--önce country göre grupla sonra city göre tekrar grupla
select country, city, count(customer_id) from customers
group by country, city
order by country, city;

select * from order_details;

select order_id, sum(quantity * unit_price) as total from order_details
group by order_id
order by total DESC;

--ürün bazlı ortalama fiyat
select order_id, avg(quantity * unit_price) as AvagreByProduct from order_details
group by order_id
order by AvagreByProduct DESC;

--ürün adedi bazlı ortalama fiyat
select order_id, sum(quantity * unit_price) / sum(quantity) as AvagreByQuantity from order_details
group by order_id
order by AvagreByQuantity DESC;

select order_id, sum(quantity * unit_price) / sum(quantity) as AvagreByQuantity from order_details
group by order_id
having  sum(quantity * unit_price) / sum(quantity) > 150
order by AvagreByQuantity DESC; 

select country, count(customer_id)  from customers
group by country
having  count(customer_id) > 2 order by country;

select country, city, count(customer_id) from customers
where country IN('Brazil', 'France') 
group by country, city
having  count(customer_id) > 1 
order by country, city;


--category_id göre max fiyat
Select  p.category_id, MAX (unit_price) from products p
INNER JOIN categories c ON c. category_id = p.category_id
group by p.category_id order by p.category_id;
