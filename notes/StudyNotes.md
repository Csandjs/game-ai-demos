# 游戏开发学习笔记

> 从零开始学习 Unity + C# 游戏开发，按天按步骤记录

---

# 📅 D1（第一天）：环境搭建 + C# 入门 + GitHub

## ☀️ 上午：环境搭建（3小时）

### 步骤1：安装团结引擎（Unity中国版）

1. 浏览器访问团结引擎官网
2. 下载「旧版本团结 Hub(Windows)」
   - ⚠️ 注意：新版 Tuanjie Cowork 是 AI 编程工具，需要许可证，不是传统 Unity Hub，不要下错
3. 安装团结 Hub
4. 打开 Hub，点「以后登录」可以先进入（也可以注册账号登录）
5. 在 Hub 里安装团结编辑器 1.10.2（约4.83GB，安装路径默认即可）
6. 安装完成后桌面会有 Tuanjie 快捷方式

**许可证说明：**
- 个人版完全免费
- 在 Hub → 设置（齿轮图标）→ 许可证 → 添加 → 获取免费个人版许可证
- 勾选同意协议，自动激活

---

### 步骤2：安装 VS Code

1. 浏览器访问 VS Code 官网，下载 Windows 版
2. 双击安装包，一路下一步
3. 安装路径保持默认即可
4. 可以勾选"创建桌面快捷方式"
5. 安装完成后打开 VS Code

---

### 步骤3：VS Code 装中文语言包

1. 打开 VS Code
2. 点左侧扩展图标（四个方块那个）
3. 搜索框输入 `Chinese`
4. 找到微软官方的「中文（简体）语言包」，点安装
5. 安装后重启 VS Code，界面就变成中文了

---

### 步骤4：VS Code 装 C# 扩展

1. 左侧扩展商店搜索 `C#`
2. 找到微软官方的 C# 扩展，点安装
3. 安装完成即可

---

### 步骤5：安装 .NET SDK

1. 浏览器访问 `https://dotnet.microsoft.com/zh-cn/download`
2. 下载 .NET SDK（不是 Runtime），选长期支持版
3. 双击安装包，一路下一步，安装路径默认
4. 安装完成后，**关闭所有 cmd 窗口，重新打开一个新的**
5. 输入 `dotnet --version` 验证，如果显示版本号就成功了

**如果提示"不是内部或外部命令"：**
1. 确认 `C:\Program Files\dotnet\dotnet.exe` 文件存在
2. 右键「此电脑」→ 属性 → 高级系统设置 → 环境变量
3. 在「系统变量」里找到 `Path`，点编辑
4. 点新建，添加 `C:\Program Files\dotnet`
5. 一路确定保存
6. 关闭所有 cmd，重新打开，再输入 `dotnet --version`

---

## 🌤️ 下午：GitHub + Git（3小时）

### 步骤6：注册 GitHub 账号并创建仓库

1. 浏览器访问 `https://github.com`，注册账号（用邮箱注册）
2. 登录后，点右上角 `+` → `New repository`
3. 仓库名输入：`game-ai-demos`
4. 选 Public（公开）
5. 勾选「Add a README file」
6. 描述可以写：游戏AI学习练习代码
7. 点「Create repository」创建完成

---

### 步骤7：安装 Git

1. 浏览器访问 Git 官网，下载 Windows 版
2. 双击安装包，一路下一步，所有选项保持默认
3. 安装完成后，打开 cmd，输入 `git --version` 验证

---

### 步骤8：配置 Git 身份（整台电脑只配一次）

打开 cmd，输入：
```bash
git config --global user.name "你的GitHub用户名"
git config --global user.email "你的注册邮箱"
```

> 配置一次永久生效，以后所有仓库都不用再配。

---

### 步骤9：克隆仓库到本地

1. 打开你的 GitHub 仓库页面，点绿色「Code」按钮，复制 HTTPS 地址
2. 打开 cmd，切换到你想存放的目录：
```bash
D:
cd D:\projects\xuexi\code
```
3. 克隆仓库：
```bash
git clone https://github.com/你的用户名/game-ai-demos.git
```
4. 克隆完成后，本地会多出 `game-ai-demos` 文件夹，这就是你的本地仓库

> 一个仓库只克隆一次，以后所有项目都放在这个文件夹里。

---

## 🌙 晚上：第一个 C# 程序（1.5小时）

### 步骤10：新建 C# 控制台项目

1. 打开 cmd，进入仓库根目录：
```bash
cd D:\projects\xuexi\code\game-ai-demos
```
也可以进入这个文件夹

清空上方地址栏 
输入cmd回车
dotnet new console   - n 文件夹名#创建一个新的文件项目
cd 文件夹名#进入文件夹 
code   .#用VScode打开文件夹
Ctrl+s#保存
dotnet run输出
2. 创建新项目：
```bash
dotnet new console -n HelloWord
```
3. 进入项目文件夹：
```bash
cd HelloWord
```
4. 运行看看默认效果：
```bash
dotnet run
```
会输出 `Hello, World!`

> 新建项目会自动生成一行默认代码 `Console.WriteLine("Hello, World!");`，这是模板自带的，可以全部删掉重写。

---

### 步骤11：用 VS Code 打开项目写代码

1. 打开 VS Code
2. 文件 → 打开文件夹 → 选择 `D:\projects\xuexi\code\game-ai-demos\HelloWord`
3. 如果弹出「是否信任此文件夹」，点「是，我信任此作者」
4. 左侧点开 `Program.cs`，这就是你写代码的文件
5. 练习变量声明，把代码改成：
```csharp
string name = "小明";
int age = 20;
double height = 1.75;

Console.WriteLine("大家好我叫" + name);
Console.WriteLine("我今年" + age + "岁");
Console.WriteLine("我的身高是" + height + "米");
Console.ReadKey();
```
6. 按 `Ctrl + S` 保存
7. 在 cmd 里输入 `dotnet run` 运行，看输出结果

**项目文件说明：**
- `Program.cs` = 你写代码的地方（唯一需要编辑的）
- `HelloWord.csproj` = 项目配置（自动生成，不用管）
- `.vscode/` = VS Code 配置（自动生成）
- `bin/` = 编译后的程序（运行后才生成，不用管）
- `obj/` = 编译临时文件（不用管）

---

### 步骤12：把代码推送到 GitHub

1. **退回仓库根目录**（重要！不能在 HelloWord 文件夹里执行 git）：
```bash
cd ..
```
2. 查看状态：
```bash
git status
```
3. 添加文件：
```bash
git add .
```
4. 提交：
```bash
git commit -m "添加第一个C#控制台程序"
```
5. 推送：
```bash
git push
```
6. 第一次 push 会弹出 GitHub 登录窗口，用浏览器授权登录即可
7. 推送成功后，刷新 GitHub 网页就能看到代码了

**Git 三步曲记住：**
- `git add .` = 选中文件
- `git commit -m "备注"` = 本地存档
- `git push` = 上传到云端

**铁律：git 命令必须在仓库根目录（game-ai-demos）执行，不能进到子项目文件夹里！**

---

# 📅 D2（第二天）：Unity 入门 + 第一个可移动物体

## ☀️ 上午：Unity 界面认识（3小时）

### 步骤1：打开 Unity 新建 3D 项目

1. 双击桌面的「Tuanjie Hub」打开
2. 点左侧「项目」→ 右上角「新建项目」
3. 模板选「3D」
4. 项目名：`FirstScene`
5. 位置选：`D:\projects\xuexi\code\game-ai-demos\`（放在仓库里方便推送）
6. 点「创建」，等待加载（第一次可能1-2分钟）

---

### 步骤2：认识六大界面区域

| 区域 | 位置 | 作用 |
|------|------|------|
| 层级面板（Hierarchy） | 左上角 | 列出场景里所有游戏物体 |
| 检查器（Inspector） | 右边 | 显示选中物体的属性和组件 |
| 场景视图（Scene） | 中间 | 编辑用的3D工作台 |
| 游戏视图（Game） | 中间 | 玩家实际看到的画面 |
| 项目面板（Project） | 左下角 | 资源仓库，管理所有文件 |
| 控制台（Console） | 左下角 | 报错和打印输出 |

**场景视图操作：**
- 按住鼠标右键拖动 = 旋转视角
- 滚轮滚动 = 放大缩小
- 按住鼠标中键拖动 = 平移视角

---

### 步骤3：理解核心概念

**GameObject（游戏物体）：**
- 场景里的每一个东西都是 GameObject（相机、灯光、玩家、地面）
- 本身是空容器，功能由挂在身上的组件决定

**Component（组件）：**
- 每个组件负责一个功能
- 每个物体必有 `Transform` 组件
- 相机有 `Camera` 组件，灯光有 `Light` 组件
- 检查器底部点「添加组件」可以加更多功能

**Transform（变换组件）：**
- 控制物体的位置（Position）、旋转（Rotation）、缩放（Scale）
- 选中物体后场景里出现彩色箭头：
  - 🔴 红色 = X轴（左右）
  - 🟢 绿色 = Y轴（上下）
  - 🔵 蓝色 = Z轴（前后）
- 拖动箭头就能移动物体

---

### 步骤4：创建/删除/重命名物体练习

1. 层级面板空白处右键 → 3D 对象 → 立方体（Cube）
2. 双击 Cube 重命名为 `Player`
3. 在检查器里把位置 Y 改成 `1`
4. 用鼠标拖动彩色箭头移动方块
5. 想删除物体：选中后按键盘 Delete 键（这个练习不用删，留着下午用）

---

## 🌤️ 下午：搭第一个小场景 + 移动脚本（3小时）

### 步骤5：创建地面（Plane）

1. 层级面板空白处右键 → 3D 对象 → 平面（Plane）
2. 检查器里位置 Y 保持 `0`
3. 平面默认很大，足够用

---

### 步骤6：调整相机视角

1. 层级面板选中 `Main Camera`
2. 检查器 Transform 设置：
   - 位置：X=`0`，Y=`6`，Z=`-8`
   - 旋转：X=`30`，Y=`0`，Z=`0`
3. 切到「游戏」标签，看看画面是不是俯视角度，能看到地面和方块

---

### 步骤7：创建 C# 移动脚本

1. 项目面板空白处右键 → 创建 → C# 脚本
2. 命名：`PlayerMove`（P和M大写）
3. 双击脚本，用 VS Code 打开
4. 把默认代码全部删掉，粘贴下面这段：

```csharp
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir * moveSpeed * Time.deltaTime, Space.World);
    }
}
```

5. 按 `Ctrl + S` 保存

**代码解释：**
- `moveSpeed` = 移动速度变量，可以在检查器里调整
- `Update()` = 每帧自动执行（一秒约60次）
- `Input.GetAxis("Horizontal")` = 检测 A/D 键
- `Input.GetAxis("Vertical")` = 检测 W/S 键
- `transform.Translate()` = 让物体移动
- `Time.deltaTime` = 让速度不受电脑帧率影响

---

### 步骤8：把脚本挂到 Player 上

1. 回到 Unity 编辑器
2. 从项目面板里按住 `PlayerMove` 脚本，拖到层级面板的 `Player` 物体上，松开
3. 选中 Player，看检查器最下面，应该多出 `Player Move (脚本)` 组件
4. 如果不小心拖了两次出现两个组件，点组件右上角三个点 → 移除组件，删掉多余的

---

### 步骤9：运行测试

1. 切到「游戏」视图
2. 点顶部中间的 ▶️ 播放按钮
3. 按键盘 **W/A/S/D**：
   - W = 往前
   - S = 往后
   - A = 往左
   - D = 往右
4. 看看方块是不是跟着移动了
5. 再点一次 ▶️ 停止运行

---

### 步骤10：调整移动速度

1. 停止运行状态下（必须停止，不然改的不保存）
2. 选中 Player，检查器里找到 `Move Speed`
3. 把数值从 3 改成 8，运行试试更快
4. 测试完改回 3 或你觉得舒服的速度

---

### 步骤11：配置 .gitignore 并推送 Unity 项目

**创建 .gitignore 文件：**
1. 用 VS Code 打开仓库文件夹 `game-ai-demos`
2. 左侧空白处右键 → 新建文件
3. 文件名输入 `.gitignore`（前面有个点，没有后缀）
4. 粘贴下面内容：
```
[Ll]ibrary/
[Tt]emp/
[Oo]bj/
[Bb]uild/
[Bb]uilds/
[Ll]ogs/
[Uu]ser[Ss]ettings/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db
[Dd]ebug/
[Rr]elease/
bin/
*.csproj.user
```
5. Ctrl+S 保存

**推送：**
1. 打开 cmd，进入仓库根目录：
```bash
cd D:\projects\xuexi\code\game-ai-demos
```
2. 查看状态（确认 Library/Temp 被忽略了）：
```bash
git status
```
3. 添加、提交、推送：
```bash
git add .
git commit -m "添加第一个Unity场景和WASD移动脚本"
git push
```

---

## 🌙 晚上：复习 + 笔记（1.5小时）

### 步骤12：整理学习笔记

1. 在仓库根目录新建 `notes` 文件夹
2. 把学习笔记放到 `notes` 文件夹里
3. 提交推送：
```bash
git add notes/
git commit -m "添加学习笔记"
git push
```

---

# 📌 常用命令速查表

## C# / .NET
```bash
dotnet new console -n 项目名   # 新建控制台项目
dotnet run                      # 运行程序
dotnet build                    # 编译
dotnet --version                # 查看版本
```

## Git
```bash
git clone 仓库地址              # 克隆仓库
git status                      # 查看状态
git add .                       # 添加全部
git add 文件夹名/               # 添加指定文件夹
git commit -m "备注"            # 提交
git push                        # 推送
git config --global user.name "名字"   # 配置用户名（一次）
git config --global user.email "邮箱"  # 配置邮箱（一次）
```

---

# ⚠️ 常见问题

1. **`dotnet` 不是内部或外部命令**
   → 没装 .NET SDK 或环境变量没配，参考 D1 步骤5

2. **`fatal: not a git repository`**
   → 在子文件夹里执行 git 了，退回到仓库根目录再执行

3. **双击 .exe 一闪而过**
   → 程序太短执行完就退出，用 `dotnet run` 运行，或代码末尾加 `Console.ReadKey()`

4. **.dll 用 Word 打开是乱码**
   → .dll 是电脑用的二进制文件，不是给人看的，不要打开

5. **GitHub 首页文件夹右侧提交消息变了**
   → 那是显示该文件夹最后一次改动的提交，不是修改历史，点「提交」按钮看完整历史

6. **Unity 运行时改参数不保存**
   → 必须在停止状态下改参数才会保存

7. **脚本挂了两次**
   → 检查器里点组件右上角三个点 → 移除组件，删掉多余的

---

第三日学习笔记
# Unity 核心概念

## 1. GameObject（游戏对象）
- 游戏里的一切「东西」都是 GameObject：玩家、敌人、子弹、地图、摄像机、灯光、UI
- 本身是空壳，什么都干不了，所有功能都靠挂组件
- 代码里用 `gameObject` 表示当前脚本所在的物体

## 2. Component（组件）
- 挂在 GameObject 上的「功能模块」，给物体赋予能力
- 一个物体可以挂多个组件，组合出各种功能
- 常见组件：
  - Mesh Renderer：让物体可见
  - Rigidbody：受重力、能被碰撞
  - Collider：能碰到东西、能被打中
  - Animator：播放动画
  - 自定义脚本（比如 PlayerMove.cs）：自己写的逻辑
- 在 Inspector 里点 Add Component 添加

## 3. Transform（变换组件）
- 每个 GameObject 天生自带，删不掉
- 管三件事：
  - Position（位置）：物体在哪
  - Rotation（旋转）：物体面朝哪
  - Scale（缩放）：物体多大
- 代码里用 `transform` 直接访问
- 移动物体：`transform.Translate(方向 * 速度 * Time.deltaTime)`

## 三者关系
GameObject 是容器（演员），Component 是功能（道具和技能），Transform 是最基础的组件（管位置、旋转、缩放）。


# 📅 D4（第四天）：C# 变量/类型/运算符 + Unity Transform 实操

## ☀️ 上午：C# 基础①（3小时）

### 步骤1：变量的声明、赋值与命名规则

**什么是变量：** 程序里的"小盒子"，用来存数据，每个盒子有名字和类型。

**声明语法：**
```csharp
// 类型 变量名;
int score;          // 声明整数变量
string playerName;  // 声明字符串变量
```

**赋值：**
```csharp
int score;       // 声明
score = 100;     // 赋值
int score = 100; // 声明+赋值合并（最常用）
score = 85;      // 重新赋值，覆盖旧值
```

**命名规则：**
- 只能用字母、数字、下划线
- 不能以数字开头
- 不能用C#关键字（int、class、void等）
- 区分大小写（Score和score是两个变量）

**命名习惯：** 局部变量用小驼峰（camelCase），第一个单词小写，后面首字母大写
- ✅ 正确：`playerName`、`moveSpeed`、`isGameOver`
- ❌ 不推荐：`playername`、`PlayerName`、`player_name`

---

### 步骤2：6种基本数据类型

| 类型 | 存什么 | 例子 | 后缀 | 用途 |
|------|--------|------|------|------|
| int | 整数 | `int a = 5;` | 无 | 分数、等级、人数 |
| float | 小数 | `float b = 3.14f;` | 必须加f | Unity里的位置、速度 |
| double | 高精度小数 | `double c = 3.14159;` | 无 | 科学计算、金融 |
| bool | 真/假 | `bool d = true;` | 无 | 开关、判断条件 |
| string | 一串文字 | `string e = "你好";` | 双引号 | 名字、对话文本 |
| char | 单个字符 | `char f = 'A';` | 单引号 | 性别、等级评定 |

**注意：**
- float 数字后面必须加 `f`，否则报错
- string 用双引号，char 用单引号且只能一个字符
- 整数除法会砍掉小数：`5 / 2 = 2`（不是2.5）
- 想要小数结果，至少一个数是小数：`5.0 / 2 = 2.5`

**类型转换：**
- 小类型→大类型自动转：`int → float → double`
- 大类型→小类型需强制转换：`int d = (int)3.14f;`（结果是3，小数被砍）

---

### 步骤3：运算符

**算术运算符：**
| 符号 | 作用 | 例子 | 结果 |
|------|------|------|------|
| + | 加 | `5 + 3` | 8 |
| - | 减 | `5 - 3` | 2 |
| * | 乘 | `5 * 3` | 15 |
| / | 除 | `5 / 2` | 2（整数砍小数） |
| % | 取余 | `5 % 2` | 1 |

**比较运算符（结果是bool）：**
| 符号 | 作用 | 例子 | 结果 |
|------|------|------|------|
| == | 等于 | `5 == 5` | true |
| != | 不等于 | `5 != 3` | true |
| > | 大于 | `5 > 3` | true |
| < | 小于 | `5 < 3` | false |
| >= | 大于等于 | `5 >= 5` | true |
| <= | 小于等于 | `5 <= 3` | false |

**⚠️ 超级重要：`=` vs `==`**
- `=` 是赋值：`x = 5;`（把5放进x）
- `==` 是比较：`x == 5`（判断x是不是5，结果true/false）

**逻辑运算符：**
| 符号 | 作用 | 口诀 | 例子 | 结果 |
|------|------|------|------|------|
| && | 与（并且） | 全真才真，一假就假 | `true && false` | false |
| \|\| | 或（或者） | 一真就真，全假才假 | `true \|\| false` | true |
| ! | 非（取反） | true变false，false变true | `!true` | false |

---

### 步骤4：综合练习 - 输入两数计算和差积商余

**控制台输入：**
```csharp
Console.Write("请输入第一个数：");
string input = Console.ReadLine();  // 读取用户输入的一行文字
int num = int.Parse(input);         // 把文字转成整数
```

**完整代码：**
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入第一个数：");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("请输入第二个数：");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("和：" + (num1 + num2));
        Console.WriteLine("差：" + (num1 - num2));
        Console.WriteLine("积：" + (num1 * num2));
        Console.WriteLine("商：" + (num1 / num2));
        Console.WriteLine("余：" + (num1 % num2));
        
        Console.ReadKey();
    }
}
```

**⚠️ 常见坑：**
- `Console.WriteLine("和：" + num1 + num2)` 不加括号会变成字符串拼接
- 正确写法：`Console.WriteLine("和：" + (num1 + num2))`

---

## 🌤️ 下午：Unity Transform 实操（3小时）

### 步骤1：打开项目，复习场景搭建

1. 打开 Unity Hub，点击项目打开
2. 右键 Hierarchy → 3D Object → Cube 创建立方体
3. 选中Cube，Inspector面板最上方是 Transform 组件
4. Transform 三个属性：Position（位置）、Rotation（旋转）、Scale（缩放）
5. 快捷键：W=移动工具，E=旋转工具，R=缩放工具

---

### 步骤2：代码设置物体位置 + 每帧匀速移动

**Unity脚本基本结构：**
```csharp
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 2f;  // public变量会显示在Inspector面板

    void Start()
    {
        // 游戏开始时执行一次
        transform.position = new Vector3(3, 1, 0);
    }

    void Update()
    {
        // 每帧执行
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
```

**关键概念：**
- `MonoBehaviour`：Unity脚本基类，必须继承
- `Start()`：游戏开始第一帧执行一次，用于初始化
- `Update()`：每帧执行（约每秒60次），用于持续逻辑
- `transform`：代表物体的Transform组件
- `transform.position`：物体的位置（Vector3类型）
- `transform.Translate(方向)`：让物体相对当前位置移动
- `Vector3.forward`：正前方（Z轴正方向）
- `Time.deltaTime`：上一帧到这一帧的时间（秒），乘了之后速度不受帧率影响

**⚠️ 为什么乘Time.deltaTime：**
- 不乘：每帧移动固定距离，帧率高跑得快，帧率低跑得慢
- 乘了：速度×时间=距离，表示"每秒移动多少米"，所有设备速度一致

---

### 步骤3：物体绕Y轴旋转

```csharp
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float rotateSpeed = 50f;

    void Update()
    {
        // 绕Y轴旋转，每秒转50度
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
    }
}
```

**三个轴的效果：**
- `new Vector3(50, 0, 0)`：绕X轴转（翻跟头）
- `new Vector3(0, 50, 0)`：绕Y轴转（转圈，最常用）
- `new Vector3(0, 0, 50)`：绕Z轴转（钟表指针）

---

### 步骤4：WASD键盘控制位移

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
```

**关键概念：**
- `if (条件) { 代码 }`：条件成立时执行
- `Input.GetKey(KeyCode.W)`：检测W键是否被按住，返回bool
- 常用键：KeyCode.W/A/S/D

**⚠️ 运行不移动的常见原因：**
1. 脚本没挂到物体上
2. 运行后没点击Game视图获取焦点
3. Move Speed在Inspector里被改成0了
4. 其他脚本冲突（比如MoveCube速度设太快）

---

## 🌙 晚上：2个小练习（1.5小时）

### 步骤1：判断一个数是奇数还是偶数

**原理：** 除以2，余数0是偶数，余数1是奇数

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入一个整数：");
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " 是偶数");
        }
        else
        {
            Console.WriteLine(num + " 是奇数");
        }
        
        Console.ReadKey();
    }
}
```

**if...else 结构：**
```csharp
if (条件)
{
    // 条件成立执行
}
else
{
    // 条件不成立执行
}
```

---

### 步骤2：摄氏温度转华氏温度

**公式：** F = C × 9/5 + 32

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("请输入摄氏温度：");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 9.0 / 5 + 32;
        Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");
        Console.ReadKey();
    }
}
```

**⚠️ 注意：** `9.0 / 5` 必须有一个是小数，否则 `9 / 5 = 1`（整数除法砍小数）

---

### 步骤3：Git 提交 + 打卡

```bash
git add DailyPractice/
git commit -m "D4晚上：判断奇偶+温度转换练习"
git push
```

更新 `notes/checkin.md`，勾选D4完成，写学习总结。

---

## 📌 D4 核心要点总结

1. **C#变量：** 声明要指定类型，赋值用=，float加f
2. **6种类型：** int/float/double/bool/string/char，各有用途
3. **运算符：** 算术/比较/逻辑，注意`=`和`==`的区别
4. **Unity脚本：** Start()执行一次，Update()每帧执行
5. **移动：** transform.Translate(方向 × 速度 × Time.deltaTime)
6. **旋转：** transform.Rotate(旋转角度 × Time.deltaTime)
7. **键盘控制：** if (Input.GetKey(KeyCode.W)) + Translate
8. **if...else：** 条件判断，奇偶判断、温度转换都用到