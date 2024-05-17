using System.Threading.Tasks;
using insurtech.Models.TokenAuth;
using insurtech.Web.Controllers;
using Shouldly;
using Xunit;

namespace insurtech.Web.Tests.Controllers
{
    public class HomeController_Tests: insurtechWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}