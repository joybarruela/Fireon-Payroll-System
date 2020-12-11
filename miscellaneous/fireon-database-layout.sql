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
  `accountType` int DEFAULT '0',
  `accountFirstName` varchar(120) DEFAULT NULL,
  `accountLastName` varchar(120) DEFAULT NULL,
  `accountKeepLoggedIn` int DEFAULT NULL,
  PRIMARY KEY (`accountID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_account`
--

LOCK TABLES `tbl_account` WRITE;
/*!40000 ALTER TABLE `tbl_account` DISABLE KEYS */;
INSERT INTO `tbl_account` VALUES (1,'NormalUser1','1231123',0,'John','Doe',0),(2,'NormalUser2','1231123',0,'Mary','Doe',0);
/*!40000 ALTER TABLE `tbl_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_employee`
--

DROP TABLE IF EXISTS `tbl_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_employee` (
  `employeeID` varchar(45) NOT NULL,
  `employeeImage` varchar(250) DEFAULT NULL,
  `employeeFirstName` varchar(120) DEFAULT NULL,
  `employeeMiddleInitial` varchar(3) DEFAULT NULL,
  `employeeLastName` varchar(120) DEFAULT NULL,
  `employeeSex` varchar(45) DEFAULT NULL,
  `employeeContactNumber` int DEFAULT NULL,
  `employeeEmailAddress` varchar(120) DEFAULT NULL,
  `employeeBirthdate` date DEFAULT NULL,
  `employeeHomeAddress` varchar(200) DEFAULT NULL,
  `employeeMaritalStatus` varchar(45) DEFAULT NULL,
  `employeeNationality` varchar(45) DEFAULT NULL,
  `employeeDateEmployed` date DEFAULT NULL,
  `employeeDepartment` varchar(45) DEFAULT NULL,
  `employeePosition` varchar(45) DEFAULT NULL,
  `employeeStatus` varchar(45) DEFAULT NULL,
  `employeeWorkingHours` int DEFAULT NULL,
  `employeeHourlyRate` int DEFAULT NULL,
  `employeeContractDuration` int DEFAULT NULL,
  `employeePaymentMode` varchar(45) DEFAULT NULL,
  `employeeAccountName` varchar(45) DEFAULT NULL,
  `employeeAccountNumber` int DEFAULT NULL,
  PRIMARY KEY (`employeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_employee`
--

LOCK TABLES `tbl_employee` WRITE;
/*!40000 ALTER TABLE `tbl_employee` DISABLE KEYS */;
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

-- Dump completed on 2020-12-11 19:45:26
