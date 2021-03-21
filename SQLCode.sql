--SQL code for creating database and its tables
create database cafe

CREATE TABLE items(
name varchar(250) not null primary key,
category varchar(250) not null,
price bigint not null);

CREATE TABLE accounts(
username varchar(250) not null primary key,
password varchar(250) not null);

CREATE TABLE SingleOrder(
Item varchar(250) not null primary key,
UnitPrice bigint not null,
Quantity int not null,
TotalPrice bigint not null,
ID smallint not null);

CREATE TABLE TotalOrders(
ID smallint not null primary key,
TotalCost bigint not null);

