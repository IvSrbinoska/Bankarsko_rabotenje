CREATE view dbo.PregledKarticki
as
SELECT ci.CardNumber, ci.print_name, ci.print_surname, ci.[status],ci.embg_user,name_series
FROM cards_issued ci
left join card_products cp
On ci.IDProduct = cp.IDProduct