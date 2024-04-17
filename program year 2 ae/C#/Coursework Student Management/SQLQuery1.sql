CREATE TABLE Person(
	id INT PRIMARY KEY ,
	username VARCHAR(255),
	email VARCHAR(255),
	telephone VARCHAR(255),
	role VARCHAR(255),
	password VARCHAR(255),
	work_type VARCHAR(255),
	salary FLOAT
)

SELECT * FROM Person


INSERT INTO Person (id, username, email, telephone, role, password, work_type, salary) VALUES (1, 'admin', 'admin@gmail.com', '091234567', 'admin', 'adminpassword', 'full-time', 100000)