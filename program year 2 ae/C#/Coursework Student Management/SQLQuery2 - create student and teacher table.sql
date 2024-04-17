
CREATE TABLE Teacher(
	id INT PRIMARY KEY ,
	username VARCHAR(255),
	email VARCHAR(255),
	telephone VARCHAR(255),
	role VARCHAR(255),
	password VARCHAR(255),
	gender VARCHAR(255),
	personID INT,
	FOREIGN KEY (personID) REFERENCES Person(id)
)