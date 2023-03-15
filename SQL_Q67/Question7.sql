SELECT trans.ticket_no, trans.date_out,product.prod_name, trader.trader name, trans.net_wt
FROM trans, tarder, product where trans.prod_code = product.prod_name 
AND trans.trader_code = trader.trader_name;