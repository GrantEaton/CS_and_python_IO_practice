import re
import fileinput
import shutil
from sys import argv

script, studentsFile, templateFile = argv

#  was going to use this class until I realized it wasnt needed. Saving it for future reference.

class Student:
    name = "";
    ID = "";
    course = "";
    due	= "";
    submitted = "";
    minutesLate	= "";
    lateDeduction = "";
    p1 = "";
    P1comments = "";
    P2 = "";
    P2comments = "";
    subtotal = "";
    total= "";

    def __init__(self, name, ID, course, due, submitted, minutesLate, lateDedction, p1, p1comments, p2, p2comments, subtotal, total):
        self.name = name
        self.ID = ID 
        self.course = course 
        self.due = due
        self.submitted = submitted 
        self.minutesLate = minutesLate 
        self.lateDedction 
        self.p1 = p1 
        self.p1comments = p1comments 
        self.p2 = p2 
        p2comments= p2comments 
        self.subtotal = subtotal 
        self.total = total 

# go through lines of file, strip by new line, then by tabs
lines = [line.rstrip('\n') for line in open(studentsFile)] 
#students is in format: SplitLines[SplitTabs[]]
students = []

for i in range(len(lines)):
    if i != 0:
        students.append(re.split(r'\t+', lines[i].rstrip('\t')))

# take in a list (called student) of student's attributes 
# creates a file named by the student's ID filled out by the template file
def createStudentFile(student):
    newFileName = student[1] + '.py'
    shutil.copyfile(templateFile, newFileName)
    #with open(newFileName) as f:
        #for c in f.read():
    lineNum = 0
    
    #get number of lines in file
    numLines = sum(1 for _ in open(templateFile))
    # check for keywords to replace and replace them if found
    with fileinput.FileInput(newFileName, inplace=True, backup='') as file:
        for line in file:
            if lineNum == 0:
                lineZero = line.replace("<<NAME>>", student[0])
                print(lineZero.replace("<<COURSE>>", student[2]), end='')
            elif lineNum == 1:
                print(line.replace("<<ID>>", student[1]), end='')
            elif lineNum == 4:
                print(line.replace("<<DUE>>", student[3]), end='')
            elif lineNum == 5:
                print(line.replace("<<SUBMITTED>>", student[4]), end='')
            elif lineNum == 6:
                print(line.replace("<<MINUTESLATE>>", student[5]), end='')
            elif lineNum == 7:
                print(lineTwo.replace("<<LATEDEDUCTION>>", student[6]), end='')
            elif lineNum == 9:
                print(line.replace("<<P1>>", student[7]), end='')
            elif lineNum == 10: 
                print(line.replace("<<P1COMMENTS>>", student[8]), end='')
            elif lineNum == 12:
                print(line.replace("<<P2>>", student[9]), end='')
            elif lineNum == 13:
                print(line.replace("<<P2COMMENTS>>", student[10]), end='')
            elif lineNum == 2:
                lineTwo = line.replace("<<TOTAL>>", student[12])
                lineTwo = lineTwo.replace("<<SUBTOTAL>>", student[11])
                print(lineTwo.replace("<<LATEDEDUCTION>>", student[6]), end='')
            lineNum += 1

# create files for each student
for i in range(len(students)):
        createStudentFile(students[i])


