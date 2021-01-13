using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class MyVideoPlayer : MonoBehaviour
{

    VideoPlayer m_VideoPlayer;
    RawImage m_RawImage;

    // Start is called before the first frame update
    void Start()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_RawImage = GetComponent<RawImage>();

        
    }

    // Update is called once per frame
    void Update()
    {
        m_RawImage.texture = m_VideoPlayer.texture;
    }
}
