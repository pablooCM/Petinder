-- Create headquarters procedure
create procedure createHeadquarters
    @city varchar(40),
    @country varchar(3),
    @creationDate date
    as
    begin
        insert into Headquarters values (@city, @country, @creationDate)
    end
-- drop procedure createHeadquarters

--Update headquarters procedure
create procedure updateHeadquarters
    @codeHeadquarters int,
    @city varchar(40),
    @country varchar(3),
    @creationDate date
    as
	begin
	SET NOCOUNT ON
	UPDATE Headquarters
	SET
        city=@city,
        country=@country,
        creationDate=@creationDate
        from Headquarters
        where codeHeadquarters=@codeHeadquarters
    end
--drop procedure updateHeadquarters

--Delete headquarters procedure
create procedure deleteHeadquarters
    @codeHeadquarters int
    as
    begin
        delete Headquarters
        from Headquarters
        where codeHeadquarters=@codeHeadquarters
    end
--drop procedure deleteHeadquarters

--Procedure to create Pets
create procedure createPet
    @petName varchar(60),
    @specie int,
    @petDescription varchar(60),
    @breed varchar(60),
    @condition varchar(60),
    @lastDate date,
    @castrated varchar(60),
    @photo image
    as
    begin
        insert into Pet values (@petName, @specie, @petDescription, @breed, @condition, @lastDate, @castrated, @photo)
    end
--drop procedure create pet

--Procedure to update pet
create procedure updatePet
    @idPet int,
    @petName varchar(60),
    @specie int,
    @petDescription varchar(60),
    @breed varchar(60),
    @condition varchar(60),
    @lastDate date,
    @castrated varchar(60),
    @photo image
    as
    begin
    SET NOCOUNT ON
    UPDATE Pet
    SET
        petName=@petName,
        specie=@specie,
        petDescription=@petDescription,
        breed=@breed,
        condition=@condition,
        lastDate=@lastDate,
        castrated=@castrated,
        photo=@photo
        from Pet
        where idPet=@idPet
    end
--drop procedure updatePet

--procedure to delete Pet
create procedure deletePet
    @idPet int
    as
    begin
        delete Pet
        from Pet
        where idPet=@idPet
    end

--procedure to create employees
create procedure createEmployee
    @idEmployee int,
    @fullName varchar(60),
    @email varchar(60),
    @city varchar(60),
    @country varchar(3),
    @salary float,
    @employeeType varchar(6)
    as
    begin
        insert into Employee values (@idEmployee, @fullName, @email, @city, @country, @salary, @employeeType)
    end

--Update Employee procedure
create procedure updateEmployee
    @idEmployee int,
    @fullName varchar(60),
    @email varchar(60),
    @city varchar(60),
    @country varchar(3),
    @salary float,
    @employeeType varchar(6)
    as
	begin
	SET NOCOUNT ON
	UPDATE Employee
	SET
        fullName=@fullName,
        email=@email,
        city=@city,
        country=@country,
        salary=@salary,
        employeeType=@employeeType
        from Employee
        where idEmployee=@idEmployee
    end

--Procedure to delete employee
create procedure deleteEmployee
    @idEmployee int
    as
    begin
        delete Employee
        from Employee
        where idEmployee=@idEmployee
    end



insert into Pet values('Fofo', 1, 'Pos un perro', 'French Poodle', 'Excellent', '2018/03/02', 'YES',
'http://images.evisos.co.cr/2012/11/24/linda-cachorra-french-poodle-tacita-en-venta_fd904d2f0f_3.jpg')

