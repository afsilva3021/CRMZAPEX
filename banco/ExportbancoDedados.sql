-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.30 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para crmzapex
CREATE DATABASE IF NOT EXISTS `crmzapex` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `crmzapex`;

-- Copiando estrutura para procedure crmzapex.CadastroItens
DELIMITER //
CREATE PROCEDURE `CadastroItens`(
    IN T2_CODIGO VARCHAR(150),
    IN T2_DESCRICAO VARCHAR(150),
    IN T2_VALOR VARCHAR(150),
    IN T2_TOTAL VARCHAR(150),
    IN T2_QTD VARCHAR(150)
)
BEGIN
    -- Se necessário, adicione lógica para validar ou processar os dados antes da inserção

    INSERT INTO XT0020 (
        T2_CODIGO, T2_DESCRICAO, T2_VALOR, T2_TOTAL, T2_QTD
    ) VALUES (
        T2_CODIGO, T2_DESCRICAO, T2_VALOR, T2_TOTAL, T2_QTD
    );

    -- Se necessário, adicione mais lógica após a inserção

END//
DELIMITER ;

-- Copiando estrutura para procedure crmzapex.cadastroProduto
DELIMITER //
CREATE PROCEDURE `cadastroProduto`(
    IN D0_COD VARCHAR(150),
    IN D0_REFENC VARCHAR(150),
    IN D0_FORNEC VARCHAR(150),
    IN D0_MARCA VARCHAR(150),
    IN D0_SALDO VARCHAR(150),
    IN D0_CUSTO VARCHAR(150),
    IN D0_VEND VARCHAR(150),
    IN D0_ESTMINIMO VARCHAR(150),
    IN D0_ESTMAXIMO VARCHAR(150),
    IN D0_DESC VARCHAR(150),
    IN D0_DESCONTO VARCHAR(150),
    IN D0_IMG VARCHAR(255)
)
BEGIN
    -- Se necessário, adicione lógica para validar ou processar os dados antes da inserção

    INSERT INTO pd0010 (
        D0_COD, D0_REFENC, D0_FORNEC, D0_MARCA, D0_SALDO, D0_CUSTO, D0_VEND,
        D0_ESTMINIMO, D0_ESTMAXIMO, D0_DESC, D0_DESCONTO, D0_IMG
    ) VALUES (
        D0_COD, D0_REFENC, D0_FORNEC, D0_MARCA, D0_SALDO, D0_CUSTO, D0_VEND,
        D0_ESTMINIMO, D0_ESTMAXIMO, D0_DESC, D0_DESCONTO, D0_IMG
    );

    -- Se necessário, adicione mais lógica após a inserção

END//
DELIMITER ;

-- Copiando estrutura para procedure crmzapex.CadCliente
DELIMITER //
CREATE PROCEDURE `CadCliente`(
		IN L0_COD 		VARCHAR(255),
		IN L0_CNPJ		VARCHAR(14),
		IN L0_PESSOA	VARCHAR(255),
		IN L0_UF		VARCHAR(255),
		IN L0_FRET		VARCHAR(255),
		IN L0_EMAIL	VARCHAR(255),
		IN L0_NOME		VARCHAR(255),
		IN L0_FANT		VARCHAR(255),
		IN L0_INSC		VARCHAR(255),
		IN L0_END		VARCHAR(255),
		IN L0_NUM		VARCHAR(255),
		IN L0_BAIR		VARCHAR(255),
		IN L0_CID		VARCHAR(255),
		IN L0_CEP		VARCHAR(255),
		IN L0_COMPL	VARCHAR(255),
		IN L0_TEL		VARCHAR(255),
		IN L0_CEL		VARCHAR(255),
		IN L0_END_COB	VARCHAR(255),
		IN L0_NUM_COB	VARCHAR(255),
		IN L0_BAIR_COB	VARCHAR(255),
		IN L0_UF_COB	VARCHAR(255),
		IN L0_CID_COB	VARCHAR(255),
		IN L0_CEP_COB	VARCHAR(255),
		IN L0_EMIL_COB	VARCHAR(255),
		IN L0_VEND		VARCHAR(255),
		IN L0_TEL_COB	VARCHAR(255),
		IN L0_CEL_COB	VARCHAR(255),
		IN L0_SITE		VARCHAR(255),
		IN L0_NATUREZ	VARCHAR(255)

)
BEGIN
    -- Se necessário, adicione lógica para validar ou processar os dados antes da inserção

    INSERT INTO CL0010 (
        L0_COD, L0_CNPJ, L0_PESSOA, L0_UF, L0_FRET, L0_EMAIL, L0_NOME, L0_FANT,
        L0_INSC,  L0_END, L0_NUM, L0_BAIR, L0_CID, L0_CEP, L0_COMPL, L0_TEL, L0_CEL, L0_DATE, L0_END_COB,
        L0_NUM_COB,L0_BAIR_COB, L0_UF_COB, L0_CID_COB, L0_CEP_COB, L0_EMIL_COB, L0_VEND, L0_TEL_COB, L0_CEL_COB, L0_SITE, L0_NATUREZ
    ) VALUES (
        L0_COD, L0_CNPJ, L0_PESSOA, L0_UF, L0_FRET, L0_EMAIL, L0_NOME, L0_FANT,
        L0_INSC,  L0_END, L0_NUM, L0_BAIR, L0_CID, L0_CEP, L0_COMPL, L0_TEL, L0_CEL, L0_DATE, L0_END_COB,
        L0_NUM_COB,L0_BAIR_COB, L0_UF_COB, L0_CID_COB, L0_CEP_COB, L0_EMIL_COB, L0_VEND, L0_TEL_COB, L0_CEL_COB, L0_SITE, L0_NATUREZ
    );

    -- Se necessário, adicione mais lógica após a inserção

END//
DELIMITER ;

-- Copiando estrutura para tabela crmzapex.cl0010
CREATE TABLE IF NOT EXISTS `cl0010` (
  `L0_ID` int NOT NULL AUTO_INCREMENT,
  `L0_COD` varchar(255) DEFAULT NULL,
  `L0_CNPJ` varchar(14) DEFAULT NULL,
  `L0_PESSOA` varchar(255) DEFAULT NULL,
  `L0_UF` varchar(255) DEFAULT NULL,
  `L0_FRET` varchar(255) DEFAULT NULL,
  `L0_EMAIL` varchar(255) DEFAULT NULL,
  `L0_NOME` varchar(255) DEFAULT NULL,
  `L0_FANT` varchar(255) DEFAULT NULL,
  `L0_INSC` varchar(255) DEFAULT NULL,
  `L0_END` varchar(255) DEFAULT NULL,
  `L0_NUM` varchar(255) DEFAULT NULL,
  `L0_BAIR` varchar(255) DEFAULT NULL,
  `L0_CID` varchar(255) DEFAULT NULL,
  `L0_CEP` varchar(255) DEFAULT NULL,
  `L0_COMPL` varchar(255) DEFAULT NULL,
  `L0_TEL` varchar(255) DEFAULT NULL,
  `L0_CEL` varchar(255) DEFAULT NULL,
  `L0_DATE` date DEFAULT NULL,
  `L0_END_COB` varchar(255) DEFAULT NULL,
  `L0_NUM_COB` varchar(255) DEFAULT NULL,
  `L0_BAIR_COB` varchar(255) DEFAULT NULL,
  `L0_UF_COB` varchar(255) DEFAULT NULL,
  `L0_CID_COB` varchar(255) DEFAULT NULL,
  `L0_CEP_COB` varchar(255) DEFAULT NULL,
  `L0_EMIL_COB` varchar(255) DEFAULT NULL,
  `L0_VEND` varchar(255) DEFAULT NULL,
  `L0_TEL_COB` varchar(255) DEFAULT NULL,
  `L0_CEL_COB` varchar(255) DEFAULT NULL,
  `L0_SITE` varchar(255) DEFAULT NULL,
  `L0_NATUREZ` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`L0_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela crmzapex.cl0010: ~5 rows (aproximadamente)
INSERT IGNORE INTO `cl0010` (`L0_ID`, `L0_COD`, `L0_CNPJ`, `L0_PESSOA`, `L0_UF`, `L0_FRET`, `L0_EMAIL`, `L0_NOME`, `L0_FANT`, `L0_INSC`, `L0_END`, `L0_NUM`, `L0_BAIR`, `L0_CID`, `L0_CEP`, `L0_COMPL`, `L0_TEL`, `L0_CEL`, `L0_DATE`, `L0_END_COB`, `L0_NUM_COB`, `L0_BAIR_COB`, `L0_UF_COB`, `L0_CID_COB`, `L0_CEP_COB`, `L0_EMIL_COB`, `L0_VEND`, `L0_TEL_COB`, `L0_CEL_COB`, `L0_SITE`, `L0_NATUREZ`) VALUES
	(7, '245', '37938493000115', '1 - Juridico', 'SP - SAO PAULO', '1 - CIF', 'producao@calebeegiovannapizzariadeliveryme.com.br', '', 'Calebe e Giovanna Pizzaria Delivery ME', '409924830030', 'Estrada Municipal Orlando Leme Franco', '617', 'Taquari Ponte', 'Leme', '13615686', '', '1929835678', '19981632892', NULL, '', '', '', '', '', '', '', '999999', '', '', 'www.calebeegiovannapizzariadeliveryme.com.br', ''),
	(9, '602', '46649427000116', '1 - Juridico', 'SP - SAO PAULO', '1 - CIF', 'contato@arthurefilipebuffetltda.com.br', '', 'Arthur e Filipe Buffet Ltda', '887233817542', 'Passagem Paraíso', '214', 'Inamar', 'Diadema', '09974240', '', '1125046379', '11989097202', NULL, '', '', '', '', '', '', '', '999999', '', '', 'www.arthurefilipebuffetltda.com.br', ''),
	(11, '806', '93319866000140', '1 - Juridico', 'SP - SAO PAULO', '1 - CIF', 'marketing@carloseduardoeotaviolocacoesdeautomoveisme.com.br', '', 'Carlos Eduardo e Otávio Locações de Automóveis ME', '790068487648', 'Rua Deputado Cantídio Sampaio', '238', 'Morro dos Barbosas', 'São Vicente', '11310140', '', '1336151537', '13992580505', NULL, '', '', '', '', '', '', '', '999999', '', '', 'www.carloseduardoeotaviolocacoesdeautomoveisme.com.br', ''),
	(14, '290', '37371934000140', '1 - Juridico', 'SP', '1 - CIF', 'compras@gabrielaebentolimpezaltda.com.br', '', 'Gabriela e Bento Limpeza Ltda', '252714497086', 'Rua Jerusalém', '145', 'Jardim do Carmo II', 'Itapecerica da Serra', '06865810', '', '1127493529', '11983961765', NULL, 'Rua Jerusalém', '122', 'Jardim do Carmo II', 'SP', 'Itapecerica da Serra', '02830020', '', '999999', '1127493529', '', 'www.gabrielaebentolimpezaltda.com.br', '111001'),
	(17, '726', '57357393000102', '1 - Juridico', 'SP', '1 - CIF', 'marketing@julianaeteresinhalimpezaltda.com.br', '', 'Juliana e Teresinha Limpeza Ltda', '412887899093', 'Rua Silva Alvarenga', '803', 'Vila Nina', 'São Paulo', '02833030', '', '1138767875', '11997032190', NULL, '', '', '', '', '', '', '', '28', '', '', 'www.julianaeteresinhalimpezaltda.com.br', ''),
	(25, '301', '50440116000110', '1 - Juridico', 'SP', '1 - CIF', 'vendas@carlosemarlimarketingltda.com.br', 'Carlos e Marli Marketing Ltda', 'Carlos e Marli Marketing Ltda', '512784441344', 'Rua Urati', '998', 'Jardim Telespark', 'São José dos Campos', '12212800', '', '1236540283', '12981682608', NULL, 'Rua Urati', '', 'Jardim Telespark', 'SP', 'São José dos Campos', '12212800', '', '999999', '', '', 'www.carlosemarlimarketingltda.com.br', ''),
	(26, '822', '13830946000127', '1 - Juridico', 'SP', '1 - CIF', 'ouvidoria@raimundaejorgelimpezame.com.br', 'Raimunda e Jorge Limpeza ME', 'Raimunda e Jorge Limpeza ME', '256092853133', 'Alameda Finlândia', '736', 'Jardim Europa', 'Bragança Paulista', '12919180', '', '1138417405', '11994398958', NULL, 'Alameda Finlândia', '', 'Jardim Europa', 'SP', 'Bragança Paulista', '12919180', 'ouvidoria@raimundaejorgelimpezame.com.br', '999999', '', '', 'www.raimundaejorgelimpezame.com.br', ''),
	(27, '319', '19913458000160', '1 - Juridico', 'SP', '1 - CIF', 'tesouraria@josefaepedropizzariadeliveryltda.com.br', 'Josefa e Pedro Pizzaria Delivery Ltda', 'Josefa e Pedro Pizzaria Delivery Ltda', '646827358785', 'Rua Antônio Cardoso Franco', '189', 'Casa Branca', 'Santo André', '09015530', '', '1125531787', '11986862091', NULL, 'Rua Antônio Cardoso Franco', '', 'Casa Branca', 'SP', 'Santo André', '09015530', 'tesouraria@josefaepedropizzariadeliveryltda.com.br', '999999', '', '', 'www.josefaepedropizzariadeliveryltda.com.br', ''),
	(28, '810', '83217333000102', '1 - Juridico', 'SP', '1 - CIF', 'posvenda@milenaelaraadvocacialtda.com.br', 'Milena e Lara Advocacia Ltda', 'Milena e Lara Advocacia Ltda', '425666024509', 'Rua Caetetuba', '473', 'Jardim Santa Maria', 'Campo Limpo Paulista', '13232365', '', '', '', NULL, 'Rua Caetetuba', '', 'Jardim Santa Maria', 'SP', 'Campo Limpo Paulista', '13232365', '', '999999', '', '', '', '');

-- Copiando estrutura para procedure crmzapex.ConsultarSysUsrPorUsuario
DELIMITER //
CREATE PROCEDURE `ConsultarSysUsrPorUsuario`(IN nome_usuario VARCHAR(20))
BEGIN
    SELECT * FROM sys_usr WHERE usr_user = nome_usuario;

END//
DELIMITER ;

-- Copiando estrutura para procedure crmzapex.ConsultarXT0010
DELIMITER //
CREATE PROCEDURE `ConsultarXT0010`()
BEGIN
    SELECT * FROM XT0010;
END//
DELIMITER ;

-- Copiando estrutura para procedure crmzapex.HEADERATENDI
DELIMITER //
CREATE PROCEDURE `HEADERATENDI`(
    IN T0_COD VARCHAR(155),
    IN T0_CLIENT VARCHAR(155),
    IN T0_FANTASIA VARCHAR(155),
    IN T0_CNPJ VARCHAR(155),
    IN T0_SITUA VARCHAR(155),
    IN T0_ENTREGA VARCHAR(155),
    IN T0_VENDEDOR VARCHAR(155),
    IN T0_CONDPAG VARCHAR(155),
    IN T0_VALORFRETE VARCHAR(155),
    IN T0_TIPOFRETE VARCHAR(155),
    IN T0_NUMPEDCLIENT VARCHAR(155),
    IN T0_STATUS VARCHAR(155),
    IN TO_DESC VARCHAR(255)
)
BEGIN
    -- Se necessário, adicione lógica para validar ou processar os dados antes da inserção

    INSERT INTO XT0010 (
        T0_COD, T0_CLIENT, T0_FANTASIA, T0_CNPJ, T0_SITUA, T0_ENTREGA,
        T0_VENDEDOR, T0_CONDPAG, T0_VALORFRETE, T0_TIPOFRETE, T0_NUMPEDCLIENT,
        T0_STATUS, TO_DESC
    ) VALUES (
        T0_COD, T0_CLIENT, T0_FANTASIA, T0_CNPJ, T0_SITUA, T0_ENTREGA,
        T0_VENDEDOR, T0_CONDPAG, T0_VALORFRETE, T0_TIPOFRETE, T0_NUMPEDCLIENT,
        T0_STATUS, TO_DESC
    );

    -- Se necessário, adicione mais lógica após a inserção

END//
DELIMITER ;

-- Copiando estrutura para tabela crmzapex.pd0010
CREATE TABLE IF NOT EXISTS `pd0010` (
  `D0_ID` int NOT NULL AUTO_INCREMENT,
  `D0_COD` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_REFENC` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_FORNEC` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_MARCA` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_SALDO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_CUSTO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_VEND` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_DESC` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_ESTMINIMO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_ESTMAXIMO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_DESCONTO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `D0_IMG` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`D0_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Tabela de Produtos';

-- Copiando dados para a tabela crmzapex.pd0010: ~1 rows (aproximadamente)
INSERT IGNORE INTO `pd0010` (`D0_ID`, `D0_COD`, `D0_REFENC`, `D0_FORNEC`, `D0_MARCA`, `D0_SALDO`, `D0_CUSTO`, `D0_VEND`, `D0_DESC`, `D0_ESTMINIMO`, `D0_ESTMAXIMO`, `D0_DESCONTO`, `D0_IMG`) VALUES
	(1, '051000012517', '000412238', 'Microsoft', 'Microsoft', '20', '10,00', '50,00', 'Licensa Windows 11 Pro', '10', '60', '0', 'ImagensRWMr0r.png'),
	(2, '999222111', '3322111', 'Microsoft', 'Microsoft', '10', '10,00', '100,00', 'Licensa Office 365', '10', '100', '0', 'Imagense70a3c65-3a17-4846-9b57-f968507f4d07.png'),
	(3, '2312321312', '5345345', 'Microsoft', 'Microsoft', '10', '10,00', '50,00', 'Licença office ', '10', '50', '0', 'Imagense70a3c65-3a17-4846-9b57-f968507f4d07.png'),
	(4, '0192876187432', '4718017187435', 'Amazon', 'Asus', '4', '540,90', '649,00', 'Placa-Mãe ASUS Prime - B450M Gaming/BR, AMD AM4, mATX, DDR4', '2', '10', '0', 'Imagensplaca mae.png'),
	(9, '7892597353064', '7892597353064', 'Amazon', 'Motorola', '5', '659,00', '759', 'Smartphone Motorola Moto E13 4G 64GB 4GB RAM Off White', '1', '10', '0', 'C:\\CRMZAPEX\\CRMZAPEX\\Image156808-800-auto.png'),
	(10, '7892597353064', '123', 'Amazon', 'Motorola', '40', '659,00', '890,00', 'Smartphone Motorola Moto E13 4G 64GB 4GB RAM Off White', '10', '60', '', 'C:\\CRMZAPEX\\CRMZAPEX\\Image156808-800-auto.png');

-- Copiando estrutura para tabela crmzapex.sys_usr
CREATE TABLE IF NOT EXISTS `sys_usr` (
  `USR_ID` int NOT NULL AUTO_INCREMENT,
  `USR_USER` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_NOME` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_PWD` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_EMAIL` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_DATBLQ` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_DEPARTAMENTO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_CARGO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_GRUPO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_BLQ` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `USR_ALT` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`USR_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela crmzapex.sys_usr: ~5 rows (aproximadamente)
INSERT IGNORE INTO `sys_usr` (`USR_ID`, `USR_USER`, `USR_NOME`, `USR_PWD`, `USR_EMAIL`, `USR_DATBLQ`, `USR_DEPARTAMENTO`, `USR_CARGO`, `USR_GRUPO`, `USR_BLQ`, `USR_ALT`) VALUES
	(1, 'admin', 'administrador', '08c0690760e50b50410040150bd0e90080bd04d0ee0150df0b10670a90c80730fc04b0b80a801f06f02a0b40480a9018', '', NULL, 'administrador', 'administrador', '1 - Vendas', '1 - Ativo', 'False'),
	(40, 'professor', 'Leandro', '0a60650a405902004202f09d04107e0480670ef0dc04f0b80a004a01f03f0ff01f0a007e09908e0860f70f70a207a0e3', 'professor@uni9.edu.br', NULL, 'professor', 'professor', '1 - Vendas', '1 - Ativo', 'False'),
	(42, 'alex', 'alex', '08c0690760e50b50410040150bd0e90080bd04d0ee0150df0b10670a90c80730fc04b0b80a801f06f02a0b40480a9018', 'alex@uni9.edu,br', NULL, '', '', '1 - Vendas', '1 - Ativo', 'False');

-- Copiando estrutura para tabela crmzapex.xt0010
CREATE TABLE IF NOT EXISTS `xt0010` (
  `T0_ID` int NOT NULL AUTO_INCREMENT,
  `T0_COD` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_CLIENT` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_FANTASIA` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_CNPJ` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_SITUA` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_ENTREGA` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_VENDEDOR` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_CONDPAG` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_TIPOFRETE` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_VALORFRETE` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_NUMPEDCLIENT` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_DESC` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  `T0_STATUS` varchar(155) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0',
  PRIMARY KEY (`T0_ID`) USING BTREE,
  KEY `T0_COD` (`T0_COD`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela crmzapex.xt0010: ~1 rows (aproximadamente)
INSERT IGNORE INTO `xt0010` (`T0_ID`, `T0_COD`, `T0_CLIENT`, `T0_FANTASIA`, `T0_CNPJ`, `T0_SITUA`, `T0_ENTREGA`, `T0_VENDEDOR`, `T0_CONDPAG`, `T0_TIPOFRETE`, `T0_VALORFRETE`, `T0_NUMPEDCLIENT`, `T0_DESC`, `T0_STATUS`) VALUES
	(1, '051000012517', '051000012517', '051000012517', '051000012517', '051000012517', '051000012517', '051000012517', '051000012517', '051000012517', '0', '0', '0', '0');

-- Copiando estrutura para tabela crmzapex.xt0020
CREATE TABLE IF NOT EXISTS `xt0020` (
  `T2_ID` int NOT NULL AUTO_INCREMENT,
  `T2_CODIGO` varchar(150) DEFAULT NULL,
  `T2_REFERENCE` varchar(150) DEFAULT NULL,
  `T2_VALORCUSTO` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `T2_VALORVENDA` varchar(150) DEFAULT NULL,
  `T2_FORNECEDOR` varchar(150) DEFAULT NULL,
  `T2_MARCA` varchar(150) DEFAULT NULL,
  `T2_DESCIRCAO` varchar(150) DEFAULT NULL,
  `T2_QTD` varchar(150) DEFAULT NULL,
  `T2_DESCONTO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `T2_XT1NUM` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`T2_ID`) USING BTREE,
  KEY `T2_XT1NUM` (`T2_XT1NUM`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Copiando dados para a tabela crmzapex.xt0020: ~5 rows (aproximadamente)
INSERT IGNORE INTO `xt0020` (`T2_ID`, `T2_CODIGO`, `T2_REFERENCE`, `T2_VALORCUSTO`, `T2_VALORVENDA`, `T2_FORNECEDOR`, `T2_MARCA`, `T2_DESCIRCAO`, `T2_QTD`, `T2_DESCONTO`, `T2_XT1NUM`) VALUES
	(25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '872'),
	(26, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '816'),
	(27, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '816'),
	(28, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '391'),
	(29, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '391'),
	(30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '521'),
	(31, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '905'),
	(32, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '905'),
	(33, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '905');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
