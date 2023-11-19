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
  especialidad VARCHAR(20) NULL,
  antiguedad VARCHAR(20) NULL,
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

CREATE TABLE Registro (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  valor VARCHAR(100) NOT NULL,
);

CREATE TABLE Cita (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  idRegistro INT NOT NULL,
  fecha DATE NOT NULL,
  hora TIME NOT NULL,
  tratamiento VARCHAR(250) NOT NULL,
  pago VARCHAR(20) NOT NULL,
  aCuenta VARCHAR(15) NOT NULL
  CONSTRAINT fk_Cita_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id),
  CONSTRAINT fk_Cita_Registro FOREIGN KEY(idRegistro) REFERENCES Registro(id)  
);

CREATE TABLE Inventario(
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  articulo VARCHAR(100) NOT NULL,
  precio DECIMAL NOT NULL
);

CREATE TABLE Medicamento (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPaciente INT NOT NULL,
  idInventario	INT NOT NULL,
  cantidad DECIMAL NOT NULL DEFAULT 0,
  descripcion VARCHAR(250) NOT NULL,
  total DECIMAL NOT NULL
  CONSTRAINT fk_Medicamento_Paciente FOREIGN KEY(idPaciente) REFERENCES Paciente(id),
  CONSTRAINT fk_Medicamento_Inventario FOREIGN KEY(idInventario) REFERENCES Inventario (id)
);


CREATE TABLE Horario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idPersonal INT NOT NULL,
  lunes VARCHAR(15) NOT NULL,
  martes VARCHAR(15) NOT NULL,
  miercoles VARCHAR(15) NOT NULL,
  jueves VARCHAR(15) NOT NULL,
  viernes VARCHAR(15) NOT NULL,
  sabado VARCHAR(15) NOT NULL,
  mes VARCHAR(25) NOT NULL,
  permiso DATE NOT NULL
  CONSTRAINT fk_Horario_Personal FOREIGN KEY(idPersonal) REFERENCES Personal(id)
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

ALTER TABLE Registro ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Registro ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Registro ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

ALTER TABLE Cita ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cita ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cita ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo


ALTER TABLE Inventario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Inventario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Inventario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo


ALTER TABLE Medicamento ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Medicamento ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Medicamento ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo


ALTER TABLE Horario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Horario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Horario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminación lógica, 0: Inactivo, 1: Activo

-- PROCEDIMIENTOS ALTERADOS FUNCIONALES

CREATE PROC paPersonalListar @parametro1 VARCHAR(50) 
AS
  SELECT id, cedulaIdentidad, nombres, especialidad, antiguedad, direccion, celular, cargo, usuarioRegistro, fechaRegistro, estado 
  FROM Personal  
  WHERE estado<>-1 AND nombres LIKE '%'+REPLACE(@parametro1,' ','%')+'%';

EXEC paPersonalListar 'Juan';


CREATE PROC paCitaListar 
  @parametro3 VARCHAR(50)
AS
BEGIN
  -- Mostrar resultados
  SELECT
    Registro.valor AS valorRegistro, 
    Cita.id, 
    Cita.idRegistro,
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
  INNER JOIN Registro ON Cita.idRegistro = Registro.id
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


	-- Nombre del paciente Medicamentos y articulo de inventario

CREATE PROC paMedicamentoListar 
  @parametro4 VARCHAR(50)
AS
BEGIN
  SELECT 
    Medicamento.id, 
    Medicamento.idPaciente,
    Medicamento.idInventario,
    Paciente.nombres AS nombresPaciente,
    Inventario.articulo AS articuloInventario,
    Inventario.precio AS precioInventario,
    Medicamento.cantidad, 
    Medicamento.descripcion, 
    Medicamento.total, 
    Medicamento.usuarioRegistro, 
    Medicamento.fechaRegistro, 
    Medicamento.estado
FROM Medicamento
INNER JOIN Paciente ON Medicamento.idPaciente = Paciente.id
INNER JOIN Inventario ON Medicamento.idInventario = Inventario.id
WHERE Medicamento.estado <> -1 AND Paciente.nombres LIKE '%' + REPLACE(@parametro4, ' ', '%') + '%';
END;


-- Ejecutar el procedimiento almacenado
EXEC paMedicamentoListar 'Paracetamol';



CREATE PROC paInventarioListar @parametro VARCHAR(50) 
AS
  SELECT id, articulo, precio, usuarioRegistro, fechaRegistro, estado 
  FROM Inventario  
  WHERE estado<>-1 AND articulo LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPersonalListar 'Ibuprofeno';


CREATE PROC paHorarioListar 
  @parametroHorario VARCHAR(50)
AS
BEGIN
  SELECT 
    Horario.id, 
    Horario.idPersonal,
    Personal.nombres AS nombresPersonal,
    Horario.lunes,
    Horario.martes,
    Horario.miercoles,
    Horario.jueves,
    Horario.viernes,
    Horario.sabado,
    Horario.mes,
    Horario.permiso,
    Horario.usuarioRegistro,
    Horario.fechaRegistro,
    Horario.estado
  FROM Horario
  INNER JOIN Personal ON Horario.idPersonal = Personal.id
  WHERE Horario.estado <> -1 AND Personal.nombres LIKE '%' + REPLACE(@parametroHorario, ' ', '%') + '%';
END;

CREATE PROC paRegistroListar @parametro VARCHAR(50) 
AS
  SELECT id, valor, usuarioRegistro, fechaRegistro, estado 
  FROM Registro  
  WHERE estado<>-1 AND estado LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paPersonalListar 'activo';



--DML

INSERT INTO Personal (cedulaIdentidad, nombres, especialidad, antiguedad, direccion, celular, cargo)
VALUES ('123456789', 'Juan', 'caninos', 'dos años', 'Calle 123', 9876543210, 'Médico');

INSERT INTO Personal (cedulaIdentidad, nombres, especialidad, antiguedad, direccion, celular, cargo)
VALUES ('987654321', 'María', 'cirugias', 'seis meses', 'Calle 456', 1234567890, 'Secretaria');

UPDATE Personal SET nombre='Pedro' WHERE id=1;
UPDATE Personal SET estado=-1 WHERE id=2;
UPDATE Personal SET estado=0 WHERE id=2;

SELECT * FROM Personal WHERE estado=1;

SELECT * FROM Usuario;

INSERT INTO Usuario(usuario, clave, idPersonal)
VALUES ('bryan', '1234', 1),
       ('Rosa10', '1234', 2);

SELECT * FROM Usuario;

-- Insertar un registro activo
INSERT INTO Registro(valor)
VALUES ('Activo');

-- Insertar un registro inactivo
INSERT INTO Registro(valor)
VALUES ('Inactivo');

-- Verificar los registros en la tabla Registro
SELECT * FROM Registro;



