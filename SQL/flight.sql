CREATE DATABASE FMS;

USE FMS;

CREATE TABLE flights(flight_no INT PRIMARY KEY, 
	flight_name VARCHAR(50) NOT NULL,
	flight_desc VARCHAR(100) NOT NULL,
	fl_capacity INT DEFAULT 40);

CREATE TABLE f_schedule(
	sid INT PRIMARY KEY AUTO_INCREMENT,
    fl_from VARCHAR(30) NOT NULL,
    fl_to VARCHAR(30) NOT NULL,
    fl_date DATE,
    fl_time TIME,
    cost INT NOT NULL DEFAULT 30000,
    fl_no INT,
    CONSTRAINT FK_fl_no FOREIGN KEY(fl_no) REFERENCES flights(flight_no)
    ON DELETE SET NULL
    );
    
CREATE TABLE passengers(
	pid INT PRIMARY KEY AUTO_INCREMENT,
    p_name VARCHAR(50) NOT NULL,
    user_name VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    u_password VARCHAR(20) NOT NULL,
    mobile BIGINT NOT NULL,
    address VARCHAR(100),
    dob DATE
);

CREATE TABLE booked_ticket(
	tick_no INT PRIMARY KEY AUTO_INCREMENT,
    date_of_booking DATE NOT NULL,
    date_of_travel DATE NOT NULL,
    fl_no INT,
    book_from VARCHAR(30) NOT NULL,
    book_to VARCHAR(30) NOT NULL,
    flight_time TIME,
    boarding_time TIME,
    flt_seat INT NOT NULL,
    passenger_id INT,
    CONSTRAINT FK_flight_no FOREIGN KEY(fl_no) REFERENCES flights(flight_no)
    ON DELETE SET NULL,
    CONSTRAINT FK_pass_id FOREIGN KEY(passenger_id) REFERENCES passengers(pid)
    ON DELETE SET NULL
);