﻿using UnityEngine;

public class CameraPostProcess : MonoBehaviour
{
    public Material PostProcessMaterial
    {
        get;
        set;
    }

    public float Vignette
    {
        set
        {
            PostProcessMaterial.SetFloat("_Vignette", value);
        }
    }

    public float Grayscale
    {
        set
        {
            PostProcessMaterial.SetFloat("_Grayscale", value);
        }
    }

    public float Timer
    {
        set
        {
            PostProcessMaterial.SetFloat("_Timer", value);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, PostProcessMaterial);
    }
}
