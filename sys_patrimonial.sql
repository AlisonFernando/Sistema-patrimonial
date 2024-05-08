CREATE DATABASE  IF NOT EXISTS `sys_pat` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci */;
USE `sys_pat`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: sys_pat.mysql.dbaas.com.br    Database: sys_pat
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
  `descricao` varchar(10000) COLLATE latin1_general_ci NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_status` int(11) DEFAULT NULL,
  `id_equipamento` int(11) DEFAULT NULL,
  `id_colaborador` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_chamado`),
  KEY `fk_equipamento_chamado` (`id_equipamento`),
  KEY `fk_tb_chamado_tb_status` (`id_status`),
  KEY `fk_usuario_chamado` (`id_usuario`),
  KEY `fk_tb_chamado_tb_colaborador` (`id_colaborador`),
  CONSTRAINT `fk_equipamento_chamado` FOREIGN KEY (`id_equipamento`) REFERENCES `tb_equipamentos` (`ID_equipamento`),
  CONSTRAINT `fk_tb_chamado_tb_colaborador` FOREIGN KEY (`id_colaborador`) REFERENCES `tb_colaborador` (`ID_colaborador`),
  CONSTRAINT `fk_tb_chamado_tb_status` FOREIGN KEY (`id_status`) REFERENCES `tb_status` (`id_status`),
  CONSTRAINT `fk_usuario_chamado` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE CASCADE,
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
  `Senha` varchar(10000) COLLATE latin1_general_ci NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_equipamentos`
--

LOCK TABLES `tb_equipamentos` WRITE;
/*!40000 ALTER TABLE `tb_equipamentos` DISABLE KEYS */;
INSERT INTO `tb_equipamentos` VALUES (1,'Teste',1,'R$13,00','Teste','Teste',NULL,NULL);
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
  `IDUsuario` int(11) NOT NULL,
  `EmailUsuario` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `DataHoraAcao` datetime NOT NULL,
  `TipoOperacao` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `Mensagem` varchar(100) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`id_log`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_logs`
--

LOCK TABLES `tb_logs` WRITE;
/*!40000 ALTER TABLE `tb_logs` DISABLE KEYS */;
INSERT INTO `tb_logs` VALUES (1,73,'alison@adm.com','2024-04-23 15:39:28','Cadastro do usuário','Cadastro do usuário: Dener'),(2,0,'alison@adm.com','2024-04-23 16:18:58','token de recuperação de senha gerado',''),(3,74,'alison@adm.com','2024-04-23 16:26:55','Cadastro do usuário','Cadastro do usuário: Alison Teobaldo'),(4,0,'alison@adm.com','2024-04-23 16:27:06','token de recuperação de senha gerado',''),(5,75,'alison@adm.com','2024-04-23 16:28:54','Cadastro do usuário','Cadastro do usuário: Alison Gmail'),(6,0,'alison@adm.com','2024-04-23 16:30:03','token de recuperação de senha gerado',''),(7,0,'alison@adm.com','2024-04-23 16:31:39','atualização de senha do usuário',''),(8,76,'','2024-04-23 16:46:21','Cadastro do usuário','Cadastro do usuário: Caio Carvalho'),(9,77,'','2024-04-23 16:46:42','Cadastro do usuário','Cadastro do usuário: Felipe Sanchez'),(10,0,'dc@scotconsultoria.com.br','2024-05-07 15:30:05','cadastro de marca',''),(11,1,'dc@scotconsultoria.com.br','2024-05-07 15:32:57','Cadastro do equipamento','Cadastro do equipamento: Teste');
/*!40000 ALTER TABLE `tb_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_manutencao`
--

DROP TABLE IF EXISTS `tb_manutencao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_manutencao` (
  `id_manutencao` int(11) NOT NULL AUTO_INCREMENT,
  `id_chamado` int(11) DEFAULT NULL,
  `Data_hora_do_chamado` datetime DEFAULT NULL,
  `descricao` varchar(10000) COLLATE latin1_general_ci DEFAULT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_status` int(11) DEFAULT NULL,
  `id_equipamento` int(11) DEFAULT NULL,
  `id_colaborador` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_manutencao`),
  KEY `fk_tb_manutencao_tb_chamado` (`id_chamado`),
  KEY `fk_tb_manutencao_tb_colaborador` (`id_colaborador`),
  CONSTRAINT `fk_tb_manutencao_tb_chamado` FOREIGN KEY (`id_chamado`) REFERENCES `tb_chamado` (`id_chamado`) ON DELETE CASCADE,
  CONSTRAINT `fk_tb_manutencao_tb_colaborador` FOREIGN KEY (`id_colaborador`) REFERENCES `tb_colaborador` (`ID_colaborador`),
  CONSTRAINT `tb_manutencao_ibfk_1` FOREIGN KEY (`id_chamado`) REFERENCES `tb_chamado` (`id_chamado`)
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
  `DataHora` datetime NOT NULL,
  PRIMARY KEY (`id_manutencaoHistorico`),
  KEY `id_equipamento` (`id_equipamento`),
  KEY `id_manutencao` (`id_manutencao`),
  CONSTRAINT `tb_manutencaoHistorico_ibfk_1` FOREIGN KEY (`id_equipamento`) REFERENCES `tb_equipamentos` (`ID_equipamento`),
  CONSTRAINT `tb_manutencaoHistorico_ibfk_2` FOREIGN KEY (`id_manutencao`) REFERENCES `tb_manutencao` (`id_manutencao`)
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
  `Ativo_inativo` bit(1) NOT NULL,
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_marca`
--

LOCK TABLES `tb_marca` WRITE;
/*!40000 ALTER TABLE `tb_marca` DISABLE KEYS */;
INSERT INTO `tb_marca` VALUES (1,'Marca_1',_binary '');
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
  `Ativo_inativo` tinyint(11) NOT NULL,
  PRIMARY KEY (`ID_setor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_setor`
--

LOCK TABLES `tb_setor` WRITE;
/*!40000 ALTER TABLE `tb_setor` DISABLE KEYS */;
INSERT INTO `tb_setor` VALUES (1,'TI',1);
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
-- Table structure for table `tb_token`
--

DROP TABLE IF EXISTS `tb_token`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_token` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_usuario` int(11) DEFAULT NULL,
  `token` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `data_expiracao` datetime NOT NULL,
  `data_criacao` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tb_token_ibfk_1` (`id_usuario`),
  CONSTRAINT `tb_token_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_token`
--

LOCK TABLES `tb_token` WRITE;
/*!40000 ALTER TABLE `tb_token` DISABLE KEYS */;
INSERT INTO `tb_token` VALUES (1,73,'5edc7916-ef00-494d-98a8-ed155c828539','2024-04-24 16:18:58','2024-04-23 16:18:58'),(2,74,'f96a8512-ffcc-4c7a-85aa-6e7716c9e7a4','2024-04-24 16:27:05','2024-04-23 16:27:05'),(3,75,'d3416679-7690-4763-8449-fbb97028c6fe','2024-04-24 16:30:03','2024-04-23 16:30:03');
/*!40000 ALTER TABLE `tb_token` ENABLE KEYS */;
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
  `UserAcesso` int(11) NOT NULL,
  `Ativo_inativo` tinyint(11) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=78 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;

/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sys_pat'
--

--
-- Dumping routines for database 'sys_pat'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-08  8:10:04
