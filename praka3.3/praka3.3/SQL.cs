using System;
SQLCommand command1 = new SQLCommand();
command1.CommandText = "SELECT * FROM Автомобили";

SQLCommand command2 = new SQLCommand("insert into автомобили values (1, Ваз 2115, Снежная королева)");

command1.Execute();
command2.Execute();