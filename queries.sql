/* Part1*/
SHOW COLUMNS FROM jobs;

/* Part2 */
SELECT name from employers
WHERE location = "Saint Louis";


select * from skills;

delete from skills where id = 4;

commit;

/*part3*/
select s.name, s.description, count(js.jobid)
from skills s
inner join jobskills js
on s.id = js.skillid
group by s.name, s.description
order by s.name;


select * from techjobs.employers;

