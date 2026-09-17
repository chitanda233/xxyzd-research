package cn.thinkingdata.analytics.h;

import android.os.SystemClock;
import java.util.Date;

/* JADX INFO: loaded from: classes.dex */
public final class i implements d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final long f118a;
    private final long b = SystemClock.elapsedRealtime();

    public i(long j) {
        this.f118a = j;
    }

    @Override // cn.thinkingdata.analytics.h.d
    public Date a(long j) {
        return new Date((j - this.b) + this.f118a);
    }
}
