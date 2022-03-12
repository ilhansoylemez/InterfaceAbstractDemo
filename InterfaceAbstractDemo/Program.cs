
using InterfaceAbstractDemo.Abstract;

using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDemo.Adapter;

BaseCustomerManager basecustomer = new StarbucksCustomerManager(new MernisServerAdapter());

BaseCustomerManager basecustomer2 = new NeroCustomerManager();


basecustomer.Save(new Customer { DateOfBirth = new DateTime(1997, 5, 31), Name = "İlhan", LastName = "Söylemez", NationalityId = 24211192484 });


basecustomer2.Save(new Customer { DateOfBirth = new DateTime(1998, 5, 31), Name = "iİlhan", LastName = "Söylemez", NationalityId = 24211192484 });