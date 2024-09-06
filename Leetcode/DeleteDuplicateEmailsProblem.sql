With
    validId as (
        select
            min(id) as id
        from
            Person
        group by
            email
    )
delete from Person
where
    id not in (
        select
            id
        from
            validId
    )