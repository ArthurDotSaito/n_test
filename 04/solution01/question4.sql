CREATE TABLE
    Doctors(
        id serial PRIMARY KEY,
        name VARCHAR(100) NOT NULL,
        crm VARCHAR(25) UNIQUE NOT NULL
    )

CREATE TABLE
    Patients(
        id serial PRIMARY KEY,
        name VARCHAR(100) NOT NULL,
        cpf VARCHAR(20) UNIQUE NOT NULL,
    )

CREATE TABLE
    Appoitments(
        id serial PRIMARY KEY,
        doctor_id INT REFERENCES Doctors(id),
        patient_id INT REFERENCES Patients(id),
        date DATE NOT NULL,
    )

CREATE INDEX idx_doctor_id ON Doctors(id);

CREATE INDEX idx_patient_id ON Patients(id);

CREATE INDEX idx_doctor_name ON Doctors(name);

CREATE INDEX idx_patient_name ON Patients(name);

CREATE INDEX idx_patient_appointments_id ON Appointments(patient_id);

CREATE INDEX idx_doctor_appointments_id ON Appointments(doctor_id);

/*Quero consultar todos os médicos de um determinado paciente*/

SELECT Doctors.name
FROM Doctors
    INNER JOIN Appoitments ON Doctors.id = Appoitments.doctor_id
WHERE
    Appoitments.patient_id = 1;