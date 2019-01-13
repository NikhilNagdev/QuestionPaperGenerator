-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2018 at 07:54 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qpgenerator`
--

-- --------------------------------------------------------

--
-- Table structure for table `javachapters`
--

CREATE TABLE `javachapters` (
  `chapterId` int(3) NOT NULL,
  `chapterNo` int(2) NOT NULL,
  `weightage` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `javachapters`
--

INSERT INTO `javachapters` (`chapterId`, `chapterNo`, `weightage`) VALUES
(1, 1, 16),
(2, 2, 24),
(3, 3, 12),
(4, 4, 16),
(5, 5, 20),
(6, 6, 12);

-- --------------------------------------------------------

--
-- Table structure for table `javaquestions`
--

CREATE TABLE `javaquestions` (
  `qId` int(5) NOT NULL,
  `chapterNo` int(2) NOT NULL,
  `question` text NOT NULL,
  `marks` int(3) NOT NULL,
  `priority` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `javaquestions`
--

INSERT INTO `javaquestions` (`qId`, `chapterNo`, `question`, `marks`, `priority`) VALUES
(1, 1, 'this is 1st 4 marks question of chapter 1\r\n', 4, 10),
(2, 1, 'this is 2nd 4 marks question of chapter 1\r\n', 4, 10),
(3, 1, 'this is 3rd 4 marks question of chapter 1', 4, 10),
(4, 1, 'this is 4th 4 marks question of chapter 1', 4, 10),
(5, 1, 'this is 5th 4 marks question of chapter 1', 4, 10),
(6, 1, 'this is 6th 4 marks question of chapter 1', 4, 10),
(7, 1, 'this is 7th 4 marks question of chapter 1', 4, 10),
(8, 1, 'this is 8th marks question of chapter 1', 4, 10),
(9, 1, 'this is 9th marks question of chapter 1', 4, 10),
(10, 1, 'this is 10th marks question of chapter 1', 4, 10),
(11, 1, 'this is 1st 6 marks question of chapter 1', 6, 10),
(12, 1, 'this is 2nd 6 marks question of chapter 1', 6, 10),
(13, 1, 'this is 3rd 6 marks question of chapter 1', 6, 10),
(14, 1, 'this is 4th 6 marks question of chapter 1', 6, 10),
(15, 1, 'this is 1st 8 marks question of chapter 1', 8, 10),
(16, 1, 'this is 2nd 8 marks question of chapter 1', 8, 10),
(17, 1, 'this is 3rd 8 marks question of chapter 1', 8, 10),
(18, 2, 'this is 1st 4 marks question of chapter 2', 4, 10),
(19, 2, 'this is 2nd 4 marks question of chapter 2', 4, 10),
(20, 2, 'this is 3rd 4 marks question of chapter 2', 4, 10),
(21, 2, 'this is 4th 4 marks question of chapter 2', 4, 10),
(22, 2, 'this is 5th 4 marks question of chapter 2', 4, 10),
(23, 2, 'this is 6th 4 marks question of chapter 2', 4, 10),
(24, 2, 'this is 7th 4 marks question of chapter 2', 4, 10),
(25, 2, 'this is 8th 4 marks question of chapter 2', 4, 10),
(26, 2, 'this is 9th 4 marks question of chapter 2', 4, 10),
(27, 2, 'this is 10th 4 marks question of chapter 2', 4, 10),
(28, 2, 'this is 1st 6 marks question of chapter 2', 6, 10),
(29, 2, 'this is 2nd 6 marks question of chapter 2', 6, 10),
(30, 2, 'this is 3rd 6 marks question of chapter 2', 6, 10),
(31, 2, 'this is 4th 6 marks question of chapter 2', 6, 10),
(32, 2, 'this is 1st 8 marks question of chapter 2', 8, 10),
(33, 2, 'this is 2nd 8 marks question of chapter 2', 8, 10),
(34, 2, 'this is 3rd 8 marks question of chapter 2', 8, 10),
(35, 3, 'this is 1st 4 marks question of chapter 3', 4, 10),
(36, 3, 'this is 2nd 4 marks question of chapter 3', 4, 10),
(37, 3, 'this is 3rd 4 marks question of chapter 3', 4, 10),
(38, 3, 'this is 4th 4 marks question of chapter 3', 4, 10),
(39, 3, 'this is 5th 4 marks question of chapter 3', 4, 10),
(40, 3, 'this is 6th 4 marks question of chapter 3', 4, 10),
(41, 3, 'this is 7th 4 marks question of chapter 3', 4, 10),
(42, 3, 'this is 8th 4 marks question of chapter 3', 4, 10),
(43, 3, 'this is 9th 4 marks question of chapter 3', 4, 10),
(44, 3, 'this is 10th 4 marks question of chapter 3', 4, 10),
(45, 3, 'this is 1st 6 marks question of chapter 3', 6, 10),
(46, 3, 'this is 2nd 6 marks question of chapter 3', 6, 10),
(47, 3, 'this is 3rd 6 marks question of chapter 3', 6, 10),
(48, 3, 'this is 4th 6 marks question of chapter 3', 6, 10),
(49, 3, 'this is 1st 8 marks question of chapter 3', 8, 10),
(50, 3, 'this is 2nd 8 marks question of chapter 3', 8, 10),
(51, 3, 'this is 3rd 8 marks question of chapter 3', 8, 10),
(52, 4, 'this is 1st 4 marks question of chapter 4', 4, 10),
(53, 4, 'this is 2nd 4 marks question of chapter 4', 4, 10),
(54, 4, 'this is 3rd 4 marks question of chapter 4', 4, 10),
(55, 4, 'this is 4th 4 marks question of chapter 4', 4, 10),
(56, 4, 'this is 5th 4 marks question of chapter 4', 4, 10),
(57, 4, 'this is 6th 4 marks question of chapter 4', 4, 10),
(58, 4, 'this is 7th 4 marks question of chapter 4', 4, 10),
(59, 4, 'this is 8th 4 marks question of chapter 4', 4, 10),
(60, 4, 'this is 9th 4 marks question of chapter 4', 4, 10),
(61, 4, 'this is 10th 4 marks question of chapter 4', 4, 10),
(62, 4, 'this is 1st 6 marks question of chapter 4', 6, 10),
(63, 4, 'this is 2nd 6 marks question of chapter 4', 6, 10),
(64, 4, 'this is 3rd 6 marks question of chapter 4', 6, 10),
(65, 4, 'this is 4th 6 marks question of chapter 4', 6, 10),
(66, 4, 'this is 1st 8 marks question of chapter 4', 8, 10),
(67, 4, 'this is 2nd 8 marks question of chapter 4', 8, 10),
(68, 4, 'this is 3rd 8 marks question of chapter 4', 8, 10),
(69, 5, 'this is 1st 4 marks question of chapter 5', 4, 10),
(70, 5, 'this is 2nd 4 marks question of chapter 5', 4, 10),
(71, 5, 'this is 3rd 4 marks question of chapter 5', 4, 10),
(72, 5, 'this is 4th 4 marks question of chapter 5', 4, 10),
(73, 5, 'this is 5th 4 marks question of chapter 5', 4, 10),
(74, 5, 'this is 6th 4 marks question of chapter 5', 4, 10),
(75, 5, 'this is 7th 4 marks question of chapter 5', 4, 10),
(76, 5, 'this is 8th 4 marks question of chapter 5', 4, 10),
(77, 5, 'this is 9th 4 marks question of chapter 5', 4, 10),
(78, 5, 'this is 10th 4 marks question of chapter 5', 4, 10),
(79, 5, 'this is 1st 6 marks question of chapter 5', 6, 10),
(80, 5, 'this is 2nd 6 marks question of chapter 5', 6, 10),
(81, 5, 'this is 3rd 6 marks question of chapter 5', 6, 10),
(82, 5, 'this is 4th 6 marks question of chapter 5', 6, 10),
(83, 5, 'this is 1st 8 marks question of chapter 5', 8, 10),
(84, 5, 'this is 2nd 8 marks question of chapter 5', 8, 10),
(85, 5, 'this is 3rd 8 marks question of chapter 5', 8, 10),
(86, 6, 'this is 1st 4 marks question of chapter 6', 4, 10),
(87, 6, 'this is 2nd 4 marks question of chapter 6', 4, 10),
(88, 6, 'this is 3rd 4 marks question of chapter 6', 4, 10),
(89, 6, 'this is 4th 4 marks question of chapter 6', 4, 10),
(90, 6, 'this is 5th 4 marks question of chapter 6', 4, 10),
(91, 6, 'this is 6th 4 marks question of chapter 6', 4, 10),
(92, 6, 'this is 7th 4 marks question of chapter 6', 4, 10),
(93, 6, 'this is 8th 4 marks question of chapter 6', 4, 10),
(94, 6, 'this is 9th 4 marks question of chapter 6', 4, 10),
(95, 6, 'this is 10th 4 marks question of chapter 6', 4, 10),
(96, 6, 'this is 1st 6 marks question of chapter 6', 6, 10),
(97, 6, 'this is 2nd 6 marks question of chapter 6', 6, 10),
(98, 6, 'this is 3rd 6 marks question of chapter 6', 6, 10),
(99, 6, 'this is 4th 6 marks question of chapter 6', 6, 10),
(100, 6, 'this is 1st 8 marks question of chapter 6', 8, 10),
(101, 6, 'this is 2nd 8 marks question of chapter 6', 8, 10),
(102, 6, 'this is 3rd 8 marks question of chapter 6', 8, 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `javachapters`
--
ALTER TABLE `javachapters`
  ADD PRIMARY KEY (`chapterId`);

--
-- Indexes for table `javaquestions`
--
ALTER TABLE `javaquestions`
  ADD PRIMARY KEY (`qId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `javachapters`
--
ALTER TABLE `javachapters`
  MODIFY `chapterId` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `javaquestions`
--
ALTER TABLE `javaquestions`
  MODIFY `qId` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
