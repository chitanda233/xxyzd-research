package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.LoginAuthCallbacks;

/* JADX INFO: loaded from: classes2.dex */
public class S implements LoginAuthCallbacks {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1955a;
    private boolean b = false;

    public S(Context context) {
        this.f1955a = context;
    }

    @Override // com.chuanglan.shanyan_sdk.listener.LoginAuthCallbacks
    public void getTokenFailed(int i, int i2, String str, String str2, String str3, long j, long j2, long j3) {
        try {
            Q.a("ProcessShanYanLogger", "getTokenFailed innerCode", Integer.valueOf(i2), Boolean.valueOf(this.b), str3, "msg", str);
            if (this.b) {
                return;
            }
            this.b = true;
            D.a();
            String strA = AbstractC0600f.a(i2, str2, str);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            AbstractC0606l.w.set(AbstractC0606l.r);
            t0.h().c(i, i2, strA, str2, str3, 4, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "getTokenFailed Exception", e);
        }
    }

    @Override // com.chuanglan.shanyan_sdk.listener.LoginAuthCallbacks
    public void getTokenSuccessed(int i, int i2, String str, String str2, long j, long j2, long j3) {
        try {
            Q.a("ProcessShanYanLogger", "getTokenSuccessed innerCode", Integer.valueOf(i2), Boolean.valueOf(this.b), AbstractC0606l.m);
            if (this.b) {
                return;
            }
            this.b = true;
            D.a();
            p0.b(this.f1955a, "cl_jm_f1", true);
            AbstractC0606l.w.set(AbstractC0606l.s);
            t0.h().c(i, i2, str, str2, AbstractC0606l.m, 4, AbstractC0606l.s, j, SystemClock.uptimeMillis() - j2, SystemClock.uptimeMillis() - j3);
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "getTokenSuccessed Exception", e);
        }
    }
}
