
select o.Buyer_Code ,p.First_Name ,p.Last_Name,p.phone,p.National_Code
from Buyer o, person p
where o.National_Code =p.National_Code

select o.Group_Manager_id,Management_Location,o.National_Code,p.Adress,p.National_Code
from Seller p,Group_Manager o
where o.Management_Location in(Select p.Adress from Seller) 

Select o.Buyer_Code,o.Adress,p.Post_Type,p.Price
from Buyer o ,Bill p
where o.Buyer_Code=p.Buyer_Code

select  Product_ID AS ID ,p.Product_Name,p.price,s.Shop_Name,s.Adress
from Product p,Seller s
where p.Seller_ID=s.Seller_ID and p.Color='red'

select b.Buyer_Code as ID,p.First_Name+' '+p.Last_Name as Name,p.phone,c.Number_OF_Products,c.price
from Buyer b,person p,Cart c
where c.Buyer_Code=b.Buyer_Code and b.National_Code=p.National_Code

select * from Seller 
where Sale_Statistics> 400 

select Seller_ID ,Shop_Name, DATEDIFF(HOUR,   Work_Start, Work_end ) AS  Hours from Seller order by Seller_point

select min(age) , iif (gender='1','male','female') as gender
from person group by Gender


select First_Name,Last_Name
from  Buyer
inner join person
 on  Buyer.National_Code=person.National_Code
 order by Last_Name desc

 select p.First_Name+' '+p.Last_Name as name ,p.phone as phone ,b.Buyer_Point 
 from  Buyer b,person p 
 where b.Buyer_Point>10 and p.National_Code=b.National_Code


 
 
