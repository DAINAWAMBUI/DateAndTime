# DateAndTime
This is a code to use DateTime class to execute various expressions
line 14 - initializes a class DateTime and initializes it with DateTime.now to return the current date and time
line 16 - uses .ToShortDateString() to return the current date in short way eg. 6/4/2024
line 17- uses .ToLongtDateString() to return the date in a long way and returns Tuesday, June 4, 2024
line 19 - uses .ToLongTimeString() to return a long time with hour, minutes and seconds
line 18 - uses .ToShortTimeString() to return short time with only the hour and minutes
line 20 - uses  .DayOfWeek.ToString() to return the day of the week
line 21- uses  .AddDays(3).ToLongDateString() to add three days to the current date and returns it
line 22 - uses .AddHours(4).ToShortTimeString() to add 4hrs to the current time and returns the time
line 23- uses .AddDays(-3).ToLongDateString() to move three days backward and returns the date
line 24 - uses .AddHours(-6).ToShortTimeString() to subtract 6hrs from the current time and return the time
line 25- uses .Year.ToString() to return the year
line 26 uses .Month.ToString() to return the month
line 27 uses .Subtract(myValue).ToString() 
line 31-33 uses the dateTime class and initializes a variable called myBirthday and gives the year,month and date of birth. it the uses the WriteLine () to execute myBirthday
35-38 - uses the dateTime class and initializes a variable called myBirthday and gives the year,month and date of birth
then initializes another class called TimeSpan to declare a variable called myAge
Then uses .Now.Subtract(myBirthday1) and parse myBirthday to the variable myAge
Then uses .TotalDays to return the total days
