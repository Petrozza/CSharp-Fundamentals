SELECT c.Name AS City, COUNT(h.Name) AS Hotels
FROM Cities c
JOIN Hotels h ON c.Id = h.CityId
GROUP BY c.Name
ORDER BY Hotels DESC, City
