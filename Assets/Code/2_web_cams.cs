using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public class Two_webcams : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            Debug.Log("Количество подключенных камер: " + devices.Length);
            for (int i = 0; i < devices.Length; i++)
            {
                Debug.Log("Камера " + i + ": " + devices[i].name);
            }

            WebCamTexture webcam1 = new WebCamTexture(devices[0].name);
            WebCamTexture webcam2 = new WebCamTexture(devices[0].name);

        }
    }
}

