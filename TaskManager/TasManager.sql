CREATE DATABASE EmpresaTickets;

USE EmpresaTickets;

-- Tabla Sector
CREATE TABLE Sector (
    SectorId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL
);
GO

-- Tabla Usuario
CREATE TABLE Usuario (
    UsuarioId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    EsAdministrador BIT NOT NULL,
    SectorId INT FOREIGN KEY REFERENCES Sector(SectorId)
);
GO

-- Tabla EstadoTarea
CREATE TABLE EstadoTarea (
    EstadoTareaId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL
);
GO

-- Insertar estados iniciales
INSERT INTO EstadoTarea (Nombre) VALUES ('Pendiente'), ('Completada');
GO

-- Tabla Tarea
CREATE TABLE Tarea (
    TareaId INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(200) NOT NULL,
    Descripcion TEXT NOT NULL,
    FechaSolicitada DATETIME NOT NULL,
    FechaEsperadaFinalizacion DATETIME NOT NULL,
    FechaFinalizacion DATETIME NULL,
    EstadoTareaId INT FOREIGN KEY REFERENCES EstadoTarea(EstadoTareaId),
    UsuarioId INT FOREIGN KEY REFERENCES Usuario(UsuarioId)
);
GO

-- Tabla ComentarioTarea
CREATE TABLE ComentarioTarea (
    ComentarioTareaId INT PRIMARY KEY IDENTITY(1,1),
    Comentario TEXT NOT NULL,
    FechaComentario DATETIME NOT NULL,
    TareaId INT FOREIGN KEY REFERENCES Tarea(TareaId)
);
GO

-- Insertar Sectores
INSERT INTO Sector (Nombre) VALUES ('Sistemas'), ('Mantenimiento'), ('Compras');
GO

-- Insertar Usuarios (Administradores y empleados)

-- Administradores
INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) 
VALUES 
('Juan P�rez', 'juan@sistemas.com', 'admin123', 1, 1), -- Admin de Sistemas
('Luis Mart�nez', 'luis@mantenimiento.com', 'admin123', 1, 2), -- Admin de Mantenimiento
('Carla G�mez', 'carla@compras.com', 'admin123', 1, 3); -- Admin de Compras
GO
INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) 
VALUES
('Horacio Ortiz', 'horacio0291@gmail.com','admin',1,1)
GO





-- Empleados del Sector Sistemas
INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) 
VALUES 
('Ana Torres', 'ana@sistemas.com', 'user123', 0, 1),
('Carlos D�az', 'carlos@sistemas.com', 'user123', 0, 1),
('Luc�a Fern�ndez', 'lucia@sistemas.com', 'user123', 0, 1);
GO

-- Empleados del Sector Mantenimiento
INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) 
VALUES 
('Pedro S�nchez', 'pedro@mantenimiento.com', 'user123', 0, 2),
('Marta Ruiz', 'marta@mantenimiento.com', 'user123', 0, 2),
('Jorge Rojas', 'jorge@mantenimiento.com', 'user123', 0, 2);
GO

-- Empleados del Sector Compras
INSERT INTO Usuario (Nombre, Email, Password, EsAdministrador, SectorId) 
VALUES 
('Sof�a L�pez', 'sofia@compras.com', 'user123', 0, 3),
('Ignacio Gonz�lez', 'ignacio@compras.com', 'user123', 0, 3),
('Patricia Dom�nguez', 'patricia@compras.com', 'user123', 0, 3);
GO

-- Insertar Tareas de prueba

-- Tareas para el sector Sistemas
INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId)
VALUES
('Actualizar servidores', 'Realizar la actualizaci�n de los servidores de la empresa.', GETDATE(), DATEADD(DAY, 7, GETDATE()), 1, 2), -- Asignada a Ana Torres
('Configurar red interna', 'Configurar la nueva red interna de la oficina.', GETDATE(), DATEADD(DAY, 5, GETDATE()), 1, 3), -- Asignada a Carlos D�az
('Revisar seguridad', 'Revisar las medidas de seguridad en los sistemas de la empresa.', GETDATE(), DATEADD(DAY, 10, GETDATE()), 1, 4); -- Asignada a Luc�a Fern�ndez
GO

-- Tareas para el sector Mantenimiento
INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId)
VALUES
('Reparar aire acondicionado', 'Reparar el aire acondicionado de la sala de servidores.', GETDATE(), DATEADD(DAY, 2, GETDATE()), 1, 5), -- Asignada a Pedro S�nchez
('Revisi�n de maquinaria', 'Revisar el estado de las m�quinas de producci�n.', GETDATE(), DATEADD(DAY, 5, GETDATE()), 1, 6), -- Asignada a Marta Ruiz
('Mantenimiento preventivo', 'Realizar mantenimiento preventivo en las instalaciones el�ctricas.', GETDATE(), DATEADD(DAY, 7, GETDATE()), 1, 7); -- Asignada a Jorge Rojas
GO

-- Tareas para el sector Compras
INSERT INTO Tarea (Titulo, Descripcion, FechaSolicitada, FechaEsperadaFinalizacion, EstadoTareaId, UsuarioId)
VALUES
('Cotizaci�n de proveedores', 'Cotizar con nuevos proveedores para la adquisici�n de equipos.', GETDATE(), DATEADD(DAY, 3, GETDATE()), 1, 8), -- Asignada a Sof�a L�pez
('Comprar insumos', 'Realizar la compra de insumos para la oficina.', GETDATE(), DATEADD(DAY, 1, GETDATE()), 1, 9), -- Asignada a Ignacio Gonz�lez
('Negociaci�n de contratos', 'Negociar contratos con proveedores internacionales.', GETDATE(), DATEADD(DAY, 10, GETDATE()), 1, 10); -- Asignada a Patricia Dom�nguez
GO



-- Actualizar estado de las tareas como "Completada" (simulaci�n de finalizaci�n)
UPDATE Tarea
SET FechaFinalizacion = GETDATE(), EstadoTareaId = 2
WHERE TareaId IN (1, 2, 3);
GO

ALTER TABLE Tarea
DROP CONSTRAINT FK_Tarea_Usuario;

ALTER TABLE Tarea
ADD CONSTRAINT FK_Tarea_Usuario
FOREIGN KEY (UsuarioId) REFERENCES Usuario(UsuarioId)
ON DELETE CASCADE;

ALTER TABLE Tarea
DROP CONSTRAINT FK_Tarea_Usuario;

ALTER TABLE Tarea
ADD CONSTRAINT FK_Tarea_Usuario
FOREIGN KEY (UsuarioId) REFERENCES Usuario(UsuarioId)
ON DELETE CASCADE;

DROP TABLE ComentarioTarea;


