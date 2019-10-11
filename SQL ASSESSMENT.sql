create database bala
use bala

create table branch_master(
		branch_id varchar(6),
		branch_name varchar(30),
		branch_city varchar(30)
		PRIMARY KEY(branch_id)
	)

	create table customer_master(
		customer_number varchar(6),
		firstname varchar(30),
		middlename varchar(30),
		lastname varchar(30),
		customer_city varchar(15),
		customer_contact_no varchar(10),
		occupation varchar(20),
		customer_date_of_birth DATE,
		PRIMARY KEY(customer_number)
)	

create table loan_details(
		customer_number varchar(6),
		branch_id varchar(6),
		loan_amount INT
		constraint FK_branch Foreign key(branch_id)
		references branch_master(branch_id),
		constraint FK_branch1 Foreign key(customer_number)
		references customer_master(customer_number)
)


create table account_master(
account_number varchar(6),
customer_number varchar(6),
branch_id varchar(6),
opening_balance int,
account_opening_date DATE,
account_type varchar(10),
account_status varchar(10),
PRIMARY KEY(account_number),
constraint AK_branch Foreign key(branch_id)
references branch_master(branch_id),
constraint AK_branch1 Foreign key(customer_number)
references customer_master(customer_number)
)

create table transaction_datails(
transaction_number varchar(6),
account_number varchar(6),
date_of_transaction DATE,
medium_of_trassaction varchar(20),
transaction_type varchar(20),
transaction_amount INT,
PRIMARY KEY(transaction_number),
constraint BK_branch1 Foreign key(account_number)
references account_master(account_number)
)

insert into branch_master values('B00001','ASAF ALI ROAD','DEHLI')
insert into branch_master values('B00002','NEW DEHLI MAIN BRANCH','DEHLI')
insert into branch_master values('B00003','DEHLI CANTT','DEHLI')
insert into branch_master values('B00004','JASOLA','DEHLI')
insert into branch_master values('B00005','MAHIM','MUMBAI')
insert into branch_master values('B00006','VILE PARLE','MUMBAI')
insert into branch_master values('B00007','MANDVI','MUMBAI')
insert into branch_master values('B00008','JADAVPUR','KOLKATA') 
insert into branch_master values('B00009','KODAMBAKKAM','CHENNAI')

INSERT INTO customer_master VALUES ('C00001', 'RAMESH','CHANDRA','SHARMA','DELHI','9543198345','SERVICE','1976-12-06')
INSERT INTO customer_master VALUES('C00002', 'AVINASH','CHANDRA','MINHA','DELHI','9543198345','SERVICE','1974-10-16') 
INSERT INTO customer_master VALUES('C00003', 'RAHUL','SUNDER','RASTOGI','DELHI','9876532109','STUDENT','1981-09-26')
INSERT INTO customer_master VALUES('C00004', 'PARUL','NULL','GANDHI','DELHI','9765178901','HOUSEWIFE','1976-11-03') 
INSERT INTO customer_master VALUES('C00005', 'NAVEEN','NULL','AEDEKAR','MUMBAI','9876532109','SERVICE','1976-09-19') 
INSERT INTO customer_master VALUES('C00006', 'CHITRESH','CHANDRA','BARWE','MUMBAI','8976523190','STUDENT','1992-11-06') 
INSERT INTO customer_master VALUES('C00007', 'AMIT','NULL','BORKAR','MUMBAI','7651298321','STUDENT','1981-09-06')
INSERT INTO customer_master VALUES('C00008', 'NISHA','KUMAR','DAMLE','MUMBAI','9875189761','SERVICE','1975-12-03')
INSERT INTO customer_master VALUES('C00009', 'ABHISHEK','NULL','DUTTA','KOLKATA','9856198761','SERVICE','1973-05-22')
INSERT INTO customer_master VALUES('C00010', 'SHANKAR','NULL','NAIR','CHENNAI','8765489076','SERVICE','1976-07-12') 


insert into loan_details values('C00001','B00001',100000)
insert into loan_details values('C00002','B00002',200000)
insert into loan_details values('C00009','B00008',400000)
insert into loan_details values('C00010','B00008',500000)
insert into loan_details values('C00001','B00003',600000)
insert into loan_details values('C00002','B00001',600000)

insert into account_master values('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')
insert into account_master values('A00002','C00002','B00001',1000,'2012-06-12','SAVING','ACTIVE')
insert into account_master values('A00003','C00003','B00002',1000,'2012-05-17','SAVING','ACTIVE')
insert into account_master values('A00004','C00002','B00005',1000,'2013-01-27','SAVING','ACTIVE')
insert into account_master values('A00005','C00006','B00006',1000,'2012-12-17','SAVING','ACTIVE')
insert into account_master values('A00006','C00007','B00007',1000,'2010-08-12','SAVING','SUSPENDED')
insert into account_master values('A00007','C00007','B00001',1000,'2012-10-02','SAVING','ACTIVE')
insert into account_master values('A00008','C00001','B00003',1000,'2009-11-09','SAVING','TERMINATED')
insert into account_master values('A00008','C00003','B00007',1000,'2008-11-30','SAVING','TERMINATED')
insert into account_master values('A000010','C00004','B00002',1000,'2013-03-01','SAVING','ACTIVE')

INSERT INTO transaction_datails VALUES('T00001','A00001','2013-01-01','CHEQUE','DEPOSIT',2000)
INSERT INTO transaction_datails VALUES('T00002','A00001','2013-02-01','CASH','WITHDRAWAL',1000)
INSERT INTO transaction_datails VALUES('T00004','A00002','2013-01-11','CASH','DEPOSIT',3000)
INSERT INTO transaction_datails VALUES('T00005','A00007','2013-01-13','CASH','DEPOSIT',7000)
INSERT INTO transaction_datails VALUES('T00006','A00007','2013-03-13','CASH','DEPOSIT',9000)
INSERT INTO transaction_datails VALUES('T00007','A00001','2013-03-13','CASH','DEPOSIT',4000)
INSERT INTO transaction_datails VALUES('T00008','A00001','2013-03-24','CHEQUE','DEPOSIT',3000)
INSERT INTO transaction_datails VALUES('T0009','A00001','2013-03-21','CASH','WITHDRAWAL',9000)
INSERT INTO transaction_datails VALUES('T00010','A00001','2013-03-22','CASH','WITHDRAWAL',2000)
INSERT INTO transaction_datails VALUES('T000011','A00002','2013-02-25','CASH','WITHDRAWAL',7000)
INSERT INTO transaction_datails VALUES('T000012','A00007','2013-02-26','CASH','WITHDRAWAL',2000)

select * from branch_master
select * from account_master
select * from customer_master
select * from transaction_datails
select * from loan_details

select a.customer_number,c.firstname,c.lastname,a.account_opening_date
from customer_master c, account_master a
where a.customer_number=c.customer_number

select count(*) as Cust_Count from customer_master where customer_city='Delhi'

select a.customer_number,c.firstname 
from account_master a,customer_master c
where a.customer_number=c.customer_number and day(customer_date_of_birth)>15
order by customer_number,account_number

select c.customer_number,c.firstname,a.account_number
from account_master a, customer_master c
where c.customer_number=a.customer_number and account_status='terminated'


select count(*) as Trans_Count 
from transaction_datails t, account_master a
where t.account_number=a.account_number and a.customer_number  like '%001'

select count(*) as Count_Customer 
from loan_details 
where customer_number not in (select distinct customer_number from account_master )


select t.account_number ,sum(t.transaction_amount)+a.opening_balance as Deposit_Amount
from transaction_datails t JOIN account_master a on a.account_number=t.account_number
where transaction_type='DEPOSIT'
group by t.account_number,a.opening_balance
