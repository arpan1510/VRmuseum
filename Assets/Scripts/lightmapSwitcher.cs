using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmapSwitcher : MonoBehaviour
{
    // array of lightmap images required as an input
    public Texture2D[] darkLightmapDir, darkLightmapColor;
    public Texture2D[] brightLightmapDir, brightLightmapColor;
    private LightmapData[] brightLightmap, darkLightmap;
    
    void Start()
    {
        // preparing darklightmap data from the array of images of low brightness lightmap
        List<LightmapData> dlightmap = new List<LightmapData>();

        for (int i = 0; i < darkLightmapDir.Length; i++)
        {
            // Adding our array of images to the Lightmap data list

            LightmapData lmdata = new LightmapData();

            lmdata.lightmapDir = darkLightmapDir[i];
            lmdata.lightmapColor = darkLightmapColor[i];

            dlightmap.Add(lmdata);
        }

        darkLightmap = dlightmap.ToArray();

        // preparing brightlightmap data from the array of images of low brightness lightmap
        List<LightmapData> blightmap = new List<LightmapData>();

        for (int i = 0; i < brightLightmapDir.Length; i++)
        {
            LightmapData lmdata = new LightmapData();

            lmdata.lightmapDir = brightLightmapDir[i];
            lmdata.lightmapColor = brightLightmapColor[i];

            blightmap.Add(lmdata);
        }

        brightLightmap = blightmap.ToArray();
    }

    public void switchToDark()
    {
        //method will be called when the High Brightness button will be pressed fin UI
        LightmapSettings.lightmaps=darkLightmap;
    }
    public void switchToBright()
    {
        //method will be called when the Low Brightness button will be pressed in UI
        LightmapSettings.lightmaps = brightLightmap;
    }

}
