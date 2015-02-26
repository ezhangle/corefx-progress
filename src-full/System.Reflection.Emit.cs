﻿namespace System.Reflection.Emit {
  public sealed class AssemblyBuilder : Assembly {
    public override IEnumerable<TypeInfo> DefinedTypes { get; }
    public override string FullName { get; }
    public override bool IsDynamic { get; }
    public override Module ManifestModule { get; }
    public override IEnumerable<Module> Modules { get; }
    public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
    public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
    public ModuleBuilder DefineDynamicModule(string name);
    public override bool Equals(object obj);
    public ModuleBuilder GetDynamicModule(string name);
    public override int GetHashCode();
    public override ManifestResourceInfo GetManifestResourceInfo(string resourceName);
    public override string[] GetManifestResourceNames();
    public override Stream GetManifestResourceStream(string name);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
  }
  public enum AssemblyBuilderAccess {
    Run = 1,
    RunAndCollect = 9,
  }
  public sealed class ConstructorBuilder : ConstructorInfo {
    public override MethodAttributes Attributes { get; }
    public override CallingConventions CallingConvention { get; }
    public override Type DeclaringType { get; }
    public bool InitLocals { get; set; }
    public override MethodImplAttributes MethodImplementationFlags { get; }
    public override string Name { get; }
    public ParameterBuilder DefineParameter(int iSequence, ParameterAttributes attributes, string strParamName);
    public ILGenerator GetILGenerator();
    public ILGenerator GetILGenerator(int streamSize);
    public override ParameterInfo[] GetParameters();
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetImplementationFlags(MethodImplAttributes attributes);
    public override string ToString();
  }
  public sealed class EnumBuilder : TypeInfo {
    public override Assembly Assembly { get; }
    public override string AssemblyQualifiedName { get; }
    public override TypeAttributes Attributes { get; }
    public override Type BaseType { get; }
    public override bool ContainsGenericParameters { get; }
    public override MethodBase DeclaringMethod { get; }
    public override Type DeclaringType { get; }
    public override string FullName { get; }
    public override GenericParameterAttributes GenericParameterAttributes { get; }
    public override int GenericParameterPosition { get; }
    public override Type[] GenericTypeArguments { get; }
    public override Guid GUID { get; }
    public override bool IsEnum { get; }
    public override bool IsGenericParameter { get; }
    public override bool IsGenericType { get; }
    public override bool IsGenericTypeDefinition { get; }
    public override bool IsSerializable { get; }
    public override Module Module { get; }
    public override string Name { get; }
    public override string Namespace { get; }
    public FieldBuilder UnderlyingField { get; }
    public TypeInfo CreateTypeInfo();
    public FieldBuilder DefineLiteral(string literalName, object literalValue);
    public override int GetArrayRank();
    public override Type GetElementType();
    public override Type[] GetGenericParameterConstraints();
    public override Type GetGenericTypeDefinition();
    public override bool IsAssignableFrom(TypeInfo typeInfo);
    public override Type MakeArrayType();
    public override Type MakeArrayType(int rank);
    public override Type MakeByRefType();
    public override Type MakeGenericType(params Type[] typeArguments);
    public override Type MakePointerType();
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
  }
  public sealed class EventBuilder {
    public void AddOtherMethod(MethodBuilder mdBuilder);
    public void SetAddOnMethod(MethodBuilder mdBuilder);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetRaiseMethod(MethodBuilder mdBuilder);
    public void SetRemoveOnMethod(MethodBuilder mdBuilder);
  }
  public sealed class FieldBuilder : FieldInfo {
    public override FieldAttributes Attributes { get; }
    public override Type DeclaringType { get; }
    public override Type FieldType { get; }
    public override string Name { get; }
    public override object GetValue(object obj);
    public void SetConstant(object defaultValue);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetOffset(int iOffset);
  }
  public sealed class GenericTypeParameterBuilder : TypeInfo {
    public override Assembly Assembly { get; }
    public override string AssemblyQualifiedName { get; }
    public override TypeAttributes Attributes { get; }
    public override Type BaseType { get; }
    public override bool ContainsGenericParameters { get; }
    public override MethodBase DeclaringMethod { get; }
    public override Type DeclaringType { get; }
    public override string FullName { get; }
    public override GenericParameterAttributes GenericParameterAttributes { get; }
    public override int GenericParameterPosition { get; }
    public override Type[] GenericTypeArguments { get; }
    public override Guid GUID { get; }
    public override bool IsEnum { get; }
    public override bool IsGenericParameter { get; }
    public override bool IsGenericType { get; }
    public override bool IsGenericTypeDefinition { get; }
    public override bool IsSerializable { get; }
    public override Module Module { get; }
    public override string Name { get; }
    public override string Namespace { get; }
    public override bool Equals(object o);
    public override int GetArrayRank();
    public override Type GetElementType();
    public override Type[] GetGenericParameterConstraints();
    public override Type GetGenericTypeDefinition();
    public override int GetHashCode();
    public override bool IsAssignableFrom(TypeInfo typeInfo);
    public override bool IsSubclassOf(Type c);
    public override Type MakeArrayType();
    public override Type MakeArrayType(int rank);
    public override Type MakeByRefType();
    public override Type MakeGenericType(params Type[] typeArguments);
    public override Type MakePointerType();
    public void SetBaseTypeConstraint(Type baseTypeConstraint);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetGenericParameterAttributes(GenericParameterAttributes genericParameterAttributes);
    public void SetInterfaceConstraints(params Type[] interfaceConstraints);
    public override string ToString();
  }
  public sealed class MethodBuilder : MethodInfo {
    public override MethodAttributes Attributes { get; }
    public override CallingConventions CallingConvention { get; }
    public override bool ContainsGenericParameters { get; }
    public override Type DeclaringType { get; }
    public bool InitLocals { get; set; }
    public override bool IsGenericMethod { get; }
    public override bool IsGenericMethodDefinition { get; }
    public override MethodImplAttributes MethodImplementationFlags { get; }
    public override string Name { get; }
    public override ParameterInfo ReturnParameter { get; }
    public override Type ReturnType { get; }
    public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
    public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName);
    public override bool Equals(object obj);
    public override Type[] GetGenericArguments();
    public override MethodInfo GetGenericMethodDefinition();
    public override int GetHashCode();
    public ILGenerator GetILGenerator();
    public ILGenerator GetILGenerator(int size);
    public override ParameterInfo[] GetParameters();
    public override MethodInfo MakeGenericMethod(params Type[] typeArguments);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetImplementationFlags(MethodImplAttributes attributes);
    public void SetParameters(params Type[] parameterTypes);
    public void SetReturnType(Type returnType);
    public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
    public override string ToString();
  }
  public class ModuleBuilder : Module {
    public override Assembly Assembly { get; }
    public override string FullyQualifiedName { get; }
    public override string Name { get; }
    public void CreateGlobalFunctions();
    public EnumBuilder DefineEnum(string name, TypeAttributes visibility, Type underlyingType);
    public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
    public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
    public MethodBuilder DefineGlobalMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
    public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
    public TypeBuilder DefineType(string name);
    public TypeBuilder DefineType(string name, TypeAttributes attr);
    public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent);
    public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, int typesize);
    public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packsize);
    public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, PackingSize packingSize, int typesize);
    public TypeBuilder DefineType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
    public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
    public override bool Equals(object obj);
    public MethodInfo GetArrayMethod(Type arrayClass, string methodName, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
    public override int GetHashCode();
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
  }
  public sealed class PropertyBuilder : PropertyInfo {
    public override PropertyAttributes Attributes { get; }
    public override bool CanRead { get; }
    public override bool CanWrite { get; }
    public override Type DeclaringType { get; }
    public override string Name { get; }
    public override Type PropertyType { get; }
    public void AddOtherMethod(MethodBuilder mdBuilder);
    public override ParameterInfo[] GetIndexParameters();
    public override object GetValue(object obj, object[] index);
    public void SetConstant(object defaultValue);
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetGetMethod(MethodBuilder mdBuilder);
    public void SetSetMethod(MethodBuilder mdBuilder);
    public override void SetValue(object obj, object value, object[] index);
  }
  public sealed class TypeBuilder : TypeInfo {
    public const int UnspecifiedTypeSize = 0;
    public override Assembly Assembly { get; }
    public override string AssemblyQualifiedName { get; }
    public override TypeAttributes Attributes { get; }
    public override Type BaseType { get; }
    public override bool ContainsGenericParameters { get; }
    public override MethodBase DeclaringMethod { get; }
    public override Type DeclaringType { get; }
    public override string FullName { get; }
    public override GenericParameterAttributes GenericParameterAttributes { get; }
    public override int GenericParameterPosition { get; }
    public override Type[] GenericTypeArguments { get; }
    public override Guid GUID { get; }
    public override bool IsEnum { get; }
    public override bool IsGenericParameter { get; }
    public override bool IsGenericType { get; }
    public override bool IsGenericTypeDefinition { get; }
    public override bool IsSerializable { get; }
    public override Module Module { get; }
    public override string Name { get; }
    public override string Namespace { get; }
    public PackingSize PackingSize { get; }
    public int Size { get; }
    public void AddInterfaceImplementation(Type interfaceType);
    public TypeInfo CreateTypeInfo();
    public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes);
    public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
    public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes);
    public EventBuilder DefineEvent(string name, EventAttributes attributes, Type eventtype);
    public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes);
    public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes);
    public GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names);
    public FieldBuilder DefineInitializedData(string name, byte[] data, FieldAttributes attributes);
    public MethodBuilder DefineMethod(string name, MethodAttributes attributes);
    public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention);
    public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
    public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
    public MethodBuilder DefineMethod(string name, MethodAttributes attributes, Type returnType, Type[] parameterTypes);
    public void DefineMethodOverride(MethodInfo methodInfoBody, MethodInfo methodInfoDeclaration);
    public TypeBuilder DefineNestedType(string name);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, int typeSize);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, PackingSize packSize, int typeSize);
    public TypeBuilder DefineNestedType(string name, TypeAttributes attr, Type parent, Type[] interfaces);
    public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes);
    public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
    public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] parameterTypes);
    public PropertyBuilder DefineProperty(string name, PropertyAttributes attributes, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers);
    public ConstructorBuilder DefineTypeInitializer();
    public FieldBuilder DefineUninitializedData(string name, int size, FieldAttributes attributes);
    public override int GetArrayRank();
    public static ConstructorInfo GetConstructor(Type type, ConstructorInfo constructor);
    public override Type GetElementType();
    public static FieldInfo GetField(Type type, FieldInfo field);
    public override Type[] GetGenericParameterConstraints();
    public override Type GetGenericTypeDefinition();
    public static MethodInfo GetMethod(Type type, MethodInfo method);
    public override bool IsAssignableFrom(TypeInfo typeInfo);
    public bool IsCreated();
    public override Type MakeArrayType();
    public override Type MakeArrayType(int rank);
    public override Type MakeByRefType();
    public override Type MakeGenericType(params Type[] typeArguments);
    public override Type MakePointerType();
    public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute);
    public void SetCustomAttribute(CustomAttributeBuilder customBuilder);
    public void SetParent(Type parent);
    public override string ToString();
  }
}
