select *,iif (gender='1','M','F')
from person 
Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('663773','Amin','Gerami','091222','aminhj@gmaim','1000-01-01',1,'17')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('3223233','Moein','Kazemi','0954455','MoeinKazemi@gmail.com','1000-01-01',1,'17')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('2234567','Yasin','Ghoreshi','09130126981','YasinGhoreshi96@gmail.com','1000-01-02',1,'20')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('3066663','Ali','Zahedi','091453581','Alizahedi96@gmail.com','1000-01-02',1,'25')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('30603278','Reza','Ghasemi','09135467981','RezaGH@gmail.com','1000-01-02',1,'28')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('22004567','Mohammad','Gholami','09130126981','MMGholami@gmail.com','1000-01-02',1,'45')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('1330434','esmaiel','fathi','0914343981','esi_fathi99@gmail.com','1000-01-02',1,'32')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('3933232','abas','Barzegar','09130126461','BarzegarAA44@gmail.com','1000-01-02',1,'57')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('23300443','Nima','Kermani','09130236981','Nima_kermani66@gmail.com','1000-01-02',1,'53')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('6637743','Hasan','Abadi','09137726981','HassanAbadi77@gmail.com','1000-01-02',1,'29')

Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('5337743','Ali','Sotoodeh','09163553981','Ali_sotoodeh76546@gmail.com','1000-01-02',1,'39')

 Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('30603278','Reza','Ghasemi','09135467981','RezaGH@gmail.com','1000-01-02',1,'28')

Insert into Seller( sid , Shop_Name ,Adress ,Business_License ,Is_Online_Sale ,Contract_Type,Seller_point,Logo , Work_satr ,work_end,Communication ,Sale_Statistics ,nid )
values ('1','Padoos','Khiyaban Emam','image','y','foroosh_online_offlin','90',null,'00:00:00.0000000','23:59:59.9999999',null,'500','3223233')

Insert into Seller( sid , Shop_Name,Adress ,Business_License ,Is_Online_Sale ,Contract_Type,Seller_point,Logo , Work_satr ,work_end,Communication ,Sale_Statistics ,nid )
values ('2','Poshak Varzehi Mohammadi','Khiyaban Takhti','image','N','foroosh_offline','80',null,'00:00:00.0000000','23:59:59.9999999',null,'1002','663773')

Insert into Seller( sid , Shop_Name ,Adress ,Business_License ,Is_Online_Sale ,Contract_Type,Seller_point,Logo , Work_satr ,work_end,Communication ,Sale_Statistics ,nid )
values ('3','Poshak Arman','Khiyaban Ferdowsi','image','N','foroosh_offline','70',null,'00:00:00.0000000','23:59:59.9999999',null,'100','2234567')

update  seller
set Is_Online_Sale='0'

where sid between 1 and  3

Insert Into Product (Pid,sid, Barcode, Buyer_Point, Supply ,Price,  Color, Product_Name, Picture, Brand , Product_Type, Size, Material,  Guarantee,  Product_Info, Product_Weight)
values('122','1','3245','80','33','100','red','Kafsh varezeshi d',null,'padoos','Shoe','42','Charm','_','_','500') 

Insert Into Product (Pid, sid , Barcode, Buyer_Point, Supply ,Price,  Color, Product_Name, Picture, Brand , Product_Type, Size, Material,  Guarantee,  Product_Info, Product_Weight)
values('121','2','34335','70','600','200','black','Nike_Tshirt',null,'Nike','Tshirt','xLL','Nakh','7 days','Tshirt meshki model skyII','150') 

Insert Into Product (Pid,sid, Barcode, Buyer_Point, Supply ,Price,  Color, Product_Name, Picture, Brand , Product_Type, Size, Material,  Guarantee,  Product_Info, Product_Weight)
values('123','3','33223435','50','10','300','Blue','Jeans',null,'Gap','Trousers','xL','Parche Brezent','7 days','Jeans model d','700') 

Insert Into Comment(cid, pid, Commentator_Name, Comment_Text)
values ('2132','121','mohammad','nesbat be gheymat khoob bood ')

Insert Into Comment(cid, pid, Commentator_Name, Comment_Text)
values ('2152','122','Ali',' khoob nist')

Insert Into Comment(cid, pid, Commentator_Name, Comment_Text)
values ('21332','123','Javad',' Awli')

Insert into Group_Manager(Group_Manager_id, Education, Contract_Type, Management_Location, Communication, nid )
values('1','masters of art','full time','Khiyaban Ferdowsi','091554699','3066663')

Insert into Group_Manager(Group_Manager_id, Education, Contract_Type, Management_Location, Communication, nid )
values('2','masters of Math','part time','Khiyaban Takhti','091624699','30603278')

Insert into Group_Manager(Group_Manager_id, Education, Contract_Type, Management_Location, Communication, nid )
values('3','masters of IT','full time','Khiyaban Emam','09164344699','22004567')

Insert into Employee( Eid ,Education ,Contract_Type, Communication ,nid)
values ('1','masters of IT','full time','029293333','1330434')
Insert into Employee( Eid ,Education ,Contract_Type, Communication ,nid)
values ('100','monshi','full time','9133254283','675433')
Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('6637743','Hasan','Abadi','09137726981','HassanAbadi77@gmail.com','1000-01-02',1,'29')

Insert into  Financial_Report(Report_Code,Number_OF_Images,Volume_OF_Images,Total_Price ,Report_Date ,Number_OF_Sales,sid )
values('1','100','2000','100000','2021-01-01 00:00:00','12','1')

Insert into  Financial_Report(Report_Code,Number_OF_Images,Volume_OF_Images,Total_Price ,Report_Date ,Number_OF_Sales,sid )
values('2','70','1500','220000','2021-01-01 00:00:00','52','2')

Insert into  Financial_Report(Report_Code,Number_OF_Images,Volume_OF_Images,Total_Price ,Report_Date ,Number_OF_Sales,sid )
values('3','440','10000','700000','2021-01-01 00:00:00','105','3')
Insert Into Person (nid,fanme, lname ,phone, email ,Birthday ,Gender ,age )
values ('675433','Hanie','Abadi','09133254283','HanieAbadi77@gmail.com','1000-01-02',0,'20')
Insert into Buyer(Buyer_Code, Account_Type ,Buyer_Point  ,Buys_Number, Adress,nid)
Values ('1','free','30','20','Tajik st','3933232')

Insert into Buyer(Buyer_Code, Account_Type ,Buyer_Point  ,Buys_Number, Adress,nid)
Values ('2','free','20','10','Takhti st','23300443')

Insert into Buyer(Buyer_Code, Account_Type ,Buyer_Point  ,Buys_Number, Adress,nid)
Values ('3','premium','40','33','Shariati','6637743')

Insert into Cart (Cart_Code,Buyer_Code,Discount_Code,Price,Number_OF_Products )
values('1','1','2323','100','2')

Insert into Cart (Cart_Code,Buyer_Code,Discount_Code,Price,Number_OF_Products )
values('2','2',null,'200','4')

Insert into Cart (Cart_Code,Buyer_Code,Discount_Code,Price,Number_OF_Products )
values('3','3','13333','150','1')

insert into Bill(Bill_Code,Buyer_Code,Post_Type,Discount_Code,Pack_Weight,Tracking_Code ,Number_OF_Products,Price )
values ('1','1','hozoori','4335','200','244242242','2','1000')

insert into Bill(Bill_Code,Buyer_Code,Post_Type,Discount_Code,Pack_Weight,Tracking_Code ,Number_OF_Products,Price )
values ('2','2','pishtaz','13455','1120','112441242','10','22000')

insert into Bill(Bill_Code,Buyer_Code,Post_Type,Discount_Code,Pack_Weight,Tracking_Code ,Number_OF_Products,Price )
values ('3','3','hozoori','1235','400','13443242','5','1500')


insert into Site_Manager(Site_Manager_Code,Education,Contract_Type,Communication,nid )
 values ('111','Diploma of Math','full time','434333444','5337743')
 

