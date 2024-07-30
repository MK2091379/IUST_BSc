




------------------------------------------------------
create table buys_audits (
buyer_code int,
Product_ID int,
updated_at datetime,
operation varchar)

--sabt record ha dar jadval buys
create trigger buys_trigger_audits
on Buys
after insert,delete
as
begin
set nocount on;
insert into buys_audits(buyer_code,Product_ID,updated_at,operation)
select i.buyer_code,i.Product_ID,GETDATE(),'insert' from inserted i
union all
select d.buyer_code,d.Product_ID,GETDATE(),'insert' from deleted d
end
------------------------------------------------------------------------------------------------------
---trigger that changes sabad after buys
create trigger call_procedures_after_buys
on Buys
after insert
as
begin
set nocount on;
EXEC [forooshgah].update_cart;
EXEC [forooshgah].show_sabad_kala;
end
---------------------------------------------------------------
create table bind_manager_seller(
seller_id int,
Group_Manager_id int,
adress varchar(max) )
---trigger that finds group manager for sellers after joining
create trigger seller_manager
on Seller
after insert
as 
begin
set nocount on;
insert into bind_manager_seller(seller_id,Group_Manager_id,adress)
select a.Seller_ID,g.Group_Manager_id,a.Adress from inserted a,Group_Manager g where g.Management_Location=a.Adress
end