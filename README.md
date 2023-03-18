# student_record_app

## Начало работы:
- Создать базу данных studentList
```
create studentList
use studentList
```
- создать таблицы adminUsers и studentRecords следующими запросами или с помощью приложенного файла .xlsx
```
create table studentRecords
(
Student_Id int primary key identity(1, 1),
Student_Name varchar(50),
Student_Surname varchar(50),
Student_GPA varchar(50),
Student_Major varchar(50),
Student_Login varchar(50),
Student_Password varchar(50),
)
insert into studentRecords values('John', 'Smith', '98', 'Economics', 'john', 'john')

create table adminUsers 
(
U_ID int primary key identity(1,1),
U_Login varchar(50),
U_Password varchar(50),
U_Type varchar(50)
)
insert into adminUsers values('admin', 'admin', 'Admin')
insert into adminUsers values('employee', 'employee', 'Employee')
```
## Работа с проектом
- Открыть проект, в форме EditRecords на 18 строчке, в форме LoginForm на 17 строчке и в ViewStudentList на 16 строчке заменить **YourDB** на название своего сервера (Да, я так и не разобралась с .dll, but oh well ¯\_(ツ)_/¯) 
```
string path = @"Data Source=YourDB;Initial Catalog=studentList;Integrated Security=True";
```
- запустить проект, ввести данные 
1. от учетки студента (например john, john и выбрать Student в комбобоксе типа пользователя). Откроется окно с таблицей студентов, в котором указаны имя, фамилия, средний балл и учебная программа
2. от учетки работника приемной комиссии (employee, employee, выбрать Employee в комбобоксе типа пользователя). Откроется форма с тремя кнопками, View Records откроет окно со списком учащихся, Change Records откроет окно, в котором можно внести записи о новых пользователях и изменить уже имеющиеся, кнопка Delete для учетки работника заблокирована
3. от учетки админа (admin, admin, выбрать Admin), чтобы делать все то же самое, что и работник приемной комиссии + удалять 
