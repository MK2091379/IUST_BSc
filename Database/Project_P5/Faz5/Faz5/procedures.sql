-----------------------------------------------------------------------------
----show total price , products buyed, post_type
create procedure show_sabad_kala
(@buyer_code_ int)
as 
begin 
--show total price and cart
select distinct  (select sum(c.price ) from product c ,buys d where c.Product_ID=d.Product_ID  and d.Buyer_Code=@buyer_code_  ) Total_price, g.cart_code  from buys a , Product b,cart g
where a.Product_ID=b.Product_ID and a.Buyer_Code=@buyer_code_ and g.Buyer_Code=@buyer_code_

--show products
 select a.buyer_code ,a.product_id , b.product_name , b.price,c.shop_name from buys a,product b, seller c 
 where a.Product_ID=b.Product_ID and c.Seller_ID=b.Seller_ID and a.Buyer_Code=1

 --show post_type
 select   d.post_type from bill d where d.Buyer_Code=@buyer_code_
end

------------------------------------------------------------------------------------------------------------------
---update sabad 
create procedure update_cart
(@buyer_code_ int)
as
begin
--update price
update cart
set price = (select distinct  (select sum(c.price ) from product c ,buys d where c.Product_ID=d.Product_ID  and d.Buyer_Code=@buyer_code_  )  from buys a , Product b
where a.Product_ID=b.Product_ID and a.Buyer_Code=1) where Buyer_Code=@buyer_code_

--update number of products
update cart
set Number_OF_Products=( select distinct count(a.buyer_code) from buys a,cart c where a.Buyer_Code=@buyer_code_ and c.Buyer_Code=@buyer_code_)
end

---------------------------------------------------------------------------------------------------

-------search for products
create procedure search_products
(@data_s varchar)
as
begin
select  Product_ID AS ID ,p.Product_Name,p.price,s.Shop_Name,s.Adress
from Product p,Seller s
where p.Seller_ID=s.Seller_ID and p.Product_Info =@data_s
end
--------------------------------------------------------------------------------------------------
------get all personal info
create procedure show_personal_information
as
begin 
select Buyer_Code First_Name,Last_Name
from  Buyer
inner join person
 on  Buyer.National_Code=person.National_Code
 order by Last_Name desc

 select Seller_ID,First_Name,Last_Name
from  seller
inner join person
 on  seller.National_Code=person.National_Code
 order by Last_Name desc


 select Site_Manager_Code,First_Name,Last_Name
from  Site_Manager
inner join person
 on  Site_Manager.National_Code=person.National_Code
 order by Last_Name desc
end


