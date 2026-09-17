package com.alipay.sdk.m.f0;

import android.content.Context;
import com.kuaishou.weapon.p0.bo;

/* JADX INFO: loaded from: classes.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static a f283a = new a();

    public static a a() {
        return f283a;
    }

    public String a(Context context) {
        try {
            return context.getPackageManager().getPackageInfo(context.getPackageName(), 16).versionName;
        } catch (Exception unused) {
            return bo.e;
        }
    }
}
