create table Users(
    Id int primary key AUTO_INCREMENT,
    Username varchar(255) not null,
    Email varchar(255) not null,
    Password varchar(255) not null,
    DateCreated datetime not null,
    DateDeleted datetime default null, 
    DateModified datetime default null
)