create database Bank;
use Bank;

create table clients(
	id_client int identity(1, 1) not null primary key,
	client_first_name nvarchar(50) not null,
	client_last_name nvarchar(50) not null,
	client_middle_name nvarchar(50) not null,
	client_gender nvarchar(3) not null,
	client_password nvarchar(256) not null,
	client_email nvarchar(50) not null,
	client_phone_number nchar(13) not null
);

create table bank_cards(
	id_bank_card int identity(1, 1) not null primary key,
	bank_card_type nvarchar(50) not null,
	bank_card_number nvarchar(16) not null,
	bank_card_cvv_code nvarchar(3) not null,
	bank_card_balance money default 0,
	bank_card_currency nvarchar(10) not null,
	bank_card_payment_system nvarchar(50) not null,
	bank_card_date date not null,
	bank_card_pin int not null
);

alter table bank_cards add id_client int;
alter table bank_cards add foreign key(id_client) references dbo.clients(id_client) on delete no action on update cascade;

create table transactions(
	id_transaction int identity(1, 1) not null primary key,
	transaction_type varchar(50) not null,
	transaction_destination varchar(200) not null,
	transaction_date date not null,
	transaction_number nchar(50),
	transaction_value money
);

alter table transactions add id_bank_card int;
alter table transactions add foreign key(id_bank_card) references dbo.bank_cards(id_bank_card) on delete no action on update cascade;           

create table credits(
	id_credit int identity(1, 1) not null primary key,
	credit_total_sum money not null,
	credit_sum money not null,
	credit_date date not null,
	credit_status bit not null default 0,
	repayment_date date,
	repayment_sum money
);

alter table credits add id_bank_card int;
alter table credits add foreign key(id_bank_card) references dbo.bank_cards(id_bank_card) on delete no action on update cascade;           
	
create table client_services(
	id_service int identity(1, 1) not null primary key,
	service_name varchar(100) not null,
	service_balance money default 0,
	service_type varchar(100) not null
);

create table client_personal_accounts(
	id_personal_account int identity(1, 1) not null primary key,
	personal_account nvarchar(10) not null
);

alter table client_personal_accounts add id_service int;
alter table client_personal_accounts add foreign key(id_service) references dbo.client_services(id_service) on delete no action on update cascade;   
 
alter table client_personal_accounts add id_client int;
alter table client_personal_accounts add foreign key(id_client) references dbo.clients(id_client) on delete no action on update cascade; 

----------------------------------------------------------------------------------------------------------------------------------------

select * from clients;
select * from bank_cards;
select * from credits;
select * from transactions;
select * from client_services;
select * from client_personal_accounts;

insert into client_services(service_name, service_balance, service_type) VALUES 
('MTC', 0, 'Mobile'),
('MegaFon', 0 , 'Mobile'),
('Tele2', 0, 'Mobile'),
('Beeline', 0, 'Mobile'),
('Yota', 0, 'Mobile');
insert into client_services(service_name, service_type) VALUES 
('Ростелеком', 'Mobile');

insert into client_services(service_name, service_type) VALUES 
('Ростелеком', 'Internet'),
('Зеленая точка', 'Internet'),
('Elink', 'Internet'),
('TTK', 'Internet');

insert into client_services(service_name, service_type) VALUES 
('ГУК', 'Communal'),
('Водоканал', 'Communal'),
('Газоснабжение', 'Communal'),
('Энергоснабжение', 'Communal'),
('ТЭКО Сервис', 'Communal');

insert into client_services(service_name, service_type) VALUES 
('Фонд Хабенского', 'Charity'),
('Подари жизнь', 'Charity');

insert into client_services(service_name, service_type) VALUES 
('Netflix', 'Entertainment'),
('Steam', 'Entertainment'),
('Яндекс+', 'Entertainment');

update bank_cards set bank_card_balance = 5000 where id_bank_card = 2;





















