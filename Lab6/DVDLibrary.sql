use DVDLibrary;
create table DVDLibrary(
	DVDCodeNo int primary key,
	DVDTitle nvarchar(100) not null,
	[Language] nvarchar(20) not null,
	subtitle bit not null,
	price money not null
);
select * from DVDLibrary;
create Login mylogin with password = 'mylogin', CHECK_POLICY = OFF
EXEC sp_changedbowner 'mylogin';