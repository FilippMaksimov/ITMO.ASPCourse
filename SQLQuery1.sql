CREATE TABLE Students
(
	ID int IDENTITY(1,1) NOT NULL,
	StudentName NVARCHAR(40) NOT NULL,
	GroupNo int NOT NULL,
	Email NVARCHAR(30) NOT NULL
	CONSTRAINT PK_T_ID PRIMARY KEY CLUSTERED (ID)
	);

CREATE TABLE Scores
(
	ScoreID int IDENTITY(1,1) NOT NULL,
	StudentID int NOT NULL,
	SubjectName NVARCHAR(20) NOT NULL,
	ScoreResult int,
	ScoreDate date
	CONSTRAINT FK_T_StudentID FOREIGN KEY(StudentID) REFERENCES Students(ID)
);

INSERT INTO Students VALUES ('Smith Michael', 101, 'smith@gmail.com')
INSERT INTO Students VALUES ('Smirnova Angelina', 101, 'smirnova98@mail.ru')
INSERT INTO Students VALUES ('Ivanova Alina', 101, 'ivanova1997@bk.ru')
INSERT INTO Students VALUES ('Petersons Janis', 101, 'petjan@gmail.com')
INSERT INTO Students VALUES ('Jankauskas Jevgenis', 102, 'janjev@gmail.com')
INSERT INTO Students VALUES ('Berzinia Linde', 102, 'berzlin1998@yoohoo.com')
INSERT INTO Students VALUES ('Vasilieva Marina', 102, 'vasmar@mail.com')
INSERT INTO Students VALUES ('Vasins Andrejs', 102, 'vasinsandr2000@gmail.com')
INSERT INTO Students VALUES ('Kazlauskase Inga', 102, 'kazlIng@gmail.com')

INSERT INTO Scores VALUES(1, 'Math',70, CAST('10.12.2022' As date ))
INSERT INTO Scores VALUES(1, 'Biology',75, CAST('11.12.2022' As date ))
INSERT INTO Scores VALUES(1, 'English',76, CAST('12.12.2022' As date ))
INSERT INTO Scores VALUES(1, 'Physics',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(1, 'Chemistry',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(1, 'Geography',60, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(1, 'History',55, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(1, 'Info Technologies',45, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(2, 'Math',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'Biology',60, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'English',100, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'Physics',85, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'Chemistry',55, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'Geography',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'History',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(2, 'Info Technologies',89, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(3, 'Math',67, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'Biology',88, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'English',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'Physics',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'Chemistry',67, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'Geography',98, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'History',40, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(3, 'Info Technologies',70, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(4, 'Math',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'Biology',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'English',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'Physics',95, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'Chemistry',98, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'Geography',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'History',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(4, 'Info Technologies',100, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(5, 'Math',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'Biology',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'English',70, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'Physics',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'Chemistry',77, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'Geography',76, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'History',75, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(5, 'Info Technologies',70, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(6, 'Math',75, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'Biology',40, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'English',76, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'Physics',72, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'Chemistry',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'Geography',75, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'History',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(6, 'Info Technologies',60, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(7, 'Math',60, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'Biology',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'English',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'Physics',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'Chemistry',67, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'Geography',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'History',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(7, 'Info Technologies',50, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(8, 'Math',78, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'Biology',70, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'English',70, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'Physics',50, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'Chemistry',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'Geography',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'History',60, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(8, 'Info Technologies',40, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(9, 'Math',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'Biology',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'English',60, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'Physics',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'Chemistry',78, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'Geography',77, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'History',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(9, 'Info Technologies',79, CAST('2022-12-12' As date ))

INSERT INTO Scores VALUES(10, 'Math',89, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'Biology',80, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'English',78, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'Physics',70, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'Chemistry',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'Geography',90, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'History',70, CAST('2022-12-12' As date ))
INSERT INTO Scores VALUES(10, 'Info Technologies',80, CAST('2022-12-12' As date ))

SELECT * FROM Students
SELECT * FROM Scores