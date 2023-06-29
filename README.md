# com.charix.yandexgames    
  
Make sure you have standalone [Git](https://git-scm.com/downloads) installed first. Reboot after installation.  
In Unity, open "Window" -> "Package Manager".  
Click the "+" sign on top left corner -> "Add package from git URL..."  
Paste this: ``  
See minimum required Unity version in the `package.json` file.  
Find "Samples" in the package window and click the "Import" button. Use it as a guide.  
To update the package, simply add it again while using a different version tag.  
  
This package automatically inserts YandexGames SDK script into HTML page when calling `YandexGamesSdk.Initialize()`. No need to mess with WebGLTemplates - just use the SDK methods.  
  
