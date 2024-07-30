alter table person 
add constraint chk_person check (age>=17 )

 alter table person 
  drop constraint chk_person

alter table person 
add constraint un_person unique (phone)

 alter table seller 
 add constraint chk_seller check ((Is_Online_Sale='1' or Is_Online_Sale='0' ) )

 alter table product 
add constraint chk_product check (Product_Weight>0 and price >0)

 alter table Financial_Report
 add constraint chk_Financial_Report check (Number_OF_Sales>=0 and Total_Price>0and Number_OF_Images>0and Volume_OF_Images>0)
 
 alter table Buyer
 add constraint chk_Buyer check (  Buys_Number>0 and Buyer_Point>=0 )

  alter table Cart
 add constraint chk_Cart check ( (12345*Discount_Code)%3=0 and Discount_Code>10000)
  
  alter table Cart 
  drop constraint chk_Cart

   alter table Bill
  add constraint chk_Bill check ( Discount_Code>0 and Pack_Weight>0 and Number_OF_Products>0 and  price>0)