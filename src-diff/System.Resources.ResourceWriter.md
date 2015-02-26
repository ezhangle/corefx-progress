﻿```diff
---lib-full\System.Resources.ResourceWriter.dll
+++lib-oss\System.Resources.ResourceWriter.dll
 namespace System.Resources {
  public sealed class ResourceWriter : IDisposable {
    public ResourceWriter(Stream stream);
    public void AddResource(string name, string value);
    public void Close();
    public void Dispose();
    public void Generate();
  }
 }
```
