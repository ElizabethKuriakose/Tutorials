CREATE DATABASE tutorial;
USE tutorial;
CREATE TABLE customers(
	id INT PRIMARY KEY AUTO_INCREMENT ,
    name VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    country VARCHAR(5) NOT NULL,
    dob DATE NOT NULL,
    age INT DEFAULT 18
);

INSERT INTO customers(name,email,country,dob,age) VALUES('Alexander','alex@gmail.com','AUS','1998-02-21',18);

INSERT INTO customers(name,email,country,dob,age) VALUES
('Mariya','mariya@gmail.com','IN','1998-05-31',20),
('Ann','ann@gmail.com','IN','1999-05-31',20);

INSERT INTO customers(name,email,country,dob,age) VALUES
('Jain','jain@gmail.com','US','2000-10-10',22),
('Bimin','bimin@gmail.com','IN','2000-08-10',22),
('Vismaya','vismaya@gmail.com','US','1998-05-20',24);

DROP TABLE customers; 

SELECT * FROM customers WHERE country IN ('IN');
SELECT * FROM customers WHERE id BETWEEN 1 AND 3;

INSERT INTO customers(name,email,country,dob,age) VALUES('','sachin@gmail.com','AUS','1998-02-21',18);

DELETE FROM customers WHERE id IN (6,7);

SELECT * FROM customers ORDER BY age;

SELECT DISTINCT country FROM customers;

SELECT name FROM customers WHERE age=(SELECT MAX(age) FROM customers);

SELECT AVG(age) FROM customers;
SELECT MIN(age) AS minimum_age FROM customers;

UPDATE customers SET age = 24 WHERE id=1;

-- alter->add-remove-rename

ALTER TABLE customers ADD (fname VARCHAR(50) NOT NULL,lname VARCHAR(50) NOT NULL);
ALTER TABLE customers DROP COLUMN lname;
ALTER TABLE customers MODIFY name VARCHAR(100);
-- ALTER TABLE customers ALTER COLUMN  country VARCHAR(10);
ALTER TABLE customer RENAME TO customers;
ALTER TABLE customers MODIFY dob date;
ALTER TABLE customer DROP COLUMN fname;