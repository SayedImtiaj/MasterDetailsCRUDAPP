                                                  
CREATE TABLE Trainee (
    TraineeID      INT           IDENTITY (1, 1) NOT NULL,
    TraineeName    VARCHAR (100) NULL,
    CourseID INT           NULL,
    DOB        DATE          NULL,
    Gender     VARCHAR (20)  NULL, 
    ImagePath  VARCHAR (250) NULL,
    CONSTRAINT [PK_Trainee] PRIMARY KEY CLUSTERED (TraineeID ASC)
);
go


CREATE TABLE EnrollCourse (
    EnrollCourseID    INT           IDENTITY (1, 1) NOT NULL,
    TraineeID       INT           NULL,
    CourseID  INT           NULL,
	EnrollDate Date NULL,
    EnrollFee     INT           NULL
);
go

CREATE TABLE Course (
    CourseID INT  Identity         NOT NULL,
    Course   NVARCHAR (50) NULL,
	CourseFee int NOT NULL,
    PRIMARY KEY CLUSTERED (CourseID ASC)
);
go

--Store Prcedure

CREATE PROC TraineeEnrollAddOrEdit
@EnrollCourseID int,
@TraineeID int,
@CourseID int,
@EnrollDate date,
@EnrollFee int
AS
	--Insert
	IF @EnrollCourseID = 0
		INSERT INTO EnrollCourse(TraineeID,CourseID,EnrollDate,EnrollFee)
		VALUES (@TraineeID,@CourseID,@EnrollDate,@EnrollFee)
	--Update
	ELSE
		UPDATE EnrollCourse
		SET
			TraineeID=@TraineeID,
			CourseID=@CourseID,
			EnrollDate=@EnrollDate,
			EnrollFee=@EnrollFee
		WHERE EnrollCourseID = @EnrollCourseID
go

CREATE PROC EnrollCourseDelete
@EnrollCourseID int
AS
	DELETE FROM EnrollCourse
	WHERE EnrollCourseID = @EnrollCourseID
go

CREATE PROC TraineeAddOrEdit
@TraineeID int,
@TraineeName varchar(100),
@CourseID int,
@DOB date,
@Gender varchar(20),
@ImagePath varchar(250)
AS

	--Insert
	IF @TraineeID = 0 BEGIN
		INSERT INTO Trainee(TraineeName,CourseID,DOB,Gender,ImagePath)
		VALUES (@TraineeName,@CourseID,@DOB,@Gender,@ImagePath)

		SELECT SCOPE_IDENTITY();

		END
	--Update
	ELSE BEGIN
		UPDATE Trainee
		SET
			
			TraineeName=@TraineeName,
			CourseID=@CourseID,
			DOB=@DOB,
			Gender=@Gender,
			
			ImagePath=@ImagePath
		WHERE TraineeID=@TraineeID

		SELECT @TraineeID;

		END
		go

CREATE PROC TraineeDelete
@TraineeID int
AS
	--Master
	DELETE FROM Trainee
	WHERE TraineeID = @TraineeID
	--Details
	DELETE FROM EnrollCourse
	WHERE TraineeID = @TraineeID
go

CREATE PROC TraineeViewAll
AS
SELECT T.TraineeID,T.TraineeName,T.Gender,T.DOB,T.ImagePath
FROM Trainee T 
go

CREATE PROC TraineeViewByID
@TraineeID int
AS
	--Master
	SELECT *
	FROM Trainee
	WHERE TraineeID = @TraineeID
	--Details
	SELECT *
	FROM EnrollCourse
	WHERE TraineeID = @TraineeID
	go

