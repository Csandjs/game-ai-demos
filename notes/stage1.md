# 地基期阶段总结（W1-W4，D1-D27）

> 2026-09-03 ~ 2026-10-18，共 27 天（含跨夜和顺延），从 0 基础 C# + Unity 到完整可玩 3D 动作小游戏。

---

## 一、阶段概述

4 周时间，从零开始走完了"C# 语言 → 面向对象 → Unity 引擎基础 → 生命周期/协程 → UI/存档 → 有限状态机 → 完整作品整合"的完整路径。最终产出 **MiniLevel**：一个有主菜单、设置、暂停、胜负结算、本地存档、BGM、Boss 战的 3D 动作小游戏。

**进度**：27 / 196 天（春招倒计时），地基期收官，下一步进 Demo1（游戏 AI 专项）。

---

## 二、知识地图

### W1：C# 基础 + Unity 入门（D1-D7）

- 变量/类型/运算符、条件/循环、数组/方法
- Unity 环境搭建、GameObject/Component/Transform
- Rigidbody 刚体物理移动、Collider 碰撞、跳跃与落地检测

### W2：面向对象 + 物理 + 可玩小关（D8-D14）

- 类与对象、继承、多态、抽象类、接口 interface
- 封装（private 字段 + public 方法）、static、enum、namespace
- 单例模式（控制台版 + Unity GameManager 版）
- 射线地面检测 Raycast、平滑移动 MoveTowards、触发器 OnTrigger
- 第一个可玩小关（W2 里程碑）

### W3：委托事件 + 集合 + 动画 + UI + 整合（D15-D20）

- 委托 delegate、事件 event、Action/Func、Lambda
- List\<T\> 动态数组、Dictionary\<K,V\> 字典
- Animator 状态机（Idle/Move/Jump 三态 + Bool 参数）
- UGUI（Canvas/Button/Slider/Panel）、场景切换 SceneManager、暂停 timeScale
- PlayerPrefs 本地存档、事件驱动 UI（金币/血量）
- W3 整合：完整流程闭环（主菜单→关卡→胜负→重开）

### W4：生命周期 + 协程 + Input + 场景存档 + 收官（D21-D27）

- 生命周期 8 方法（Awake/Start/Update/FixedUpdate/LateUpdate/OnEnable/OnDisable/OnDestroy）
- 协程 Coroutine（IEnumerator + yield return + 三种等待 + 句柄停止）
- Input 系统（旧版 GetKey/GetAxis + 新版 Input System）
- 场景管理（DontDestroyOnLoad 持久单例、异步加载 LoadSceneAsync + 进度条）
- 存档系统（PlayerPrefs 封装 + JSON 整包存取 + SaveManager）
- Boss 五态 FSM（巡逻/追击/攻击前摇后摇/受击/死亡）+ 攻击协程 + 事件血条
- D27 收官整合：攻击动画、空气墙、出生点保护、双 AudioSource BGM、Toggle 开关、完整录屏

---

## 三、成果清单

### 作品：MiniLevel（地基期收官版）

| 模块 | 实现 |
|---|---|
| 主菜单 | 开始/设置/退出，最高分+最近得分显示 |
| 设置 | 音量滑块 + 音乐开关（Toggle），PlayerPrefs 存档 |
| 玩家 | WASD 移动（刚体+平滑插值）、空格跳跃（射线地面检测）、K/左键攻击（Animator Trigger 前扑动画） |
| 小怪 AI | 三态 FSM（巡逻/追击/攻击），距离触发切换 |
| Boss AI | 五态 FSM（巡逻/追击/攻击前摇后摇/受击/死亡），攻击协程三段式，事件驱动血条 |
| 音频 | 双 AudioSource（音效 PlayOneShot 6 种 + BGM loop 独立开关） |
| 存档 | PlayerPrefs 散键（音量/音乐/最高分/最近分）+ JSON 整包（SaveData） |
| 边界 | 四面空气墙 + Boss 出生点保护（向量归一化推出） |
| 结算 | 胜利/失败面板，三行分数，重开/返回主菜单 |
| 录屏 | Unity Recorder FHD 1080p 完整流程 |

### 技术栈

- **语言**：C#（OOP 四件套、委托事件、Lambda、协程、泛型集合）
- **引擎**：团结引擎 Tuanjie 1.10.2（2022.3.62t14）
- **物理**：Rigidbody、Collider/Trigger、Raycast
- **UI**：UGUI（Button/Slider/Toggle/Panel/Text）
- **动画**：Animator 状态机（Bool/Trigger、AnyState、Transition Duration）
- **音频**：AudioSource（PlayOneShot/loop/mute）、AudioListener
- **存档**：PlayerPrefs、JsonUtility
- **版本控制**：Git / GitHub（27 天连续 commit）

---

## 四、踩坑汇总（高频面试点）

| 坑 | 根因 | 解法 |
|---|---|---|
| 改代码默认值不生效 | 序列化：public 字段首次挂载写入，之后以 Inspector 为准 | Awake 强制赋值 / 改完检查器手动改 |
| 空引用中断核心玩法 | 附属系统（音效）未初始化 | `?.` 判空调用，附属不阻断核心 |
| 协程竞态覆盖状态 | 协程是另一条时间线，醒来无脑改 state | 醒来守卫 `if (state != 我的状态) yield break` |
| GetKeyDown 放 FixedUpdate 漏按 | 按键事件只一帧有效，Fixed 固定步长可能错过 | 输入放 Update，物理放 FixedUpdate |
| 两行 GetComponent 拿到同一组件 | GetComponent 是找已有，不是新建 | 新建用 AddComponent |
| 事件退订泄漏 | 订阅了不在 OnDestroy 退订 | 订阅三件套：Start +=、OnDestroy -= |
| PlayerPrefs 键名大小写 | "Volume" ≠ "volume" | 键名收进 GameConfig const |
| timeScale 粘性 | 切场景不重置 | LoadScene 前拨 1 + Awake 保底 |
| 复制 UI 连绑定一起复制 | 复制物体连 OnClick 引用一起复制 | 复制后检查事件绑定 |
| Slider 血条一直满 | maxValue 默认 1，value 被截断 | 代码里设 maxValue = 最大血量 |

---

## 五、面试能力自评

### 能讲清（80%+）

- 生命周期执行顺序和各方法分工
- 协程原理（yield return 交还控制权 + Unity 每帧轮询，不是多线程）
- 单例模式三件套和跨场景持久化
- 委托/事件/Action/Func 的区别和事件驱动解耦
- List vs Dictionary 的使用场景
- Animator 状态机参数类型（Bool/Trigger/Float）和过渡配置
- PlayerPrefs 存取和 JSON 序列化
- 有限状态机的设计思路（枚举互斥 vs 一堆 bool）

### 还需加强

- 协程句柄管理（StopCoroutine 精准停止 vs StopAllCoroutines）
- 泛型约束、接口多态的深入应用
- 设计模式（工厂、观察者、状态模式的正式写法）
- 数据结构与算法（LeetCode 手感）
- 性能优化（对象池、GC 分配、Draw Call）

---

## 六、下一阶段规划

### Demo1 阶段（游戏 AI 专项）

- **状态机深化**：小怪 FSM 完善（巡逻点/侦测范围/丢失目标回巡逻）
- **行为树 Behavior Tree**：从 FSM 过渡到行为树，理解组合节点/装饰节点/条件节点
- **寻路**：NavMesh 导航网格 + A* 算法理解
- **感知系统**：视野/听觉检测，替代简单距离判断
- **群体行为**：多敌人协调（包围、轮流攻击）

### 打磨期（穿插）

- public 字段重构为 [SerializeField] private
- 代码规范统一（命名、注释、区域折叠）
- Unity 打包 Windows exe
- 作品集截图 + 视频整理
- 简历项目描述更新

### LeetCode 计划

- 每周 2-3 道，从数组/哈希/双指针入门
- 已完成：21 合并有序链表
- 待完成：283 移动零、121 买卖股票、232 栈实现队列、203 移除链表元素、141 环形链表、104 二叉树最大深度、226 翻转二叉树、242 有效字母异位词

---

## 七、关键数字

- 学习天数：27 天（D1-D27）
- 代码提交：GitHub main 分支连续 commit
- 项目脚本：30+ 个 C# 脚本
- 游戏场景：2 个（MenuScene + MiniLevel）
- 动画状态：4 个（Idle/Move/Jump/Attack）
- Boss 状态：5 个（Patrol/Chase/Attack/Hurt/Dead）
- 音效：6 种 + BGM 1 首
- LeetCode：1 道（目标春招前 50+）
