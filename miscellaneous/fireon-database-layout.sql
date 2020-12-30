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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_account`
--

LOCK TABLES `tbl_account` WRITE;
/*!40000 ALTER TABLE `tbl_account` DISABLE KEYS */;
INSERT INTO `tbl_account` VALUES (1,'Super User','123123123','Super User'),(15,'qwe','qwe','Normal User');
/*!40000 ALTER TABLE `tbl_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_allowance`
--

DROP TABLE IF EXISTS `tbl_allowance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_allowance` (
  `allowanceID` int NOT NULL AUTO_INCREMENT,
  `allowanceName` varchar(45) DEFAULT NULL,
  `allowanceAmount` int DEFAULT '0',
  PRIMARY KEY (`allowanceID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_allowance`
--

LOCK TABLES `tbl_allowance` WRITE;
/*!40000 ALTER TABLE `tbl_allowance` DISABLE KEYS */;
INSERT INTO `tbl_allowance` VALUES (7,'Food Allowance',500);
/*!40000 ALTER TABLE `tbl_allowance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_deduction`
--

DROP TABLE IF EXISTS `tbl_deduction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_deduction` (
  `deductionID` int NOT NULL AUTO_INCREMENT,
  `deductionName` varchar(45) DEFAULT NULL,
  `deductionPercentage` float DEFAULT NULL,
  PRIMARY KEY (`deductionID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_deduction`
--

LOCK TABLES `tbl_deduction` WRITE;
/*!40000 ALTER TABLE `tbl_deduction` DISABLE KEYS */;
INSERT INTO `tbl_deduction` VALUES (3,'SSS',3.63),(4,'PhilHealth',2.75),(5,'PagIBIG',2);
/*!40000 ALTER TABLE `tbl_deduction` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee`
--

LOCK TABLES `tbl_employee` WRITE;
/*!40000 ALTER TABLE `tbl_employee` DISABLE KEYS */;
INSERT INTO `tbl_employee` VALUES (76,'SERGE','E','VIBIESCA','Male',9326154110,'21VIBIESCA@GMAIL.COM','ADDRESS','2000-08-21','Single','FILIPINO','Customer Service','Customer Care Operator','Regular',216,100,0,'Bill of Exchange',NULL,'2020-12-27'),(77,'MARIE JOY','B','BARRUELA','Female',9195207555,'MJOYBARRUELA@GMAIL.COM','ADDRESS','2000-08-31','Single','FILIPINO','Customer Service','Customer Care Operator','Regular',216,200,0,'Cash Payment',NULL,'2020-12-27'),(78,'CYRUS JEURELL','Y','VILLANUEVA','Male',9131274161,'SAISASU@GMAIL.COM','ADDRESS','2000-10-01','Married','FILIPINO','Administrative','Administrative Assistant Director','Regular',216,300,0,'Bill of Exchange',NULL,'2020-12-27'),(79,'MARY ROSE','B','BRIGOLI','Female',9137127412,'BRIGS@GMAIL.COM','ADDRESS','2000-07-07','Married','FILIPINO','Customer Service','Customer Care Operator','Regular',216,222,0,'Cash Payment',NULL,'2020-12-27'),(80,'SONNY','S','MOORE','Male',9421894842,'SONNY@GMAIL.COM','ADDRESS','1990-06-14','Single','AMERICAN','Administrative','Administrative Coordinator','Regular',216,150,0,'Cheque','D:\\Fireon-Payroll-System\\Fireon\\Resources\\miscellaneous\\miscEmployeeDP.png','2020-12-28'),(81,'NICOLE MAE','','GARCIA','Female',9123178213,'NICOLE@GMAIL.COM','ADDRESS','1999-12-25','Married','FILIPINO','Customer Service','Customer Experience Specialist','Contractual',213,200,3,'Bill of Exchange',NULL,'2020-12-29'),(82,'FELIX','','KJELLBERG','Male',9123312313,'PEWDIEPIE@GMAIL.COM','SWEDEN','1990-06-12','Married','SWEDISH','Marketing','Marketing Director','Regular',216,333,0,'Cheque',NULL,'2020-12-30'),(83,'MICHAEL','','JACKSON','Male',9321312223,'JACKSON@GMAIL.COM','ADDRESS','1800-01-01','Married','AMERICAN','Customer Service','Retail Associate','Regular',216,222,0,'Bill of Exchange',NULL,'2020-12-30'),(84,'MAINE','G','MENDOZA','Female',9321321313,'MAINE@GMAIL.COM','ADDRESS','1990-07-19','Single','FILIPINO','Human Resource','Human Resource Associate','Contractual',100,333,333,'Bank Draft',NULL,'2020-12-30'),(85,'PEDRO','','MARDIGAL','Male',9837621833,'PMADRIGAL@GMAIL.COM','ADDRESS','2020-12-10','Married','FILIPINO','Customer Service','Customer Care Operator','Regular',216,222,0,'Cash Payment',NULL,'2020-12-30'),(86,'ALDEN','F','RICHARDS','Male',9321313131,'AR@GMAIL.COM','ADDRESS','2000-02-01','Married','FILIPINO','Administrative','Administrative Assistant Director','Contractual',333,333,333,'Bank Draft',NULL,'2020-12-30'),(87,'ASD','ASD','ASD','Male',9312312321,'ASD','ADDRESS','2020-12-01','Married','FILIPINO','Administrative','Administrative Coordinator','Contractual',333,333,111,'Bank Draft','C:\\Users\\51\\Desktop\\paint 3d\\12345678.png','2020-12-30'),(88,'E','QWE','QWE','Male',9231313133,'QWE','QWE','2020-12-08','Separated','QWE','Customer Service','Call Center Customer Support','Contractual',123,123,123,'Bill of Exchange',NULL,'2020-12-30'),(89,'SD','ASD','ASD','Male',23133213123,'QWE','QWE','2020-12-02','Widowed','EQE','Customer Service','Customer Care Operator','Regular',216,213,0,'Cheque',NULL,'2020-12-30'),(90,'ASD','DA','ASD','Male',12331231321,'12312213','32133213','2020-12-10','Separated','EWQEQEW','Customer Service','Customer Care Operator','Regular',216,123,0,'Bill of Exchange',NULL,'2020-12-30');
/*!40000 ALTER TABLE `tbl_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_employee_details`
--

DROP TABLE IF EXISTS `tbl_employee_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_employee_details` (
  `idtbl_employee_details` int NOT NULL,
  `employeeDetailsID` int NOT NULL AUTO_INCREMENT,
  `leaveSickLeave` int DEFAULT '30',
  `leaveVacationLeave` int DEFAULT '60',
  `leaveMaternityLeave` int DEFAULT '180',
  `overtimeAdditionalHours` int DEFAULT '0',
  `holidayHolidayPay` int DEFAULT '0',
  `violationViolationAmount` int DEFAULT '0',
  `cashAdvanceAmount` int DEFAULT '0',
  `payrollTotalWorkingHours` int DEFAULT '0',
  `payrollBasicSalary` int DEFAULT '0',
  `payrollTotalDeduction` int DEFAULT '0',
  `payrollTotalAddition` int DEFAULT '0',
  `payrollNetPay` int DEFAULT '0',
  PRIMARY KEY (`employeeDetailsID`),
  KEY `fkEmployeeID_idx` (`idtbl_employee_details`),
  CONSTRAINT `fkEmployeeID` FOREIGN KEY (`idtbl_employee_details`) REFERENCES `tbl_employee` (`employeeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee_details`
--

LOCK TABLES `tbl_employee_details` WRITE;
/*!40000 ALTER TABLE `tbl_employee_details` DISABLE KEYS */;
INSERT INTO `tbl_employee_details` VALUES (76,12,30,60,180,0,0,0,5000,216,21600,1810,500,20290),(77,13,30,60,180,0,0,0,5000,216,43200,3620,500,40080),(78,14,30,60,180,0,0,0,5000,216,64800,5430,500,59870),(79,15,30,60,180,10,0,0,5000,226,50172,4204,500,46468),(80,16,30,60,180,0,0,0,5000,216,32400,2715,500,30185),(81,17,30,60,180,0,0,0,5000,213,42600,3569,500,39531),(82,18,30,60,180,0,0,0,5000,216,71928,6027,500,66401),(83,19,30,60,180,0,0,0,5000,216,47952,4018,500,44434),(84,20,30,60,180,0,0,0,5000,100,33300,2790,500,31010),(85,21,30,60,180,0,0,0,5000,216,47952,4018,500,44434),(86,22,30,60,180,0,0,0,5000,333,110889,9292,500,102097),(87,23,30,60,180,0,0,0,5000,333,110889,9292,500,102097),(88,24,30,60,180,0,0,0,5000,123,15129,1267,500,14362),(89,25,30,60,180,0,0,0,5000,216,46008,3855,500,42653),(90,26,30,60,180,0,0,0,5000,216,26568,2226,500,24842);
/*!40000 ALTER TABLE `tbl_employee_details` ENABLE KEYS */;
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

-- Dump completed on 2020-12-30 23:46:16
