using SharedLibrary;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var player = await Api.Get<Player>("http://localhost:5000/player/22092003");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
