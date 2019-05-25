using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    void Start()
    {
        Show(this.gameObject, 0.8F);
    }

    public void Show(GameObject obj, float time)
    {
        StartCoroutine(ShowPanelCoroutine(obj, time));
    }

    IEnumerator ShowPanelCoroutine(GameObject obj, float time)
    {
        float timemax = time;

        obj.SetActive(true);
        obj.transform.localScale = Vector3.zero;

        while (time > 0)
        {
            time -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
            obj.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (timemax - time) / timemax);
        }
    }
}
