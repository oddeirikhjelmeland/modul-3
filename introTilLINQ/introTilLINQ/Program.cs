using introTilLINQ;
using SimpleListAndLinqDemo;

// var people = new Person[3];
var people = new List<Person>
{
    new Person(
        1,
        "Per",
        "Hansen",
        new DateTime(1990, 1, 2),
        1234),
    new Person(
        2,
        "Pål",
        "Nilsen",
        new DateTime(1991, 3, 4),
        2345),
    new Person(
        3,
        "Espen",
        "Olsen",
        new DateTime(1992, 5, 6),
        3456),
};

// FirstOrDefault - første som...

var firstPersonInList = people.FirstOrDefault();

var personWhoIsBornBefore1991 = people.FirstOrDefault(p => p.BirthDay.Year < 1991); // per
var personWhoIsBornBefore1981 = people.FirstOrDefault(p => p.BirthDay.Year < 1981); // null

Person personWhoIsBornBefore1991x = null;
foreach (var p in people)
{
    if (p.BirthDay.Year < 1991)
    {
        personWhoIsBornBefore1991x = p;
        break;
    }
}

// SingleOrDefault - den ene som...

var personWithId2 = people.SingleOrDefault(p => p.Id == 2); // pål
var personWithId20 = people.SingleOrDefault(p => p.Id == 20); // null

// Where (tilsvarer filter i JavaScript)

var peopleWithFirstNameWithLetterE =
    people.Where(p => p.FirstName.ToLower().Contains("e"))
        .ToList();

var peopleWithFirstNameWithLetterEx = new List<Person>();
foreach (var p in people)
{
    if (p.FirstName.ToLower().Contains("e"))
    {
        peopleWithFirstNameWithLetterEx.Add(p);
    }
}

// Select (tilsvarer map i JavaScript)

var firstNames = people.Select(p => p.FirstName).ToList();

var firstNamesx = new List<string>();
foreach (var p in people)
{
    firstNamesx.Add(p.FirstName);
}

// Select og Where
// .ToArray
// .ToList

var firstNamesOfPeopleBornBefore1992 = people
    .Where(p => p.BirthDay.Year < 1992)
    .Select(p => p.FirstName)
    .ToList();
//.ToArray();

var firstNamesOfPeopleBornBefore1992x = new List<string>();
foreach (var p in people)
{
    if (p.BirthDay.Year < 1992)
    {
        firstNamesOfPeopleBornBefore1992x.Add(p.FirstName);
    }
}

// Sum, Min, Max, Average

var sumOfPeoplesAges = people.Select(p => p.Age).Sum();
