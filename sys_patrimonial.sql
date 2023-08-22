-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: syspatrimonial.mysql.dbaas.com.br    Database: syspatrimonial
-- ------------------------------------------------------
-- Server version	5.7.32-35-log

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
-- Table structure for table `tb_chamado`
--

DROP TABLE IF EXISTS `tb_chamado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_chamado` (
  `id_chamado` int(11) NOT NULL AUTO_INCREMENT,
  `data_hora_do_chamado` datetime NOT NULL,
  `descricao` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_chamado`),
  KEY `id_usuario` (`id_usuario`),
  KEY `id_status` (`id_status`),
  CONSTRAINT `tb_chamado_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`),
  CONSTRAINT `tb_chamado_ibfk_2` FOREIGN KEY (`id_status`) REFERENCES `tb_status` (`id_status`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_chamado`
--

LOCK TABLES `tb_chamado` WRITE;
/*!40000 ALTER TABLE `tb_chamado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_chamado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_colaborador`
--

DROP TABLE IF EXISTS `tb_colaborador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_colaborador` (
  `ID_colaborador` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Email` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Agenda` varchar(150) COLLATE latin1_general_ci NOT NULL,
  `Telefone` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `Ativo_inativo` tinyint(11) NOT NULL,
  `id_setor` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_colaborador`),
  KEY `id_setor` (`id_setor`),
  CONSTRAINT `tb_colaborador_ibfk_1` FOREIGN KEY (`id_setor`) REFERENCES `tb_setor` (`ID_setor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_colaborador`
--

LOCK TABLES `tb_colaborador` WRITE;
/*!40000 ALTER TABLE `tb_colaborador` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_colaborador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_equipamentos`
--

DROP TABLE IF EXISTS `tb_equipamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_equipamentos` (
  `ID_equipamento` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_equipamento` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Ativo_inativo` tinyint(11) NOT NULL,
  `Valor` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Descricao` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Etiqueta_identificacao` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `id_colaborador` int(11) DEFAULT NULL,
  `id_marca` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_equipamento`),
  KEY `id_colaborador` (`id_colaborador`),
  KEY `id_marca` (`id_marca`),
  CONSTRAINT `tb_equipamentos_ibfk_1` FOREIGN KEY (`id_colaborador`) REFERENCES `tb_colaborador` (`ID_colaborador`),
  CONSTRAINT `tb_equipamentos_ibfk_2` FOREIGN KEY (`id_marca`) REFERENCES `tb_marca` (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipamentos`
--

LOCK TABLES `tb_equipamentos` WRITE;
/*!40000 ALTER TABLE `tb_equipamentos` DISABLE KEYS */;
INSERT INTO `tb_equipamentos` VALUES (1,'notebbok',0,'1','1400','nt_001',NULL,1),(2,'notebbok',0,'0','1400','nt_002',NULL,1),(3,'notebbok',0,'1','1400','nt_003',NULL,1);
/*!40000 ALTER TABLE `tb_equipamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_logs`
--

DROP TABLE IF EXISTS `tb_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_logs` (
  `id_log` int(11) NOT NULL AUTO_INCREMENT,
  `Data_hora` datetime NOT NULL,
  `operacao` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `entidade` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_log`),
  KEY `id_usuario` (`id_usuario`),
  CONSTRAINT `tb_logs_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_logs`
--

LOCK TABLES `tb_logs` WRITE;
/*!40000 ALTER TABLE `tb_logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_manutencao`
--

DROP TABLE IF EXISTS `tb_manutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_manutencao` (
  `ID_manutencao` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID_manutencao`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_manutencao`
--

LOCK TABLES `tb_manutencao` WRITE;
/*!40000 ALTER TABLE `tb_manutencao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_manutencao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_manutencaoHistorico`
--

DROP TABLE IF EXISTS `tb_manutencaoHistorico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_manutencaoHistorico` (
  `id_manutencaoHistorico` int(11) NOT NULL AUTO_INCREMENT,
  `id_equipamento` int(11) DEFAULT NULL,
  `id_manutencao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_manutencaoHistorico`),
  KEY `id_equipamento` (`id_equipamento`),
  KEY `id_manutencao` (`id_manutencao`),
  CONSTRAINT `tb_manutencaoHistorico_ibfk_1` FOREIGN KEY (`id_equipamento`) REFERENCES `tb_equipamentos` (`ID_equipamento`),
  CONSTRAINT `tb_manutencaoHistorico_ibfk_2` FOREIGN KEY (`id_manutencao`) REFERENCES `tb_manutencao` (`ID_manutencao`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_manutencaoHistorico`
--

LOCK TABLES `tb_manutencaoHistorico` WRITE;
/*!40000 ALTER TABLE `tb_manutencaoHistorico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_manutencaoHistorico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_marca`
--

DROP TABLE IF EXISTS `tb_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_marca` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_marca`
--

LOCK TABLES `tb_marca` WRITE;
/*!40000 ALTER TABLE `tb_marca` DISABLE KEYS */;
INSERT INTO `tb_marca` VALUES (1,'Dell'),(2,'Sansung');
/*!40000 ALTER TABLE `tb_marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_setor`
--

DROP TABLE IF EXISTS `tb_setor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_setor` (
  `ID_setor` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_setor` varchar(100) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`ID_setor`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_setor`
--

LOCK TABLES `tb_setor` WRITE;
/*!40000 ALTER TABLE `tb_setor` DISABLE KEYS */;
INSERT INTO `tb_setor` VALUES (1,'Engenharia'),(2,'Criacao'),(3,'Marketing'),(4,'TI'),(5,'ADM'),(6,'Ligacoes');
/*!40000 ALTER TABLE `tb_setor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_status`
--

DROP TABLE IF EXISTS `tb_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_status` (
  `id_status` int(11) NOT NULL AUTO_INCREMENT,
  `andamento_do_chamado` varchar(100) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`id_status`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_status`
--

LOCK TABLES `tb_status` WRITE;
/*!40000 ALTER TABLE `tb_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Email` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Senha` varchar(10000) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'syspatrimonial'
--

--
-- Dumping routines for database 'syspatrimonial'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-22 17:18:38
