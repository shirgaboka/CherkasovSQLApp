-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 16, 2023 at 05:58 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cherkasovdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance_journal`
--

CREATE TABLE `attendance_journal` (
  `attendance_id` int(11) NOT NULL,
  `attendance_date` date DEFAULT NULL,
  `circle_id` int(11) DEFAULT NULL,
  `student_id` int(11) DEFAULT NULL,
  `teacher_id` int(11) DEFAULT NULL,
  `student_grade` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `attendance_journal`
--

INSERT INTO `attendance_journal` (`attendance_id`, `attendance_date`, `circle_id`, `student_id`, `teacher_id`, `student_grade`) VALUES
(1, '2021-09-01', 1, 1, 1, 5),
(2, '2021-09-01', 1, 2, 1, 4),
(3, '2021-09-01', 1, 3, 1, 5),
(4, '2021-09-01', 1, 4, 1, 5),
(5, '2021-09-01', 2, 5, 2, 4),
(6, '2021-09-01', 2, 6, 2, 5),
(7, '2021-09-01', 2, 7, 2, 4),
(8, '2021-09-01', 2, 8, 2, 5),
(9, '2022-05-12', 3, 7, 3, 5),
(10, '2022-03-11', 3, 8, 3, 4),
(11, '2022-09-30', 3, 9, 3, 5),
(12, '2022-03-01', 3, 10, 3, 5),
(13, '2022-06-09', 4, 11, 4, 5),
(14, '2022-07-07', 4, 12, 4, 5),
(15, '2023-04-12', 4, 13, 4, 5),
(16, '2023-07-11', 4, 14, 4, 4),
(17, '2023-04-21', 5, 15, 5, 5),
(19, '2023-02-11', 6, 16, 6, 5),
(20, '2023-05-11', 7, 17, 7, 4),
(21, '2023-06-12', 8, 17, 8, 5),
(22, '2023-08-13', 9, 17, 9, 4),
(23, '2023-01-14', 10, 17, 10, 5),
(24, '2023-02-16', 11, 17, 11, 5),
(25, '2023-04-15', 12, 19, 12, 4),
(26, '2023-05-21', 13, 20, 13, 5);

-- --------------------------------------------------------

--
-- Table structure for table `circles`
--

CREATE TABLE `circles` (
  `circle_id` int(11) NOT NULL,
  `circle_name` varchar(255) DEFAULT NULL,
  `circle_description` varchar(255) DEFAULT NULL,
  `circle_date_created` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `circles`
--

INSERT INTO `circles` (`circle_id`, `circle_name`, `circle_description`, `circle_date_created`) VALUES
(1, 'Шахматный кружок', 'Занятия по игре в шахматы', '2023-04-15'),
(2, 'Кружок художников', 'Занятия по рисованию и живописи', '2023-04-15'),
(3, 'Интересные эксперименты', 'Занятия по опытам и экспериментам', '2023-04-15'),
(4, 'Кружок по изучению иностранных языков', 'Занятия по изучению английского, немецкого и французского языков', '2023-04-15'),
(5, 'Кружок по программированию', 'Занятия по основам программирования на языках Python и JavaScript', '2023-04-15'),
(6, 'Математический кружок', 'Занятия по математике и геометрии', '2023-04-15'),
(7, 'Кружок по физике', 'Занятия по физике, механике и оптике', '2023-04-15'),
(8, 'Кружок по биологии', 'Занятия по биологии, экологии и здоровому образу жизни', '2023-04-15'),
(9, 'Кружок по истории', 'Занятия по истории, культуре и традициям нашего народа', '2023-04-15'),
(10, 'Музыкальный кружок', 'Занятия по игре на музыкальных инструментах и вокалу', '2023-04-15'),
(11, 'Кружок по краеведению', 'Занятия по изучению достопримечательностей и истории нашего края', '2023-04-15'),
(12, 'Физкультурно-спортивный кружок', 'Занятия по спортивной гимнастике и фитнесу', '2023-04-15'),
(13, 'Кулинарный кружок', 'Занятия по кулинарии и приготовлению домашних блюд', '2023-04-15'),
(14, 'Театральный кружок', 'Занятия по актерскому мастерству и театральной режиссуре', '2023-04-15'),
(15, 'Кружок по робототехнике', 'Занятия по созданию роботов и программированию микроконтроллеров', '2023-04-15'),
(16, 'Кружок по журналистике', 'Занятия по созданию и изданию собственной газеты и сайта', '2023-04-15'),
(17, 'Декоративно-прикладное искусство', 'Занятия по созданию украшений, игрушек и предметов интерьера', '2023-04-15'),
(18, 'Кружок по туризму и путешествиям', 'Занятия по подготовке и проведению самостоятельных и групповых путешествий', '2023-04-15'),
(19, 'Кружок по науке и технике', 'Занятия по изучению технических новинок и принципов науки', '2023-04-15'),
(20, 'Кружок по кино и видео', 'Занятия по съемке, монтажу и созданию собственных фильмов и роликов', '2023-04-15');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `student_name` varchar(255) DEFAULT NULL,
  `student_date_of_birth` date DEFAULT NULL,
  `student_address` varchar(255) DEFAULT NULL,
  `student_phone` varchar(20) DEFAULT NULL,
  `student_email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `student_name`, `student_date_of_birth`, `student_address`, `student_phone`, `student_email`) VALUES
(1, 'Иванов Петр Сергеевич', '2007-05-10', 'г. Москва, ул. Тверская, д. 15', '+7 (916) 111-11-11', 'ivanov.ps@mail.ru'),
(2, 'Петрова Мария Владимировна', '2009-09-08', 'г. Санкт-Петербург, ул. Большая Морская, д. 5', '+7 (921) 222-22-22', 'petrova.mv@mail.ru'),
(3, 'Сидоров Иван Петрович', '2008-02-15', 'г. Екатеринбург, ул. Ленина, д. 20', '+7 (922) 333-33-33', 'sidorov.ip@mail.ru'),
(4, 'Михайлов Александр Иванович', '2010-06-20', 'г. Владивосток, ул. Адмирала Фокина, д. 10', '+7 (914) 444-44-44', 'mikhaylov.ai@mail.ru'),
(5, 'Козлова Елена Николаевна', '2007-01-01', 'г. Казань, пр. Победы, д. 25', '+7 (987) 555-55-55', 'kozlova.en@mail.ru'),
(6, 'Федорова Анастасия Семеновна', '2008-03-28', 'г. Нижний Новгород, ул. Гороховка, д. 5', '+7 (910) 666-66-66', 'fedorova.as@mail.ru'),
(7, 'Смирнов Дмитрий Олегович', '2009-11-13', 'г. Красноярск, ул. Пушкина, д. 15', '+7 (903) 777-77-77', 'smirnov.do@mail.ru'),
(8, 'Тихомирова Анна Александровна', '2010-04-02', 'г. Иркутск, ул. Карла Маркса, д. 18', '+7 (967) 888-88-88', 'tikhomirova.aa@mail.ru'),
(9, 'Андреев Сергей Владимирович', '2008-09-25', 'г. Ростов-на-Дону, ул. Ленина, д. 5', '+7 (951) 999-99-99', 'andreev.sv@mail.ru'),
(10, 'Горбачев Михаил Андреевич', '2009-07-30', 'г. Волгоград, пр. Ленина, д. 50', '+7 (977) 101-01-01', 'gorbachov.ma@mail.ru'),
(11, 'Фомина Елена Игоревна', '2007-12-05', 'г. Ярославль, ул. Пушкина, д. 10', '+7 (999) 121-21-21', 'fomina.ei@mail.ru'),
(12, 'Исаев Дмитрий Александрович', '2010-10-09', 'г. Уфа, ул. Кирова, д. 5', '+7 (987) 131-31-31', 'isaev.da@mail.ru'),
(13, 'Чернов Даниил Викторович', '2008-06-08', 'г. Самара, ул. Ленина, д. 7', '+7 (999) 141-41-41', 'chernov.dv@mail.ru'),
(14, 'Данилов Алексей Ильич', '2010-07-07', 'г. Томск, ул. Измайлова, д. 10', '+7 (922) 151-51-51', 'danilov.ai@mail.ru'),
(15, 'Макаров Антон Алексеевич', '2007-02-25', 'г. Ульяновск, ул. Ленина, д. 15', '+7 (977) 161-61-61', 'makarov.aa@mail.ru'),
(16, 'Лебедева Ксения Олеговна', '2008-09-30', 'г. Калининград, ул. Генерала Леонова, д. 45', '+7 (903) 171-71-71', 'lebedeva.ko@mail.ru'),
(17, 'Каменева Анастасия Сергеевна', '2009-05-17', 'г. Рязань, ул. Ленина, д. 30', '+7 (906) 181-81-81', 'kameneva.as@mail.ru'),
(18, 'Денисов Алексей Андреевич', '2007-10-20', 'г. Воронеж, ул. Кирова, д. 15', '+7 (922) 191-91-91', 'denisov.aa@mail.ru'),
(19, 'Максимов Игорь Олегович', '2010-04-23', 'г. Саратов, ул. Первомайская, д. 10', '+7 (977) 202-02-02', 'maximov.io@mail.ru'),
(20, 'Белова Анна Петровна', '2008-01-19', 'г. Курган, ул. Пушкина, д. 5', '+7 (922) 212-12-12', 'belova.ap@mail.ru');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `teacher_id` int(11) NOT NULL,
  `teacher_name` varchar(255) DEFAULT NULL,
  `teacher_address` varchar(255) DEFAULT NULL,
  `teacher_phone` varchar(20) DEFAULT NULL,
  `teacher_email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`teacher_id`, `teacher_name`, `teacher_address`, `teacher_phone`, `teacher_email`) VALUES
(1, 'Иванова Анна Владимировна', 'г. Москва, ул. Никольская, д. 10', '+7 (495) 111-11-11', 'ivanova.av@gmail.com'),
(2, 'Петрова Екатерина Сергеевна', 'г. Санкт-Петербург, пр. Невский, д. 33', '+7 (812) 222-22-22', 'petrova.es@gmail.com'),
(3, 'Сидоров Петр Андреевич', 'г. Екатеринбург, ул. Ленина, д. 10', '+7 (343) 333-33-33', 'sidorov.pa@gmail.com'),
(4, 'Михайлова Юлия Олеговна', 'г. Владивосток, ул. Светланская, д. 5', '+7 (423) 444-44-44', 'mikhaylova.yo@gmail.com'),
(5, 'Козлов Николай Иванович', 'г. Казань, ул. Баумана, д. 15', '+7 (843) 555-55-55', 'kozlov.ni@gmail.com'),
(6, 'Федоров Илья Викторович', 'г. Нижний Новгород, ул. Минина, д. 10', '+7 (831) 666-66-66', 'fedorov.iv@gmail.com'),
(7, 'Смирнова Ольга Петровна', 'г. Красноярск, ул. Мира, д. 20', '+7 (391) 777-77-77', 'smirnova.op@gmail.com'),
(8, 'Тихомиров Андрей Александрович', 'г. Иркутск, ул. Кирова, д. 15', '+7 (395) 888-88-88', 'tikhomirov.aa@gmail.com'),
(9, 'Андреев Никита Николаевич', 'г. Ростов-на-Дону, ул. Пушкинская, д. 7', '+7 (863) 999-99-99', 'andreev.nn@gmail.com'),
(10, 'Горбачева Марина Анатольевна', 'г. Волгоград, пр. Ленина, д. 25', '+7 (844) 101-01-01', 'gorbachova.ma@gmail.com'),
(11, 'Фомин Евгений Игоревич', 'г. Ярославль, ул. Советская, д. 10', '+7 (485) 121-21-21', 'fomin.ei@gmail.com'),
(12, 'Исаева Анастасия Сергеевна', 'г. Уфа, пр. Октября, д. 5', '+7 (347) 131-31-31', 'isaeva.as@gmail.com'),
(13, 'Чернов Владислав Николаевич', 'г. Самара, ул. Мичурина, д. 8', '+7 (846) 141-41-41', 'chernov.vn@gmail.com'),
(14, 'Данилова Елена Павловна', 'г. Томск, ул. Ленина, д. 20', '+7 (382) 151-51-51', 'danilova.ep@gmail.com'),
(15, 'Макарова Оксана Дмитриевна', 'г. Ульяновск, ул. Ленина, д. 12', '+7 (842) 161-61-61', 'makarova.od@gmail.com'),
(16, 'Лебедев Артем Олегович', 'г. Калининград, ул. Пушкинская, д. 15', '+7 (401) 171-71-71', 'lebedev.ao@gmail.com'),
(17, 'Каменева Екатерина Викторовна', 'г. Рязань, ул. Маяковского, д. 30', '+7 (491) 181-81-81', 'kameneva.ev@gmail.com'),
(18, 'Денисов Александр Валерьевич', 'г. Воронеж, ул. Пушкина, д. 10', '+7 (473) 191-91-91', 'denisov.av@gmail.com'),
(19, 'Максимова Елена Игоревна', 'г. Саратов, ул. Ленина, д. 10', '+7 (845) 202-02-02', 'maximova.ei@gmail.com'),
(20, 'Белов Максим Сергеевич', 'г. Курган, ул. Карла Маркса, д. 5', '+7 (352) 212-12-12', 'belov.ms@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(100) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(32) NOT NULL,
  `name` varchar(50) NOT NULL,
  `mail` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `name`, `mail`) VALUES
(12, 'shirgaboka', '12345', 'Dmitriy', 'sh0rgeq@gmail.com'),
(13, 'Admin', '1234', 'Anton', 'adminkaea@mail.ru'),
(14, '1', '1', '1', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance_journal`
--
ALTER TABLE `attendance_journal`
  ADD PRIMARY KEY (`attendance_id`),
  ADD KEY `circle_id` (`circle_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `teacher_id` (`teacher_id`);

--
-- Indexes for table `circles`
--
ALTER TABLE `circles`
  ADD PRIMARY KEY (`circle_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`teacher_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(100) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance_journal`
--
ALTER TABLE `attendance_journal`
  ADD CONSTRAINT `attendance_journal_ibfk_1` FOREIGN KEY (`circle_id`) REFERENCES `circles` (`circle_id`),
  ADD CONSTRAINT `attendance_journal_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `attendance_journal_ibfk_3` FOREIGN KEY (`teacher_id`) REFERENCES `teachers` (`teacher_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
