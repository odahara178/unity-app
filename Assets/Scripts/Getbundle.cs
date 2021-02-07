using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Getbundle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(DownLoad());
    }

    IEnumerator DownLoad()
    {
        string bundleUrl = Application.streamingAssetsPath + "/yuusya";
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(bundleUrl);
        while (!request.isDone)
        {
            yield return null;
        }
        AssetBundle assetBundle = request.assetBundle;
        AssetBundleRequest image = assetBundle.LoadAssetAsync<GameObject>("main");

        GameObject obj = (GameObject)Instantiate(image.asset);
        obj.transform.SetParent(transform, false);
        obj.GetComponent<RectTransform>().anchoredPosition = new Vector2(2, 2);
    }
}