CREATE DATABASE STGenetics;

USE STGenetics;

CREATE TABLE Animal (
  AnimalId INT PRIMARY KEY,
  Nombre VARCHAR(100),
  Raza VARCHAR(100),
  FechaNacimiento DATE,
  Sexo VARCHAR(10),
  Precio DECIMAL(18, 2),
  Estado VARCHAR(20)
);

INSERT INTO Animal (AnimalId, Nombre, Raza, FechaNacimiento, Sexo, Precio, Estado)
VALUES
  (1, 'Martina', 'Angus', '01/01/2022', 'Hembra', 2500000.00, 'Activo'),
  (2, 'Rodolfo', 'Hereford', '15/05/2021', 'Macho', 3000000.00, 'Activo'),
  (3, 'Lola', 'Simmental', '10/08/2020', 'Hembra', 2000000.00, 'Activo'),
  (4, 'Pedro', 'Brahman', '20/03/2022', 'Macho', 2700000.00, 'Activo'),
  (5, 'Carmen', 'Limousin', '05/11/2019', 'Hembra', 2300000.00, 'Activo'),
  (6, 'Fernando', 'Charolais', '18/06/2022', 'Macho', 2600000.00, 'Activo'),
  (7, 'Clara', 'Holstein', '14/02/2020', 'Hembra', 2100000.00, 'Activo'),
  (8, 'Ricardo', 'Jersey', '25/08/2021', 'Macho', 3200000.00, 'Activo'),
  (9, 'Juana', 'Guernsey', '10/12/2019', 'Hembra', 1800000.00, 'Activo'),
  (10, 'Ramón', 'Angus', '30/04/2020', 'Macho', 2700000.00, 'Activo'),
  (11, 'Lucía', 'Hereford', '12/07/2019', 'Hembra', 2500000.00, 'Activo'),
  (12, 'Javier', 'Limousin', '18/10/2021', 'Macho', 3000000.00, 'Activo'),
  (13, 'Valentina', 'Brahman', '25/11/2020', 'Hembra', 2100000.00, 'Activo'),
  (14, 'Santiago', 'Charolais', '02/07/2022', 'Macho', 2800000.00, 'Activo'),
  (15, 'Isabella', 'Holstein', '16/03/2020', 'Hembra', 2200000.00, 'Activo'),
  (16, 'Mateo', 'Jersey', '05/09/2021', 'Macho', 3100000.00, 'Activo'),
  (17, 'Emma', 'Guernsey', '25/11/2019', 'Hembra', 1900000.00, 'Activo'),
  (18, 'Daniel', 'Angus', '15/05/2020', 'Macho', 2600000.00, 'Activo'),
  (19, 'Mariana', 'Hereford', '22/08/2019', 'Hembra', 2400000.00, 'Activo'),
  (20, 'Matías', 'Charolais', '20/07/2022', 'Macho', 3000000.00, 'Activo');
