Leonides Martinez
CST-150
September 26, 2021
Mark Smithers

Topic 1 Activity 1

Rubric
1. Install the necessary software for the course.

	Visual Studio was installed according to the instructions from our textbook "Starting out with Visual C#:Fifth Edition".

2. Use the .NET environment to develop a simple graphical user interface using built-in tools.

	Using the Visual Studio IDE, I created a simple GUI which asks for the student's first and last name, and course name. The form includes a show name, clear, and exit button.

3. Function for each control.

	All the controls below were entered inside groupBox1.

	firstNameLabel: Label to instruct the user to enter first name.
	lastNameLabel: Label to instruct the user to enter last name.
	courseLabel: Label to instruct the user to enter course name.
	
	firstNameTextBox: TextBox for user to Input first name.
	lastNameTextBox: TextBox for user to Input last name.
	courseTextBox: TextBox for user to Input course name.

	studentLabel: Label for the display information to the right.

	displayStudentLabel: Label will display student information as coded when "Show Name" is clicked.

	showNameButton: When clicked, firstNameTextBox and lastNameTextBox will be concatenated. The course name will be displayed on the next line.
			Button is coded with ampersand before "S". Alt + S will also show information.
			Button declared as accept button, therefore, ENTER button will also show the information.
	clearButton: When clicked, the information under firstNameTextBox, lastNameTextBox, courseNameTextBox, and displayStudentLabel will be cleared.
		     Button is coded with ampersand before "C". Alt + C will also clear information.
		     Focus is declared on firstNameLabel when information is cleared.
	exitButton: When clicked, form will close.
		    Button is coded with ampersand before "x". Alt + x will also close the form.
		    Button declared as cancel button, therefore, ESC button will also close the form.

GitHub Link:
https://github.com/Leomtz03/Activity1.git
https://github.com/Leomtz03/Activity1