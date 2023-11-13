-- 86. a.Bu ülkeler hangileri..?
SELECT DISTINCT country FROM customers

-- 87. En Pahalı 5 ürün
select * from products
order by unit_price desc limit 5;

-- 88. ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?
select count(*) from orders
where customer_id = 'ALFKI';

-- 89. Ürünlerimin toplam maliyeti
select sum((unit_price * quantity)) from order_details

-- 90. Şirketim, şimdiye kadar ne kadar ciro yapmış..?
select sum((unit_price * quantity) * (1 - discount)) from order_details

-- 91. Ortalama Ürün Fiyatım
select avg(unit_price) from products;

-- 92. En Pahalı Ürünün Adı
select product_name, unit_price from products
order by unit_price desc limit 1;

-- 93. En az kazandıran sipariş
select order_id, sum((unit_price * quantity) * (1 - discount)) from order_details
group by order_id
ORDER BY sum((Unit_Price * Quantity)* (1 - discount)) asc limit 1;

-- 94. Müşterilerimin içinde en uzun isimli müşteri

select contact_name, LENGTH(contact_name) from customers
order by LENGTH(contact_name) desc limit 1;

-- 95. Çalışanlarımın Ad, Soyad ve Yaşları
select first_name, last_name, 
(date_part('year', current_date) - date_part('year', birth_date)) Age from employees;

-- 96. Hangi üründen toplam kaç adet alınmış..?)
select p.product_name , sum(quantity) from order_details od
inner join products p on od.product_id = p.product_id
group by product_name;

-- 97. Hangi siparişte toplam ne kadar kazanmışım..?
select order_id, sum((unit_price * quantity) * (1 - discount)) 
from  order_details group by order_id

-- 98. Hangi kategoride toplam kaç adet ürün bulunuyor..?
select category_id,  count(*) from products
group by category_id order by  category_id

-- 99. 1000 Adetten fazla satılan ürünler?
select product_id  , sum(quantity) from order_details
group by product_id
having sum(quantity) > 1000

-- 100. Hangi Müşterilerim hiç sipariş vermemiş..?
select * from customers where customer_id not in (select distinct customer_id from orders)

-- 101. Hangi tedarikçi hangi ürünü sağlıyor ?
select s.company_name, p.product_name from products p
inner join suppliers s on s.supplier_id = p.supplier_id


-- 102. Hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş..?
select s.company_name, order_id, order_date from orders o
inner join shippers s on s.shipper_id = o.ship_via

-- 103. Hangi siparişi hangi müşteri verir..?
select  o.order_id, c.company_name from orders o
inner join customers c on c.customer_id = o.customer_id;


-- 104. Hangi çalışan, toplam kaç sipariş almış..?
select o.employee_id , count(*) from orders o
inner join employees e on e.employee_id = o.employee_id
group by o.employee_id


-- 105. En fazla siparişi kim almış..?
select od.order_id, c.company_name, sum(quantity) from order_details od
inner join orders o on o.order_id = od.order_id
inner join customers c on c.customer_id = o.customer_id
group by od.order_id, c.company_name
order by  sum(quantity) desc limit 1;

-- 106. Hangi siparişi, hangi çalışan, hangi müşteri vermiştir..?
select o.order_id, (first_name ||' ' || last_name), c.company_name  from employees e
inner join orders o on o.employee_id = e.employee_id
inner join customers c on c.customer_id = o.customer_id

-- 107. Hangi ürün, hangi kategoride bulunmaktadır..? Bu ürünü kim tedarik etmektedir..?
select p.product_name, c.category_name, s.company_name from products p
inner join categories c on p.category_id = c.category_id
inner join suppliers s on p.supplier_id = s.supplier_id

-- 108. Hangi siparişi hangi müşteri vermiş, hangi çalışan almış, hangi tarihte, hangi kargo şirketi tarafından gönderilmiş
--hangi üründen kaç adet alınmış, hangi fiyattan alınmış, ürün hangi kategorideymiş bu ürünü hangi tedarikçi sağlamış
select o.order_id, ct.company_name "Customer", (e.first_name || ' ' || e.last_name) "Employee", o.order_date , sh.company_name "Shipper",  
p.product_name, od.quantity, od.unit_price, c.category_name, s.company_name "Supplier" from orders o
inner join customers ct on ct.customer_id = o.customer_id
inner join employees e on e.employee_id = o.employee_id
inner join shippers sh on sh.shipper_id = o.ship_via
inner join order_details od on od.order_id = o.order_id
inner join products p on p.product_id = od.product_id
inner join categories c on p.category_id = c.category_id
inner join suppliers s on p.supplier_id = s.supplier_id

-- 109. Altında ürün bulunmayan kategoriler
select * from categories where category_id not in (
	select category_id from products )

-- 110. Manager ünvanına sahip tüm müşterileri listeleyiniz.
select * from customers
where LOWER(contact_title) like ('%manager')

-- 111. FR ile başlayan 5 karekter olan tüm müşterileri listeleyiniz.
select * from customers
where lower(customer_id) like 'fr___'

-- 112. (171) alan kodlu telefon numarasına sahip müşterileri listeleyiniz.
select * from customers
where phone like ('(171)%')

-- 113. BirimdekiMiktar alanında boxes geçen tüm ürünleri listeleyiniz.
select * from Products where quantity_per_unit like '%boxes%'


-- 114. Fransa ve Almanyadaki (France,Germany) Müdürlerin (Manager) Adını ve Telefonunu listeleyiniz.(MusteriAdi,Telefon)
select contact_name ,phone from customers
where country in('France', 'Germany') and LOWER(contact_title) like '%manager'

-- 115. En yüksek birim fiyata sahip 10 ürünü listeleyiniz.
select * from products
order by unit_price desc limit 10

-- 116. Müşterileri ülke ve şehir bilgisine göre sıralayıp listeleyiniz.
select * from customers
order by country, city

-- 117. Personellerin ad,soyad ve yaş bilgilerini listeleyiniz.
select (first_name || ' ' || last_name), 
(date_part('year', current_date) - date_part('year', birth_date)) Age from employees

-- 118. 35 gün içinde sevk edilmeyen satışları listeleyiniz.
select * from orders
where (order_date + 35) > shipped_date

-- 119. Birim fiyatı en yüksek olan ürünün kategori adını listeleyiniz. (Alt Sorgu)
select category_name from categories where category_id =  (
	select category_id from products order by unit_price desc limit 1)


-- 120. Kategori adında 'on' geçen kategorilerin ürünlerini listeleyiniz. (Alt Sorgu)
select * from products where category_id in (
	select category_id from categories where category_name like '%on%')

-- 121. Konbu adlı üründen kaç adet satılmıştır.
select sum(quantity) from order_details where product_id in (
	select product_id from products where product_name = 'Konbu')

-- 122. Japonyadan kaç farklı ürün tedarik edilmektedir.
select count(*) from products where supplier_id in (
	select supplier_id from suppliers where country = 'Japan')

-- 123. 1997 yılında yapılmış satışların en yüksek, en düşük ve ortalama nakliye ücretlisi ne kadardır?
select max(freight), min(freight), avg(freight) from orders where date_part('year', order_date) = '1997'

-- 124. Faks numarası olan tüm müşterileri listeleyiniz.
select * from customers where fax is not null

-- 125. 1996-07-16 ile 1996-07-30 arasında sevk edilen satışları listeleyiniz. 
select * from orders
where shipped_date between '1996-07-16' and '1996-07-30'