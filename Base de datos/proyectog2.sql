-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: proyectog2
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumnos`
--

DROP TABLE IF EXISTS `alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alumnos` (
  `id_alumno` int NOT NULL AUTO_INCREMENT,
  `codigo` varchar(10) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellidos` varchar(100) DEFAULT NULL,
  `curso` varchar(20) DEFAULT NULL,
  `id_profesor` int DEFAULT NULL,
  PRIMARY KEY (`id_alumno`)
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumnos`
--

LOCK TABLES `alumnos` WRITE;
/*!40000 ALTER TABLE `alumnos` DISABLE KEYS */;
INSERT INTO `alumnos` VALUES (1,'A001','Lucía','González','5A',1),(2,'A002','Mateo','Ramírez','5A',1),(3,'A003','Valentina','Torres','5A',1),(4,'A004','Sebastián','Flores','5A',1),(5,'A005','Camila','Rojas','5A',1),(6,'A006','Diego','Castillo','5A',1),(7,'A007','María','Cruz','5A',1),(8,'A008','Daniel','Reyes','5A',1),(9,'A009','Antonella','Morales','5A',1),(10,'A010','Gabriel','Peña','5A',1),(21,'A011','Sofía','Ortega','5A',1),(22,'A012','Andrés','Pérez','5A',1),(23,'A013','Valeria','Lopez','5A',1),(24,'A014','Martín','Salazar','5A',1),(25,'A015','Julieta','Chávez','5A',1),(26,'A016','Thiago','Ramírez','5A',1),(27,'B001','Lucas','Fernández','5B',2),(28,'B002','Emma','Torres','5B',2),(29,'B003','Mateo','Cruz','5B',2),(30,'B004','Isabella','Soto','5B',2),(31,'B005','Santiago','Rojas','5B',2),(32,'B006','Mía','Navarro','5B',2),(33,'B007','Benjamín','Silva','5B',2),(34,'B008','Valentina','Aguilar','5B',2),(35,'B009','Martina','Vega','5B',2),(36,'B010','Diego','Campos','5B',2),(37,'B011','Gabriel','Suárez','5B',2),(38,'B012','Zoe','Mendoza','5B',2),(39,'B013','Facundo','Ortega','5B',2),(40,'B014','Julia','Herrera','5B',2),(41,'B015','Valeria','Reyes','5B',2),(42,'C001','Nicolás','Guzmán','6A',4),(43,'C002','Valeria','Montoya','6A',4),(44,'C003','Tomás','Paredes','6A',4),(45,'C004','Isabella','Ramos','6A',4),(46,'C005','Camilo','Vera','6A',4),(47,'D001','Agustín','Quispe','4B',5),(48,'D002','Emilia','Sandoval','4B',5),(49,'D003','Santiago','Mora','4B',5),(50,'D004','Sofía','Huerta','4B',5),(51,'D005','Martín','Villanueva','4B',5),(52,'E001','Mateo','Arce','3C',6),(53,'E002','Antonella','León','3C',6),(54,'E003','Benjamín','Paz','3C',6),(55,'E004','Josefina','Gallardo','3C',6),(56,'E005','Thiago','Solís','3C',6),(57,'C006','Diego','Salazar','6A',4),(58,'C007','Lucía','Mendoza','6A',4),(59,'C008','Sebastián','Ortega','6A',4),(60,'C009','Martina','Vargas','6A',4),(61,'C010','Tomás','Fuentes','6A',4),(62,'C011','Valentina','Reyes','6A',4),(63,'C012','Facundo','Pérez','6A',4),(64,'C013','Mía','Gómez','6A',4),(65,'C014','Joaquín','Acosta','6A',4),(66,'C015','Emilia','Rojas','6A',4),(67,'D006','Lucas','Pacheco','4B',5),(68,'D007','Sofía','Salinas','4B',5),(69,'D008','Pedro','Silva','4B',5),(70,'D009','Camila','Muñoz','4B',5),(71,'D010','Agustín','Peña','4B',5),(72,'D011','Isabella','Peralta','4B',5),(73,'D012','Martín','Guevara','4B',5),(74,'D013','Catalina','Santos','4B',5),(75,'D014','Mateo','Carrillo','4B',5),(76,'D015','Florencia','Cáceres','4B',5),(77,'E006','Gabriel','Rosales','3C',6),(78,'E007','Julieta','Morales','3C',6),(79,'E008','Emmanuel','García','3C',6),(80,'E009','Zoe','Hernández','3C',6),(81,'E010','Samuel','Castro','3C',6),(82,'E011','Bianca','Reyna','3C',6),(83,'E012','Tomás','Escobar','3C',6),(84,'E013','Renata','Miranda','3C',6),(85,'E014','Valentino','González','3C',6),(86,'E015','Josefina','López','3C',6);
/*!40000 ALTER TABLE `alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencias`
--

DROP TABLE IF EXISTS `asistencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencias` (
  `id_asistencia` int NOT NULL AUTO_INCREMENT,
  `id_alumno` int DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `presente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_asistencia`),
  UNIQUE KEY `unq_alumno_fecha` (`id_alumno`,`fecha`),
  CONSTRAINT `asistencias_ibfk_1` FOREIGN KEY (`id_alumno`) REFERENCES `alumnos` (`id_alumno`)
) ENGINE=InnoDB AUTO_INCREMENT=675 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencias`
--

LOCK TABLES `asistencias` WRITE;
/*!40000 ALTER TABLE `asistencias` DISABLE KEYS */;
INSERT INTO `asistencias` VALUES (1,27,'2025-07-05',1),(2,28,'2025-07-05',1),(3,29,'2025-07-05',1),(4,30,'2025-07-05',1),(5,31,'2025-07-05',0),(6,32,'2025-07-05',0),(7,33,'2025-07-05',0),(8,34,'2025-07-05',1),(9,35,'2025-07-05',1),(10,36,'2025-07-05',0),(11,37,'2025-07-05',0),(12,38,'2025-07-05',0),(13,39,'2025-07-05',0),(14,40,'2025-07-05',0),(15,41,'2025-07-05',0),(481,47,'2025-07-05',0),(482,48,'2025-07-05',0),(483,49,'2025-07-05',0),(484,50,'2025-07-05',0),(485,51,'2025-07-05',0),(486,67,'2025-07-05',0),(487,68,'2025-07-05',0),(488,69,'2025-07-05',0),(489,70,'2025-07-05',0),(490,71,'2025-07-05',0),(491,72,'2025-07-05',0),(492,73,'2025-07-05',0),(493,74,'2025-07-05',0),(494,75,'2025-07-05',0),(495,76,'2025-07-05',0),(517,42,'2025-07-05',0),(518,43,'2025-07-05',0),(519,44,'2025-07-05',0),(520,45,'2025-07-05',0),(521,46,'2025-07-05',0),(522,57,'2025-07-05',0),(523,58,'2025-07-05',0),(524,59,'2025-07-05',0),(525,60,'2025-07-05',0),(526,61,'2025-07-05',0),(527,62,'2025-07-05',0),(528,63,'2025-07-05',0),(529,64,'2025-07-05',0),(530,65,'2025-07-05',0),(531,66,'2025-07-05',0),(537,1,'2025-07-05',1),(538,2,'2025-07-05',1),(539,3,'2025-07-05',0),(540,4,'2025-07-05',1),(541,5,'2025-07-05',1),(542,6,'2025-07-05',0),(543,7,'2025-07-05',1),(544,8,'2025-07-05',1),(545,9,'2025-07-05',0),(546,10,'2025-07-05',0),(547,21,'2025-07-05',0),(548,22,'2025-07-05',0),(549,23,'2025-07-05',0),(550,24,'2025-07-05',0),(551,25,'2025-07-05',0),(552,26,'2025-07-05',0),(615,42,'2025-07-06',1),(616,43,'2025-07-06',1),(617,44,'2025-07-06',0),(618,45,'2025-07-06',0),(619,46,'2025-07-06',1),(620,57,'2025-07-06',1),(621,58,'2025-07-06',1),(622,59,'2025-07-06',1),(623,60,'2025-07-06',0),(624,61,'2025-07-06',0),(625,62,'2025-07-06',0),(626,63,'2025-07-06',1),(627,64,'2025-07-06',1),(628,65,'2025-07-06',1),(629,66,'2025-07-06',1),(645,27,'2025-07-07',1),(646,28,'2025-07-07',1),(647,29,'2025-07-07',0),(648,30,'2025-07-07',0),(649,31,'2025-07-07',1),(650,32,'2025-07-07',1),(651,33,'2025-07-07',0),(652,34,'2025-07-07',1),(653,35,'2025-07-07',0),(654,36,'2025-07-07',1),(655,37,'2025-07-07',1),(656,38,'2025-07-07',1),(657,39,'2025-07-07',0),(658,40,'2025-07-07',0),(659,41,'2025-07-07',0);
/*!40000 ALTER TABLE `asistencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(50) NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `correo` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','1234',NULL,NULL,NULL),(2,'Alberth','123','Alberth','Miranda','alberth@colegio.com'),(4,'Zavala','1234','Javier','Zavala','zavala@colegio.com'),(5,'Cohen','1234','Cristian','Cohen','cohen@colegio.com'),(6,'Brandon','1234','Brandon','Pilco','brandon@colegio.com');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-07-07  8:07:28
