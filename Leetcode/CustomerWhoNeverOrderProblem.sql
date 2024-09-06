select c.name 'Customers'
from Customers as c left join Orders as o on c.id = o.customerId
where o.customerId is null