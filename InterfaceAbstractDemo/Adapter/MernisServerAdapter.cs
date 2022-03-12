using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServerAdapter:ICustomerCheckService
    {
        public bool CheckİfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap); 
           
            return client.TCKimlikNoDogrula(customer.NationalityId,customer.Name.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
            

        }
    }
}
