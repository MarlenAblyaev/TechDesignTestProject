using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_animation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _trigger_name;

    public void Play ()
    {
        _animator.SetTrigger(_trigger_name);
    }
}
