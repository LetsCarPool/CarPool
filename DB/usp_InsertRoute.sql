USE [CarPool]
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertRoute]    Script Date: 11/21/2013 14:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[usp_InsertRoute]
(@CarID NUMERIC,
@Startpoint VARCHAR(30), 
@Destination VARCHAR(30), 
@StartDate date,
@EndDate date, 
@RunningDays VARCHAR(15),
@Intermediatepoint1 VARCHAR(30)= NULL,
@Intermediatepoint2 VARCHAR(30)= NULL,
@Intermediatepoint3 VARCHAR(30)= NULL,
@Intermediatepoint4 VARCHAR(30)= NULL,
@Intermediatepoint5 VARCHAR(30)= NULL, 
@Intermediatepoint6 VARCHAR(30)= NULL,
@Intermediatepoint7 VARCHAR(30)= NULL,
@Intermediatepoint8 VARCHAR(30)= NULL,
@Intermediatepoint9 VARCHAR(30)= NULL,
@Intermediatepoint10 VARCHAR(30)= NULL)
AS
BEGIN

	BEGIN TRY
	DECLARE @SeatsAvailable int
	DECLARE @ROUTEID INT
	DECLARE @TEMP FLOAT
	DECLARE @NTEMP FLOAT
	
	SELECT @SeatsAvailable=CAPACITY FROM tbl_CarDetails WHERE CarId=@CarID		
	INSERT INTO tbl_RouteTable VALUES(@CarID,@Startpoint,@Destination,@StartDate,@EndDate,@RunningDays,@Intermediatepoint1,@Intermediatepoint2,@Intermediatepoint3,@Intermediatepoint4,@Intermediatepoint5,@Intermediatepoint6,@Intermediatepoint7,@Intermediatepoint8,@Intermediatepoint9,@Intermediatepoint10)
	
	SET @ROUTEID=@@IDENTITY
	WHILE(@StartDate<=@EndDate)
	BEGIN
				
		IF(UPPER(datename(dw,@StartDate))='SUNDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (10 AS FLOAT))
			--SET @NTEMP=ROUND(@TEMP,0)
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		IF(UPPER(datename(dw,@StartDate))='SATURDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (100 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		IF(UPPER(datename(dw,@StartDate))='FRIDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (1000 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		IF(UPPER(datename(dw,@StartDate))='THURSDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (10000 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		IF(UPPER(datename(dw,@StartDate))='WEDNESDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (100000 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END

		IF (UPPER(datename(dw,@StartDate))='TUESDAY')
		BEGIN
			SET @TEMP= (@RunningDays/CAST (1000000 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		IF(UPPER(datename(dw,@StartDate))='MONDAY' )
		BEGIN
			SET @TEMP= (@RunningDays/CAST (10000000 AS FLOAT))
			SET @TEMP=@TEMP- ROUND(@TEMP,0)
			SET @TEMP=(@TEMP*10)
			SET @TEMP=ROUND(@TEMP,0)
			SELECT @TEMP
			IF (@TEMP=1 )
			BEGIN
				INSERT INTO tbl_Trip(CarId,RouteId,Date,SeatsAvailable)	
				VALUES(@CarID,@ROUTEID,@StartDate,@SeatsAvailable)
			END
		END
		SET @StartDate =DATEADD(day,1,@StartDate) 
	END	
	END TRY
	BEGIN CATCH		
		SELECT ERROR_NUMBER()
		SELECT ERROR_MESSAGE()
		SELECT ERROR_SEVERITY()
		RETURN -3
	END CATCH
END
