-- MySQL dump 10.14  Distrib 5.5.65-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: TelediagnosticoMedico_HeartBits
-- ------------------------------------------------------
-- Server version	5.5.65-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `TelediagnosticoMedico_HeartBits`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `TelediagnosticoMedico_HeartBits` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `TelediagnosticoMedico_HeartBits`;

--
-- Table structure for table `acepta`
--

DROP TABLE IF EXISTS `acepta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acepta` (
  `id_medico` int(10) NOT NULL,
  `id_peticion` int(10) NOT NULL,
  PRIMARY KEY (`id_peticion`),
  KEY `id_peticion` (`id_peticion`),
  KEY `acepta_ibfk_1` (`id_medico`),
  CONSTRAINT `acepta_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `persona` (`id`),
  CONSTRAINT `acepta_ibfk_2` FOREIGN KEY (`id_peticion`) REFERENCES `peticion` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acepta`
--

LOCK TABLES `acepta` WRITE;
/*!40000 ALTER TABLE `acepta` DISABLE KEYS */;
INSERT INTO `acepta` VALUES (1,4),(10,1),(11,2),(12,5),(13,3),(15,35),(16,11),(17,6),(19,10),(20,7),(34,8),(34,9),(38,12),(40,14),(41,13),(52,16);
/*!40000 ALTER TABLE `acepta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cel_empleado`
--

DROP TABLE IF EXISTS `cel_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cel_empleado` (
  `id_empleado` int(10) NOT NULL DEFAULT '0',
  `celular` varchar(16) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_empleado`,`celular`),
  CONSTRAINT `cel_empleado_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `persona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cel_empleado`
--

LOCK TABLES `cel_empleado` WRITE;
/*!40000 ALTER TABLE `cel_empleado` DISABLE KEYS */;
INSERT INTO `cel_empleado` VALUES (1,'091854011'),(3,'096757353'),(10,'099049806'),(11,'091836345'),(12,'093919411'),(13,'094515482'),(14,'094689121'),(15,'095711918'),(16,'095895808'),(17,'098117054'),(18,'090077196'),(19,'092845031'),(20,'099794617'),(34,'097037692'),(35,'096005276'),(36,'096033068'),(37,'099804488'),(38,'093909146'),(39,'099942955'),(40,'092942925'),(41,'093922155'),(42,'098941299'),(43,'097102177'),(44,'096191369'),(45,'098860700'),(46,'091499778'),(47,'095503375'),(48,'093115023'),(49,'095215053'),(50,'099028544');
/*!40000 ALTER TABLE `cel_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cel_paciente`
--

DROP TABLE IF EXISTS `cel_paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cel_paciente` (
  `id_paciente` int(10) NOT NULL DEFAULT '0',
  `celular` varchar(16) NOT NULL DEFAULT '',
  PRIMARY KEY (`id_paciente`,`celular`),
  CONSTRAINT `cel_paciente_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cel_paciente`
--

LOCK TABLES `cel_paciente` WRITE;
/*!40000 ALTER TABLE `cel_paciente` DISABLE KEYS */;
INSERT INTO `cel_paciente` VALUES (2,'091960412'),(4,'095571963'),(5,'096986920'),(6,'090196189'),(7,'092416455'),(8,'093498253'),(9,'091507102'),(21,'093275548'),(22,'095075884'),(23,'095124353'),(24,'095124353'),(25,'090868660'),(26,'095776573'),(27,'097425494'),(28,'091044589'),(29,'096045529'),(30,'099087994'),(31,'099203227'),(32,'090921797'),(33,'099698605');
/*!40000 ALTER TABLE `cel_paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ciudad` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  `id_dpto` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_dpto` (`id_dpto`),
  CONSTRAINT `ciudad_ibfk_1` FOREIGN KEY (`id_dpto`) REFERENCES `departamento` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'Montevideo',19),(2,'Rivera',6),(3,'Punta del Este',2),(4,'Salto',8),(5,'Paysandú',9),(6,'Melo',5),(7,'Maldonado',2),(8,'Tacuarembó',18),(9,'Mercedes',11),(10,'Artigas',7),(11,'Minas',16),(12,'San José',13),(13,'Durazno',17),(14,'Florida',15),(15,'Treinta y Tres',4),(16,'Rocha',3),(17,'Fray Bentos',10),(18,'Bella Unión',7),(19,'Colonia del Sacramento',12),(20,'Trinidad',14),(21,'Canelones',1),(22,'Carmelo',12),(23,'Santa Lucía',1),(24,'Paso de los Toros',17),(25,'Castillos',3),(26,'Tranqueras',6),(27,'Lascano',3),(28,'Vergara',4),(29,'La Paloma',3),(30,'Aiguá',2),(31,'Baltasar Brum',7),(32,'José Batlle y Ordóñez',16);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conversa`
--

DROP TABLE IF EXISTS `conversa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conversa` (
  `id_persona` int(10) NOT NULL DEFAULT '0',
  `id_sala` int(10) NOT NULL,
  `mensaje` text NOT NULL,
  `hora` time NOT NULL,
  KEY `conversa_ibfk_1` (`id_persona`),
  KEY `conversa_ibfk_2` (`id_sala`),
  CONSTRAINT `conversa_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id`),
  CONSTRAINT `conversa_ibfk_2` FOREIGN KEY (`id_sala`) REFERENCES `salaChat` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conversa`
--

LOCK TABLES `conversa` WRITE;
/*!40000 ALTER TABLE `conversa` DISABLE KEYS */;
INSERT INTO `conversa` VALUES (10,1,'Buenas en que la puedo ayudar','20:08:00'),(2,1,'Hola que tal, se me diagnosticó Asma bronquial y quisiera saber si ese diagnóstico es correcto','20:09:00'),(10,1,'Entendido, verificaré el diagnostico y le diré mi opinión','20:09:30'),(10,1,'He verificado el diagnóstico tentativo y es correcto, usted padece Asma bronquial','20:11:00'),(10,1,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','20:12:00'),(10,1,'Algo más que desee consultar?','20:12:10'),(2,1,'No, todo claro','20:13:00'),(10,1,'Muy bien, que tenga un buen dia','20:14:00'),(2,1,'Hasta luego','20:14:25'),(11,2,'Buenas en que lo puedo ayudar','09:04:00'),(4,2,'Hola que tal, se me diagnosticó Neumonía y quisiera saber si ese diagnóstico es correcto','09:05:00'),(11,2,'Entendido, verificaré el diagnostico y le diré mi opinión','09:05:50'),(11,2,'He verificado el diagnóstico tentativo y es equívoco, usted padece Asma bronquial','09:08:00'),(11,2,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','09:09:00'),(11,2,'Algo más que desee consultar?','09:10:00'),(4,2,'No, gracias','09:11:00'),(11,2,'Muy bien, que tenga un buen dia','09:11:25'),(4,2,'Hasta luego','09:12:00'),(13,3,'Buenas en que lo puedo ayudar','11:06:00'),(5,3,'Hola que tal, se me diagnosticó Artritis y quisiera saber si ese diagnóstico es correcto','11:07:00'),(13,3,'Entendido, verificaré el diagnostico y le diré mi opinión','11:07:54'),(13,3,'He verificado el diagnóstico tentativo y es correcto, usted padece Artritis','11:08:00'),(13,3,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','11:08:59'),(13,3,'Algo más que desee consultar?','11:09:00'),(5,3,'No, muchas gracias','11:10:00'),(13,3,'Muy bien, que tenga un buen dia','11:10:26'),(5,3,'Hasta luego','11:11:00'),(1,4,'Buenas en que la puedo ayudar','23:38:00'),(6,4,'Hola que tal, se me diagnosticó Nefropatía crónica y quisiera saber si ese diagnóstico es correcto','23:39:00'),(1,4,'Entendido, verificaré el diagnostico y le diré mi opinión','23:39:50'),(1,4,'He verificado el diagnóstico tentativo y es equívoco, usted padece Tendinitis','23:43:00'),(1,4,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','23:44:00'),(1,4,'Algo más que desee consultar?','23:45:00'),(6,4,'No, todo claro','23:46:00'),(1,4,'Excelente, que tenga un buen dia','23:47:00'),(6,4,'Hasta luego','23:47:40'),(12,5,'Buenas en que lo puedo ayudar','06:59:00'),(7,5,'Hola que tal, se me diagnosticó Bronquitis y quisiera saber si ese diagnóstico es correcto','07:00:00'),(12,5,'Entendido, verificaré el diagnostico y le diré mi opinión','07:01:00'),(12,5,'He verificado el diagnóstico tentativo y es correcto, usted padece Bronquitis','07:04:00'),(12,5,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','07:05:00'),(12,5,'Algo más que desee consultar?','07:05:20'),(7,5,'No, gracias','07:06:00'),(12,5,'Perfecto, que tenga un buen dia','07:07:00'),(12,5,'Hasta luego','07:07:54'),(17,6,'Buenas en que lo puedo ayudar','14:26:00'),(8,6,'Hola que tal, se me diagnosticó Leucemia y quisiera saber si ese diagnóstico es correcto','14:27:00'),(17,6,'Entendido, verificaré el diagnostico y le diré mi opinión','14:27:30'),(17,6,'He verificado el diagnóstico tentativo y es equívoco, usted padece Tuberculosis','14:30:00'),(17,6,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','14:31:00'),(17,6,'Algo más que desee consultar?','14:31:50'),(8,6,'Si, cuan mortal es la tuberculosis?','14:32:00'),(17,6,'Tiene un 30% de riesgo de muerte','14:34:00'),(8,6,'Gracias por contestarme, no tengo más dudas','14:35:00'),(17,6,'Muy bien, que tenga un buen dia','14:36:00'),(8,6,'Hasta luego','14:36:25'),(20,7,'Buenas en que la puedo ayudar','19:03:00'),(9,7,'Hola que tal, se me diagnosticó Bronquitis y quisiera saber si ese diagnóstico es correcto','19:04:00'),(20,7,'Entendido, verificaré el diagnostico y le diré mi opinión','19:05:00'),(20,7,'He verificado el diagnóstico tentativo y es correcto, usted padece Bronquitis','19:07:00'),(20,7,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','19:08:00'),(20,7,'Algo más que desee consultar?','19:08:24'),(9,7,'No, todo claro','19:09:00'),(20,7,'Perfecto, que tenga un buen dia','19:10:00'),(9,7,'Hasta luego','19:10:25'),(34,8,'Buenas en que la puedo ayudar','17:18:00'),(21,8,'Hola que tal, se me diagnosticó Conjuntivitis y quisiera saber si ese diagnóstico es correcto','17:19:00'),(34,8,'Entendido, verificaré el diagnostico y le diré mi opinión','17:20:00'),(34,8,'He verificado el diagnóstico tentativo y es correcto, usted padece Conjuntivitis','17:24:00'),(34,8,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','17:25:00'),(34,8,'Algo más que desee consultar?','17:26:00'),(21,8,'No, muchas gracias','17:27:00'),(34,8,'Muy bien, que tenga un buen dia','17:28:00'),(21,8,'Hasta luego','17:28:30'),(34,9,'Buenas en que lo puedo ayudar','17:18:00'),(22,9,'Hola que tal, se me diagnosticó Diabetes tipo 1 y quisiera saber si ese diagnóstico es correcto','17:19:00'),(34,9,'Entendido, verificaré el diagnostico y le diré mi opinión','17:20:00'),(34,9,'He verificado el diagnóstico tentativo y es equívoco, usted padece Cataratas','17:26:00'),(34,9,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','17:27:00'),(34,9,'Algo más que desee consultar?','17:27:30'),(22,9,'No, todo claro','17:28:00'),(34,9,'Muy bien, que tenga un buen dia','17:29:00'),(22,9,'Hasta luego','17:29:30'),(19,10,'Buenas en que la puedo ayudar','13:13:00'),(23,10,'Hola que tal, se me diagnosticó Tracoma y quisiera saber si ese diagnóstico es correcto','13:14:00'),(19,10,'Entendido, verificaré el diagnostico y le diré mi opinión','13:15:00'),(19,10,'He verificado el diagnóstico tentativo y es correcto, usted padece Cataratas','13:16:00'),(19,10,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','13:17:00'),(19,10,'Algo más que desee consultar?','13:17:32'),(23,10,'No, gracias','13:18:00'),(19,10,'Muy bien, que tenga un buen dia','13:19:00'),(23,10,'Hasta luego','13:19:36'),(16,11,'Buenas en que la puedo ayudar','07:31:00'),(24,11,'Hola que tal, se me diagnosticó Disfagia y quisiera saber si ese diagnóstico es correcto','07:32:00'),(16,11,'Entendido, verificaré el diagnostico y le diré mi opinión','07:33:00'),(16,11,'He verificado el diagnóstico tentativo y es correcto, usted padece Disfagia','07:36:00'),(16,11,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','07:37:00'),(16,11,'Algo más que desee consultar?','07:38:00'),(24,11,'No, muchas gracias','07:38:20'),(16,11,'Excelente, que tenga un buen dia','07:39:00'),(24,11,'Hasta luego','07:39:46'),(38,12,'Buenas en que lo puedo ayudar','16:09:00'),(25,12,'Hola que tal, se me diagnosticó Disfagia y quisiera saber si ese diagnóstico es correcto','16:10:00'),(38,12,'Entendido, verificaré el diagnostico y le diré mi opinión','16:11:00'),(38,12,'He verificado el diagnóstico tentativo y es correcto, usted padece Disfagia','16:16:00'),(38,12,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','16:17:00'),(38,12,'Algo más que desee consultar?','16:18:00'),(25,12,'Si, es mortal?','16:18:40'),(38,12,'Tiene un riesgo medio de muerte si no se siguen los tratamientos','16:19:00'),(25,12,'Está bien, gracias por responder, no tengo más preguntas','16:20:00'),(38,12,'Muy bien, que tenga un buen dia','16:21:00'),(25,12,'Hasta luego','16:21:30'),(41,13,'Buenas en que la puedo ayudar','06:01:00'),(26,13,'Hola que tal, se me diagnosticó Fibrosis pulmonar y quisiera saber si ese diagnóstico es correcto','06:02:00'),(41,13,'Entendido, verificaré el diagnostico y le diré mi opinión','06:03:00'),(41,13,'He verificado el diagnóstico tentativo y es correcto, usted padece Fibrosis pulmonar','06:08:00'),(41,13,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','06:09:00'),(41,13,'Algo más que desee consultar?','06:10:00'),(26,13,'No, todo claro gracias','06:11:00'),(41,13,'Muy bien, que tenga un buen dia','06:12:00'),(26,13,'Hasta luego','06:12:32'),(40,14,'Buenas en que la puedo ayudar','21:13:00'),(27,14,'Hola que tal, se me diagnosticó Diabétes tipo 1 y quisiera saber si ese diagnóstico es correcto','21:14:00'),(40,14,'Entendido, verificaré el diagnostico y le diré mi opinión','21:15:00'),(40,14,'He verificado el diagnóstico tentativo y es correcto, usted padece Diabétes tipo 1','21:18:00'),(40,14,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','21:19:00'),(40,14,'Algo más que desee consultar?','21:20:00'),(27,14,'No, gracias','21:21:00'),(40,14,'Excelente, que tenga un buen dia','21:22:00'),(27,14,'Hasta luego','21:22:30'),(52,15,'Buenas en que la puedo ayudar','18:05:00'),(51,15,'Hola que tal, se me diagnosticó SARS-COV2 y quisiera saber si ese diagnóstico es correcto','18:06:00'),(52,15,'Entendido, verificaré el diagnostico y le diré mi opinión','18:06:30'),(52,15,'He verificado el diagnóstico tentativo y es correcto, usted padece SARS-COV2','18:07:00'),(52,15,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','18:08:00'),(52,15,'Algo más que desee consultar?','18:09:00'),(51,15,'No, todo claro','18:10:00'),(52,15,'Muy bien, que tenga un buen dia','18:11:00'),(51,15,'Hasta luego','18:11:50');
/*!40000 ALTER TABLE `conversa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Canelones'),(2,'Maldonado'),(3,'Rocha'),(4,'Treinta y tres'),(5,'Cerro largo'),(6,'Rivera'),(7,'Artigas'),(8,'Salto'),(9,'Paysandou'),(10,'Rio negro'),(11,'Soriano'),(12,'Colonia'),(13,'San jose'),(14,'Flores'),(15,'Florida'),(16,'Lavalleja'),(17,'Durazno'),(18,'Tacuarembo'),(19,'Montevideo');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostico`
--

DROP TABLE IF EXISTS `diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diagnostico` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_tipo` int(10) NOT NULL,
  `id_paciente` int(10) NOT NULL,
  `id_patologia` int(10) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_tipo` (`id_tipo`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_patologia` (`id_patologia`),
  CONSTRAINT `diagnostico_ibfk_1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_diagnostico` (`id`),
  CONSTRAINT `diagnostico_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`),
  CONSTRAINT `diagnostico_ibfk_3` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostico`
--

LOCK TABLES `diagnostico` WRITE;
/*!40000 ALTER TABLE `diagnostico` DISABLE KEYS */;
INSERT INTO `diagnostico` VALUES (1,2,2,7,'2020-08-05'),(2,2,4,7,'2020-08-03'),(3,2,5,10,'2020-07-14'),(4,2,6,40,'2020-07-14'),(5,2,7,22,'2020-07-29'),(6,2,8,29,'2020-07-30'),(7,2,9,22,'2020-08-01'),(8,2,21,21,'2020-08-01'),(9,2,22,3,'2020-08-01'),(10,2,23,3,'2020-01-02'),(11,2,24,39,'2020-08-03'),(12,2,25,39,'2020-08-04'),(13,2,26,14,'2020-08-04'),(14,2,27,2,'2020-08-05'),(15,1,28,31,'2020-08-03'),(16,1,29,16,'2020-06-01'),(17,1,30,28,'2020-07-23'),(18,1,31,20,'2020-07-23'),(19,1,32,15,'2020-06-07'),(20,1,33,26,'2020-08-10'),(21,2,51,41,'2020-04-24'),(23,1,53,9,'2020-09-01'),(24,1,54,9,'2020-10-05'),(25,1,55,9,'2020-10-09');
/*!40000 ALTER TABLE `diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mensaje`
--

DROP TABLE IF EXISTS `mensaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensaje` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `texto` text NOT NULL,
  `hora` time NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=140 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensaje`
--

LOCK TABLES `mensaje` WRITE;
/*!40000 ALTER TABLE `mensaje` DISABLE KEYS */;
INSERT INTO `mensaje` VALUES (1,'Buenas en que la puedo ayudar','20:08:00'),(2,'Hola que tal, se me diagnosticó Asma bronquial y quisiera saber si ese diagnóstico es correcto','20:09:00'),(3,'Entendido, verificaré el diagnostico y le diré mi opinión','20:09:30'),(4,'He verificado el diagnóstico tentativo y es correcto, usted padece Asma bronquial','20:11:00'),(5,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','20:12:00'),(6,'Algo más que desee consultar?','20:12:10'),(7,'No, todo claro','20:13:00'),(8,'Muy bien, que tenga un buen dia','20:14:00'),(9,'Hasta luego','20:14:25'),(10,'Buenas en que lo puedo ayudar','09:04:00'),(11,'Hola que tal, se me diagnosticó Neumonía y quisiera saber si ese diagnóstico es correcto','09:05:00'),(12,'Entendido, verificaré el diagnostico y le diré mi opinión','09:05:50'),(13,'He verificado el diagnóstico tentativo y es equívoco, usted padece Asma bronquial','09:08:00'),(14,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','09:09:00'),(15,'Algo más que desee consultar?','09:10:00'),(16,'No, gracias','09:11:00'),(17,'Muy bien, que tenga un buen dia','09:11:25'),(18,'Hasta luego','09:12:00'),(19,'Buenas en que lo puedo ayudar','11:06:00'),(20,'Hola que tal, se me diagnosticó Artritis y quisiera saber si ese diagnóstico es correcto','11:07:00'),(21,'Entendido, verificaré el diagnostico y le diré mi opinión','11:07:54'),(22,'He verificado el diagnóstico tentativo y es correcto, usted padece Artritis','11:08:00'),(23,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','11:08:59'),(24,'Algo más que desee consultar?','11:09:00'),(25,'No, muchas gracias','11:10:00'),(26,'Muy bien, que tenga un buen dia','11:10:26'),(27,'Hasta luego','11:11:00'),(28,'Buenas en que la puedo ayudar','23:38:00'),(29,'Hola que tal, se me diagnosticó Nefropatía crónica y quisiera saber si ese diagnóstico es correcto','23:39:00'),(30,'Entendido, verificaré el diagnostico y le diré mi opinión','23:39:50'),(31,'He verificado el diagnóstico tentativo y es equívoco, usted padece Tendinitis','23:43:00'),(32,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','23:44:00'),(33,'Algo más que desee consultar?','23:45:00'),(34,'No, todo claro','23:46:00'),(35,'Excelente, que tenga un buen dia','23:47:00'),(36,'Hasta luego','23:47:40'),(37,'Buenas en que lo puedo ayudar','06:59:00'),(38,'Hola que tal, se me diagnosticó Bronquitis y quisiera saber si ese diagnóstico es correcto','07:00:00'),(39,'Entendido, verificaré el diagnostico y le diré mi opinión','07:01:00'),(40,'He verificado el diagnóstico tentativo y es correcto, usted padece Bronquitis','07:04:00'),(41,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','07:05:00'),(42,'Algo más que desee consultar?','07:05:20'),(43,'No, gracias','07:06:00'),(44,'Perfecto, que tenga un buen dia','07:07:00'),(45,'Hasta luego','07:07:54'),(46,'Buenas en que lo puedo ayudar','14:26:00'),(47,'Hola que tal, se me diagnosticó Leucemia y quisiera saber si ese diagnóstico es correcto','14:27:00'),(48,'Entendido, verificaré el diagnostico y le diré mi opinión','14:27:30'),(49,'He verificado el diagnóstico tentativo y es equívoco, usted padece Tuberculosis','14:30:00'),(50,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','14:31:00'),(51,'Algo más que desee consultar?','14:31:50'),(52,'Si, cuan mortal es la tuberculosis?','14:32:00'),(53,'Tiene un 30% de riesgo de muerte','14:34:00'),(54,'Gracias por contestarme, no tengo más dudas','14:35:00'),(55,'Muy bien, que tenga un buen dia','14:36:00'),(56,'Hasta luego','14:36:25'),(57,'Buenas en que la puedo ayudar','19:03:00'),(58,'Hola que tal, se me diagnosticó Bronquitis y quisiera saber si ese diagnóstico es correcto','19:04:00'),(59,'Entendido, verificaré el diagnostico y le diré mi opinión','19:05:00'),(60,'He verificado el diagnóstico tentativo y es correcto, usted padece Bronquitis','19:07:00'),(61,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','19:08:00'),(62,'Algo más que desee consultar?','19:08:24'),(63,'No, todo claro','19:09:00'),(64,'Perfecto, que tenga un buen dia','19:10:00'),(65,'Hasta luego','19:10:25'),(66,'Buenas en que la puedo ayudar','17:18:00'),(67,'Hola que tal, se me diagnosticó Conjuntivitis y quisiera saber si ese diagnóstico es correcto','17:19:00'),(68,'Entendido, verificaré el diagnostico y le diré mi opinión','17:20:00'),(69,'He verificado el diagnóstico tentativo y es correcto, usted padece Conjuntivitis','17:24:00'),(70,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','17:25:00'),(71,'Algo más que desee consultar?','17:26:00'),(72,'No, muchas gracias','17:27:00'),(73,'Muy bien, que tenga un buen dia','17:28:00'),(74,'Hasta luego','17:28:30'),(75,'Buenas en que lo puedo ayudar','17:18:00'),(76,'Hola que tal, se me diagnosticó Diabetes tipo 1 y quisiera saber si ese diagnóstico es correcto','17:19:00'),(77,'Entendido, verificaré el diagnostico y le diré mi opinión','17:20:00'),(78,'He verificado el diagnóstico tentativo y es equívoco, usted padece Cataratas','17:26:00'),(79,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','17:27:00'),(80,'Algo más que desee consultar?','17:27:30'),(81,'No, todo claro','17:28:00'),(82,'Muy bien, que tenga un buen dia','17:29:00'),(83,'Hasta luego','17:29:30'),(84,'Buenas en que la puedo ayudar','13:13:00'),(85,'Hola que tal, se me diagnosticó Tracoma y quisiera saber si ese diagnóstico es correcto','13:14:00'),(86,'Entendido, verificaré el diagnostico y le diré mi opinión','13:15:00'),(87,'He verificado el diagnóstico tentativo y es correcto, usted padece Cataratas','13:16:00'),(88,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','13:17:00'),(89,'Algo más que desee consultar?','13:17:32'),(90,'No, gracias','13:18:00'),(91,'Muy bien, que tenga un buen dia','13:19:00'),(92,'Hasta luego','13:19:36'),(93,'Buenas en que la puedo ayudar','07:31:00'),(94,'Hola que tal, se me diagnosticó Disfagia y quisiera saber si ese diagnóstico es correcto','07:32:00'),(95,'Entendido, verificaré el diagnostico y le diré mi opinión','07:33:00'),(96,'He verificado el diagnóstico tentativo y es correcto, usted padece Disfagia','07:36:00'),(97,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','07:37:00'),(98,'Algo más que desee consultar?','07:38:00'),(99,'No, muchas gracias','07:38:20'),(100,'Excelente, que tenga un buen dia','07:39:00'),(101,'Hasta luego','07:39:46'),(102,'Buenas en que lo puedo ayudar','16:09:00'),(103,'Hola que tal, se me diagnosticó Disfagia y quisiera saber si ese diagnóstico es correcto','16:10:00'),(104,'Entendido, verificaré el diagnostico y le diré mi opinión','16:11:00'),(105,'He verificado el diagnóstico tentativo y es correcto, usted padece Disfagia','16:16:00'),(106,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','16:17:00'),(107,'Algo más que desee consultar?','16:18:00'),(108,'Si, es mortal?','16:18:40'),(109,'Tiene un riesgo medio de muerte si no se siguen los tratamientos','16:19:00'),(110,'Está bien, gracias por responder, no tengo más preguntas','16:20:00'),(111,'Muy bien, que tenga un buen dia','16:21:00'),(112,'Hasta luego','16:21:30'),(113,'Buenas en que la puedo ayudar','06:01:00'),(114,'Hola que tal, se me diagnosticó Fibrosis pulmonar y quisiera saber si ese diagnóstico es correcto','06:02:00'),(115,'Entendido, verificaré el diagnostico y le diré mi opinión','06:03:00'),(116,'He verificado el diagnóstico tentativo y es correcto, usted padece Fibrosis pulmonar','06:08:00'),(117,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','06:09:00'),(118,'Algo más que desee consultar?','06:10:00'),(119,'No, todo claro gracias','06:11:00'),(120,'Muy bien, que tenga un buen dia','06:12:00'),(121,'Hasta luego','06:12:32'),(122,'Buenas en que la puedo ayudar','21:13:00'),(123,'Hola que tal, se me diagnosticó Diabétes tipo 1 y quisiera saber si ese diagnóstico es correcto','21:14:00'),(124,'Entendido, verificaré el diagnostico y le diré mi opinión','21:15:00'),(125,'He verificado el diagnóstico tentativo y es correcto, usted padece Diabétes tipo 1','21:18:00'),(126,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','21:19:00'),(127,'Algo más que desee consultar?','21:20:00'),(128,'No, gracias','21:21:00'),(129,'Excelente, que tenga un buen dia','21:22:00'),(130,'Hasta luego','21:22:30'),(131,'Buenas en que la puedo ayudar','18:05:00'),(132,'Hola que tal, se me diagnosticó SARS-COV2 y quisiera saber si ese diagnóstico es correcto','18:06:00'),(133,'Entendido, verificaré el diagnostico y le diré mi opinión','18:06:30'),(134,'He verificado el diagnóstico tentativo y es correcto, usted padece SARS-COV2','18:07:00'),(135,'Al finalizar el chat se le indicarán los tratamientos que puede seguir','18:08:00'),(136,'Algo más que desee consultar?','18:09:00'),(137,'No, todo claro','18:10:00'),(138,'Muy bien, que tenga un buen dia','18:11:00'),(139,'Hasta luego','18:11:50');
/*!40000 ALTER TABLE `mensaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `muere`
--

DROP TABLE IF EXISTS `muere`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `muere` (
  `id_persona` int(10) NOT NULL,
  `id_patologia` int(10) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_persona`,`id_patologia`),
  KEY `id_persona` (`id_persona`),
  KEY `muere_ibfk_2` (`id_patologia`),
  CONSTRAINT `muere_ibfk_1` FOREIGN KEY (`id_persona`) REFERENCES `persona` (`id`),
  CONSTRAINT `muere_ibfk_2` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `muere`
--

LOCK TABLES `muere` WRITE;
/*!40000 ALTER TABLE `muere` DISABLE KEYS */;
INSERT INTO `muere` VALUES (27,41,'2020-05-01'),(28,41,'2020-03-08'),(53,29,'2020-09-14'),(54,14,'2020-04-25'),(55,14,'2019-08-13');
/*!40000 ALTER TABLE `muere` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_sufre`
--

DROP TABLE IF EXISTS `paciente_sufre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente_sufre` (
  `id_sintoma` int(10) NOT NULL,
  `id_paciente` int(10) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_sintoma`,`id_paciente`,`fecha`),
  KEY `id_paciente` (`id_paciente`),
  CONSTRAINT `paciente_sufre_ibfk_1` FOREIGN KEY (`id_sintoma`) REFERENCES `sintoma` (`id`),
  CONSTRAINT `paciente_sufre_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_sufre`
--

LOCK TABLES `paciente_sufre` WRITE;
/*!40000 ALTER TABLE `paciente_sufre` DISABLE KEYS */;
INSERT INTO `paciente_sufre` VALUES (1,2,'2020-08-05'),(2,4,'2020-08-03'),(3,2,'2020-08-05'),(4,4,'2020-08-03'),(4,51,'2020-04-24'),(5,2,'2020-08-05'),(6,5,'2020-07-14'),(7,6,'2020-07-14'),(8,5,'2020-07-14'),(9,6,'2020-07-14'),(10,5,'2020-07-14'),(11,7,'2020-07-29'),(12,8,'2020-07-30'),(12,51,'2020-04-24'),(13,2,'2020-08-05'),(13,7,'2020-07-29'),(13,51,'2020-04-24'),(13,53,'2020-09-01'),(13,54,'2020-10-05'),(13,55,'2020-10-09'),(14,8,'2020-07-30'),(14,53,'2020-09-01'),(14,55,'2020-10-09'),(15,9,'2020-08-01'),(16,21,'2020-08-01'),(17,9,'2020-08-01'),(17,22,'2020-08-01'),(18,21,'2020-08-01'),(19,22,'2020-08-01'),(20,23,'2020-01-02'),(21,22,'2020-08-01'),(22,23,'2020-01-02'),(25,24,'2020-08-03'),(26,25,'2020-08-04'),(27,24,'2020-08-03'),(28,25,'2020-08-04'),(29,26,'2020-08-04'),(30,27,'2020-08-05'),(31,26,'2020-08-04'),(32,27,'2020-08-05'),(33,26,'2020-08-04'),(33,29,'2020-06-01'),(34,28,'2020-08-03'),(35,29,'2020-06-01'),(36,28,'2020-08-03'),(37,29,'2020-06-01'),(38,28,'2020-08-03'),(39,29,'2020-06-01'),(40,30,'2020-07-23'),(41,31,'2020-07-23'),(42,32,'2020-06-07'),(48,53,'2020-09-01'),(51,54,'2020-10-05'),(52,54,'2020-10-05'),(52,55,'2020-10-09'),(54,32,'2020-06-07'),(55,51,'2020-04-24'),(66,31,'2020-07-23'),(68,33,'2020-08-10'),(70,33,'2020-08-10'),(72,2,'2020-08-05'),(72,31,'2020-07-23'),(72,33,'2020-08-10');
/*!40000 ALTER TABLE `paciente_sufre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patologia`
--

DROP TABLE IF EXISTS `patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patologia` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_prioridad` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `indiceMortalidad` int(10) NOT NULL,
  `id_tipo` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `id_prioridad` (`id_prioridad`),
  KEY `id_tipo` (`id_tipo`),
  CONSTRAINT `patologia_ibfk_1` FOREIGN KEY (`id_prioridad`) REFERENCES `prioridad` (`id`),
  CONSTRAINT `patologia_ibfk_2` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_patologia` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patologia`
--

LOCK TABLES `patologia` WRITE;
/*!40000 ALTER TABLE `patologia` DISABLE KEYS */;
INSERT INTO `patologia` VALUES (1,2,'Nefropatía crónica','La enfermedad renal crónica, también llamada insuficiencia renal crónica, describe la pérdida gradual de la función renal.',30,1),(2,2,'Diabetes tipo 1','La diabetes tipo 1 es un trastorno crónico en el cual el páncreas produce muy poca insulina o directamente no la produce.',15,2),(3,3,'Cataratas','Una catarata es una opacidad de la transparencia normal del cristalino del ojo.',1,3),(4,2,'Neumonia','La neumonía es una infección que inflama los sacos aéreos de uno o ambos pulmones.',15,4),(5,2,'Retinopatia diabetica','La retinopatía diabética es una complicación de la diabetes que afecta los ojos. Es causada por el daño a los vasos sanguíneos.',20,3),(6,1,'Diabetes tipo 2','La diabetes de tipo 2 es un trastorno crónico que afecta la manera en la cual el cuerpo metaboliza el azúcar.',40,2),(7,3,'Asma bronquial','El asma es una afección en la que se estrechan y se hinchan las vías respiratorias, lo cual produce mayor mucosidad.',8,4),(8,2,'Colera','El cólera es una enfermedad bacteriana que, por lo general, se propaga a través del agua contaminada.',30,5),(9,1,'Leucemia','La leucemia es el cáncer de los tejidos que forman la sangre en el organismo, incluso la médula ósea y el sistema linfático.',51,6),(10,3,'Artritis','La artritis es la hinchazón y la sensibilidad de una o más de las articulaciones.',1,2),(11,3,'Parkinson','La enfermedad de Parkinson es una enfermedad progresiva del sistema nervioso que afecta el movimiento.',1,7),(12,1,'Linfoma','El linfoma es un tipo de cáncer del sistema linfático, que es parte de la red del organismo que combate los gérmenes.',75,6),(13,1,'Fiebre amarilla','La fiebre amarilla es una infección viral que transmite un tipo particular de mosquito, frecuente en Africa y Sudamerica.',50,5),(14,1,'Fibrosis pulmonar','La fibrosis pulmonar es una enfermedad pulmonar que se produce cuando el tejido pulmonar se daña y se producen cicatrices.',45,4),(15,3,'Migraña','La migraña puede causar un dolor pulsátil intenso o una sensación de latido en la cabeza, generalmente de un solo lado.',2,7),(16,3,'Mononucleosis','El virus que causa la mononucleosis se transmite por la saliva.',3,5),(17,2,'Zika','La enfermedad por el virus del Zika es una infección viral transmitida por los mosquitos.',15,5),(18,3,'Hepatitis A','La hepatitis A es una infección del hígado sumamente contagiosa causada por el virus de la hepatitis A.',5,2),(19,2,'Hepatitis B','La hepatitis B es una infección hepática grave causada por el virus VHB.',22,2),(20,2,'Hepatitis C','La hepatitis C es una infección vírica que causa inflamación del hígado, lo que a veces conduce a un daño hepático grave.',30,2),(21,3,'Conjuntivitis','La conjuntivitis es una inflamación o una infección en la membrana transparente que recubre el párpado y el globo ocular.',0,8),(22,1,'Bronquitis','La bronquitis es una inflamación del revestimiento de los bronquios que llevan el aire hacia adentro y fuera de los pulmones.',40,4),(23,3,'Pancreatitis','La pancreatitis es inflamación en el páncreas.',8,8),(24,1,'Sindrome nefrotico','El síndrome nefrótico es un trastorno renal que hace que el cuerpo excrete demasiadas proteínas en la orina.',5,9),(25,3,'Sinusitis aguda','La sinusitis aguda hace que los espacios dentro de la nariz (senos paranasales) se inflamen e hinchen.',5,8),(26,3,'Siringomielia','La siringomielia es el desarrollo de un quiste lleno de líquido dentro de la médula espinal.',5,10),(27,1,'Sindrome pulmonar por hantavirus','El síndrome pulmonar por hantavirus es una enfermedad infecciosa caracterizada por síntomas similares a la influenza.',40,5),(28,3,'Tracoma','El tracoma es una infección bacteriana que afecta los ojos. Se produce por la bacteria Chlamydia trachomatis.',0,5),(29,2,'Tuberculosis','La bacteria suele atacar los pulmones, pero puede también dañar otras partes del cuerpo.',30,5),(30,3,'Ganglion','Los quistes ganglionares son bultos no cancerosos ,con frecuencia se forman a lo largo de los tendones o de las articulaciones.',0,10),(31,1,'Gangrena','La gangrena es la muerte de tejido corporal como consecuencia de la falta de irrigación sanguínea o de una infección bacteriana.',40,5),(32,2,'Gastritis','La gastritis es un término general para un grupo de enfermedades con un punto en común: la inflamación del estómago.',20,9),(33,3,'Glaucoma','El glaucoma es un grupo de afecciones oculares que dañan el nervio óptico, cuya salud es vital para tener una buena vista.',5,3),(34,2,'Vasculitis','La vasculitis es la inflamación de los vasos sanguíneos. Provoca cambios en las paredes de los vasos sanguíneos.',30,8),(35,1,'VIH','El síndrome de inmunodeficiencia adquirida es una afección crónica que puede poner en riesgo la vida. ',55,11),(36,1,'Rabia','La rabia es un virus mortal que se propaga a las personas a través de la saliva de animales infectados.',99,5),(37,3,'Atelectasia','La atelectasia es un colapso completo o parcial del pulmón entero o de una parte (lóbulo) del pulmón.',8,4),(38,3,'Diarrea','La diarrea (deposiciones blandas, líquidas y posiblemente más frecuentes) es un problema común.',3,9),(39,2,'Disfagia','Es la dificultad para tragar.',30,8),(40,3,'Tendinitis','La tendinitis es la inflamación o la irritación de un tendón, las cuerdas fibrosas que unen el músculo al hueso.',1,8),(41,1,'SARS-COV2','La enfermedad por coronavirus (COVID 19) es una ?enfermedad infecciosa causada por un ?coronavirus recientemente descubierto.',60,4);
/*!40000 ALTER TABLE `patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `persona` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
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
  `pin` int(4) DEFAULT NULL,
  `muerto` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `ci` (`ci`),
  UNIQUE KEY `email` (`email`),
  UNIQUE KEY `usuario` (`usuario`),
  KEY `id_tipo` (`id_tipo`),
  KEY `id_ciudad` (`id_ciudad`),
  CONSTRAINT `persona_ibfk_1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_persona` (`id`),
  CONSTRAINT `persona_ibfk_2` FOREIGN KEY (`id_ciudad`) REFERENCES `ciudad` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,46067186,'Julia','Leila','Howe','Perry','M','1959-05-10','Maecenas.libero@gmail.com','Quisque',1538,2,NULL,2,'Ginecologa','jul59','681nlo',NULL,0),(2,35570765,'Beverly',NULL,'Riley','Contreras','M','1999-09-26','nulla.at.sem@hotmail.com','Vivamus',4995,5,1,3,NULL,NULL,NULL,NULL,0),(3,28399224,'Anastasia','Jaquelyn','Crado','Kiss','M','1946-11-10','lobortis.tellus.justo@gmail.com','Ariel',5999,6,NULL,1,NULL,'admintata16','14adhj',2006,0),(4,41336383,'Oscar','Spencer','Rodriguez','Yang','H','2002-07-20','nec@utpharetra.net','Box',8500,10,0,3,NULL,NULL,NULL,NULL,0),(5,14321113,'Alexander','Marcelo','Coper','Wallace','H','1967-05-16','ultrices.sit@egestaslacinia.com','Oncativo',5943,1,0,3,NULL,NULL,NULL,NULL,0),(6,22040672,'Nicole',NULL,'Ocampos','Vinson','M','1986-07-27','ultrices.sit.amet@Integer.net','Malesuada',4229,1,0,3,NULL,NULL,NULL,NULL,0),(7,56661131,'Pedro','Ivan','Casilla','Woodward','H','2000-05-03','mauris.ut@justonecante.com','Elementum',6006,1,0,3,NULL,NULL,NULL,NULL,0),(8,42807329,'Joaquin','Sebastian','Monroe','Diaz','H','1995-06-21','Integer.id.magna@parturient.com','Facilisis',8334,1,0,3,NULL,NULL,NULL,NULL,0),(9,31567128,'Camila',NULL,'Perez','Roy','M','1985-11-11','tristique.aliquet@inceptos.com','Av. Italia',9062,1,0,3,NULL,NULL,NULL,NULL,0),(10,61496047,'Micaela','Julieta','Foster','Bowman','M','1979-07-18','sociosqu.ad.litora@gmail.com','Lacinia',9988,6,NULL,2,'Oftalmologa','jul79','qn96v3',NULL,0),(11,52241986,'Erik','Carlos','Rice','Carpe','H','1966-12-26','non.luctus.sit@lacusvarius.org','Parturient',7016,17,NULL,2,'Otorrinolaringólogo','ric66','v13t35',NULL,0),(12,32082895,'Thadeo','Juan','Guerrero','Tran','H','1975-02-11','amet.ornare.lectus@facilisis.com','Temperley',1078,22,NULL,2,'Cardiologa','tran75','uw148j',NULL,0),(13,45960884,'Aldo',NULL,'Barrios','Lopez','H','1979-03-17','tincidunt.adipiscing@egetvenenatis.ca','Av. Rivera',4235,25,NULL,2,'Medicina General','aldo79','b8o4bw',NULL,0),(14,66635033,'Guillermo','José','Rige','Gentry','H','2001-06-03','nec.leo.Morbi@iaculis.net','Magna',3339,28,NULL,2,'Neurologo','rig01','y07b46',NULL,0),(15,66953713,'Lydia','Emilia','Colinas','Campos','M','1974-09-11','egestas@liberoestcongue.org','Libero',8243,1,NULL,2,'Neumologa','lyd74','me4a6c',NULL,0),(16,40688581,'Javier',NULL,'Park','Welch','H','2000-07-13','odio.Aliquam.vulputate@dapibusidblandit.edu','Augue',8682,1,NULL,2,'Gastroenterologo','jav20','kvs6hk',NULL,0),(17,51144309,'Santiago',NULL,'Garcia','Mercado','H','1978-10-04','nisl.sem@velesttempor.com','Dolor',7158,16,NULL,2,'Infectologo','san78','n3a71h',NULL,0),(18,30381358,'Melanie',NULL,'Burris','Crane','M','1992-04-07','gravida@purusmaurisa.com','Aliquam',4621,2,NULL,2,'Neurologo','mel92','eo2161',NULL,0),(19,38458268,'Kevin','Ricardo','Alfonso','Perry','H','1972-11-11','bibendum.sed@dolor.edu','Amet',2092,28,NULL,2,'Proctologo','kev72','3j7yc7',NULL,0),(20,51857607,'Vincente',NULL,'Sanders','Chavez','H','1977-01-16','eget.metus@vulputate.edu','Egestas',6922,1,NULL,2,'Reumatologo','vic77','55j9in',NULL,0),(21,12986816,'Ruby',NULL,'Walto','Buker','H','2003-07-20','Lorem.ipsum@gmail.com','Bell',4789,7,0,3,NULL,NULL,NULL,NULL,0),(22,42444235,'Benjamin','Lucas','Norris','Ryan','H','2002-12-10','dis.parturient.montes@htomail.com','Palermo',1333,12,0,3,NULL,NULL,NULL,NULL,0),(23,49255274,'Mia','Lana','Velazquez','Glover','M','2014-01-11','arcu@mauris.edu.uy','Siracusa',8742,31,1,3,NULL,NULL,NULL,NULL,0),(24,21137953,'Eleanor',NULL,'Casey','Haynes','M','1960-10-04','sagittis.Nullam.vitae@elementumategestas.org','Calle 3',2284,25,0,3,NULL,NULL,NULL,NULL,0),(25,53676912,'Martin','Brian','Mcdowell','Mileto','H','1944-01-23','molestie.pharetra.nibh@enimMauris.com','Orinoco',4434,23,0,3,NULL,NULL,NULL,NULL,0),(26,11618271,'Kalani',NULL,'Hilikiler','Mope','M','2009-05-26','non.dui@tinciduntcongueturpis.org','Calle 4',5638,21,0,3,NULL,NULL,NULL,NULL,0),(27,68651471,'Mariela','Jasmine','Nicholson','Stephens','M','1980-04-02','mi@erosProinultrices.edu','Arocena',5050,6,0,3,NULL,NULL,NULL,NULL,1),(28,62157114,'Neville','Sean','Rice','Mills','H','1985-05-11','velit.Quisque@nibh.edu','Av. Sayago',4469,16,0,3,NULL,NULL,NULL,NULL,1),(29,39723364,'Wilson',NULL,'Da Silva','Ferreira','H','2001-03-06','nisl@aliquam.net','Av.Millán',8976,28,0,3,NULL,NULL,NULL,NULL,0),(30,16385445,'Santiago','Nahuel','Hernandez','Rios','H','1982-07-23','enim.non@tortor.com','Av.Italia',9356,1,0,3,NULL,NULL,NULL,NULL,0),(31,18404866,'Facundo','Ezequiel','Ibañez','Martinez','H','1967-06-30','fringilla@aauctornon.co.uk','Aconcagua',3021,4,0,3,NULL,NULL,NULL,NULL,0),(32,24115231,'Marcelo','Usbo','Nelson','Alegre','H','1992-10-19','ac.risus@a.ca','Av José Batlle y Ordóñez',9699,7,0,3,NULL,NULL,NULL,NULL,0),(33,41420327,'Anika',NULL,'Fitzpatrick','Gray','M','1961-02-17','nisl@dictum.edu','Echeverria',4638,9,0,3,NULL,NULL,NULL,NULL,0),(34,53051837,'Hermione','Deirdre','Cochran','Bright','M','1988-03-02','posuere.vulputate.lacus@feugiatSednec.co.uk','Antonio María Márquez',8737,6,NULL,2,'Nefrología','herma53','ion44e',NULL,0),(35,53884722,'Sierra',NULL,'Petersen','Sims','M','1993-04-26','non.bibendum@estarcuac.edu','Sargento Patricio',3232,10,NULL,2,'Reumatología','sen555','sie472',NULL,0),(36,37201024,'Rodrigo','Jonah','Hull','Little','H','1966-08-13','vel@mitemporlorem.org','Av. Eugenio Garzón',8205,11,NULL,2,'Pediatría','rodr09','jon454',NULL,0),(37,55440212,'Harrison',NULL,'Mayo','Wyatt','H','1961-03-30','nunc.nulla.vulputate@semperauctor.co.uk','Cno Gral Maximo Santos',6156,22,NULL,2,'Neurología','harr56','mayd66',NULL,0),(38,20186143,'Keaton','Lydia','Howell','Conley','M','1976-01-13','elit.elit.fermentum@Loremipsum.edu','Av. 18 de Julio',8020,23,NULL,2,'Gastroenterología','keat12','ho4k55',NULL,0),(39,40865631,'Gwendolyn','Lawrence','Horne','Puckett','H','1964-07-28','varius.et.euismod@sodales.org','Calle 2',4516,6,NULL,2,'Alergología','lynlaw','lyn6h63',NULL,0),(40,47213603,'Isaac','Joshua','Calhoun','Mercado','H','1962-09-17','vulputate@etultrices.co.uk','Confederada',2259,31,NULL,2,'Angiología','isacc4','is5a4c',NULL,0),(41,35947448,'Germaine','Emma','Pate','Rollins','M','1972-06-22','vel@Donec.com','Carafí',7584,1,NULL,2,'Hepatología','emma44','em4am4',NULL,0),(42,41605049,'Braian',NULL,'Mccray','Odonnell','H','1978-09-25','eleifend.egestas@ametrisus.net','Turpis Avenue',2318,1,NULL,1,NULL,'bra78','0h56i6',2534,0),(43,51956816,'Nicole','Silvia','Buchanan','Ferreira','M','1987-07-16','vel.est@amalesuada.org','Mollis',1834,25,NULL,1,NULL,'nic78','s7m4qf',5234,0),(44,25423452,'Melanie','Yennifer','Warren','Hart','M','1964-12-06','Cras@ultricesmaurisipsum.edu','Velodromo',9443,20,NULL,1,NULL,'mel64','84ulkc',6324,0),(45,45275761,'Amanda','Yoko','Morales','Pacheco','M','1992-04-14','Curabitur@necmollis.org','Av. Molestie',7292,1,NULL,1,NULL,'ama92','clfv8w',1523,0),(46,39706785,'Karen',NULL,'Blevins','Colon','M','1976-12-22','cursus.diam@elitNulla.org','Gravida',8878,30,NULL,1,NULL,'kar76','g3b57t',4234,0),(47,32715256,'Ignacio',NULL,'Sosa','Rose','H','1990-02-16','dapibus.rutrum@dictum.org','Purus',6339,29,NULL,1,NULL,'ign90','b619jo',2315,0),(48,45683607,'Maximiliano','Xerxes','Louise','Velazquez','H','1984-12-30','per.inceptos.hymenaeos@acturpisegestas.com','Av. giannatasio',3960,1,NULL,1,NULL,'max84','p9u4rn',5214,0),(49,21503121,'Cesar','Carter','Villarreal','Oconnor','H','1993-08-17','faucibus@eleifendegestasSed.net','Jose belloni',2057,22,NULL,1,NULL,'ces93','xir00p',9089,0),(50,35630549,'Enzo','Vincente','Antoñoni','Mcmillan','H','1968-01-05','euismod@nectempusmauris.net','Av. Egestas',7865,3,NULL,1,NULL,'enz68','ah9fx5',8669,0),(51,31108971,'Walter','Washington','Gutierrez','Sanguinneti','H','1950-06-20','walterwash@gmail.com','Siracusa',3424,1,0,3,NULL,NULL,NULL,NULL,0),(52,37178735,'Mariana','Melanie','Martinez','Gonzalez','M','1970-03-01','marian.mart@gmail.com','Mataojos',2135,1,NULL,2,'Neurólogo','mar70','9v03p7',NULL,0),(53,52108971,'Kevin','Mathew','Anadon','Wappler','H','2002-07-07','mathewanadon@gmail.com','Villa de masnou',5806,1,NULL,3,NULL,NULL,NULL,NULL,1),(54,53683976,'Mayza','Daniela','Ferreira','Hernandez','M','2003-03-16','mayfer@gmail.com','calle 2',35,1,NULL,3,NULL,NULL,NULL,NULL,1),(55,53472561,'Ignacio',NULL,'Rodriguez','Rodriguez','H','2002-12-12','igna@hotmail.com','Tomas de Tezanos',2356,21,NULL,3,NULL,NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peticion`
--

DROP TABLE IF EXISTS `peticion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `peticion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_paciente` int(10) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  `motivo` varchar(128) DEFAULT NULL,
  `fechaHoraInicio` datetime NOT NULL,
  `fechaHoraFin` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `peticion_ibfk_1` (`id_paciente`),
  CONSTRAINT `peticion_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `persona` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peticion`
--

LOCK TABLES `peticion` WRITE;
/*!40000 ALTER TABLE `peticion` DISABLE KEYS */;
INSERT INTO `peticion` VALUES (1,2,0,'Peticion aceptada','2020-08-05 20:05:00','2020-08-05 20:07:00'),(2,4,0,'Petcion aceptada','2020-08-03 09:00:00','2020-08-03 09:03:00'),(3,5,0,'Petcion aceptada','2020-07-14 11:04:00','2020-07-14 11:05:00'),(4,6,0,'Petcion aceptada','2020-07-14 23:35:00','2020-07-14 23:37:00'),(5,7,0,'Peticion aceptada','2020-07-29 06:57:00','2020-07-29 06:58:00'),(6,8,0,'Peticion aceptada','2020-07-30 14:23:00','2020-07-30 14:25:00'),(7,9,0,'Peticion aceptada','2020-08-01 19:02:00','2020-08-01 19:02:00'),(8,21,0,'Peticion aceptada','2020-08-01 17:15:00','2020-08-01 17:17:00'),(9,22,0,'Peticion aceptada','2020-08-01 17:15:00','2020-08-01 17:17:00'),(10,23,0,'Peticion aceptada','2020-08-02 13:11:00','2020-08-02 13:12:00'),(11,24,0,'Peticion aceptada','2020-08-03 07:28:00','2020-08-03 07:30:00'),(12,25,0,'Peticion aceptada','2020-08-04 16:06:00','2020-08-04 16:08:00'),(13,26,0,'Peticion aceptada','2020-08-04 05:59:00','2020-08-04 06:00:00'),(14,27,0,'Peticion aceptada','2020-08-05 21:10:00','2020-08-05 21:12:00'),(15,28,0,'Se retiró del Centro de atención de salud','2020-08-03 15:42:00','2020-08-03 15:43:00'),(16,51,0,'Peticion aceptada','2020-04-24 18:00:00','2020-04-24 18:04:00');
/*!40000 ALTER TABLE `peticion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prioridad`
--

DROP TABLE IF EXISTS `prioridad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prioridad` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prioridad`
--

LOCK TABLES `prioridad` WRITE;
/*!40000 ALTER TABLE `prioridad` DISABLE KEYS */;
INSERT INTO `prioridad` VALUES (1,'Alta'),(2,'Media'),(3,'Baja');
/*!40000 ALTER TABLE `prioridad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `region`
--

DROP TABLE IF EXISTS `region`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `region` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `region`
--

LOCK TABLES `region` WRITE;
/*!40000 ALTER TABLE `region` DISABLE KEYS */;
INSERT INTO `region` VALUES (1,'Cabeza'),(2,'Ojos'),(3,'Orejas'),(4,'Nariz'),(5,'Cavidad oral'),(6,'Cuello o garganta'),(7,'Pecho'),(8,'Brazo'),(9,'Parte superior del abdomen'),(10,'Abdomen medio'),(11,'Antebrazo'),(12,'Mano'),(13,'Parte baja del abdomen'),(14,'Genitales'),(15,'Muslo'),(16,'Rodilla'),(17,'Parte inferior de la pierna'),(18,'Pie'),(19,'Espalda');
/*!40000 ALTER TABLE `region` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salaChat`
--

DROP TABLE IF EXISTS `salaChat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salaChat` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `estado` tinyint(1) NOT NULL,
  `motivo` varchar(128) DEFAULT NULL,
  `fechaHoraInicio` datetime NOT NULL,
  `fechaHoraFin` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salaChat`
--

LOCK TABLES `salaChat` WRITE;
/*!40000 ALTER TABLE `salaChat` DISABLE KEYS */;
INSERT INTO `salaChat` VALUES (1,0,'Conversación finalizada','2020-08-05 20:08:00','2020-08-05 20:14:25'),(2,0,'Conversación finalizada','2020-08-03 09:04:00','2020-08-03 09:12:00'),(3,0,'Conversación finalizada','2020-07-14 11:06:00','2020-07-14 11:11:00'),(4,0,'Conversación finalizada','2020-07-14 23:38:00','2020-07-14 23:47:40'),(5,0,'Conversación finalizada','2020-07-29 06:59:00','2020-07-29 07:07:54'),(6,0,'Conversación finalizada','2020-07-30 14:26:00','2020-07-30 14:36:25'),(7,0,'Conversación finalizada','2020-08-01 19:03:00','2020-08-01 19:10:25'),(8,0,'Conversación finalizada','2020-08-01 17:18:00','2020-08-01 17:28:30'),(9,0,'Conversación finalizada','2020-08-01 17:18:00','2020-08-01 17:29:30'),(10,0,'Conversación finalizada','2020-08-02 13:13:00','2020-08-02 13:19:36'),(11,0,'Conversación finalizada','2020-08-03 07:31:00','2020-08-03 07:39:46'),(12,0,'Conversación finalizada','2020-08-04 16:09:00','2020-08-04 16:21:30'),(13,0,'Conversación finalizada','2020-08-04 06:01:00','2020-08-04 06:12:32'),(14,0,'Conversación finalizada','2020-08-05 21:13:00','2020-08-05 21:22:30'),(15,0,'Conversación finalizada','2020-04-24 18:04:00','2020-04-24 18:11:50');
/*!40000 ALTER TABLE `salaChat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sintoma` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_region` int(10) DEFAULT NULL,
  `descripcion` varchar(128) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_region` (`id_region`),
  CONSTRAINT `sintoma_ibfk_1` FOREIGN KEY (`id_region`) REFERENCES `region` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintoma`
--

LOCK TABLES `sintoma` WRITE;
/*!40000 ALTER TABLE `sintoma` DISABLE KEYS */;
INSERT INTO `sintoma` VALUES (1,7,'Disnea'),(2,7,'Dolor en el pecho'),(3,NULL,'Insomnio'),(4,6,'Tos'),(5,NULL,'Dolor'),(6,NULL,'Rigidez'),(7,NULL,'Hinchazón'),(8,NULL,'Eritema'),(9,7,'Taquipnea'),(10,7,'Sibilancias'),(11,4,'Esputo'),(12,NULL,'Fatiga'),(13,NULL,'Fiebre'),(14,NULL,'Escalofrios'),(15,7,'Dolor torácico'),(16,2,'Prurito'),(17,2,'Legaña'),(18,2,'Epifora'),(19,2,'Perdida de vision'),(20,2,'Fotofobia'),(21,2,'Perdida de colores'),(22,NULL,'Diarrea'),(23,NULL,'Nauseas'),(24,10,'Dolor abdominal'),(25,NULL,'Deshidratacion'),(26,NULL,'Incontinencia fecal'),(27,6,'Odinofagia'),(28,6,'Ronquera'),(29,10,'Acidez estomacal'),(30,NULL,'Perdida de peso'),(31,NULL,'Sed excesiva'),(32,14,'Incontinencia urinaria'),(33,NULL,'Dolor muscular'),(34,NULL,'Perdida de apetito'),(35,NULL,'Dificultad de movilidad de las articulaciones'),(36,NULL,'Cambios de color de piel'),(37,NULL,'Ampollas en la piel'),(38,NULL,'Piel brillante'),(39,10,'Indigestion'),(40,2,'Dolor ocular'),(41,14,'Orina oscura'),(42,12,'Dolor articular'),(43,NULL,'Ictericia'),(44,NULL,'Hematoma'),(45,10,'Ascitis'),(46,1,'Encefalopatia hepatica'),(47,NULL,'Araña vascular'),(48,NULL,'Debilidad'),(49,6,'Linfadenopatia'),(50,NULL,'Hemofilia'),(51,NULL,'Petequia'),(52,NULL,'Dolor oseo'),(53,2,'Escotomas'),(54,2,'Fotopsia'),(55,6,'Dolor de garganta'),(56,6,'Sarpullido'),(57,NULL,'Erupcion cutanea'),(58,NULL,'Presion alta'),(59,NULL,'Pulso acelerado'),(60,12,'Temblores'),(61,12,'Perdida de los movimientos'),(62,NULL,'Hiperactividad'),(63,6,'Llagas'),(64,NULL,'Edema'),(65,3,'Barotraumatismo'),(66,5,'Dolor en los dientes'),(67,4,'Sentido del olfato alterado'),(68,NULL,'Atrofia'),(69,19,'Escoliosis'),(70,2,'Inflamacion del parpado'),(71,2,'Ojos rojos'),(72,1,'Dolor de cabeza');
/*!40000 ALTER TABLE `sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintoma_compone`
--

DROP TABLE IF EXISTS `sintoma_compone`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sintoma_compone` (
  `id_sintoma` int(10) NOT NULL,
  `id_patologia` int(10) NOT NULL,
  PRIMARY KEY (`id_sintoma`,`id_patologia`),
  KEY `id_patologia` (`id_patologia`),
  CONSTRAINT `sintoma_compone_ibfk_1` FOREIGN KEY (`id_sintoma`) REFERENCES `sintoma` (`id`),
  CONSTRAINT `sintoma_compone_ibfk_2` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintoma_compone`
--

LOCK TABLES `sintoma_compone` WRITE;
/*!40000 ALTER TABLE `sintoma_compone` DISABLE KEYS */;
INSERT INTO `sintoma_compone` VALUES (1,1),(1,4),(1,7),(1,12),(1,14),(1,22),(1,37),(2,7),(3,7),(4,4),(4,7),(4,14),(4,22),(4,25),(4,29),(4,35),(4,37),(4,39),(4,41),(5,10),(5,30),(5,34),(5,40),(6,10),(6,11),(7,1),(7,10),(7,12),(7,20),(7,31),(7,40),(8,10),(8,21),(9,37),(10,37),(11,22),(12,1),(12,2),(12,4),(12,5),(12,6),(12,12),(12,14),(12,16),(12,18),(12,22),(12,23),(12,24),(12,25),(12,29),(12,34),(12,41),(13,4),(13,9),(13,12),(13,13),(13,16),(13,17),(13,18),(13,19),(13,22),(13,25),(13,27),(13,29),(13,34),(13,35),(13,36),(13,38),(13,41),(14,4),(14,9),(14,22),(14,27),(14,29),(15,1),(15,4),(15,22),(15,29),(16,21),(18,21),(19,2),(19,3),(19,5),(19,6),(19,15),(19,33),(20,3),(20,13),(20,28),(21,3),(22,8),(23,1),(23,4),(23,8),(23,13),(23,18),(23,19),(23,23),(23,32),(23,33),(23,36),(23,38),(24,8),(24,13),(24,18),(24,19),(24,23),(24,27),(24,32),(24,36),(24,38),(25,8),(26,38),(27,39),(28,39),(29,39),(30,2),(30,5),(30,6),(30,12),(30,14),(30,29),(30,34),(30,39),(31,2),(31,5),(31,6),(32,2),(33,13),(33,14),(33,16),(33,17),(33,26),(33,35),(34,1),(34,13),(34,18),(34,19),(34,20),(34,29),(36,31),(38,31),(39,32),(40,28),(40,33),(41,18),(41,19),(41,20),(42,18),(42,19),(42,20),(43,20),(44,20),(45,20),(46,20),(47,20),(48,1),(48,9),(49,9),(49,16),(50,9),(51,9),(52,9),(53,15),(54,15),(55,16),(55,35),(55,41),(56,16),(57,16),(57,17),(57,34),(57,35),(58,1),(60,11),(61,11),(62,36),(63,5),(63,6),(64,24),(65,25),(66,25),(67,25),(68,26),(69,26),(70,28),(71,17),(72,13),(72,16),(72,17),(72,25),(72,26),(72,27),(72,33),(72,34),(72,35),(72,36);
/*!40000 ALTER TABLE `sintoma_compone` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `test`
--

DROP TABLE IF EXISTS `test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `test` (
  `id` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `test`
--

LOCK TABLES `test` WRITE;
/*!40000 ALTER TABLE `test` DISABLE KEYS */;
INSERT INTO `test` VALUES (0),(1);
/*!40000 ALTER TABLE `test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_diagnostico`
--

DROP TABLE IF EXISTS `tipo_diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_diagnostico` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_diagnostico`
--

LOCK TABLES `tipo_diagnostico` WRITE;
/*!40000 ALTER TABLE `tipo_diagnostico` DISABLE KEYS */;
INSERT INTO `tipo_diagnostico` VALUES (2,'Definitivo'),(1,'Tentativo');
/*!40000 ALTER TABLE `tipo_diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_patologia`
--

DROP TABLE IF EXISTS `tipo_patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_patologia` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_patologia`
--

LOCK TABLES `tipo_patologia` WRITE;
/*!40000 ALTER TABLE `tipo_patologia` DISABLE KEYS */;
INSERT INTO `tipo_patologia` VALUES (2,'Autoinmune'),(6,'Cancerigena'),(3,'Degenerativa'),(1,'Endocrina'),(5,'Infecciosa'),(8,'Inflamacion'),(7,'Mental'),(10,'Quiste'),(4,'Respiratoria'),(9,'Trastorno Renal'),(11,'Venerea');
/*!40000 ALTER TABLE `tipo_patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_persona`
--

DROP TABLE IF EXISTS `tipo_persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_persona` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_persona`
--

LOCK TABLES `tipo_persona` WRITE;
/*!40000 ALTER TABLE `tipo_persona` DISABLE KEYS */;
INSERT INTO `tipo_persona` VALUES (1,'Administrador'),(2,'Medico'),(3,'Paciente');
/*!40000 ALTER TABLE `tipo_persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tratamiento`
--

DROP TABLE IF EXISTS `tratamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tratamiento` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_patologia` int(10) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `tipo` varchar(32) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `id_patologia` (`id_patologia`),
  CONSTRAINT `tratamiento_ibfk_1` FOREIGN KEY (`id_patologia`) REFERENCES `patologia` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=83 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tratamiento`
--

LOCK TABLES `tratamiento` WRITE;
/*!40000 ALTER TABLE `tratamiento` DISABLE KEYS */;
INSERT INTO `tratamiento` VALUES (1,1,'Clortalidona','La clortalidona es un medicamento diurético utilizado para tratar la hipertensión','Medicamento'),(2,1,'Eritropoyetina',' Proteína segregada, principalmente, por el riñón en el adulto y por el hígado en el feto, que estimula la producción de glóbulo','Medicamento'),(3,2,'Insulina','Es una hormona polipeptídica formada por 51 aminoácidos,? producida y secretada por las células beta de los islotes de Langerhan','Medicamento'),(4,2,'Aspirina','Se utiliza como medicamento para tratar el dolor, la fiebre y la inflamación','Medicamento'),(5,3,'Cirugía de cataratas','En la cirugía de cataratas se extrae el lente nublado y se reemplaza con un lente artificial transparente','Quirurjico'),(6,3,'Gotas oculares','Las gotas oculares podrían ayudar a controlar los síntomas de cataratas y le ayudan a ver más claramente hasta que se requiera d','Medicamento'),(7,4,'Penicilina','Son antibióticos del grupo de los betalactámicos empleados profusamente en el tratamiento de infecciones provocadas por bacteria','Medicamento'),(8,4,'Levofloxacino','El levofloxacino es un antibiótico del grupo de las quinolonas, más concretamente una fluorquinolona','Medicamento'),(9,5,'Fotocoagulación','Este tratamiento con láser, también conocido como tratamiento focal con láser, puede detener o disminuir la filtración de sangre','Quirurjico'),(10,5,'Vitrectomía','En este procedimiento se hace una pequeña incisión en el ojo para extraer la sangre del centro del ojo','Quirurjico'),(11,6,'Metformina','La metformina, o el preparado comercial clorhidrato de metformina, es un fármaco antidiabético de aplicación oral','Medicamento'),(12,6,'Tiazolidinedionas',' Las tiazolidinedionas mejoran la sensibilidad de los tejidos blancos a la insulina por actuar como agonistas selectivos','Medicamento'),(13,7,'Beclometasona','La beclomometasona se utiliza para evitar la dificultad para respirar, opresión en el pecho, sibilancia y tos por asma','Medicamento'),(14,7,'Teofilina','La teofilina se usa para prevenir y tratar las sibilancias, la falta de aliento y la opresión en el pecho','Medicamento'),(15,8,'Penicilamina','La penicilamina, producto de degradación de la penicilina','Medicamento'),(16,8,'Doxiciclina','La doxiciclina es un antibiótico del grupo de las tetraciclinas que previene el crecimiento y propagación de las bacterias','Medicamento'),(17,9,'Terapia biológica','La terapia biológica funciona mediante tratamientos que ayudan a tu sistema inmunitario a reconocer y atacar la leucemia','Quirurjico'),(18,9,'Radioterapia','La radioterapia usa rayos X u otros haces de alta energía para dañar las células de leucemia y detener su crecimiento','Quirurjico'),(19,10,'Tramadol','El tramadol es un analgésico de tipo opioide que alivia el dolor actuando sobre células nerviosas','Medicamento'),(20,10,'Ibuprofeno','El ibuprofeno es un antiinflamatorio no esteroideo','Medicamento'),(21,11,'Levodopa','Se utiliza principalmente para controlar los síntomas de la enfermedad de Parkinson','Medicamento'),(22,11,'Duopas','Es una medicina combinada que se usa para tratar los problemas de movimiento en personas con enfermedad de Parkinson avanzado','Medicamento'),(23,12,'Terapia de radiación','La terapia de radiación utiliza haces de energía de alta potencia, como rayos X y protones','Quirurjico'),(24,12,'Trasplante de médula ósea',' Un trasplante de médula ósea, también conocido como trasplante de células madre, implica el uso de altas dosis de quimioterapia','Quirurjico'),(25,13,'Vancomicina','La vancomicina es un glucopéptido de estructura compleja que se sintetiza de modo natural por Nocardia orientalis','Medicamento'),(26,13,'Transfusion de plasma','Las transfusiones de plasma son un tratamiento utilizado con frecuencia para los pacientes graves','Quirurjico'),(27,14,'Diatermia','Tratamiento que emplea corrientes eléctricas de alta frecuencia para elevar la temperatura de las partes más profundas','Quirurjico'),(28,14,'Masoterapia','El proceso consigue reducir las adherencias que tenga la cicatriz de la rotura y disminuye ostensiblemente la inflamación','Quirurjico'),(29,15,'Acetaminofén','Es un medicamento común para aliviar el dolor ligero o moderado de dolores de cabeza','Medicamento'),(30,15,'Propranolol','Propranolol es el nombre de un fármaco beta bloqueante usado principalmente en el tratamiento de la hipertensión','Medicamento'),(31,16,'Ampicilina','La ampicilina es un antibiótico betalactámico que ha sido extensamente utilizado para tratar infecciones bacterianas','Medicamento'),(32,16,'Amoxicilina','La amoxicilina es un antibiótico semisintético derivado de la penicilina','Medicamento'),(33,17,'Tylenol','e usa para bajar temporalmente la fiebre y para aliviar los dolores menores, como dolores de cabeza, musculares y más','Medicamento'),(34,17,'Motrin','Es un medicamento antiinflamatorio no esteroide y contiene ibuprofeno','Medicamento'),(35,18,'Oseltamivir','Oseltamivir es un profármaco antiviral','Medicamento'),(36,18,'Zanamivir','El zanamivir es un inhibidor de la neuraminidasa','Medicamento'),(37,19,'Entecavir','Funciona al disminuir la cantidad del virus de la hepatitis B en el cuerpo.','Medicamento'),(38,19,'Interferón','se administra como una inyección bajo la piel (vía subcutánea), generalmente en el muslo o en el abdomen','Medicamento'),(39,20,'Trasplante de hígado','Durante un trasplante hepático, el cirujano extrae el hígado dañado y lo reemplaza por uno sano','Quirurjico'),(40,20,'Ribavirina','La ribavirina también conocida como virazole es un nucleósido sintético en el que la base nitrogenada es la triazolcarboxamida','Medicamento'),(41,21,'Lubricante ocular','solución oftálmica indicado para el alivio temporal del ardor y la irritación que se manifiesta como consecuencia de la sequedad','Medicamento'),(42,21,'Tamiflu','Tamiflu contiene oseltamivir, el cual pertenece a un grupo de medicamentos denominados inhibidores de la neuraminidasa','Medicamento'),(43,22,'Acetilsalicílico','Se utiliza como medicamento para tratar el dolor, la fiebre y la inflamación','Medicamento'),(44,22,'Bromhexina','La bromhexina es un fármaco que actúa disminuyendo la viscosidad de la mucosidad bronquial facilitando la expectoración','Medicamento'),(45,23,'Naproxeno','El naproxeno es un medicamento antinflamatorio no esteroideo que se emplea en el tratamiento del dolor leve a moderado','Medicamento'),(46,23,'Cirugía de páncreas','Es una cirugía para drenar el líquido del páncreas o para eliminar el tejido enfermo','Quirurjico'),(47,24,'Diálisis','Es un tipo de terapia renal conjuntiva usada para proporcionar un reemplazo artificial','Quirurjico'),(48,24,'Trasplante de riñón','El trasplante de riñón o trasplante renal es el trasplante de un riñón en un paciente con enfermedad renal avanzada','Quirurjico'),(49,25,'Fluticasona','Fluticasona es un potente corticosteroide sintético prescrito en el tratamiento del asma y de la rinitis alérgica','Medicamento'),(50,25,'Budesónida','La budesónida es un medicamento glucocorticoide, de la familia de los corticosteroides','Medicamento'),(51,26,'Drenaje de la siringe','El médico insertará quirúrgicamente un sistema de drenaje, llamado derivación','Quirurjico'),(52,26,'Extracción de la obstrucción','i algo en la médula espinal, como un tumor o un bulto óseo, entorpece el flujo de líquido cefalorraquídeo','Quirurjico'),(53,27,'Intubación','comprende la colocación de un tubo de respiración a través de la nariz o la boca hasta la garganta para ayuda a las vias respira','Quirurjico'),(54,27,'ECMO','La Oxigenación por membrana extracorpórea, también conocida como ECMO proporciona soporte cardíaco y respiratorio','Quirurjico'),(55,28,'Azitromicina','Azitromicina es un antibiótico de amplio espectro del grupo de macrólidos que actúa contra varias bacterias','Medicamento'),(56,28,'cirugía de rotación de los párpa','El médico hace una incisión en la tapa cicatrizada y rota las pestañas alejándolas de la córnea.','Quirurjico'),(57,29,'Isoniacida','La isoniacida o isoniazida es un fármaco antituberculoso activo frente a Mycobacterium tuberculosis','Medicamento'),(58,29,'Pirazinamida','DescripciónLa pirazinamida es un antibiótico usado en tratamiento de la tuberculosis','Medicamento'),(59,30,'cirugia de ganglion','Durante este procedimiento, el médico extirpa el quiste y el tallo que lo une a la articulación o al tendón','Quirurjico'),(60,30,'Aspiración','En este procedimiento, el médico usa una aguja para drenar el líquido del quiste','Quirurjico'),(61,31,'cirugía de gangrena','El médico podría realizar un procedimiento quirúrgico para extraer el tejido muerto, lo que ayuda a evitar que se extienda','Quirurjico'),(62,31,'Oxigenoterapia','Al aumentar la presión y el contenido de oxígeno, la sangre puede transportar mayor cantidad de oxígeno','Quirurjico'),(63,32,'Claritromicina','La claritromicina es el nombre de un antibiótico del grupo de los macrólidos que se indica para el tratamiento de infecciones','Medicamento'),(64,32,'Lansoprazol','El lansoprazol es un medicamento del grupo de inhibidores de la bomba de protones que actúa a nivel del tracto gastrointestinal','Medicamento'),(65,33,'Latanoprost','El latanoprost es un medicamento que se utiliza en oftalmología y se aplica en forma de gotas que se instilan directamente','Medicamento'),(66,33,'Timolol','Timolol es el nombre de un medicamento beta bloqueante no selectivo, es decir, bloquea la acción de la epinefrina','Medicamento'),(67,34,'Metilprednisolona','Metilprednisolona, esteroide sintético, del grupo de los glucocorticoides que se utiliza en medicina por sus propiedades inmunos','Medicamento'),(68,34,'Micofenolato','Es un medicamento inmunosupresor derivado del Penicillium stoloniferum, y especies relacionadas, bloquea la síntesis','Medicamento'),(69,35,'Efavirenz','Efavirenz es un fármaco inhibidor de la transcriptasa inversa no análogo a los nucleósidos que se emplea','Medicamento'),(70,35,'Tenofovir','Tenofovir es un medicamento antiviral que se emplea para el tratamiento de la infección por el virus de la inmunodeficiencia','Medicamento'),(71,36,'Inmunoglobulina antirrábica','Una inyección de acción rápida para prevenir que el virus te infecte','Medicamento'),(72,36,'Vacunas antirrábicas','Una serie de vacunas para ayudar a que el cuerpo aprenda a identificar y combatir el virus de la rabia','Medicamento'),(73,37,'Broncoscopia','Durante la broncoscopia, el médico introduce con cuidado un tubo flexible por la garganta para limpiar las vías respiratorias','Quirurjico'),(74,37,'CPAP','La presión positiva continua en las vías respiratorias (CPAP) puede ser útil en algunas personas que están demasiado débiles','Quirurjico'),(75,38,'Colonoscopia','El médico puede ver el interior del colon mediante un tubo delgado con luz que se introduce en el recto','Quirurjico'),(76,38,'Tetraciclina','Las tetraciclinas constituyen un grupo de antibióticos, unos naturales y otros obtenidos por semisíntesis, que abarcan un amplio','Medicamento'),(77,39,'Maalox','Está indicado para el alivio y tratamiento sintomático de la acidez y ardor de estómago','Medicamento'),(78,39,'Dilatación esofágica','El médico puede usar un endoscopio con un globo especial conectado para estirar y expandir suavemente el ancho del esófago','Quirurjico'),(79,40,'Prednisona','Prednisona es un fármaco corticosteroide sintético que se toma usualmente en forma oral, pero puede ser administrado por vía','Medicamento'),(80,40,'PRP','Plasma rico en plaquetas, aplica tomar una muestra de tu sangre y centrifugarla para separar las plaquetas y componentes','Quirurjico'),(81,41,'Remdesivir','Es un medicamento antiviral, un nuevo profármaco 2? que pertenece a los nucleótidos. Se utiliza mediante inyecciones','Medicamento'),(82,41,'Inyección de tocilizumab','El uso de la inyección de tocilizumab puede reducir su capacidad para combatir infecciones por bacterias, virus y hongos','Medicamento');
/*!40000 ALTER TABLE `tratamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `verifica`
--

DROP TABLE IF EXISTS `verifica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `verifica` (
  `id_tentativo` int(10) NOT NULL DEFAULT '0',
  `id_medico` int(10) NOT NULL,
  PRIMARY KEY (`id_tentativo`),
  KEY `id_medico` (`id_medico`),
  CONSTRAINT `verifica_ibfk_1` FOREIGN KEY (`id_tentativo`) REFERENCES `diagnostico` (`id`),
  CONSTRAINT `verifica_ibfk_2` FOREIGN KEY (`id_medico`) REFERENCES `persona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `verifica`
--

LOCK TABLES `verifica` WRITE;
/*!40000 ALTER TABLE `verifica` DISABLE KEYS */;
INSERT INTO `verifica` VALUES (4,1),(1,10),(2,11),(5,12),(3,13),(11,16),(6,17),(10,19),(7,20),(16,20),(8,34),(9,34),(12,38),(14,40),(13,41),(21,52);
/*!40000 ALTER TABLE `verifica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vista_admin`
--

DROP TABLE IF EXISTS `vista_admin`;
/*!50001 DROP VIEW IF EXISTS `vista_admin`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vista_admin` (
  `id` tinyint NOT NULL,
  `ci` tinyint NOT NULL,
  `primerNom` tinyint NOT NULL,
  `segundoNom` tinyint NOT NULL,
  `primerApe` tinyint NOT NULL,
  `segundoApe` tinyint NOT NULL,
  `genero` tinyint NOT NULL,
  `fechaNacimiento` tinyint NOT NULL,
  `email` tinyint NOT NULL,
  `calle` tinyint NOT NULL,
  `npuerta` tinyint NOT NULL,
  `id_ciudad` tinyint NOT NULL,
  `usuario` tinyint NOT NULL,
  `contrasena` tinyint NOT NULL,
  `pin` tinyint NOT NULL,
  `muerto` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vista_medico`
--

DROP TABLE IF EXISTS `vista_medico`;
/*!50001 DROP VIEW IF EXISTS `vista_medico`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vista_medico` (
  `id` tinyint NOT NULL,
  `ci` tinyint NOT NULL,
  `primerNom` tinyint NOT NULL,
  `segundoNom` tinyint NOT NULL,
  `primerApe` tinyint NOT NULL,
  `segundoApe` tinyint NOT NULL,
  `genero` tinyint NOT NULL,
  `fechaNacimiento` tinyint NOT NULL,
  `email` tinyint NOT NULL,
  `calle` tinyint NOT NULL,
  `npuerta` tinyint NOT NULL,
  `id_ciudad` tinyint NOT NULL,
  `especialidad` tinyint NOT NULL,
  `usuario` tinyint NOT NULL,
  `contrasena` tinyint NOT NULL,
  `muerto` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vista_paciente`
--

DROP TABLE IF EXISTS `vista_paciente`;
/*!50001 DROP VIEW IF EXISTS `vista_paciente`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vista_paciente` (
  `id` tinyint NOT NULL,
  `ci` tinyint NOT NULL,
  `primerNom` tinyint NOT NULL,
  `segundoNom` tinyint NOT NULL,
  `primerApe` tinyint NOT NULL,
  `segundoApe` tinyint NOT NULL,
  `genero` tinyint NOT NULL,
  `fechaNacimiento` tinyint NOT NULL,
  `email` tinyint NOT NULL,
  `calle` tinyint NOT NULL,
  `npuerta` tinyint NOT NULL,
  `id_ciudad` tinyint NOT NULL,
  `habilitado` tinyint NOT NULL,
  `muerto` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Current Database: `TelediagnosticoMedico_HeartBits`
--

USE `TelediagnosticoMedico_HeartBits`;

--
-- Final view structure for view `vista_admin`
--

/*!50001 DROP TABLE IF EXISTS `vista_admin`*/;
/*!50001 DROP VIEW IF EXISTS `vista_admin`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_admin` AS select `persona`.`id` AS `id`,`persona`.`ci` AS `ci`,`persona`.`primerNom` AS `primerNom`,`persona`.`segundoNom` AS `segundoNom`,`persona`.`primerApe` AS `primerApe`,`persona`.`segundoApe` AS `segundoApe`,`persona`.`genero` AS `genero`,`persona`.`fechaNacimiento` AS `fechaNacimiento`,`persona`.`email` AS `email`,`persona`.`calle` AS `calle`,`persona`.`npuerta` AS `npuerta`,`persona`.`id_ciudad` AS `id_ciudad`,`persona`.`usuario` AS `usuario`,`persona`.`contrasena` AS `contrasena`,`persona`.`pin` AS `pin`,`persona`.`muerto` AS `muerto` from `persona` where (`persona`.`id_tipo` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_medico`
--

/*!50001 DROP TABLE IF EXISTS `vista_medico`*/;
/*!50001 DROP VIEW IF EXISTS `vista_medico`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_medico` AS select `persona`.`id` AS `id`,`persona`.`ci` AS `ci`,`persona`.`primerNom` AS `primerNom`,`persona`.`segundoNom` AS `segundoNom`,`persona`.`primerApe` AS `primerApe`,`persona`.`segundoApe` AS `segundoApe`,`persona`.`genero` AS `genero`,`persona`.`fechaNacimiento` AS `fechaNacimiento`,`persona`.`email` AS `email`,`persona`.`calle` AS `calle`,`persona`.`npuerta` AS `npuerta`,`persona`.`id_ciudad` AS `id_ciudad`,`persona`.`especialidad` AS `especialidad`,`persona`.`usuario` AS `usuario`,`persona`.`contrasena` AS `contrasena`,`persona`.`muerto` AS `muerto` from `persona` where (`persona`.`id_tipo` = 2) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vista_paciente`
--

/*!50001 DROP TABLE IF EXISTS `vista_paciente`*/;
/*!50001 DROP VIEW IF EXISTS `vista_paciente`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vista_paciente` AS select `persona`.`id` AS `id`,`persona`.`ci` AS `ci`,`persona`.`primerNom` AS `primerNom`,`persona`.`segundoNom` AS `segundoNom`,`persona`.`primerApe` AS `primerApe`,`persona`.`segundoApe` AS `segundoApe`,`persona`.`genero` AS `genero`,`persona`.`fechaNacimiento` AS `fechaNacimiento`,`persona`.`email` AS `email`,`persona`.`calle` AS `calle`,`persona`.`npuerta` AS `npuerta`,`persona`.`id_ciudad` AS `id_ciudad`,`persona`.`habilitado` AS `habilitado`,`persona`.`muerto` AS `muerto` from `persona` where (`persona`.`id_tipo` = 3) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-09 18:27:49
