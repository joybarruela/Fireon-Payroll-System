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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_allowance`
--

LOCK TABLES `tbl_allowance` WRITE;
/*!40000 ALTER TABLE `tbl_allowance` DISABLE KEYS */;
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
  `deductionAmount` float DEFAULT NULL,
  PRIMARY KEY (`deductionID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_deduction`
--

LOCK TABLES `tbl_deduction` WRITE;
/*!40000 ALTER TABLE `tbl_deduction` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee`
--

LOCK TABLES `tbl_employee` WRITE;
/*!40000 ALTER TABLE `tbl_employee` DISABLE KEYS */;
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
  `payrollTotalPay` int DEFAULT '0',
  PRIMARY KEY (`employeeDetailsID`),
  KEY `fkEmployeeID_idx` (`idtbl_employee_details`),
  CONSTRAINT `fkEmployeeID` FOREIGN KEY (`idtbl_employee_details`) REFERENCES `tbl_employee` (`employeeID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee_details`
--

LOCK TABLES `tbl_employee_details` WRITE;
/*!40000 ALTER TABLE `tbl_employee_details` DISABLE KEYS */;
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

-- Dump completed on 2020-12-27  0:30:01
