USE PersonPresentation_DB;

INSERT INTO Persons (CNP, FirstName, LastName, Birth, Age, Sex)
VALUES ('1990801203544', 'Popica', 'Ioan', '1999-08-01', 19, 0);

INSERT INTO Persons (CNP, FirstName, LastName, Birth, Age, Sex)
VALUES ('5000801207611', 'Marisal', 'Alex', '2000-08-01', 17, 0);

INSERT INTO Persons (CNP, FirstName, LastName, Birth, Age, Sex)
VALUES ('5000801204227', 'Pop', 'Radu', '2000-08-01', 17, 0);

INSERT INTO Persons (CNP, FirstName, LastName, Birth, Age, Sex)
VALUES ('6000801200600', 'Moldovan', 'Alexandra', '2000-08-01', 17, 1);

INSERT INTO Persons (CNP, FirstName, LastName, Birth, Age, Sex)
VALUES ('6000801201805', 'Moldovan', 'Cristina', '2000-08-01', 17, 1);


select * from persons;