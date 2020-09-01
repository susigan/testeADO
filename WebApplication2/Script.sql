
CREATE PROCEDURE ExcluirTimePorId
(
	@TimeId int
)
as

begin
	Delete from Times where TimeId = @TimeId
end

exec ExcluirTimePorId @TimeId = 2
end

	CREATE PROCEDURE AtualizarTime
	(
		@TimeId Int,
		@Time nvarchar(100),
		@Estado char(2),
		@Cores varchar(50)
	)
	as

	begin

	Update Times set Time = @Time,
	Estado = @Estado, Cores = @Cores
	where TimeId = @TimeId

	end

	exec AtualizarTime @TimeId = 1, @Time = ' a' , @Estado = 'JH' , @Cores = ' Cor'

	select * from Times


	CREATE PROCEDURE IncluirTime
	(
		@Time nvarchar(100),
		@Estado char(2),
		@Cores varchar(50)
	)
	as 
	begin
		Insert into Times values (@Time, @Estado, @Cores)
	end

	exec IncluirTime @Time = 'time J' , @Estado = 'IJ', @cores = 'rubro'

	CREATE PROCEDURE ObterTimes
	as
	begin
		Select TimeId, Time, Estado, Cores from Times
	end