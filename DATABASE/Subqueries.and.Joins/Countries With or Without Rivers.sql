SELECT TOP(5) c.CountryName, r.RiverName
FROM Countries c
LEFT JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers r ON cr.RiverId = r.Id
JOIN Continents con ON c.ContinentCode = con.ContinentCode
WHERE con.ContinentName = 'Africa'
ORDER BY c.CountryName

