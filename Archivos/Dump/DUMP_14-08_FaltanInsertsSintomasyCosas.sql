-- 1. COMPORTAMIENTO DE SCRIPT ------------------------------------------------------ --
	-- ------------------------------------------------------------------------------ --
	DROP DATABASE IF EXISTS TelediagnosticoMedico_HeartBits;
	CREATE DATABASE IF NOT EXISTS TelediagnosticoMedico_HeartBits;
	USE TelediagnosticoMedico_HeartBits;
	-- ------------------------------------------------------------------------------ --
-- FIN DE COMPORTAMIENTO DEL SCRIPT - (1) ------------------------------------------- -- 

-- 2. CREACIÓN DE TABLAS ------------------------------------------------------------ --
--
-- Base de datos: `telediagnosticomedico_heartbits`
--


--
-- Estructura de tabla para la tabla `ciudad`
--

CREATE TABLE `ciudad` (
  `id` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `id_dpto` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ciudad`
--

INSERT INTO `ciudad` (`id`, `nombre`, `id_dpto`) VALUES
(1, 'Montevideo', 19),
(2, 'Rivera', 6),
(3, 'Punta del Este', 2),
(4, 'Salto', 8),
(5, 'Paysandú', 9),
(6, 'Melo', 5),
(7, 'Maldonado', 2),
(8, 'Tacuarembó', 18),
(9, 'Mercedes', 11),
(10, 'Artigas', 7),
(11, 'Minas', 16),
(12, 'San José', 13),
(13, 'Durazno', 17),
(14, 'Florida', 15),
(15, 'Treinta y Tres', 4),
(16, 'Rocha', 3),
(17, 'Fray Bentos', 10),
(18, 'Bella Unión', 7),
(19, 'Colonia del Sacramento', 12),
(20, 'Trinidad', 14),
(21, 'Canelones', 1),
(22, 'Carmelo', 12),
(23, 'Santa Lucía', 1),
(24, 'Paso de los Toros', 17),
(25, 'Castillos', 3),
(26, 'Tranqueras', 6),
(27, 'Lascano', 3),
(28, 'Vergara', 4),
(29, 'La Paloma', 3),
(30, 'Aiguá', 2),
(31, 'Baltasar Brum', 7),
(32, 'José Batlle y Ordóñez', 16);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conversa`
--

CREATE TABLE `conversa` (
  `id_paciente` int(10) NOT NULL,
  `id_medico` int(10) NOT NULL,
  `id_mensaje` int(10) NOT NULL,
  `id_sala` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `id` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`id`, `nombre`) VALUES
(1, 'Canelones'),
(2, 'Maldonado'),
(3, 'Rocha'),
(4, 'Treinta y tres'),
(5, 'Cerro largo'),
(6, 'Rivera'),
(7, 'Artigas'),
(8, 'Salto'),
(9, 'Paysandou'),
(10, 'Rio negro'),
(11, 'Soriano'),
(12, 'Colonia'),
(13, 'San jose'),
(14, 'Flores'),
(15, 'Florida'),
(16, 'Lavalleja'),
(17, 'Durazno'),
(18, 'Tacuarembo'),
(19, 'Montevideo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `diagnostico`
--

CREATE TABLE `diagnostico` (
  `id` int(10) NOT NULL,
  `id_tipo` int(10) NOT NULL,
  `id_paciente` int(10) NOT NULL,
  `id_sintoma` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensaje`
--

CREATE TABLE `mensaje` (
  `id` int(10) NOT NULL,
  `texto` mediumtext NOT NULL,
  `hora` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_sufre`
--

CREATE TABLE `paciente_sufre` (
  `id_sintoma` int(10) NOT NULL,
  `id_paciente` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologia`
--

CREATE TABLE `patologia` (
  `id` int(10) NOT NULL,
  `id_prioridad` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `indiceMortalidad` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `patologia`
--

INSERT INTO `patologia` (`id`, `id_prioridad`, `nombre`, `descripcion`, `indiceMortalidad`) VALUES
(1, 2, 'Nefropatía crónica', 'La enfermedad renal crónica, también llamada insuficiencia renal crónica, describe la pérdida gradual de la función renal.', 30),
(2, 2, 'Diabetes tipo 1', 'La diabetes tipo 1 es un trastorno crónico en el cual el páncreas produce muy poca insulina o directamente no la produce.', 15),
(3, 3, 'Cataratas', 'Una catarata es una opacidad de la transparencia normal del cristalino del ojo.', 1),
(4, 2, 'Neumonia', 'La neumonía es una infección que inflama los sacos aéreos de uno o ambos pulmones.', 15),
(5, 2, 'Retinopatia diabetica', 'La retinopatía diabética es una complicación de la diabetes que afecta los ojos. Es causada por el daño a los vasos sanguíneos.', 20),
(6, 1, 'Diabetes tipo 2', 'La diabetes de tipo 2 es un trastorno crónico que afecta la manera en la cual el cuerpo metaboliza el azúcar.', 40),
(7, 3, 'Asma bronquial', 'El asma es una afección en la que se estrechan y se hinchan las vías respiratorias, lo cual produce mayor mucosidad.', 8),
(8, 2, 'Colera', 'El cólera es una enfermedad bacteriana que, por lo general, se propaga a través del agua contaminada.', 30),
(9, 1, 'Leucemia', 'La leucemia es el cáncer de los tejidos que forman la sangre en el organismo, incluso la médula ósea y el sistema linfático.', 51),
(10, 3, 'Artritis', 'La artritis es la hinchazón y la sensibilidad de una o más de las articulaciones.', 1),
(11, 3, 'Parkinson', 'La enfermedad de Parkinson es una enfermedad progresiva del sistema nervioso que afecta el movimiento.', 1),
(12, 1, 'Linfoma', 'El linfoma es un tipo de cáncer del sistema linfático, que es parte de la red del organismo que combate los gérmenes.', 75),
(13, 1, 'Fiebre amarilla', 'La fiebre amarilla es una infección viral que transmite un tipo particular de mosquito, frecuente en Africa y Sudamerica.', 50),
(14, 1, 'Fibrosis pulmonar', 'La fibrosis pulmonar es una enfermedad pulmonar que se produce cuando el tejido pulmonar se daña y se producen cicatrices.', 45),
(15, 3, 'Migraña', 'La migraña puede causar un dolor pulsátil intenso o una sensación de latido en la cabeza, generalmente de un solo lado.', 2),
(16, 3, 'Mononucleosis', 'El virus que causa la mononucleosis se transmite por la saliva.', 3),
(17, 2, 'Zika', 'La enfermedad por el virus del Zika es una infección viral transmitida por los mosquitos.', 15),
(18, 3, 'Hepatitis A', 'La hepatitis A es una infección del hígado sumamente contagiosa causada por el virus de la hepatitis A.', 5),
(19, 2, 'Hepatitis B', 'La hepatitis B es una infección hepática grave causada por el virus VHB.', 22),
(20, 2, 'Hepatitis C', 'La hepatitis C es una infección vírica que causa inflamación del hígado, lo que a veces conduce a un daño hepático grave.', 30),
(21, 3, 'Conjuntivitis', 'La conjuntivitis es una inflamación o una infección en la membrana transparente que recubre el párpado y el globo ocular.', 0),
(22, 1, 'Bronquitis', 'La bronquitis es una inflamación del revestimiento de los bronquios que llevan el aire hacia adentro y fuera de los pulmones.', 40),
(23, 3, 'Pancreatitis', 'La pancreatitis es inflamación en el páncreas.', 8),
(24, 1, 'Sindrome nefrotico', 'El síndrome nefrótico es un trastorno renal que hace que el cuerpo excrete demasiadas proteínas en la orina.', 5),
(25, 3, 'Sinusitis aguda', 'La sinusitis aguda hace que los espacios dentro de la nariz (senos paranasales) se inflamen e hinchen.', 5),
(26, 3, 'Siringomielia', 'La siringomielia es el desarrollo de un quiste lleno de líquido dentro de la médula espinal.', 5),
(27, 1, 'Sindrome pulmonar por hantavirus', 'El síndrome pulmonar por hantavirus es una enfermedad infecciosa caracterizada por síntomas similares a la influenza.', 40),
(28, 3, 'Tracoma', 'El tracoma es una infección bacteriana que afecta los ojos. Se produce por la bacteria Chlamydia trachomatis.', 0),
(29, 2, 'Tuberculosis', 'La bacteria suele atacar los pulmones, pero puede también dañar otras partes del cuerpo.', 30),
(30, 3, 'Ganglion', 'Los quistes ganglionares son bultos no cancerosos ,con frecuencia se forman a lo largo de los tendones o de las articulaciones.', 0),
(31, 1, 'Gangrena', 'La gangrena es la muerte de tejido corporal como consecuencia de la falta de irrigación sanguínea o de una infección bacteriana.', 40),
(32, 2, 'Gastritis', 'La gastritis es un término general para un grupo de enfermedades con un punto en común: la inflamación del estómago.', 20),
(33, 3, 'Glaucoma', 'El glaucoma es un grupo de afecciones oculares que dañan el nervio óptico, cuya salud es vital para tener una buena vista.', 5),
(34, 2, 'Vasculitis', 'La vasculitis es la inflamación de los vasos sanguíneos. Provoca cambios en las paredes de los vasos sanguíneos.', 30),
(35, 1, 'VIH', 'El síndrome de inmunodeficiencia adquirida es una afección crónica que puede poner en riesgo la vida. ', 55),
(36, 1, 'Rabia', 'La rabia es un virus mortal que se propaga a las personas a través de la saliva de animales infectados.', 99),
(37, 3, 'Atelectasia', 'La atelectasia es un colapso completo o parcial del pulmón entero o de una parte (lóbulo) del pulmón.', 8),
(38, 3, 'Diarrea', 'La diarrea (deposiciones blandas, líquidas y posiblemente más frecuentes) es un problema común.', 3),
(39, 2, 'Disfagia', 'Es la dificultad para tragar.', 30),
(40, 3, 'Tendinitis', 'La tendinitis es la inflamación o la irritación de un tendón, las cuerdas fibrosas que unen el músculo al hueso.', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `id` int(10) NOT NULL,
  `ci` int(8) NOT NULL,
  `primerNom` varchar(32) NOT NULL,
  `segundoNom` varchar(32) DEFAULT NULL,
  `primerApe` varchar(32) NOT NULL,
  `segundoApe` varchar(32) NOT NULL,
  `genero` char(1) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  `email` varchar(64) NOT NULL,
  `calle` varchar(64) NOT NULL,
  `npuerta` int(10) NOT NULL,
  `id_ciudad` int(10) NOT NULL,
  `habilitado` tinyint(1) DEFAULT NULL,
  `id_tipo` int(10) NOT NULL,
  `especialidad` varchar(64) DEFAULT NULL,
  `usuario` varchar(16) DEFAULT NULL,
  `contrasena` varchar(16) DEFAULT NULL,
  `pin` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`id`, `ci`, `primerNom`, `segundoNom`, `primerApe`, `segundoApe`, `genero`, `fechaNacimiento`, `email`, `calle`, `npuerta`, `id_ciudad`, `habilitado`, `id_tipo`, `especialidad`, `usuario`, `contrasena`, `pin`) VALUES
(1, 4606718, 'Julia', 'Leila', 'Howe', 'Perry', 'M', '1959-05-10', 'Maecenas.libero@gmail.com', 'Quisque', 1538, 2, NULL, 2, 'Ginecologa', 'jul59', '681nlo', NULL),
(2, 3557076, 'Beverly', NULL, 'Riley', 'Contreras', 'M', '1999-09-26', 'nulla.at.sem@hotmail.com', 'Vivamus', 4995, 5, 1, 3, NULL, NULL, NULL, NULL),
(3, 2839922, 'Anastasia', 'Jaquelyn', 'Crado', 'Kiss', 'M', '1946-11-10', 'lobortis.tellus.justo@gmail.com', 'Ariel', 5999, 6, NULL, 1, NULL, 'admintata16', '14adhj', 2006),
(4, 4133638, 'Oscar', 'Spencer', 'Rodriguez', 'Yang', 'H', '2002-07-20', 'nec@utpharetra.net', 'Box', 8500, 10, 0, 3, NULL, NULL, NULL, NULL),
(5, 1432111, 'Alexander', 'Marcelo', 'Coper', 'Wallace', 'H', '1967-05-16', 'ultrices.sit@egestaslacinia.com', 'Oncativo', 5943, 1, 1, 3, NULL, NULL, NULL, NULL),
(6, 2204067, 'Nicole', NULL, 'Ocampos', 'Vinson', 'M', '1986-07-27', 'ultrices.sit.amet@Integer.net', 'Malesuada', 4229, 1, 1, 3, NULL, NULL, NULL, NULL),
(7, 5666113, 'Pedro', 'Ivan', 'Casilla', 'Woodward', 'H', '2000-05-03', 'mauris.ut@justonecante.com', 'Elementum', 6006, 1, 1, 3, NULL, NULL, NULL, NULL),
(8, 4280732, 'Joaquin', 'Sebastian', 'Monroe', 'Diaz', 'H', '1995-06-21', 'Integer.id.magna@parturient.com', 'Facilisis', 8334, 1, 1, 3, NULL, NULL, NULL, NULL),
(9, 3156712, 'Camila', NULL, 'Perez', 'Roy', 'M', '1985-11-11', 'tristique.aliquet@inceptos.com', 'Av. Italia', 9062, 1, 1, 3, NULL, NULL, NULL, NULL),
(10, 6149604, 'Micaela', 'Julieta', 'Foster', 'Bowman', 'M', '1979-07-18', 'sociosqu.ad.litora@gmail.com', 'Lacinia', 9988, 6, NULL, 2, 'Oftalmologa', 'jul79', 'qn96v3', NULL),
(11, 5224198, 'Erik', 'Carlos', 'Rice', 'Carpe', 'H', '1966-12-26', 'non.luctus.sit@lacusvarius.org', 'Parturient', 7016, 17, NULL, 2, 'Otorrinolaringólogo', 'ric66', 'v13t35', NULL),
(12, 3208289, 'Thadeo', 'Juan', 'Guerrero', 'Tran', 'H', '1975-02-11', 'amet.ornare.lectus@facilisis.com', 'Temperley', 1078, 22, NULL, 2, 'Cardiologa', 'tran75', 'uw148j', NULL),
(13, 4596088, 'Aldo', NULL, 'Barrios', 'Lopez', 'H', '1979-03-17', 'tincidunt.adipiscing@egetvenenatis.ca', 'Av. Rivera', 4235, 25, NULL, 2, 'Medicina General', 'aldo79', 'b8o4bw', NULL),
(14, 6663503, 'Guillermo', 'José', 'Rige', 'Gentry', 'H', '2001-06-03', 'nec.leo.Morbi@iaculis.net', 'Magna', 3339, 28, NULL, 2, 'Neurologo', 'rig01', 'y07b46', NULL),
(15, 6695371, 'Lydia', 'Emilia', 'Colinas', 'Campos', 'M', '1974-09-11', 'egestas@liberoestcongue.org', 'Libero', 8243, 1, NULL, 2, 'Neumologa', 'lyd74', 'me4a6c', NULL),
(16, 4068858, 'Javier', NULL, 'Park', 'Welch', 'H', '2000-07-13', 'odio.Aliquam.vulputate@dapibusidblandit.edu', 'Augue', 8682, 1, NULL, 2, 'Gastroenterologo', 'jav20', 'kvs6hk', NULL),
(17, 5114430, 'Santiago', NULL, 'Garcia', 'Mercado', 'H', '1978-10-04', 'nisl.sem@velesttempor.com', 'Dolor', 7158, 16, NULL, 2, 'Infectologo', 'san78', 'n3a71h', NULL),
(18, 3038135, 'Melanie', NULL, 'Burris', 'Crane', 'M', '1992-04-07', 'gravida@purusmaurisa.com', 'Aliquam', 4621, 2, NULL, 2, 'Neurologo', 'mel92', 'eo2161', NULL),
(19, 3845826, 'Kevin', 'Ricardo', 'Alfonso', 'Perry', 'H', '1972-11-11', 'bibendum.sed@dolor.edu', 'Amet', 2092, 28, NULL, 2, 'Proctologo', 'kev72', '3j7yc7', NULL),
(20, 5185760, 'Vincente', NULL, 'Sanders', 'Chavez', 'H', '1977-01-16', 'eget.metus@vulputate.edu', 'Egestas', 6922, 1, NULL, 2, 'Reumatologo', 'vic77', '55j9in', NULL),
(21, 1298681, 'Ruby', NULL, 'Walto', 'Buker', 'H', '2003-07-20', 'Lorem.ipsum@gmail.com', 'Bell', 4789, 7, 1, 3, NULL, NULL, NULL, NULL),
(22, 4244423, 'Benjamin', 'Lucas', 'Norris', 'Ryan', 'H', '2002-12-10', 'dis.parturient.montes@htomail.com', 'Palermo', 1333, 12, 1, 3, NULL, NULL, NULL, NULL),
(23, 4925527, 'Mia', 'Lana', 'Velazquez', 'Glover', 'M', '2014-01-11', 'arcu@mauris.edu.uy', 'Siracusa', 8742, 31, 1, 3, NULL, NULL, NULL, NULL),
(24, 2113795, 'Eleanor', NULL, 'Casey', 'Haynes', 'M', '1960-10-04', 'sagittis.Nullam.vitae@elementumategestas.org', 'Calle 3', 2284, 25, 1, 3, NULL, NULL, NULL, NULL),
(25, 5367691, 'Martin', 'Brian', 'Mcdowell', 'Mileto', 'H', '1944-01-23', 'molestie.pharetra.nibh@enimMauris.com', 'Orinoco', 4434, 23, 1, 3, NULL, NULL, NULL, NULL),
(26, 1161827, 'Kalani', NULL, 'Hilikiler', 'Mope', 'M', '2009-05-26', 'non.dui@tinciduntcongueturpis.org', 'Calle 4', 5638, 21, 1, 3, NULL, NULL, NULL, NULL),
(27, 6865147, 'Mariela', 'Jasmine', 'Nicholson', 'Stephens', 'M', '1980-04-02', 'mi@erosProinultrices.edu', 'Arocena', 5050, 6, 1, 3, NULL, NULL, NULL, NULL),
(28, 6215711, 'Neville', 'Sean', 'Rice', 'Mills', 'H', '1985-05-11', 'velit.Quisque@nibh.edu', 'Av. Sayago', 4469, 16, 1, 3, NULL, NULL, NULL, NULL),
(29, 3972336, 'Wilson', NULL, 'Da Silva', 'Ferreira', 'H', '2001-03-06', 'nisl@aliquam.net', 'Av.Millán', 8976, 28, 1, 3, NULL, NULL, NULL, NULL),
(30, 1638544, 'Santiago', 'Nahuel', 'Hernandez', 'Rios', 'H', '1982-07-23', 'enim.non@tortor.com', 'Av.Italia', 9356, 1, 1, 3, NULL, NULL, NULL, NULL),
(31, 1840486, 'Facundo', 'Ezequiel', 'Ibañez', 'Martinez', 'H', '1967-06-30', 'fringilla@aauctornon.co.uk', 'Aconcagua', 3021, 4, 1, 3, NULL, NULL, NULL, NULL),
(32, 2411523, 'Marcelo', 'Usbo', 'Nelson', 'Alegre', 'H', '1992-10-19', 'ac.risus@a.ca', 'Av José Batlle y Ordóñez', 9699, 7, 1, 3, NULL, NULL, NULL, NULL),
(33, 4142032, 'Anika', NULL, 'Fitzpatrick', 'Gray', 'M', '1961-02-17', 'nisl@dictum.edu', 'Echeverria', 4638, 9, 1, 3, NULL, NULL, NULL, NULL),
(34, 5305183, 'Hermione', 'Deirdre', 'Cochran', 'Bright', 'M', '1988-03-02', 'posuere.vulputate.lacus@feugiatSednec.co.uk', 'Antonio María Márquez', 8737, 6, NULL, 2, 'Nefrología', 'herma53', 'ion44e', NULL),
(35, 5388472, 'Sierra', NULL, 'Petersen', 'Sims', 'M', '1993-04-26', 'non.bibendum@estarcuac.edu', 'Sargento Patricio', 3232, 10, NULL, 2, 'Reumatología', 'sen555', 'sie472', NULL),
(36, 3720102, 'Rodrigo', 'Jonah', 'Hull', 'Little', 'H', '1966-08-13', 'vel@mitemporlorem.org', 'Av. Eugenio Garzón', 8205, 11, NULL, 2, 'Pediatría', 'rodr09', 'jon454', NULL),
(37, 5544021, 'Harrison', NULL, 'Mayo', 'Wyatt', 'H', '1961-03-30', 'nunc.nulla.vulputate@semperauctor.co.uk', 'Cno Gral Maximo Santos', 6156, 22, NULL, 2, 'Neurología', 'harr56', 'mayd66', NULL),
(38, 2018614, 'Keaton', 'Lydia', 'Howell', 'Conley', 'M', '1976-01-13', 'elit.elit.fermentum@Loremipsum.edu', 'Av. 18 de Julio', 8020, 23, NULL, 2, 'Gastroenterología', 'keat12', 'ho4k55', NULL),
(39, 4086563, 'Gwendolyn', 'Lawrence', 'Horne', 'Puckett', 'H', '1964-07-28', 'varius.et.euismod@sodales.org', 'Calle 2', 4516, 6, NULL, 2, 'Alergología', 'lynlaw', 'lyn6h63', NULL),
(40, 4721360, 'Isaac', 'Joshua', 'Calhoun', 'Mercado', 'H', '1962-09-17', 'vulputate@etultrices.co.uk', 'Confederada', 2259, 31, NULL, 2, 'Angiología', 'isacc4', 'is5a4c', NULL),
(41, 3594744, 'Germaine', 'Emma', 'Pate', 'Rollins', 'M', '1972-06-22', 'vel@Donec.com', 'Carafí', 7584, 1, NULL, 2, 'Hepatología', 'emma44', 'em4am4', NULL),
(42, 4160504, 'Braian', NULL, 'Mccray', 'Odonnell', 'H', '1978-09-25', 'eleifend.egestas@ametrisus.net', 'Turpis Avenue', 2318, 1, NULL, 1, NULL, 'bra78', '0h56i6', 2534),
(43, 5195681, 'Nicole', 'Silvia', 'Buchanan', 'Ferreira', 'M', '1987-07-16', 'vel.est@amalesuada.org', 'Mollis', 1834, 25, NULL, 1, NULL, 'nic78', 's7m4qf', 5234),
(44, 2542345, 'Melanie', 'Yennifer', 'Warren', 'Hart', 'M', '1964-12-06', 'Cras@ultricesmaurisipsum.edu', 'Velodromo', 9443, 20, NULL, 1, NULL, 'mel64', '84ulkc', 6324),
(45, 4527576, 'Amanda', 'Yoko', 'Morales', 'Pacheco', 'M', '1992-04-14', 'Curabitur@necmollis.org', 'Av. Molestie', 7292, 1, NULL, 1, NULL, 'ama92', 'clfv8w', 1523),
(46, 3970678, 'Karen', NULL, 'Blevins', 'Colon', 'M', '1976-12-22', 'cursus.diam@elitNulla.org', 'Gravida', 8878, 30, NULL, 1, NULL, 'kar76', 'g3b57t', 4234),
(47, 3271525, 'Ignacio', NULL, 'Sosa', 'Rose', 'H', '1990-02-16', 'dapibus.rutrum@dictum.org', 'Purus', 6339, 29, NULL, 1, NULL, 'ign90', 'b619jo', 2315),
(48, 4568360, 'Maximiliano', 'Xerxes', 'Louise', 'Velazquez', 'H', '1984-12-30', 'per.inceptos.hymenaeos@acturpisegestas.com', 'Av. giannatasio', 3960, 1, NULL, 1, NULL, 'max84', 'p9u4rn', 5214),
(49, 2150312, 'Cesar', 'Carter', 'Villarreal', 'Oconnor', 'H', '1993-08-17', 'faucibus@eleifendegestasSed.net', 'Jose belloni', 2057, 22, NULL, 1, NULL, 'ces93', 'xir00p', 9089),
(50, 3563054, 'Enzo', 'Vincente', 'Antoñoni', 'Mcmillan', 'H', '1968-01-05', 'euismod@nectempusmauris.net', 'Av. Egestas', 7865, 3, NULL, 1, NULL, 'enz68', 'ah9fx5', 8669);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `peticion`
--

CREATE TABLE `peticion` (
  `id_paciente` int(10) NOT NULL,
  `id_medico` int(10) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  `motivo` varchar(128) DEFAULT NULL,
  `fechaHoraInicio` datetime NOT NULL,
  `fechaHoraFin` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prioridad`
--

CREATE TABLE `prioridad` (
  `id` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `prioridad`
--

INSERT INTO `prioridad` (`id`, `nombre`) VALUES
(1, 'Alta'),
(2, 'Media'),
(3, 'Baja');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `region`
--

CREATE TABLE `region` (
  `id` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `region`
--

INSERT INTO `region` (`id`, `nombre`) VALUES
(1, 'Cabeza'),
(2, 'Ojos'),
(3, 'Orejas'),
(4, 'Nariz'),
(5, 'Cavidad oral'),
(6, 'Cuello o garganta'),
(7, 'Pecho'),
(8, 'Brazo'),
(9, 'Parte superior del abdomen'),
(10, 'Abdomen medio'),
(11, 'Antebrazo'),
(12, 'Mano'),
(13, 'Parte baja del abdomen'),
(14, 'Genitales'),
(15, 'Muslo'),
(16, 'Rodilla'),
(17, 'Parte inferior de la pierna'),
(18, 'Pie'),
(19, 'Espalda');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salachat`
--

CREATE TABLE `salachat` (
  `id` int(10) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  `motivo` varchar(128) DEFAULT NULL,
  `fechaHoraInicio` datetime NOT NULL,
  `fechaHoraFin` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sintoma`
--

CREATE TABLE `sintoma` (
  `id` int(10) NOT NULL,
  `id_region` int(10) DEFAULT NULL,
  `descripcion` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sintoma_compone`
--

CREATE TABLE `sintoma_compone` (
  `id_sintoma` int(10) NOT NULL,
  `id_patologia` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_diagnostico`
--

CREATE TABLE `tipo_diagnostico` (
  `id` int(10) NOT NULL,
  `nombre` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_diagnostico`
--

INSERT INTO `tipo_diagnostico` (`id`, `nombre`) VALUES
(2, 'Definitivo'),
(1, 'Tentativo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_persona`
--

CREATE TABLE `tipo_persona` (
  `id` int(10) NOT NULL,
  `nombre` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_persona`
--

INSERT INTO `tipo_persona` (`id`, `nombre`) VALUES
(1, 'Administrador'),
(2, 'Medico'),
(3, 'Paciente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tratamiento`
--

CREATE TABLE `tratamiento` (
  `id` int(10) NOT NULL,
  `id_patologia` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `tipo` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tratamiento`
--

INSERT INTO `tratamiento` (`id`, `id_patologia`, `nombre`, `descripcion`, `tipo`) VALUES
(1, 1, 'Clortalidona', 'La clortalidona es un medicamento diurético utilizado para tratar la hipertensión', 'Medicamento'),
(2, 1, 'Eritropoyetina', ' Proteína segregada, principalmente, por el riñón en el adulto y por el hígado en el feto, que estimula la producción de glóbulo', 'Medicamento'),
(3, 2, 'Insulina', 'Es una hormona polipeptídica formada por 51 aminoácidos,​ producida y secretada por las células beta de los islotes de Langerhan', 'Medicamento'),
(4, 2, 'Aspirina', 'Se utiliza como medicamento para tratar el dolor, la fiebre y la inflamación', 'Medicamento'),
(5, 3, 'Cirugía de cataratas', 'En la cirugía de cataratas se extrae el lente nublado y se reemplaza con un lente artificial transparente', 'Quirurjico'),
(6, 3, 'Gotas oculares', 'Las gotas oculares podrían ayudar a controlar los síntomas de cataratas y le ayudan a ver más claramente hasta que se requiera d', 'Medicamento'),
(7, 4, 'Penicilina', 'Son antibióticos del grupo de los betalactámicos empleados profusamente en el tratamiento de infecciones provocadas por bacteria', 'Medicamento'),
(8, 4, 'Levofloxacino', 'El levofloxacino es un antibiótico del grupo de las quinolonas, más concretamente una fluorquinolona', 'Medicamento'),
(9, 5, 'Fotocoagulación', 'Este tratamiento con láser, también conocido como tratamiento focal con láser, puede detener o disminuir la filtración de sangre', 'Quirurjico'),
(10, 5, 'Vitrectomía', 'En este procedimiento se hace una pequeña incisión en el ojo para extraer la sangre del centro del ojo', 'Quirurjico'),
(11, 6, 'Metformina', 'La metformina, o el preparado comercial clorhidrato de metformina, es un fármaco antidiabético de aplicación oral', 'Medicamento'),
(12, 6, 'Tiazolidinedionas', ' Las tiazolidinedionas mejoran la sensibilidad de los tejidos blancos a la insulina por actuar como agonistas selectivos', 'Medicamento'),
(13, 7, 'Beclometasona', 'La beclomometasona se utiliza para evitar la dificultad para respirar, opresión en el pecho, sibilancia y tos por asma', 'Medicamento'),
(14, 7, 'Teofilina', 'La teofilina se usa para prevenir y tratar las sibilancias, la falta de aliento y la opresión en el pecho', 'Medicamento'),
(15, 8, 'Penicilamina', 'La penicilamina, producto de degradación de la penicilina', 'Medicamento'),
(16, 8, 'Doxiciclina', 'La doxiciclina es un antibiótico del grupo de las tetraciclinas que previene el crecimiento y propagación de las bacterias', 'Medicamento'),
(17, 9, 'Terapia biológica', 'La terapia biológica funciona mediante tratamientos que ayudan a tu sistema inmunitario a reconocer y atacar la leucemia', 'Quirurjico'),
(18, 9, 'Radioterapia', 'La radioterapia usa rayos X u otros haces de alta energía para dañar las células de leucemia y detener su crecimiento', 'Quirurjico'),
(19, 10, 'Tramadol', 'El tramadol es un analgésico de tipo opioide que alivia el dolor actuando sobre células nerviosas', 'Medicamento'),
(20, 10, 'Ibuprofeno', 'El ibuprofeno es un antiinflamatorio no esteroideo', 'Medicamento'),
(21, 11, 'Levodopa', 'Se utiliza principalmente para controlar los síntomas de la enfermedad de Parkinson', 'Medicamento'),
(22, 11, 'Duopas', 'Es una medicina combinada que se usa para tratar los problemas de movimiento en personas con enfermedad de Parkinson avanzado', 'Medicamento'),
(23, 12, 'Terapia de radiación', 'La terapia de radiación utiliza haces de energía de alta potencia, como rayos X y protones', 'Quirurjico'),
(24, 12, 'Trasplante de médula ósea', ' Un trasplante de médula ósea, también conocido como trasplante de células madre, implica el uso de altas dosis de quimioterapia', 'Quirurjico'),
(25, 13, 'Vancomicina', 'La vancomicina es un glucopéptido de estructura compleja que se sintetiza de modo natural por Nocardia orientalis', 'Medicamento'),
(26, 13, 'Transfusion de plasma', 'Las transfusiones de plasma son un tratamiento utilizado con frecuencia para los pacientes graves', 'Quirurjico'),
(27, 14, 'Diatermia', 'Tratamiento que emplea corrientes eléctricas de alta frecuencia para elevar la temperatura de las partes más profundas', 'Quirurjico'),
(28, 14, 'Masoterapia', 'El proceso consigue reducir las adherencias que tenga la cicatriz de la rotura y disminuye ostensiblemente la inflamación', 'Quirurjico'),
(29, 15, 'Acetaminofén', 'Es un medicamento común para aliviar el dolor ligero o moderado de dolores de cabeza', 'Medicamento'),
(30, 15, 'Propranolol', 'Propranolol es el nombre de un fármaco beta bloqueante usado principalmente en el tratamiento de la hipertensión', 'Medicamento'),
(31, 16, 'Ampicilina', 'La ampicilina es un antibiótico betalactámico que ha sido extensamente utilizado para tratar infecciones bacterianas', 'Medicamento'),
(32, 16, 'Amoxicilina', 'La amoxicilina es un antibiótico semisintético derivado de la penicilina', 'Medicamento'),
(33, 17, 'Tylenol', 'e usa para bajar temporalmente la fiebre y para aliviar los dolores menores, como dolores de cabeza, musculares y más', 'Medicamento'),
(34, 17, 'Motrin', 'Es un medicamento antiinflamatorio no esteroide y contiene ibuprofeno', 'Medicamento'),
(35, 18, 'Oseltamivir', 'Oseltamivir es un profármaco antiviral', 'Medicamento'),
(36, 18, 'Zanamivir', 'El zanamivir es un inhibidor de la neuraminidasa', 'Medicamento'),
(37, 19, 'Entecavir', 'Funciona al disminuir la cantidad del virus de la hepatitis B en el cuerpo.', 'Medicamento'),
(38, 19, 'Interferón', 'se administra como una inyección bajo la piel (vía subcutánea), generalmente en el muslo o en el abdomen', 'Medicamento'),
(39, 20, 'Trasplante de hígado', 'Durante un trasplante hepático, el cirujano extrae el hígado dañado y lo reemplaza por uno sano', 'Quirurjico'),
(40, 20, 'Ribavirina', 'La ribavirina también conocida como virazole es un nucleósido sintético en el que la base nitrogenada es la triazolcarboxamida', 'Medicamento'),
(41, 21, 'Lubricante ocular', 'solución oftálmica indicado para el alivio temporal del ardor y la irritación que se manifiesta como consecuencia de la sequedad', 'Medicamento'),
(42, 21, 'Tamiflu', 'Tamiflu contiene oseltamivir, el cual pertenece a un grupo de medicamentos denominados inhibidores de la neuraminidasa', 'Medicamento'),
(43, 22, 'Acetilsalicílico', 'Se utiliza como medicamento para tratar el dolor, la fiebre y la inflamación', 'Medicamento'),
(44, 22, 'Bromhexina', 'La bromhexina es un fármaco que actúa disminuyendo la viscosidad de la mucosidad bronquial facilitando la expectoración', 'Medicamento'),
(45, 23, 'Naproxeno', 'El naproxeno es un medicamento antinflamatorio no esteroideo que se emplea en el tratamiento del dolor leve a moderado', 'Medicamento'),
(46, 23, 'Cirugía de páncreas', 'Es una cirugía para drenar el líquido del páncreas o para eliminar el tejido enfermo', 'Quirurjico'),
(47, 24, 'Diálisis', 'Es un tipo de terapia renal conjuntiva usada para proporcionar un reemplazo artificial', 'Quirurjico'),
(48, 24, 'Trasplante de riñón', 'El trasplante de riñón o trasplante renal es el trasplante de un riñón en un paciente con enfermedad renal avanzada', 'Quirurjico'),
(49, 25, 'Fluticasona', 'Fluticasona es un potente corticosteroide sintético prescrito en el tratamiento del asma y de la rinitis alérgica', 'Medicamento'),
(50, 25, 'Budesónida', 'La budesónida es un medicamento glucocorticoide, de la familia de los corticosteroides', 'Medicamento'),
(51, 26, 'Drenaje de la siringe', 'El médico insertará quirúrgicamente un sistema de drenaje, llamado derivación', 'Quirurjico'),
(52, 26, 'Extracción de la obstrucción', 'i algo en la médula espinal, como un tumor o un bulto óseo, entorpece el flujo de líquido cefalorraquídeo', 'Quirurjico'),
(53, 27, 'Intubación', 'comprende la colocación de un tubo de respiración a través de la nariz o la boca hasta la garganta para ayuda a las vias respira', 'Quirurjico'),
(54, 27, 'ECMO', 'La Oxigenación por membrana extracorpórea, también conocida como ECMO proporciona soporte cardíaco y respiratorio', 'Quirurjico'),
(55, 28, 'Azitromicina', 'Azitromicina es un antibiótico de amplio espectro del grupo de macrólidos que actúa contra varias bacterias', 'Medicamento'),
(56, 28, 'cirugía de rotación de los párpa', 'El médico hace una incisión en la tapa cicatrizada y rota las pestañas alejándolas de la córnea.', 'Quirurjico'),
(57, 29, 'Isoniacida', 'La isoniacida o isoniazida es un fármaco antituberculoso activo frente a Mycobacterium tuberculosis', 'Medicamento'),
(58, 29, 'Pirazinamida', 'DescripciónLa pirazinamida es un antibiótico usado en tratamiento de la tuberculosis', 'Medicamento'),
(59, 30, 'cirugia de ganglion', 'Durante este procedimiento, el médico extirpa el quiste y el tallo que lo une a la articulación o al tendón', 'Quirurjico'),
(60, 30, 'Aspiración', 'En este procedimiento, el médico usa una aguja para drenar el líquido del quiste', 'Quirurjico'),
(61, 31, 'cirugía de gangrena', 'El médico podría realizar un procedimiento quirúrgico para extraer el tejido muerto, lo que ayuda a evitar que se extienda', 'Quirurjico'),
(62, 31, 'Oxigenoterapia', 'Al aumentar la presión y el contenido de oxígeno, la sangre puede transportar mayor cantidad de oxígeno', 'Quirurjico'),
(63, 32, 'Claritromicina', 'La claritromicina es el nombre de un antibiótico del grupo de los macrólidos que se indica para el tratamiento de infecciones', 'Medicamento'),
(64, 32, 'Lansoprazol', 'El lansoprazol es un medicamento del grupo de inhibidores de la bomba de protones que actúa a nivel del tracto gastrointestinal', 'Medicamento'),
(65, 33, 'Latanoprost', 'El latanoprost es un medicamento que se utiliza en oftalmología y se aplica en forma de gotas que se instilan directamente', 'Medicamento'),
(66, 33, 'Timolol', 'Timolol es el nombre de un medicamento beta bloqueante no selectivo, es decir, bloquea la acción de la epinefrina', 'Medicamento'),
(67, 34, 'Metilprednisolona', 'Metilprednisolona, esteroide sintético, del grupo de los glucocorticoides que se utiliza en medicina por sus propiedades inmunos', 'Medicamento'),
(68, 34, 'Micofenolato', 'Es un medicamento inmunosupresor derivado del Penicillium stoloniferum, y especies relacionadas, bloquea la síntesis', 'Medicamento'),
(69, 35, 'Efavirenz', 'Efavirenz es un fármaco inhibidor de la transcriptasa inversa no análogo a los nucleósidos que se emplea', 'Medicamento'),
(70, 35, 'Tenofovir', 'Tenofovir es un medicamento antiviral que se emplea para el tratamiento de la infección por el virus de la inmunodeficiencia', 'Medicamento'),
(71, 36, 'Inmunoglobulina antirrábica', 'Una inyección de acción rápida para prevenir que el virus te infecte', 'Medicamento'),
(72, 36, 'Vacunas antirrábicas', 'Una serie de vacunas para ayudar a que el cuerpo aprenda a identificar y combatir el virus de la rabia', 'Medicamento'),
(73, 37, 'Broncoscopia', 'Durante la broncoscopia, el médico introduce con cuidado un tubo flexible por la garganta para limpiar las vías respiratorias', 'Quirurjico'),
(74, 37, 'CPAP', 'La presión positiva continua en las vías respiratorias (CPAP) puede ser útil en algunas personas que están demasiado débiles', 'Quirurjico'),
(75, 38, 'Colonoscopia', 'El médico puede ver el interior del colon mediante un tubo delgado con luz que se introduce en el recto', 'Quirurjico'),
(76, 38, 'Tetraciclina', 'Las tetraciclinas constituyen un grupo de antibióticos, unos naturales y otros obtenidos por semisíntesis, que abarcan un amplio', 'Medicamento'),
(77, 39, 'Maalox', 'Está indicado para el alivio y tratamiento sintomático de la acidez y ardor de estómago', 'Medicamento'),
(78, 39, 'Dilatación esofágica', 'El médico puede usar un endoscopio con un globo especial conectado para estirar y expandir suavemente el ancho del esófago', 'Quirurjico'),
(79, 40, 'Prednisona', 'Prednisona es un fármaco corticosteroide sintético que se toma usualmente en forma oral, pero puede ser administrado por vía', 'Medicamento'),
(80, 40, 'PRP', 'Plasma rico en plaquetas, aplica tomar una muestra de tu sangre y centrifugarla para separar las plaquetas y componentes', 'Quirurjico');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `verifica`
--

CREATE TABLE `verifica` (
  `id_tentativo` int(10) NOT NULL,
  `id_medico` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cel_empleado`
--

CREATE TABLE `cel_empleado` (
  `id_empleado` int(10) NOT NULL,
  `celular` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cel_empleado`
--

INSERT INTO `cel_empleado` (`id_empleado`, `celular`) VALUES
(1, '091854011'),
(3, '096757353'),
(10, '099049806'),
(11, '091836345'),
(12, '093919411'),
(13, '094515482'),
(14, '094689121'),
(15, '095711918'),
(16, '095895808'),
(17, '098117054'),
(18, '090077196'),
(19, '092845031'),
(20, '099794617'),
(34, '097037692'),
(35, '096005276'),
(36, '096033068'),
(37, '099804488'),
(38, '093909146'),
(39, '099942955'),
(40, '092942925'),
(41, '093922155'),
(42, '098941299'),
(43, '097102177'),
(44, '096191369'),
(45, '098860700'),
(46, '091499778'),
(47, '095503375'),
(48, '093115023'),
(49, '095215053'),
(50, '099028544');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cel_paciente`
--

CREATE TABLE `cel_paciente` (
  `id_paciente` int(10) NOT NULL,
  `celular` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cel_paciente`
--

INSERT INTO `cel_paciente` (`id_paciente`, `celular`) VALUES
(2, '091960412'),
(4, '095571963'),
(5, '096986920'),
(6, '090196189'),
(7, '092416455'),
(8, '093498253'),
(9, '091507102'),
(21, '093275548'),
(22, '095075884'),
(23, '095124353'),
(24, '095124353'),
(25, '090868660'),
(26, '095776573'),
(27, '097425494'),
(28, '091044589'),
(29, '096045529'),
(30, '099087994'),
(31, '099203227'),
(32, '090921797'),
(33, '099698605');

-- --------------------------------------------------------


--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cel_empleado`
--
ALTER TABLE `cel_empleado`
  ADD PRIMARY KEY (`id_empleado`,`celular`);

--
-- Indices de la tabla `cel_paciente`
--
ALTER TABLE `cel_paciente`
  ADD PRIMARY KEY (`id_paciente`,`celular`);

--
-- Indices de la tabla `ciudad`
--
ALTER TABLE `ciudad`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_dpto` (`id_dpto`);

--
-- Indices de la tabla `conversa`
--
ALTER TABLE `conversa`
  ADD PRIMARY KEY (`id_paciente`,`id_medico`,`id_mensaje`),
  ADD KEY `id_medico` (`id_medico`),
  ADD KEY `id_mensaje` (`id_mensaje`),
  ADD KEY `id_sala` (`id_sala`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `diagnostico`
--
ALTER TABLE `diagnostico`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_tipo` (`id_tipo`),
  ADD KEY `id_paciente` (`id_paciente`),
  ADD KEY `id_sintoma` (`id_sintoma`);

--
-- Indices de la tabla `mensaje`
--
ALTER TABLE `mensaje`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `paciente_sufre`
--
ALTER TABLE `paciente_sufre`
  ADD PRIMARY KEY (`id_sintoma`,`id_paciente`),
  ADD KEY `id_paciente` (`id_paciente`);

--
-- Indices de la tabla `patologia`
--
ALTER TABLE `patologia`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`),
  ADD KEY `id_prioridad` (`id_prioridad`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `ci` (`ci`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `usuario` (`usuario`),
  ADD UNIQUE KEY `contrasena` (`contrasena`),
  ADD KEY `id_tipo` (`id_tipo`),
  ADD KEY `id_ciudad` (`id_ciudad`);

--
-- Indices de la tabla `peticion`
--
ALTER TABLE `peticion`
  ADD PRIMARY KEY (`id_paciente`,`id_medico`),
  ADD KEY `id_medico` (`id_medico`);

--
-- Indices de la tabla `prioridad`
--
ALTER TABLE `prioridad`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `region`
--
ALTER TABLE `region`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `salachat`
--
ALTER TABLE `salachat`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sintoma`
--
ALTER TABLE `sintoma`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_region` (`id_region`);

--
-- Indices de la tabla `sintoma_compone`
--
ALTER TABLE `sintoma_compone`
  ADD PRIMARY KEY (`id_sintoma`,`id_patologia`),
  ADD KEY `id_patologia` (`id_patologia`);

--
-- Indices de la tabla `tipo_diagnostico`
--
ALTER TABLE `tipo_diagnostico`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `tipo_persona`
--
ALTER TABLE `tipo_persona`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `tratamiento`
--
ALTER TABLE `tratamiento`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`),
  ADD KEY `id_patologia` (`id_patologia`);

--
-- Indices de la tabla `verifica`
--
ALTER TABLE `verifica`
  ADD PRIMARY KEY (`id_tentativo`),
  ADD KEY `id_medico` (`id_medico`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `ciudad`
--
ALTER TABLE `ciudad`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `diagnostico`
--
ALTER TABLE `diagnostico`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `mensaje`
--
ALTER TABLE `mensaje`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `patologia`
--
ALTER TABLE `patologia`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT de la tabla `persona`
--
ALTER TABLE `persona`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT de la tabla `prioridad`
--
ALTER TABLE `prioridad`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `region`
--
ALTER TABLE `region`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `salachat`
--
ALTER TABLE `salachat`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `sintoma`
--
ALTER TABLE `sintoma`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipo_diagnostico`
--
ALTER TABLE `tipo_diagnostico`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tipo_persona`
--
ALTER TABLE `tipo_persona`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tratamiento`
--
ALTER TABLE `tratamiento`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cel_empleado`
--
ALTER TABLE `cel_empleado`
  ADD CONSTRAINT `cel_empleado_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `persona` (`id`);

--
-- Filtros para la tabla `cel_paciente`
--
ALTER TABLE `cel_paciente`
  ADD CONSTRAINT `cel_paciente_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`);

--
-- Filtros para la tabla `ciudad`
--
ALTER TABLE `ciudad`
  ADD CONSTRAINT `ciudad_ibfk_1` FOREIGN KEY (`id_dpto`) REFERENCES `departamento` (`id`);

--
-- Filtros para la tabla `conversa`
--
ALTER TABLE `conversa`
  ADD CONSTRAINT `conversa_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`),
  ADD CONSTRAINT `conversa_ibfk_2` FOREIGN KEY (`id_medico`) REFERENCES `persona` (`id`),
  ADD CONSTRAINT `conversa_ibfk_3` FOREIGN KEY (`id_mensaje`) REFERENCES `mensaje` (`id`),
  ADD CONSTRAINT `conversa_ibfk_4` FOREIGN KEY (`id_sala`) REFERENCES `salachat` (`id`);

--
-- Filtros para la tabla `diagnostico`
--
ALTER TABLE `diagnostico`
  ADD CONSTRAINT `diagnostico_ibfk_1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_diagnostico` (`id`),
  ADD CONSTRAINT `diagnostico_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`),
  ADD CONSTRAINT `diagnostico_ibfk_3` FOREIGN KEY (`id_sintoma`) REFERENCES `sintoma` (`id`);

--
-- Filtros para la tabla `paciente_sufre`
--
ALTER TABLE `paciente_sufre`
  ADD CONSTRAINT `paciente_sufre_ibfk_1` FOREIGN KEY (`id_sintoma`) REFERENCES `sintoma` (`id`),
  ADD CONSTRAINT `paciente_sufre_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`);

--
-- Filtros para la tabla `patologia`
--
ALTER TABLE `patologia`
  ADD CONSTRAINT `patologia_ibfk_1` FOREIGN KEY (`id_prioridad`) REFERENCES `prioridad` (`id`);

--
-- Filtros para la tabla `persona`
--
ALTER TABLE `persona`
  ADD CONSTRAINT `persona_ibfk_1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_persona` (`id`),
  ADD CONSTRAINT `persona_ibfk_2` FOREIGN KEY (`id_ciudad`) REFERENCES `ciudad` (`id`);

--
-- Filtros para la tabla `peticion`
--
ALTER TABLE `peticion`
  ADD CONSTRAINT `peticion_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`),
  ADD CONSTRAINT `peticion_ibfk_2` FOREIGN KEY (`id_medico`) REFERENCES `persona` (`id`);

--
-- Filtros para la tabla `sintoma`
--
ALTER TABLE `sintoma`
  ADD CONSTRAINT `sintoma_ibfk_1` FOREIGN KEY (`id_region`) REFERENCES `region` (`id`);

--
-- Filtros para la tabla `sintoma_compone`
--
ALTER TABLE `sintoma_compone`
  ADD CONSTRAINT `sintoma_compone_ibfk_1` FOREIGN KEY (`id_sintoma`) REFERENCES `sintoma` (`id`),
  ADD CONSTRAINT `sintoma_compone_ibfk_2` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`);

--
-- Filtros para la tabla `tratamiento`
--
ALTER TABLE `tratamiento`
  ADD CONSTRAINT `tratamiento_ibfk_1` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`);

--
-- Filtros para la tabla `verifica`
--
ALTER TABLE `verifica`
  ADD CONSTRAINT `verifica_ibfk_1` FOREIGN KEY (`id_tentativo`) REFERENCES `diagnostico` (`id`),
  ADD CONSTRAINT `verifica_ibfk_2` FOREIGN KEY (`id_medico`) REFERENCES `persona` (`id`);