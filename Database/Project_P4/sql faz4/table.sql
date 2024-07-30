create table person (
nid int  not null,
fanme varchar(50) not null,
lname varchar (50) not null,
phone decimal(10,0)  null,
email varchar(255) default '-',
Birthday date null default '1000-01-01', 
Gender  bit not null ,
age int,
primary key (nid)
)



Create table Seller(
 sid int not null ,
 Shop_Name nvarchar(50),
 Adress nvarchar(max) null,
 Business_License image not null,
 Is_Online_Sale bit null default '-',--
 Contract_Type nvarchar(50) not null,
 Seller_point int,
 Logo image NULL,
 Work_satr time NOT NULL,
 work_end time NOT NULL,
 Communication nvarchar(max) NULL default '-',
 Sale_Statistics int,
 nid int foreign key references person(nid),
 primary key (sid)
 );

 Create table Product(
  Pid int primary key not null,
  sid int foreign key references Seller(sid),
  Barcode float not null,
  Buyer_Point int  null ,
  Supply int default 0 ,--
  Price money not null,--
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
cid int not null ,
pid int  foreign key references product(pid ) not null,
Commentator_Name nvarchar(50) default 'Known',
Comment_Text varchar(max) null,
primary key (Cid),
)
Create table Group_Manager(
 Group_Manager_id int not null ,
 Education varchar(50) null,
 Contract_Type nvarchar(50) not null,
 Management_Location nvarchar(50)null  default '-',
 Communication nvarchar(max) null default '-',
 nid int foreign key references person (nid), 
 primary key (Group_Manager_id)
 )
Create table Employee(
  Eid int not null,
 Education nvarchar(50)null,
 Contract_Type nvarchar(50) not null,
 Communication nvarchar(max)null default '-',
nid int foreign key references person(nid)  ,
 primary key (Eid)
 )
Create Table Financial_Report(
Report_Code  int not null,
Number_OF_Images int null,
Volume_OF_Images int  null,
Total_Price money not null,
Report_Date datetime not null,
Number_OF_Sales int not null,
sid int foreign key references Seller(sid) not null,
primary key (Report_Code)
 )
 alter table Financial_Report
 add constraint chk_Financial_Report check (Number_OF_Sales>=0 and Total_Price>0and Number_OF_Images>0and Volume_OF_Images>0)
Create table Buyer(
  Buyer_Code int not null,
  Account_Type nvarchar(50) not null,
  Buyer_Point int null,
  Buys_Number int default 0,
  Adress nvarchar(max) null,
  nid int foreign key references person(nid) not null,
  primary key (Buyer_Code)
  )
   alter table Buyer
 add constraint chk_Buyer check (  Buys_Number>0 and Buyer_Point>=0 )
  
Create table Cart (
  Cart_Code int not null,
  Buyer_Code int foreign key references buyer(buyer_code)not null,
    Discount_Code int default 0, 
  Price money not null,
   Number_OF_Products int not null,
  primary key (Cart_Code) 
  )
  
Create table Bill(
  Bill_Code int ,
  Buyer_Code int foreign key references buyer(buyer_code)not null,
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
 nid int foreign key  references person(nid) not null,
 primary key (Site_Manager_Code),
)




