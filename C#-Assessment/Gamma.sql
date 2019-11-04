create table products(
	productid int primary key identity,
	productname varchar(40)
	)
	drop table products
	select * from products

	create table supplier(
	supplierid int primary key,
	suppliername varchar(20),
	price int,
	location varchar(20),
	Productid int,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
	);

	create table customers(
	customerid int primary key identity,
	customername varchar(20),
	quan int,
	Productid int,
	supplierid int,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	FOREIGN KEY (supplierid) REFERENCES supplier(supplierid)
	);

	insert into products values('laptops');
	
	insert into products values('mobiles');
	
	insert into products values('earphones');


	insert into supplier values(101,'dell',40000,'mum',1);
	insert into supplier values(102,'HP',45000,'dehl',1);
	insert into supplier values(103,'lenovo',35000,'chenn',1);
	insert into supplier values(104,'Asus',60000,'taiwan',1);

	insert into supplier values(105,'Xiaomi',20000,'china',2);
    insert into supplier values(106,'Oneplus',35000,'shanghai',2);
	insert into supplier values(107,'Apple',60000,'Cali',2);
	insert into supplier values(108,'Samsung',40000,'jap',2);

	insert into supplier values(109,'Sannheiser',4000,'newjers',3);
	insert into supplier values(110,'boat',8000,'ghana',3);
	insert into supplier values(111,'boss',15000,'malibu',3);
	insert into supplier values(112,'piston',2000,'newjers',3);

	select * from products