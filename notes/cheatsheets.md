# Unity UI 速查表（D18-D19）

## 1. 基础三件套

- **Canvas（画布）**：所有 UI 的容器，Render Mode 默认 `Screen Space - Overlay`（屏幕空间覆盖，最常用，UI 永远盖在画面上）。
- **EventSystem（事件系统）**：按钮点击、滑块拖动的"感应器官"。场景里有可交互 UI 就必须有一个（创建 UI 时自动生成，**按钮点了没反应先查它在不在**）。
- **Rect Transform**：UI 物体的位置组件（普通物体用 Transform），锚点 Anchors 决定相对屏幕的停靠/拉伸方式。

## 2. 常用控件（Legacy）

| 控件 | 用途 | 关键属性/事件 |
|---|---|---|
| Text | 文本 | `.text` |
| Image | 图片/背景 | Source Image、Color |
| Panel | 面板容器（自带 Image 背景） | 用来装菜单、暂停界面 |
| Button | 按钮 | Image+Button 组件+子 Text；`onClick` |
| Slider | 滑块 | Min/Max Value、Value、Whole Numbers、Interactable、Fill；`onValueChanged`（带 float） |

- 血条 Slider：关 Interactable（不让拖）、Min 0 Max 100、Fill Area 左右边距归 0 才铺满。
- 音量 Slider：勾 Interactable、Min 0 Max 1、不勾 Whole Numbers（要小数）。

## 3. 事件绑定

```csharp
using UnityEngine.UI;   // Button/Slider/Text 都在这，不写会报找不到

button.onClick.AddListener(OnClick);            // 方法签名：void OnClick()
slider.onValueChanged.AddListener(OnChanged);   // 方法签名：void OnChanged(float value)
```

- 也可以在 Inspector 里 On Click() 加号拖物体选方法（不用写代码，适合原型）。
- **自造 event 没有 Unity 自动 Invoke，UI 事件一律用 AddListener。**
- onClick 只通知"被点了"；onValueChanged 会把滑块当前值 float 传给方法。

## 4. 面板显隐

- `gameObject.SetActive(true/false)`：激活/隐藏整个物体及其子物体。
- 父物体隐藏，子物体全部跟着隐藏。
- 同级 UI，Hierarchy 里越靠下渲染越在上层。
- 读取当前是否激活：`gameObject.activeSelf`。

## 5. 场景切换

```csharp
using UnityEngine.SceneManagement;
SceneManager.LoadScene("MenuScene");                              // 加载指定场景
SceneManager.LoadScene(SceneManager.GetActiveScene().name);       // 重载当前场景（重开）
```

- 必须先在 **File → Build Settings → Add Open Scenes** 注册场景，否则报 Scene not found。
- **场景是隔离的**：切场景后旧场景物体全部销毁，新场景重新 Awake→Start；不能跨场景访问旧场景的 UI。
- 复用 UI 的标准做法：做成**预制体**，两个场景各放一份，数据走 PlayerPrefs 共享。

## 6. 游戏状态机 + 暂停

```csharp
public enum GameState { Playing, Paused, Win, Lose }
public GameState state;
```

- 操作门控：玩家移动等 Update 开头 `if (state != GameState.Playing) return;`。
- 暂停：`Time.timeScale = 0`；恢复：`Time.timeScale = 1`。
- timeScale=0 时：Update 照常执行、UI 点击/拖滑块照常（UGUI 用 unscaled 时间）；基于 timeScale 的动画、协程、物理暂停。UI 动画要用 `Time.unscaledDeltaTime`。
- **timeScale 粘性**：切场景不重置，LoadScene 前和 GameManager.Awake 里设 1 保底。
- **状态机防重入**：WinGame/LoseGame 开头 `if (state != GameState.Playing) return;`，一局只结算一次。
- 暂停键：`Input.GetKeyDown(KeyCode.Escape)`。

## 7. 获取组件三途径

| 场景 | 方式 |
|---|---|
| 组件和脚本在同一物体 | `GetComponent<T>()` |
| 组件在别的物体 | `public T 字段;` Inspector 拖引用 |
| 动态生成的物体 | `Instantiate()` 返回 GameObject，再 `GetComponent<T>()` |

- GetComponent **只在脚本自己挂着的物体身上找，不翻父子**；挂在 Canvas 上不等于能找到子物体上的 Button。
- 向子物体找：`GetComponentInChildren<T>()`，但同类组件多时分不清谁是谁，少用。
- 一个物体只有一个某类型组件，挂两个脚本都 GetComponent<Text> 会指向同一文本。

## 8. 音频 / 退出

- **AudioListener**：场景的"耳朵"，Main Camera 自带，全场景一个。
- `AudioListener.volume`：全局音量 0~1，**static 属性，Inspector 不显示**，只能代码控制。
- 播一次性音效：`AudioSource.PlayClipAtPoint(clip, position);`
- 退出游戏：`Application.Quit();`（编辑器里无反应，打包后才生效，正常）。

## 9. PlayerPrefs 本地存档

```csharp
PlayerPrefs.SetFloat("Volume", 0.5f);
float v = PlayerPrefs.GetFloat("Volume", 1f);   // 第二参数：没存过时的默认值
PlayerPrefs.SetInt("HighScore", 10);
int high = PlayerPrefs.GetInt("HighScore", 0);
// 还有 SetString/GetString
```

- 键值对存在本地，关闭重启还在；Unity 退出时自动落盘。
- **键名区分大小写**："Volume" ≠ "volume"。用 `const` 或静态类集中管理键名，杜绝魔法字符串。
- 跨场景/入口要在 Awake 里读档恢复（新场景 AudioListener 可能覆盖设置）。
- 编辑器清档：**Edit → Clear All PlayerPrefs**。

## 10. 事件驱动 UI（逻辑与 UI 解耦）

```csharp
// 逻辑层：只广播，不认识 UI
public event Action<int> OnHpChanged;          // using System;
OnHpChanged?.Invoke(hp);

// UI 层：自己订阅、自己刷新
playerHealth.OnHpChanged += RefreshHp;
RefreshHp(playerHealth.Hp);                    // 订阅后主动刷一次，防 Start 顺序坑
```

- 金币（OnCoinCollected）、血条（OnHpChanged）都是这套：数据持有者广播，UI 自愿订阅。
- 加新 UI（低血警告、队友血条）只需要再订阅，逻辑层一行不改。

## 11. 高频坑清单

1. 改了 public 字段默认值，运行没变化 → 序列化：默认值只在首次挂载写入，以 Inspector 为准，Awake 强制赋值。
2. 复制 UI 会连脚本和 OnClick 绑定一起复制（"继续游戏"按钮带着重开脚本的事故）。
3. 按钮点了没反应：查 EventSystem、Interactable、是否被别的面板挡住。
4. 缺 `using UnityEngine.UI`：Button/Slider/Text 找不到。
5. 漏拖引用：NullReferenceException。
6. 场景没注册 Build Settings：LoadScene 报错。
7. 材质丢失变洋红；整理资源只在 Unity Project 窗口内移动（.meta 存 GUID，引用不断），Ctrl+拖=复制。
8. 同物体的按钮用 GetComponent，跨面板控件用拖引用。

# W4 地基期速查表（生命周期 / 协程 / Input / 场景存档）

> 用法：面试前、写代码前翻一遍。能自己口述出来才算掌握，看懂不算。

---

## 一、生命周期（脚本从出生到销毁）

### 执行顺序

| 阶段 | 函数 | 频率 | 用来干什么 |
|---|---|---|---|
| 出生 | **Awake** | 1 次 | 自己初始化（拿自己身上的组件、登记单例） |
| 出生 | **OnEnable** | 每次激活 | 订阅事件 `+=` |
| 首帧前 | **Start** | 1 次 | 找别人、引用其他对象（此时所有人 Awake 都跑完了） |
| 存活 | **FixedUpdate** | 固定步长（默认 0.02s），一帧可跑 0~N 次 | Rigidbody 物理、移动 |
| 存活 | **Update** | 每渲染帧 1 次 | 输入检测、状态逻辑、计时器 |
| 存活 | **LateUpdate** | 所有 Update 跑完后 | 相机跟随、结算后处理 |
| 死亡 | **OnDisable** | 每次失活 | 退订事件 `-=` |
| 死亡 | **OnDestroy** | 销毁时 | 最终清理 |

### 关键区别

- **Awake vs Start**：检查器里赋的字段在 Awake 前就已经就位；Awake 哪怕脚本复选框关了（物体激活）也会跑，Start 不跑。所有 Awake 都在任意 Start 之前执行——所以 Start 里引用别人一定安全。
- **FixedUpdate vs Update**：物理是固定步长，刚体移动/加力必须放 FixedUpdate（不同帧率下速度一致）；按键检测放 Update（低帧率 FixedUpdate 可能漏按）。
- **OnEnable/OnDisable 成对**：订阅放 OnEnable、退订放 OnDisable 最稳（物体失活后不会收到事件）。
- 物理事件：`OnTriggerEnter/Stay/Exit`（触发器）、`OnCollisionEnter/Stay/Exit`（碰撞器），在物理步执行。

---

## 二、协程

**大白话**：协程是"另一条时间线"，可以暂停等一会再继续，期间 Update 照跑。需要 `using System.Collections;`。

### 核心 API

| 写法 | 作用 |
|---|---|
| `IEnumerator 方法名()` | 协程方法固定返回类型 |
| `StartCoroutine(方法())` | 启动 |
| `Coroutine r = StartCoroutine(...)` | 用句柄接住，才能精确停 |
| `StopCoroutine(r)` | 停一个（必须用句柄） |
| `StopAllCoroutines()` | 停本脚本启动的全部 |
| `yield return null` | 等一帧 |
| `yield return new WaitForSeconds(n)` | 等 n 秒（游戏时间，timeScale=0 会暂停） |
| `yield return new WaitForSecondsRealtime(n)` | 等 n 秒（真实时间，暂停菜单用） |
| `yield return new WaitForFixedUpdate()` | 等下一个物理帧 |

### 标准模板

```csharp
using System.Collections;
using UnityEngine;

public class Example : MonoBehaviour
{
    Coroutine routine;
    void Start()
    {
        routine = StartCoroutine(Loop());
    }
    IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            // 每 2 秒做一件事
        }
    }
    void OnDestroy()
    {
        if (routine != null) StopCoroutine(routine);
    }
}
```

### 逐帧动画模板（Boss 前摇/缩小）

```csharp
float t = 0;
while (t < duration)
{
    t += Time.deltaTime;
    float p = t / duration;                 // 0 → 1
    transform.localScale = Vector3.Lerp(a, b, p);
    yield return null;
}
```

### 什么时候用协程 / Update

- **协程**：有明确时间线的事——倒计时、每隔 N 秒生成、前摇后摇、死亡延迟、异步加载进度
- **Update**：每帧持续判定——状态机、移动、持续检测距离
- **协程坑**：并行的另一条时间线会"醒来"，切状态前要想——它会不会覆盖我？用句柄停掉 + 醒来守卫 `if (state != X) yield break;`

---

## 三、Input（旧 Input Manager）

### 键盘鼠标

| API | 行为 |
|---|---|
| `Input.GetAxis("Horizontal")` | **返回 float**，范围 -1~1，有平滑（推一半半速） |
| `Input.GetAxis("Vertical")` | 同上（前后） |
| `Input.GetAxisRaw("Horizontal")` | 返回 float，但只有 -1/0/1，不平滑 |
| `Input.GetKeyDown(KeyCode.K)` | 按下那一帧 true（攻击） |
| `Input.GetKey(KeyCode.K)` | 按住期间一直 true |
| `Input.GetKeyUp(KeyCode.K)` | 抬起那一帧 true |
| `Input.GetMouseButton(0)` | 按住左键持续 true；0 左键、1 右键、2 中键 |
| `Input.GetMouseButtonDown(0)` | 左键按下瞬间 true |

- 移动用 GetAxis：手柄/键盘都平滑过渡，不突兀
- 单次触发用 Down（跳、攻击），持续动作用 GetKey/GetButton

### 移动接线（W4 写法）

```csharp
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");
Vector3 dir = new Vector3(h, 0, v);
rb.MovePosition(transform.position + dir.normalized * speed * Time.fixedDeltaTime);
```

---

## 四、单例 + 场景管理 + 存档

### 单例三件套（GameManager 模板）

```csharp
public static GameManager Instance;   // ① 静态登记
void Awake()
{
    if (Instance != null)             // ② 判重
    {
        Destroy(gameObject);
        return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);    // ③ 跨场景保留
}
```

- 判重原因：返回主菜单/重复加载会再生一个 GameManager，留老的、毁新的
- DontDestroyOnLoad：切场景不销毁，总管、音频、存档都靠它

### 异步加载场景

```csharp
IEnumerator LoadScene(string sceneName)
{
    AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
    op.allowSceneActivation = false;                 // 先不切场景
    while (op.progress < 0.9f)
    {
        slider.value = op.progress / 0.9f;          // 0.9 → 1，进度条铺满
        yield return null;
    }
    slider.value = 1;
    op.allowSceneActivation = true;                 // 放行，真正切换
}
```

- LoadSceneAsync 返回 **AsyncOperation**
- 进度只走到 0.9，最后 0.1 要等 allowSceneActivation=true（等激活）；除以 0.9 是把 0.9 映射成 100%
- 单场景：`SceneManager.LoadScene("场景名")` 立即切换
- 重开本关：`SceneManager.LoadScene(SceneManager.GetActiveScene().name)`

### PlayerPrefs 散键存档

```csharp
PlayerPrefs.SetInt(key, value);   PlayerPrefs.GetInt(key, 0);
PlayerPrefs.SetFloat(key, value); PlayerPrefs.GetFloat(key, 1f);
PlayerPrefs.SetString(key, value);PlayerPrefs.GetString(key, "");
PlayerPrefs.HasKey(key);          // 判空（有没有存过）
PlayerPrefs.DeleteKey(key);       // 删一项
PlayerPrefs.DeleteAll();          // 清全部
PlayerPrefs.Save();               // 强制写盘
```

- 键名放 GameConfig 常量，不写裸字符串；全部散键收进 SaveManager，业务代码不直接碰 PlayerPrefs

### JSON 整包存档

```csharp
using System;   // [Serializable]

[Serializable]                      // 许可令：允许这个类被打包
public class SaveData
{
    public int highScore;
    public int lastScore;
    public int unlockedLevel;
}

string json = JsonUtility.ToJson(data);              // 打包：箱子 → 文本
PlayerPrefs.SetString(key, json);
if (PlayerPrefs.HasKey(key))
{
    string json = PlayerPrefs.GetString(key);
    SaveData d = JsonUtility.FromJson<SaveData>(json); // 解包：文本 → 新箱子
}
```

- JsonUtility 只打包 public 字段；不支持 Dictionary、属性；嵌套类也要 [Serializable]
- 数据箱是普通类，不继承 MonoBehaviour
- 第一次玩：HasKey 为 false，返回 `new SaveData()`（全 0 默认箱）

---

## W4 高频坑清单（自测时重点对照）

1. GetAxis 返回 **float** 不是 int
2. 0.9f 必须带 f（0.9 是 double，且进度条会差一格）
3. 协程切状态：句柄 StopCoroutine + 醒来守卫
4. 死了/硬直中：先扣血、再 Invoke 事件，最后才判状态
5. 事件订阅：OnEnable/Start `+=`，OnDisable/OnDestroy `-=`
6. Slider 不设 maxValue，value 被截断
7. GetComponent 在自己身上找；找别人的组件用 public 拖引用
8. GetComponentInChildren 默认不搜隐藏物体，要传 true
9. 关卡场景必须从主菜单启动（总管在 MenuScene）
10. 物理移动放 FixedUpdate、用 Time.fixedDeltaTime
