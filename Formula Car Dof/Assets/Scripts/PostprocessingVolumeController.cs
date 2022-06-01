using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class PostprocessingVolumeController : MonoBehaviour
{
    [SerializeField] private Slider apertureSlider;
    [SerializeField] private Slider distanceSlider;
    [SerializeField] private Slider hightSlider;
    [SerializeField] private PostProcessVolume volume;

    DepthOfField dof;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings<DepthOfField>(out dof);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAperture()
    {
        dof.aperture.value = apertureSlider.value;
    }

    public void SetDistance()
    {
        Vector3 vec = new Vector3(0, hightSlider.value, distanceSlider.value);
        dof.focusDistance.value = vec.magnitude;
    }
}
