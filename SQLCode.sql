--SQL code for creating database and its tables
create database cafe

CREATE TABLE items(
name varchar(250) not null primary key,
category varchar(250) not null,
price bigint not null);

CREATE TABLE accounts(
username varchar(250) not null,
password varchar(250) not null);

CREATE TABLE SingleOrder(
Item varchar(250) not null,
UnitPrice bigint not null,
Quantity int not null,
TotalPrice bigint not null,
ID smallint not null);

CREATE TABLE TotalOrders(
ID smallint not null,
TotalCost bigint not null);

