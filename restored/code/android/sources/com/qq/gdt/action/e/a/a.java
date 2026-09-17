package com.qq.gdt.action.e.a;

import android.os.Handler;
import android.os.Looper;
import com.qq.gdt.action.e.b.i;

/* JADX INFO: loaded from: classes3.dex */
public abstract class a<T> implements com.qq.gdt.action.e.b.b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Handler f3042a = new Handler(Looper.getMainLooper());
    private boolean b;

    public a(boolean z) {
        this.b = z;
    }

    private void b(final int i, final T t) {
        f3042a.post(new Runnable() { // from class: com.qq.gdt.action.e.a.a.1
            /* JADX WARN: Multi-variable type inference failed */
            /* JADX WARN: Type inference fix 'apply assigned field type' failed
            java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$PrimitiveArg
            	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
            	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
            	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
            	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
            	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
            	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
            	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
             */
            @Override // java.lang.Runnable
            public void run() {
                a.this.a(i, t);
            }
        });
    }

    private void c(final Throwable th) {
        f3042a.post(new Runnable() { // from class: com.qq.gdt.action.e.a.a.2
            @Override // java.lang.Runnable
            public void run() {
                a.this.b(th);
            }
        });
    }

    public abstract void a(int i, T t);

    @Override // com.qq.gdt.action.e.b.b
    public void a(i iVar) {
        try {
            int iC = iVar.c();
            T tB = b(iVar);
            if (this.b) {
                b(iC, tB);
            } else {
                a(iC, tB);
            }
        } catch (Throwable th) {
            com.qq.gdt.action.c.a aVar = new com.qq.gdt.action.c.a("Response parse error", th);
            if (this.b) {
                c(aVar);
            } else {
                b(aVar);
            }
        }
    }

    @Override // com.qq.gdt.action.e.b.b
    public void a(Throwable th) {
        if (this.b) {
            c(th);
        } else {
            b(th);
        }
    }

    public abstract T b(i iVar) throws Exception;

    public abstract void b(Throwable th);
}
