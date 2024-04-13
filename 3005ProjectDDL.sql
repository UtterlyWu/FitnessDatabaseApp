INSERT INTO public.fitnessroutines (title,description,category)
VALUES 
	('Maratheon Training', 'You run a bunch and its super fun and cool.','Cardio'),
	('Powerlifter Training', 'Essentially you lift 100 pounds then you start lifing more weight.', 'Weight Training'),
	('Superman Routine', 'Lift a bunch, run a bunch, fly a bunch. Its basically what superman does.', 'Specialist'),
	('Light Weight Training', 'Training to lift up to 15 pounds, very light work, good for weaklings.', 'Weight Training');

INSERT INTO public.adminstaff(username,pword,first_name,last_name,position)
VALUES
	('admin1','password','George','Bush','General Manager'),
	('admin2','password','Dick','Cheney','Vice General Manager'),
	('admin3','password','Hillary','Clinton','Director of Operations');

INSERT INTO public.trainers(username,pword,first_name,last_name)
VALUES
	('trainer1','password','Al','Gore'),
	('trainer2','password','John','Kerry'),
	('trainer3','password','Barack','Obama');

INSERT INTO public.rooms(room_number, name)
VALUES
	(1,'Pain Room'),
	(2,'Gain Room'),
	(3,'Armory'),
	(4,'Maintence Shed'),
	(5,'Basketball Court');

INSERT INTO public.machines(name,status,room_number)
VALUES
	('Tricycle','Working',1),
	('The Abdominator','Working',2),
	('The MuscleGaininator','Needs Repairs',3);

INSERT INTO public.members(username,pword,first_name,last_name,current_weight,desired_weight,height,joined_date,sex,routine_id,desired_date)
VALUES
	('member1','password','Ari','Rubin',450,1,175,'2023-05-26','Male',1,'2024-05-26'),
	('member2','password','Patrick','Wu',253,350,167,'2023-09-03','Male',3,'2024-05-24'),
	('member3','password','Marco','Toito',154,155,179,'2023-02-16','Male',2,'2025-05-29'),
	('member4','password','Caitlin','Wunderlich',124,129,166,'2023-03-26','Female',1,'2024-05-21');

INSERT INTO public.Sessions (trainer_id, room_number, type, name, description, date, capacity)
VALUES
    (1, 1, 'Single', 'Morning Yoga', 'Relaxing yoga session to start your day', '2024-04-15', 20),
    (2, 2, 'Group', 'High-Intensity Interval Training', 'Intense cardio workout for fitness enthusiasts', '2024-04-16', 15),
    (3, 3, 'Group', 'Full Body Strength Workout', 'Strength training session focusing on all major muscle groups', '2024-04-17', 10);

INSERT INTO public.Registrations (session_id, member_id)
VALUES
    (1, 1),
	(1, 2);

INSERT INTO public.Availability (date,trainer_id)
VALUES
	('2024-04-15',1),
	('2024-04-16',2),
	('2024-04-17',3);