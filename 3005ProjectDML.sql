DROP TABLE IF EXISTS public.FitnessRoutines CASCADE;
DROP TABLE IF EXISTS public.Accounts CASCADE;
DROP TABLE IF EXISTS public.Members CASCADE;
DROP TABLE IF EXISTS public.Trainers CASCADE;
DROP TABLE IF EXISTS public.AdminStaff CASCADE;
DROP TABLE IF EXISTS public.Rooms CASCADE;
DROP TABLE IF EXISTS public.Sessions CASCADE;
DROP TABLE IF EXISTS public.Billings CASCADE;
DROP TABLE IF EXISTS public.Machines CASCADE;
DROP TABLE IF EXISTS public.Availability CASCADE;
DROP TABLE IF EXISTS public.Registrations CASCADE;

CREATE TABLE public.FitnessRoutines(
	routine_id	SERIAL,
	title		VARCHAR(255),
	description	TEXT,
	category	VARCHAR(30),
	
	PRIMARY KEY(routine_id)
);

CREATE TABLE public.Accounts(
	username	VARCHAR(80)	NOT NULL,
	pword		VARCHAR(80)	NOT NULL,
	first_name	VARCHAR(80)	NOT NULL,
	last_name	VARCHAR(80)	NOT NULL,
	account_type	VARCHAR(10)	DEFAULT 'NONE',

	PRIMARY KEY(username, pword, first_name, last_name)
);

CREATE TABLE public.Members(
	member_id	SERIAL,
	username	VARCHAR(80)	NOT NULL,
	pword		VARCHAR(80)	NOT NULL,
	first_name	VARCHAR(80)	NOT NULL,
	last_name	VARCHAR(80)	NOT NULL,
	
	current_weight	float(2),
	desired_weight	float(2),
	height			INT,
	joined_date		DATE	NOT NULL,
	sex				VARCHAR(15),
	routine_id		INT,
	desired_date	DATE,
	
	PRIMARY KEY(member_id),
	FOREIGN KEY(routine_id) REFERENCES FitnessRoutines(routine_id),
	FOREIGN KEY(username, pword, first_name, last_name) REFERENCES Accounts(username, pword, first_name, last_name)
);

CREATE TABLE public.Trainers(
	trainer_id	SERIAL,
	username	VARCHAR(80)	NOT NULL,
	pword		VARCHAR(80)	NOT NULL,
	first_name	VARCHAR(80)	NOT NULL,
	last_name	VARCHAR(80)	NOT NULL,

	PRIMARY KEY(trainer_id),
	FOREIGN KEY(username, pword, first_name, last_name) REFERENCES Accounts(username, pword, first_name, last_name)
);

CREATE TABLE public.AdminStaff(
	admin_id	SERIAL,
	username	VARCHAR(80)	NOT NULL,
	pword		VARCHAR(80)	NOT NULL,
	first_name	VARCHAR(80)	NOT NULL,
	last_name	VARCHAR(80)	NOT NULL,
	position	VARCHAR(80) NOT NULL,

	PRIMARY KEY(admin_id),
	FOREIGN KEY(username, pword, first_name, last_name) REFERENCES Accounts(username, pword, first_name, last_name)
);

CREATE TABLE public.Rooms(
	room_number		INT NOT NULL,
	name		VARCHAR(80)	NOT NULL,

	PRIMARY KEY(room_number)
);

CREATE TABLE public.Sessions(
	session_id	SERIAL,
	trainer_id INT,
	room_number INT,
	type		VARCHAR(255)	NOT NULL,
	name		VARCHAR(255)	NOT NULL,
	date		DATE			NOT NULL,
	
	PRIMARY KEY(session_id),
	FOREIGN KEY(trainer_id) REFERENCES Trainers(trainer_id),
	FOREIGN KEY(room_number) REFERENCES Rooms(room_number)
);

CREATE TABLE public.Billings(
	bill_id		SERIAL,
	amount		float(2),
	member_id	INT,
	card_number	INT,
	
	PRIMARY KEY(bill_id),
	FOREIGN KEY(member_id) REFERENCES Members(member_id)
);

CREATE TABLE public.Registrations(
	session_id INT,
	member_id INT,

	FOREIGN KEY(session_id) REFERENCES Sessions(session_id),
	FOREIGN KEY(member_id) REFERENCES Members(member_id)
);

CREATE TABLE public.Machines(
	machine_id	SERIAL,
	name		VARCHAR(80),
	status		VARCHAR(255),
	room_number	INT,
	
	FOREIGN KEY(room_number) REFERENCES Rooms(room_number)
);

CREATE TABLE public.Availability(
	date		DATE,
	trainer_id	INT,
	
	PRIMARY KEY(date, trainer_id),
	FOREIGN KEY(trainer_id) REFERENCES Trainers(trainer_id)
);

CREATE OR REPLACE FUNCTION insert_into_accounts()
RETURNS TRIGGER AS 
$$
BEGIN
	IF (TG_TABLE_NAME = 'members' OR TG_TABLE_NAME = 'trainers' OR TG_TABLE_NAME = 'adminstaff') THEN
		-- RAISE NOTICE '%', TG_TABLE_NAME;
		INSERT INTO Accounts(username, pword, first_name, last_name, account_type)
		VALUES (NEW.username, NEW.pword, NEW.first_name, NEW.last_name, TG_TABLE_NAME);
    END IF;
	RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_insert_from_members
BEFORE INSERT ON Members
	FOR EACH ROW EXECUTE FUNCTION insert_into_accounts();

CREATE TRIGGER trigger_insert_from_trainers
BEFORE INSERT ON Trainers
	FOR EACH ROW EXECUTE FUNCTION insert_into_accounts();

CREATE TRIGGER trigger_insert_from_admin
BEFORE INSERT ON AdminStaff
	FOR EACH ROW EXECUTE FUNCTION insert_into_accounts();