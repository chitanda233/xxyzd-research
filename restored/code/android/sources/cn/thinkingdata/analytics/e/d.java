package cn.thinkingdata.analytics.e;

import cn.thinkingdata.analytics.h.q;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final TimeUnit f96a;
    private long b;
    private long c = 0;
    private long d;

    public d(TimeUnit timeUnit, long j) {
        this.b = j;
        this.f96a = timeUnit;
    }

    public String a() {
        return b(this.d);
    }

    public String a(long j) {
        return b((j - this.b) + this.c);
    }

    public long b() {
        return this.d;
    }

    /* JADX WARN: Code duplicated, block: B:28:0x0048 A[Catch: Exception -> 0x000c, TryCatch #0 {Exception -> 0x000c, blocks: (B:4:0x0007, B:10:0x0015, B:12:0x001a, B:25:0x0042, B:28:0x0048, B:29:0x004d, B:15:0x0021, B:17:0x0029, B:18:0x002c, B:20:0x0034, B:21:0x0036, B:22:0x0038, B:24:0x003e), top: B:33:0x0005 }] */
    /* JADX WARN: Code duplicated, block: B:29:0x004d A[Catch: Exception -> 0x000c, TRY_LEAVE, TryCatch #0 {Exception -> 0x000c, blocks: (B:4:0x0007, B:10:0x0015, B:12:0x001a, B:25:0x0042, B:28:0x0048, B:29:0x004d, B:15:0x0021, B:17:0x0029, B:18:0x002c, B:20:0x0034, B:21:0x0036, B:22:0x0038, B:24:0x003e), top: B:33:0x0005 }] */
    String b(long j) {
        float f;
        float f2;
        try {
            if (j < 0) {
                return String.valueOf(0);
            }
            if (j > 86400000) {
                return b(86400000L);
            }
            if (this.f96a != TimeUnit.MILLISECONDS) {
                if (this.f96a == TimeUnit.SECONDS) {
                    f2 = j / 1000.0f;
                } else {
                    if (this.f96a == TimeUnit.MINUTES) {
                        f = j / 1000.0f;
                    } else if (this.f96a == TimeUnit.HOURS) {
                        f = (j / 1000.0f) / 60.0f;
                    }
                    f2 = f / 60.0f;
                }
                return f2 < 0.0f ? String.valueOf(0) : String.valueOf(q.a(f2, 3));
            }
            f2 = j;
            if (f2 < 0.0f) {
            }
        } catch (Exception e) {
            e.printStackTrace();
            return String.valueOf(0);
        }
    }

    public long c() {
        return this.c;
    }

    public void c(long j) {
        this.d = j;
    }

    public long d() {
        return this.b;
    }

    public void d(long j) {
        this.c = j;
    }

    public void e(long j) {
        this.b = j;
    }
}
