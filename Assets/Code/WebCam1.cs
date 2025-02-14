using UnityEngine;


    public class WebCam1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            WebCamTexture webcamTexture = new WebCamTexture(devices[0].name);
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }
    }



