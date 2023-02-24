SELECT trans.date_out, trans.trader_code, trader.trader_name, product.prod_code,
SUM(trans.net_wt) AS total_wt
FROM trans, trader, product where trans.trader_code = trader.trader_code
AND trans.prod_code = product.prod_code
GROUP BY trans.date_out
GROUP By trader.trader_code;