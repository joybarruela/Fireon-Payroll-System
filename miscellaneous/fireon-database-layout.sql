CREATE DATABASE  IF NOT EXISTS `fireon` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `fireon`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: fireon
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `tbl_account`
--

DROP TABLE IF EXISTS `tbl_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_account` (
  `accountID` int NOT NULL AUTO_INCREMENT,
  `accountUsername` varchar(32) DEFAULT NULL,
  `accountPassword` varchar(32) DEFAULT NULL,
  `accountType` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`accountID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_account`
--

LOCK TABLES `tbl_account` WRITE;
/*!40000 ALTER TABLE `tbl_account` DISABLE KEYS */;
INSERT INTO `tbl_account` VALUES (1,'Super User','123123123','Super User');
/*!40000 ALTER TABLE `tbl_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_document_locations`
--

DROP TABLE IF EXISTS `tbl_document_locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_document_locations` (
  `docID` int NOT NULL,
  KEY `docEmployeeID_idx` (`docID`),
  CONSTRAINT `docEmployeeID` FOREIGN KEY (`docID`) REFERENCES `tbl_employee` (`employeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_document_locations`
--

LOCK TABLES `tbl_document_locations` WRITE;
/*!40000 ALTER TABLE `tbl_document_locations` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_document_locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_employee`
--

DROP TABLE IF EXISTS `tbl_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_employee` (
  `employeeID` int NOT NULL AUTO_INCREMENT,
  `employeeFirstName` varchar(120) DEFAULT NULL,
  `employeeMiddleInitial` varchar(3) DEFAULT NULL,
  `employeeLastName` varchar(120) DEFAULT NULL,
  `employeeSex` varchar(6) DEFAULT NULL,
  `employeeContactNumber` bigint DEFAULT NULL,
  `employeeEmailAddress` varchar(120) DEFAULT NULL,
  `employeeHomeAddress` varchar(200) DEFAULT NULL,
  `employeeBirthdate` date DEFAULT NULL,
  `employeeMaritalStatus` varchar(9) DEFAULT NULL,
  `employeeNationality` varchar(45) DEFAULT NULL,
  `employeeDepartment` varchar(45) DEFAULT NULL,
  `employeePosition` varchar(45) DEFAULT NULL,
  `employeeStatus` varchar(45) DEFAULT NULL,
  `employeeWorkingHours` int DEFAULT NULL,
  `employeeHourlyRate` int DEFAULT NULL,
  `employeeContractDuration` int DEFAULT NULL,
  `employeePaymentMode` varchar(45) DEFAULT NULL,
  `employeeImageLocation` varchar(255) DEFAULT NULL,
  `employeeDateEmployed` date DEFAULT NULL,
  PRIMARY KEY (`employeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee`
--

LOCK TABLES `tbl_employee` WRITE;
/*!40000 ALTER TABLE `tbl_employee` DISABLE KEYS */;
INSERT INTO `tbl_employee` VALUES (6,'ALIANA JESSICA','K','RIVERA','Female',9923458634,'ALIANAJESSICA@GMAIL.COM','ROOM 11 G/F MAYA BUILDING, 678 EDSA, CUBAO','1995-07-07','Married','FILIPINO','Administrative','Administrative Manager','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(7,'BARTOLI KAIDEN','S','SOLER','Male',9213872187,'BARTOLIKAIDEN@GMAIL.COM','SUITE 1511 15/F HERRERA TOWER98 HERRERA CORNER VALERIO STREET SALCEDO VILLAGE 1227','1990-08-17','Widowed','FILIPINO','Administrative','Administrative Assistant Director','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(8,'AYLIN CHRISANNE','A','ZABALA','Female',9432878764,'AYLINCHRISANNE@GMAIL.COM','MIRMAR HOUSE DOMESTIC DRIVE 1300 PASAY CITY','1989-01-04','Separated','FILIPINO','Administrative','Administrative Coordinator','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(9,'KIERAN ELIAS','N','BARRAMEDA','Male',9869414616,'KEIRANELIAS@GMAIL.COM','5/F SNL BUILDING 1500 ROXAS BOULEVARD MANILA','1979-07-17','Divorced','FILIPINO','Administrative','Administrative Director','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(10,'ALANA LEOPOLDO','Q','CEREZO','Male',9243511122,'ALANALEOPOLDO@GMAIL.COM','3/F EQUITABLE BANK BUILDING 898 AURORA BOULIVARD CORNER STANFORD STREET CUBAO','1994-06-06','Single','FILIPINO','Administrative','Administrative Specialist','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(11,'DEIGA BRIANNE','P','LAVARES','Female',9959261879,'DEIGABRIANNE@GMAIL.COM','153 J. RIZAL STREET, MANDAUE CITY CEBU','1989-10-16','Married','FILIPINO','Administrative','Administrator','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(12,'TYREE RHETT','P','REIGO','Female',9984651894,'TYREERHETT@GMAIL.COM','MERCURY AVENUE CORNER E. RODRIGQUEZ JUNIOR AVENUE KEYNET COMPOUND QUEZON CITY','1993-06-15','Widowed','FILIPINO','Administrative','Secretary','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(13,'KALEIGH LANEY','C','MONTEVERDE','Female',9949416853,'KALEIGNLANEY@GMAIL.COM','CASA ROCHA 290-292 HENERAL LUNA STREET INTRAMUROS MANILA','1998-07-31','Separated','FILIPINO','Administrative','Services Manager','Regular',216,350,0,'Cheque',NULL,'2020-12-18'),(14,'MADALENA ELODIA','M','PIATOS','Female',9894665998,'MADALENAELODIA@GMAIL.COM','7805 ST. PAUL CORNER MAYAPIS STREET SAN ANTONIO VILLAGE MAKATI CITY','1996-12-04','Divorced','FILIPINO','Customer Service','Call Center Customer Support','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(15,'CORINNE DEVYN','D','CUENCO','Female',9613879824,'CORINNE DEVYN','746 RIZAL AVENUE EXTENSION BONIFACIO CIRCLE MONUMENTO CALOOCAN CITY','2000-01-01','Single','FILIPINO','Customer Service','Customer Care Operator','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(16,'CAMERON KESEY','W','LAZARO','Male',9874317998,'CAMERONKESEY@GMAIL.COM','1543 A.C. CORTEZ, MANDAUE CITY CEBU','1993-05-17','Married','FILIPINO','Customer Service','Customer Experience Specialist','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(17,'KARLA MAGALYS','S','DULCE','Female',9885454515,'KARLAMAGALYS@GMAIL.COM','JOMON BUILDING BRIXTON STREET 1600 KAPITOLYO PASIG CITY','1989-06-15','Widowed','FILIPINO','Customer Service','Customer Interaction Management Specialist','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(18,'CANDLE LUELLA','M','BELLEZA','Female',9673452343,'CANDLELUELLA@GMAIL.COM','31 A.J. ESCALER STREET LOYOLA HEIGHTS QUEZON CITY MANILA','1998-09-05','Separated','FILIPINO','Customer Service','Customer Service Agent','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(19,'DELMAR CHAYO','S','QUEZADA','Male',9321649497,'DELMARCHAYO@GMAIL.COM','ROOM 11 G/F/ MAYA BUILDING, 678 EDSA, CUBAO MANILA','1999-11-11','Divorced','FILIPINO','Customer Service','Customer Support Associate','Regular',216,180,0,'Bank Draft',NULL,'2020-12-18'),(20,'CASSIDY CELINE','S','MATIAS','Female',9855125412,'CASSIDYCELINE@GMAIL.COM','7/F THE ATHENAEUM BUILDING 160 ALFARO STREET SALCEDO HOMES MAKATI CITY','2000-06-14','Single','FILIPNIO','Finance','Accountant','Regular',216,220,0,'Cheque',NULL,'2020-12-18'),(21,'CARMELA ROSLYN','D','CAPISTRANO','Female',9564504338,'CARMELAROSLYN@GMAIL.COM','#2 SUSANO ROAD DEPARO NOVALICHES CALOOCAN CITY','1994-07-08','Widowed','FILIPINO','Finance','Assistant Accountant','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(22,'BRAXTON JEFFERSON','C','CEREZA','Male',9441564900,'BRAXTONJEFF@GMAIL.COM','UNIT 2505 CITYLAND TOWER 1 AYALA AVENUE SALCEDO HOMES MAKATI CITY','1995-06-20','Single','FILIPINO','Finance','Financial Analyst','Regular',216,230,0,'Cash Payment',NULL,'2020-12-18'),(23,'DARRYL MICAH','N','PAMPLONA','Male',9872173213,'DARRLYMIC@GMAIL.COM','UNIT 506 SOUTH GATE BUILDING TOPAZ STREET MADRIGAL MUNTINLUPA CITY','1988-12-06','Divorced','FILIPNIO','Finance','Payroll Assistant','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(24,'SHAWN DARREN','L','ESCRIBANO','Male',9432843284,'SHAWNDARREN@GMAIL.COM','UNIT 7 UP/F FARMERS PLAZA AURORA BOULEVARD CUBAO QUEZON CITY','1994-06-22','Widowed','FILIPINO','Finance','Payroll Clerk','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(25,'MADINA BRISA','B','SOLAS','Female',9611620054,'MADINABRISA@GMAIL.COM','523 JUAN LUNA STREET BINONDO MANILA','1987-10-29','Single','FILIPINO','Human Resource','Human Resource Administrator','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(26,'SAVANNAH DOMINICA','K','FELONGCO','Female',9044120154,'SAVDOM@GMAIL.COM','8B QUAD PARK SQUARE BUILDING AYALA CENTER 1200 MAKATI CITY','1989-01-05','Single','FILIPINO','Human Resource','Human Resource Analyst','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(27,'ZITA SAVANA','Y','OUANO','Female',9845685154,'ZITASAV@GMAIL.COM','296 ROOSEVELT AVENUE SAN FRANCISCO DEL MONTE QUEZON CITY','2000-05-15','Single','FILIPINO','Human Resource','Human Resource Assistant','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(28,'SIRITO JOELLE','M','OLARTE','Male',9975325403,'SIRJOE@GMAIL.COM','BLOCK 46 LOT 12 DIAMOND STREET ROXAS AVENUE MAHAYAHAY VILLAGE ILIGAN LANAO DEL NORTE','1994-06-17','Single','FILIPINO','Human Resource','Human Resource Associate','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(29,'BRANDI ARAT','D','SORIANO','Male',9612675830,'LIQUORTRA@GMAIL.COM','15 MOSOLA STREET 1115 QUEZON CITY','1989-07-12','Married','FILIPINO','Human Resource','Human Resource Director','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(30,'KYLE TERRENCE','M','HONTIVEROS','Male',9896140825,'KYLETERR@GMAIL.COM','UNIT 5 SATNA AGUENDA COMMERCIAL APPARETMENT PARANAQUE CITY','1996-08-23','Single','FILIPINO','Human Resource','Human Resource Generalist','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(31,'YAZMIN ZANDRA','P','MERCADO','Female',9824082450,'YAZZAN@GMAIL.COM','SOUTH TYLER HIGHWAY 128 SUN VALLEY DRIVE PARANAQUE CITY','2000-04-04','Separated','FILIPINO','Human Resource','Human Resource Manager','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(32,'JUANITO LEONEL','G','AYALA','Male',9050501532,'JUANLEO@GMAIL.COM','1807 WEST TOWER PSE CENTRE EXCHANGE ROAD MAIN PASIG CITY','1995-06-13','Divorced','FILIPINO','Human Resource','Human Resource Specialist','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(33,'ADEN REMINGTON','A','LABRADOR','Male',9848255085,'ADENREM@GMAIL.COM','2/F LE METROPOLE BUILDING SENATOR GIL PUYAT AVENUE MAKATI CITY','1994-03-04','Single','FILIPINO','Human Resource','Human Resource Specialist','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(34,'JADE BEATRICE','B','ATAYDE','Male',9860055456,'JADEBEA@GMAIL.COM','110 AGUIRRE STREET LEGASTPI VILLAGE MAKATI CITY','1993-02-02','Single','FILIPINO','Human Resource','Human Resource Supervisor','Regular',216,220,0,'Bank Draft',NULL,'2020-12-18'),(35,'EMMELINE LILIANA','Y','MONTELOYOLA','Female',9085175015,'EMMELIA@GMAIL.COM','20-22 TIGANAN CORNER MAUBAN STREET 1100 QUEZON CITY','1999-11-09','Single','FILIPINO','Information Technology','Application Developer','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(36,'JOSUE FRANKIE','C','VILLEGAS','Male',9781701818,'JOSEFRANK@GMAIL.COM','ROOM 502 PIECO BUILDING PASONG TAMO EXTENSION MAKATI CITY','2000-06-20','Single','FILIPINO','Information Technology','IT Support Specialist','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(37,'DEVYN DALE','D','CAHUELA','Male',9081282050,'DEVDALE@GMAIL.COM','WHARFSIDE FISH PORT COMPLEX 1485 NAVOTAS CITY','1998-10-20','Single','FILIPINO','Information Technology','IT Director','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(38,'GAVYN NOE','C','CLEMENTE','Male',9085548185,'GAVNOE@GMAIL.COM','UNIT J VILLA FRIENZE ALVIR STREET LITTLE BAGUIO SAN JUAN CITY','1996-06-18','Married','FILIPINO','Information Technology','IT Support Specialist','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(39,'CYRUS JEURELL','V','OJEDA','Male',9696906969,'SAIRASUJEURELL@GMAIL.COM','BLOCK 4 LOT 60 PRINCETOWN SUBDIVISION BAGUMBONG CALOOCAN CITY','2000-10-01','Married','FILIPINO','Information Technology','IT Technician','Regular',216,269,0,'Cash Payment',NULL,'2020-12-18'),(40,'JAYNZPHER','O','VILLANUEVA','Male',9696906969,'JAYNZPHERSAI@GMAIL.COM','BLOCK 4 LOT 60 PRINCETOWN SUBDIVISION BAGUMBONG CALOOCAN CITY','1996-06-06','Married','FILIPINO','Information Technology','IT Technician','Regular',216,269,0,'Cash Payment',NULL,'2020-12-18'),(41,'ADRIENNE EMESTA','P','ESPINOSA','Female',9716752805,'ADRINEEMST@GMAIL.COM','BLOCK 4 LOT 23 ADB AVENUE 1550 MANDALUYONG CITY','1999-06-16','Single','FILIPINO','Information Technology','Network Administrator','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(42,'VETA LAURA','M','AUSTRIA','Female',9087548315,'VETALAU@GMAIL.COM','24 SAN PABLO STREET KAPITOLYO 1600 PASIG CITY','1997-11-27','Single','FILIPINO','Information Technology','Security Specialist','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(43,'FRESCURA LINDA','B','QUIZONO','Female',9763298432,'FRESLIN@GMAIL.COM','BLOCK 56 LOT 23 KAUNLARAN VILLAGE TABING ILOG PHASE 1-C NAVOTAS CITY','1989-04-29','Single','FILIPINO','Information Technology','System Analyst','Regular',216,260,0,'Bank Draft',NULL,'2020-12-18'),(44,'CLIFFORD TATE','M','SILVESTRE','Male',9708751520,'CLIFFTATE@GMAIL.COM','92 NEW YORK STREET CUBAO 1100 QUEZON CITY','1993-05-10','Divorced','FILIPINO','Information Technology','Web Developer','Contractual',108,200,6,'Cheque',NULL,'2020-12-18'),(45,'MARTIN MICHAEL','A','LEGASPI','Male',9720756786,'MARTINMICHAEL@GMAIL.COM','UNIT 115 MANILA EXECUTIVE REGENCY J.BOCOBO STREET ERMILITA VILLAGE MANILA','1966-07-21','Married','FILIPINO','Legal','Attorney','Regular',216,380,0,'Cheque',NULL,'2020-12-18'),(46,'VINA LANDRADA','C','ZABALA','Female',9051710410,'VINALANDRADA@GMAIL.COM','301 MARIO CO BUILDING 1945 M.ADRIATICO STREET MALATE MAKATI CITY','1986-12-31','Married','FILIPINO','Legal','Legal Analyst','Regular',216,380,0,'Cheque',NULL,'2020-12-18'),(47,'MICHEAL SHELDON','D','DOMINGUEZ','Male',9087218721,'MIKESHEL@GMAIL.COM','38 BULLETIN STREET WEST TRIANGLE 1100','1983-11-30','Widowed','FILIPINO','Legal','Law Firm Administrator','Regular',216,380,0,'Cheque',NULL,'2020-12-18'),(48,'SHEILA NORA','Q','IGNACIO','Female',9105104014,'SHEILANORA@GMAIL.COM','3/F GASTON BUILDING J.ELIZALDE STREET BF HOMES PARANAQUE MANILA','1988-09-20','Single','FILIPINO','Sales','Sales Manager','Regular',216,200,0,'Bank Draft',NULL,'2020-12-18'),(49,'JOLIE KARINA','L','FORMALOUZA','Female',9270724015,'JOLIEKARINA@GMAIL.COM','4/F NARRA BUILDING 2276 PASONG TAMO EXTENSION BARANGGAY 175 MAKATI CITY METRO MANILA','1998-10-07','Single','FILIPINO','Research and Development','R&D Specialist','Contractual',100,200,12,'Cheque',NULL,'2020-12-18'),(50,'LAUREN MARISOL','DAY','OPULENCIA','Female',9321431983,'LAURENMARI@GMAIL.COM','175 LAKANDULA STREET BARANGGAY POBLACION MARIVELES BATAAN CITY','1994-09-26','Single','FILIPINO','Operation','Operations Manager','Regular',216,200,0,'Bank Draft',NULL,'2020-12-18'),(51,'ALDEN MAXWELL','J','SANDOVAL','Male',9054215746,'ALDENMAX@GMAIL.COM','4TH STREET AREA 4 FOURTH ESTATE SUBDIVISION 1700 PARANAQUE CITY','1993-05-03','Single','FILIPINO','Production','Production Manager','Regular',216,150,0,'Bank Draft',NULL,'2020-12-18'),(52,'TULIA LESLY','P','DUARNA','Female',9052864208,'TULIALESLY@GMAIL.COM','BLOCK 3 LOT 93 THE PENNINSULA MANILA AYALA AVENUE MAKATI CITY','1992-08-01','Single','FILIPINO','Purchasing','Purchasing Manager','Regular',216,200,0,'Bank Draft',NULL,'2020-12-18'),(53,'JEFFERY RUFO','S','VILELA','Male',9045170750,'JEFFRUFO@GMAIL.COM','GA TOWER II 1156 EDSA MANDALUYONG CITY','1988-11-27','Widowed','FILIPINO','Production','Machinist','Regular',216,200,0,'Cash Payment',NULL,'2020-12-18'),(54,'LUCILA NORBERTO','S','COSTALES','Male',9087518518,'LUCILANORBERTO@GMAIL.COM','UP/F 39 ALFARO PALACE L.P.LEVISTE BLOOMFIELDS VILLAGE MAKATI CITY','1988-12-07','Single','FILIPINO','Operation','Logistics Manager','Regular',216,220,0,'Cheque',NULL,'2020-12-18'),(55,'NYAH JALYN','S','INFANTE','Female',9181750756,'NYAHJALYN@GMAIL.COM','11 DE CASTRO AVENUE DE CASTRO SUBDIVISION STA LUCIA HOMES PASIG CITY','1965-12-16','Married','FILIPINO','Operation','Facilities Coordinator','Regular',216,220,0,'Cheque',NULL,'2020-12-18'),(56,'VIBIESCA','E','SERGE','Male',9326154110,'21VIBIESCA@GMAIL.COM','QWEQWEQWE','2000-08-21','Single','ASD','Administrative','Administrative Manager','Contractual',123,123,123,'Bank Draft',NULL,'2020-12-21'),(57,'MARIE JOY','B','BARRUELA','Female',9195207555,'QWE','QWE','2000-08-30','Single','QWE','Administrative','Administrative Manager','Regular',216,123,0,'Bank Draft',NULL,'2020-12-21'),(58,'ASD','SD','ASD','Male',22222222222,'ASD','ASD','2020-12-01','Widowed','ASD','Sales','Sales Collection Agent','Regular',216,213213,0,'Bank Draft',NULL,'2020-12-21'),(59,'WWW','WWW','WWW','Male',22222222222,'QWE','QWE','2020-12-03','Widowed','QWE','Customer Service','Customer Care Operator','Regular',216,123,0,'Bill of Exchange',NULL,'2020-12-21'),(60,'XXX','XXX','XXX','Male',22222222222,'XXX','XXX','2020-12-01','Separated','XXX','Customer Service','Customer Care Operator','Contractual',222,222222,222,'Bank Draft',NULL,'2020-12-21'),(61,'ZZZZZZZZZZ','ZZZ','ZZZ','Male',22222222222,'ZZ22','ZZZ','2020-12-03','Widowed','ZZZZZZZZZZZZ','Customer Service','Customer Care Operator','Regular',216,222,0,'Cash Payment',NULL,'2020-12-21'),(62,'XXX','XXX','XXX','Male',22222222222,'SSS','SSS','2020-12-04','Single','SSS','Customer Service','Customer Care Operator','Regular',216,222,0,'Bill of Exchange',NULL,'2020-12-21'),(63,'XXXXXXXXXXX','XXX','XXXXXXXXXXX','Male',11111111111,'1111','1111','2020-01-24','Married','WEWE','Customer Service','Customer Care Operator','Contractual',222,222222,222,'Bill of Exchange','D:\\Short-Animation\\miscellaneous\\mockup\\processed-frames\\ms-animation-workplace_frame-1.png','2020-12-21'),(64,'DDDD','DDD','DDD','Male',22222222222,'DDD','DDD','2020-12-16','Widowed','DDD','Administrative','Administrative Coordinator','Regular',216,222,0,'Cash Payment','D:\\Short-Animation\\miscellaneous\\mockup\\processed-frames\\ms-animation-workplace_title-frame.png','2020-12-21');
/*!40000 ALTER TABLE `tbl_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'fireon'
--

--
-- Dumping routines for database 'fireon'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-22 20:49:08
