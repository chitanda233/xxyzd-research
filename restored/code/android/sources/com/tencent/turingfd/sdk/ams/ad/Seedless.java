package com.tencent.turingfd.sdk.ams.ad;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Seedless {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile Object f3889a;

    public abstract Object a();

    public final Object b() {
        Object objA;
        Object obj = this.f3889a;
        if (obj != null) {
            return obj;
        }
        synchronized (this) {
            objA = this.f3889a;
            if (objA == null) {
                objA = a();
                this.f3889a = objA;
            }
        }
        return objA;
    }
}
