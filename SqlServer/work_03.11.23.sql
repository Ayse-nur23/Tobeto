--inner join
select p.product_name, c.category_name from  products p
inner join categories c on p.category_id = c.category_id;

--hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş?
select o.order_id, s.company_name, o.order_date from orders o
inner join shippers s on o.ship_via = s.shipper_id;

--hangi siparişi hangi çalışan almıştır hangi müşteri vermiştir?
--orders - employees - customers
select o.order_id, e.first_name|| ' ' || e.last_name as Full_Name, 
c.company_name, p.product_name from orders o
inner join employees e on o.employee_id = e.employee_id
inner join customers c on o.customer_id = c.customer_id
inner join order_details od on o.order_id = od.order_id
inner join products p on p.product_id = od.product_id;

--left join
select  o.order_id, e.first_name|| ' ' || e.last_name as Full_Name, 
o.order_date from employees e
left join orders o on e.employee_id = o.employee_id;

--right join
select  o.order_id, e.first_name|| ' ' || e.last_name as Full_Name, 
o.order_date from employees e
right join orders o on e.employee_id = o.employee_id;

--full outer join
select  o.order_id, e.first_name|| ' ' || e.last_name as Full_Name, 
o.order_date from employees e
full outer join orders o on e.employee_id = o.employee_id;

--group by
--belirtilen sutün ya da sutünlardaki aynı değere sahip satırları tek bir satırda birleştirmeyi sağlar.
--min - max - sum - count - avg

--hangi ktegoride toplam kaç ürün var?
select c.category_name, count(c.category_id) from products p
inner join categories c on p.category_id = c.category_id
group by c.category_name;

--Sipariş detayları tablosundan product_id alanına göre gruplandırarak
--her grubun toplam sipariş miktarını belirleyelim

select p.product_name as "Product Name",
SUM(quantity) as "Toplam Sipariş" from order_details od
inner join products p on p.product_id = od.product_id
group by product_name;


--Hangi ülkeye ne kadar satış yapılmış?
select * from order_details;
select * from products;
select ship_country, count(*) from orders o
group by ship_country;

--Hangi ülkeye ne kadarlık satış yapılmış?
select o.ship_country, sum(od.unit_price * od.quantity) AS total_sales from order_details od
inner join orders o on o.order_id = od.order_id
group by o.ship_country
order by  total_sales desc;

--having: filtreleme 
--Toplam sipariş miktarı 1300den fazla olan ürün kodlarını görelim?
select product_id, SUM(quantity)  from order_details
group by product_id
having SUM(quantity) > 1300

--stok sayısı 20den fazla toplam ürün sayısı 1'den fazla kategoriler
select category_id, count(*), units_in_stock from products p
where units_in_stock > 20
group by category_id, units_in_stock
having count(*) > 1;

--içerisinde en az iki ürün olan kategorilerin ürün sayısı
select category_name, count(*) from products p
inner join categories c on p.category_id = c.category_id
group by category_name
having count(*) > 1;

--250 adetten fazla satılan ürünler
select p.product_name, sum(quantity) from order_details od 
inner join products p on od.product_id = p.product_id
group by p.product_name
having sum(od.quantity) > 250;



