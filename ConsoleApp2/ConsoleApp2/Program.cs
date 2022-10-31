// See https://aka.ms/new-console-template for more information
using ConsoleApp2;



var Person1 = new Person("Bernt", new Kidney(false, false));
var Person2 = new Person("Kåre", new Kidney(true,true));


var Operation = new Operation(Person1, Person2);

Operation.Operate();
