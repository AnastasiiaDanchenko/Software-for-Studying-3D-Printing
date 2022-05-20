using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private Canvas canvas = null;
    private TaskManager taskManager = null;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void Setup(TaskManager taskManager)
    {
        this.taskManager = taskManager;
        Hide();
    }

    public void Show()
    {
        canvas.enabled = true;
    }
    public void Hide()
    {
        canvas.enabled = false;
    }
}
