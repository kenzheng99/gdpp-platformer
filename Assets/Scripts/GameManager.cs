using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance; // set up the singleton
    [SerializeField] private GameObject player;
    public Vector2 lastCheckpointPos = new Vector2(-3,0);
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
        else
        {
            Destroy (gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerDeath()
    {
        //animations, sounds, screen fades to black or smth
        //probably wait for some seconds
        Destroy(player);
    }

    void PlayerRespawn()
    {
        Instantiate(player, lastCheckpointPos, Quaternion.identity);
    }
}
