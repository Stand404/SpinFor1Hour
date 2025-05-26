<div align="center">
  <h1>旋转1小时.exe</h1>
  <img src="resources/汉堡.gif" alt="汉堡动图" width="200">
  <br>
  <a href="README.md">中文</a> | <a href="README_EN.md">English</a>
</div>

---

## 中文

### 项目简介
《旋转1小时》是一款简单的桌面应用程序，旨在帮助用户记录和管理他们的运动数据。通过这个程序，用户可以轻松跟踪他们的运动时间、距离和消耗的卡路里，从而更好地管理自己的健康和健身计划。

### 如何自行编译

#### 前置条件
- **Visual Studio 2022 或更高版本**：确保您已安装 Visual Studio 2022 或更高版本。
- **.NET 桌面开发工具**：在安装过程中，确保勾选了“.NET 桌面开发”工作负载。
- **Windows 10 或 Windows 11 SDK**：同样需要勾选 Windows 10 或 Windows 11 SDK。

#### 编译步骤
1. **安装 Visual Studio**  
   如果您尚未安装 Visual Studio，请前往 [Visual Studio 官方网站](https://visualstudio.microsoft.com/)下载并安装 Visual Studio 2022 或更高版本。在安装过程中，确保勾选以下选项：
   - **.NET 桌面开发**  
     该选项提供了开发桌面应用程序所需的工具和库。
   - **Windows 10 或 Windows 11 SDK**  
     该选项提供了开发 Windows 应用程序所需的系统开发包。

2. **配置环境变量**  
   在安装 Windows SDK 后，您需要将 SDK 的 `bin/版本号/` 目录添加到系统的环境变量中。具体步骤如下：
   - 打开“开始”菜单，搜索并打开“环境变量”设置。
   - 在“系统属性”窗口中，选择“环境变量”。
   - 在“系统变量”部分，找到并选择“Path”变量，然后点击“编辑”。
   - 点击“新建”，添加 SDK 的 `bin/版本号/` 目录路径。例如：
     ```
     C:\Program Files (x86)\Windows Kits\10\bin\x64
     ```
   - 点击“确定”保存更改。

3. **克隆项目**  
   打开终端或命令提示符，运行以下命令克隆本项目到本地：
   ```bash
   git clone https://github.com/stand114514/SpinFor1Hour.git
   cd SpinFor1Hour
   ```

4. **打开项目**  
   使用 Visual Studio 打开项目：
   - 打开 Visual Studio。
   - 选择“打开”->“项目或解决方案”。
   - 导航到克隆的项目目录，选择解决方案文件（`.sln`）。

5. **编译项目**  
   在 Visual Studio 中，点击“生成”->“生成解决方案”，即可编译项目。如果一切正常，您将看到编译成功的提示。

6. **运行程序**  
   点击“调试”->“开始调试”，即可运行程序。您也可以直接在生成的输出目录中找到可执行文件（`旋转1小时.exe`），双击运行。

### 使用说明
- **记录运动数据**：启动程序后，您可以输入运动时间、距离等信息，程序将自动计算消耗的卡路里。
- **查看历史记录**：程序会保存您的历史运动数据，您可以通过界面查看详细记录。
- **导出数据**：您还可以将数据导出为 CSV 文件，方便进一步分析。

### 注意事项
- 确保您的计算机已安装最新版本的 .NET 运行时。
- 如果在编译过程中遇到问题，请检查 Visual Studio 的安装是否完整，或者查看项目中的 `README.md` 文件中的常见问题解答部分。

### 联系方式
如果您在使用过程中遇到任何问题或有任何建议，请通过 [Issues](https://github.com/stand114514/SpinFor1Hour/issues) 提交反馈。

---

## English

### Project Introduction
"Spin for 1 Hour" is a simple desktop application designed to help users record and manage their exercise data. Through this program, users can easily track their exercise time, distance, and calories burned, thereby better managing their health and fitness plans.

### How to Compile

#### Prerequisites
- **Visual Studio 2022 or Higher**: Ensure you have Visual Studio 2022 or a higher version installed.
- **.NET Desktop Development Tools**: During installation, make sure to select the ".NET Desktop Development" workload.
- **Windows 10 or Windows 11 SDK**: Also select the Windows 10 or Windows 11 SDK.

#### Compilation Steps
1. **Install Visual Studio**  
   If you haven't installed Visual Studio yet, please visit the [Visual Studio Official Website](https://visualstudio.microsoft.com/) to download and install Visual Studio 2022 or higher. During installation, ensure you select the following options:
   - **.NET Desktop Development**  
     This option provides the tools and libraries required for desktop application development.
   - **Windows 10 or Windows 11 SDK**  
     This option provides the system development packages required for Windows application development.

2. **Configure Environment Variables**  
   After installing the Windows SDK, you need to add the SDK's `bin/版本号/` directory to the system environment variables. Follow these steps:
   - Open the "Start" menu, search for, and open the "Environment Variables" settings.
   - In the "System Properties" window, select "Environment Variables".
   - In the "System variables" section, find and select the "Path" variable, then click "Edit".
   - Click "New" and add the path to the SDK's `bin/版本号/` directory. For example:
     ```
     C:\Program Files (x86)\Windows Kits\10\bin\x64
     ```
   - Click "OK" to save the changes.

3. **Clone the Project**  
   Open a terminal or command prompt and run the following commands to clone the project to your local machine:
   ```bash
   git clone https://github.com/stand114514/SpinFor1Hour.git
   cd SpinFor1Hour
   ```

4. **Open the Project**  
   Open the project using Visual Studio:
   - Open Visual Studio.
   - Select "Open" -> "Project or Solution".
   - Navigate to the cloned project directory and select the solution file (`.sln`).

5. **Compile the Project**  
   In Visual Studio, click "Build" -> "Build Solution" to compile the project. If everything goes well, you will see a successful compilation prompt.

6. **Run the Program**  
   Click "Debug" -> "Start Debugging" to run the program. You can also directly run the executable file (`SpinFor1Hour.exe`) in the output directory by double-clicking it.

### Usage Instructions
- **Record Exercise Data**: After launching the program, you can input exercise time, distance, and other information. The program will automatically calculate the calories burned.
- **View History**: The program will save your historical exercise data, which you can view through the interface.
- **Export Data**: You can also export the data to a CSV file for further analysis.

### Notes
- Ensure that the latest version of the .NET runtime is installed on your computer.
- If you encounter any issues during compilation, please check if your Visual Studio installation is complete or refer to the "Common Issues" section in the project's `README.md` file.

### Contact
If you encounter any problems or have any suggestions while using the program, please submit feedback through [Issues](https://github.com/stand114514/SpinFor1Hour/issues).

---

希望这份 `README.md` 文件能满足您的需求！如果您有任何进一步的要求或需要调整的地方，请随时告诉我。