using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public static class Api
{
    public static async Task<T> Get<T>(string url)
    {
        var getRequest = CreateRequest(url, RequestType.Get);
        getRequest.SendWebRequest();

        while (!getRequest.isDone)
        {
            await Task.Delay(10);
        }

        return JsonConvert.DeserializeObject<T>(getRequest.downloadHandler.text);
    }
    public static async Task<T> Post<T>(string url, object data)
    {
        var postRequest = CreateRequest(url, RequestType.Post, data);
        postRequest.SendWebRequest();

        while (!postRequest.isDone)
        {
            await Task.Delay(10);
        }

        return JsonConvert.DeserializeObject<T>(postRequest.downloadHandler.text);
    }

    private static UnityWebRequest CreateRequest(string url, RequestType type, object data = null)
    {
        var request = new UnityWebRequest(url, type.ToString());

        if (data != null)
        {
            var bodyRaw = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        }

        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        return request;
    }

    public enum RequestType
    {
        Put,
        Get,
        Post,
    }
}
