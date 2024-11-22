raw sql

`
SELECT * 
FROM customers c
WHERE NOT EXSISTS (
    SELECT 1 
    FROM orders o
    WHERE o.customer_id = c.customer_id    
)
`