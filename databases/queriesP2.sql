--Here are some of the things Sarah needs your help with:

--1. Find out which countries the directors in her collection are from (and make sure your result set only lists each country only once).
SELECT DISTINCT country FROM directors GROUP BY country;

--2. Who are the French directors in her database?
SELECT first, last FROM directors WHERE country='France';

--3. What is the date of the first time someone viewed one of Sarah's movies?
SELECT date_viewed FROM `viewings` GROUP BY date_viewed ASC LIMIT 1;
-- or
SELECT MIN(date_viewed) FROM viewings;

--4. How many movies in her collection were directed by people born in the USA?
SELECT COUNT(movies.movie_id) FROM movies
JOIN directors ON movies.director_id = directors.director_id
WHERE directors.country = 'USA';

--5. What are the titles of the movies in her collection that were directed by Akira Kurosawa?
SELECT movies.title FROM movies
JOIN directors ON movies.director_id = directors.director_id
WHERE directors.first = 'Akira' AND directors.last = 'Kurosawa';

--6. How many times has the movie "Talk to Me" been viewed?
SELECT count(viewings.movie_id) FROM viewings
JOIN movies ON movies.movie_id = viewings.movie_id
WHERE movies.title = 'Talk to Me';

--7. When was the last time someone viewed one of her movies?
SELECT date_viewed FROM `viewings` GROUP BY date_viewed DESC LIMIT 1;
-- or
SELECT MAX(date_viewed) FROM viewings;

--8. What is the id of the last-viewed movie?
SELECT movie_id FROM viewings WHERE date_viewed = (SELECT date_viewed FROM `viewings` GROUP BY date_viewed DESC LIMIT 1);

--9. What is the title of the first movie she loaned to a friend for viewing?
SELECT title FROM movies WHERE movie_id = (SELECT movie_id FROM viewings WHERE date_viewed = (SELECT MIN(date_viewed) FROM viewings));
--or
SELECT title FROM movies WHERE movie_id = (SELECT movie_id FROM viewings WHERE viewing_id = (SELECT MIN(viewing_id) FROM viewings));
--or
SELECT movies.title FROM movies JOIN viewings ON viewings.movie_id = movies.movie_id WHERE viewings.viewing_id = 1;

--10. What is the first and last name of the person who viewed the last-viewed movie?
SELECT first, last FROM viewers JOIN viewings 
ON viewers.viewer_id = viewings.viewer_id WHERE date_viewed = (SELECT date_viewed FROM `viewings` GROUP BY date_viewed DESC LIMIT 1); 
--or
SELECT first, last FROM viewers JOIN viewings 
ON viewers.viewer_id = viewings.viewer_id WHERE movie_id = (SELECT movie_id FROM viewings WHERE date_viewed = (SELECT date_viewed FROM `viewings` GROUP BY date_viewed DESC LIMIT 1)); 


--BONUS MISSIONS
--11. Write the SQL query to display the DVDs that others have watched in order of most viewed to least viewed. What's the title of the most-viewed movie(s) in Sarah's collection?
SELECT title, COUNT(viewings.movie_id) FROM viewings JOIN movies ON movies.movie_id = viewings.movie_id GROUP BY viewings.movie_id ORDER BY COUNT(viewings.movie_id) DESC;

--12. Find the email of everyone who has watched "The Tango Lesson", so Sarah can email them and ask what they thought of it.
SELECT email FROM viewers JOIN viewings 
ON viewers.viewer_id = viewings.viewer_id WHERE movie_id = (SELECT movie_id FROM movies WHERE title = 'The Tango Lesson'); 

--13. Sarah is hosting a Kurosawa film festival soon and needs an email list to send out invites. What are the full names and emails of all her friends who have watched any movie by Akira Kurosawa?
SELECT DISTINCT CONCAT(first, " ", last)AS Fullname, email FROM viewers JOIN viewings ON viewers.viewer_id = viewings.viewer_id WHERE movie_id = ANY(SELECT movie_id FROM movies JOIN directors ON movies.director_id = directors.director_id WHERE directors.first = 'Akira' AND directors.last = 'Kurosawa'); 