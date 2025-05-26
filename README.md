<div align="center">
  <h1>��ת1Сʱ.exe</h1>
  <img src="resources/����.gif" alt="������ͼ" width="200">
  <a href="#����">����</a> | <a href="#english">English</a>
</div>

---

## ����

<a id="����"></a>
���������������������֣�һ��������ʼ��ת��ͬʱ�·���ʾ����ʱ1Сʱ��  
- **���������ʹ���**����������ʱ������ʾ������ͼ��򴰿ڱ߿���ȫ����ʽ���顣  
- **����ʱ����**������ʱ����ʱ�������Զ��˳���  
- **�Ҽ��˵�����**������ͨ���Ҽ��˵��رճ��򣬻���ͨ�����������ǿ�ƽ������̡�  
- **�л�ʳ��**���Ҽ������ת��ʳ������л�������������ʳ����������ת��һСʱ�ɣ�

### ������б���

#### ǰ������
- **Visual Studio 2022 ����߰汾**��ȷ�����Ѱ�װ Visual Studio 2022 ����߰汾��
- **.NET ���濪������**���ڰ�װ�����У�ȷ����ѡ�ˡ�.NET ���濪�����������ء�
- **Windows 10 �� Windows 11 SDK**��ͬ����Ҫ��ѡ Windows 10 �� Windows 11 SDK��

#### ���벽��
1. **��װ Visual Studio**  
   �������δ��װ Visual Studio����ǰ�� [Visual Studio �ٷ���վ](https://visualstudio.microsoft.com/)���ز���װ Visual Studio 2022 ����߰汾���ڰ�װ�����У�ȷ����ѡ����ѡ�
   - **.NET ���濪��**  
     ��ѡ���ṩ�˿�������Ӧ�ó�������Ĺ��ߺͿ⡣
   - **Windows 10 �� Windows 11 SDK**  
     ��ѡ���ṩ�˿��� Windows Ӧ�ó��������ϵͳ��������

2. **���û�������**  
   �ڰ�װ Windows SDK ������Ҫ�� SDK �� `bin/�汾��/` Ŀ¼��ӵ�ϵͳ�Ļ��������С����岽�����£�
   - �򿪡���ʼ���˵����������򿪡��������������á�
   - �ڡ�ϵͳ���ԡ������У�ѡ�񡰻�����������
   - �ڡ�ϵͳ���������֣��ҵ���ѡ��Path��������Ȼ�������༭����
   - ������½�������� SDK �� `bin/�汾��/` Ŀ¼·�������磺
     ```
     D:\Windows Kits\10\bin\10.0.26100.0\x64
     ```
   - �����ȷ����������ġ�

3. **��¡��Ŀ**  
   ���ն˻�������ʾ�����������������¡����Ŀ�����أ�
   ```bash
   git clone https://github.com/stand114514/SpinFor1Hour.git
   cd SpinFor1Hour
   ```

4. **����Ŀ**  
   ʹ�� Visual Studio ����Ŀ��
   - �� Visual Studio��
   - ѡ�񡰴򿪡�->����Ŀ������������
   - ��������¡����ĿĿ¼��ѡ���������ļ���`.sln`����

5. **������Ŀ**  
   �� Visual Studio �У���������ɡ�->�����ɽ�������������ɱ�����Ŀ�����һ��������������������ɹ�����ʾ��

6. **���г���**  
   ��������ԡ�->����ʼ���ԡ����������г�����Ҳ����ֱ�������ɵ����Ŀ¼���ҵ���ִ���ļ���`��ת1Сʱ.exe`����˫�����С�

### ʹ��˵��
- **��¼�˶�����**����������������������˶�ʱ�䡢�������Ϣ�������Զ��������ĵĿ�·�
- **�鿴��ʷ��¼**������ᱣ��������ʷ�˶����ݣ�������ͨ������鿴��ϸ��¼��
- **��������**���������Խ����ݵ���Ϊ CSV �ļ��������һ��������

### ע������
- ȷ�����ļ�����Ѱ�װ���°汾�� .NET ����ʱ��
- ����ڱ���������������⣬���� Visual Studio �İ�װ�Ƿ����������߲鿴��Ŀ�е� `README.md` �ļ��еĳ��������𲿷֡�

### ��ϵ��ʽ
�������ʹ�ù����������κ���������κν��飬��ͨ�� [Issues](https://github.com/stand114514/SpinFor1Hour/issues) �ύ������

---

## English
<a id="english"></a>
Launch the software, and a hamburger begins to spin to the sound of delightful music, with a 1-hour countdown timer displayed below.  
- **No Taskbar or Window**��The program runs without a taskbar icon or window frame for a fully immersive experience.  
- **Countdown Completion**��The program will automatically exit when the countdown reaches zero.  
- **Right-Click Menu**��You can close the program via the right-click menu, or terminate it through the Task Manager.  
- **Switch Foods**��Right-click on the spinning food to switch to various other dishes. Enjoy your spinning hour!

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
   After installing the Windows SDK, you need to add the SDK's `bin/�汾��/` directory to the system environment variables. Follow these steps:
   - Open the "Start" menu, search for, and open the "Environment Variables" settings.
   - In the "System Properties" window, select "Environment Variables".
   - In the "System variables" section, find and select the "Path" variable, then click "Edit".
   - Click "New" and add the path to the SDK's `bin/�汾��/` directory. For example:
     ```
     D:\Windows Kits\10\bin\10.0.26100.0\x64
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

ͨ������������� `#����` �� `#english`���û�����ֱ����ת����Ӧ�����Ļ�Ӣ�Ĳ��֡�ϣ������Ľ�����������������������������������Ҫ��һ������������ʱ�����ҡ�