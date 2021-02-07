using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLoad : MonoBehaviour
{

    void Start()
    {
        //AssetBundlePrefab();
        AssetBundleImage();
    }

    void AssetBundleImage()
    {
        AssetBundle image = AssetBundle.LoadFromFile("Assets/StreamingAssets/Image/yuusya");
        if (image == null)
        {
            // ロード失敗
            Debug.Log("error : load bundle");
        }
        else
        {
            // ロード成功
            Debug.Log("success : load bundle");


            Image ist = image.LoadAsset<Image>("main.png");
            if (ist == null)
            {
                //// Prefabのロード失敗
                Debug.Log("error : load asset");
            }
            else
            {
                Debug.Log("success : load asset");

                //var _image = this.GetComponent<Image>();
                //_image.sprite = ist;
                Instantiate(image);
            }
        }
    }


    void AssetBundlePrefab()
    {
        // アセットバンドルのロード
        AssetBundle ab = AssetBundle.LoadFromFile("Assets/StreamingAssets/Android/prefab");

        if (ab == null)
        {
            //// ロード失敗
            //Debug.Log("error : load bundle");
        }
        else
        {
            //// ロード成功
            //Debug.Log("success : load bundle");

            // Prefabのロード
            GameObject prefab = ab.LoadAsset<GameObject>("sd");

            if (prefab == null)
            {
                //// Prefabのロード失敗
                //Debug.Log("error : load asset");
            }
            else
            {
                // Prefabのロード成功

                // Prefabをインスタンス化
                Instantiate(prefab);
            }
        }
    }
}