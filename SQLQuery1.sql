﻿IF OBJECT_ID('users', 'U') IS NOT NULL
    DROP TABLE users;

CREATE TABLE users(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	date_create DATE NULL
);

SELECT * FROM users

CREATE TABLE categories(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	type VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
)

SELECT * FROM categories

CREATE TABLE income(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	income FLOAT NULL,
	description TEXT NULL,
	date_income DATE NULL,
	date_insert DATE NULL

)

SELECT * FROM income

CREATE TABLE expenses(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	cost FLOAT NULL,
	description TEXT NULL,
	date_expense DATE NULL,
	date_insert DATE NULL

)

SELECT * FROM expenses


