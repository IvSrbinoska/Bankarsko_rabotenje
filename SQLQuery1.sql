--CREATE PROCEDURE dbo.sp_Obrabotka
--    @datum DATETIME
--AS
-- t-sql code
--GO

-- tip na transakcija=-1 e provizija!?
DECLARE @datum DATE
DECLARE @month INT

SET @datum='2018-05-23'
SET @month = MONTH(DATEADD(month, -1, @datum))
SELECT @month

INSERT INTO dbo.card_transactions
(
    CardNumber,
    amount,
    [description],
    date_processing,
    date_system_insert,
    tip_transakcija
)
SELECT b.CardNumber,a.fees,CONCAT('provizija za mesec ',@month), GETDATE(), GETDATE(), -1/*tip_Transakcija*/
--a.*,b.*
FROM dbo.card_products a INNER JOIN dbo.cards_issued b ON a.IDProduct=b.IDProduct
INNER JOIN dbo.card_transactions c ON b.CardNumber=c.CardNumber AND c.tip_transakcija=-1
WHERE a.debit_credit=1 AND b.[status]=1 AND MONTH(c.date_processing)=@month

/*
SELECT * FROM dbo.card_transactions
WHERE tip_transakcija=-1

SELECT * FROM dbo.VRABOTEN1
SELECT * FROM dbo.ADRESAR
SELECT * FROM dbo.cards_issued
SELECT * FROM dbo.card_products
*/
