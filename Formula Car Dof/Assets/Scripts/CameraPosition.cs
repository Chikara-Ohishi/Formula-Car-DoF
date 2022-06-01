using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] Slider distanceSlider;
    [SerializeField] Slider positionSlider;
    [SerializeField] Slider hightSlider;
    [SerializeField] GameObject mainCamera;

    [SerializeField] private float hight;
    [SerializeField] private float distance;
    [SerializeField] private float targetHight;

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
        distance = distanceSlider.value;
        SetCameraPosition();
    }

    public void SetPosition()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, positionSlider.value, 0));
    }

    public void SetHight()
    {
        hight = hightSlider.value;
        SetCameraPosition();
    }

    private void SetCameraPosition()
    {
        mainCamera.transform.localPosition = new Vector3(0, hight, -distance);

        float angle = Mathf.Atan2(hight - targetHight, distance) * Mathf.Rad2Deg;
        mainCamera.transform.localRotation = Quaternion.Euler(new Vector3(angle, 0, 0));
    }

}
