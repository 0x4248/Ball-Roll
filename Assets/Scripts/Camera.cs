using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    void Awake () {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;
    }
    private void FixedUpdate() {
        transform.position = new Vector3(player.position.x + 3,player.position.y + 0, transform.position.z);
    }
}
