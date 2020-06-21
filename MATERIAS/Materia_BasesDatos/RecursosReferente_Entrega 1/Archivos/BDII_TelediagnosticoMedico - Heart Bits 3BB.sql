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
		id INT (10) AUTO_INCREMENT,
		texto BLOB (65535) NOT NULL,
		hora TIME NOT NULL,
		PRIMARY KEY (id)
	);

	CREATE TABLE salaChat (
		id INT (10) AUTO_INCREMENT,
		estado BOOLEAN NOT NULL,
		motivo VARCHAR (128) NOT NULL,
		fechaHoraInicio DATETIME NOT NULL,
		fechaHoraFin DATETIME NOT NULL,
		PRIMARY KEY (id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS HACIA LAS PERSONAS ----------------------------------------- --
	CREATE TABLE paciente (
		id INT (10) AUTO_INCREMENT,
		ci VARCHAR (8) NOT NULL UNIQUE,
		primerNom VARCHAR (32) NOT NULL,
		segundoNom VARCHAR (32),
		primerApe VARCHAR (32) NOT NULL,
		segundoApe VARCHAR (32) NOT NULL,
		fechaNacimiento DATE NOT NULL,
		email VARCHAR (64) NOT NULL UNIQUE,
		habilitado BOOLEAN NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE tipo_empleado (
		id INT (10) AUTO_INCREMENT,
		nombre VARCHAR (64) NOT NULL UNIQUE,
		PRIMARY KEY (id)
	);	

	CREATE TABLE empleado (
		id INT (10) AUTO_INCREMENT,
		id_tipo INT (10) NOT NULL,
		ci VARCHAR (8) NOT NULL UNIQUE,
		primerNom VARCHAR (32) NOT NULL,
		segundoNom VARCHAR (32),
		primerApe VARCHAR (32) NOT NULL,
		segundoApe VARCHAR (32) NOT NULL,
		fechaNacimiento DATE NOT NULL,
		email VARCHAR (64) NOT NULL UNIQUE,
		usuario VARCHAR (16) NOT NULL UNIQUE,
		contrasena VARCHAR (16) NOT NULL,
		pin INT (4) NOT NULL, 
		PRIMARY KEY (id),
		FOREIGN KEY (id_tipo) REFERENCES tipo_empleado(id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS AL ÁREA MÉDICA --------------------------------------------- --
	CREATE TABLE region (
		id INT (10) AUTO_INCREMENT,
		nombre VARCHAR (32) NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE zona (
		id INT (10) AUTO_INCREMENT,
		id_region INT (10) NOT NULL,
		parte VARCHAR (32) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_region) REFERENCES region(id)
	);	

	CREATE TABLE prioridad (
		id INT (10) AUTO_INCREMENT,
		nombre VARCHAR (32) NOT NULL,
		PRIMARY KEY (id)
	);	

	CREATE TABLE sintoma (
		id INT (10) AUTO_INCREMENT,
		id_zona INT (10) NOT NULL,
		descripcion VARCHAR (128) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_zona) REFERENCES zona(id)
	);	

	CREATE TABLE patologia (
		id INT (10) AUTO_INCREMENT,
		id_prioridad INT (10) NOT NULL,
		nombre VARCHAR (32) NOT NULL,
		descripcion VARCHAR (128) NOT NULL,
		indiceMortalidad INT (10) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_prioridad) REFERENCES prioridad(id)
	);	


	CREATE TABLE tipo_diagnostico (
		id INT (10) AUTO_INCREMENT,
		nombre VARCHAR (64) NOT NULL UNIQUE,
		PRIMARY KEY (id)
	);	

	CREATE TABLE diagnostico (
		id INT (10) AUTO_INCREMENT,
		id_tipo INT (10) NOT NULL,
		id_paciente INT (10) NOT NULL,
		id_sintoma INT (10) NOT NULL,
		PRIMARY KEY (id),
		FOREIGN KEY (id_tipo) REFERENCES tipo_diagnostico(id),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id)
	);	
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS A RELACIONES DE TABLAS ------------------------------------- --
	CREATE TABLE paciente_sufre (
		id_sintoma INT (10),
		id_paciente INT (10),
		PRIMARY KEY (id_sintoma, id_paciente),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id)
	);

	CREATE TABLE sintoma_compone (
		id_sintoma INT (10),
		id_patologia INT (10),
		PRIMARY KEY (id_sintoma, id_patologia),
		FOREIGN KEY (id_sintoma) REFERENCES sintoma(id),
		FOREIGN KEY (id_patologia) REFERENCES patologia(id)
	);

	CREATE TABLE peticion (
		id_paciente INT (10),
		id_medico INT (10),
		estado BOOLEAN NOT NULL,
		motivo VARCHAR (128) NOT NULL,
		fechaHoraInicio DATETIME NOT NULL,
		fechaHoraFin DATETIME NOT NULL,
		PRIMARY KEY (id_paciente, id_medico),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id)
	);

	CREATE TABLE verifica (
		id_tentativo INT (10),
		id_medico INT (10) NOT NULL,
		PRIMARY KEY (id_tentativo),
		FOREIGN KEY (id_tentativo) REFERENCES diagnostico(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id)
	);

	CREATE TABLE conversa (
		id_paciente INT (10),
		id_medico INT (10),
		id_mensaje INT (10),
		id_sala INT (10) NOT NULL,
		PRIMARY KEY (id_paciente, id_medico, id_mensaje),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id),
		FOREIGN KEY (id_medico) REFERENCES empleado(id),
		FOREIGN KEY (id_mensaje) REFERENCES mensaje(id),
		FOREIGN KEY (id_sala) REFERENCES salaChat(id)
	);
	-- ------------------------------------------------------------------------------ --


	-- TABLAS ORIENTADAS A TABLAS CON COLUMNAS DE VALOR MULTIVALUADO ---------------  --
	CREATE TABLE cel_paciente (
		id_paciente INT (10),
		celular INT (16),
		PRIMARY KEY (id_paciente, celular),
		FOREIGN KEY (id_paciente) REFERENCES paciente(id)
	);

	CREATE TABLE cel_empleado (
		id_empleado INT (10),
		celular INT (16),
		PRIMARY KEY (id_empleado, celular),
		FOREIGN KEY (id_empleado) REFERENCES empleado(id)
	);
	-- ------------------------------------------------------------------------------ --
-- FIN DE CREACIÓN DE TABLAS - (2) -------------------------------------------------- --


-- 3. INSERCCIÓN DE DATOS ------------------------------------------------------------ --
	-- ------------------------------------------------------------------------------- --
-- FIN DE INSERCCIÓN DE DATOS - (3) -------------------------------------------------- --