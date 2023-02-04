using BlazorDemo.Shared;

namespace BlazorDemo.Client.Shared;

public interface IContactsClient
{
    Task<IEnumerable<Contact>?> GetContacts();
}