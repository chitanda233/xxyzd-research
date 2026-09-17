package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.text.TextUtils;
import java.io.File;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.atomic.AtomicBoolean;
import java.util.concurrent.locks.ReentrantReadWriteLock;

/* JADX INFO: loaded from: classes4.dex */
public final class q {
    public static final String d = Cinstanceof.a(Cinstanceof.Y0);
    public static final long e = TimeUnit.HOURS.toMillis(32);
    public static final q f = new q();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile Auriga f3956a = null;
    public final AtomicBoolean b = new AtomicBoolean(false);
    public final ReentrantReadWriteLock c = new ReentrantReadWriteLock();

    public static String b(String str) {
        Context context;
        synchronized (Ccatch.class) {
            context = Ccatch.f3917a;
        }
        File dir = context.getDir("turingfd", 0);
        if (dir == null) {
            return "";
        }
        StringBuilder sbAppend = new StringBuilder().append(dir.getAbsolutePath());
        String str2 = File.separator;
        File file = new File(sbAppend.append(str2).append("12").toString());
        return (file.exists() || file.mkdirs()) ? file.getAbsolutePath() + str2 + Olive.f3871a + "_ad_" + str : "";
    }

    public final void a(Auriga auriga, boolean z) {
        this.c.writeLock().lock();
        if (z) {
            try {
                Phoenix phoenix = new Phoenix();
                auriga.a(phoenix);
                byte[] bArr = new byte[phoenix.f3876a.position()];
                System.arraycopy(phoenix.f3876a.array(), 0, bArr, 0, phoenix.f3876a.position());
                if (CanisMinor.a(b("2"), Cstrictfp.b(Cprivate.a(bArr), Cstrictfp.a()))) {
                    File file = new File(b("1"));
                    if (file.exists()) {
                        file.delete();
                    }
                }
            } finally {
                this.f3956a = auriga;
                this.c.writeLock().unlock();
            }
        }
    }

    public final HashSet c() {
        synchronized (e.class) {
        }
        String strA = !d() ? Cinstanceof.a(Cinstanceof.g1) : a("p_l_h_l");
        if (TextUtils.isEmpty(strA)) {
            return null;
        }
        HashSet hashSet = new HashSet();
        Collections.addAll(hashSet, strA.split(","));
        return hashSet;
    }

    public final boolean d() {
        return b() != null;
    }

    public static Auriga b(String str, boolean z) {
        try {
            byte[] bArrB = CanisMinor.b(str);
            if (bArrB == null) {
                return null;
            }
            if (z && ((bArrB = Cprivate.b(Cstrictfp.a(bArrB, Cstrictfp.a()))) == null || bArrB.length == 0)) {
                return null;
            }
            Auriga auriga = new Auriga();
            auriga.a(new Perseus(bArrB));
            return auriga;
        } catch (Throwable unused) {
            return null;
        }
    }

    public final String a(String str) {
        Map map;
        Auriga aurigaB = b();
        if (aurigaB == null || (map = aurigaB.g) == null) {
            return null;
        }
        return (String) map.get(str);
    }

    public final Auriga b() {
        this.c.readLock().lock();
        try {
            if (this.b.get()) {
                Auriga auriga = this.f3956a;
                this.c.readLock().unlock();
                return auriga;
            }
            synchronized (this.b) {
                if (this.b.get()) {
                    Auriga auriga2 = this.f3956a;
                    this.c.readLock().unlock();
                    return auriga2;
                }
                Auriga aurigaB = b(b("2"), true);
                if (aurigaB == null) {
                    aurigaB = b(b("1"), false);
                }
                this.f3956a = aurigaB;
                this.b.set(true);
                Auriga auriga3 = this.f3956a;
                this.c.readLock().unlock();
                return auriga3;
            }
        } catch (Throwable th) {
            this.c.readLock().unlock();
            throw th;
        }
    }

    public final boolean a(String str, boolean z) {
        String strA = a(str);
        if (strA == null) {
            return z;
        }
        try {
            return Integer.parseInt(strA) > 0;
        } catch (NumberFormatException unused) {
            return z;
        }
    }

    public final String a(Context context) {
        String strA;
        if (!d()) {
            strA = Cinstanceof.a(Cinstanceof.f1);
        } else {
            strA = a("a_f_ok_c");
        }
        String strA2 = a("a_f_ok_s");
        HashSet<String> hashSet = new HashSet();
        hashSet.add(Cinstanceof.a(Csynchronized.b));
        hashSet.add(Cinstanceof.a(Csynchronized.c));
        String strA3 = Cinstanceof.a(Csynchronized.d);
        hashSet.add(strA3);
        if (!TextUtils.isEmpty(strA)) {
            for (String str : strA.split(",")) {
                if (!TextUtils.isEmpty(str)) {
                    hashSet.add(str);
                }
            }
        }
        if (!TextUtils.isEmpty(strA2)) {
            synchronized (e.class) {
            }
            if (Cranberry.a()) {
                for (String str2 : strA2.split(",")) {
                    if (!TextUtils.isEmpty(str2)) {
                        hashSet.add(str2);
                    }
                }
            }
        }
        if (hashSet.isEmpty()) {
            return null;
        }
        StringBuilder sb = new StringBuilder();
        for (String str3 : hashSet) {
            if (!TextUtils.isEmpty(str3)) {
                if (sb.length() > 0) {
                    sb.append(",");
                }
                if (str3.contains(strA3)) {
                    str3 = str3.replace(strA3, context.getFilesDir().getParent()) + com.alipay.sdk.m.y.l.b + str3;
                }
                sb.append(str3);
            }
        }
        return sb.toString();
    }

    public final HashMap a() {
        HashMap map = new HashMap();
        String strA = a("c_f_s_l");
        String strA2 = Cinstanceof.a(Csynchronized.f3963a);
        if (!TextUtils.isEmpty(strA)) {
            strA2 = strA + "," + strA2;
        }
        for (String str : strA2.split(",")) {
            if (!str.isEmpty()) {
                String[] strArrSplit = str.split(":");
                if (strArrSplit.length >= 2) {
                    String str2 = strArrSplit[0];
                    Set hashSet = (Set) map.get(str2);
                    if (hashSet == null) {
                        hashSet = new HashSet();
                        map.put(str2, hashSet);
                    }
                    hashSet.addAll(Arrays.asList(strArrSplit).subList(1, strArrSplit.length));
                }
            }
        }
        return map;
    }
}
