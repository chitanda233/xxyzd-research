package com.tencent.turingfd.sdk.ams.ad;

import android.app.Application;
import android.content.Context;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.catch, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public abstract class Ccatch {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static Context f3917a;

    public static synchronized Context a() {
        return f3917a;
    }

    public static synchronized Application b() {
        Context context = f3917a;
        if (!(context instanceof Application)) {
            return null;
        }
        return (Application) context;
    }
}
