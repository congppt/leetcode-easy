select distinct p1.email 'Email' 
from Person as p1 join Person as p2 on p1.email = p2.email and p1.id != p2.id;