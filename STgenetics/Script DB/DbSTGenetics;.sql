CREATE DATABASE STGenetics;

USE STGenetics;

CREATE TABLE Animal (
  AnimalId INT PRIMARY KEY,
  Nombre VARCHAR(100),
  Raza VARCHAR(100),
  FechaNacimiento DATE,
  Sexo VARCHAR(10),
  Precio DECIMAL(10, 2),
  Estado VARCHAR(20)
);

INSERT INTO Animal (AnimalId, Nombre, Raza, FechaNacimiento, Sexo, Precio, Estado)
VALUES
  (1, 'Martina', 'Angus', '2022-01-01', 'Hembra', 2500000.00, 'Activo'),
  (2, 'Rodolfo', 'Hereford', '2021-05-15', 'Macho', 3000000.00, 'Activo'),
  (3, 'Lola', 'Simmental', '2020-08-10', 'Hembra', 2000000.00, 'Activo'),
  (4, 'Pedro', 'Brahman', '2022-03-20', 'Macho', 2700000.00, 'Activo'),
  (5, 'Carmen', 'Limousin', '2019-11-05', 'Hembra', 2300000.00, 'Activo'),
  (6, 'Fernando', 'Charolais', '2022-06-18', 'Macho', 2600000.00, 'Activo'),
  (7, 'Clara', 'Holstein', '2020-02-14', 'Hembra', 2100000.00, 'Activo'),
  (8, 'Ricardo', 'Jersey', '2021-08-25', 'Macho', 3200000.00, 'Activo'),
  (9, 'Juana', 'Guernsey', '2019-12-10', 'Hembra', 1800000.00, 'Activo'),
  (10, 'Ramón', 'Angus', '2020-04-30', 'Macho', 2700000.00, 'Activo'),
  (11, 'Lucía', 'Hereford', '2019-07-12', 'Hembra', 2500000.00, 'Activo'),
  (12, 'Javier', 'Limousin', '2021-10-18', 'Macho', 3000000.00, 'Activo'),
  (13, 'Valentina', 'Brahman', '2020-11-25', 'Hembra', 2100000.00, 'Activo'),
  (14, 'Santiago', 'Charolais', '2022-07-02', 'Macho', 2800000.00, 'Activo'),
  (15, 'Isabella', 'Holstein', '2020-03-16', 'Hembra', 2200000.00, 'Activo'),
  (16, 'Mateo', 'Jersey', '2021-09-05', 'Macho', 3100000.00, 'Activo'),
  (17, 'Emma', 'Guernsey', '2019-11-25', 'Hembra', 1900000.00, 'Activo'),
  (18, 'Daniel', 'Angus', '2020-05-15', 'Macho', 2600000.00, 'Activo'),
  (19, 'Mariana', 'Hereford', '2019-08-22', 'Hembra', 2400000.00, 'Activo'),
  (20, 'Matías', 'Charolais', '2022-07-20', 'Macho', 3000000.00, 'Activo');
