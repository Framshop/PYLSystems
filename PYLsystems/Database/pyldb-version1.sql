CREATE DATABASE  IF NOT EXISTS `pyldb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pyldb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: pyldb
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `accessworkdesc`
--

DROP TABLE IF EXISTS `accessworkdesc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accessworkdesc` (
  `employeeStatus` int(11) NOT NULL AUTO_INCREMENT,
  `employeePosition` varchar(50) NOT NULL,
  `workDetailsDesc` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`employeeStatus`),
  UNIQUE KEY `employeeStatus_UNIQUE` (`employeeStatus`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accessworkdesc`
--

LOCK TABLES `accessworkdesc` WRITE;
/*!40000 ALTER TABLE `accessworkdesc` DISABLE KEYS */;
INSERT INTO `accessworkdesc` VALUES (1,'Admin','Owner or programming administrator rights'),(2,'Management Staff','Managing the shop when the owner is not around'),(3,'Framer','Working on frame production'),(4,'Cashier','Front desk responsibilities');
/*!40000 ALTER TABLE `accessworkdesc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `attendance` (
  `AttendanceID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) NOT NULL,
  `date` date NOT NULL,
  `timeIn` timestamp NULL DEFAULT NULL,
  `timeOut` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`AttendanceID`),
  KEY `employeeID_toEmployee_idx` (`employeeID`),
  CONSTRAINT `employeeIDAtt_toEmployee` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `employeeID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeStatus` int(11) NOT NULL,
  `startofEmployment` datetime NOT NULL,
  `firstName` varchar(45) NOT NULL,
  `lastName` varchar(45) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `birthDate` date NOT NULL,
  `homeAddress` varchar(120) DEFAULT NULL,
  `salaryRate` decimal(7,2) NOT NULL,
  `contactNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`employeeID`),
  KEY `employeeStatus_accessWorkDesc_idx` (`employeeStatus`),
  CONSTRAINT `employeeStatusEmp_toAccessWorkDesc` FOREIGN KEY (`employeeStatus`) REFERENCES `accessworkdesc` (`employeeStatus`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,1,'2018-10-19 00:00:00','Admin','Administrator','none','2018-10-19','PYL',0.00,NULL);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payroll`
--

DROP TABLE IF EXISTS `payroll`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payroll` (
  `payrollID(key)` int(11) NOT NULL AUTO_INCREMENT,
  `employeeIDReceiver` int(11) NOT NULL,
  `employeeIDProvider` int(11) NOT NULL,
  `cashAdvanceDate` datetime NOT NULL,
  `salaryRate` decimal(7,2) NOT NULL,
  `cashAdvanceAmount` decimal(7,2) NOT NULL,
  PRIMARY KEY (`payrollID(key)`),
  KEY `employeeID_Both_toEmployee_idx` (`employeeIDReceiver`),
  KEY `employeeIDProvPayroll_toEmployee_idx` (`employeeIDProvider`),
  CONSTRAINT `employeeIDProvPayroll_toEmployee` FOREIGN KEY (`employeeIDProvider`) REFERENCES `employee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `employeeIDRecPayroll_toEmployee` FOREIGN KEY (`employeeIDReceiver`) REFERENCES `employee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payroll`
--

LOCK TABLES `payroll` WRITE;
/*!40000 ALTER TABLE `payroll` DISABLE KEYS */;
/*!40000 ALTER TABLE `payroll` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `userID` int(11) NOT NULL AUTO_INCREMENT,
  `employeeID` int(11) NOT NULL,
  `employeeStatus` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`userID`,`employeeID`),
  UNIQUE KEY `username` (`username`),
  KEY `employeeIDUsers_toEmployee_idx` (`employeeID`),
  CONSTRAINT `employeeIDUsers_toEmployee` FOREIGN KEY (`employeeID`) REFERENCES `employee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,1,'admin','admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-22 16:55:07
