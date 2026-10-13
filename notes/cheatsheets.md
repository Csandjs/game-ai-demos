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