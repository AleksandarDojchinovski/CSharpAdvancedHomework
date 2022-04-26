// See https://aka.ms/new-console-template for more information
using FakeDataBase;
using Models;
using Models.Generic;

Database database = new Database();
database.dogStore.PrintPets();
database.catStore.PrintPets();
database.fishStore.PrintPets();
database.dogStore.BuyPet("Rex");
database.catStore.BuyPet("Garfield");
database.dogStore.PrintPets();
database.catStore.PrintPets();
