
create table Person (
National_Code int  ,
First_Name varchar(50) not null,
Last_Name varchar (50) not null,
Phone decimal  null,
Email varchar(255) default '-',
Birthday date  default '1000-01-01', 
Gender  bit ,
Age int,
primary key (National_Code)
)


create table Seller(
 Seller_ID int ,
 Seller_Password int,
 Shop_Name nvarchar(50),
 Adress nvarchar(max) null,
 Business_License image not null,
 Is_Online_Sale varchar ,
 Contract_Type nvarchar(50) not null,
 Seller_point int,
 Logo image NULL,
 Work_Start time ,
 Work_End time ,
 Communication nvarchar(max) NULL default '-',
 Sale_Statistics int,
 National_Code int foreign key references person(National_Code),
 primary key (Seller_ID)
 );

 Create table Product(
  Product_ID int primary key ,
  Seller_ID int foreign key references Seller(Seller_ID),
  Barcode int not null,
  Buyer_Point int  null ,
  Supply int default 0 ,
  Price money ,
  Color nvarchar(50)  default '-' ,
  Product_Name nvarchar(50) not null,
  Picture image,
  Brand nvarchar(50) not null,
  Product_Type nvarchar(50) not null,
  Size varchar(50) not null,--
  Material nvarchar(250) default '-' ,
  Guarantee nvarchar(50) default '-',
  Product_Info nvarchar(max) default'-' ,
  Product_Weight int  default'-',
  
)

Create table Comment(
Comment_ID int ,
Product_ID int  foreign key references Product(Product_ID ) ,
Commentator_Name nvarchar(50) default 'UNKnown',
Comment_Text varchar(max) null,
primary key (Comment_ID),
)
Create table Group_Manager(
 Group_Manager_id int  ,
 Education varchar(50) ,
 Contract_Type nvarchar(50) not null,
 Management_Location nvarchar(50)null  default '-',
 Communication nvarchar(max) null default '-',
 National_Code int foreign key references person (National_Code), 
 primary key (Group_Manager_id)
 )
Create table Employee(
  Employee_ID int ,
 Education nvarchar(50)null,
 Contract_Type nvarchar(50) not null,
 Communication nvarchar(max)null default '-',
National_Code int foreign key references person(National_Code)  ,
 primary key (Employee_ID)
 )
Create Table Financial_Report(
Report_Code  int ,
Number_OF_Images int null,
Volume_OF_Images int  null,
Total_Price money not null,
Report_Date datetime not null,
Number_OF_Sales int not null,
Seller_ID int foreign key references Seller(Seller_ID) not null,
primary key (Report_Code)
 )
 alter table Financial_Report
 add constraint chk_Financial_Report check (Number_OF_Sales>=0 and Total_Price>0and Number_OF_Images>0and Volume_OF_Images>0)
Create table Buyer(
  Buyer_Code int ,
  Buyer_Password int not null,
  Account_Type nvarchar(50) not null,
  Buyer_Point int null,
  Buys_Number int,
  Adress nvarchar(max) null,
  National_Code int foreign key references person(National_Code) not null,
  primary key (Buyer_Code)
  )
   
  
Create table Cart (
  Cart_Code int ,
  Buyer_Code int foreign key references buyer(Buyer_Code)not null,
    Discount_Code int default 0, 
  Price money ,
   Number_OF_Products int not null,
  primary key (Cart_Code) 
  )

  Create table Buys
  (
  Buyer_Code int foreign key references Buyer(Buyer_Code ) ,
  Product_ID int  foreign key references Product(Product_ID ) ,
  )
  
Create table Bill(
  Bill_Code int ,
  Buyer_Code int foreign key references buyer(Buyer_Code)not null,
  Post_Type nvarchar(50) not null,
   Discount_Code int default 0 not null, 
   Pack_Weight int  null,
   Tracking_Code int not null,
	Number_OF_Products int not null,
  Price money 
 constraint  PK_bill primary  key (Bill_code,tracking_Code)

  )
	
Create Table Site_Manager(
  Site_Manager_Code int not null,
 Education nvarchar(50) null,
 Contract_Type nvarchar(50) not null,
 Communication nvarchar(max) null default '-',
 National_Code int foreign key  references person(National_Code) not null,
 primary key (Site_Manager_Code),
)




