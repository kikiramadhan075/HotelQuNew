/*
SQLyog - Free MySQL GUI v5.19
Host - 5.1.41 : Database - db_penginapan
*********************************************************************
Server version : 5.1.41
*/

SET NAMES utf8;

SET SQL_MODE='';

create database if not exists `db_penginapan`;

USE `db_penginapan`;

SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO';

/*Table structure for table `tbl_kamar` */

DROP TABLE IF EXISTS `tbl_kamar`;

CREATE TABLE `tbl_kamar` (
  `id_kamar` int(10) NOT NULL AUTO_INCREMENT,
  `id_tipe_kamar` int(10) NOT NULL,
  `deskripsi` text NOT NULL,
  `status` varchar(1) NOT NULL,
  PRIMARY KEY (`id_kamar`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_kamar` */

insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (1,1,'Dilengkapi dengan AC, double bad, shower, dan televisi','N');
insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (2,1,'Dilengkapi dengan AC, double bad, shower, dan televisi','N');
insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (3,1,'Dilengkapi dengan AC, double bad, shower, dan televisi','Y');
insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (4,2,'Dilengkapi dengan AC, double bad, shower, dan televisi. Kamar yang nyaman, dijamin anda akan puas.','N');
insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (5,2,'Dilengkapi dengan AC, double bad, shower, dan televisi. Kamar yang nyaman, dijamin anda akan puas.','N');
insert into `tbl_kamar` (`id_kamar`,`id_tipe_kamar`,`deskripsi`,`status`) values (6,1,'Dilengkapi dengan AC, double bad, shower, dan televisi','N');

/*Table structure for table `tbl_menu` */

DROP TABLE IF EXISTS `tbl_menu`;

CREATE TABLE `tbl_menu` (
  `id_menu` int(10) NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `harga` int(10) NOT NULL,
  PRIMARY KEY (`id_menu`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_menu` */

insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (1,'Nasi Goreng Biasa',10000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (2,'Nasi Goreng Spesial',18000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (3,'Rujak Soto',8000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (4,'Sop Buntut Spesial',13000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (5,'Ayam Bakar Kalasan',14000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (6,'Ayam Goreng Crispy',12000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (7,'Es Jeruk',5000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (8,'Es Degan Susu',4000);
insert into `tbl_menu` (`id_menu`,`nama`,`harga`) values (9,'Es Cappucino',8000);

/*Table structure for table `tbl_pembayaran` */

DROP TABLE IF EXISTS `tbl_pembayaran`;

CREATE TABLE `tbl_pembayaran` (
  `id_pembayaran` int(10) NOT NULL AUTO_INCREMENT,
  `id_reservasi` int(10) NOT NULL,
  `id_tamu` int(10) NOT NULL,
  `id_kamar` int(10) NOT NULL,
  `id_tipe_kamar` int(10) NOT NULL,
  `id_user` int(10) NOT NULL,
  `total_bayar` int(30) NOT NULL,
  `bulan` varchar(5) NOT NULL,
  `tahun` varchar(5) NOT NULL,
  PRIMARY KEY (`id_pembayaran`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_pembayaran` */

insert into `tbl_pembayaran` (`id_pembayaran`,`id_reservasi`,`id_tamu`,`id_kamar`,`id_tipe_kamar`,`id_user`,`total_bayar`,`bulan`,`tahun`) values (1,4,1,5,1,2,820000,'1','2011');
insert into `tbl_pembayaran` (`id_pembayaran`,`id_reservasi`,`id_tamu`,`id_kamar`,`id_tipe_kamar`,`id_user`,`total_bayar`,`bulan`,`tahun`) values (2,5,2,1,2,2,1228000,'1','2011');

/*Table structure for table `tbl_pesanan` */

DROP TABLE IF EXISTS `tbl_pesanan`;

CREATE TABLE `tbl_pesanan` (
  `id_pesanan` int(10) NOT NULL AUTO_INCREMENT,
  `id_reservasi` int(10) NOT NULL,
  `id_menu` int(10) NOT NULL,
  `jumlah_pesanan` int(10) NOT NULL,
  `tgl` varchar(20) NOT NULL,
  PRIMARY KEY (`id_pesanan`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_pesanan` */

insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (1,4,1,2,'23/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (2,5,1,2,'23/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (3,5,8,2,'23/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (4,6,5,3,'23/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (5,6,9,5,'23/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (6,6,6,2,'24/01/2011');
insert into `tbl_pesanan` (`id_pesanan`,`id_reservasi`,`id_menu`,`jumlah_pesanan`,`tgl`) values (7,6,8,3,'24/01/2011');

/*Table structure for table `tbl_reservasi` */

DROP TABLE IF EXISTS `tbl_reservasi`;

CREATE TABLE `tbl_reservasi` (
  `id_reservasi` int(10) NOT NULL AUTO_INCREMENT,
  `id_tamu` int(10) NOT NULL,
  `id_user` int(10) NOT NULL,
  `id_tipe_kamar` int(10) NOT NULL,
  `id_kamar` int(10) NOT NULL,
  `tgl_cek_in` varchar(20) NOT NULL,
  `tgl_cek_out` varchar(20) NOT NULL,
  `lama_menginap` varchar(20) NOT NULL,
  `status` varchar(1) NOT NULL,
  PRIMARY KEY (`id_reservasi`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_reservasi` */

insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (1,1,2,1,3,'23/01/2011','25/01/2011','2','Y');
insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (2,3,2,1,3,'23/01/2011','26/01/2011','3','Y');
insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (3,2,2,1,2,'23/01/2011','28/01/2011','5','Y');
insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (4,1,2,2,5,'23/01/2011','25/01/2011','2','Y');
insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (5,2,2,1,1,'23/01/2011','29/01/2011','6','Y');
insert into `tbl_reservasi` (`id_reservasi`,`id_tamu`,`id_user`,`id_tipe_kamar`,`id_kamar`,`tgl_cek_in`,`tgl_cek_out`,`lama_menginap`,`status`) values (6,2,2,1,3,'23/01/2011','29/01/2011','6','N');

/*Table structure for table `tbl_tamu` */

DROP TABLE IF EXISTS `tbl_tamu`;

CREATE TABLE `tbl_tamu` (
  `id_tamu` int(10) NOT NULL AUTO_INCREMENT,
  `nama_tamu` varchar(100) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telpon` varchar(20) NOT NULL,
  `jk` varchar(1) NOT NULL,
  `pekerjaan` varchar(100) NOT NULL,
  PRIMARY KEY (`id_tamu`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_tamu` */

insert into `tbl_tamu` (`id_tamu`,`nama_tamu`,`alamat`,`no_telpon`,`jk`,`pekerjaan`) values (1,'Gede Suma Wijaya','Denpasar','081916186418','L','Kuli Coding');
insert into `tbl_tamu` (`id_tamu`,`nama_tamu`,`alamat`,`no_telpon`,`jk`,`pekerjaan`) values (2,'Willy Witanto','Banyuwangi','081805394038','L','Kuli Jaringan');
insert into `tbl_tamu` (`id_tamu`,`nama_tamu`,`alamat`,`no_telpon`,`jk`,`pekerjaan`) values (3,'Ayus Nyemplung','Banyuwangi','081236987343','L','Kuli HaPe');
insert into `tbl_tamu` (`id_tamu`,`nama_tamu`,`alamat`,`no_telpon`,`jk`,`pekerjaan`) values (4,'Puji Agustian AW','Rogojampi','081555799323','L','Kuli Coding');
insert into `tbl_tamu` (`id_tamu`,`nama_tamu`,`alamat`,`no_telpon`,`jk`,`pekerjaan`) values (5,'Untung Jasuli','Situbondo Rock City','081999345678','L','Kuli Coding');

/*Table structure for table `tbl_tipe_kamar` */

DROP TABLE IF EXISTS `tbl_tipe_kamar`;

CREATE TABLE `tbl_tipe_kamar` (
  `id_tipe_kamar` int(10) NOT NULL AUTO_INCREMENT,
  `nama` varchar(30) NOT NULL,
  `harga` int(10) NOT NULL,
  PRIMARY KEY (`id_tipe_kamar`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_tipe_kamar` */

insert into `tbl_tipe_kamar` (`id_tipe_kamar`,`nama`,`harga`) values (1,'Eksekutif',200000);
insert into `tbl_tipe_kamar` (`id_tipe_kamar`,`nama`,`harga`) values (2,'VIP',400000);
insert into `tbl_tipe_kamar` (`id_tipe_kamar`,`nama`,`harga`) values (3,'Standar',100000);
insert into `tbl_tipe_kamar` (`id_tipe_kamar`,`nama`,`harga`) values (4,'Super VIP',600000);
insert into `tbl_tipe_kamar` (`id_tipe_kamar`,`nama`,`harga`) values (5,'Melati',50000);

/*Table structure for table `tbl_user` */

DROP TABLE IF EXISTS `tbl_user`;

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `nama_lengkap` varchar(100) NOT NULL,
  `kelahiran` varchar(100) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_user` */

insert into `tbl_user` (`id_user`,`username`,`password`,`nama_lengkap`,`kelahiran`) values (1,'lumbung','lumbung','Gede Suma Wijaya','Denpasar, 4 Februari 1991');
insert into `tbl_user` (`id_user`,`username`,`password`,`nama_lengkap`,`kelahiran`) values (2,'gede','gede','Wayan Gede Suma Wijaya','Denpasar, 4 Februari 1991');

/* Procedure structure for procedure `CariBerdasarkanNamaTamu` */

drop procedure if exists `CariBerdasarkanNamaTamu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariBerdasarkanNamaTamu`(nama varchar(100))
BEGIN
select tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_tamu.nama_tamu like nama;
END$$

DELIMITER ;

/* Procedure structure for procedure `CariBerdasarkanTipeKamar` */

drop procedure if exists `CariBerdasarkanTipeKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariBerdasarkanTipeKamar`(id int(10))
BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_kamar.id_tipe_kamar=id;
END$$

DELIMITER ;

/* Procedure structure for procedure `CariKamarBerdasarkanNoKamar` */

drop procedure if exists `CariKamarBerdasarkanNoKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariKamarBerdasarkanNoKamar`(no int(10))
BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where id_kamar=no;
END$$

DELIMITER ;

/* Procedure structure for procedure `CariPesananIdReservasi` */

drop procedure if exists `CariPesananIdReservasi`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariPesananIdReservasi`(nm int(5))
BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_reservasi.id_reservasi=nm;
END$$

DELIMITER ;

/* Procedure structure for procedure `CariPesananTglNoKamar` */

drop procedure if exists `CariPesananTglNoKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariPesananTglNoKamar`(tgl varchar(10), nm int(5))
BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_pesanan.tgl=tgl and tbl_reservasi.id_kamar=nm;
END$$

DELIMITER ;

/* Procedure structure for procedure `CariReservasi` */

drop procedure if exists `CariReservasi`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasi`()
BEGIN
select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.status='N';
END$$

DELIMITER ;

/* Procedure structure for procedure `CariReservasiBerdasarkanKamar` */

drop procedure if exists `CariReservasiBerdasarkanKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasiBerdasarkanKamar`(no int(10))
BEGIN
select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.id_kamar=no and tbl_reservasi.status='N';
END$$

DELIMITER ;

/* Procedure structure for procedure `CariReservasiBerdasarkanKamar2` */

drop procedure if exists `CariReservasiBerdasarkanKamar2`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CariReservasiBerdasarkanKamar2`(no int(10))
BEGIN
select id_reservasi, nama_tamu, tbl_kamar.id_kamar, tgl_cek_in, tgl_cek_out from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.id_kamar=no and tbl_reservasi.status='N';
END$$

DELIMITER ;

/* Procedure structure for procedure `CekOut` */

drop procedure if exists `CekOut`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CekOut`(idRs int(10), idTm int(10), idKm int(10), idTip int(10), idUs int(10), tot int(20), tgByr varchar(20), thnByr varchar(20))
BEGIN
insert into tbl_pembayaran (id_reservasi, id_tamu, id_kamar, id_tipe_kamar, id_user, total_bayar, bulan, tahun) values (idRs, idTm, idKm, idTip, idUs, tot, tgByr, thnByr);
END$$

DELIMITER ;

/* Procedure structure for procedure `DataReservasi` */

drop procedure if exists `DataReservasi`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DataReservasi`()
BEGIN
select id_reservasi, tbl_kamar.id_kamar, nama_tamu, nama, harga, tgl_cek_in, tgl_cek_out, lama_menginap, (harga*lama_menginap) as total, tbl_tamu.id_tamu, tbl_tipe_kamar.id_tipe_kamar from tbl_reservasi left join (tbl_kamar, tbl_tamu, tbl_tipe_kamar) on tbl_reservasi.id_kamar=tbl_kamar.id_kamar and tbl_reservasi.id_tamu=tbl_tamu.id_tamu and tbl_reservasi.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar where tbl_reservasi.status='N';
END$$

DELIMITER ;

/* Procedure structure for procedure `ExportLaporan` */

drop procedure if exists `ExportLaporan`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ExportLaporan`(bln int(10), thn int(10))
BEGIN
select nama_tamu, tbl_kamar.id_kamar, total_bayar, bulan, tahun, username from tbl_pembayaran left join (tbl_tamu,tbl_kamar,tbl_user) on tbl_pembayaran.id_tamu=tbl_tamu.id_tamu and tbl_pembayaran.id_kamar=tbl_kamar.id_kamar and tbl_pembayaran.id_user=tbl_user.id_user where bulan=bln and tahun=thn;
END$$

DELIMITER ;

/* Procedure structure for procedure `LihatLaporan` */

drop procedure if exists `LihatLaporan`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatLaporan`()
BEGIN
select nama_tamu, tbl_kamar.id_kamar, total_bayar, bulan, tahun, username from tbl_pembayaran left join (tbl_tamu,tbl_kamar,tbl_user) on tbl_pembayaran.id_tamu=tbl_tamu.id_tamu and tbl_pembayaran.id_kamar=tbl_kamar.id_kamar and tbl_pembayaran.id_user=tbl_user.id_user;
END$$

DELIMITER ;

/* Procedure structure for procedure `LihatPesananPerTamu` */

drop procedure if exists `LihatPesananPerTamu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LihatPesananPerTamu`(id int(10))
BEGIN
select id_kamar, nama, (harga*jumlah_pesanan) as total, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu where tbl_pesanan.id_reservasi=id;
END$$

DELIMITER ;

/* Procedure structure for procedure `loginUser` */

drop procedure if exists `loginUser`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loginUser`(user varchar(40), pass varchar(40))
BEGIN
select * from tbl_user where username='user' and password='pass';
END$$

DELIMITER ;

/* Procedure structure for procedure `TambahKamar` */

drop procedure if exists `TambahKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahKamar`(id_tipe int(10), deskr varchar(400), stts varchar(1))
BEGIN
insert into tbl_kamar (id_tipe_kamar, deskripsi, status) values (id_tipe, deskr, stts);
END$$

DELIMITER ;

/* Procedure structure for procedure `TambahMenu` */

drop procedure if exists `TambahMenu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahMenu`(nm varchar(100), hrg varchar(100))
BEGIN
insert into tbl_menu (nama, harga) values (nm, hrg);
END$$

DELIMITER ;

/* Procedure structure for procedure `TambahPesanan` */

drop procedure if exists `TambahPesanan`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahPesanan`(id_rs int(10), id_mn int(10), jml int(10), tgl varchar(10))
BEGIN
insert into tbl_pesanan (id_reservasi, id_menu, jumlah_pesanan, tgl) values(id_rs,id_mn,jml,tgl);
END$$

DELIMITER ;

/* Procedure structure for procedure `tambahReservasi` */

drop procedure if exists `tambahReservasi`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `tambahReservasi`(id_tamu int(10), id_user int(10), id_tipe_kamar int(10), id_kamar int(10), tgl_cek_in varchar(20), tgl_cek_out varchar(20), lama int(10))
BEGIN
insert into tbl_reservasi (id_tamu, id_user, id_tipe_kamar, id_kamar, tgl_cek_in, tgl_cek_out, lama_menginap, status) values (id_tamu, id_user, id_tipe_kamar, id_kamar, tgl_cek_in, tgl_cek_out, lama, 'N');
END$$

DELIMITER ;

/* Procedure structure for procedure `TambahTamu` */

drop procedure if exists `TambahTamu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahTamu`(nama varchar(100), almt varchar(100), tlpn varchar (40), jk varchar(1), kerja varchar(50))
BEGIN
insert into tbl_tamu (nama_tamu, alamat, no_telpon, jk, pekerjaan) values (nama, almt, tlpn, jk, kerja);
END$$

DELIMITER ;

/* Procedure structure for procedure `TambahTipeKamar` */

drop procedure if exists `TambahTipeKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TambahTipeKamar`(nama varchar(100), harga varchar(20))
BEGIN
insert into tbl_tipe_kamar (nama, harga) values (nama, harga);
END$$

DELIMITER ;

/* Procedure structure for procedure `TampilKamar` */

drop procedure if exists `TampilKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilKamar`()
BEGIN
select id_kamar, nama, deskripsi, harga, status from tbl_kamar left join tbl_tipe_kamar on tbl_kamar.id_tipe_kamar=tbl_tipe_kamar.id_tipe_kamar;
END$$

DELIMITER ;

/* Procedure structure for procedure `TampilMenu` */

drop procedure if exists `TampilMenu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilMenu`()
BEGIN
select * from tbl_menu;
END$$

DELIMITER ;

/* Procedure structure for procedure `TampilPesanan` */

drop procedure if exists `TampilPesanan`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilPesanan`()
BEGIN
select tbl_pesanan.id_reservasi, id_kamar, nama, tgl_cek_in, tgl_cek_out, tgl from tbl_pesanan left join (tbl_reservasi,tbl_menu) on tbl_pesanan.id_reservasi=tbl_reservasi.id_reservasi and tbl_pesanan.id_menu=tbl_menu.id_menu;
END$$

DELIMITER ;

/* Procedure structure for procedure `TampilTamu` */

drop procedure if exists `TampilTamu`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TampilTamu`()
BEGIN
select * from tbl_tamu;
END$$

DELIMITER ;

/* Procedure structure for procedure `TipeKamar` */

drop procedure if exists `TipeKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `TipeKamar`()
BEGIN
select * from tbl_tipe_kamar;
END$$

DELIMITER ;

/* Procedure structure for procedure `updateStatusKamar` */

drop procedure if exists `updateStatusKamar`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateStatusKamar`(id_kamar int(10))
BEGIN
update tbl_kamar set status='Y' where id_kamar='id_kamar';
END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
