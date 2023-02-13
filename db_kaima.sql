-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 12-Fev-2023 às 18:11
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kaima`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluno`
--

DROP TABLE IF EXISTS `aluno`;
CREATE TABLE IF NOT EXISTS `aluno` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `telefone` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `morada` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `data_nascimento` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `bi` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sexo` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `encarregado_id` int(11) NOT NULL,
  `img` varchar(500) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `aluno`
--

INSERT INTO `aluno` (`id`, `nome`, `telefone`, `morada`, `data_nascimento`, `bi`, `sexo`, `encarregado_id`, `img`) VALUES
(5, 'Joao Batista', '912121312', 'Viana', '23/01/2023', '000012123', 'Masculino', 4, 'C:\\Users\\programador\\Downloads\\WhatsApp Image 2023-02-06 at 00.11.07.jpeg'),
(4, 'Fernando Silva', '9233232', '', '10/06/2001', '00012B1212FDF', 'Masculino', 4, 'C:\\Users\\programador\\Downloads\\WhatsApp Image 2023-02-06 at 00.11.07.jpeg'),
(6, 'Manuela MM', '9233354655', 'NM', '23/01/2023', '000555666', 'Feminino', 4, 'C:\\Users\\programador\\Downloads\\WhatsApp Image 2023-02-06 at 00.11.07.jpeg');

-- --------------------------------------------------------

--
-- Estrutura da tabela `ano_letivo`
--

DROP TABLE IF EXISTS `ano_letivo`;
CREATE TABLE IF NOT EXISTS `ano_letivo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ano_lectivo` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `data_inicio` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `data_final` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `ano_letivo`
--

INSERT INTO `ano_letivo` (`id`, `ano_lectivo`, `data_inicio`, `data_final`, `status`) VALUES
(1, '2022/2023', '23/01/2023', '23/01/2023', NULL),
(2, '2023/2024', '23/01/2024', '23/01/2025', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `area_formacao`
--

DROP TABLE IF EXISTS `area_formacao`;
CREATE TABLE IF NOT EXISTS `area_formacao` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `duracao` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `area_formacao`
--

INSERT INTO `area_formacao` (`id`, `nome`, `duracao`) VALUES
(1, 'Tecnica', 4),
(2, 'Punivel', 3),
(3, 'Administrativa', 3),
(4, 'Enfermagem', 4),
(5, 'Ciencias Socias', 3),
(6, 'Saude', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargo`
--

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE IF NOT EXISTS `cargo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cargo` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cargo`
--

INSERT INTO `cargo` (`id`, `cargo`) VALUES
(1, 'Professor'),
(2, 'Continuo'),
(3, 'Limpeza');

-- --------------------------------------------------------

--
-- Estrutura da tabela `classe`
--

DROP TABLE IF EXISTS `classe`;
CREATE TABLE IF NOT EXISTS `classe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `classe`
--

INSERT INTO `classe` (`id`, `name`, `status`) VALUES
(1, '10 Classe', 1),
(2, '11 Classe', 1),
(3, '12 Classe', 1),
(4, '13 Classe', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `classe_disciplina_curso`
--

DROP TABLE IF EXISTS `classe_disciplina_curso`;
CREATE TABLE IF NOT EXISTS `classe_disciplina_curso` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `curso_id` int(11) NOT NULL,
  `classe_id` int(11) NOT NULL,
  `disciplina_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=118 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `classe_disciplina_curso`
--

INSERT INTO `classe_disciplina_curso` (`id`, `curso_id`, `classe_id`, `disciplina_id`) VALUES
(116, 27, 3, 1),
(115, 27, 2, 6),
(114, 27, 2, 5),
(113, 27, 2, 4),
(94, 26, 4, 3),
(86, 25, 1, 3),
(79, 24, 1, 7),
(112, 27, 2, 3),
(24, 1, 4, 1),
(93, 26, 3, 3),
(111, 27, 2, 2),
(30, 1, 2, 1),
(31, 1, 2, 2),
(110, 27, 2, 1),
(34, 1, 2, 7),
(109, 27, 1, 5),
(89, 25, 3, 5),
(88, 25, 2, 2),
(38, 17, 2, 7),
(108, 27, 1, 4),
(40, 18, 1, 7),
(100, 25, 4, 5),
(92, 26, 3, 2),
(43, 18, 3, 5),
(107, 27, 1, 3),
(46, 19, 2, 2),
(48, 19, 3, 3),
(49, 19, 3, 4),
(117, 27, 3, 5),
(78, 24, 1, 6),
(106, 27, 1, 2),
(54, 21, 1, 8),
(105, 27, 1, 1),
(102, 22, 1, 2),
(98, 25, 4, 2),
(91, 26, 2, 2),
(87, 25, 2, 3),
(63, 22, 3, 7),
(64, 22, 3, 8),
(65, 22, 4, 1),
(95, 26, 4, 5),
(104, 22, 1, 3),
(75, 24, 1, 3),
(103, 22, 1, 1),
(77, 24, 1, 5),
(72, 22, 4, 8);

-- --------------------------------------------------------

--
-- Estrutura da tabela `curso`
--

DROP TABLE IF EXISTS `curso`;
CREATE TABLE IF NOT EXISTS `curso` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `abreviacao` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `area_id` int(11) NOT NULL,
  `mensalidade` float NOT NULL,
  PRIMARY KEY (`id`),
  KEY `area_id` (`area_id`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `curso`
--

INSERT INTO `curso` (`id`, `nome`, `abreviacao`, `area_id`, `mensalidade`) VALUES
(22, 'Tecnico de Informatica', NULL, 1, 10000),
(23, 'Quimica Industrial', NULL, 1, 20000),
(24, 'Ciencias Fisicas', NULL, 5, 8000),
(25, 'Analises Clinicas', NULL, 4, 30000),
(26, 'Economicas Juridicas', NULL, 3, 5000),
(27, 'Ciencias criminais', NULL, 5, 20000);

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplinas`
--

DROP TABLE IF EXISTS `disciplinas`;
CREATE TABLE IF NOT EXISTS `disciplinas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `disciplina` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `disciplinas`
--

INSERT INTO `disciplinas` (`id`, `disciplina`) VALUES
(1, 'Biologia'),
(2, 'Quimica'),
(3, 'Matematica'),
(4, 'Fisica'),
(5, 'OGE'),
(6, 'Micro'),
(7, 'Base de dados'),
(8, 'teste'),
(9, 'MIC');

-- --------------------------------------------------------

--
-- Estrutura da tabela `encarregado`
--

DROP TABLE IF EXISTS `encarregado`;
CREATE TABLE IF NOT EXISTS `encarregado` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `tel` varchar(20) NOT NULL,
  `email` varchar(100) NOT NULL,
  `sexo` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `encarregado`
--

INSERT INTO `encarregado` (`id`, `nome`, `tel`, `email`, `sexo`) VALUES
(4, 'Maria Andre Jorge', '92332323', 'm@gmail.com', 'Femenino');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE IF NOT EXISTS `funcionario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `tel` varchar(50) NOT NULL,
  `morada` varchar(50) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `cargo_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id`, `nome`, `tel`, `morada`, `sexo`, `cargo_id`) VALUES
(27, 'Fulano AS', '22224443', 'OK', 'Masculino', 1),
(26, 'MN ', '9123545656', 'HJMJH', 'Masculino', 1),
(25, 'Teste', '8455', 'jhc', 'Masculino', 1),
(24, 'Manuela Jose', '9233444', 'HJ', 'Femenino', 1),
(23, 'Moises MN', '22265556', 'KIL', 'Masculino', 1),
(22, 'Fernando Silva', '95233455', 'MKK', 'Masculino', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `matricula`
--

DROP TABLE IF EXISTS `matricula`;
CREATE TABLE IF NOT EXISTS `matricula` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nmatricula` varchar(50) NOT NULL,
  `turma_id` int(11) NOT NULL,
  `aluno_id` int(11) NOT NULL,
  `ano_id` int(11) NOT NULL,
  `data_matricula` varchar(11) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `status` int(11) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `matricula`
--

INSERT INTO `matricula` (`id`, `nmatricula`, `turma_id`, `aluno_id`, `ano_id`, `data_matricula`, `tipo`, `status`) VALUES
(1, '00015', 16, 5, 2, '10/02/2023', 'NOVA', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

DROP TABLE IF EXISTS `professor`;
CREATE TABLE IF NOT EXISTS `professor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `funcionaro_id` int(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`id`, `funcionaro_id`) VALUES
(22, 27),
(21, 26),
(20, 25),
(19, 24),
(18, 23),
(17, 22);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor_disciplina`
--

DROP TABLE IF EXISTS `professor_disciplina`;
CREATE TABLE IF NOT EXISTS `professor_disciplina` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `professor_id` int(11) NOT NULL,
  `disciplina_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=127 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `professor_disciplina`
--

INSERT INTO `professor_disciplina` (`id`, `professor_id`, `disciplina_id`) VALUES
(126, 19, 1),
(125, 19, 2),
(124, 19, 3),
(123, 21, 3),
(122, 21, 2),
(121, 21, 1),
(119, 22, 5),
(120, 22, 6),
(117, 22, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `sala`
--

DROP TABLE IF EXISTS `sala`;
CREATE TABLE IF NOT EXISTS `sala` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `capacidade` int(11) NOT NULL,
  `tipo` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `sala`
--

INSERT INTO `sala` (`id`, `nome`, `capacidade`, `tipo`) VALUES
(1, 'Sala 1', 25, 'Sala de Aula'),
(2, 'Sala 2', 22, 'Sala de Aula'),
(3, 'Sala 3', 15, 'Sala de Aula');

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma`
--

DROP TABLE IF EXISTS `turma`;
CREATE TABLE IF NOT EXISTS `turma` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `classe_id` int(11) NOT NULL,
  `curso_id` int(11) NOT NULL,
  `prof_id` int(11) DEFAULT NULL,
  `turno_id` int(11) NOT NULL,
  `ano_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `turma`
--

INSERT INTO `turma` (`id`, `nome`, `classe_id`, `curso_id`, `prof_id`, `turno_id`, `ano_id`) VALUES
(15, 'IG1A', 1, 22, 21, 1, 1),
(16, 'GG10B', 1, 22, 22, 1, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma_disciplina_professor`
--

DROP TABLE IF EXISTS `turma_disciplina_professor`;
CREATE TABLE IF NOT EXISTS `turma_disciplina_professor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `professor_id` int(11) NOT NULL,
  `disciplina_id` int(11) NOT NULL,
  `turma_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `turma_disciplina_professor`
--

INSERT INTO `turma_disciplina_professor` (`id`, `professor_id`, `disciplina_id`, `turma_id`) VALUES
(18, 21, 1, 16),
(17, 21, 2, 16),
(16, 22, 3, 16),
(15, 22, 3, 15);

-- --------------------------------------------------------

--
-- Estrutura da tabela `turno`
--

DROP TABLE IF EXISTS `turno`;
CREATE TABLE IF NOT EXISTS `turno` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `inicio` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `final` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `turno`
--

INSERT INTO `turno` (`id`, `nome`, `inicio`, `final`) VALUES
(1, 'Manhã', '08:00', '12:45');

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(100) NOT NULL,
  `senha` varchar(500) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`username`, `senha`, `id`) VALUES
('admin', 'admin', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
