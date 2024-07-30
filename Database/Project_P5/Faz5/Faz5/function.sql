use final

--1

go
create function  getid (@fname varchar(50),@lname varchar(50))
returns table  
as 
	return
	( 
	select i.National_Code
	from person as i
	where i.First_Name=@fname and i.Last_Name=@lname);
	---test1
	select *from getid('amin','Gerami')




	---2
	create function getEmail_Phone (@id int )
	returns table
	as 
	return 
	(
	select phone=Communication.Phone ,Email=Communication.Email 
	from Person as Communication 
	where @id=Communication.National_Code
	);
	--test2
	select *from getEmail_Phone(3066663)





	---3
	
go
create function CalculatePrice
		(
							@supply int
							,@price int)
	returns bigint
	as 
	begin
		return @supply * @price;
	end ;
	---test 3 
	select p.Product_Name ,sum(dbo.CalculatePrice(p.Supply,p.Price)) as [price table] 
	from Product as p
	group by Product_Name
	order by [price table] desc
	
	
	
	
	---4
		go
create function showCustomerOrders(@buyer_code int)
returns table
as
return
(
	select  p.Product_Name,p.Product_Info,p.Product_Type,p.Product_Weight,p.Color,p.Material
	from Buys o inner join Product p on o.Product_ID=p.Product_ID
	where o.Buyer_Code = @buyer_code
);

---test 4
select *from showCustomerOrders(1)






---5

create function showComment(@product_id int)
returns table
as
return
(
	select  p.Product_Name,o.Commentator_Name,o.Comment_Text
	from Comment o inner join Product p on o.Product_ID=p.Product_ID
	where o.Product_ID = @product_id
);
---test 5
select *from showComment(121)
select *from showComment(122)
select *from showComment(123)

---6 
select *
from Seller 
drop function [filter online shop]

create function [filter online shop](@azemtiaz int ,@taemtiaz int)
returns table 
as 
return
(
select S.Shop_Name,S.Seller_point,S.Work_Start,S.Work_End
from seller as S
where (S.Seller_point>=@azemtiaz and S.Seller_point<=@taemtiaz) and( S.Is_Online_Sale='y' or s.Is_Online_Sale='Y')
);
--- test 6 
select *from [filter online shop](20,100)




	

	

	
	
	

	
		