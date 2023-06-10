using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMove : MonoBehaviour
{
    [SerializeField] GameObject screen;
    [SerializeField] Image progressImage;

    public void NextScene()
    {
        StartCoroutine(LoadScene(1));
    }

    IEnumerator LoadScene(int index)
    {
        screen.SetActive(true);

        AsyncOperation operation = SceneManager.LoadSceneAsync(index);

        progressImage.fillAmount = 0;

        operation.allowSceneActivation = false;
        // allowSceneActivation : �� �̵��� �����ϴ� ����
        // true -> ���� �̵��մϴ�.
        // false -> ���� �̵����� �ʽ��ϴ�.

        float progress = 0;

        
        
        while (operation.isDone == false)
        {
            progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);
            // MoveTowards(A, B, �����Ӹ�ŭ A������Ʈ�� B������Ʈ�� �̵��ϴ� �Լ�)

            progressImage.fillAmount = progress;

            // 0.9f���� �� �ε��� �����ϴ�.
            if(progress >= 0.9f)
            {
                progressImage.fillAmount = 2f;
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
        // isDone : �� �ε��� �� �������� Ȯ���ϴ� ����
        // true -> �� �ε��� �� ���� ����
        // false -> �� �ε��� �� ������ ���� ����

        yield return null;
    }
}
