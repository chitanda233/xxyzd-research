package com.chuanglan.shanyan_sdk;

import android.os.SystemClock;
import com.chuanglan.shanyan_sdk.listener.AuthCallbacks;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.i, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public class C0603i implements AuthCallbacks {
    @Override // com.chuanglan.shanyan_sdk.listener.AuthCallbacks
    public void authFailed(int i, int i2, String str, String str2, int i3, String str3, long j, long j2, long j3) {
        String strA = AbstractC0600f.a(i2, str2, str);
        long jUptimeMillis = SystemClock.uptimeMillis() - j3;
        long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
        AbstractC0606l.x.set(AbstractC0606l.r);
        t0.h().b(i, i2, strA, str2, str3, 11, AbstractC0606l.r, j, jUptimeMillis2, jUptimeMillis);
    }

    @Override // com.chuanglan.shanyan_sdk.listener.AuthCallbacks
    public void authSuccessed(int i, int i2, String str, String str2, int i3, String str3, long j, long j2, long j3) {
        long jUptimeMillis = SystemClock.uptimeMillis() - j3;
        long jUptimeMillis2 = SystemClock.uptimeMillis() - j2;
        AbstractC0606l.x.set(AbstractC0606l.s);
        t0.h().b(i, i2, str, str2, str3, 11, AbstractC0606l.s, j, jUptimeMillis2, jUptimeMillis);
    }
}
