﻿namespace System.Linq {
  public interface IOrderedQueryable : IEnumerable, IQueryable {
  }
  public interface IOrderedQueryable<out T> : IEnumerable, IEnumerable<T>, IOrderedQueryable, IQueryable, IQueryable<T> {
  }
  public interface IQueryable : IEnumerable {
    Type ElementType { get; }
    Expression Expression { get; }
    IQueryProvider Provider { get; }
  }
  public interface IQueryable<out T> : IEnumerable, IEnumerable<T>, IQueryable {
  }
  public interface IQueryProvider {
    IQueryable CreateQuery(Expression expression);
    IQueryable<TElement> CreateQuery<TElement>(Expression expression);
    object Execute(Expression expression);
    TResult Execute<TResult>(Expression expression);
  }
}
namespace System.Linq.Expressions {
  public class BinaryExpression : Expression {
    public override bool CanReduce { get; }
    public LambdaExpression Conversion { get; }
    public bool IsLifted { get; }
    public bool IsLiftedToNull { get; }
    public Expression Left { get; }
    public MethodInfo Method { get; }
    public Expression Right { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public override Expression Reduce();
    public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right);
  }
  public class BlockExpression : Expression {
    public ReadOnlyCollection<Expression> Expressions { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression Result { get; }
    public override Type Type { get; }
    public ReadOnlyCollection<ParameterExpression> Variables { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public BlockExpression Update(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions);
  }
  public sealed class CatchBlock {
    public Expression Body { get; }
    public Expression Filter { get; }
    public Type Test { get; }
    public ParameterExpression Variable { get; }
    public override string ToString();
    public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body);
  }
  public class ConditionalExpression : Expression {
    public Expression IfFalse { get; }
    public Expression IfTrue { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression Test { get; }
    public override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse);
  }
  public class ConstantExpression : Expression {
    public sealed override ExpressionType NodeType { get; }
    public override Type Type { get; }
    public object Value { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
  }
  public class DebugInfoExpression : Expression {
    public SymbolDocumentInfo Document { get; }
    public virtual int EndColumn { get; }
    public virtual int EndLine { get; }
    public virtual bool IsClear { get; }
    public sealed override ExpressionType NodeType { get; }
    public virtual int StartColumn { get; }
    public virtual int StartLine { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
  }
  public sealed class DefaultExpression : Expression {
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
  }
  public sealed class ElementInit : IArgumentProvider {
    public MethodInfo AddMethod { get; }
    public int ArgumentCount { get; }
    public ReadOnlyCollection<Expression> Arguments { get; }
    public Expression GetArgument(int index);
    public override string ToString();
    public ElementInit Update(IEnumerable<Expression> arguments);
  }
  public abstract class Expression {
    protected Expression();
    protected Expression(ExpressionType nodeType, Type type);
    public virtual bool CanReduce { get; }
    public string DebugView { get; }
    public virtual ExpressionType NodeType { get; }
    public virtual Type Type { get; }
    protected internal virtual Expression Accept(ExpressionVisitor visitor);
    public static BinaryExpression Add(Expression left, Expression right);
    public static BinaryExpression Add(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AddAssign(Expression left, Expression right);
    public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression AddAssignChecked(Expression left, Expression right);
    public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression AddChecked(Expression left, Expression right);
    public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression And(Expression left, Expression right);
    public static BinaryExpression And(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AndAlso(Expression left, Expression right);
    public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AndAssign(Expression left, Expression right);
    public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes);
    public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes);
    public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes);
    public static BinaryExpression ArrayIndex(Expression array, Expression index);
    public static MethodCallExpression ArrayIndex(Expression array, params Expression[] indexes);
    public static UnaryExpression ArrayLength(Expression array);
    public static BinaryExpression Assign(Expression left, Expression right);
    public static MemberAssignment Bind(MemberInfo member, Expression expression);
    public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression);
    public static BlockExpression Block(IEnumerable<Expression> expressions);
    public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions);
    public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions);
    public static BlockExpression Block(Expression arg0, Expression arg1);
    public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2);
    public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3);
    public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4);
    public static BlockExpression Block(params Expression[] expressions);
    public static BlockExpression Block(Type type, IEnumerable<Expression> expressions);
    public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions);
    public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions);
    public static BlockExpression Block(Type type, params Expression[] expressions);
    public static GotoExpression Break(LabelTarget target);
    public static GotoExpression Break(LabelTarget target, Expression value);
    public static GotoExpression Break(LabelTarget target, Expression value, Type type);
    public static GotoExpression Break(LabelTarget target, Type type);
    public static MethodCallExpression Call(Expression instance, MethodInfo method);
    public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments);
    public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1);
    public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2);
    public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments);
    public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments);
    public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments);
    public static MethodCallExpression Call(MethodInfo method, Expression arg0);
    public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1);
    public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2);
    public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3);
    public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4);
    public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments);
    public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, params Expression[] arguments);
    public static CatchBlock Catch(ParameterExpression variable, Expression body);
    public static CatchBlock Catch(ParameterExpression variable, Expression body, Expression filter);
    public static CatchBlock Catch(Type type, Expression body);
    public static CatchBlock Catch(Type type, Expression body, Expression filter);
    public static DebugInfoExpression ClearDebugInfo(SymbolDocumentInfo document);
    public static BinaryExpression Coalesce(Expression left, Expression right);
    public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion);
    public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse);
    public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type);
    public static ConstantExpression Constant(object value);
    public static ConstantExpression Constant(object value, Type type);
    public static GotoExpression Continue(LabelTarget target);
    public static GotoExpression Continue(LabelTarget target, Type type);
    public static UnaryExpression Convert(Expression expression, Type type);
    public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method);
    public static UnaryExpression ConvertChecked(Expression expression, Type type);
    public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method);
    public static DebugInfoExpression DebugInfo(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn);
    public static UnaryExpression Decrement(Expression expression);
    public static UnaryExpression Decrement(Expression expression, MethodInfo method);
    public static DefaultExpression Default(Type type);
    public static BinaryExpression Divide(Expression left, Expression right);
    public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression DivideAssign(Expression left, Expression right);
    public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments);
    public static ElementInit ElementInit(MethodInfo addMethod, params Expression[] arguments);
    public static DefaultExpression Empty();
    public static BinaryExpression Equal(Expression left, Expression right);
    public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static BinaryExpression ExclusiveOr(Expression left, Expression right);
    public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right);
    public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static MemberExpression Field(Expression expression, FieldInfo field);
    public static MemberExpression Field(Expression expression, string fieldName);
    public static MemberExpression Field(Expression expression, Type type, string fieldName);
    public static Type GetActionType(params Type[] typeArgs);
    public static Type GetDelegateType(params Type[] typeArgs);
    public static Type GetFuncType(params Type[] typeArgs);
    public static GotoExpression Goto(LabelTarget target);
    public static GotoExpression Goto(LabelTarget target, Expression value);
    public static GotoExpression Goto(LabelTarget target, Expression value, Type type);
    public static GotoExpression Goto(LabelTarget target, Type type);
    public static BinaryExpression GreaterThan(Expression left, Expression right);
    public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right);
    public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static ConditionalExpression IfThen(Expression test, Expression ifTrue);
    public static ConditionalExpression IfThenElse(Expression test, Expression ifTrue, Expression ifFalse);
    public static UnaryExpression Increment(Expression expression);
    public static UnaryExpression Increment(Expression expression, MethodInfo method);
    public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments);
    public static InvocationExpression Invoke(Expression expression, params Expression[] arguments);
    public static UnaryExpression IsFalse(Expression expression);
    public static UnaryExpression IsFalse(Expression expression, MethodInfo method);
    public static UnaryExpression IsTrue(Expression expression);
    public static UnaryExpression IsTrue(Expression expression, MethodInfo method);
    public static LabelTarget Label();
    public static LabelExpression Label(LabelTarget target);
    public static LabelExpression Label(LabelTarget target, Expression defaultValue);
    public static LabelTarget Label(string name);
    public static LabelTarget Label(Type type);
    public static LabelTarget Label(Type type, string name);
    public static LambdaExpression Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Expression body, bool tailCall, params ParameterExpression[] parameters);
    public static LambdaExpression Lambda(Expression body, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Expression body, params ParameterExpression[] parameters);
    public static LambdaExpression Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Expression body, string name, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, params ParameterExpression[] parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static LambdaExpression Lambda(Type delegateType, Expression body, string name, IEnumerable<ParameterExpression> parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, params ParameterExpression[] parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);
    public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, IEnumerable<ParameterExpression> parameters);
    public static BinaryExpression LeftShift(Expression left, Expression right);
    public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression LeftShiftAssign(Expression left, Expression right);
    public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression LessThan(Expression left, Expression right);
    public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static BinaryExpression LessThanOrEqual(Expression left, Expression right);
    public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers);
    public static MemberListBinding ListBind(MemberInfo member, params ElementInit[] initializers);
    public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers);
    public static MemberListBinding ListBind(MethodInfo propertyAccessor, params ElementInit[] initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, params ElementInit[] initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, params Expression[] initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers);
    public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, params Expression[] initializers);
    public static LoopExpression Loop(Expression body);
    public static LoopExpression Loop(Expression body, LabelTarget @break);
    public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue);
    public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right);
    public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion);
    public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter);
    public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type);
    public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments);
    public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member);
    public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers);
    public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type);
    public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method);
    public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings);
    public static MemberMemberBinding MemberBind(MemberInfo member, params MemberBinding[] bindings);
    public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings);
    public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, params MemberBinding[] bindings);
    public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings);
    public static MemberInitExpression MemberInit(NewExpression newExpression, params MemberBinding[] bindings);
    public static BinaryExpression Modulo(Expression left, Expression right);
    public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression ModuloAssign(Expression left, Expression right);
    public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression Multiply(Expression left, Expression right);
    public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression MultiplyAssign(Expression left, Expression right);
    public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right);
    public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression MultiplyChecked(Expression left, Expression right);
    public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method);
    public static UnaryExpression Negate(Expression expression);
    public static UnaryExpression Negate(Expression expression, MethodInfo method);
    public static UnaryExpression NegateChecked(Expression expression);
    public static UnaryExpression NegateChecked(Expression expression, MethodInfo method);
    public static NewExpression New(ConstructorInfo constructor);
    public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments);
    public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members);
    public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, params MemberInfo[] members);
    public static NewExpression New(ConstructorInfo constructor, params Expression[] arguments);
    public static NewExpression New(Type type);
    public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds);
    public static NewArrayExpression NewArrayBounds(Type type, params Expression[] bounds);
    public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers);
    public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers);
    public static UnaryExpression Not(Expression expression);
    public static UnaryExpression Not(Expression expression, MethodInfo method);
    public static BinaryExpression NotEqual(Expression left, Expression right);
    public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);
    public static UnaryExpression OnesComplement(Expression expression);
    public static UnaryExpression OnesComplement(Expression expression, MethodInfo method);
    public static BinaryExpression Or(Expression left, Expression right);
    public static BinaryExpression Or(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression OrAssign(Expression left, Expression right);
    public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression OrElse(Expression left, Expression right);
    public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method);
    public static ParameterExpression Parameter(Type type);
    public static ParameterExpression Parameter(Type type, string name);
    public static UnaryExpression PostDecrementAssign(Expression expression);
    public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method);
    public static UnaryExpression PostIncrementAssign(Expression expression);
    public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method);
    public static BinaryExpression Power(Expression left, Expression right);
    public static BinaryExpression Power(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression PowerAssign(Expression left, Expression right);
    public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static UnaryExpression PreDecrementAssign(Expression expression);
    public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method);
    public static UnaryExpression PreIncrementAssign(Expression expression);
    public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method);
    public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor);
    public static MemberExpression Property(Expression expression, PropertyInfo property);
    public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments);
    public static IndexExpression Property(Expression instance, PropertyInfo indexer, params Expression[] arguments);
    public static MemberExpression Property(Expression expression, string propertyName);
    public static IndexExpression Property(Expression instance, string propertyName, params Expression[] arguments);
    public static MemberExpression Property(Expression expression, Type type, string propertyName);
    public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName);
    public static UnaryExpression Quote(Expression expression);
    public virtual Expression Reduce();
    public Expression ReduceAndCheck();
    public Expression ReduceExtensions();
    public static BinaryExpression ReferenceEqual(Expression left, Expression right);
    public static BinaryExpression ReferenceNotEqual(Expression left, Expression right);
    public static void RequiresCanRead(IEnumerable<Expression> items, string paramName);
    public static void RequiresCanRead(Expression expression, string paramName);
    public static UnaryExpression Rethrow();
    public static UnaryExpression Rethrow(Type type);
    public static GotoExpression Return(LabelTarget target);
    public static GotoExpression Return(LabelTarget target, Expression value);
    public static GotoExpression Return(LabelTarget target, Expression value, Type type);
    public static GotoExpression Return(LabelTarget target, Type type);
    public static T ReturnObject<T>(object collectionOrT) where T : class;
    public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IList<T> collection);
    public static BinaryExpression RightShift(Expression left, Expression right);
    public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression RightShiftAssign(Expression left, Expression right);
    public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static RuntimeVariablesExpression RuntimeVariables(IEnumerable<ParameterExpression> variables);
    public static RuntimeVariablesExpression RuntimeVariables(params ParameterExpression[] variables);
    public static BinaryExpression Subtract(Expression left, Expression right);
    public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression SubtractAssign(Expression left, Expression right);
    public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression SubtractAssignChecked(Expression left, Expression right);
    public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method);
    public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);
    public static BinaryExpression SubtractChecked(Expression left, Expression right);
    public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method);
    public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, params SwitchCase[] cases);
    public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases);
    public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases);
    public static SwitchExpression Switch(Expression switchValue, params SwitchCase[] cases);
    public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases);
    public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases);
    public static SwitchCase SwitchCase(Expression body, IEnumerable<Expression> testValues);
    public static SwitchCase SwitchCase(Expression body, params Expression[] testValues);
    public static SymbolDocumentInfo SymbolDocument(string fileName);
    public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language);
    public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor);
    public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor, Guid documentType);
    public static UnaryExpression Throw(Expression value);
    public static UnaryExpression Throw(Expression value, Type type);
    public override string ToString();
    public static TryExpression TryCatch(Expression body, params CatchBlock[] handlers);
    public static TryExpression TryCatchFinally(Expression body, Expression @finally, params CatchBlock[] handlers);
    public static TryExpression TryFault(Expression body, Expression fault);
    public static TryExpression TryFinally(Expression body, Expression @finally);
    public static bool TryGetActionType(Type[] typeArgs, out Type actionType);
    public static bool TryGetFuncType(Type[] typeArgs, out Type funcType);
    public static UnaryExpression TypeAs(Expression expression, Type type);
    public static TypeBinaryExpression TypeEqual(Expression expression, Type type);
    public static TypeBinaryExpression TypeIs(Expression expression, Type type);
    public static UnaryExpression UnaryPlus(Expression expression);
    public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method);
    public static UnaryExpression Unbox(Expression expression, Type type);
    public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis);
    public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments);
    public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi);
    public static ParameterExpression Variable(Type type);
    public static ParameterExpression Variable(Type type, string name);
    protected internal virtual Expression VisitChildren(ExpressionVisitor visitor);
  }
  public sealed class Expression<TDelegate> : LambdaExpression {
    public Expression(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters);
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public new TDelegate Compile();
    public Expression<TDelegate> Update(Expression body, IEnumerable<ParameterExpression> parameters);
  }
  public enum ExpressionType {
    Add = 0,
    AddAssign = 63,
    AddAssignChecked = 74,
    AddChecked = 1,
    And = 2,
    AndAlso = 3,
    AndAssign = 64,
    ArrayIndex = 5,
    ArrayLength = 4,
    Assign = 46,
    Block = 47,
    Call = 6,
    Coalesce = 7,
    Conditional = 8,
    Constant = 9,
    Convert = 10,
    ConvertChecked = 11,
    DebugInfo = 48,
    Decrement = 49,
    Default = 51,
    Divide = 12,
    DivideAssign = 65,
    Dynamic = 50,
    Equal = 13,
    ExclusiveOr = 14,
    ExclusiveOrAssign = 66,
    Extension = 52,
    Goto = 53,
    GreaterThan = 15,
    GreaterThanOrEqual = 16,
    Increment = 54,
    Index = 55,
    Invoke = 17,
    IsFalse = 84,
    IsTrue = 83,
    Label = 56,
    Lambda = 18,
    LeftShift = 19,
    LeftShiftAssign = 67,
    LessThan = 20,
    LessThanOrEqual = 21,
    ListInit = 22,
    Loop = 58,
    MemberAccess = 23,
    MemberInit = 24,
    Modulo = 25,
    ModuloAssign = 68,
    Multiply = 26,
    MultiplyAssign = 69,
    MultiplyAssignChecked = 75,
    MultiplyChecked = 27,
    Negate = 28,
    NegateChecked = 30,
    New = 31,
    NewArrayBounds = 33,
    NewArrayInit = 32,
    Not = 34,
    NotEqual = 35,
    OnesComplement = 82,
    Or = 36,
    OrAssign = 70,
    OrElse = 37,
    Parameter = 38,
    PostDecrementAssign = 80,
    PostIncrementAssign = 79,
    Power = 39,
    PowerAssign = 71,
    PreDecrementAssign = 78,
    PreIncrementAssign = 77,
    Quote = 40,
    RightShift = 41,
    RightShiftAssign = 72,
    RuntimeVariables = 57,
    Subtract = 42,
    SubtractAssign = 73,
    SubtractAssignChecked = 76,
    SubtractChecked = 43,
    Switch = 59,
    Throw = 60,
    Try = 61,
    TypeAs = 44,
    TypeEqual = 81,
    TypeIs = 45,
    UnaryPlus = 29,
    Unbox = 62,
  }
  public abstract class ExpressionVisitor {
    protected ExpressionVisitor();
    public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes);
    public virtual Expression Visit(Expression node);
    public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor);
    public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression;
    public T VisitAndConvert<T>(T node, string callerName) where T : Expression;
    protected internal virtual Expression VisitBinary(BinaryExpression node);
    protected internal virtual Expression VisitBlock(BlockExpression node);
    protected virtual CatchBlock VisitCatchBlock(CatchBlock node);
    protected internal virtual Expression VisitConditional(ConditionalExpression node);
    protected internal virtual Expression VisitConstant(ConstantExpression node);
    protected internal virtual Expression VisitDebugInfo(DebugInfoExpression node);
    protected internal virtual Expression VisitDefault(DefaultExpression node);
    protected virtual ElementInit VisitElementInit(ElementInit node);
    protected internal virtual Expression VisitExtension(Expression node);
    protected internal virtual Expression VisitGoto(GotoExpression node);
    protected internal virtual Expression VisitIndex(IndexExpression node);
    protected internal virtual Expression VisitInvocation(InvocationExpression node);
    protected internal virtual Expression VisitLabel(LabelExpression node);
    protected virtual LabelTarget VisitLabelTarget(LabelTarget node);
    protected internal virtual Expression VisitLambda<T>(Expression<T> node);
    protected internal virtual Expression VisitListInit(ListInitExpression node);
    protected internal virtual Expression VisitLoop(LoopExpression node);
    protected internal virtual Expression VisitMember(MemberExpression node);
    protected virtual MemberAssignment VisitMemberAssignment(MemberAssignment node);
    protected virtual MemberBinding VisitMemberBinding(MemberBinding node);
    protected internal virtual Expression VisitMemberInit(MemberInitExpression node);
    protected virtual MemberListBinding VisitMemberListBinding(MemberListBinding node);
    protected virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node);
    protected internal virtual Expression VisitMethodCall(MethodCallExpression node);
    protected internal virtual Expression VisitNew(NewExpression node);
    protected internal virtual Expression VisitNewArray(NewArrayExpression node);
    protected internal virtual Expression VisitParameter(ParameterExpression node);
    protected internal virtual Expression VisitRuntimeVariables(RuntimeVariablesExpression node);
    protected internal virtual Expression VisitSwitch(SwitchExpression node);
    protected virtual SwitchCase VisitSwitchCase(SwitchCase node);
    protected internal virtual Expression VisitTry(TryExpression node);
    protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node);
    protected internal virtual Expression VisitUnary(UnaryExpression node);
  }
  public sealed class GotoExpression : Expression {
    public GotoExpressionKind Kind { get; }
    public sealed override ExpressionType NodeType { get; }
    public LabelTarget Target { get; }
    public sealed override Type Type { get; }
    public Expression Value { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public GotoExpression Update(LabelTarget target, Expression value);
  }
  public enum GotoExpressionKind {
    Break = 2,
    Continue = 3,
    Goto = 0,
    Return = 1,
  }
  public interface IArgumentProvider {
    int ArgumentCount { get; }
    Expression GetArgument(int index);
  }
  public interface IDynamicExpression : IArgumentProvider {
    Type DelegateType { get; }
    object CreateCallSite();
    Expression Rewrite(Expression[] args);
  }
  public sealed class IndexExpression : Expression, IArgumentProvider {
    public int ArgumentCount { get; }
    public ReadOnlyCollection<Expression> Arguments { get; }
    public PropertyInfo Indexer { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression Object { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public Expression GetArgument(int index);
    public IndexExpression Update(Expression @object, IEnumerable<Expression> arguments);
  }
  public sealed class InvocationExpression : Expression, IArgumentProvider {
    public int ArgumentCount { get; }
    public ReadOnlyCollection<Expression> Arguments { get; }
    public Expression Expression { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public Expression GetArgument(int index);
    public InvocationExpression Update(Expression expression, IEnumerable<Expression> arguments);
  }
  public sealed class LabelExpression : Expression {
    public Expression DefaultValue { get; }
    public sealed override ExpressionType NodeType { get; }
    public LabelTarget Target { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public LabelExpression Update(LabelTarget target, Expression defaultValue);
  }
  public sealed class LabelTarget {
    public string Name { get; }
    public Type Type { get; }
    public override string ToString();
  }
  public abstract class LambdaExpression : Expression {
    public Expression Body { get; }
    public string Name { get; }
    public sealed override ExpressionType NodeType { get; }
    public ReadOnlyCollection<ParameterExpression> Parameters { get; }
    public Type ReturnType { get; }
    public bool TailCall { get; }
    public sealed override Type Type { get; }
    public Delegate Compile();
  }
  public sealed class ListInitExpression : Expression {
    public override bool CanReduce { get; }
    public ReadOnlyCollection<ElementInit> Initializers { get; }
    public NewExpression NewExpression { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public override Expression Reduce();
    public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers);
  }
  public sealed class LoopExpression : Expression {
    public Expression Body { get; }
    public LabelTarget BreakLabel { get; }
    public LabelTarget ContinueLabel { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body);
  }
  public sealed class MemberAssignment : MemberBinding {
    public Expression Expression { get; }
    public MemberAssignment Update(Expression expression);
  }
  public abstract class MemberBinding {
    protected MemberBinding(MemberBindingType type, MemberInfo member);
    public MemberBindingType BindingType { get; }
    public MemberInfo Member { get; }
    public override string ToString();
  }
  public enum MemberBindingType {
    Assignment = 0,
    ListBinding = 2,
    MemberBinding = 1,
  }
  public class MemberExpression : Expression {
    public Expression Expression { get; }
    public MemberInfo Member { get; }
    public sealed override ExpressionType NodeType { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public MemberExpression Update(Expression expression);
  }
  public sealed class MemberInitExpression : Expression {
    public ReadOnlyCollection<MemberBinding> Bindings { get; }
    public override bool CanReduce { get; }
    public NewExpression NewExpression { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public override Expression Reduce();
    public MemberInitExpression Update(NewExpression newExpression, IEnumerable<MemberBinding> bindings);
  }
  public sealed class MemberListBinding : MemberBinding {
    public ReadOnlyCollection<ElementInit> Initializers { get; }
    public MemberListBinding Update(IEnumerable<ElementInit> initializers);
  }
  public sealed class MemberMemberBinding : MemberBinding {
    public ReadOnlyCollection<MemberBinding> Bindings { get; }
    public MemberMemberBinding Update(IEnumerable<MemberBinding> bindings);
  }
  public class MethodCallExpression : Expression, IArgumentProvider {
    public virtual int ArgumentCount { get; }
    public ReadOnlyCollection<Expression> Arguments { get; }
    public MethodInfo Method { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression Object { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public virtual Expression GetArgument(int index);
    public MethodCallExpression Update(Expression @object, IEnumerable<Expression> arguments);
  }
  public class NewArrayExpression : Expression {
    public ReadOnlyCollection<Expression> Expressions { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public NewArrayExpression Update(IEnumerable<Expression> expressions);
  }
  public class NewExpression : Expression, IArgumentProvider {
    public int ArgumentCount { get; }
    public ReadOnlyCollection<Expression> Arguments { get; }
    public ConstructorInfo Constructor { get; }
    public ReadOnlyCollection<MemberInfo> Members { get; }
    public sealed override ExpressionType NodeType { get; }
    public override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public Expression GetArgument(int index);
    public NewExpression Update(IEnumerable<Expression> arguments);
  }
  public class ParameterExpression : Expression {
    public bool IsByRef { get; }
    public string Name { get; }
    public sealed override ExpressionType NodeType { get; }
    public override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
  }
  public sealed class RuntimeVariablesExpression : Expression {
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    public ReadOnlyCollection<ParameterExpression> Variables { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public RuntimeVariablesExpression Update(IEnumerable<ParameterExpression> variables);
  }
  public sealed class SwitchCase {
    public Expression Body { get; }
    public ReadOnlyCollection<Expression> TestValues { get; }
    public override string ToString();
    public SwitchCase Update(IEnumerable<Expression> testValues, Expression body);
  }
  public sealed class SwitchExpression : Expression {
    public ReadOnlyCollection<SwitchCase> Cases { get; }
    public MethodInfo Comparison { get; }
    public Expression DefaultBody { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression SwitchValue { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public SwitchExpression Update(Expression switchValue, IEnumerable<SwitchCase> cases, Expression defaultBody);
  }
  public class SymbolDocumentInfo {
    public virtual Guid DocumentType { get; }
    public string FileName { get; }
    public virtual Guid Language { get; }
    public virtual Guid LanguageVendor { get; }
  }
  public sealed class TryExpression : Expression {
    public Expression Body { get; }
    public Expression Fault { get; }
    public Expression Finally { get; }
    public ReadOnlyCollection<CatchBlock> Handlers { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault);
  }
  public sealed class TypeBinaryExpression : Expression {
    public Expression Expression { get; }
    public sealed override ExpressionType NodeType { get; }
    public sealed override Type Type { get; }
    public Type TypeOperand { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public TypeBinaryExpression Update(Expression expression);
  }
  public sealed class UnaryExpression : Expression {
    public override bool CanReduce { get; }
    public bool IsLifted { get; }
    public bool IsLiftedToNull { get; }
    public MethodInfo Method { get; }
    public sealed override ExpressionType NodeType { get; }
    public Expression Operand { get; }
    public sealed override Type Type { get; }
    protected internal override Expression Accept(ExpressionVisitor visitor);
    public override Expression Reduce();
    public UnaryExpression Update(Expression operand);
  }
}
namespace System.Runtime.CompilerServices {
  public sealed class Closure {
    public readonly object[] Constants;
    public readonly object[] Locals;
    public Closure(object[] constants, object[] locals);
  }
  public interface IRuntimeVariables {
    int Count { get; }
    object this[int index] { get; set; }
  }
  public static class RuntimeOps {
    public static IRuntimeVariables CreateRuntimeVariables();
    public static IRuntimeVariables CreateRuntimeVariables(object[] data, long[] indexes);
    public static IRuntimeVariables MergeRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes);
    public static Expression Quote(Expression expression, object hoistedLocals, object[] locals);
  }
}
