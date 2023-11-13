26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.
27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı
28. 1997 yılı şubat ayında kaç siparişim var?
select count(*) from orders where date_part('year', order_date) = 1997 and date_part('month', order_date) = 2
select * from customers
29. London şehrinden 1998 yılında kaç siparişim var?
30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası
31. Taşıma ücreti 40 üzeri olan siparişlerim
32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı
33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf),
34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )
35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad

36. Geciken siparişlerim?
select * from orders where required_date < shipped_date;



37. Geciken siparişlerimin tarihi, müşterisinin adı
select o.order_date, c.contact_name from orders o 
inner join customers c on c.customer_id = o.customer_id
where required_date < shipped_date;

38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
select od.order_id, p.product_name, c.category_name, od.quantity  from order_details od
inner join products p on p.product_id = od.product_id
inner join categories c on c.category_id = p.category_id
where od.order_id = 10248;

39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı
select od.order_id, p.product_name, s.company_name from order_details od
inner join products p on p.product_id = od.product_id
inner join suppliers s on s.supplier_id = p.supplier_id
where od.order_id = 10248;


40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti
select o.employee_id, p.product_name, od.quantity, o.order_date from orders o
inner join order_details od on od.order_id = o.order_id
inner join products p on od.product_id = p.product_id
where o.employee_id = 3 and date_part('year', o.order_date) = 1997;

41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad
select o.employee_id, (e.first_name || ' ' || e.last_name) as "Full_Name", max(od.quantity) from employees e
inner join orders o on e.employee_id = o.employee_id
inner join order_details od on od.order_id = o.order_id
where  date_part('year', o.order_date) = 1997
group by o.employee_id, e.first_name, e.last_name
order by max(od.quantity) desc LIMIT 1;

select max(quantity) from order_details
select * from order_details where quantity = 130
select * from orders where order_id = 10764
select * from employees where employee_id = 6



42. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****
select o.employee_id, (e.first_name || ' ' || e.last_name) as "Full_Name", sum(od.quantity) from employees e
inner join orders o on e.employee_id = o.employee_id
inner join order_details od on od.order_id = o.order_id
where  date_part('year', o.order_date) = 1997
group by o.employee_id, e.first_name, e.last_name
order by sum(od.quantity) desc LIMIT 1;



43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?
select p.product_name, c.category_name, max(unit_price) from products p
inner join categories c on c.category_id = p.category_id
group by  p.product_name, c.category_name
order by max(unit_price) DESC LIMIT 1;

44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
select o.order_id, e.first_name, e.last_name, o.order_date from orders o
inner join employees e on e.employee_id = o.employee_id
order by o.order_date

45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?
select od.order_id, AVG(od.unit_price * od.quantity)from orders o
inner join order_details od on od.order_id = o.order_id
group by od.order_id, o.order_date
order by o.order_date desc LIMIT 5;

select * from order_details
select * from orders
select * from products
select * from employees
select * from categories
select * from shippers
select * from us_states
select * from region


46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?
47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
Select p.product_name, od.quantity from products p
inner join order_details od on od.product_id= p.product_id
where od.quantity > (Select AVG(quantity) from order_details)

Select product_name, unit_price from products
48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
49. Kaç ülkeden müşterim var
50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?


65. 10 numaralı ID ye sahip ürünümden son 3 ayda ne kadarlık ciro sağladım?
66. Hangi çalışan şimdiye kadar toplam kaç sipariş almış..?
67. 91 müşterim var. Sadece 89’u sipariş vermiş. Sipariş vermeyen 2 kişiyi bulun
68. Brazil’de bulunan müşterilerin Şirket Adı, TemsilciAdi, Adres, Şehir, Ülke bilgileri
69. Brezilya’da olmayan müşteriler
70. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
71. Faks numarasını bilmediğim müşteriler
72. Londra’da ya da Paris’de bulunan müşterilerim
73. Hem Mexico D.F’da ikamet eden HEM DE ContactTitle bilgisi ‘owner’ olan müşteriler
74. C ile başlayan ürünlerimin isimleri ve fiyatları
75. Adı (FirstName) ‘A’ harfiyle başlayan çalışanların (Employees); Ad, Soyad ve Doğum Tarihleri
76. İsminde ‘RESTAURANT’ geçen müşterilerimin şirket adları
77. 50$ ile 100$ arasında bulunan tüm ürünlerin adları ve fiyatları
78. 1 temmuz 1996 ile 31 Aralık 1996 tarihleri arasındaki siparişlerin (Orders), SiparişID (OrderID) ve SiparişTarihi (OrderDate) bilgileri

79. Ülkesi (Country) YA Spain, Ya France, Ya da Germany olan müşteriler
select * from customers
where LOWER(country) IN('spain', 'france', 'germany')

80. Faks numarasını bilmediğim müşteriler
select * from customers
where fax is null
81. Müşterilerimi ülkeye göre sıralıyorum:
select * from customers
order by country

82. Ürünlerimi en pahalıdan en ucuza doğru sıralama, sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price from products
order by unit_price desc

83. Ürünlerimi en pahalıdan en ucuza doğru sıralasın, ama stoklarını küçükten-büyüğe doğru göstersin sonuç olarak ürün adı ve fiyatını istiyoruz
select product_name, unit_price, units_in_stock from products
order by unit_price desc, units_in_stock asc

84. 1 Numaralı kategoride kaç ürün vardır..?
select category_id, count(category_id) from products p
where category_id = 1
group by category_id


85. Kaç farklı ülkeye ihracat yapıyorum..?
