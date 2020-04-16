CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.34-MariaDB

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
-- Table structure for table `acreedor`
--

DROP TABLE IF EXISTS `acreedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acreedor` (
  `pkidacreedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `nit` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `calidadservicio` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidacreedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acreedor`
--

LOCK TABLES `acreedor` WRITE;
/*!40000 ALTER TABLE `acreedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `acreedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asistencia` (
  `pkcodigoasistencia` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `fechaentrada` date DEFAULT NULL,
  `fechasalida` date DEFAULT NULL,
  `horaentrada` time DEFAULT NULL,
  `horasalida` time DEFAULT NULL,
  PRIMARY KEY (`pkcodigoasistencia`),
  KEY `fk_asistencia_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_asistencia_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ayudas`
--

DROP TABLE IF EXISTS `ayudas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ayudas` (
  `pkcodigoayuda` int(11) NOT NULL,
  `rutayuda` varchar(190) DEFAULT NULL,
  `indicedeayuda` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoayuda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ayudas`
--

LOCK TABLES `ayudas` WRITE;
/*!40000 ALTER TABLE `ayudas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ayudas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `cod_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(45) DEFAULT NULL,
  `MAC` varchar(45) DEFAULT NULL,
  `usuario` varchar(45) DEFAULT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `fecha_hora` datetime DEFAULT NULL,
  `accion` varchar(45) DEFAULT NULL,
  `formulario` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`cod_bitacora`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bodega` (
  `pkidBodega` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `StockMaximo` int(11) DEFAULT NULL,
  `StockMinimo` int(11) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidBodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidatos_internos`
--

DROP TABLE IF EXISTS `candidatos_internos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `candidatos_internos` (
  `pkcodigocandidato` int(11) NOT NULL AUTO_INCREMENT,
  `pksolicitudempleado` int(11) NOT NULL,
  `pkcodperfil` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocandidato`,`pksolicitudempleado`,`pkcodperfil`),
  KEY `fk_candidatos_internos_tbl_solicitud_empleado_encabezado1_idx` (`pksolicitudempleado`),
  KEY `fk_candidatos_internos_perfil_encabezado1_idx` (`pkcodperfil`),
  CONSTRAINT `fk_candidatos_internos_perfil_encabezado1` FOREIGN KEY (`pkcodperfil`) REFERENCES `perfil_encabezado` (`pkcodperfil`),
  CONSTRAINT `fk_candidatos_internos_tbl_solicitud_empleado_encabezado1` FOREIGN KEY (`pksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidatos_internos`
--

LOCK TABLES `candidatos_internos` WRITE;
/*!40000 ALTER TABLE `candidatos_internos` DISABLE KEYS */;
/*!40000 ALTER TABLE `candidatos_internos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `pkcodcategoria` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodcategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concepto`
--

DROP TABLE IF EXISTS `concepto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `concepto` (
  `pkcodigoconcepto` int(11) NOT NULL,
  `nombreconcepto` varchar(45) DEFAULT NULL,
  `tipo_concepto` tinyint(4) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `tipo_accion` tinyint(4) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoconcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concepto`
--

LOCK TABLES `concepto` WRITE;
/*!40000 ALTER TABLE `concepto` DISABLE KEYS */;
/*!40000 ALTER TABLE `concepto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conceptos_empleado`
--

DROP TABLE IF EXISTS `conceptos_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `conceptos_empleado` (
  `pkconceptoempleado` int(11) NOT NULL AUTO_INCREMENT,
  `pknombreconcepto` varchar(25) DEFAULT NULL,
  `Total_monto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkconceptoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conceptos_empleado`
--

LOCK TABLES `conceptos_empleado` WRITE;
/*!40000 ALTER TABLE `conceptos_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `conceptos_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_contable`
--

DROP TABLE IF EXISTS `cuentas_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuentas_contable` (
  `pkcodigocuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(45) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `debe_haber` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_contable`
--

LOCK TABLES `cuentas_contable` WRITE;
/*!40000 ALTER TABLE `cuentas_contable` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `pkcodigodepto` int(11) NOT NULL,
  `nombredepto` varchar(45) DEFAULT NULL,
  `descripciondepto` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigodepto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despidoempleado`
--

DROP TABLE IF EXISTS `despidoempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `despidoempleado` (
  `pkcodigodespidoempleado` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `razondespido` varchar(45) DEFAULT NULL,
  `descripciondespido` varchar(45) DEFAULT NULL,
  `fechadespido` date DEFAULT NULL,
  PRIMARY KEY (`pkcodigodespidoempleado`),
  KEY `fk_despidoempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_despidoempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despidoempleado`
--

LOCK TABLES `despidoempleado` WRITE;
/*!40000 ALTER TABLE `despidoempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `despidoempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `pkcodigoempleado` int(11) NOT NULL,
  `fkcodigojornada` int(11) NOT NULL,
  `primernombre` varchar(45) DEFAULT NULL,
  `segundonombre` varchar(45) DEFAULT NULL,
  `primerapellido` varchar(45) DEFAULT NULL,
  `segundoapellido` varchar(45) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `celular` int(11) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `TipoContratacion_pkcodigocontratacion` int(11) DEFAULT NULL,
  `nit` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoempleado`),
  KEY `fk_empleado_jornada_idx` (`fkcodigojornada`),
  CONSTRAINT `fk_empleado_jornada` FOREIGN KEY (`fkcodigojornada`) REFERENCES `jornada` (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleadocontable`
--

DROP TABLE IF EXISTS `empleadocontable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleadocontable` (
  `pkcodigolinea` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigoconcepto` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigolinea`),
  KEY `fk_empleadocontable_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_empleadocontable_concepto1_idx` (`fkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_concepto1` FOREIGN KEY (`fkcodigoconcepto`) REFERENCES `concepto` (`pkcodigoconcepto`),
  CONSTRAINT `fk_empleadocontable_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleadocontable`
--

LOCK TABLES `empleadocontable` WRITE;
/*!40000 ALTER TABLE `empleadocontable` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleadocontable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedordetalle`
--

DROP TABLE IF EXISTS `facturaproveedordetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturaproveedordetalle` (
  `pkidDetalleFactura` int(11) NOT NULL AUTO_INCREMENT,
  `fkidEncabezadoFactura` int(11) DEFAULT NULL,
  `fkidProducto` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `precioUnitario` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidDetalleFactura`),
  KEY `fk_facturaProveedorDetalle_facturaProveedorEncabezado1_idx` (`fkidEncabezadoFactura`),
  KEY `fk_facturaProveedorDetalle_producto1_idx` (`fkidProducto`),
  CONSTRAINT `fk_facturaProveedorDetalle_facturaProveedorEncabezado1` FOREIGN KEY (`fkidEncabezadoFactura`) REFERENCES `facturaproveedorencabezado` (`pkidEncabezadoFacturaP`),
  CONSTRAINT `fk_facturaProveedorDetalle_producto1` FOREIGN KEY (`fkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedordetalle`
--

LOCK TABLES `facturaproveedordetalle` WRITE;
/*!40000 ALTER TABLE `facturaproveedordetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturaproveedordetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaproveedorencabezado`
--

DROP TABLE IF EXISTS `facturaproveedorencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturaproveedorencabezado` (
  `pkidEncabezadoFacturaP` int(11) NOT NULL,
  `fkIdOrdenCompra` int(11) DEFAULT NULL,
  `pkcodigoempleado` int(11) DEFAULT NULL,
  `segun` varchar(45) DEFAULT NULL,
  `serieFactura` varchar(45) DEFAULT NULL,
  `numeroFactura` varchar(45) DEFAULT NULL,
  `fechaEntrega` date DEFAULT NULL,
  `fkIdImpuesto` int(11) DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidEncabezadoFacturaP`),
  KEY `fk_facturaProveedorEncabezado_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_facturaproveedorencabezado_ordenComrpaEncabezado1_idx` (`fkIdOrdenCompra`),
  KEY `fk_facturaproveedorencabezado_impuestos1_idx` (`fkIdImpuesto`),
  CONSTRAINT `fk_facturaProveedorEncabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_facturaproveedorencabezado_impuestos1` FOREIGN KEY (`fkIdImpuesto`) REFERENCES `impuestos` (`pkidImpuesto`),
  CONSTRAINT `fk_facturaproveedorencabezado_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdOrdenCompra`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaproveedorencabezado`
--

LOCK TABLES `facturaproveedorencabezado` WRITE;
/*!40000 ALTER TABLE `facturaproveedorencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturaproveedorencabezado` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,STRICT_ALL_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ALLOW_INVALID_DATES,ERROR_FOR_DIVISION_BY_ZERO,TRADITIONAL,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `mydb`.`tgr_desactivar_ordenc`
AFTER INSERT ON `mydb`.`facturaproveedorencabezado`
FOR EACH ROW
begin
UPDATE ordencomrpaencabezado
SET estado='0' WHERE pkIdOrdenCompraEncabezado=New.fkIdOrdenCompra; 
end */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;


--
-- Table structure for table `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devoluciones` (
  `pkcodigodev` int(11) NOT NULL ,
  `pkidEncabezadoFacturaP` int(11) NOT NULL,
  `pkcodigoempleado` int(11) DEFAULT NULL,
  `fkIdOrdenCompra` int(11) DEFAULT NULL,
`numerofactura` varchar(45) DEFAULT NULL,
  `total` varchar(45) DEFAULT NULL,
   `motivo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigodev`),
KEY `fk_devoluciones1_idx` (`pkcodigoempleado`),
KEY `fk_devoluciones_ordenComrpaEncabezado1_idx` (`fkIdOrdenCompra`),
CONSTRAINT `fk_devoluciones_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
CONSTRAINT `fk_devoluciones_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdOrdenCompra`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devoluciones`
--

LOCK TABLES `devoluciones` WRITE;
/*!40000 ALTER TABLE `devoluciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `devoluciones` ENABLE KEYS */;
UNLOCK TABLES;
--
-- Table structure for table `formaspago`
--

DROP TABLE IF EXISTS `formaspago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formaspago` (
  `pkIdFormaPago` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdFormaPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formaspago`
--

LOCK TABLES `formaspago` WRITE;
/*!40000 ALTER TABLE `formaspago` DISABLE KEYS */;
/*!40000 ALTER TABLE `formaspago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horasextras`
--

DROP TABLE IF EXISTS `horasextras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horasextras` (
  `pkcodigohorasextras` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigohorasextras`),
  KEY `fk_horasextras_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_horasextras_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horasextras`
--

LOCK TABLES `horasextras` WRITE;
/*!40000 ALTER TABLE `horasextras` DISABLE KEYS */;
/*!40000 ALTER TABLE `horasextras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `impuestos`
--

DROP TABLE IF EXISTS `impuestos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `impuestos` (
  `pkidImpuesto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidImpuesto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `impuestos`
--

LOCK TABLES `impuestos` WRITE;
/*!40000 ALTER TABLE `impuestos` DISABLE KEYS */;
/*!40000 ALTER TABLE `impuestos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jornada`
--

DROP TABLE IF EXISTS `jornada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jornada` (
  `pkcodigojornada` int(11) NOT NULL,
  `nombrejornada` varchar(45) DEFAULT NULL,
  `horasjornada` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigojornada`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jornada`
--

LOCK TABLES `jornada` WRITE;
/*!40000 ALTER TABLE `jornada` DISABLE KEYS */;
/*!40000 ALTER TABLE `jornada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kpi`
--

DROP TABLE IF EXISTS `kpi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kpi` (
  `pkcodigokpi` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `puntuacion` int(11) DEFAULT NULL,
  `desempeño` varchar(45) DEFAULT NULL,
  `fkcodcategoria` int(11) DEFAULT NULL,
  `fkcodempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`pkcodigokpi`),
  KEY `fk_kpi_categoria1_idx` (`fkcodcategoria`),
  KEY `fk_kpi_empleado1` (`fkcodempleado`),
  CONSTRAINT `fk_kpi_categoria1` FOREIGN KEY (`fkcodcategoria`) REFERENCES `categoria` (`pkcodcategoria`),
  CONSTRAINT `fk_kpi_empleado1` FOREIGN KEY (`fkcodempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kpi`
--

LOCK TABLES `kpi` WRITE;
/*!40000 ALTER TABLE `kpi` DISABLE KEYS */;
/*!40000 ALTER TABLE `kpi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mediodecomunicacion`
--

DROP TABLE IF EXISTS `mediodecomunicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mediodecomunicacion` (
  `pkmediodecomunicacion` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkmediodecomunicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mediodecomunicacion`
--

LOCK TABLES `mediodecomunicacion` WRITE;
/*!40000 ALTER TABLE `mediodecomunicacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `mediodecomunicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `meta`
--

DROP TABLE IF EXISTS `meta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `meta` (
  `codigo_meta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_meta` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `plazo_meta` tinyint(1) DEFAULT NULL,
  `puntaje` varchar(45) DEFAULT NULL,
  `fecha_realizacion` datetime DEFAULT NULL,
  `completado` tinyint(1) DEFAULT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo_meta`),
  KEY `fk_meta_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_meta_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meta`
--

LOCK TABLES `meta` WRITE;
/*!40000 ALTER TABLE `meta` DISABLE KEYS */;
/*!40000 ALTER TABLE `meta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_detalle`
--

DROP TABLE IF EXISTS `movimiento_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento_detalle` (
  `Linea` int(11) NOT NULL AUTO_INCREMENT,
  `pkidMovimiento` int(11) NOT NULL,
  `pkidmovimiento_general` int(11) NOT NULL,
  PRIMARY KEY (`Linea`,`pkidMovimiento`,`pkidmovimiento_general`),
  KEY `fk_movimiento_detalle_movimiento_encabezado1_idx` (`pkidMovimiento`),
  KEY `fk_movimiento_detalle_movimiento_general1_idx` (`pkidmovimiento_general`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_encabezado1` FOREIGN KEY (`pkidMovimiento`) REFERENCES `movimiento_encabezado` (`pkidMovimiento`),
  CONSTRAINT `fk_movimiento_detalle_movimiento_general1` FOREIGN KEY (`pkidmovimiento_general`) REFERENCES `movimiento_general` (`pkidmovimiento_general`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_detalle`
--

LOCK TABLES `movimiento_detalle` WRITE;
/*!40000 ALTER TABLE `movimiento_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_encabezado`
--

DROP TABLE IF EXISTS `movimiento_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento_encabezado` (
  `pkidMovimiento` int(11) NOT NULL,
  `pkcodigoempleado` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidMovimiento`,`pkcodigoempleado`),
  KEY `fk_movimiento_encabezado_empleado1_idx` (`pkcodigoempleado`),
  CONSTRAINT `fk_movimiento_encabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_encabezado`
--

LOCK TABLES `movimiento_encabezado` WRITE;
/*!40000 ALTER TABLE `movimiento_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimiento_general`
--

DROP TABLE IF EXISTS `movimiento_general`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimiento_general` (
  `pkidmovimiento_general` int(11) NOT NULL AUTO_INCREMENT,
  `pkidProducto` int(11) DEFAULT NULL,
  `concepto` varchar(45) DEFAULT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`pkidmovimiento_general`),
  KEY `fk_movimiento_general_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_movimiento_general_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimiento_general`
--

LOCK TABLES `movimiento_general` WRITE;
/*!40000 ALTER TABLE `movimiento_general` DISABLE KEYS */;
/*!40000 ALTER TABLE `movimiento_general` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina_encabezado`
--

DROP TABLE IF EXISTS `nomina_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nomina_encabezado` (
  `pkcodigonomina` int(11) NOT NULL,
  `tipo_nomina` tinyint(4) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafin` date DEFAULT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `Observaciones` varchar(45) DEFAULT NULL,
  `saldo_total` double DEFAULT '0',
  PRIMARY KEY (`pkcodigonomina`),
  KEY `fk_nomina_encabezado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_nomina_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina_encabezado`
--

LOCK TABLES `nomina_encabezado` WRITE;
/*!40000 ALTER TABLE `nomina_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `nomina_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nominadetalle`
--

DROP TABLE IF EXISTS `nominadetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nominadetalle` (
  `pkcodigonomina` int(11) NOT NULL,
  `cod_linea` int(11) NOT NULL,
  `subtotal_percepcion` double DEFAULT NULL,
  `subtotal_deduccion` double DEFAULT NULL,
  `nominadetallecol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigonomina`,`cod_linea`),
  CONSTRAINT `fk_nominadetalle_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nominadetalle`
--

LOCK TABLES `nominadetalle` WRITE;
/*!40000 ALTER TABLE `nominadetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `nominadetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencompradetalle`
--

DROP TABLE IF EXISTS `ordencompradetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordencompradetalle` (
  `pkIdCompraDetalle` int(11) NOT NULL,
  `fkIdordenCompraEncabezado` int(11) DEFAULT NULL,
  `codigoLinea` int(11) NOT NULL AUTO_INCREMENT,
  `fkIdProducto` int(11) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `subTotal` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`codigoLinea`,`pkIdCompraDetalle`),
  KEY `fk_ordenCompraDetalle_ordenComrpaEncabezado1_idx` (`fkIdordenCompraEncabezado`),
  KEY `fk_ordenCompraDetalle_producto1_idx` (`fkIdProducto`),
  CONSTRAINT `fk_ordenCompraDetalle_ordenComrpaEncabezado1` FOREIGN KEY (`fkIdordenCompraEncabezado`) REFERENCES `ordencomrpaencabezado` (`pkIdOrdenCompraEncabezado`),
  CONSTRAINT `fk_ordenCompraDetalle_producto1` FOREIGN KEY (`fkIdProducto`) REFERENCES `producto` (`pkidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencompradetalle`
--

LOCK TABLES `ordencompradetalle` WRITE;
/*!40000 ALTER TABLE `ordencompradetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencompradetalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordencomrpaencabezado`
--

DROP TABLE IF EXISTS `ordencomrpaencabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordencomrpaencabezado` (
  `pkIdOrdenCompraEncabezado` int(11) NOT NULL,
  `fkIdProveedor` int(11) DEFAULT NULL,
  `fkIdFormaPago` int(11) DEFAULT NULL,
  `fechaPedido` date DEFAULT NULL,
  `fechaRequerida` date DEFAULT NULL,
  `pkcodigoempleado` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `totalImpuesto` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkIdOrdenCompraEncabezado`),
  KEY `fk_ordenComrpaEncabezado_formasPago1_idx` (`fkIdFormaPago`),
  KEY `fk_ordenComrpaEncabezado_empleado1_idx` (`pkcodigoempleado`),
  KEY `fk_ordenComrpaEncabezado_proveedor1_idx` (`fkIdProveedor`),
  CONSTRAINT `fk_ordenComrpaEncabezado_empleado1` FOREIGN KEY (`pkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_ordenComrpaEncabezado_formasPago1` FOREIGN KEY (`fkIdFormaPago`) REFERENCES `formaspago` (`pkIdFormaPago`),
  CONSTRAINT `fk_ordenComrpaEncabezado_proveedor1` FOREIGN KEY (`fkIdProveedor`) REFERENCES `proveedor` (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordencomrpaencabezado`
--

LOCK TABLES `ordencomrpaencabezado` WRITE;
/*!40000 ALTER TABLE `ordencomrpaencabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordencomrpaencabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_detalle`
--

DROP TABLE IF EXISTS `perfil_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_detalle` (
  `fkcodperfil` int(11) NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `graduado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`fkcodperfil`),
  CONSTRAINT `fk_perfil_detalle_perfil_encabezado1` FOREIGN KEY (`fkcodperfil`) REFERENCES `perfil_encabezado` (`pkcodperfil`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_detalle`
--

LOCK TABLES `perfil_detalle` WRITE;
/*!40000 ALTER TABLE `perfil_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `perfil_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil_encabezado`
--

DROP TABLE IF EXISTS `perfil_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfil_encabezado` (
  `pkcodperfil` int(11) NOT NULL,
  `fkcodigopuesto` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodperfil`),
  KEY `fk_perfil_encabezado_puesto1_idx` (`fkcodigopuesto`),
  CONSTRAINT `fk_perfil_encabezado_puesto1` FOREIGN KEY (`fkcodigopuesto`) REFERENCES `puesto` (`pkcodigopuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil_encabezado`
--

LOCK TABLES `perfil_encabezado` WRITE;
/*!40000 ALTER TABLE `perfil_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `perfil_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_detalle`
--

DROP TABLE IF EXISTS `poliza_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_detalle` (
  `cod_linea` int(11) NOT NULL AUTO_INCREMENT,
  `pkcodigopoliza` int(11) NOT NULL,
  `cuentas` varchar(25) DEFAULT NULL,
  `Debe` int(11) DEFAULT NULL,
  `Haber` int(11) DEFAULT NULL,
  PRIMARY KEY (`cod_linea`,`pkcodigopoliza`),
  KEY `fk_poliza_detalle_poliza_encabezado1` (`pkcodigopoliza`),
  CONSTRAINT `fk_poliza_detalle_poliza_encabezado1` FOREIGN KEY (`pkcodigopoliza`) REFERENCES `poliza_encabezado` (`pkcodigopoliza`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_detalle`
--

LOCK TABLES `poliza_detalle` WRITE;
/*!40000 ALTER TABLE `poliza_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `poliza_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poliza_encabezado`
--

DROP TABLE IF EXISTS `poliza_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poliza_encabezado` (
  `pkcodigopoliza` int(11) NOT NULL,
  `pkcodigonomina` int(11) NOT NULL,
  `fechainicio` int(21) DEFAULT NULL,
  `fechafin` int(21) DEFAULT NULL,
  PRIMARY KEY (`pkcodigopoliza`,`pkcodigonomina`),
  KEY `fk_poliza_encabezado_nomina_encabezado1_idx` (`pkcodigonomina`),
  CONSTRAINT `fk_poliza_encabezado_nomina_encabezado1` FOREIGN KEY (`pkcodigonomina`) REFERENCES `nomina_encabezado` (`pkcodigonomina`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poliza_encabezado`
--

LOCK TABLES `poliza_encabezado` WRITE;
/*!40000 ALTER TABLE `poliza_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `poliza_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `pkidProveedor` int(11) NOT NULL,
  `pkidProducto` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Precio` decimal(3,0) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Presentacion` varchar(45) DEFAULT NULL,
  `Costo` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  `pktipo_producto` int(11) NOT NULL,
  PRIMARY KEY (`pkidProducto`,`pkidProveedor`),
  KEY `fk_Producto_Tipo Producto1_idx` (`pktipo_producto`),
  KEY `fk_Producto_Proveedor1_idx` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Proveedor1` FOREIGN KEY (`pkidProveedor`) REFERENCES `proveedor` (`pkidProveedor`),
  CONSTRAINT `fk_Producto_Tipo Producto1` FOREIGN KEY (`pktipo_producto`) REFERENCES `tipo producto` (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productoenbodega`
--

DROP TABLE IF EXISTS `productoenbodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productoenbodega` (
  `pkidBodega` int(11) NOT NULL,
  `pkidProducto` int(11) NOT NULL,
  `Existencias` int(11) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkidBodega`,`pkidProducto`),
  KEY `fk_ProductoenBodega_Bodega1_idx` (`pkidBodega`),
  KEY `fk_productoenbodega_producto1_idx` (`pkidProducto`),
  CONSTRAINT `fk_productoenbodega_bodega1` FOREIGN KEY (`pkidBodega`) REFERENCES `bodega` (`pkidBodega`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_productoenbodega_producto1` FOREIGN KEY (`pkidProducto`) REFERENCES `producto` (`pkidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productoenbodega`
--

LOCK TABLES `productoenbodega` WRITE;
/*!40000 ALTER TABLE `productoenbodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `productoenbodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `pkidProveedor` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` int(11) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puesto`
--

DROP TABLE IF EXISTS `puesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puesto` (
  `pkcodigopuesto` int(11) NOT NULL,
  `fkcodigoempleado` int(11) NOT NULL,
  `fkcodigodepto` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `sueldo` double DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkcodigopuesto`),
  KEY `fk_puesto_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_puesto_departamentos1_idx` (`fkcodigodepto`),
  CONSTRAINT `fk_puesto_departamentos1` FOREIGN KEY (`fkcodigodepto`) REFERENCES `departamentos` (`pkcodigodepto`),
  CONSTRAINT `fk_puesto_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puesto`
--

LOCK TABLES `puesto` WRITE;
/*!40000 ALTER TABLE `puesto` DISABLE KEYS */;
/*!40000 ALTER TABLE `puesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reuniones`
--

DROP TABLE IF EXISTS `reuniones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reuniones` (
  `pkcodigoreuniones` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombrereunion` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fechainicio` time DEFAULT NULL,
  `fechafinal` time DEFAULT NULL,
  `horainicio` datetime DEFAULT NULL,
  `horafinal` datetime DEFAULT NULL,
  `cantidadempleados` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigoreuniones`),
  KEY `fk_reuniones_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_reuniones_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reuniones`
--

LOCK TABLES `reuniones` WRITE;
/*!40000 ALTER TABLE `reuniones` DISABLE KEYS */;
/*!40000 ALTER TABLE `reuniones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ruta` (
  `pkidruta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidruta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sancionempleado`
--

DROP TABLE IF EXISTS `sancionempleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sancionempleado` (
  `pkcodigosansionempleado` int(11) NOT NULL AUTO_INCREMENT,
  `fkcodigoempleado` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descipcion` varchar(45) DEFAULT NULL,
  `fechainicio` date DEFAULT NULL,
  `fechafinal` date DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkcodigosansionempleado`),
  KEY `fk_sancionempleado_empleado1_idx` (`fkcodigoempleado`),
  CONSTRAINT `fk_sancionempleado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sancionempleado`
--

LOCK TABLES `sancionempleado` WRITE;
/*!40000 ALTER TABLE `sancionempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `sancionempleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sucursal` (
  `pkidsucursal` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidsucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bancotalento`
--

DROP TABLE IF EXISTS `tbl_bancotalento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_bancotalento` (
  `pkBancoTalento` int(11) NOT NULL AUTO_INCREMENT,
  `fkCurriculum` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkBancoTalento`,`fkCurriculum`),
  KEY `FK_Curriculum_BancoT` (`fkCurriculum`),
  CONSTRAINT `FK_Curriculum_BancoT` FOREIGN KEY (`fkCurriculum`) REFERENCES `tbl_curriculums` (`pkidCurriculum`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bancotalento`
--

LOCK TABLES `tbl_bancotalento` WRITE;
/*!40000 ALTER TABLE `tbl_bancotalento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bancotalento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_curriculums`
--

DROP TABLE IF EXISTS `tbl_curriculums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_curriculums` (
  `pkidCurriculum` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Numero` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Correo_Electronico` varchar(45) DEFAULT NULL,
  `Primaria` tinyint(1) DEFAULT NULL,
  `Secundaria` tinyint(1) DEFAULT NULL,
  `Bachillerato` tinyint(1) DEFAULT NULL,
  `Estudiante_Universitario` tinyint(1) DEFAULT NULL,
  `GraduadoU` tinyint(1) DEFAULT NULL,
  `CursoExtra` tinyint(1) DEFAULT NULL,
  `DescripcionCursos` varchar(100) DEFAULT NULL,
  `Experiencia_Previa` varchar(45) DEFAULT NULL,
  `SueldoEsperado` double DEFAULT NULL,
  `fksolicitudempleado` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkidCurriculum`),
  KEY `FK_solicitud_empleado_encabezado_Curriculums` (`fksolicitudempleado`),
  CONSTRAINT `FK_solicitud_empleado_encabezado_Curriculums` FOREIGN KEY (`fksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_curriculums`
--

LOCK TABLES `tbl_curriculums` WRITE;
/*!40000 ALTER TABLE `tbl_curriculums` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_curriculums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_detalle`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_solicitud_empleado_detalle` (
  `pksolicitudempleado` int(11) NOT NULL,
  `primaria` tinyint(1) DEFAULT NULL,
  `secundaria` tinyint(1) DEFAULT NULL,
  `bachillerato` tinyint(1) DEFAULT NULL,
  `estudiante_U` tinyint(1) DEFAULT NULL,
  `grado_U` tinyint(1) DEFAULT NULL,
  `curso_extra` tinyint(1) DEFAULT NULL,
  `descripcion_curso` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_detalle_tbl_solicitud_empleado_enca1` FOREIGN KEY (`pksolicitudempleado`) REFERENCES `tbl_solicitud_empleado_encabezado` (`pksolicitudempleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_detalle`
--

LOCK TABLES `tbl_solicitud_empleado_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_solicitud_empleado_encabezado`
--

DROP TABLE IF EXISTS `tbl_solicitud_empleado_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_solicitud_empleado_encabezado` (
  `pksolicitudempleado` int(11) NOT NULL,
  `fkcodigoempleado` int(11) DEFAULT NULL,
  `fkcodigocontratacion` int(11) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pksolicitudempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_empleado1_idx` (`fkcodigoempleado`),
  KEY `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1_idx` (`fkcodigocontratacion`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_empleado1` FOREIGN KEY (`fkcodigoempleado`) REFERENCES `empleado` (`pkcodigoempleado`),
  CONSTRAINT `fk_tbl_solicitud_empleado_encabezado_tipocontratacion1` FOREIGN KEY (`fkcodigocontratacion`) REFERENCES `tipocontratacion` (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_solicitud_empleado_encabezado`
--

LOCK TABLES `tbl_solicitud_empleado_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_solicitud_empleado_encabezado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo producto`
--

DROP TABLE IF EXISTS `tipo producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo producto` (
  `pktipo_producto` int(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pktipo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo producto`
--

LOCK TABLES `tipo producto` WRITE;
/*!40000 ALTER TABLE `tipo producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_usuario` (
  `pktipousuario` int(10) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`pktipousuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipobodega`
--

DROP TABLE IF EXISTS `tipobodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipobodega` (
  `pkidtipobodega` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `capacidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtipobodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipobodega`
--

LOCK TABLES `tipobodega` WRITE;
/*!40000 ALTER TABLE `tipobodega` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipobodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocontratacion`
--

DROP TABLE IF EXISTS `tipocontratacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipocontratacion` (
  `pkcodigocontratacion` int(11) NOT NULL,
  `PorContrato` varchar(45) DEFAULT NULL,
  `PorMeses` varchar(45) DEFAULT NULL,
  `PorProyecto` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pkcodigocontratacion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocontratacion`
--

LOCK TABLES `tipocontratacion` WRITE;
/*!40000 ALTER TABLE `tipocontratacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipocontratacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipotransporte`
--

DROP TABLE IF EXISTS `tipotransporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipotransporte` (
  `pkidtipotransporte` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `capacidad` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtipotransporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipotransporte`
--

LOCK TABLES `tipotransporte` WRITE;
/*!40000 ALTER TABLE `tipotransporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipotransporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transporte`
--

DROP TABLE IF EXISTS `transporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transporte` (
  `pkidtransporte` int(11) NOT NULL AUTO_INCREMENT,
  `fkidruta` int(11) NOT NULL,
  `fkidtipotransporte` int(11) NOT NULL,
  `placa` varchar(45) DEFAULT NULL,
  `chasis` varchar(45) DEFAULT NULL,
  `motor` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`pkidtransporte`),
  KEY `fk_transporte_ruta1_idx` (`fkidruta`),
  KEY `fk_transporte_tipotransporte1_idx` (`fkidtipotransporte`),
  CONSTRAINT `fk_transporte_ruta1` FOREIGN KEY (`fkidruta`) REFERENCES `ruta` (`pkidruta`),
  CONSTRAINT `fk_transporte_tipotransporte1` FOREIGN KEY (`fkidtipotransporte`) REFERENCES `tipotransporte` (`pkidtipotransporte`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transporte`
--

LOCK TABLES `transporte` WRITE;
/*!40000 ALTER TABLE `transporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `transporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `pkusuario` int(10) NOT NULL AUTO_INCREMENT,
  `pktipousuario` int(10) NOT NULL,
  `nombreusuario` varchar(45) DEFAULT NULL,
  `passusuario` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `foto_ubicacion` varchar(90) DEFAULT NULL,
  PRIMARY KEY (`pkusuario`,`pktipousuario`),
  KEY `fk_usuario_tipo_usuario1_idx` (`pktipousuario`),
  CONSTRAINT `fk_usuario_tipo_usuario1` FOREIGN KEY (`pktipousuario`) REFERENCES `tipo_usuario` (`pktipousuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-15 16:25:40
