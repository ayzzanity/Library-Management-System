-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 26, 2018 at 11:46 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `bookID` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `author` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`bookID`, `title`, `author`, `status`) VALUES
(3, 'A Song of Ice and Fire', 'George R. R. Martin', 'Available'),
(4, 'A Game of Thrones', 'George R. R. Martin', 'Available'),
(5, 'A Clash of Kings', 'George R. R. Martin', 'Available'),
(6, 'A Storm of Swords', 'George R. R. Martin', 'Available'),
(7, 'A Feast for Crows', 'George R. R. Martin', 'Available'),
(8, 'A Dance With Dragons', 'George R. R. Martin', 'Available'),
(10, 'Artemis', 'Andy Weir', 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `borrowers`
--

CREATE TABLE `borrowers` (
  `borrowerID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL,
  `memberID` int(11) NOT NULL,
  `borrowdate` date NOT NULL,
  `duedate` date NOT NULL,
  `returndate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrowers`
--

INSERT INTO `borrowers` (`borrowerID`, `bookID`, `memberID`, `borrowdate`, `duedate`, `returndate`) VALUES
(8, 3, 11, '2018-03-27', '2018-04-03', '2018-03-27'),
(9, 4, 11, '2018-03-27', '2018-04-03', '2018-03-27'),
(10, 5, 10, '2018-03-27', '2018-04-03', '2018-03-27'),
(11, 3, 11, '2018-03-27', '2018-04-03', '2018-03-27'),
(12, 6, 10, '2018-03-27', '2018-04-03', '2018-03-27'),
(13, 6, 11, '2018-03-27', '2018-04-03', '2018-03-27'),
(14, 3, 11, '2018-03-27', '2018-04-03', '2018-03-27'),
(15, 3, 11, '2018-03-27', '2018-04-03', '2018-03-27');

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `memberID` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `membershipdate` date NOT NULL,
  `expirydate` date NOT NULL,
  `membershiptype` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`memberID`, `firstname`, `lastname`, `membershipdate`, `expirydate`, `membershiptype`) VALUES
(9, 'Hayley', 'Williams', '2018-03-27', '2019-03-27', 'Premium Member'),
(10, 'Ayzal ', 'Abdulwahid', '2018-03-27', '2019-03-27', 'Premium Member'),
(11, 'Arleen', 'Tan Sanchez', '2018-03-27', '2019-03-27', 'Regular Member');

-- --------------------------------------------------------

--
-- Table structure for table `publishers`
--

CREATE TABLE `publishers` (
  `publisherID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL,
  `publishername` varchar(100) NOT NULL,
  `title` varchar(100) NOT NULL,
  `author` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `publishers`
--

INSERT INTO `publishers` (`publisherID`, `bookID`, `publishername`, `title`, `author`) VALUES
(1, 101, 'Pearson', 'The Future is History: How Totalitarianism Reclaimed Russia', 'Masha Gessen'),
(2, 102, 'RELX Group', 'Sing, Unburied, Sing', 'Jesmyn Ward'),
(3, 103, 'Pearson', 'Artemis', 'Andy Weir'),
(4, 104, 'ThomsonReuters', 'hey Can’t Kill Us Until They Kill Us', 'Hanif Abdurraqib'),
(5, 105, 'ThomsonReuters', 'Three Daughters of Eve', 'Elif Shafak'),
(6, 106, 'RELX Group', 'Heather, The Totality', 'Matthew Weiner'),
(7, 107, 'RELX Group', 'The State of Affairs: Rethinking Infidelity', 'Esther Perel'),
(8, 108, 'RELX Group', 'Manhattan Beach', 'Jennifer Egan');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`bookID`);

--
-- Indexes for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD PRIMARY KEY (`borrowerID`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`memberID`);

--
-- Indexes for table `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`publisherID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `bookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `borrowerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `memberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `publishers`
--
ALTER TABLE `publishers`
  MODIFY `publisherID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
