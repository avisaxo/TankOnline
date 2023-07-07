using UnityEngine;

public class DataStatus : MonoBehaviour
{
    public int IndexPlayer = 0;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void IncrementIndexSpawned()
    {
        IndexPlayer++;
    }

    public int GetIndexSpawned()
    {
        return IndexPlayer;
    }
}
