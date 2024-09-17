using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightmapSwitcher : MonoBehaviour
{
    public Texture2D[] darkLightmapDir, darkLightmapColor;
    public Texture2D[] brightLightmapDir, brightLightmapColor;
    private LightmapData[] brightLightmap, darkLightmap;
    // Start is called before the first frame update
    void Start()
    {
        List<LightmapData> dlightmap = new List<LightmapData>();

        for (int i = 0; i < darkLightmapDir.Length; i++)
        {
            LightmapData lmdata = new LightmapData();

            lmdata.lightmapDir = darkLightmapDir[i];
            lmdata.lightmapColor = darkLightmapColor[i];

            dlightmap.Add(lmdata);
        }

        darkLightmap = dlightmap.ToArray();

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
        LightmapSettings.lightmaps=darkLightmap;
    }
    public void switchToBright()
    {
        LightmapSettings.lightmaps = brightLightmap;
    }

}
