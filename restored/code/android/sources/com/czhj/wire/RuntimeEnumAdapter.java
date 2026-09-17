package com.czhj.wire;

import com.czhj.wire.WireEnum;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes2.dex */
final class RuntimeEnumAdapter<E extends WireEnum> extends EnumAdapter<E> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Class<E> f2364a;
    private Method b;

    RuntimeEnumAdapter(Class<E> cls) {
        super(cls);
        this.f2364a = cls;
    }

    private Method a() {
        Method method = this.b;
        if (method != null) {
            return method;
        }
        try {
            Method method2 = this.f2364a.getMethod("fromValue", Integer.TYPE);
            this.b = method2;
            return method2;
        } catch (NoSuchMethodException e) {
            throw new AssertionError(e);
        }
    }

    public boolean equals(Object obj) {
        return (obj instanceof RuntimeEnumAdapter) && ((RuntimeEnumAdapter) obj).f2364a == this.f2364a;
    }

    @Override // com.czhj.wire.EnumAdapter
    protected E fromValue(int i) {
        try {
            return (E) a().invoke(null, Integer.valueOf(i));
        } catch (Throwable th) {
            throw new AssertionError(th);
        }
    }

    public int hashCode() {
        return this.f2364a.hashCode();
    }
}
