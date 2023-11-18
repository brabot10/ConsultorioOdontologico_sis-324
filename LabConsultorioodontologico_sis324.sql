-- DDL
CREATE DATABASE LabSis324; 


USE master
GO
CREATE LOGIN usrodontologia WITH PASSWORD=N'123456',
	DEFAULT_DATABASE=LabSis324,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE LabSis324
GO        
CREATE USER usrodontologia FOR LOGIN usrodontologia
GO
ALTER ROLE db_owner ADD MEMBER usrodontologia
GO



DROP TABLE Usuario;
DROP TABLE Personal;
DROP TABLE Paciente;
DROP TABLE Cita;
DROP TABLE Medicamento;

CREATE TABLE Personal (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(15) NOT NULL,
  nombres VARCHAR(20) NOT NULL,
  primerApellido VARCHAR(20) NULL,
  segundoApellido VARCHAR(20) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(30) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  usuario VARCHAR(12) NOT NULL,
  clave VARCHAR(100) NOT NULL
  CONSTRAINT fk_Usuario_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
);

CREATE TABLE Paciente (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  nombres VARCHAR(20) NOT NULL,
  cedulaIdentidad VARCHAR(15) NOT NULL,
  alergias VARCHAR(250) NULL,
  fechaNacimiento DATE NOT NULL,
  celular BIGINT NOT NULL
  CONSTRAINT fk_Paciente_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
);

CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  fecha DATE NOT NULL,
  hora VARCHAR(20) NOT NULL,
  tratamiento VARCHAR(250) NOT NULL,
  pago VARCHAR(20) NOT NULL,
  aCuenta VARCHAR(15) NOT NULL
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id) 
);

CREATE TABLE Medicamento (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  articulo VARCHAR(250) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  precio DECIMAL NOT NULL
  CONSTRAINT fk_Medicamento_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id)
);
ALTER TABLE Personal ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Personal ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Personal ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Paciente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Paciente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Paciente ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Cita ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cita ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cita ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Medicamento ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Medicamento ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Medicamento ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo


-- PROCEDIMIENTOS ALTERADOS FUNCIONALES

CREATE PROC paPersonalListar @parametro1 VARCHAR(50) 
AS
  SELECT id, cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo, usuarioRegistro, fechaRegistro, estado 
  FROM Personal  
  WHERE estado<>-1 AND nombres LIKE '%'+REPLACE(@parametro1,' ','%')+'%';

EXEC paPersonalListar 'Juan';


CREATE PROC paCitaListar 
  @parametro3 VARCHAR(50)
AS
BEGIN
  -- Mostrar resultados
  SELECT 
    Cita.id, 
    Paciente.nombres AS nombresPaciente,
    Cita.fecha, 
    Cita.hora, 
    Cita.tratamiento, 
    Cita.pago, 
    Cita.aCuenta, 
    Cita.usuarioRegistro, 
    Cita.fechaRegistro, 
    Cita.estado
  FROM Cita
  INNER JOIN Paciente ON Cita.idPaciente = Paciente.id
  WHERE Cita.estado <> -1 AND Paciente.nombres LIKE '%' + REPLACE(@parametro3, ' ', '%') + '%';
END;

 	-- Doctor Asignado Pacientes

CREATE PROC paPacienteListar 
  @parametro2 VARCHAR(50)
AS
BEGIN
  -- Mostrar resultados
  SELECT 
    Paciente.id, 
    Paciente.idPersonal, 
    Personal.nombres AS nombresPersonal,
    Paciente.cedulaIdentidad, 
    Paciente.nombres, 
    Paciente.alergias, 
    Paciente.fechaNacimiento, 
    Paciente.celular, 
    Paciente.usuarioRegistro, 
    Paciente.fechaRegistro, 
    Paciente.estado
  FROM Paciente
  INNER JOIN Personal ON Paciente.idPersonal = Personal.id
  WHERE Paciente.estado <> -1 AND Paciente.nombres LIKE '%' + REPLACE(@parametro2, ' ', '%') + '%';
END;

-- Ejecutar el procedimiento almacenado
EXEC paPacienteListar 'María';


 	-- Encargado  Usuario

CREATE PROC paUsuarioListar 
  @parametro VARCHAR(50)
AS
BEGIN
  -- Mostrar resultados
  SELECT 
    Usuario.id, 
    Usuario.idPersonal, 
    Personal.nombres AS nombresPersonal,
    Usuario.usuario, 
    Usuario.clave, 
    Usuario.usuarioRegistro, 
    Usuario.fechaRegistro, 
    Usuario.estado
  FROM Usuario
  INNER JOIN Personal ON Usuario.idPersonal = Personal.id
  WHERE Usuario.estado <> -1 AND Usuario.usuario LIKE '%' + REPLACE(@parametro, ' ', '%') + '%';
END;

-- Ejecutar el procedimiento almacenado
EXEC paUsuarioListar 'bryan';


	-- Nombre del paciente Medicamentos

CREATE PROC paMedicamentoListar 
  @parametro4 VARCHAR(50)
AS
BEGIN
  SELECT 
    Medicamento.id, 
    Medicamento.idPaciente, 
    Paciente.nombres AS nombresPaciente,
    Medicamento.articulo, 
    Medicamento.descripcion, 
    Medicamento.precio, 
    Medicamento.usuarioRegistro, 
    Medicamento.fechaRegistro, 
    Medicamento.estado
FROM Medicamento
INNER JOIN Paciente ON Medicamento.idPaciente = Paciente.id
WHERE Medicamento.estado <> -1 AND Paciente.nombres LIKE '%' + REPLACE(@parametro4, ' ', '%') + '%';
END;

-- Ejecutar el procedimiento almacenado
EXEC paMedicamentoListar 'Paracetamol';



--DML

INSERT INTO Personal (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123456789', 'Juan', 'Pérez', 'García', 'Calle 123', 9876543210, 'Médico');

INSERT INTO Personal (cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('987654321', 'María', 'González', 'Díaz', 'Calle 456', 1234567890, 'Secretaria');

UPDATE Personal SET nombre='Pedro' WHERE id=1;
UPDATE Personal SET estado=-1 WHERE id=2;
UPDATE Personal SET estado=0 WHERE id=2;

SELECT * FROM Personal WHERE estado=1;

SELECT * FROM Usuario;

INSERT INTO Usuario(usuario, clave, idPersonal)
VALUES ('bryan', '1234', 1),
       ('Rosa10', '1234', 2);

SELECT * FROM Usuario;





