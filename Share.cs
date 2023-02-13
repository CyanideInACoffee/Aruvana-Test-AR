using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Share : MonoBehaviour
{
    public GameObject UI;
    public void KlikShare()
    {
        UI.SetActive(false);
        StartCoroutine(AmbilScreenshotDanShare());
    }

  
    private IEnumerator AmbilScreenshotDanShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = System.IO.Path.Combine(Application.temporaryCachePath, "AR Atuvana Test.png");
        System.IO.File.WriteAllBytes(filePath, ss.EncodeToPNG());

        Destroy(ss);
        UI.SetActive(true);

        NativeGallery.SaveImageToGallery(ss, "AR Screenshot", name);

        yield return new WaitForSeconds(1.5f);

        new NativeShare().AddFile(filePath)
            .SetSubject("My Games").SetText("Ini Hasil AR").SetUrl("")
            .Share();
    }

}
