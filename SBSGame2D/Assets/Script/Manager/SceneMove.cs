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
        // allowSceneActivation : 씬 이동을 제어하는 변수
        // true -> 씬을 이동합니다.
        // false -> 씬을 이동하지 않습니다.

        float progress = 0;

        
        
        while (operation.isDone == false)
        {
            progress = Mathf.MoveTowards(progress, operation.progress, Time.deltaTime);
            // MoveTowards(A, B, 프레임만큼 A오브젝트가 B오브젝트로 이동하는 함수)

            progressImage.fillAmount = progress;

            // 0.9f에서 씬 로딩을 끝냅니다.
            if(progress >= 0.9f)
            {
                progressImage.fillAmount = 2f;
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
        // isDone : 씬 로딩이 다 끝났는지 확인하는 변수
        // true -> 씬 로딩이 다 끝난 상태
        // false -> 씬 로딩이 다 끝나지 않은 상태

        yield return null;
    }
}
