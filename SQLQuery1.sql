create table users(
    id int primary key identity(1,1),
    username varchar(MAX) NULL,
    password varchar(MAX) NULL,
    date_create date NULL,
    );