use final 
 select *
 from Employee
---1
create view [show public details]
as 
select p.Last_Name,p.Email,iif(p.gender=1,'male','female') as gender ,p.Age
from person as p
---test1
select* from [show public details]




--2
create view [show products]
as
	select p.Product_Name
	from Product as p
	where p.Price <= ( select avg(Price)
						from Product)
--test2
select* from [show products]


---3 

go
create view ShowFinancialInfo 
with schemabinding
as
select ( p.First_Name + ' ' + p.Last_Name ) as full_name,
		F.Report_Code, CONVERT(date, F.Report_Date) as Report_date, P.Phone,F.Total_Price
		from dbo.seller as  s inner join dbo.person as p on  p.National_Code = S.National_Code
		inner join dbo.Financial_Report as F on S.Seller_ID=F.Seller_ID
create unique clustered index 
  [unique report code]
  on dbo.ShowFinancialInfo (Report_Code)
 
---test 3
	 select* from dbo.ShowFinancialInfo 



----4
create function showmycart(@buyer_code int )
returns table 
as
return(
select C.Number_OF_Products ,c.Price
from cart as C
where @buyer_code=C.Buyer_Code
)
create view mycart
as 
select *
from showmycart(1)

---test 4
 select * from mycart

 


 ----5

 create view showshops
 as 
 select S.Shop_Name,S.Adress,S.Contract_Type,S.Work_Start,S.Work_End
 from Seller as S
 ---test5
 select*from showshops
 ----6

 create view [show comments ]
 with schemabinding
 as
 select p.Product_ID, p.Product_Name as [product name],o.Commentator_Name,o.Comment_Text
	from dbo.Comment as  o inner join dbo.Product as p on o.Product_ID=p.Product_ID
	where o.Product_ID = o.Product_ID

create unique clustered index 
  [unique product  code]
  on dbo.[show comments ](Product_ID)

  ---test 6
  select*from dbo.[show comments ]
  ---7
 
	 create view [show bills  ]
 with schemabinding
 as
 select  o.Bill_Code, o.Number_OF_Products as [num products],o.Price,o.Post_Type,p.Adress,o.Discount_Code
	from dbo.Bill as  o inner join dbo.Buyer as p on o.Buyer_Code=p.Buyer_Code
	create unique clustered index 
  [unique bill  code]
  on dbo.[show bills  ](Bill_Code)
  ---test 7
   select*from dbo.[show bills  ]
	





