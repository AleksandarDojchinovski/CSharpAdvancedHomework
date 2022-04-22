// See https://aka.ms/new-console-template for more information
using Models.Interfaces;
using UsersDataBase;

Database data = new();

data.aleksandar.PrintInfo();
data.petko.PrintInfo();
data.vlatko.PrintInfo();
data.trajko.PrintInfo();