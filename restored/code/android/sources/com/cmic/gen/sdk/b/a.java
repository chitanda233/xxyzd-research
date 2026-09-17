package com.cmic.gen.sdk.b;

import android.content.ContentResolver;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.telephony.SubscriptionManager;
import com.cmic.gen.sdk.f.c;
import com.cmic.gen.sdk.f.n;

/* JADX INFO: compiled from: UMCTelephonyManagement.java */
/* JADX INFO: loaded from: classes2.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static a f2064a;
    private static long b;
    private C0345a c = null;

    /* JADX INFO: renamed from: com.cmic.gen.sdk.b.a$a, reason: collision with other inner class name */
    /* JADX INFO: compiled from: UMCTelephonyManagement.java */
    public static class C0345a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private int f2065a = -1;
        private int b = -1;

        public int a() {
            return this.b;
        }
    }

    private a() {
    }

    public static a a() {
        if (f2064a == null) {
            f2064a = new a();
        }
        return f2064a;
    }

    public C0345a b() {
        C0345a c0345a = this.c;
        return c0345a == null ? new C0345a() : c0345a;
    }

    public void a(Context context, boolean z) {
        long jCurrentTimeMillis = System.currentTimeMillis() - b;
        if (jCurrentTimeMillis >= 5000 || jCurrentTimeMillis <= 0) {
            this.c = new C0345a();
            if (z) {
                a(context);
                if (n.e() && n.d()) {
                    c.b("UMCTelephonyManagement", "华为手机兼容性处理");
                    if (this.c.b == 0 || this.c.b == 1) {
                        if (this.c.f2065a == -1) {
                            C0345a c0345a = this.c;
                            c0345a.f2065a = c0345a.b;
                        }
                        this.c.b = -1;
                    }
                    if (this.c.f2065a != -1 || this.c.b != -1) {
                        b(context);
                    }
                }
                b = System.currentTimeMillis();
            }
        }
    }

    private void a(Context context) {
        SubscriptionManager subscriptionManagerFrom = SubscriptionManager.from(context.getApplicationContext());
        if (subscriptionManagerFrom != null) {
            try {
                if (this.c.f2065a == -1) {
                    this.c.b = SubscriptionManager.getDefaultDataSubscriptionId();
                    c.b("UMCTelephonyManagement", "android 7.0及以上手机getDefaultDataSubscriptionId适配成功: dataSubId = " + this.c.b);
                    return;
                }
            } catch (Exception unused) {
                c.a("UMCTelephonyManagement", "android 7.0及以上手机getDefaultDataSubscriptionId适配失败");
            }
            try {
                Object objInvoke = subscriptionManagerFrom.getClass().getMethod("getDefaultDataSubId", new Class[0]).invoke(subscriptionManagerFrom, new Object[0]);
                if ((objInvoke instanceof Integer) || (objInvoke instanceof Long)) {
                    this.c.b = ((Integer) objInvoke).intValue();
                    c.b("UMCTelephonyManagement", "android 7.0以下手机getDefaultDataSubId适配成功: dataSubId = " + this.c.b);
                    return;
                }
            } catch (Exception unused2) {
                c.a("UMCTelephonyManagement", "readDefaultDataSubId-->getDefaultDataSubId 反射出错");
            }
            try {
                Object objInvoke2 = subscriptionManagerFrom.getClass().getMethod("getDefaultDataSubscriptionId", new Class[0]).invoke(subscriptionManagerFrom, new Object[0]);
                if ((objInvoke2 instanceof Integer) || (objInvoke2 instanceof Long)) {
                    this.c.b = ((Integer) objInvoke2).intValue();
                    c.b("UMCTelephonyManagement", "反射getDefaultDataSubscriptionId适配成功: dataSubId = " + this.c.b);
                }
            } catch (Exception unused3) {
                c.a("UMCTelephonyManagement", "getDefaultDataSubscriptionId-->getDefaultDataSubscriptionId 反射出错");
            }
        }
    }

    /* JADX WARN: Code duplicated, block: B:22:0x008b A[PHI: r11
  0x008b: PHI (r11v4 android.database.Cursor) = (r11v2 android.database.Cursor), (r11v6 android.database.Cursor) binds: [B:21:0x0089, B:18:0x0081] A[DONT_GENERATE, DONT_INLINE]] */
    private void b(Context context) {
        c.b("UMCTelephonyManagement", "readSimInfoDbStart");
        Uri uri = Uri.parse("content://telephony/siminfo");
        ContentResolver contentResolver = context.getContentResolver();
        Cursor cursorQuery = null;
        try {
            try {
                cursorQuery = contentResolver.query(uri, new String[]{"_id", "sim_id"}, "sim_id>=?", new String[]{"0"}, null);
                if (cursorQuery != null) {
                    while (cursorQuery.moveToNext()) {
                        int i = cursorQuery.getInt(cursorQuery.getColumnIndex("sim_id"));
                        int i2 = cursorQuery.getInt(cursorQuery.getColumnIndex("_id"));
                        if (this.c.f2065a == -1 && this.c.b != -1 && this.c.b == i2) {
                            this.c.f2065a = i;
                            c.b("UMCTelephonyManagement", "通过读取sim db获取数据流量卡的卡槽值：" + i);
                        }
                        if (this.c.f2065a == i) {
                            this.c.b = i2;
                        }
                    }
                }
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
            } catch (Exception unused) {
                c.a("UMCTelephonyManagement", "readSimInfoDb error");
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
            }
            c.b("UMCTelephonyManagement", "readSimInfoDbEnd");
        } catch (Throwable th) {
            if (cursorQuery != null) {
                cursorQuery.close();
            }
            throw th;
        }
    }
}
