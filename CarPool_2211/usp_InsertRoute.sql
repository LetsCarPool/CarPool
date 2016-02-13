USE [CarPoolDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_InsertRoute]    Script Date: 11/15/2013 15:25:56 ******/
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
	
				
	INSERT INTO tbl_RouteTable VALUES(@CarID,@Startpoint,@Destination,@StartDate,@EndDate,@RunningDays,@Intermediatepoint1,@Intermediatepoint2,@Intermediatepoint3,@Intermediatepoint4,@Intermediatepoint5,@Intermediatepoint6,@Intermediatepoint7,@Intermediatepoint8,@Intermediatepoint9,@Intermediatepoint10)
	
	END TRY
	BEGIN CATCH
		
		SELECT ERROR_NUMBER()
		SELECT ERROR_MESSAGE()
		SELECT ERROR_SEVERITY()
		RETURN -3
	END CATCH
END

GO

