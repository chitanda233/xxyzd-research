package com.qq.e.comm.managers.devtool;

import android.content.Context;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes3.dex */
public class DevTools {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2994a;

    public String getDemoGameUrl() {
        String str = this.f2994a;
        this.f2994a = null;
        return str;
    }

    public void testDemoGame(Context context, String str) {
        if (!TextUtils.isEmpty(str) && context.getPackageName().equals("com.qq.e.union.demo.union")) {
            this.f2994a = str;
        }
    }
}
