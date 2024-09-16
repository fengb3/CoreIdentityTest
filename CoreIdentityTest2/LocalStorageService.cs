//using Microsoft.JSInterop;
//using System.Text.Json;

//public interface ILocalStorageService
//{
//    Task SetItemAsync<T>(string key, T value);
//    Task<T> GetItemAsync<T>(string key);
//    Task RemoveItemAsync(string key);
//}


//public class LocalStorageService : ILocalStorageService
//{
//    private readonly IJSRuntime _jsRuntime;

//    public LocalStorageService(IJSRuntime jsRuntime)
//    {
//        _jsRuntime = jsRuntime;
//    }

//    public async Task SetItemAsync<T>(string key, T value)
//    {
//        string json = JsonSerializer.Serialize(value);
//        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, json);
//    }

//    public async Task<T> GetItemAsync<T>(string key)
//    {
//        string json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);

//        if (json == null)
//            return default;

//        return JsonSerializer.Deserialize<T>(json);
//    }

//    public async Task RemoveItemAsync(string key)
//    {
//        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
//    }
//}
