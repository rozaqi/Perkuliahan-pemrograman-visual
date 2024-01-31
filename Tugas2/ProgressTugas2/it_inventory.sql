-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 31, 2024 at 01:24 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `it_inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `hosts`
--

CREATE TABLE `hosts` (
  `id` int(11) NOT NULL,
  `host_name` varchar(255) NOT NULL,
  `ram` varchar(255) NOT NULL,
  `cores_thread` varchar(255) NOT NULL,
  `disk` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hosts`
--

INSERT INTO `hosts` (`id`, `host_name`, `ram`, `cores_thread`, `disk`) VALUES
(1, 'Host10', '32GB', '6 Cores 12 Thread', '512GB SSD'),
(2, 'Host2', '64GB', '12 Cores 24 Thread', '512GB SSD');

-- --------------------------------------------------------

--
-- Table structure for table `ipam`
--

CREATE TABLE `ipam` (
  `id` int(100) NOT NULL,
  `ip_address` varchar(255) NOT NULL,
  `gateway` varchar(255) NOT NULL,
  `assign_to_vm` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ipam`
--

INSERT INTO `ipam` (`id`, `ip_address`, `gateway`, `assign_to_vm`) VALUES
(0, '192.168.1.2/24', '192.168.1.254', 'backend1'),
(1, '192.168.1.3/24', '192.168.1.254', 'database1'),
(2, '192.168.1.4/24', '192.168.1.254', 'website'),
(3, '192.168.1.5/24', '192.168.1.254', 'website5');

-- --------------------------------------------------------

--
-- Table structure for table `r_s`
--

CREATE TABLE `r_s` (
  `id` int(11) NOT NULL,
  `device_name` varchar(255) NOT NULL,
  `device_type` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `port` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `r_s`
--

INSERT INTO `r_s` (`id`, `device_name`, `device_type`, `type`, `port`) VALUES
(1, 'Switch10', 'Switch', 'Dell', 24),
(2, 'Router-Core02', 'Router', 'Juniper', 4),
(3, 'Router-Core03', 'Router', 'Cisco', 4),
(4, 'Switch_Management01', 'Switch', 'Cisco', 26);

-- --------------------------------------------------------

--
-- Table structure for table `vms`
--

CREATE TABLE `vms` (
  `id` int(11) NOT NULL,
  `vm_name` varchar(255) NOT NULL,
  `cluster` varchar(255) NOT NULL,
  `notes` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vms`
--

INSERT INTO `vms` (`id`, `vm_name`, `cluster`, `notes`) VALUES
(2, 'database1', 'Jakarta', 'VM ini digunakan untuk database Data Mahasiswa.'),
(3, 'website', 'Bogor', 'VM ini digunakan untuk menampilkan data mahasiswa dalam bentuk website'),
(4, 'website2', 'Banten', 'VM ini digunakan untuk menampilkan data mahasiswa dalam bentuk website2.'),
(5, 'website3', 'Banten', 'VM ini digunakan untuk menampilkan data mahasiswa dalam bentuk website3.'),
(6, 'website4', 'Banten', 'VM ini digunakan untuk menampilkan data mahasiswa dalam bentuk website4.'),
(7, 'website5', 'Banten', 'VM ini digunakan untuk menampilkan data mahasiswa dalam bentuk website5.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ipam`
--
ALTER TABLE `ipam`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vms`
--
ALTER TABLE `vms`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
