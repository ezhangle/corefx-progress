namespace System.Reflection {
  public static class AssemblyExtensions {
    public static Type[] GetExportedTypes(Assembly assembly);
    public static Module[] GetModules(Assembly assembly);
    public static Type[] GetTypes(Assembly assembly);
  }
  public static class EventInfoExtensions {
    public static MethodInfo GetAddMethod(EventInfo eventInfo);
    public static MethodInfo GetAddMethod(EventInfo eventInfo, bool nonPublic);
    public static MethodInfo GetRaiseMethod(EventInfo eventInfo);
    public static MethodInfo GetRaiseMethod(EventInfo eventInfo, bool nonPublic);
    public static MethodInfo GetRemoveMethod(EventInfo eventInfo);
    public static MethodInfo GetRemoveMethod(EventInfo eventInfo, bool nonPublic);
  }
  public static class MethodInfoExtensions {
    public static MethodInfo GetBaseDefinition(MethodInfo method);
  }
  public static class PropertyInfoExtensions {
    public static MethodInfo[] GetAccessors(PropertyInfo property);
    public static MethodInfo[] GetAccessors(PropertyInfo property, bool nonPublic);
    public static MethodInfo GetGetMethod(PropertyInfo property);
    public static MethodInfo GetGetMethod(PropertyInfo property, bool nonPublic);
    public static MethodInfo GetSetMethod(PropertyInfo property);
    public static MethodInfo GetSetMethod(PropertyInfo property, bool nonPublic);
  }
  public static class TypeExtensions {
    public static ConstructorInfo GetConstructor(Type type, Type[] types);
    public static ConstructorInfo[] GetConstructors(Type type);
    public static ConstructorInfo[] GetConstructors(Type type, BindingFlags bindingAttr);
    public static MemberInfo[] GetDefaultMembers(Type type);
    public static EventInfo GetEvent(Type type, string name);
    public static EventInfo GetEvent(Type type, string name, BindingFlags bindingAttr);
    public static EventInfo[] GetEvents(Type type);
    public static EventInfo[] GetEvents(Type type, BindingFlags bindingAttr);
    public static FieldInfo GetField(Type type, string name);
    public static FieldInfo GetField(Type type, string name, BindingFlags bindingAttr);
    public static FieldInfo[] GetFields(Type type);
    public static FieldInfo[] GetFields(Type type, BindingFlags bindingAttr);
    public static Type[] GetGenericArguments(Type type);
    public static Type[] GetInterfaces(Type type);
    public static MemberInfo[] GetMember(Type type, string name);
    public static MemberInfo[] GetMember(Type type, string name, BindingFlags bindingAttr);
    public static MemberInfo[] GetMembers(Type type);
    public static MemberInfo[] GetMembers(Type type, BindingFlags bindingAttr);
    public static MethodInfo GetMethod(Type type, string name);
    public static MethodInfo GetMethod(Type type, string name, BindingFlags bindingAttr);
    public static MethodInfo GetMethod(Type type, string name, Type[] types);
    public static MethodInfo[] GetMethods(Type type);
    public static MethodInfo[] GetMethods(Type type, BindingFlags bindingAttr);
    public static Type GetNestedType(Type type, string name, BindingFlags bindingAttr);
    public static Type[] GetNestedTypes(Type type, BindingFlags bindingAttr);
    public static PropertyInfo[] GetProperties(Type type);
    public static PropertyInfo[] GetProperties(Type type, BindingFlags bindingAttr);
    public static PropertyInfo GetProperty(Type type, string name);
    public static PropertyInfo GetProperty(Type type, string name, BindingFlags bindingAttr);
    public static PropertyInfo GetProperty(Type type, string name, Type returnType);
    public static PropertyInfo GetProperty(Type type, string name, Type returnType, Type[] types);
    public static bool IsAssignableFrom(Type type, Type c);
    public static bool IsInstanceOfType(Type type, object o);
  }
}
