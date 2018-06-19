--Country table
create table Country (
    idCountry varchar(3),
    countryName varchar(40)
    primary key (idCountry)
    )
--drop table Country

--Headquarters table
create table Headquarters(
    codeHeadquarters int identity(1,1),
    city varchar(40),
    country varchar(3),
    creationDate date,
    primary key (codeHeadquarters),
	foreign key (country) references Country(idCountry)
		on delete cascade
		on update cascade
    )
--drop table Headquarters

--Employee table
create table Employee(
    idEmployee int,
    firstName varchar(60),
    middleName varchar(60),
    lastName varchar(60),
    email varchar (60),
    city varchar (60),
    country varchar(3),
    salary float,
    employeeType varchar(60),
    primary key (idEmployee),
    foreign key (country) references Country(idCountry)
		on delete cascade
		on update cascade
    )
--drop table Employee

--Specie table
create table Specie(
    idSpecie int,
    specieName varchar(60)
    primary key (idSpecie)
    )
--drop table Specie

--Adoption proposal table
create table AdoptionProposal(
    idAdoptionProposal int identity(1,1),
    initialDate date,
    theme varchar(60),
    adoptionDescription varchar(60),
    adoptionStatus varchar(60),
    lastDate date
    primary key (idAdoptionProposal)
)
-- drop table AdoptionProposal

--Client table
create table Client(
    idClient int,
    clientName varchar(60),
    middleName varchar(60),
    lastname varchar(60),
    clientType varchar(60),
    photo image,
    primary key (idClient)
)
-- drop table Client

--Pet table
create table Pet(
    idPet int identity(1,1),
    petName varchar(60),
    specie int,
    petDescription varchar(60),
    breed varchar(60),
    condition varchar(60),
    lastDate date,
    castrated varchar(60),
    photo image
    primary key(idPet)
)
--drop table Pet

--Employee Specie intermediate table
create table IntermediateEmployeeSpecie(
    idEmployee int,
    idSpecie int,
    primary key (idEmployee, idSpecie),
    foreign key (idEmployee) references Employee(idEmployee)
    	on delete cascade
		on update cascade,
    foreign key (idSpecie) references Specie(idSpecie)
        on delete cascade
        on update cascade
    )
--drop table IntermediateEmployeeSpecie

--Intermediate table between Headquarters and Employee
create table IntermediateHQandEmployee(
    codeHeadquarters int,
    idEmployee int,
    primary key (codeHeadquarters, idEmployee),
    foreign key (codeHeadquarters) references Headquarters(codeHeadquarters)
        on delete no action
        on update no action,
    foreign key (idEmployee) references Employee(idEmployee)
        on delete cascade
        on update cascade
    )
--drop table IntermediateHQandEmployee

--Intermediate table to define a reviewer for the adoptions proposals
create table IntermediateReviewer(
    idAdoptionProposal int,
    idEmployee int,
    primary key (idAdoptionProposal, idEmployee),
    foreign key (idAdoptionProposal) references AdoptionProposal(idAdoptionProposal)
        on delete cascade
        on update cascade,
    foreign key (idEmployee) references Employee(idEmployee)
        on delete cascade
        on update cascade
)
--drop table IntermediateReviewer

--Intermediate table between Client and Species that the client would like
create table IntermediateSpecieClient(
    idSpecie int,
    idClient int,
    primary key (idSpecie, idClient),
    foreign key (idSpecie) references Specie(idSpecie)
        on delete cascade
        on update cascade,
    foreign key (idClient) references Client(idClient)
        on delete cascade
        on update cascade
)
-- drop table IntermediateSpecieClient

--Intermediate table between client and adoption proposal
create table IntermediateClientAdoptionProposal(
    idAdoptionProposal int,
    idClient int,
    primary key (idAdoptionProposal, idClient),
    foreign key(idAdoptionProposal) references AdoptionProposal(idAdoptionProposal)
        on delete cascade
        on update cascade,
    foreign key (idClient) references Client(idClient)
        on delete cascade
        on update cascade
    )
--drop table IntermediateClientAdoptionProposal

--Intermediate table between Adoption Proposal and Pet
create table IntermediateAdoptionProposalPet(
    idAdoptionProposal int,
    idPet int,
    primary key(idAdoptionProposal, idPet),
    foreign key(idAdoptionProposal) references AdoptionProposal(idAdoptionProposal)
        on delete cascade
        on update cascade,
    foreign key(idPet) references Pet(idPet)
        on delete cascade
        on update cascade
)
--drop table IntermediateAdoptionProposalPet

--Intermediate table between client and pet to define an owner
create table IntermediateForOwner(
    idPet int,
    idClient int,
    primary key(idPet, idClient),
    foreign key(idPet) references Pet(idPet)
        on delete cascade
        on update cascade,
    foreign key (idClient) references Client(idClient)
        on delete cascade
        on update cascade
)

--Inserts
insert into Country values ('AFG', 'Afghanistan')
insert into Country values ('ALB', 'Albania')
insert into Country values ('ARG', 'Argentina')
insert into Country values ('ARM', 'Armenia')
insert into Country values ('AUT', 'Austria')
insert into Country values ('BEL', 'Belgium')
insert into Country values ('BIH', 'Bosnia and Herzegovina')
insert into Country values ('BRA', 'Brazil')
insert into Country values ('KHM', 'Cambodia')
insert into Country values ('CMR', 'Cameroon')
insert into Country values ('CAN', 'Canada')
insert into Country values ('CHL', 'Chile')
insert into Country values ('COL', 'Colombia')
insert into Country values ('CRI', 'Costa Rica')
insert into Country values ('HRV', 'Croatia')
insert into Country values ('CUB', 'Cuba')
insert into Country values ('FRA', 'France')
insert into Country values ('DEU', 'Germany')
insert into Country values ('GRC', 'Greece')
insert into Country values ('GTM', 'Guatemala')
insert into Country values ('HND', 'Honduras')
insert into Country values ('ISL', 'Iceland')
insert into Country values ('IRN', 'Iran')
insert into Country values ('ITA', 'Italy')
insert into Country values ('KAZ', 'Kazakhstan')
insert into Country values ('NLD', 'Netherlands')
insert into Country values ('NIC', 'Nicaragua')
insert into Country values ('NOR', 'Norway')
insert into Country values ('PAK', 'Pakistan')
insert into Country values ('PAN', 'Panama')
insert into Country values ('PRY', 'Paraguay')
insert into Country values ('PER', 'Peru')
insert into Country values ('POL', 'Poland')
insert into Country values ('PRT', 'Portugal')
insert into Country values ('ROU', 'Romania')
insert into Country values ('SRB', 'Serbia')
insert into Country values ('SVK', 'Slovakia')
insert into Country values ('UKR', 'Ukraine')
insert into Country values ('USA', 'United States')
insert into Country values ('URY', 'Uruguay')
insert into Country values ('VEN', 'Venezuela')
insert into Country values ('ZWE', 'Zimbabwe')

insert into Headquarters values('Harare', 'ZWE', '2017/02/15')

select * from Headquarters
