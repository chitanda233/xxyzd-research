package com.bykv.vk.component.ttvideo.log;

import android.content.Context;
import com.byazt.nys.PluginConstants;
import com.kuaishou.weapon.p0.t;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public a f1664a;
    public String b;
    public String g;
    public String c = "";
    public String d = "";
    public String e = "";
    public int h = Integer.MIN_VALUE;
    public String f = com.bykv.vk.component.ttvideo.utils.b.a(null);

    c(a aVar, Context context) {
        this.f1664a = aVar;
    }

    public void a() {
        b();
    }

    public void a(String str) {
        this.b = str;
        this.f = com.bykv.vk.component.ttvideo.utils.b.b(str);
    }

    public void b() {
        Map mapVersionInfo;
        a aVar = this.f1664a;
        if (aVar == null || (mapVersionInfo = aVar.versionInfo()) == null) {
            return;
        }
        this.c = (String) mapVersionInfo.get(t.x);
        this.d = (String) mapVersionInfo.get(com.alipay.sdk.m.w.a.v);
        this.e = (String) mapVersionInfo.get(PluginConstants.KEY_SDK_VERSION);
    }

    public void b(String str) {
    }
}
