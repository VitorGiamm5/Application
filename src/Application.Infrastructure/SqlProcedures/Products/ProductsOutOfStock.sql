raw sql

`
SELECT * 
FROM products p
WHERE NOT EXSISTS (
    SELECT 1 
    FROM order_item oi
    WHERE oi.poduct_id = p.poduct_id    
)
`