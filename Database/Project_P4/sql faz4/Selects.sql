
select o.Buyer_Code ,p.fanme ,p.lname,p.phone,p.nid
from Buyer o, person p
where o.nid =p.nid

select o.Management_Location,o.nid,p.Adress,p.nid
from Seller p,Group_Manager o
where o.Management_Location in(Select p.Adress from Seller) 

Select o.Buyer_Code,o.Adress,p.Post_Type,p.Price
from Buyer o ,Bill p
where o.Buyer_Code=p.Buyer_Code

select  pid AS ID ,p.Product_Name,p.price,s.Shop_Name,s.Adress
from Product p,Seller s
where p.sid=s.sid and p.Color='red'

select b.Buyer_Code as ID,p.fanme+' '+p.lname as Name,p.phone,c.Number_OF_Products,c.price
from Buyer b,person p,Cart c
where c.Buyer_Code=b.Buyer_Code and b.nid=p.nid

select * from Seller 
where Sale_Statistics> 400 

select sid ,Shop_Name, DATEDIFF(HOUR,   Work_satr, Work_end ) AS  Hours from Seller order by Seller_point

select min(age) , iif (gender='1','male','female') as gender
from person group by Gender


select fanme,lname
from  Buyer
inner join person
 on  Buyer.nid=person.nid
 order by lname desc

 select p.fanme+' '+p.lname as name ,p.phone as phone ,b.Buyer_Point 
 from  Buyer b,person p 
 where b.Buyer_Point>10 and p.nid=b.nid


 
 
