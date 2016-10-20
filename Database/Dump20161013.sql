-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: dbmedicalclinic
-- ------------------------------------------------------
-- Server version	5.7.15-log

use dbmedicalclinic;

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
-- Dumping data for table `tbladdress`
--

LOCK TABLES `tbladdress` WRITE;
/*!40000 ALTER TABLE `tbladdress` DISABLE KEYS */;
INSERT INTO `tbladdress` VALUES ('ADDR-000',NULL,NULL,'Sta. Mesa','Manila City','2016-10-08 13:30:55','admin@user1-PC'),('ADDR-001',NULL,NULL,'Sta. Mesa','Manila City','2016-10-08 13:31:26','admin@user1-PC'),('ADDR-002',NULL,NULL,'Sta. Mesa','Manila City','2016-10-08 13:33:29','admin@user1-PC'),('ADDR-003',NULL,NULL,'Sta. Mesa','Manila City','2016-10-08 13:35:30','admin@user1-PC'),('ADDR-004',NULL,NULL,'Sta. Mesa','Manila','2016-10-08 13:37:29','admin@user1-PC'),('ADDR-005',NULL,NULL,'Sta. Maria','Bulacan','2016-10-08 13:40:08','admin@user1-PC'),('ADDR-006',NULL,NULL,'Sta. Maria','Bulacan','2016-10-08 13:43:43','admin@User-PC'),('ADDR-007',NULL,NULL,'Mambugan','Antipolo City','2016-10-08 13:44:44','admin@User-PC'),('ADDR-008','12',NULL,'Sta. Mesa','Manila','2016-10-08 13:47:23','admin@localhost'),('ADDR-009',NULL,'Anonas','Sta. Mesa','Manila','2016-10-08 13:48:29','admin@user1-PC'),('ADDR-010','173','Galaxy','Carrieland Subd., Ampid','San Mateo, Rizal','2016-10-08 13:50:39','admin@localhost'),('ADDR-011',NULL,NULL,'San Mateo','Rizal','2016-10-08 13:54:48','admin@User-PC'),('ADDR-012',NULL,'Anonas','Sta Mesa','Manila','2016-10-08 14:10:32','admin@localhost'),('ADDR-013',NULL,'Anonas','Sta Mesa','Manila','2016-10-08 14:10:44','admin@localhost'),('ADDR-014',NULL,'Pureza','Sta Mesa','Manila','2016-10-08 14:11:06','admin@localhost'),('ADDR-015',NULL,NULL,'Brgy. Mapayapa','Batangas','2016-10-08 14:13:19','admin@User-PC'),('ADDR-016',NULL,'Anonas','Sta Mesa','Manila','2016-10-08 14:14:08','admin@localhost'),('ADDR-017',NULL,NULL,'Commonweath','Quezon City','2016-10-08 14:14:37','admin@localhost'),('ADDR-018',NULL,NULL,'Barangay','Taguig','2016-10-08 14:15:01','admin@localhost'),('ADDR-019',NULL,NULL,'Bagak','Bataan','2016-10-08 14:16:52','admin@localhost'),('ADDR-020',NULL,NULL,'Sta. Clara','Cavite','2016-10-08 14:17:30','admin@User-PC'),('ADDR-021',NULL,NULL,'Sta Clara','Cavite','2016-10-08 14:17:31','admin@localhost'),('ADDR-022',NULL,NULL,'Sta. Clara','Cavite','2016-10-08 14:17:37','admin@User-PC'),('ADDR-023',NULL,NULL,'Lopez','Quezon','2016-10-08 14:17:42','admin@localhost'),('ADDR-024',NULL,NULL,'Mulanay','Mulanay','2016-10-08 14:18:17','admin@localhost'),('ADDR-025',NULL,NULL,'Sta. Clara','Cavite','2016-10-08 14:18:34','admin@User-PC'),('ADDR-026',NULL,NULL,'Sta Tomas','Bulacan','2016-10-08 14:18:35','admin@localhost'),('ADDR-027',NULL,NULL,'Sta Maria','Bulacan','2016-10-08 14:18:48','admin@localhost'),('ADDR-028',NULL,NULL,'Sta. Cruz','Manila','2016-10-08 14:21:41','admin@User-PC'),('ADDR-029',NULL,NULL,'Mexico','Baguio','2016-10-08 14:23:00','admin@User-PC'),('ADDR-030',NULL,NULL,'Santolan','Marikina City','2016-10-08 14:32:57','admin@User-PC'),('ADDR-031',NULL,NULL,'San Jose','Montalban','2016-10-08 14:35:09','admin@User-PC');
/*!40000 ALTER TABLE `tbladdress` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbladmininfo`
--

LOCK TABLES `tbladmininfo` WRITE;
/*!40000 ALTER TABLE `tbladmininfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbladmininfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblbranch`
--

LOCK TABLES `tblbranch` WRITE;
/*!40000 ALTER TABLE `tblbranch` DISABLE KEYS */;
INSERT INTO `tblbranch` VALUES ('BRA00001','Dental','ADDR-009',0,NULL,NULL,'2016-10-08 13:48:29','admin@user1-PC'),('BRA00002','CEA','ADDR-012',0,NULL,NULL,'2016-10-08 14:10:32','admin@localhost'),('BRA00003','COC','ADDR-013',0,NULL,NULL,'2016-10-08 14:10:44','admin@localhost'),('BRA00004','Hasmin','ADDR-014',0,NULL,NULL,'2016-10-08 14:11:06','admin@localhost'),('BRA00005','Lab High','ADDR-016',0,NULL,NULL,'2016-10-08 14:14:08','admin@localhost'),('BRA00006','Commonwealth','ADDR-017',0,NULL,NULL,'2016-10-08 14:14:37','admin@localhost'),('BRA00007','Taguig','ADDR-018',0,NULL,NULL,'2016-10-08 14:15:01','admin@localhost'),('BRA00008','Bataan','ADDR-019',0,NULL,NULL,'2016-10-08 14:16:52','admin@localhost'),('BRA00009','Cavite','ADDR-021',0,NULL,NULL,'2016-10-08 14:17:31','admin@localhost'),('BRA00010','Lopez','ADDR-023',0,NULL,NULL,'2016-10-08 14:17:42','admin@localhost'),('BRA00011','Mulanay','ADDR-024',0,NULL,NULL,'2016-10-08 14:18:17','admin@localhost'),('BRA00012','Sta Tomas','ADDR-026',0,NULL,NULL,'2016-10-08 14:18:35','admin@localhost'),('BRA00013','Ragay','ADDR-027',0,NULL,NULL,'2016-10-08 14:18:48','admin@localhost');
/*!40000 ALTER TABLE `tblbranch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblcollege`
--

LOCK TABLES `tblcollege` WRITE;
/*!40000 ALTER TABLE `tblcollege` DISABLE KEYS */;
INSERT INTO `tblcollege` VALUES ('COLL000','College of Accountancy and Finance','CAF',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL001','College of Architecture and Fine Arts','CAFA',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL002','College of Arts and Letters','CAL',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL003','College of Business Administration','CBA',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL004','College of Communication','COC',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL005','College of Computer and Information Sciences','CCIS',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL006','College of Education','COED',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL007','College of Engineering','CE',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL008','College of Human Kinetics','CHK',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL009','College of Political Science and Public Administration','CPSPA',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL010','College of Social Sciences and Development','CSSD',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL011','College of Science','CS',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL012','College of Tourism, Hospitality and Transportation Management','CTHTM',0,NULL,NULL,'2016-09-18 19:41:48',''),('COLL013','Institute of Technology','ITECH',0,NULL,NULL,'2016-09-18 19:41:48','');
/*!40000 ALTER TABLE `tblcollege` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblcourse`
--

LOCK TABLES `tblcourse` WRITE;
/*!40000 ALTER TABLE `tblcourse` DISABLE KEYS */;
INSERT INTO `tblcourse` VALUES ('COUR000','Bachelor of Science in Accountancy','COLL000','BSA',0,NULL,NULL,'2016-09-18 19:43:46','root@localhost'),('COUR001','Bachelor in Banking and Finance','COLL000','BBF',0,NULL,NULL,'2016-09-18 19:43:46','root@localhost'),('COUR002','Bachelor of Science in Architecture','COLL001','BS ARCH',0,NULL,NULL,'2016-09-18 19:43:46','root@localhost'),('COUR003','Bachelor of Science in Interior Design','COLL001','BAID',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR004','Bachelor of Arts in English','COLL002','ABE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR0047','Bachelor of Science in Physics','COLL011','BSP',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR005','Bachelor of Arts in Filipino','COLL002','ABF',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR006','Bachelor of Arts in Philosophy','COLL002','ABPHILO',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR007','Bachelor of Arts in Theater Arts','COLL002','ABTA',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR008','Bachelor of Science in Business Administration major in Marketing Management','COLL003','BSBA-MM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR009','Bachelor of Science in Business Administration major in Human Resource Development Management','COLL003','BSBA-HRDM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR01','Bachelor of Science in Office Administration','COLL003','BSOA',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR010','Bachelor of Science in Entrepreneurship','COLL003','BSEntrep',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR012','Bachelor in Advertising and Public Relation','COLL004','BAPR',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR013','Bachelor of Arts in Journalism','COLL004','ABJ',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR014','Bachelor of Arts on Broadcast Communication','COLL004','ABBrC',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR015','Bachelor of Arts in Communication Research','COLL004','ABCR',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR016','Bachelor of Science in Computer Science','COLL005','BSCS',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR017','Bachelor of Science in Information Technology','COLL005','BSIT',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR018','Bachelor in Business Teacher Education','COLL006','BBTE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR019','Bachelor in Library and Information Science','COLL006','BLIS',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR020','Bachelor of Elementary Education','COLL006','BEED',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR021','Bachelor of Secondary Education major in English','COLL006','BSED',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR022','Bachelor of Secondary Education major in Filipino','COLL006','BSED',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR023','Bachelor of Secondary Education major in Mathematics','COLL006','BSED',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR024','Bachelor of Secondary Education major in Social Studies','COLL006','BSED',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR025','Bachelor of Science in Mechanical Engineering','COLL007','BSME',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR026','Bachelor of Science in Civil Engineering','COLL007','BSCE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR027','Bachelor of Science in Electrical Engineering','COLL007','BSEE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR028','Bachelor of Science in Industrial Engineering','COLL007','BSIE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR029','Bachelor of Science in Computer Engineering','COLL007','BSCoE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR030','Bachelor of Science in Electronics and Communications Engineering','COLL007','BSECE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR031','Bachelor in Physical Education','COLL008','BPE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR032','Bachelor in Political Science','COLL009','BPS',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR033','Bachelor in Public Administration and Governance','COLL009','BPAG',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR034','Bachelor of Science in Political Economy','COLL009','BSPE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR035','Bachelor in Cooperatives','COLL010','BC',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR036','Bachelor of Arts in History','COLL010','ABH',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR037','Bachelor of Science in Economics','COLL010','BSE',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR038','Bachelor of Science in Psychology','COLL010','BSPSY',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR039','Bachelor of Science in Sociology','COLL010','BSS',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR040','Bachelor in Applied Statistics','COLL011','BAS',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR041','Bachelor of Science in Applied Mathematics major in Actuarial Mathematics','COLL011','BSAM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR042','Bachelor of Science in Biology','COLL011','BSBIO',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR043','Bachelor of Science in Chemistry','COLL011','BSCHEM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR044','Bachelor of Science in Food Technology','COLL011','BSFT',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR045','Bachelor of Science in Mathematics','COLL011','BSM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR046','Bachelor of Science in Nutrition and Dietetics','COLL011','BSND',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR048','Bachelor of Science in Tourism Management','COLL012','BSTM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR049','Bachelor in Transportation Management','COLL012','BTM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR050','Bachelor of Science in Hospitality Management','COLL012','BSHM',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR051','Diploma in Computer Engineering Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR052','Diploma in Electronics Communications Engineering Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR053','Diploma in Electrical Engineering Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR054','Diploma in Information Communication Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR055','Diploma in Mechanical Engineering Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost'),('COUR056','Diploma in Office Management Technology','COLL013','NULL',0,NULL,NULL,'2016-09-18 19:43:47','root@localhost');
/*!40000 ALTER TABLE `tblcourse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbldepartment`
--

LOCK TABLES `tbldepartment` WRITE;
/*!40000 ALTER TABLE `tbldepartment` DISABLE KEYS */;
INSERT INTO `tbldepartment` VALUES ('DEP001','Accounting Department','AD',0,NULL,NULL,'2016-10-08 06:41:25',''),('DEP002','Alumni Relations','AR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP003','Assets Management','AM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP004','Bids and Awards Committee','BAC',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP005','Budget Services','BS',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP006','Campus Development and Maintenance','CDM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP007','Central Records','CR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP008','Communication management','CM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP009','Community Relations and Extension for Development','CRED',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP010','Fund Management','FM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP011','General Services','GS',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP012','Human Resource Management Department','HRMD',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP013','Information and Communications Technology','ICT',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP014','Institute for Cultural Studies','ICS',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP015','Institute for Data and Statistical Analysis','IDSA',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP016','Institute for Labor and Industrial Relations','ILIR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP017','Institute for Science and Technology Research','ISTR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP018','Institute for Social Sciences and Development','ISSD',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP019','Institutional Planning Office','IPO',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP020','Intellectual Property Management','IPM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP021','Internal Audit','IA',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP022','International Affairs','IntlA',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP023','Medical Services Department','MSD',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP024','NSTP','NSTP',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP025','Office of the Student Services','OSS',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP026','Office of the University Registrar','OUR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP027','Open University','OUR',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP028','Physical Planning and Development','PPD',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP029','Procurement','Prcmt',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP030','Publications','Pub',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP031','Quality Assurance','QA',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP032','Research and Extension Management','REM',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP033','Resource Generation','RG',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP034','Safety and Security','SS',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP035','Special Programs and Project','SPP',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP036','Sports Development','SD',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP037','University Center for Culture and Arts','UCCA',0,NULL,NULL,'2016-10-08 06:41:26',''),('DEP038','University Legal Counsel','ULC',0,NULL,NULL,'2016-10-08 06:41:26','');
/*!40000 ALTER TABLE `tbldepartment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbldistributiondetail`
--


--
-- Dumping data for table `tbldistributionheader`
--

LOCK TABLES `tbldistributionheader` WRITE;
/*!40000 ALTER TABLE `tbldistributionheader` DISABLE KEYS */;
INSERT INTO `tbldistributionheader` VALUES ('DIS00001','2016-10-08','MED00001',50,'2016-10-08 15:52:02','admin@user1-PC'),('DIS00002','2016-10-08','MED00002',200,'2016-10-08 16:53:43','staff1@User-PC'),('DIS00003','2016-10-10','MED00024',120,'2016-10-10 05:13:27','root@localhost'),('DIS00004','2016-10-10','MED00002',3,'2016-10-10 05:29:44','root@localhost'),('DIS00005','2016-10-10','MED00002',45,'2016-10-10 05:34:41','admin@localhost'),('DIS00006','2016-10-10','MED00002',2,'2016-10-10 05:34:49','admin@localhost'),('DIS00007','2016-10-10','MED00024',34,'2016-10-10 05:35:00','admin@localhost'),('DIS00008','2016-10-12','MED00031',50,'2016-10-12 21:00:38','root@localhost'),('DIS00009','2016-10-12','MED00024',50,'2016-10-12 21:01:26','root@localhost'),('DIS00010','2016-10-12','EQU00005',500,'2016-10-12 21:05:49','root@localhost'),('DIS00011','2016-10-12','EQU00005',56,'2016-10-12 21:06:02','root@localhost'),('DIS00012','2016-10-12','EQU00005',900,'2016-10-12 21:06:08','root@localhost'),('DIS00013','2016-10-12','EQU00005',9000,'2016-10-12 21:06:14','root@localhost'),('DIS00014','2016-10-13','EQU00005',4,'2016-10-13 07:52:39','root@localhost');
/*!40000 ALTER TABLE `tbldistributionheader` ENABLE KEYS */;
UNLOCK TABLES;
LOCK TABLES `tbldistributiondetail` WRITE;
/*!40000 ALTER TABLE `tbldistributiondetail` DISABLE KEYS */;
INSERT INTO `tbldistributiondetail` VALUES ('DIS00014','BRA00004'),('DIS00014','BRA00005'),('DIS00014','BRA00006');
/*!40000 ALTER TABLE `tbldistributiondetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblfacultyinfo`
--

LOCK TABLES `tblfacultyinfo` WRITE;
/*!40000 ALTER TABLE `tblfacultyinfo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblfacultyinfo` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Dumping data for table `tbllogsheader`
--

LOCK TABLES `tbllogsheader` WRITE;
/*!40000 ALTER TABLE `tbllogsheader` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllogsheader` ENABLE KEYS */;
UNLOCK TABLES;
--
-- Dumping data for table `tbllogsdetail`
--

LOCK TABLES `tbllogsdetail` WRITE;
/*!40000 ALTER TABLE `tbllogsdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllogsdetail` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Dumping data for table `tblmanufacturer`
--

LOCK TABLES `tblmanufacturer` WRITE;
/*!40000 ALTER TABLE `tblmanufacturer` DISABLE KEYS */;
INSERT INTO `tblmanufacturer` VALUES ('MAN00001','Doctors Pharml.,Inc.',1,'ADDR-001',0,NULL,NULL,'2016-10-28 13:31:26','admin@user1-PC'),('MAN00002','Novartis',1,'ADDR-002',0,NULL,NULL,'2016-10-28 13:33:29','admin@user1-PC'),('MAN00003','Unilab',1,'ADDR-003',0,NULL,NULL,'2016-10-28 13:35:30','admin@user1-PC'),('MAN00004','Boots Company',1,'ADDR-004',0,NULL,NULL,'2016-10-28 13:37:29','admin@user1-PC'),('MAN00005','Pharex',1,'ADDR-005',0,NULL,NULL,'2016-10-28 13:40:08','admin@user1-PC'),('MAN00006','Filadams',1,'ADDR-006',0,NULL,NULL,'2016-10-28 13:43:43','admin@User-PC'),('MAN00007','Glaxo Wellcome',1,'ADDR-007',0,NULL,NULL,'2016-10-28 13:44:44','admin@User-PC'),('MAN00008','Abbott',1,'ADDR-011',0,NULL,NULL,'2016-10-08 13:54:48','admin@User-PC'),('MAN00009','Cathay',1,'ADDR-015',0,NULL,NULL,'2016-10-08 14:13:19','admin@User-PC'),('MAN00010','Unilab',2,'ADDR-025',0,NULL,NULL,'2016-10-08 14:18:34','admin@User-PC'),('MAN00011','Unilever',2,'ADDR-028',0,NULL,NULL,'2016-10-08 14:21:41','admin@User-PC'),('MAN00012','Bats',2,'ADDR-029',0,NULL,NULL,'2016-10-08 14:23:00','admin@User-PC'),('MAN00013','Uratex',3,'ADDR-030',0,NULL,NULL,'2016-10-08 14:32:57','admin@User-PC'),('MAN00014','Med-Equip',3,'ADDR-031',0,NULL,NULL,'2016-10-08 14:35:09','admin@User-PC');
/*!40000 ALTER TABLE `tblmanufacturer` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Dumping data for table `tblitem`
--

LOCK TABLES `tblitem` WRITE;
/*!40000 ALTER TABLE `tblitem` DISABLE KEYS */;
INSERT INTO `tblitem` VALUES ('EQU00001','Bed','Bed','MAN00013',5,50,3,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('EQU00002','WC45-X1','Wheel Chair','MAN00013',1,10,3,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('EQU00003','Steth-AG1','Stethoscope','MAN00014',1,10,3,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('EQU00004','Chairs','Monobloc Chair','MAN00013',5,100,3,0,NULL,NULL,'2016-10-08 14:36:49','admin@User-PC'),('EQU00005','Table1','Table','MAN00013',2,20,3,0,NULL,NULL,'2016-10-08 14:37:58','admin@User-PC'),('EQU00006','Chair','Chair','MAN00013',5,20,3,0,NULL,NULL,'2016-10-08 16:46:42','staff1@User-PC'),('MED00001','gh','Ibuprofen','MAN00001',500,1000,1,1,'2016-10-08 16:44:45','admin@%','2016-10-08 14:36:42','admin@user1-PC'),('MED00002','Bu-Aid','Ibuprofen','MAN00001',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00003','Skelan Forte','Ibuprofen','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00004','Dolan FP','Ibuprofen','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00005','XANDRA','XANDRA','MAN00001',0,32,1,1,'2016-10-08 13:38:23','admin@%','2016-10-08 14:36:42','admin@User-PC'),('MED00006','Nuprofen','Ibuprofen','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00007','Pharex Paracetamol','Paracetamol','MAN00005',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00008','Defebrol','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00009','Medicol-A','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00010','Napalgin','Paracetamol','MAN00001',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@user1-PC'),('MED00011','Servigesic','Paracetamol','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00012','Detramol Tab','Paracetamol','MAN00006',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00013','Calpol','Paracetamol','MAN00007',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00014','Biogesic','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00015','Defebrol','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00016','Naprex','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00017','Afebrin','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00018','Rexidol','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00019','Defebrol','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00020','Biogesic','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00021','Afebrin','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00022','Detramol Susp.','Paracetamol','MAN00006',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00023','Calpol 6 Plus','Paracetamol','MAN00007',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00024','Naphrex','Paracetamol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00025','Nubain','Nalbuphine','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00026','Demerol','Pethidine','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00027','Siverol','Tramadol','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00028','Ethrane','Enflurane','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00029','Forane','Isoflurane','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00030','Sevorane','Sevoflurane','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00031','Calypsol','Ketamine','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00032','Pentothal','Thiopental Sodium','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00033','Denkoran','Diclodenac','MAN00005',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00034','Voltaren','Diclofenac','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00035','Anxionil','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00036','Trazepam','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00037','Anxionil','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00038','Trazepam','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00039','Trazepam','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00040','Anxionil','Diazepam','MAN00003',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00041','Brevibloc','Esmolol','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00042','Potocaine','Tetracaine','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00043','Tegretol','Carbamazepine','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00044','Tegretol','Carbamazepine','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00045','Negretol','Carbamazepine','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00046','Epival Abbott','Valproate Disodium/Valporic','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00047','Depakene','Valproate Disodium / Valproic Acid','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00048','Pentothal','Thiopental Sodium','MAN00008',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00049','Servol','Propranolol','MAN00002',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00050','Sinemet','Levodopa','MAN00009',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00051','Sinemet','Levodopa','MAN00009',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00052','Symmetrel','Amandatine','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00053','Symmetrel','Amandatine','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('MED00054','biogesic','paracetamol','MAN00004',500,1000,1,0,NULL,NULL,'2016-10-08 16:42:03','staff1@User-PC'),('MED00055','Bu-Aid','Ibuprofen','MAN00001',9998,100000000,1,0,NULL,NULL,'2016-10-12 21:18:00','root@localhost'),('SUP00001','Green Cross','Alcohol','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00002','Band Me','Band Aid','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00003','Coolets','Cotton Buds','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00004','M-Gauze','Gauze','MAN00012',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00005','Inject','Syringe','MAN00012',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00006','Betamine','Betadine','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00007','Agua-X','Agua Oxinada','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00008','Coolets','Cotton','MAN00010',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00009','Tisyu','Tissue','MAN00011',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00010','Ethanol','Alcohol','MAN00012',50,500,2,0,NULL,NULL,'2016-10-08 14:36:42','admin@User-PC'),('SUP00011','Syringe','Syringe','MAN00010',5,100,2,0,NULL,NULL,'2016-10-08 16:47:19','staff1@User-PC');
/*!40000 ALTER TABLE `tblitem` ENABLE KEYS */;
UNLOCK TABLES;
--
-- Dumping data for table `tbladditional`
--

LOCK TABLES `tbladditional` WRITE;
/*!40000 ALTER TABLE `tbladditional` DISABLE KEYS */;
INSERT INTO `tbladditional` VALUES ('MED00001','200 mg','Tablet'),('MED00002','200 mg','Tablet'),('MED00003','400 mg','Tablet'),('MED00004','100 ml','Syrup'),('MED00005','239jksf','Tablet'),('MED00006','100 ml','Syrup'),('MED00007','500 mg','Tablet'),('MED00008','500 mg','Tablet'),('MED00009','500 mg','Tablet'),('MED00010','500 mg','Tablet'),('MED00011','500 mg','Tablet'),('MED00012','500 mg','Tablet'),('MED00013','500 mg','Tablet'),('MED00014','500 mg','Tablet'),('MED00015','100 ml','Syrup'),('MED00016','100 ml','Syrup'),('MED00017','100 ml','Syrup'),('MED00018','100 ml','Syrup'),('MED00019','120 ml','Syrup'),('MED00020','120 ml','Syrup'),('MED00021','120 ml','Syrup'),('MED00022','60 ml','Syrup'),('MED00023','250 ml','Syrup'),('MED00024','60 ml','Syrup'),('MED00025','10 mg','Capsule'),('MED00026','550 ml','Syrup'),('MED00027','50 mg','Capsule'),('MED00028','250 ml','Syrup'),('MED00029','1000 ml','Syrup'),('MED00030','250 ml','Syrup'),('MED00031','50 ml','Capsule'),('MED00032',' 50 ml','Capsule'),('MED00033','15 mg','Tablet'),('MED00034','25 ml','Syrup'),('MED00035','2 mg','Tablet'),('MED00036','2 mg','Tablet'),('MED00037','5 mg','Tablet'),('MED00038','5 mg','Tablet'),('MED00039','10 mg','Tablet'),('MED00040','5 ml','Capsule'),('MED00041','100 mg','Tablet'),('MED00042','20 mg','Tablet'),('MED00043','200 mg','Tablet'),('MED00044','400 mg','Tablet'),('MED00045','100 ml','Syrup'),('MED00046','200 mg','Tablet'),('MED00047','200 ml','Syrup'),('MED00048','50 ml','Syrup'),('MED00049','40 mg','Tablet'),('MED00050','100 mg','Tablet'),('MED00051','250 mg','Tablet'),('MED00052','100 MG','Tablet'),('MED00053','50 ml','Syrup'),('MED00054','500mg','Tablet'),('MED00055','250 mg','Tablet');
/*!40000 ALTER TABLE `tbladditional` ENABLE KEYS */;
UNLOCK TABLES;


--
-- Dumping data for table `tblpatient`
--

LOCK TABLES `tblpatient` WRITE;
/*!40000 ALTER TABLE `tblpatient` DISABLE KEYS */;
INSERT INTO `tblpatient` VALUES ('PAT00001',0,'Vicente','Venmar','Cuasay','1998-01-14',0,163,75,'09102449544',0,NULL,NULL,'2016-10-08 13:57:17','admin@Jhynzar-PC'),('PAT00002',0,'Subiera','Xandra','Fegalan','1997-07-03',1,123,60,'',0,NULL,NULL,'2016-10-08 13:58:23','admin@Jhynzar-PC'),('PAT00003',0,'Golosinda','Valerie','Guillermo','1998-02-14',1,176,58,'',0,NULL,NULL,'2016-10-08 13:59:37','admin@Jhynzar-PC'),('PAT00004',0,'Espino','Gaberielle','Calabia','1994-11-06',1,0,0,'',0,NULL,NULL,'2016-10-08 15:18:31','admin@user1-PC'),('PAT00005',0,'Mapanao','Jay Ryan','Navarro','2000-02-02',0,0,0,'',0,NULL,NULL,'2016-10-08 16:48:34','staff1@User-PC');
/*!40000 ALTER TABLE `tblpatient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblreceiveheader`
--



--
-- Dumping data for table `tblstudentinfo`
--

LOCK TABLES `tblstudentinfo` WRITE;
/*!40000 ALTER TABLE `tblstudentinfo` DISABLE KEYS */;
INSERT INTO `tblstudentinfo` VALUES ('PAT00001','COUR017','2016-10-08 13:57:17','3','1D'),('PAT00002','COUR009','2016-10-08 13:58:23','3','6'),('PAT00002','COUR009','2016-10-08 14:00:08','3','6'),('PAT00003','COUR015','2016-10-08 13:59:38','2','8'),('PAT00004','COUR028','2016-10-08 15:18:31','5','1D'),('PAT00004','COUR028','2016-10-08 15:18:54','5','1D'),('PAT00005','COUR029','2016-10-08 16:48:35','1','2D');
/*!40000 ALTER TABLE `tblstudentinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblsupplier`
--

LOCK TABLES `tblsupplier` WRITE;
/*!40000 ALTER TABLE `tblsupplier` DISABLE KEYS */;
INSERT INTO `tblsupplier` VALUES ('SUP00001','Meds Supplier','ADDR-008','09102449544','medsupplier@yahoo.com',0,NULL,NULL,'2016-10-28 13:47:23','admin@localhost'),('SUP00002','iCri','ADDR-010','09168964307','iCri@gmail.com',0,NULL,NULL,'2016-10-28 13:50:39','admin@localhost');
/*!40000 ALTER TABLE `tblsupplier` ENABLE KEYS */;
UNLOCK TABLES;


LOCK TABLES `tblreceiveheader` WRITE;
/*!40000 ALTER TABLE `tblreceiveheader` DISABLE KEYS */;
INSERT INTO `tblreceiveheader` VALUES ('REC00001','812731','SUP00002','2016-10-08','2016-10-08 14:02:09','admin@Jhynzar-PC'),('REC00002','78233','SUP00002','2016-10-08','2016-10-08 14:03:41','admin@Jhynzar-PC'),('REC00003','6788667','SUP00002','2016-10-08','2016-10-08 14:50:47','admin@user1-PC'),('REC00004','000-43','SUP00001','2016-10-08','2016-10-08 16:52:42','staff1@User-PC'),('REC00005','5d572','SUP00002','2016-10-12','2016-10-12 17:54:24','root@localhost'),('REC00006','bhre654','SUP00002','2016-10-12','2016-10-12 18:13:07','root@localhost'),('REC00007','ret42y4','SUP00002','2016-10-12','2016-10-12 18:35:34','root@localhost'),('REC00008','yh54uyh','SUP00001','2016-10-13','2016-10-13 07:34:25','root@localhost');
/*!40000 ALTER TABLE `tblreceiveheader` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblreceivedetail`
--

LOCK TABLES `tblreceivedetail` WRITE;
/*!40000 ALTER TABLE `tblreceivedetail` DISABLE KEYS */;
INSERT INTO `tblreceivedetail` VALUES ('REC00001','MED00020','BAT0001',800,'2021-01-08'),('REC00002','MED00024','BAT00002',700,'2111-01-10'),('REC00002','MED00028','BAT00003',600,'2055-07-15'),('REC00002','MED00031','BAT00004',750,'2110-12-27'),('REC00003','MED00001','BAT00006',600,'2016-10-08'),('REC00004','MED00002','0002',500,'2019-07-17'),('REC00005','EQU00002','526896',8,'2019-11-28'),('REC00005','EQU00006','201563',15,'2021-01-01'),('REC00006','EQU00005','546456',14,'2016-10-12'),('REC00006','SUP00001','445',100,'2019-11-12'),('REC00006','SUP00004','3vwef4',12,'2019-11-21'),('REC00006','SUP00005','45645',60,'2016-10-12'),('REC00006','SUP00006','456',56,'2018-10-31'),('REC00007','MED00015','tert43',435,'2019-11-12'),('REC00007','MED00026','bhnnfg',45,'2019-11-12'),('REC00007','MED00029','ret4',435,'2019-11-28'),('REC00008','EQU00002','56dy3467',2,'2016-10-13'),('REC00008','SUP00002','',500,'2016-10-13'),('REC00008','SUP00004','525',38,'2016-10-13');
/*!40000 ALTER TABLE `tblreceivedetail` ENABLE KEYS */;
UNLOCK TABLES;


/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-10-13  7:59:09
