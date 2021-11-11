using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace tests;

public class ProgramTests
{
    [Fact]
    public async Task GetPerson_WhenPersonExists_ReturnsPerson()
    {
        //arrange
        var app = new WebApplicationFactory<Program>();
        var client = app.CreateClient();

        //act
        var person = await client.GetFromJsonAsync<Person>("/person/1");

        //assert
        Assert.NotNull(person);
    }
}