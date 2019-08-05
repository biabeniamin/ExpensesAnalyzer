-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 55555555, 2019 at 04:16 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `expensesanalyzer`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `AccountId` int(11) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Password` varchar(40) NOT NULL,
  `Balance` double NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`AccountId`, `Email`, `Password`, `Balance`, `CreationTime`) VALUES
(1, 'test@gmail.com', 'acetronic', 0, '2019-07-12 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`CategoryId`, `Name`, `CreationTime`) VALUES
(1, 'Fuel', '2019-07-21 15:36:41'),
(2, 'Haine', '2019-07-21 15:36:46'),
(3, 'Income', '2019-07-21 17:19:48'),
(4, 'Health', '2019-08-01 18:31:57'),
(5, 'Car', '2019-08-01 19:10:38'),
(6, 'Leisure', '2019-08-01 19:11:45');

-- --------------------------------------------------------

--
-- Table structure for table `categorizedmerchants`
--

CREATE TABLE `categorizedmerchants` (
  `CategorizedMerchantId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `MerchantId` int(11) NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `merchants`
--

CREATE TABLE `merchants` (
  `MerchantId` int(11) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `Name` varchar(40) NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `merchants`
--

INSERT INTO `merchants` (`MerchantId`, `CategoryId`, `Name`, `CreationTime`) VALUES
(1, 1, 'Rompretrol', '2019-07-21 15:36:53'),
(2, 2, 'Zara', '2019-07-21 15:42:54'),
(3, 3, 'Mama', '2019-07-21 17:19:55'),
(4, 4, 'Dentist', '2019-08-01 18:32:12'),
(5, 3, 'Utcn Burse', '2019-08-01 19:08:22'),
(6, 5, 'Features', '2019-08-01 19:10:57'),
(7, 6, 'Mare', '2019-08-01 19:11:52'),
(8, 3, 'Magura', '2019-08-01 19:12:45');

-- --------------------------------------------------------

--
-- Table structure for table `messages`
--

CREATE TABLE `messages` (
  `MessageId` int(11) NOT NULL,
  `Content` text NOT NULL,
  `Source` int(11) NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `notifications`
--

CREATE TABLE `notifications` (
  `NotificationId` int(11) NOT NULL,
  `Title` varchar(20) NOT NULL,
  `Message` text NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `TransactionId` int(11) NOT NULL,
  `AccountId` int(11) NOT NULL,
  `MerchantId` int(11) NOT NULL,
  `Value` double NOT NULL,
  `CreationTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`TransactionId`, `AccountId`, `MerchantId`, `Value`, `CreationTime`) VALUES
(6, 1, 1, 150, '2019-07-21 15:45:53'),
(7, 1, 3, -500, '2019-07-21 17:20:12'),
(12, 1, 4, 150, '2019-07-31 18:32:40'),
(13, 1, 5, -1000, '2019-08-28 19:08:37'),
(14, 1, 6, 150, '2019-07-31 19:11:10'),
(15, 1, 7, 150, '2019-07-27 19:12:05'),
(16, 1, 8, -200, '2019-07-27 19:13:04');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`AccountId`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `categorizedmerchants`
--
ALTER TABLE `categorizedmerchants`
  ADD PRIMARY KEY (`CategorizedMerchantId`);

--
-- Indexes for table `merchants`
--
ALTER TABLE `merchants`
  ADD PRIMARY KEY (`MerchantId`);

--
-- Indexes for table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`MessageId`);

--
-- Indexes for table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`NotificationId`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransactionId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `AccountId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `categorizedmerchants`
--
ALTER TABLE `categorizedmerchants`
  MODIFY `CategorizedMerchantId` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `merchants`
--
ALTER TABLE `merchants`
  MODIFY `MerchantId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `messages`
--
ALTER TABLE `messages`
  MODIFY `MessageId` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `NotificationId` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransactionId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
