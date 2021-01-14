using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class AnimationController : MonoBehaviour
{

    public Animator m_PresentationAnimator;
    public Animator m_FourPeopleAnimator;
    public Animator m_TwoPeopleAnimator;
    public Animator m_FourPeopleAnimator_V;
    public Animator m_FourPeopleAnimator_H;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_PresentationAnimator.Play("PowerPointSelect");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_PresentationAnimator.Play("Normal");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_FourPeopleAnimator.Play("ZoomIn");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            m_FourPeopleAnimator.Play("ZoomOut");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            m_FourPeopleAnimator.Play("MoveAndFadeOut");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            m_TwoPeopleAnimator.Play("Normal");

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            m_TwoPeopleAnimator.Play("Create");

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            m_TwoPeopleAnimator.Play("Join");

        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            m_TwoPeopleAnimator.Play("FullScreen");

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            m_TwoPeopleAnimator.Play("ShareScreen");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            m_FourPeopleAnimator_V.Play("SlideIn");

        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            m_FourPeopleAnimator_V.Play("SlideOut");

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_FourPeopleAnimator_H.Play("SlideIn");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_FourPeopleAnimator_H.Play("SlideOut");
        }





    }
    


}
