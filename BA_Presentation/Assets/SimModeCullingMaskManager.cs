using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimModeCullingMaskManager : MonoBehaviour
{
    private const int EVERYTHING = -1;
	//private const string SIMSCREEN = "SimScreen";
    //private const string HOLOLENS_UI = "HoloLensUI";
    private const string LABEL = "Label";
    private const string LABEL_STATIC = "LabelStatic";


    //private UserProfile config;

    void Start()
    {
        //config = UserProfile.Instance;
        //if(config == null) return;
        //toggleCameraLayers(config.MonoScreenActive);
    }

    public void OnSimulationModeToggled(bool isMonoScreenActive)
    {
        toggleCameraLayers(isMonoScreenActive);
    }

    private void toggleCameraLayers(bool isMonoScreenActive)
    {
        if(isMonoScreenActive)
        {
            // Set CullingMask to show SimScreenLayer only -> excluding interactables
			Camera.main.LayerCullingHide(LABEL);
            //Camera.main.LayerCullingShow(HOLOLENS_UI);
			//Camera.main.LayerCullingShow(SIMSCREEN);
        }
        else
        {
            Camera.main.LayerCullingShow(LABEL);
            // Set CullingMask to show all Layers but not SimScreenLayer
			//Camera.main.LayerCullingShow(EVERYTHING);
			//Camera.main.LayerCullingHide(SIMSCREEN);
        }
    }

    public void OnStaticSimulationModeToggled(bool isMonoScreenActive) {
        toggleStaticCameraLayers(isMonoScreenActive);
    }

    private void toggleStaticCameraLayers(bool isMonoScreenActive) {
        if(isMonoScreenActive)
        {
            // Set CullingMask to show SimScreenLayer only -> excluding interactables
			Camera.main.LayerCullingHide(LABEL_STATIC);
            //Camera.main.LayerCullingShow(HOLOLENS_UI);
			//Camera.main.LayerCullingShow(SIMSCREEN);
        }
        else
        {
            Camera.main.LayerCullingShow(LABEL_STATIC);
        }
    }
}
