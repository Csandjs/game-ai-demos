# W4 地基期周总结（D22–D25，10/16–10/18）

> 主题：从"能写脚本"到"能组织代码"——生命周期、协程、状态机、单例、存档。
> 节奏：D22/D23 一天双开（10/16），D24 压缩日（10/17 上午+下午），D25 跨夜（10/17 晚→10/18 凌晨），D26 复盘（10/18 上午）。

---

## 一、本周知识地图

| 天 | 主题 | 核心产出 |
|---|---|---|
| D22 | 生命周期 + 协程 | Awake/Start/Update/FixedUpdate/LateUpdate 分工；三种 yield；协程刷怪器；技能 CD UI；BossDirector 登场；事件退订自查 |
| D23 | Input + 场景管理 | GetAxis 移动重构、K/鼠标攻击；GameManager 单例 + DontDestroyOnLoad；场景报到模式；LoadSceneAsync 进度条 |
| D24 | 存档体系 | PlayerPrefs 封装 SaveManager；GameManager 收尾；标准弹窗结构；JSON 整包存取（SaveData）；删档 |
| D25 | Boss 战 | Boss 五态 FSM；攻击前摇/判定/后摇协程；受击硬直、打断、死亡；BossHpUI 事件驱动血条；Unity Recorder 录屏 |

---

## 二、核心知识体系（四句话）

1. **生命周期**：初始化放 Awake（自己的事）、跨对象引用放 Start（别人都醒了）、物理放 FixedUpdate、输入和状态放 Update、相机放 LateUpdate、退订放 OnDestroy
2. **协程**：一条能暂停的时间线，管倒计时/按秒流程/逐帧动画；Update 管每帧持续判定；句柄必须接住才能精确停
3. **状态机**：互斥状态用 enum，同一时刻只做一件事；状态切换时要想"并行的协程会不会醒来覆盖我"
4. **数据**：跨场景的总管靠单例+DontDestroyOnLoad；设置类存档走 PlayerPrefs 散键，进度类走 JSON 整包；唯一数据源

---

## 三、本周踩坑全清单（按类型，面试素材）

### 生命周期/时序类
- 生命周期：Awake 取自身组件、Start 找别人；相机不放 LateUpdate 会差一帧抖动
- GetKeyDown 写 FixedUpdate 会漏按（物理帧没采样到）
- 0.9 vs 0.9f：double/float 精度差导致进度条 while 死循环
- 关卡场景必须从 MenuScene 启动（GameManager 在主菜单），否则 NullRef 洪水

### 协程类
- 协程跟 GameObject 不跟 enabled：只取消脚本勾选协程继续跑，物体失活才停
- 死亡分支漏 return → 被 HurtRoutine 复活；漏的活统一移交 DieRoutine
- Hurt 守卫写在扣血前 → 硬直无敌；顺序必须是先扣血+Invoke，再判状态
- 协程醒来不守卫 → 覆盖 Dead 状态（`if (state != X) yield break`）
- StopCoroutine 前必须判空，停完句柄置空、bool 复位
- 防重复启动的门禁要装在 StartCoroutine 之前，写在协程内部会被新句柄覆盖

### 数据/存档类
- PlayerPrefs 键名大小写敏感（"Volume"≠"volume"）
- SetInt 第二参数才是新值，误存 Load 旧值会导致永远写不进
- static 成员默认 private；static class 方法要显式 public
- JSON：[Serializable] 许可令、只打包 public 字段、不支持 Dictionary/属性；HasKey 判空
- 字符串当开关参数拼错静默失败，开关拆方法或用枚举
- 事件 `+=` 必须 `-=` 退订；UnityEvent（onClick/AddListener）不用退订

### UI 类
- Slider MaxValue 默认 1，不设会截断 value
- GetComponent 在自己身上找；GetComponentInChildren 默认不搜隐藏物体要传 true
- 结算面板标准结构：Image 半透明遮罩根物体 → 文字+按钮平级
- 大字号固定尺寸 Text 会溢出，弹窗要先建层级

### 工程/录屏类
- 改代码默认值对已挂组件不生效（序列化值以检查器为准）
- 录屏 Game View 太小 + 缩放会半灰翻转，用 Play Maximized
- 编译慢：Auto Refresh 改 Disabled（Ctrl+R 手动）+ Defender 排除项目目录

---

## 四、D26 闭卷自测结果（诚实记录）

| 题 | 内容 | 结果 |
|---|---|---|
| 题1 | 生命周期分析题（GetKeyDown 放 FixedUpdate 的现象、相机为何 LateUpdate） | ✅ 闭卷通过 90/100（"抖动"说成"卡顿"，用词修正） |
| 题2 | 协程刷怪器（每 2 秒 1 个共 5 个、X 停止、防重复） | ⚠️ 闭卷 78→改后通过；初版缺判空、门禁写在协程内部、bool 没置 true |
| 题3 | 单例 + PlayerPrefs 最高分 | 📖 未闭卷，看参考完成；口述环节再抽查 |

速查表四模块（生命周期/协程/Input/场景存档）闭卷回忆：约 80% 脱稿，缺口是 GetAxis 返回 float、IEnumerator/JsonUtility 拼写、WaitForFixedUpdate、[Serializable] 许可令。

**结论**：理解已到位，"识别"强于"回忆"；拼写和 API 名字要靠再用两三次形成肌肉记忆，不是理解问题。

---

## 五、待办池（打磨期统一处理）

1. 闪避（dodge：冲刺动画+无敌帧+冷却）——压缩日明确砍掉
2. 环形 CD UI、手感打磨（playerAttackRange 现 3，可试 4~5）
3. BossHpUI 从 Scripts/Enemy 挪到 Scripts/UI；BossHpSlider 删 Handle Slide Area
4. Boss 专用厚重受击音效（现复用打怪音效）
5. CanvasGroup 淡入淡出、LoadingPanel 半透明黑底
6. public 访问级别重构
7. LeetCode 积压：232/203/141/104/226/242
8. BossDirector 等待 5s 录屏临时改 1s 记得改回
9. 完整作品集版录屏（现成片 Movie_007 约 44 秒）

---

## 六、面试高频问题（W4 范围）

1. Awake 和 Start 的区别？为什么相机放 LateUpdate？
2. 协程和 Update 怎么选？协程是多线程吗？
3. 单例怎么写？为什么判重？DontDestroyOnLoad 的作用？
4. 状态机怎么设计？Boss 攻击为什么要前摇后摇？
5. 协程和状态切换冲突怎么处理？（结合 Boss 三个竞态 bug 讲）
6. UI 怎么和游戏数据同步？（事件订阅/退订）
7. PlayerPrefs 和 JSON 存档怎么分工？

---

## 七、下周进入 Demo1（D36 起）

W4 地基工具已备齐：生命周期、协程、FSM、单例、存档、事件、录屏。Demo1 阶段目标：把这些零件组织成一个完整可玩 Demo，11/8 完成录屏+简历初稿。
