using System;
using UnityEngine;

public class WorldManager: MonoBehaviour
{
    public static WorldManager Instance {
        get {
            return _instance;
        }
    }

    private static WorldManager _instance;

    public static event Action<World> OnWorldChange;
    private World currentWorld;
    
    void Awake() {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(_instance);
        } else {
            Destroy (gameObject);
        }
    }

    void Start() {
        currentWorld = World.MAIN;
        OnWorldChange?.Invoke(currentWorld);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            ToggleWorld();
        }
    }

    private void ToggleWorld() {
        currentWorld = currentWorld == World.MAIN ? World.OTHER : World.MAIN;
        OnWorldChange?.Invoke(currentWorld);
    }
}
