using System.Collections;
using System.Collections.Generic;
using Overimagined.Common;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : SingletonMono<Test>
{
    void Update()
    {
        DebugInfo.Set("frame", Time.frameCount);

        if (Keyboard.current.f1Key.wasPressedThisFrame)
            DebugInfo.ToggleVisible();
    }
}
