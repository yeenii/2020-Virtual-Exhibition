using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraButton : MonoBehaviour
{
    public MainCamera my_camera;
    public int target_index = 0;
    private void OnMouseDown()
    {
        my_camera.MoveCamera(target_index);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
