--CLIENTES
CREATE TABLE CLIENTES (
	[id_cli] INT NOT NULL IDENTITY,
	[nombre_cli] VARCHAR(50) NOT NULL,
	[apellido_cli] VARCHAR(50) NOT NULL,
	[alias_cli] VARCHAR(50) NOT NULL,
	[contrasenia_cli] VARCHAR(10) NOT NULL,
	PRIMARY KEY ([id_cli])
);
