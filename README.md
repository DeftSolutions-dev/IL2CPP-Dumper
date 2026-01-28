# IL2CPP Dumper DLL

Simple injectable DLL tool that dumps IL2CPP metadata from Unity games.

**Main features**
- Extracts classes, fields, methods, interfaces, namespaces from `GameAssembly.dll`
- Generates two output formats per assembly:
  - Classic C#-like `.cs` files (with proper access modifiers, static/virtual, inheritance, interfaces)
  - AI-friendly structured text (easy to feed to LLMs / code generation tools)
- Activated by pressing **INSERT** after injection
- Saves dumps to:
  - `C:\IL2CPP_Dump_Normal\`
  - `C:\IL2CPP_Dump_AI\`
- Logs everything to `C:\IL2CPPDump_Log.txt`

**Originally created for**  
Arknights: Endfield (and other modern Unity + IL2CPP games)

**Supported IL2CPP versions**  
≈ IL2CPP 27–29 (covers most games built with Unity 2021.3 – 2023.x – 2024.x)

**Usage**
1. Inject the DLL into the game process (any injector)
2. Press **INSERT** in-game
3. Wait for dump completion (check console & log file)

Perfect for reverse engineering, modding, cheat development or LLM-based code analysis of Unity IL2CPP titles.
