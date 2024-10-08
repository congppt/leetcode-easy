with
    yesterdayTemp as (
        select
            id,
            DATE_ADD (recordDate, interval 1 day) as recordDate,
            temperature
        from
            Weather
    )
select
    d.id
from
    Weather as d
    join yesterdayTemp as y on d.recordDate = y.recordDate
    and d.temperature > y.temperature