-- 1. COMPORTAMIENTO DE SCRIPT ------------------------------------------------------ --
	-- ------------------------------------------------------------------------------ --
	DROP DATABASE IF EXISTS TelediagnosticoMedico_HeartBits;
	CREATE DATABASE IF NOT EXISTS TelediagnosticoMedico_HeartBits;
	USE TelediagnosticoMedico_HeartBits;
	-- ------------------------------------------------------------------------------ --
-- FIN DE COMPORTAMIENTO DEL SCRIPT - (1) ------------------------------------------- -- 



-- 2. CREACIÓN DE TABLAS ------------------------------------------------------------ --
	-- ------------------------------------------------------------------------------ --
	-- TABLAS DE CHAT --------------------------------------------------------------- --
	CREATE TABLE mensaje (
		id int (10) AUTO_INCREMENT NOT NULL,
		texto varchar (MAX) NOT NULL,
		hora date NOT NULL,
		PRIMARY KEY (id)
	);

	CREATE TABLE salaChat (
		id int (10) AUTO_INCREMENT NOT NULL,
		estado boolean NOT NULL,
		motivo varchar (128) NOT NULL,
		fechaHoraInicio datetime NOT NULL,
		fechaHoraFin datetime NOT NULL,
		PRIMARY KEY (id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS HACIA LAS PERSONAS ----------------------------------------- --
	CREATE TABLE paciente (
		id int (10) AUTO_INCREMENT NOT NULL,
		ci varchar (8) AUTO_INCREMENT NOT NULL,
		primerNom varchar (32) NOT NULL,
		segundoNom varchar (32),
		primerApe varchar (32) NOT NULL,
		segundoApe varchar (32) NOT NULL,
		fechaNacimiento date NOT NULL,
		email varchar (64) NOT NULL UNIQUE,
		habilitado boolean NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE tipo_empleado (
		id int (10) AUTO_INCREMENT NOT NULL,
		nombre varchar (64) NOT NULL UNIQUE,
		PRIMARY KEY (id)
	);	

	CREATE TABLE empleado (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_tipo int (10) NOT NULL,
		ci varchar (8) AUTO_INCREMENT NOT NULL,
		primerNom varchar (32) NOT NULL,
		segundoNom varchar (32),
		primerApe varchar (32) NOT NULL,
		segundoApe varchar (32) NOT NULL,
		fechaNacimiento date NOT NULL,
		email varchar (64) NOT NULL UNIQUE,
		usuario varchar (16) NOT NULL UNIQUE,
		contrasena varchar (16) NOT NULL,
		pin int (4) NOT NULL, 
		PRIMARY KEY (id),
		FOREIGN KEY (id_tipo) REFERENCES tipo_empleado(id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS AL ÁREA MÉDICA --------------------------------------------- --
	CREATE TABLE region (
		id int (10) AUTO_INCREMENT NOT NULL,
		nombre varchar (32) NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE zona (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_region int (10) NOT NULL,
		parte varchar (32) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_region) REFERENCES region(id)
	);	

	CREATE TABLE prioridad (
		id int (10) AUTO_INCREMENT NOT NULL,
		nombre varchar (32) NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE sintoma (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_zona int (10) NOT NULL,
		descripcion varchar (128) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_zona) REFERENCES zona(id)
	);	

	CREATE TABLE patologia (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_prioridad int (10) NOT NULL,
		nombre varchar (32) NOT NULL,
		descripcion varchar (128) NOT NULL,
		indiceMortalidad int (10) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_prioridad) REFERENCES prioridad(id)
	);	

	CREATE TABLE patologia (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_prioridad int (10) NOT NULL,
		nombre varchar (32) NOT NULL,
		descripcion varchar (128) NOT NULL,
		indiceMortalidad int (10) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_prioridad) REFERENCES prioridad(id)
	);	

	CREATE TABLE tipo_diagnostico (
		id int (10) AUTO_INCREMENT NOT NULL,
		nombre varchar (64) NOT NULL UNIQUE,
		PRIMARY KEY (id)
	);	

	CREATE TABLE diagnostico (
		id int (10) AUTO_INCREMENT NOT NULL,
		id_tipo int (10) NOT NULL,
		id_paciente int (10) NOT NULL,
		id_sintoma int (10) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_tipo) REFERENCES tipo_diagnostico(id),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS A RELACIONES DE TABLAS ------------------------------------- --
	CREATE TABLE paciente_sufre (
		id_sintoma int (10) NOT NULL,
		id_paciente int (10) NOT NULL,
		PRIMARY KEY (id_sintoma, id_paciente),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id)
	);

	CREATE TABLE sintoma_compone (
		id_sintoma int (10) NOT NULL,
		id_patologia int (10) NOT NULL,
		PRIMARY KEY (id_sintoma, id_patologia),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id),
		FOREIGN KEY (id_patologia) REFERENCES patologia(id)
	);

	CREATE TABLE peticion (
		id_paciente int (10) NOT NULL,
		id_medico int (10) NOT NULL,
		estado boolean NOT NULL,
		motivo varchar (128) NOT NULL,
		fechaHoraInicio datetime NOT NULL,
		fechaHoraFin datetime NOT NULL,
		PRIMARY KEY (id_paciente, id_medico),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id)
	);

	CREATE TABLE verifica (
		id_tentativo int (10) NOT NULL,
		id_medico int (10) NOT NULL,
		PRIMARY KEY (id_tentativo),
		FOREIGN KEY (id_tentativo) REFERENCES diagnostico(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id)
	);

	CREATE TABLE conversa (
		id_paciente int (10) NOT NULL,
		id_medico int (10) NOT NULL,
		id_mensaje int (10) NOT NULL,
		id_sala int (10) NOT NULL,
		PRIMARY KEY (id_paciente, id_medico, id_mensaje),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id),
		FOREIGN KEY (id_mensaje) REFERENCES mensaje(id),
		FOREIGN KEY (id_sala) REFERENCES salaChat(id)
	);
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS A TABLAS CON COLUMNAS DE VALOR MULTIVALUADO ---------------  --
	CREATE TABLE cel_paciente (
		id_paciente INT (10) NOT NULL,
		celular INT (16) NOT NULL UNIQUE,
		PRIMARY KEY (id_paciente, celular),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id)
	);

	CREATE TABLE cel_empleado (
		id_empleado INT (10) NOT NULL,
		celular INT (16) NOT NULL UNIQUE,
		PRIMARY KEY (id_empleado, celular),
		FOREIGN KEY (id_empleado) REFERENCES empleado(id)
	);
	-- ------------------------------------------------------------------------------ --
-- FIN DE CREACIÓN DE TABLAS - (2) -------------------------------------------------- --


-- 3. INSERCCIÓN DE DATOS ------------------------------------------------------------ --
	-- ------------------------------------------------------------------------------- --
-- FIN DE INSERCCIÓN DE DATOS - (3) -------------------------------------------------- --