using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class DepthImageVisualizer : MonoBehaviour
{
    public ARCameraManager CameraManager
    {
        get => _cameraManager;
        set => _cameraManager = value;
    }

    [SerializeField]
    [Tooltip("The ARCameraManager which will produce camera frame events.")]
    private ARCameraManager _cameraManager;


    public AROcclusionManager OcclusionManager
    {
        get => _occlusionManager;
        set => _occlusionManager = value;
    }

    [SerializeField]
    [Tooltip("The AROcclusionManager which will produce depth textures.")]
    private AROcclusionManager _occlusionManager;

    public RawImage RawImageDepth
    {
        get => _rawImage;
        set => _rawImage = value;
    }

    [SerializeField]
    [Tooltip("The UI RawImage used to display the depth image on screen.")]
    private RawImage _rawImage;

    // public RawImage RawImageConf
    // {
    //     get => _rawImageConf;
    //     set => _rawImageConf = value;
    // }

    // [SerializeField]
    // [Tooltip("The UI RawImage used to display the depth conf image on screen.")]
    // private RawImage _rawImageConf;

    // private Texture2D envDepthConfidenceTexture;
    private Texture2D envDepthTexture;

    public void Update(){
        // envDepthConfidenceTexture = _occlusionManager.environmentDepthConfidenceTexture;
        // _rawImageConf.texture  = envDepthConfidenceTexture;
        envDepthTexture = _occlusionManager.environmentDepthTexture ;
        _rawImage.texture = envDepthTexture;
    }
    
}