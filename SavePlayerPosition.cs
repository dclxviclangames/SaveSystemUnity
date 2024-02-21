using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{
    public Transform player;
    public Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("playerStarted"))
        {
            player.position = new Vector3(PlayerPrefs.GetFloat("playerPositioX"), PlayerPrefs.GetFloat("playerPositioY"), PlayerPrefs.GetFloat("playerPositioZ"));
        }
        else
        {
            player.position = playerPosition;
        }

        if(!PlayerPrefs.HasKey("playerStarted"))
        {
            PlayerPrefs.SetInt("playerStarted", 1);
            PlayerPrefs.Save();
        }
    }

    public void SavePlayerPos()
    {
        playerPosition = player.position;
        PlayerPrefs.SetFloat("playerPositioX", playerPosition.x);
        PlayerPrefs.SetFloat("playerPositioY", playerPosition.y);
        PlayerPrefs.SetFloat("playerPositioZ", playerPosition.z);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
