raw sql

`
SELECT * 
FROM products p
WHERE NOT EXSISTS (
    SELECT 1 
    FROM stoks s
    WHERE s.product_id = c.product_id AND s.quantity > 0    
)
`