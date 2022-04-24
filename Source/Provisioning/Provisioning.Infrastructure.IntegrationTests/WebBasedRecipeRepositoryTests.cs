using Provisioning.Interfaces;
using Provisioning.Interfaces.Recipes.List;
using Xunit;

namespace Provisioning.Infrastructure.IntegrationTests;

public class WebBasedRecipeRepositoryTests
{
    protected const string baseUrlForTests =
        "https://raw.githubusercontent.com/stho32/M005-Windows-CSharp/main/Recipies/";
    
    private static IRecipeRepository GetRepository()
    {
        return new WebBasedRecipeRepository(baseUrlForTests);
    }
    
    [Fact]
    public async void GetList_retrieves_Information_from_the_web()
    {
        var repository = GetRepository();
        RecipeSummary[]? list = await repository.GetList();
        Assert.NotNull(list);
        Assert.NotEmpty(list);
    }
    
    [Fact]
    public async void GetList_contains_the_correct_list_of_recipes()
    {
        var repository = GetRepository();
        RecipeSummary[]? list = await repository.GetList();
        Assert.NotNull(list);
        Assert.Equal(2, list.Length);
        
        Assert.Equal("Chrome", list[0].Name);
        Assert.Equal("A machine with chrome", list[0].Description);
        Assert.Equal("Chrome.json", list[0].FilePath);
        
        Assert.Equal("Firefox", list[1].Name);
        Assert.Equal("A machine with firefox", list[1].Description);
        Assert.Equal("Firefox.json", list[1].FilePath);
    }

    [Fact]
    public async void GetByFilePath_without_a_correct_filePath_returns_null()
    {
        var repository = GetRepository();

        var notAvailable = await repository.GetByFilePath("Not available");

        Assert.Null(notAvailable);
    }

    [Fact]
    public async void GetByFilePath_with_a_correct_filePath_is_not_null()
    {
        var repository = GetRepository();

        var recipe = await repository.GetByFilePath("Firefox.json");

        Assert.NotNull(recipe);
    }
    
    [Fact]
    public async void GetByFilePath_with_a_correct_filePath_null()
    {
        var repository = GetRepository();

        var recipe = await repository.GetByFilePath("Firefox.json");

        Assert.NotNull(recipe);
    }
    
    [Fact]
    public async void GetByFilePath_with_a_correct_filePath_retrieves_correct_values()
    {
        var repository = GetRepository();

        var recipe = await repository.GetByFilePath("Firefox.json");

        Assert.Equal("Development machine with firefox installed", recipe.Name);
        Assert.Single(recipe.HostDescriptions);
        Assert.Equal("main", recipe.HostDescriptions[0].Name);
        Assert.Equal("Install chocolatey", recipe.HostDescriptions[0].Tasks[0].Name);
        Assert.Equal(true, recipe.HostDescriptions[0].Tasks[0].AsAdmin);
        Assert.Equal("powershell", recipe.HostDescriptions[0].Tasks[0].Shell);
        Assert.Equal("Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))", 
            recipe.HostDescriptions[0].Tasks[0].Command);
    }
}