--Sql

--SELECT: select [kolon_adi]/* from [tablo_adi]
-- ; virgülün bulunduğu satırı çalıştırmaz
Select * from products
Select product_name, category_id from products

--Where : den 'dan anlamı katar
Select * from products where unit_price > 50
select * from products where unit_price > 50 And unit_price < 100
Select * from products where unit_price Between 50 And 100

Select product_name, category_id from products
where unit_price > 50 OR category_id > 2

--IN() : içine parametre verilen n kadar veri ile ilgi alanların uyuşmasını bekler.
Select * from products
where LOWER(product_name) IN('chai', 'Chang', 'ikura');

Select * from products
where LOWER(category_id) IN(1, 2, 3)

--LIKE: kalıba benzer ifadeler getirir.
--%te% : metnin ortasında, metinin öncesi ve sonrasının önemli olmadığını belirtir.
--%te : te ile biten
--te% : te ile başlayan

select * from products
where LOWER(product_name) LIKE '%te%'

-- %__r% : ortadan 3. harfi r olan, karakter atlama
-- _r% : baştan 2. harfi r olan
-- %r_ : sondan 2. harfi r olan
Select * from products
where Lower(product_name) LIKE '__r%'


--buılt-ın functions
--Summary SUM(): TOPLAMA
Select SUM(unit_price) from products

--Average AVG(): ORTALAMA
Select AVG(unit_price) from products

--Maximum MAX(): Maksimum değeri döndürür
Select MAX(unit_price) from products

--Minimum MIN(): Minimum değeri döndürür
Select MIN(unit_price) from products

--Count Count(): adedini dödürür.
Select Count(*) from products where unit_price > 50

--DISTINCT : Tekrarı engeller
--Kaç farklı şehirde çalışanım var?
Select DISTINCT city from employees


-- SUB-QUERY : iç içe sorgular
--Ortalamanın altında bir fiyata sahip ürünler
Select AVG(unit_price) from products -- = 28.83
Select product_name, unit_price from products where unit_price < 28.83

Select product_name, unit_price from products
where unit_price < (Select AVG(unit_price) from products)

--En pahalı ürün
Select Max(unit_price) from products -- = 263.5
Select * from products where unit_price = 263.5

Select * from products where unit_price = (Select Max(unit_price) from products) 

--order by : sıralama
-- default küçükten büyüğe sıralar
--ascending ASC() : küçükten büyüğe a-z
--descending DESC(): büyükten küçüğe z-a
select * from products
order by unit_price 

select * from products
order by unit_price DESC

--total fiyat yüzdeyi alabilmek için 1 çıkartılmalı
select *, ((unit_price * quantity) * (1 - discount)) as total_amount from order_details
order by total_amount desc;
select *, ((unit_price * quantity)) as total_amount from order_details;

--alias AS: takma isim
select current_date as "Bugünün Tarihi"

select date_part('month', current_date)

select * from employees where date_part('year', birth_date) < date_part('year', current_date)

--Dateiff(interval, date1, date2) : iki tarih arası farkı verir
--GetDate() : güncel saat-tarih 
