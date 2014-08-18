CREATE TABLE Modules (PrKey int not null Identity(1,1), Title varchar(255) not null, Description varchar(255) not null,
	ImageURL varchar(255), OwnerFK int not null, DateCreated datetime not null, DateModified datetime, ModifiedBy int,
	IsActive bit not null, IsPrivate bit not null, PRIMARY KEY (PrKey));
GO
CREATE TABLE Resources (PrKey int not null Identity(1,1), Title varchar(255) not null, Description varchar(255) not null,
	ImageURL varchar(255), OwnerFK int not null, DateCreated datetime not null, DateModified datetime, ModifiedBy int,
	DifficultyLevel int, IsActive bit not null, ResourceTypeFK int not null, PRIMARY KEY (PrKey));
GO

CREATE TABLE Tags (PrKey int not null Identity(1,1), Name varchar(255) not null, PRIMARY KEY (PrKey));
GO

CREATE TABLE ModuleTags (ModulesFK int not null, TagsFK int not null);
GO

CREATE TABLE ResourceTags (ResourcesFK int not null, TagsFK int not null);
GO

CREATE TABLE ResourceType (PrKey int not null Identity(1,1), Name varchar(255) not null,
	IsActive bit not null, PRIMARY KEY(PrKey));
GO
CREATE TABLE Ratings (PrKey int not null Identity(1,1), UsersFK int not null, Rating int not null,
	ModifiedDate datetime, PRIMARY KEY(PrKey));
GO

CREATE TABLE Comments (PrKey int not null Identity(1,1), RatingsFK int, Comment varchar(255) not null, UsersFK int not null,
	ModifiedDate datetime, PRIMARY KEY(PrKey));
GO

CREATE TABLE ResourceExtras (PrKey int not null Identity(1,1), Label varchar(255), StringValue varchar(255), DateVaule datetime,
	ResourcesFK int not null, PRIMARY KEY(PrKey));
GO