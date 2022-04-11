using Bogus;
using ConsoleApp;
using ConsoleApp.Utilities;
using Newtonsoft.Json.Linq;
using System;

public enum Gender
{
	male,
	female
}

public class UserFactory
{
	public static RegistrationUser CreateValideUser()
	{
		var fakeData = new Faker<RegistrationUser>("tr")
				.RuleFor(i => i.FirstName, i => i.Name.FirstName())
				.RuleFor(i => i.LastName, i => i.Name.LastName())
				.RuleFor(i => i.UserName, i => i.Internet.UserName())
				.RuleFor(i => i.EmailAddress, i => i.Person.Email)
				.RuleFor(i => i.City, i => i.Address.City())
				.RuleFor(i => i.Phone, i => i.Phone.PhoneNumber())
				.Generate(1);

		var con = fakeData.DumpString();
		dynamic myObject = JValue.Parse(con);

		return new RegistrationUser
		{
			FirstName = myObject[0].FirstName,
			LastName = myObject[0].LastName,
			Password = myObject[0].Password,
			UserName = myObject[0].UserName,
			EmailAddress = myObject[0].EmailAddress,
			Month = "3",
			Year = "1996",
			FirstName2 = "Ivan",
			LastName2 = "Ivanov",
			Address = "Ivanov str.",
			City = "Ivanovgrad",
			State = "7",
			PostCode = "80000",
			Company = "ivan OOD",
			Phone = "044 444 444",
			Aliase = "hallo"
		};
	}
}


