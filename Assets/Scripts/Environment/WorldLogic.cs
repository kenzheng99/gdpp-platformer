using UnityEngine;

public enum World {
    MAIN,
    OTHER,
    BOTH
}
public class WorldLogic : MonoBehaviour {
    [SerializeField] private World world;

    private void Awake() {
        WorldManager.OnWorldChange += ToggleActive;
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            ToggleActive(World.MAIN);
        }
    }

    private void ToggleActive(World currentWorld) {
        bool active = this.world == currentWorld || this.world == World.BOTH;
        gameObject.SetActive(active);
    }
}
