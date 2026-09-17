package com.bytedance.ads.convert.flat.e;

import com.bytedance.ads.convert.flat.a.f;

/* JADX INFO: loaded from: classes2.dex */
public final class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final C0324a f1693a;
    public static final f b;
    public static final String c;
    public static C0324a d;
    public static f e;
    public static long f;
    public static volatile long g;
    public static final a h = new a();

    /* JADX INFO: renamed from: com.bytedance.ads.convert.flat.e.a$a, reason: collision with other inner class name */
    public static final class C0324a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final boolean f1694a;
        public final long b;

        public C0324a() {
            this(false, 0L, 3);
        }

        public C0324a(boolean z, long j) {
            this.f1694a = z;
            this.b = j;
        }

        public /* synthetic */ C0324a(boolean z, long j, int i) {
            this((i & 1) != 0 ? false : z, (i & 2) != 0 ? 200L : j);
        }

        public boolean equals(Object obj) {
            if (this == obj) {
                return true;
            }
            if (!(obj instanceof C0324a)) {
                return false;
            }
            C0324a c0324a = (C0324a) obj;
            return this.f1694a == c0324a.f1694a && this.b == c0324a.b;
        }

        /* JADX WARN: Multi-variable type inference failed */
        /* JADX WARN: Type inference failed for: r0v1, types: [int] */
        /* JADX WARN: Type inference failed for: r0v4 */
        /* JADX WARN: Type inference failed for: r0v5 */
        public int hashCode() {
            boolean z = this.f1694a;
            ?? r0 = z;
            if (z) {
                r0 = 1;
            }
            long j = this.b;
            return (r0 * 31) + ((int) (j ^ (j >>> 32)));
        }

        public String toString() {
            return "INodeConfig(enable=" + this.f1694a + ", timeout=" + this.b + ")";
        }
    }

    static {
        C0324a c0324a = new C0324a(false, 200L);
        f1693a = c0324a;
        f fVar = new f(false, null, null, null, 15);
        b = fVar;
        c = "https://analytics.oceanengine.com/sdk/app/config";
        d = c0324a;
        e = fVar;
        f = 60000L;
        g = -1L;
    }
}
