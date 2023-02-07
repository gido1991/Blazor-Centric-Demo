using System.Net.Http.Json;
using BlazorDemo.Shared;

namespace BlazorDemo.Client.Shared;

public class ContactsClient: IContactsClient
{
    private readonly HttpClient _httpClient;

    public ContactsClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<Contact>?> GetContacts()
            => await _httpClient.GetFromJsonAsync<IEnumerable<Contact>>("contacts");

    public async Task SubmitContact(Contact contact)
        => await _httpClient.PostAsJsonAsync("contacts", contact);
}