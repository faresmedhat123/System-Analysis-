-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2026 at 04:45 PM
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
-- Database: `metro_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `messages`
--

CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `subject` varchar(150) DEFAULT NULL,
  `message` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `messages`
--

INSERT INTO `messages` (`id`, `name`, `email`, `subject`, `message`) VALUES
(2, '', '', '', ''),
(3, 'Anas', 'test@gmail.com', 'Hello', 'Testing'),
(4, 'Anas', 'killl@gmail.com', 'po', 'jih\r\n'),
(5, 'AAA', 'aaa@gmail.com', 'aaaaaaaaaaaaaaaaaaaaaaa', 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'),
(6, 'Anasuh', 'aaa@gmail.com', '97697iu', 'iuyuyutjgyuj'),
(7, 'jjhh', '3t5wqr3tr5@gmail.com', 'reggrrqwg', 'gwewwgg'),
(8, 'Anas', 'ali@gmail.com', 'iuo8h', 'khgykgigyi\r\n'),
(9, 'Anas', '', '', ''),
(10, 'kljkklp', 'ipuip@gmail.com', 'oihi', 'uiyhloi9giytgy'),
(11, 'kljkklp', 'ipuip@gmail.com', 'oihi', 'uiyhloi9giytgy'),
(12, 'Anas', 'killl@gmail.com', 'oihipk', 'uiyhloi9giytgy'),
(13, 'Anas', 'killl@gmail.com', 'oihipk', 'uiyhloi9giytgy'),
(14, 'Anas', 'killl@gmail.com', 'oihipk', 'uiyhloi9giytgy'),
(15, 'Anas', 'killl@gmail.com', 'oihipk', 'uiyhloi9giytgy'),
(16, 'AAA', 'killl@gmail.com', '666uu', 'yhtyty'),
(17, 'Anas', 'ali@gmail.com', 'rt', 'vfsfsv'),
(18, 'Anas', 'aaa@gmail.com', 'totalx', 'iuyuuouo');

-- --------------------------------------------------------

--
-- Table structure for table `newsletter`
--

CREATE TABLE `newsletter` (
  `id` int(11) NOT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `newsletter`
--

INSERT INTO `newsletter` (`id`, `email`) VALUES
(1, ''),
(2, 'killl@gmail.com'),
(3, 'killl@gmail.com'),
(4, 'killl@gmail.com'),
(5, 'killl@gmail.com'),
(6, 'killl@gmail.com'),
(7, 'ali@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`) VALUES
(1, 'Ali', 'killl@gmail.com', '$2y$10$Pgc8P6kGT6uXhICp5lXuHeb14vqaHJov.3T93vVS8KRddBULzNZwO'),
(2, 'Anas', 'ali@gmail.com', '$2y$10$Va22iVdZo.nRCyRh4BsZtuvOU9Wn6QaWYGuPs1Xqy6RZXIPyFbbl6'),
(3, 'Ali', 'ali@gmail.com', '$2y$10$TsUgVyYMN5fZKk0Je3.7w.TJJyYDP5bB.HedePc44VVThdvH/E4fG'),
(4, 'Ali', 'ali@gmail.com', '$2y$10$pEa9fuR.ssC9LiFzAvK1k.s7XT6mtln6Rm0vr7DzXpTBj8DbEOqE.'),
(5, 'Ali', 'ali@gmail.com', '$2y$10$Pd.ArW4Kb2G2c1n/geI70Ow/Az90MTM2dlDRp9zFyKE/.aKJCYQba'),
(6, 'Ali', 'ali@gmail.com', '$2y$10$t9dCb9mwq693x9tr1ZCDxefGkr4n2TnETdHCEWBkieyvE2x6Bin0W'),
(7, 'AAA', 'aaa@gmail.com', '$2y$10$5Uql7KbNSn.S23MutOHHBeOIx45rrt8cYB2XYMDjntBB0F79yggXq'),
(8, 'aaaa', 'aaaa@gmail.com', '$2y$10$oJyMhia60F16JnWnkrrY/OGMS8/aFXkdVrP6QVVu2suluUOLIvNeK'),
(9, 'AAA', 'aaa@gmail.com', '$2y$10$bEGorczzu3atZu8IZvv/TuGqxjsDhOusGAfVOC.qzbDab2uRi1.DG'),
(10, 'alo', 'alo@gmail.com', '$2y$10$7oGkZM4sxJ06oENCGToLIuEQqf1ZhGctGa1echh0Ucm84uboOugHC'),
(12, 'Anas', 'aaa@gmail.com', '$2y$10$6h9fY2YMzFjq4TiUEVKdqei3yg1BpZg8v.NzOfl6QQ13rHQ/LAGiu'),
(13, 'AAA', 'aaa@gmail.com', '$2y$10$BZH1dLVRXARMyC.gLWlKGuq06Eg4zNV94IiVmyDufOpQtMianqIFG');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `newsletter`
--
ALTER TABLE `newsletter`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `newsletter`
--
ALTER TABLE `newsletter`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
