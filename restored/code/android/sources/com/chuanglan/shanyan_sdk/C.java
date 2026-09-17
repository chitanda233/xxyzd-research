package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoCallbacks;

/* JADX INFO: loaded from: classes2.dex */
public class C implements GetPhoneInfoCallbacks {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1932a;
    private boolean b = false;

    public C(Context context) {
        this.f1932a = context;
    }

    @Override // com.chuanglan.shanyan_sdk.listener.GetPhoneInfoCallbacks
    public void getPhoneInfoFailed(int i, int i2, String str, String str2, int i3, String str3, long j, long j2, long j3) {
        char c;
        try {
            Q.a("ProcessShanYanLogger", "preInfoFailed innerCode", Integer.valueOf(i2), Boolean.valueOf(this.b), Integer.valueOf(i3), "innerDesc", str2);
            j0.a();
            t0.h().d();
            String strA = AbstractC0600f.a(i2, str2, str, str3);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            try {
                if (i3 != 3) {
                    if (i3 != 4) {
                        t0.h().a(i, i2, strA, str2, str3, i3, 2, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                    } else {
                        D.a();
                        AbstractC0606l.w.set(AbstractC0606l.r);
                        t0.h().c(i, i2, strA, str2, str3, 2, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                    }
                } else {
                    if (this.b) {
                        return;
                    }
                    try {
                        this.b = true;
                        AbstractC0606l.v.set(AbstractC0606l.r);
                        AbstractC0606l.U.set(true);
                        c = 1;
                        try {
                            t0.h().a(i, i2, strA, str2, str3, 1, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                        } catch (Exception e) {
                            e = e;
                            e.printStackTrace();
                            Object[] objArr = new Object[2];
                            objArr[0] = "getPhoneInfoFailed Exception";
                            objArr[c] = e;
                            Q.d("ExceptionShanYanLogger", objArr);
                        }
                    } catch (Exception e2) {
                        e = e2;
                        c = 1;
                    }
                }
            } catch (Exception e3) {
                e = e3;
                c = 1;
            }
        } catch (Exception e4) {
            e = e4;
            c = 1;
        }
    }

    @Override // com.chuanglan.shanyan_sdk.listener.GetPhoneInfoCallbacks
    public void getPhoneInfoSuccessed(int i, int i2, String str, String str2, int i3, long j, long j2, long j3) {
        char c;
        try {
            Q.a("ProcessShanYanLogger", "preInfoSuccess", Boolean.valueOf(this.b), Integer.valueOf(i3));
            j0.a();
            p0.b(this.f1932a, "cl_jm_f4", true);
            p0.b(this.f1932a, "cl_jm_f1", true);
            AbstractC0610p.d(this.f1932a, "scripCache_sub");
            AbstractC0610p.c(this.f1932a, "scripCache_sub");
            String strA = AbstractC0600f.a(i2, str2, str, this.f1932a);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            try {
                if (i3 != 3) {
                    if (i3 != 4) {
                        t0.h().a(i, i2, strA, str2, AbstractC0606l.m, i3, 2, AbstractC0606l.s, j, jUptimeMillis2, jUptimeMillis);
                    } else {
                        E.a().a(AbstractC0606l.m, j, j2, j3);
                    }
                } else {
                    if (this.b) {
                        return;
                    }
                    c = 1;
                    try {
                        this.b = true;
                        T.a().a(j, j2, j3);
                    } catch (Exception e) {
                        e = e;
                        e.printStackTrace();
                        Object[] objArr = new Object[2];
                        objArr[0] = "getPhoneInfoSuccessed Exception";
                        objArr[c] = e;
                        Q.d("ExceptionShanYanLogger", objArr);
                    }
                }
            } catch (Exception e2) {
                e = e2;
                c = 1;
            }
        } catch (Exception e3) {
            e = e3;
            c = 1;
        }
    }
}
