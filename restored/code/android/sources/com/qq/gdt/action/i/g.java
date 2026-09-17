package com.qq.gdt.action.i;

import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.ProviderInfo;

/* JADX INFO: loaded from: classes3.dex */
public class g {
    private static volatile g b;
    private volatile boolean c = false;
    private volatile boolean d = false;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public volatile a f3078a = a.NO_CP;

    public enum a {
        UNKNOW,
        CP,
        NO_CP
    }

    public static g a() {
        if (b == null) {
            synchronized (g.class) {
                if (b == null) {
                    b = new g();
                }
            }
        }
        return b;
    }

    public synchronized void a(boolean z) {
        this.d = z;
    }

    public synchronized boolean b() {
        if (this.c) {
            return this.d;
        }
        try {
            boolean z = false;
            o.a("isCpProcess = " + this.d, new Object[0]);
            if (!this.d) {
                o.a("isCpProcess false, need check", new Object[0]);
                PackageInfo packageInfo = com.qq.gdt.action.d.a().g().getPackageManager().getPackageInfo(com.qq.gdt.action.d.a().g().getPackageName(), 8);
                if (packageInfo.providers != null) {
                    for (ProviderInfo providerInfo : packageInfo.providers) {
                        o.a("providerInfo name =" + providerInfo.name, new Object[0]);
                        if (providerInfo.name.contains("GDTInitProvider")) {
                            z = true;
                            break;
                        }
                    }
                }
                if (!z) {
                    this.d = true;
                    this.f3078a = a.UNKNOW;
                }
            }
        } catch (PackageManager.NameNotFoundException e) {
            e.printStackTrace();
        }
        this.c = true;
        return this.d;
    }
}
