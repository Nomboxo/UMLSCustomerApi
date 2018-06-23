using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ULMSCustomerApi.AutoMapper;
using ULMSCustomerApi.Controllers;
using ULMSCustomerApi.Tests.TestData;
using ULMSDomain.Contracts;
using ULMSDomain.Services;
using ULMSLookUps.Constants;
using ULMSRepository.Logic;

namespace ULMSCustomerApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomerMapper.InitializeCustomerMapper();
            var customerServiceMock = A.Fake<ICustomerService>();
            var customerRepositoryMock = A.Fake<ICustomerRepository>();
            //var customerController = new CustomerController(customerServiceMock);

            var customerController = new CustomerController(new CustomerService( new CustomerRepository()));

            //Act
            var response = customerController.AddNewCustomer(CustomerBuilder.BuildCustomer());

            //Assert
            Assert.AreEqual(response.StatusCode, ResponseCodes.Ok);
        }
    }
}