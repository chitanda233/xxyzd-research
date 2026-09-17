package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.InitCallbacks;

/* JADX INFO: loaded from: classes2.dex */
public class L implements InitCallbacks {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private Context f1945a;
    private boolean b = false;

    public L(Context context) {
        this.f1945a = context;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v0, types: [com.chuanglan.shanyan_sdk.L] */
    /* JADX WARN: Type inference failed for: r1v1 */
    /* JADX WARN: Type inference failed for: r1v2 */
    /* JADX WARN: Type inference failed for: r1v3 */
    /* JADX WARN: Type inference failed for: r1v4 */
    /* JADX WARN: Type inference failed for: r1v5 */
    /* JADX WARN: Type inference failed for: r1v6 */
    /* JADX WARN: Type inference failed for: r1v7 */
    /* JADX WARN: Type inference failed for: r1v8 */
    @Override // com.chuanglan.shanyan_sdk.listener.InitCallbacks
    public void initFailed(int i, int i2, String str, String str2, int i3, long j, long j2, long j3) {
        ?? r1 = this;
        try {
            String strB = C0616v.g().b(r1.f1945a);
            Q.a("ProcessShanYanLogger", "InitFailed innerCode", Integer.valueOf(i2), "operator", strB, "processName", Integer.valueOf(i3), "msg", str);
            AbstractC0606l.u.set(AbstractC0606l.r);
            String strA = AbstractC0600f.a(i2, str2, str);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            try {
                if (i3 == 2) {
                    r1 = 1;
                    t0.h().a(i, i2, strA, str2, strB, i3, 1, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                } else if (i3 == 3) {
                    r1 = 1;
                    AbstractC0606l.v.set(AbstractC0606l.r);
                    AbstractC0606l.U.set(true);
                    t0.h().a(i, i2, strA, str2, strB, 1, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                } else {
                    if (i3 != 4) {
                        if (i3 == 11) {
                            AbstractC0606l.x.set(AbstractC0606l.r);
                            t0.h().b(i, i2, strA, str2, strB, 1, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                        }
                        M.a();
                        if (r1.b) {
                            return;
                        }
                        r1.b = true;
                        r1 = 1;
                        t0.h().d(i, i2, strA, str2, strB, i3, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                        e.printStackTrace();
                        Object[] objArr = new Object[2];
                        objArr[0] = "initFailed Exception";
                        objArr[r1] = e;
                        Q.d("ExceptionShanYanLogger", objArr);
                        return;
                    }
                    r1 = 1;
                    D.a();
                    AbstractC0606l.w.set(AbstractC0606l.r);
                    t0.h().c(i, i2, strA, str2, strB, 1, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
                }
            } catch (Exception e) {
                e = e;
            }
        } catch (Exception e2) {
            e = e2;
            r1 = 1;
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r14v0 */
    /* JADX WARN: Type inference failed for: r1v0, types: [com.chuanglan.shanyan_sdk.L] */
    @Override // com.chuanglan.shanyan_sdk.listener.InitCallbacks
    public void initSuccessed(int i, int i2, String str, String str2, int i3, long j, long j2, long j3) {
        char c;
        int i4 = this;
        i4 = 2;
        char c2 = 1;
        char c3 = 1;
        char c4 = 1;
        try {
            String strB = C0616v.g().b(i4.f1945a);
            Integer numValueOf = Integer.valueOf(i3);
            Object[] objArr = new Object[2];
            objArr[0] = "initSuccessed processName";
            objArr[c4 == true ? 1 : 0] = numValueOf;
            Q.a("ProcessShanYanLogger", objArr);
            AbstractC0606l.u.set(AbstractC0606l.s);
            N.b().d();
            String strA = AbstractC0600f.a(i2, str2, str);
            long jUptimeMillis = SystemClock.uptimeMillis() - j3;
            long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
            if (-1 == i3) {
                M.a();
                if (i4.b) {
                    return;
                }
                i4.b = c2 == true ? 1 : 0;
                t0.h().d(i, i2, strA, str2, strB, 1, AbstractC0606l.s, j, jUptimeMillis2, jUptimeMillis);
                return;
            }
            try {
                if (i3 == 2 || i3 == 3 || i3 == 4) {
                    k0.b().c(i3, null, j, j2, j3);
                } else {
                    if (i3 == 11) {
                        C0604j.a().c(j, j2, j3);
                    }
                    M.a();
                    if (i4.b) {
                        return;
                    }
                    i4.b = c3 == true ? 1 : 0;
                    t0.h().d(i, i2, strA, str2, strB, i3, AbstractC0606l.s, j, jUptimeMillis2, jUptimeMillis);
                }
            } catch (Exception e) {
                e = e;
                e.printStackTrace();
                Object[] objArr2 = new Object[i4];
                objArr2[0] = "initSuccessed Exception";
                objArr2[c] = e;
                Q.d("ExceptionShanYanLogger", objArr2);
            }
        } catch (Exception e2) {
            e = e2;
            i4 = 2;
            c = 1 == true ? 1 : 0;
        }
    }
}
