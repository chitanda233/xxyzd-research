package com.sigmob.sdk.downloader.core.listener.assist;

import android.util.SparseArray;
import com.sigmob.sdk.downloader.core.listener.assist.e.a;
import com.sigmob.sdk.downloader.f;

/* JADX INFO: loaded from: classes3.dex */
public class e<T extends a> implements d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    volatile T f3449a;
    final SparseArray<T> b = new SparseArray<>();
    private Boolean c;
    private final b<T> d;

    /* JADX INFO: Access modifiers changed from: package-private */
    public interface a {
        void a(com.sigmob.sdk.downloader.core.breakpoint.c info);

        int b();
    }

    public interface b<T extends a> {
        T b(int id);
    }

    e(b<T> creator) {
        this.d = creator;
    }

    T a(f fVar, com.sigmob.sdk.downloader.core.breakpoint.c cVar) {
        T t = (T) this.d.b(fVar.c());
        synchronized (this) {
            if (this.f3449a == null) {
                this.f3449a = t;
            } else {
                this.b.put(fVar.c(), t);
            }
            if (cVar != null) {
                t.a(cVar);
            }
        }
        return t;
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void a(boolean isAlwaysRecoverModel) {
        this.c = Boolean.valueOf(isAlwaysRecoverModel);
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public boolean a() {
        Boolean bool = this.c;
        return bool != null && bool.booleanValue();
    }

    T b(f fVar, com.sigmob.sdk.downloader.core.breakpoint.c cVar) {
        T t;
        int iC = fVar.c();
        synchronized (this) {
            t = (this.f3449a == null || this.f3449a.b() != iC) ? null : this.f3449a;
        }
        if (t == null) {
            t = this.b.get(iC);
        }
        return (t == null && a()) ? (T) a(fVar, cVar) : t;
    }

    @Override // com.sigmob.sdk.downloader.core.listener.assist.d
    public void b(boolean isAlwaysRecoverAssistModel) {
        if (this.c == null) {
            this.c = Boolean.valueOf(isAlwaysRecoverAssistModel);
        }
    }

    T c(f fVar, com.sigmob.sdk.downloader.core.breakpoint.c cVar) {
        T t;
        int iC = fVar.c();
        synchronized (this) {
            if (this.f3449a == null || this.f3449a.b() != iC) {
                t = this.b.get(iC);
                this.b.remove(iC);
            } else {
                t = this.f3449a;
                this.f3449a = null;
            }
        }
        if (t == null) {
            t = (T) this.d.b(iC);
            if (cVar != null) {
                t.a(cVar);
            }
        }
        return t;
    }
}
