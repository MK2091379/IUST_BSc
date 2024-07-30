alter table person 
add constraint chk_person check (age>=17 )

 alter table person 
  drop constraint chk_person

    alter table Cart
 add constraint chk_Cart check ( (12345*Discount_Code)%3=0 and Discount_Code>10000)
  
  alter table Cart 
  drop constraint chk_Cart