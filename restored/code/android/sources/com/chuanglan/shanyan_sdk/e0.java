package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthCallbaks;

/* JADX INFO: loaded from: classes2.dex */
public class e0 implements OpenLoginAuthCallbaks {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1968a;

    public e0(Context context) {
        this.f1968a = context;
    }

    @Override // com.chuanglan.shanyan_sdk.listener.OpenLoginAuthCallbaks
    public void openPageFailed(int i, int i2, String str, String str2, String str3, long j, long j2, long j3) {
        try {
            Q.a("ProcessShanYanLogger", "openPageFailed innerCode", Integer.valueOf(i2), "operator", str3, "msg", str);
            t0.h().d();
            String strA = AbstractC0600f.a(i2, str2, str);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            AbstractC0606l.v.set(AbstractC0606l.r);
            AbstractC0606l.U.set(true);
            t0.h().a(i, i2, strA, str2, str3, 3, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
        } catch (Exception e) {
            e.printStackTrace();
            Q.d("ExceptionShanYanLogger", "openPageFailed Exception", e);
        }
    }

    @Override // com.chuanglan.shanyan_sdk.listener.OpenLoginAuthCallbaks
    public void openPageSuccessed(int i, int i2, String str, String str2, long j, long j2, long j3) {
        try {
            Q.a("ProcessShanYanLogger", "openPageSuccessed innerCode", Integer.valueOf(i2), "operator", AbstractC0606l.m, "msg", str);
            try {
                p0.b(this.f1968a, "cl_jm_f1", true);
                AbstractC0606l.v.set(AbstractC0606l.s);
                long jUptimeMillis = SystemClock.uptimeMillis() - j3;
                t0.h().a(i, i2, AbstractC0600f.a(i2, str2, str), str2, AbstractC0606l.m, 3, AbstractC0606l.s, j, SystemClock.uptimeMillis() - j2, jUptimeMillis);
            } catch (Exception e) {
                e = e;
                e.printStackTrace();
                Q.d("ExceptionShanYanLogger", "openPageSuccessed Exception", e);
            }
        } catch (Exception e2) {
            e = e2;
        }
    }
}
