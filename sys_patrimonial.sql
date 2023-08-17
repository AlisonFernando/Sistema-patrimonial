-- phpMyAdmin SQL Dump
-- version 4.6.6deb5ubuntu0.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: 16-Ago-2023 às 20:38
-- Versão do servidor: 5.7.42-0ubuntu0.18.04.1
-- PHP Version: 7.2.24-0ubuntu0.18.04.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sys_patrimonial`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_chamado`
--

CREATE TABLE `tb_chamado` (
  `ID_Chamado` int(11) NOT NULL,
  `Nome_equipamento` varchar(100) NOT NULL,
  `Data_hora_chamado` datetime NOT NULL,
  `Descricao` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_colaborador`
--

CREATE TABLE `tb_colaborador` (
  `ID_colaborador` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Senha` varchar(100) NOT NULL,
  `Link_agenda` varchar(100) NOT NULL,
  `Telefone` varchar(100) NOT NULL,
  `Ativo_inativo` tinyint(4) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_equipamentos`
--

CREATE TABLE `tb_equipamentos` (
  `ID_equipamento` int(11) NOT NULL,
  `Nome_equipamento` varchar(100) NOT NULL,
  `Descricao` varchar(100) NOT NULL,
  `Ativo_inativo` tinyint(4) NOT NULL,
  `Valor` varchar(100) NOT NULL,
  `Etiqueta_identificacao` varchar(100) NOT NULL,
  `marca_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_equipamentos`
--

INSERT INTO `tb_equipamentos` (`ID_equipamento`, `Nome_equipamento`, `Descricao`, `Ativo_inativo`, `Valor`, `Etiqueta_identificacao`, `marca_id`) VALUES
(1, 'Vostro', 'notebook', 1, '200', 'nt_001', NULL),
(2, 'Vostro', 'notebook', 0, '200', 'nt_002', NULL),
(3, 'matheus', 'pimentel', 1, '0', 'mt_01', NULL),
(4, 'Matheus', 'pimentel', 1, '200', 'mt_02', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_logs`
--

CREATE TABLE `tb_logs` (
  `ID_logs` int(11) NOT NULL,
  `Data_hora` datetime NOT NULL,
  `Alteracao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_manutencao`
--

CREATE TABLE `tb_manutencao` (
  `ID_manutencao` int(11) NOT NULL,
  `Motivo_da_manutencao` varchar(100) NOT NULL,
  `Finalizado` tinyint(4) NOT NULL,
  `Nome_equipamento` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_marca`
--

CREATE TABLE `tb_marca` (
  `ID_marca` int(11) NOT NULL,
  `Nome_marca` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_marca`
--

INSERT INTO `tb_marca` (`ID_marca`, `Nome_marca`) VALUES
(1, 'Dell'),
(2, 'Logitech'),
(3, 'Samsung');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_setor`
--

CREATE TABLE `tb_setor` (
  `ID_setor` int(11) NOT NULL,
  `Nome_Setor` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_status`
--

CREATE TABLE `tb_status` (
  `ID_status` int(11) NOT NULL,
  `Andamento_do_chamado` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Senha` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`ID`, `Nome`, `Email`, `Senha`) VALUES
(1, 'teste', 'teste@teste.com', '123'),
(4, 'teste', 'teste@alison.com', 'alison'),
(5, 'teste', 'teste@pimentel.com', 'alison');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_chamado`
--
ALTER TABLE `tb_chamado`
  ADD PRIMARY KEY (`ID_Chamado`);

--
-- Indexes for table `tb_colaborador`
--
ALTER TABLE `tb_colaborador`
  ADD PRIMARY KEY (`ID_colaborador`);

--
-- Indexes for table `tb_equipamentos`
--
ALTER TABLE `tb_equipamentos`
  ADD PRIMARY KEY (`ID_equipamento`),
  ADD KEY `fk_equipamentos_marca` (`marca_id`);

--
-- Indexes for table `tb_logs`
--
ALTER TABLE `tb_logs`
  ADD PRIMARY KEY (`ID_logs`);

--
-- Indexes for table `tb_manutencao`
--
ALTER TABLE `tb_manutencao`
  ADD PRIMARY KEY (`ID_manutencao`);

--
-- Indexes for table `tb_marca`
--
ALTER TABLE `tb_marca`
  ADD PRIMARY KEY (`ID_marca`);

--
-- Indexes for table `tb_setor`
--
ALTER TABLE `tb_setor`
  ADD PRIMARY KEY (`ID_setor`);

--
-- Indexes for table `tb_status`
--
ALTER TABLE `tb_status`
  ADD PRIMARY KEY (`ID_status`);

--
-- Indexes for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_colaborador`
--
ALTER TABLE `tb_colaborador`
  MODIFY `ID_colaborador` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_equipamentos`
--
ALTER TABLE `tb_equipamentos`
  MODIFY `ID_equipamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tb_marca`
--
ALTER TABLE `tb_marca`
  MODIFY `ID_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_equipamentos`
--
ALTER TABLE `tb_equipamentos`
  ADD CONSTRAINT `fk_equipamentos_marca` FOREIGN KEY (`marca_id`) REFERENCES `tb_marca` (`ID_marca`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
