Just a couple simple scripts, one in C# and one in Python 3, that take a list of students and their assignment information, then fill out a template file with that data for each student.
Both scripts will create a file for each student, named by their unique ID.

* TO RUN PYTHON FILE
	1. Make sure Python is installed
	2. clone this repository
	3. In command line, execute: 
		> python3 mm.py 465HW4.tsv 465HW4.tmp

* TO RUN C# FILE
	1. Make sure you have c# or mono installed
	2. Clone this repository
	3. In command line, execute:
		> mcs mm.cs

		> mono mm.exe 465HW4.tsv 465HW4.tmp





Example Output file:

Name: Kenny Briddle	(465)

ID: briddlek

Total: 70/100	Subtotal: 70		Total deductions: 0

Time due: 2/5/2016 23:59:00

Submitted: ontime

Late minutes: 0

Total: 70/100	Subtotal: 70		Total deductions: 0

Problem 1: 15/35

Many test cases missing.

Problem 2: 55/65

Missing the report.

