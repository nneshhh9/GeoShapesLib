## SQL Query

SQL запрос для выбора всех пар «Имя продукта – Имя категории»:

```sql
SELECT 
    P.ProductName AS ProductName,
    C.CategoryName AS CategoryName
FROM 
    Products AS P
LEFT JOIN 
    ProductCategories AS PC ON P.ProductID = PC.ProductID
LEFT JOIN 
    Categories AS C ON PC.CategoryID = C.CategoryID
ORDER BY 
    P.ProductName, C.CategoryName;
