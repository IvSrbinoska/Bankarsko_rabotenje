--CREATE PROCEDURE dbo.sp_Obrabotka
--    @datum DATETIME
--AS
--SELECT * 
--FROM Person.Address
--WHERE City = @City
--GO

-- tip na transakcija=-1 e provizija!?
DECLARE @datum DATE
SET @datum='2018-04-23'

SELECT MONTH(@datum)

SELECT a.*,b.*
FROM dbo.card_products a INNER JOIN dbo.cards_issued b ON a.IDProduct=b.IDProduct
INNER JOIN dbo.card_transactions c ON b.CardNumber=c.CardNumber AND c.tip_transakcija=-1
WHERE a.debit_credit=1 AND b.[status]=1 AND MONTH(c.date_processing)=MONTH(@datum)




/*
SELECT * FROM dbo.card_transactions
WHERE tip_transakcija=-1

SELECT * FROM dbo.VRABOTEN1
SELECT * FROM dbo.ADRESAR
SELECT * FROM dbo.cards_issued
SELECT * FROM dbo.card_products
*/
