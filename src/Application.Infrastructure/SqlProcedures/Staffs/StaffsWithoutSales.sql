raw sql

`
SELECT * 
FROM staffs s
WHERE NOT EXSISTS (
    SELECT 1 
    FROM orders o
    WHERE o.staff_id = s.staff_id 
)
`