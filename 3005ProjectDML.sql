CREATE TABLE public.Members(
	member_id	SERIAL,
	username	VARCHAR(80)	NOT NULL,
	pword		VARCHAR(80)	NOT NULL,
	first_name	VARCHAR(80)	NOT NULL,
	last_name	VARCHAR(80)	NOT NULL,
	sex			VARCHAR(15),
	
	current_weight	INT,
	desired_weight	INT,
	height			INT,
	joined_date		DATE	NOT NULL,
	sex				VARCHAR(15),
	routine_id		INT,
	desired_date	DATE,
	height			INT
	
	PRIMARY KEY(member_id),
	FOREIGN KEY(routine_id) REFERENCES FitnessRoutines(routine_id)
)

CREATE TABLE public.FitnessRoutines(
	routine_id	SERIAL,
	title		VARCHAR(255)
	description	VARCHAR(500)
	catagory	VARCHAR(30)
	
	PRIMARY KEY(routine_id)
)

CREATE TABLE public.billings(
	bill_id		SERIAL,
	amount		INT,
	member_id	INT,
	card_number	INT
	
	PRIMARY KEY(bill_id)
	FOREIGN KEY(member_id) REFERENCES Members(member_id)
)