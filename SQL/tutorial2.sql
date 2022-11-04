USE tutorial;

CREATE TABLE orders(
	id INT PRIMARY KEY AUTO_INCREMENT,
    product VARCHAR(150) NOT NULL,
    quantity INT NOT NULL DEFAULT 1,
    amount INT NOT NULL CHECK(amount >= 0),
    customer_id INT NOT NULL
    );

DROP TABLE orders;

CREATE TABLE orders(
	id INT PRIMARY KEY AUTO_INCREMENT,
    product VARCHAR(150) NOT NULL,
    quantity INT NOT NULL DEFAULT 1,
    amount INT NOT NULL CHECK(amount >= 0),
    customer_id INT,
    CONSTRAINT FK_orders_customer_id FOREIGN KEY(customer_id) REFERENCES customers(id) 
    ON DELETE SET NULL
    );

INSERT INTO orders (product,quantity,amount,customer_id) VALUES
	('Prod 1',25,500,11),
	('Prod 2',30,500,11),
    ('Prod 3',27,500,12),
    ('Prod 4',30,500,12),
    ('Prod 5',30,500,13);
    
TRUNCATE TABLE orders;  
TRUNCATE TABLE customers;
DELETE FROM customers WHERE id >= 1;

INSERT INTO customers (name,email,country,age) VALUES 
('User 1','user1@gmail.com','IN',25),
('User 2','user2@gmail.com','IN',25),
('User 3','user3@gmail.com','US',18),
('User 4','user4@gmail.com','IN',20),
('User 5','user5@gmail.com','CN',22);



SELECT product FROM orders,customers WHERE email = 'user1@gmail.com' AND customers.id = customer_id;
SELECT * FROM orders where customer_id = (SELECT id FROM customers WHERE email='user1@gmail.com' limit 1);

SELECT customers.id, name, email, product, quantity, amount
FROM customers INNER JOIN orders
ON customers.id = orders.customer_id;

SELECT customers.id, name, email, product, quantity, amount FROM customers,orders WHERE customers.
id=orders.customer_id;

-- Left Join
SELECT customers.id, name, email, product, quantity, amount
FROM customers LEFT JOIN orders
ON customers.id = orders.customer_id;

-- Right join
SELECT customers.id, name, email, product, quantity, amount
FROM customers RIGHT JOIN orders
ON customers.id = orders.customer_id;

ALTER TABLE orders DROP COLUMN product;

CREATE TABLE products (id INT PRIMARY KEY AUTO_INCREMENT,
		name VARCHAR(50) NOT NULL,
        price INT NOT NULL DEFAULT 0);
        
INSERT INTO products(name,price) VALUES 
('PROD 1',500),
('PROD 2',550),
('PROD 3',600),
('PROD 4',500);

ALTER TABLE orders ADD COLUMN product_id INT;
ALTER TABLE orders ADD CONSTRAINT FK_orders_product_id FOREIGN KEY (product_id) REFERENCES products(id);
ALTER TABLE orders MODIFY COLUMN product_id INT NOT NULL;

-- SELECT customers.name,products.name,orders.id 
SELECT
	customers.id AS customer_id,
    customers.name AS customer_name,
    customers.email,
    products.name AS product_name,
    products.price,
    orders.id AS order_id,
    orders.amount,
    orders.quantity
FROM customers INNER JOIN orders
ON customers.id = orders.customer_id
INNER JOIN products
ON products.id = orders.product_id;

-- variavle:@
SELECT @id:=id FROM customers WHERE email='user1@gmail.com';
SELECT * FROM orders WHERE customer_id=@id;