# Driving & Vehicle License Department System

![Screenshot](Pics/DVLD_Screenshot.png)

---
## How to use
1. Clone this repo.
2. Restore 'DVLD.bak' database file in MSSQL Server.
3. Run Visual Studio 2022.
4. Build the project.

---
1. **Technologies:**
	1. .NET Framework.
	2. C\#.
	3. ADO.NET.
	4. Microsoft SQL.
2. **Architecture:** Three-tire.
3. **UI:** Google *Material You* icons and color scheme.
4. **Database system:** Interacte with *MS SQL* using *ADO.NET*.
5. **Security:**
	1. Users password hashed with `SHA-256`.
	2. Using windows registry to save user login.
6. **Logger:** Simple error logging with windows events.
7. **Modules:**
	1. Main and login forms.
	2. **People management:**
		1. manage form.
		2. info form.
		3. Add new.
		4. Delete.
		5. Update.
	3. **Users management:**
		1. manage form.
		2. info form.
		3. Add new.
		4. Delete.
		5. Update.
		6. change password.
	4. **Drivers management:**
		1. manage form.
		2. Update.
		3. Delete.
	5. **License management:** local and international licenses
		1. info form.
		2. manage form.
		3. Add new.
		4. Detain:
			1. Manage detain.
			2. create new detain.
		5. Replace for:
			1. Lost.
			2. Damaged.
		6. Update.
		7. Renew.
		8. History.
	6. **Appointment scheduling:**
		1. schedule an appointment.
	7. **Test logic:**
		1. manage form.
		2. schedule a test.
		3. take test form.
		4. update test.
		5. three tests:
			1. Vision test.
			2. Pratical steet test.
			3. Paper test.
	8. **Application Types:**
		1. manage app types.
		2. update.

---
