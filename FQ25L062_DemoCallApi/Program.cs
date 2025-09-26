// See https://aka.ms/new-console-template for more information


using FQ25L062_DemoCallApi;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

//Call GET & DELETE ne peuvent pas envoyer de contenu
// Exemple de Get
using (HttpClient client = new HttpClient())
{
    //using (HttpResponseMessage responseMessage = client.GetAsync("https://localhost:7093/api/Dino").Result)
    //{
    //    //responseMessage.EnsureSuccessStatusCode(); //Si Code 20x pas de soucis sinon Exception

    //    if(responseMessage.IsSuccessStatusCode)
    //    {
    //        string json = responseMessage.Content.ReadAsStringAsync().Result;
    //        Console.WriteLine(json);
    //        IEnumerable<Dino>? dinos = JsonSerializer.Deserialize<Dino[]>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

    //        if(dinos is not null)
    //        {
    //            foreach(Dino dino in dinos)
    //            {
    //                Console.WriteLine(dino.Espece ?? "Null");
    //            }
    //        }
    //    }
    //}

    // Méthode simplifiée
    //try
    //{
    //    IEnumerable<Dino>? dinos = client.GetFromJsonAsync<Dino[]>("https://localhost:7093/api/Dino").Result;

    //    if (dinos is not null)
    //    {
    //        foreach (Dino dino in dinos)
    //        {
    //            Console.WriteLine(dino.Espece ?? "Null");
    //        }
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}

    int id = 1;
    //using (HttpResponseMessage responseMessage = client.GetAsync($"https://localhost:7093/api/Dino/{id}").Result)
    //{

    //    //responseMessage.EnsureSuccessStatusCode(); //Si Code 20x pas de soucis sinon Exception

    //    if (!responseMessage.IsSuccessStatusCode)
    //    {
    //        switch(responseMessage.StatusCode)
    //        {
    //            case HttpStatusCode.BadRequest:
    //                Console.WriteLine("Il y a une erreur dans la requête!");
    //                break;
    //            case HttpStatusCode.NotFound:
    //                Console.WriteLine($"Aucun dinosaure trouvé avec l'id => {id}");
    //                break;
    //        }

    //    }
    //    else
    //    {
    //        string json = responseMessage.Content.ReadAsStringAsync().Result;
    //        Console.WriteLine(json);
    //        Dino? dino = JsonSerializer.Deserialize<Dino>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

    //        if (dino is not null)
    //        {
    //            Console.WriteLine(dino.Espece);
    //        }
    //    }
    //}

    //try
    //{
    //    Dino? dino = client.GetFromJsonAsync<Dino>($"https://localhost:7093/api/Dino/{id}").Result;

    //    if (dino is not null)
    //    {
    //        Console.WriteLine(dino.Espece);
    //    }
    //}
    //catch (AggregateException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}


    //Call POST, PUT, PATCH un contenu sera attendu
    Dino dino = new Dino("Michaelosaurus Maximum Decimus Général...", -110, 177);
    //Méthode classique    
    //Avant
    //string json = JsonSerializer.Serialize(dino);
    //HttpContent content = new StringContent(json);
    //content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

    //Après
    //HttpContent httpContent = JsonContent.Create(dino); //Serializer et préparer le contenu pour indiquer qu'il s'agit de JSON
    ////Dans le cas du PUT c'est la méthode PutAsync et dans le cas du PATCH c'est la méthode PatchAsync
    //using (HttpResponseMessage responseMessage = client.PostAsync("https://localhost:7093/api/Dino/", httpContent).Result)
    //{
    //    if (responseMessage.IsSuccessStatusCode)
    //    {
    //        Console.WriteLine("Dinosaure créé!");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Erreur lors de la création du dinosaure!");
    //    }
    //}

    //Méthode simplifiée 
    try
    {
        var response = client.PostAsJsonAsync("https://localhost:7093/api/Dino/", dino).Result;
        response.EnsureSuccessStatusCode();
        Console.WriteLine("Dinosaure créé!");
    }
    catch (Exception)
    {
        Console.WriteLine("Erreur lors de la création du dinosaure!");
    }

}
