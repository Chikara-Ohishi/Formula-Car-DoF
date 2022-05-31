using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] Slider distanceSlider;
    [SerializeField] Slider positionSlider;
    [SerializeField] GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDistance()
    {
        mainCamera.transform.localPosition = new Vector3(0, 2.5f, -distanceSlider.value);
    }

    public void SetPosition()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, positionSlider.value, 0));
    }
}
