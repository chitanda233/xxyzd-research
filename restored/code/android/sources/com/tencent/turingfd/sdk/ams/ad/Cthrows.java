package com.tencent.turingfd.sdk.ams.ad;

import android.os.Handler;
import android.view.View;
import android.view.ViewTreeObserver;
import android.view.Window;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

/* JADX INFO: renamed from: com.tencent.turingfd.sdk.ams.ad.throws, reason: invalid class name */
/* JADX INFO: loaded from: classes4.dex */
public final class Cthrows implements ViewTreeObserver.OnPreDrawListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final /* synthetic */ Window f3965a;
    public final /* synthetic */ Cdefault b;
    public final /* synthetic */ String c;

    public Cthrows(Window window, Cdefault cdefault, String str) {
        this.f3965a = window;
        this.b = cdefault;
        this.c = str;
    }

    @Override // android.view.ViewTreeObserver.OnPreDrawListener
    public final boolean onPreDraw() {
        Object objInvoke;
        Object objA;
        try {
            View decorView = this.f3965a.getDecorView();
            decorView.getViewTreeObserver().removeOnPreDrawListener(this);
            Object objInvoke2 = null;
            try {
                Method declaredMethod = View.class.getDeclaredMethod("getViewRootImpl", null);
                declaredMethod.setAccessible(true);
                objInvoke = declaredMethod.invoke(decorView, null);
            } catch (Throwable unused) {
                objInvoke = null;
            }
            if (objInvoke == null) {
                return true;
            }
            try {
                Method methodA = Filbert.a((Class) objInvoke.getClass(), "getAccessibilityInteractionController", (Class[]) null);
                if (methodA != null) {
                    objInvoke2 = methodA.invoke(objInvoke, null);
                }
            } catch (Throwable unused2) {
            }
            if (objInvoke2 == null || (objA = Filbert.a(objInvoke2.getClass(), "mHandler", objInvoke2)) == null) {
                return true;
            }
            Field declaredField = Handler.class.getDeclaredField("mCallback");
            declaredField.setAccessible(true);
            Handler.Callback callback = (Handler.Callback) declaredField.get(objA);
            if (callback instanceof Celse) {
                return true;
            }
            declaredField.set(objA, new Celse(callback, this.b, this.c));
        } catch (Throwable unused3) {
        }
        return true;
    }
}
